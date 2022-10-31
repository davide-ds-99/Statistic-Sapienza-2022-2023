Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim myDictionary = New Dictionary(Of Integer, Double)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonHisto.Click
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Chart1.Titles.Add("Distribution of the sum of roll of two dice")
        'Create a new series and add data points to it.
        Dim s As New Series
        s.Name = "sum of distribution"
        'Change to a line graph.
        s.ChartType = SeriesChartType.Column
        For Each element As KeyValuePair(Of Integer, Double) In myDictionary
            s.Points.AddXY(element.Key.ToString, element.Value)
        Next
        'Add the series to the Chart1 control.
        Chart1.Series.Add(s)
    End Sub

    Private Sub ButtonFill_Click(sender As Object, e As EventArgs) Handles ButtonFill.Click
        Me.myDictionary.Clear()
        Me.RichTextBox1.Clear()

        Me.myDictionary.Add(2, 0.03)
        Me.myDictionary.Add(3, 0.06)
        Me.myDictionary.Add(4, 0.08)
        Me.myDictionary.Add(5, 0.11)
        Me.myDictionary.Add(6, 0.14)
        Me.myDictionary.Add(7, 0.17)
        Me.myDictionary.Add(8, 0.14)
        Me.myDictionary.Add(9, 0.11)
        Me.myDictionary.Add(10, 0.08)
        Me.myDictionary.Add(11, 0.06)
        Me.myDictionary.Add(12, 0.03)

        Me.RichTextBox1.AppendText("SUM OF TWO DICE ROLL" & Environment.NewLine)
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
End Class
