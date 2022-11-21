Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim n = 100
    Dim dictionaryX As New Dictionary(Of Double, Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGauss.Click
        Dim MEAN = 1
        Dim STDEV = 1
        Dim x1 As Double = MathNet.Numerics.Distributions.Normal.Sample(MEAN, STDEV)
        Console.WriteLine(x1)

        'Media e Varianza ancora da definire'
        Dim media = 0
        Dim varianza = 0

        For i As Integer = 0 To n
            'Dim x1 As Double = MathNet.Numerics.Distributions.Normal.Sample(MEAN, STDEV)
        Next
        'Plotting
    End Sub
    Private Sub ButtonChiSquare_Click(sender As Object, e As EventArgs) Handles ButtonChiSquare.Click
        dictionaryX.Clear()
        Chart.Titles.Clear()
        Chart.Series.Clear()
        Chart.Titles.Add("Chi Squadre Distribution")
        Dim s As New Series
        s.ChartType = SeriesChartType.Line
        s.MarkerColor = Color.Red
        Dim media = 0
        Dim varianza = 1
        For i As Integer = 0 To n
            Dim x1 As Double = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2)

            aggItem(x1, dictionaryX)
            Console.WriteLine(x1)
        Next
        s = ordDict(dictionaryX)
        Chart.Series.Add(s)
        'Plotting
    End Sub

    Public Function ordDict(dictionaryX As Dictionary(Of Double, Integer))
        Dim s As New Series
        Dim query = From item In dictionaryX
                    Order By item.Key Ascending
                    Select item
        For Each value As KeyValuePair(Of Double, Integer) In query
            Console.WriteLine(value)
            s.Points.AddXY(value.Key, value.Value)
        Next
        Return s
    End Function

    Private Sub aggItem(x As Double, dictionaryX As Dictionary(Of Double, Integer))
        If dictionaryX.ContainsKey(x) Then
            dictionaryX(x) += 1
        Else
            dictionaryX.Add(x, 1)
        End If
    End Sub


    Private Sub ButtonStudent_Click(sender As Object, e As EventArgs) Handles ButtonStudent.Click

    End Sub

    Private Sub ButtonFisher_Click(sender As Object, e As EventArgs) Handles ButtonFisher.Click

    End Sub

    Private Sub ButtonCauchy_Click(sender As Object, e As EventArgs) Handles ButtonCauchy.Click

    End Sub
End Class
