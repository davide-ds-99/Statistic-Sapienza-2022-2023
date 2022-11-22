Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim n = 1000
    Dim dictionaryX As New Dictionary(Of Double, Integer)
    Public Function ordDict(dictionaryX As Dictionary(Of Double, Integer))
        Dim s As New Series
        Dim query = From item In dictionaryX
                    Order By item.Key Ascending
                    Select item
        For Each value As KeyValuePair(Of Double, Integer) In query

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGauss.Click

        Chart.Titles.Clear()
        Chart.Series.Clear()
        Chart.Titles.Add("Gauss Distribution")
        Dim Mean = 0
        Dim Variance = 0.2
        dictionaryX.Clear()
        For i As Integer = 0 To n - 1
            Dim x1 As Double = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(Mean, Variance), 2)
            aggItem(x1, dictionaryX)
        Next
        Dim s = ordDict(dictionaryX)
        s.ChartType = SeriesChartType.StepLine
        s.MarkerColor = Color.Aqua
        Chart.Series.Add(s)

    End Sub
    Private Sub ButtonChiSquare_Click(sender As Object, e As EventArgs) Handles ButtonChiSquare.Click
        dictionaryX.Clear()
        Chart.Titles.Clear()
        Chart.Series.Clear()
        Chart.Titles.Add("Chi Squadre Distribution")
        Dim media = 0
        Dim varianza = 1
        For i As Integer = 0 To n
            'X1^2
            Dim x1 As Double = Math.Pow(Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2), 2)
            aggItem(x1, dictionaryX)
            Console.WriteLine(x1)
        Next
        Dim s As New Series
        s = ordDict(dictionaryX)
        s.ChartType = SeriesChartType.StepLine
        s.Color = Color.Red
        Chart.Series.Add(s)
    End Sub
    Private Sub ButtonStudent_Click(sender As Object, e As EventArgs) Handles ButtonStudent.Click
        dictionaryX.Clear()
        Chart.Titles.Clear()
        Chart.Series.Clear()
        Chart.Titles.Add("Chi Student Distribution")
        Dim media = 0
        Dim varianza = 0.2
        For i As Integer = 0 To n - 1
            'x/y^2
            Dim x1 As Double = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2)
            Dim y1 As Double = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2)
            Try
                Dim x_y_2 = Math.Round(Math.Round((x1 / y1), 2) / y1, 2)
                Console.WriteLine(x_y_2)
                aggItem(x_y_2, dictionaryX)

            Catch ex As OverflowException
                Dim x_y_2 = 0
                aggItem(x_y_2, dictionaryX)
            End Try
        Next
        Dim s As New Series
        s = ordDict(dictionaryX)
        s.ChartType = SeriesChartType.StepLine
        s.Color = Color.Red
        Chart.Series.Add(s)
    End Sub
    Private Sub ButtonFisher_Click(sender As Object, e As EventArgs) Handles ButtonFisher.Click
        dictionaryX.Clear()
        Chart.Titles.Clear()
        Chart.Series.Clear()
        Chart.Titles.Add("Fisher Distribution")
        Dim media = 0
        Dim varianza = 0.2
        For i As Integer = 0 To n - 1
            'x^2/y^2
            Dim x1 As Double = Math.Pow(Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2), 2)
            Dim y1 As Double = Math.Pow(Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2), 2)
            Try
                Dim x_y_2 = Math.Round((x1 / y1), 2)
                Console.WriteLine(x_y_2)
                aggItem(x_y_2, dictionaryX)

            Catch ex As OverflowException
                Dim x_y_2 = 0
                aggItem(x_y_2, dictionaryX)
            End Try
        Next
        Dim s As New Series
        s = ordDict(dictionaryX)
        s.ChartType = SeriesChartType.StepLine
        s.Color = Color.Pink
        Chart.Series.Add(s)
    End Sub

    Private Sub ButtonCauchy_Click(sender As Object, e As EventArgs) Handles ButtonCauchy.Click
        dictionaryX.Clear()
        Chart.Titles.Clear()
        Chart.Series.Clear()
        Chart.Titles.Add("Cauchy Distribution")
        Dim media = 0
        Dim varianza = 0.2
        For i As Integer = 0 To n - 1
            'x/y
            Dim x1 As Long = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2)
            Dim y1 As Long = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(media, varianza), 2)
            Try
                Dim x_y_2 = Math.Round((x1 / y1), 2)
                Console.WriteLine(x_y_2)
                aggItem(x_y_2, dictionaryX)
            Catch ex As OverflowException
                Dim x_y_2 = 0
                aggItem(x_y_2, dictionaryX)
            End Try
        Next
        Dim s As New Series
        s = ordDict(dictionaryX)
        s.ChartType = SeriesChartType.StepLine
        s.Color = Color.Pink
        Chart.Series.Add(s)
    End Sub
End Class
