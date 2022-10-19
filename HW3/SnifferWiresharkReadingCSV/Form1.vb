Imports System.IO
Imports System.Reflection

Public Class Form1
    Dim Path1 As String
    Private Sub ButtonCustomFile_Click(sender As Object, e As EventArgs) Handles ButtonCustomFile.Click
        Dim o As New OpenFileDialog
        o.ShowDialog()
        If String.IsNullOrWhiteSpace(o.FileName) Then Exit Sub
        Me.RichTextBoxPath.Text = o.FileName
    End Sub

    Private Sub ButtonDefaultFile_Click(sender As Object, e As EventArgs) Handles ButtonDefaultFile.Click

        If RichTextBoxPath.Text = "" Then
            Path1 = Path.Combine(Application.StartupPath, "..\..\WiresharkFile.csv")
            Me.RichTextBoxPath.Text = Path1
        Else
            Path1 = Me.RichTextBoxPath.Text.Trim
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Dim ListOfWiresharkRecordInterval As New List(Of DataPoint_Numeric)

    Private Sub ButtonStream_Click(sender As Object, e As EventArgs) Handles ButtonStream.Click
        ' Define path
        ' Dim Path As String = Me.RichTextBoxPath.Text.Trim
        'Define the Array
        Dim WiresharkRecord As New List(Of Record)
        Using R As New StreamReader(Me.Path1)
            'Estraggo la prima riga
            Dim NameOfVariables As String = R.ReadLine
            Do While Not R.EndOfStream

                'MANUAL PARSING
                Dim Line As String = R.ReadLine
                Dim Values() As String = Line.Split(",".ToCharArray)

                Dim Record As New Record
                'REFLECTION
                Dim MyType As Type = GetType(Record)                    'Take Type of Record
                Dim MyFieldInfo() As FieldInfo = MyType.GetFields()     'Take information of the Metadata

                Dim ValueIndex As Integer = 0
                For Each FieldInfo As FieldInfo In MyFieldInfo
                    If Not String.IsNullOrEmpty(Values(ValueIndex)) Then
                        Dim Value As Object = Convert.ChangeType(Values(ValueIndex), FieldInfo.FieldType)
                        FieldInfo.SetValue(Record, Value)
                        ValueIndex += 1
                    End If
                Next

                WiresharkRecord.Add(Record)
                Dim data_point As New DataPoint_Numeric
                data_point.X = Record.FrameNumber
                data_point.Y = Record.IpProto
                ListOfWiresharkRecordInterval.Add(data_point)
                Me.RichTextBoxCSV.AppendText(Line & Environment.NewLine)
            Loop

        End Using
    End Sub

    Sub PrintResults_BivariateDistribution_ClassInterval(FrequencyDistribution As Dictionary(Of Tuple(Of Interval, Interval), FrequenciesForValue)) ' SortedDistr As List(Of KeyValuePair(Of Tuple(Of Double, Double), FrequenciesForValue)))

        Me.RTBDistribution.AppendText("BIVARIATE DISTRIBUTION CLASS INTERVAL of X(Index) and Y(Ip.Proto)" & Environment.NewLine)

        'Extraction of distinct values ot 
        Dim DistinctValues_FirstVariable As New HashSet(Of Interval)
        Dim DistinctValues_SecondVariable As New HashSet(Of Interval)

        For Each kvp As KeyValuePair(Of Tuple(Of Interval, Interval), FrequenciesForValue) In FrequencyDistribution

            Dim t As Tuple(Of Interval, Interval) = kvp.Key

            If Not DistinctValues_FirstVariable.Contains(t.Item1) Then
                DistinctValues_FirstVariable.Add(t.Item1)

            End If

            If Not DistinctValues_SecondVariable.Contains(t.Item2) Then
                DistinctValues_SecondVariable.Add(t.Item2)

            End If

        Next


        Dim s1 As New SortedSet(Of Interval)(DistinctValues_FirstVariable)
        Dim s2 As New SortedSet(Of Interval)(DistinctValues_SecondVariable)




        'Table
        Dim CountCheck As Double
        Me.RTBDistribution.AppendText("X\Y".ToString.PadRight(10) & "| ")
        For Each I_Y As Interval In s2
            Me.RTBDistribution.AppendText(I_Y.ToString.PadRight(10))
        Next
        Me.RTBDistribution.AppendText(vbCrLf)
        Me.RTBDistribution.AppendText("---------------------------------------------------------" & vbCrLf)
        'Loop and take the JOINT FREQUENCY OF X AND Y
        For Each I_X As Interval In s1

            Me.RTBDistribution.AppendText(I_X.ToString.PadRight(15) & "| ")

            For Each I_Y As Interval In s2

                Dim t As New Tuple(Of Interval, Interval)(I_X, I_Y)
                Dim c As Double
                If FrequencyDistribution.ContainsKey(t) Then
                    c = FrequencyDistribution(t).Count          'JOINT FREQUENCY OF X AND Y
                Else
                    c = 0
                End If
                CountCheck += c
                Me.RTBDistribution.AppendText(c.ToString.PadRight(10))
            Next
            Me.RTBDistribution.AppendText(vbCrLf)
        Next
    End Sub

    Function findIntervalForValue(v As Double, IntervalSize As Double, ByRef ListOfIntervals As List(Of Interval)) As Interval

        For Each Interval In ListOfIntervals
            If Interval.ContainsValue(v) Then Return Interval
        Next

        If v <= ListOfIntervals(0).LowerEnd Then
            Do
                Dim NewLeftInterval As New Interval
                NewLeftInterval.UpperEnd = ListOfIntervals(0).LowerEnd
                NewLeftInterval.LowerEnd = NewLeftInterval.UpperEnd - IntervalSize

                ListOfIntervals.Insert(0, NewLeftInterval)

                If NewLeftInterval.ContainsValue(v) Then Return NewLeftInterval
            Loop
        ElseIf v > ListOfIntervals(ListOfIntervals.Count - 1).UpperEnd Then
            Do
                Dim NewRightInterval As New Interval
                NewRightInterval.LowerEnd = ListOfIntervals(ListOfIntervals.Count - 1).UpperEnd
                NewRightInterval.UpperEnd = NewRightInterval.LowerEnd + IntervalSize

                ListOfIntervals.Add(NewRightInterval)

                If NewRightInterval.ContainsValue(v) Then Return NewRightInterval

            Loop

        Else
            Throw New Exception("Not excepted occurrence")
        End If
    End Function

    Function BivariateDistribution_ClassIntervals(ListOfObservations As List(Of BivariateNumericObservation),
                                                     IntervalSize_X As Double, IntervalSize_Y As Double,
                                                        StartingEndPoint_X As Double, StartingEndPoint_Y As Double) _
                                                    As Dictionary(Of Tuple(Of Interval, Interval), FrequenciesForValue)

        Dim FrequencyDistribution As New Dictionary(Of Tuple(Of Interval, Interval), FrequenciesForValue)

        'first interval X ---------------------------------------------------------------------'

        Dim Interval_X_0 As New Interval
        Interval_X_0.LowerEnd = StartingEndPoint_X
        Interval_X_0.UpperEnd = Interval_X_0.LowerEnd + IntervalSize_X

        Dim ListOfIntervals_X As New List(Of Interval)
        ListOfIntervals_X.Add(Interval_X_0)


        'first interval Y ---------------------------------------------------------------------'

        Dim Interval_Y_0 As New Interval
        Interval_Y_0.LowerEnd = StartingEndPoint_Y
        Interval_Y_0.UpperEnd = Interval_Y_0.LowerEnd + IntervalSize_Y

        Dim ListOfIntervals_Y As New List(Of Interval)
        ListOfIntervals_Y.Add(Interval_Y_0)

        Dim Interval_Found_X As Interval
        Dim Interval_Found_Y As Interval

        'look for the interval
        For Each b As BivariateNumericObservation In ListOfObservations

            Interval_Found_X = Nothing
            Interval_Found_Y = Nothing

            'look for the interval for X value
            Interval_Found_X = Me.findIntervalForValue(b.X, IntervalSize_X, ListOfIntervals_X)
            'look for the interval for Y value
            Interval_Found_Y = Me.findIntervalForValue(b.Y, IntervalSize_Y, ListOfIntervals_Y)

            Dim FoundTuple As New Tuple(Of Interval, Interval)(Interval_Found_X, Interval_Found_Y)

            If FrequencyDistribution.ContainsKey(FoundTuple) Then
                FrequencyDistribution(FoundTuple).Count += 1
            Else
                FrequencyDistribution.Add(FoundTuple, New FrequenciesForValue)
            End If
        Next

        Return FrequencyDistribution

    End Function

    Private Sub ButtonBivariate_Click(sender As Object, e As EventArgs) Handles ButtonBivariate.Click
        RTBDistribution.Clear()
        Dim ListOfBivariateNumericObservation As New List(Of BivariateNumericObservation)

        'Dim ListOfDataPoint_Numeric As List(Of DataPoint_Numeric) = Me.WiresharkRecord

        For Each DataPoint_Numeric As DataPoint_Numeric In ListOfWiresharkRecordInterval
            Dim BivariateNumericObs As New BivariateNumericObservation
            BivariateNumericObs.X = DataPoint_Numeric.X
            BivariateNumericObs.Y = DataPoint_Numeric.Y
            ListOfBivariateNumericObservation.Add(BivariateNumericObs)
        Next
        'Dim IntervalSize As Double = 5
        'Dim StartingEndPoint As Double = 10

        Dim FrequencyDistribution_BivariateContinuos As Dictionary(Of Tuple(Of Interval, Interval), FrequenciesForValue) = Me.BivariateDistribution_ClassIntervals(ListOfBivariateNumericObservation, 5, 5, 10, 10)
        Me.PrintResults_BivariateDistribution_ClassInterval(FrequencyDistribution_BivariateContinuos)

    End Sub
End Class