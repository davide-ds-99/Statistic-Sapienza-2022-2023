Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim myDictionary = New Dictionary(Of Integer, Double)
    Dim DistributionDictionary = New Dictionary(Of Integer, Integer)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub ButtonFill_Click(sender As Object, e As EventArgs) Handles ButtonFill.Click
        Me.myDictionary.Clear()
        Me.RichTextBox1.Clear()

        Me.myDictionary.Add(1, 0.2)
        Me.myDictionary.Add(2, 0.1)
        Me.myDictionary.Add(3, 0.05)
        Me.myDictionary.Add(4, 0.05)
        Me.myDictionary.Add(5, 0.4)
        Me.myDictionary.Add(6, 0.2)

        Me.RichTextBox1.AppendText("Table of Probability" & Environment.NewLine)
        For Each element As KeyValuePair(Of Integer, Double) In myDictionary
            Me.RichTextBox1.AppendText(element.Key.ToString.PadRight(10) & element.Value.ToString().PadLeft(2) & vbCrLf)
        Next

    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Me.myDictionary.Clear()
        Me.RichTextBox1.Clear()
    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        Discrete(100)
    End Sub

    Private Sub Button500_Click(sender As Object, e As EventArgs) Handles Button500.Click
        Discrete(500)
    End Sub
    Private Sub Button1000_Click(sender As Object, e As EventArgs) Handles Button1000.Click
        Discrete(1000)
    End Sub

    Private Sub Discrete(iteration As Integer)
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        DistributionDictionary.Clear()
        Chart1.Titles.Add("Discrete Inverse Trasform Method")
        'Create a new series and add data points to it.
        Dim s As New Series
        s.Name = "sum of distribution"
        'Change to a line graph.
        s.ChartType = SeriesChartType.Column

        For Each key As KeyValuePair(Of Integer, Double) In myDictionary
            DistributionDictionary.Add(key.Key, 0)
        Next

        For Each key As KeyValuePair(Of Integer, Integer) In DistributionDictionary
            Console.WriteLine("Chiave " & key.Key & " Valore" & key.Value)
        Next

        Console.WriteLine("LEN " & Len(myDictionary.Count))

        For n = 1 To iteration
            Dim U = Rnd()
            If U <= myDictionary(1) Then
                DistributionDictionary(1) += 1
            Else
                Dim sum As New Double
                For i = 1 To Len(myDictionary.Count) + 1
                    sum += myDictionary(i)
                    If U > sum And U < sum + myDictionary(i + 1) Then
                        DistributionDictionary(i + 1) += 1
                        Exit For
                    End If
                Next
            End If
        Next

        For Each key As KeyValuePair(Of Integer, Integer) In DistributionDictionary
            Console.WriteLine("Chiave " & key.Key & " Valore" & key.Value)
            s.Points.AddXY(key.Key, key.Value)
        Next
        Chart1.Series.Add(s)
    End Sub


End Class
