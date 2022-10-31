Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim random As New Random
    Dim n As Integer
    Dim p As Double
    Dim DataSet As New List(Of Integer)
    Dim AF As New Dictionary(Of Integer, Double)
    Dim RF As New Dictionary(Of Integer, Double)


    Private Sub ButtonBinomial_Click(sender As Object, e As EventArgs) Handles ButtonBinomial.Click
        Me.DataSet.Clear()
        'Me.FrequencyDict.Clear()
        RTBVariable.Clear()
        DataGridView.Rows.Clear()
        Me.n = random.Next(50, 1000)
        Me.p = Convert.ToDouble(random.Next(0, 100)) / 100
        RTBVariable.AppendText("n° trials = " & Me.n & Environment.NewLine & "p = " & Me.p)
        'Table of value
        Dim score As Double
        DataGridView.ColumnCount = 2
        DataGridView.Columns(0).Name = "trials"
        DataGridView.Columns(1).Name = "score"
        For i As Integer = 1 To n
            score = random.Next(0, 2) * p
            If score > 0.5 Then
                score = 1
            Else
                score = 0
            End If
            'score *= p - (n - i)
            'score /= i
            Me.DataSet.Add(score)
            DataGridView.Rows.Add(i, score)
        Next
    End Sub
    Private Sub ButtonFrquency_Click(sender As Object, e As EventArgs) Handles ButtonFrquency.Click
        DataGridViewFrequency.Rows.Clear()
        DataGridViewFrequency.ColumnCount = 6

        DataGridViewFrequency.Columns(0).Name = "absolute frequency"
        DataGridViewFrequency.Columns(1).Name = "value AF"
        DataGridViewFrequency.Columns(2).Name = "relative frequency"
        DataGridViewFrequency.Columns(3).Name = "value RF"
        DataGridViewFrequency.Columns(4).Name = "normalized frequency"
        DataGridViewFrequency.Columns(5).Name = "value NF"

        Dim DictAF As Dictionary(Of Integer, Integer) = AbosluteFrequency(Me.DataSet)

        AF.Clear()
        For Each item As KeyValuePair(Of Integer, Integer) In DictAF
            DataGridViewFrequency.Rows.Add(item.Key, item.Value)
            AF.Add(item.Key, item.Value)
        Next

        RF.Clear()
        Dim DictRF As Dictionary(Of Integer, Integer) = RelativeFrequency(DictAF)
        Dim i As Integer
        For Each item As KeyValuePair(Of Integer, Integer) In DictRF
            DataGridViewFrequency.Rows(i).Cells(2).Value = item.Key
            DataGridViewFrequency.Rows(i).Cells(3).Value = item.Value & "%"
            RF.Add(item.Key, item.Value)
            i += 1
        Next
        'DataGridViewFrequency.Rows.Add(item.Key, item.Value)
    End Sub
    Function AbosluteFrequency(DataSet As List(Of Integer)) As Dictionary(Of Integer, Integer)
        Dim Dict As New Dictionary(Of Integer, Integer)
        For Each element In DataSet
            If Not Dict.ContainsKey(element) Then
                Dict.Add(element, 1)
            Else
                Dict(element) += 1
            End If
        Next
        Return Dict
    End Function

    Function RelativeFrequency(Dictio As Dictionary(Of Integer, Integer)) As Dictionary(Of Integer, Integer)
        Dim Dict As New Dictionary(Of Integer, Integer)
        For Each item As KeyValuePair(Of Integer, Integer) In Dictio
            Dim relativefreq As New Double
            relativefreq = item.Value / Me.n * 100
            Dict.Add(item.Key, relativefreq)
        Next
        Return Dict
    End Function

    Private Sub ButtonHisto_Click(sender As Object, e As EventArgs) Handles ButtonHisto.Click
        'Me.InizializeGraphics()
        'DrawScene()
        'Use a Windows Package for generate chart
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Chart1.Titles.Add("Distribution of flip two faice coin")
        'Create a new series and add data points to it.
        Dim s As New Series
        s.Name = "sum of distribution"
        'Change to a line graph.
        s.ChartType = SeriesChartType.Column
        For Each element As KeyValuePair(Of Integer, Double) In AF
            s.Points.AddXY(element.Key.ToString, element.Value)
        Next
        'Add the series to the Chart1 control.
        Chart1.Series.Add(s)

        Chart2.Titles.Clear()
        Chart2.Series.Clear()
        Chart2.Titles.Add("Distribution of flip two faice coin")
        'Create a new series and add data points to it.
        Dim f As New Series
        f.Name = "sum of distribution"
        'Change to a line graph.
        f.ChartType = SeriesChartType.Column
        For Each element As KeyValuePair(Of Integer, Double) In RF
            f.Points.AddXY(element.Key.ToString, element.Value)
        Next
        'Add the series to the Chart1 control.
        Chart2.Series.Add(f)
    End Sub

End Class
