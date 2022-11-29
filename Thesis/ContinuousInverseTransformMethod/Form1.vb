Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim DistributionDictionary = New Dictionary(Of Double, Integer)
    Dim Array As New ArrayList

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        Distribution(100)
    End Sub

    Private Sub Distribution(iteration As Integer)
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        DistributionDictionary.Clear()
        Array.Clear()

        Chart1.Titles.Add("Continuous Inverse Trasform Method")
        'Create a new series and add data points to it.
        Dim s As New Series

        s.Name = "sum of distribution"
        'Change to a line graph.
        s.ChartType = SeriesChartType.Column

        'Exponential Function
        'Inverse CDF
        ' F^-1(u)= -Lambda log(1-u)
        For n = 1 To iteration
            Dim U = Rnd()
            Dim actual As Double
            Dim X As Double
            X = Math.Round(-1 * Math.Log(1 - U), 2)
            Array.Add(X)
        Next
        For Each element In Array
            If DistributionDictionary.ContainsKey(element) Then
                DistributionDictionary(element) += 1
            Else
                DistributionDictionary.Add(element, 1)
            End If
        Next

        For Each key As KeyValuePair(Of Double, Integer) In DistributionDictionary
            Console.WriteLine("Chiave " & key.Key & " Valore" & key.Value)
            s.Points.AddXY(key.Key, key.Value)
        Next

        Chart1.Series.Add(s)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button500.Click
        Distribution(500)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1000.Click
        Distribution(1000)
    End Sub
End Class
