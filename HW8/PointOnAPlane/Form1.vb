Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim n As New Integer
    Dim dictionaryX As New Dictionary(Of Double, Integer)
    Dim dictionaryY As New Dictionary(Of Double, Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chart.Titles.Clear()
        Chart.Series.Clear()
        dictionaryX.Clear()
        dictionaryY.Clear()

        'CHART
        Chart.Titles.Add("Points in a Cartesian Plane")
        Dim s As New Series
        Try
            Me.n = CInt(TextBoxN.Text)
            s.Name = " n° points = " & n
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
                Dim X As Double = Math.Round(r * Math.Cos(tetha), 2)
                Dim Y As Double = Math.Round(r * Math.Sin(tetha), 2)
                Console.WriteLine("X = " & X & " Y = " & Y)
                aggItem(X, dictionaryX)
                aggItem(Y, dictionaryY)
                s.Points.AddXY(X, Y)
            Next
            Chart.Series.Add(s)
            empiricalDistribution(dictionaryX, ChartX)
            empiricalDistribution(dictionaryY, ChartY)
        Catch
            MsgBox("Insert an Integer and not anymore")

        End Try
    End Sub

    Private Sub aggItem(x As Double, dictionaryX As Dictionary(Of Double, Integer))
        If dictionaryX.ContainsKey(x) Then
            dictionaryX(x) += 1
        Else
            dictionaryX.Add(x, 1)
        End If
    End Sub

    Private Sub empiricalDistribution(dizionario As Dictionary(Of Double, Integer), Chart As Chart)
        Chart.Titles.Clear()
        Chart.Series.Clear()
        Dim s As New Series
        s.ChartType = SeriesChartType.Column
        Dim query = From item In dizionario
                    Order By item.Key Ascending
                    Select item
        For Each value As KeyValuePair(Of Double, Integer) In query
            Console.WriteLine(value)
            s.Points.AddXY(value.Key, value.Value)
        Next
        Chart.Series.Add(s)

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub
End Class
