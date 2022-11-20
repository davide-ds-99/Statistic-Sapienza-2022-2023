Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim ArrayX As New List(Of Double)
    Dim ArrayY As New List(Of Double)
    Dim n = 50
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chart.Titles.Clear()
        Chart.Series.Clear()
        ArrayX.Clear()
        ArrayY.Clear()

        'CHART
        Chart.Titles.Add("Points in a Cartesian Plane")
        Dim s As New Series
        'Dim lambda = CInt(TextBoxLambda.Text)
        s.Name = " n° points = " & n
        'Change to a line graph.
        s.ChartType = SeriesChartType.Point
        s.MarkerStyle = MarkerStyle.Circle
        s.MarkerSize = 5
        s.MarkerColor = Color.Red
        Dim rand As Random = New Random()
        For k As Integer = 0 To n
            Dim u1 As Double = rand.NextDouble()
            Console.WriteLine("U1 = " & u1)
            Dim u2 As Double = rand.NextDouble()
            Console.WriteLine("U2 = " & u2)
            Dim r As Double = Math.Sqrt(-2 * Math.Log10(u1))
            Console.WriteLine("R = " & r)
            Dim tetha As Double = 2 * Math.PI * u2
            Console.WriteLine("Tetha = " & tetha)
            Dim X As Double = r * Math.Cos(tetha)
            Dim Y As Double = r * Math.Sin(tetha)
            Console.WriteLine("X = " & X & " Y = " & Y)
            ArrayX.Add(X)
            ArrayY.Add(Y)
            s.Points.AddXY(X, Y)
        Next
        Chart.Series.Add(s)
        drawEmpiricalDistribution(ArrayX, ChartX)
        drawEmpiricalDistribution(ArrayY, ChartY)
    End Sub

    Private Sub drawEmpiricalDistribution(unorderedarray As List(Of Double), chart As Chart)
        Dim ordered_array As List(Of Double) = unorderedarray
        ordered_array.Sort()
        chart.Titles.Clear()
        chart.Series.Clear()
        chart.Titles.Add("Empirical Distribution")
        Dim s As New Series
        s.ChartType = SeriesChartType.Column
        's.MarkerStyle = MarkerStyle.Circle
        s.MarkerSize = 5
        s.MarkerColor = Color.Green
        For item_index As Integer = 0 To n
            Console.WriteLine(item_index, ordered_array(item_index))
            s.Points.AddXY(item_index, ordered_array(item_index))
        Next
        chart.Series.Add(s)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub
End Class
