Public Class Form1
    Dim random As New Random
    Dim n As Integer
    Dim p As Double
    Dim DataSet As New List(Of Integer)
    Dim FrequencyDict As New Dictionary(Of Integer, Integer)
    Dim ListaEstremi As New List(Of Integer)
    Dim ListaValori As New List(Of Double)
    Public b As Bitmap
    Public g As Graphics
    'WINDOW
    Public MinX_Window As Double = -1
    Public MaxX_Window As Double = 1
    Public MinY_Window As Double = 0
    Public MaxY_Window As Double = 1000
    Public RangeX As Double = MaxX_Window - MinX_Window
    Public RangeY As Double = MaxY_Window - MinY_Window
    Public Viewport As New Rectangle(10, 10, 250, 250)


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

        Dim DictAF As New Dictionary(Of Integer, Integer)
        Dim DictRF As New Dictionary(Of Integer, Integer)

        DictAF = AbosluteFrequency(Me.DataSet)
        For Each item As KeyValuePair(Of Integer, Integer) In DictAF
            DataGridViewFrequency.Rows.Add(item.Key, item.Value)
            FrequencyDict.Add(item.Key, item.Value)
            ListaEstremi.Add(item.Key + 1)
            ListaValori.Add(item.Value)
        Next

        DictRF = RelativeFrequency(DictAF)
        Dim i As Integer
        For Each item As KeyValuePair(Of Integer, Integer) In DictRF
            DataGridViewFrequency.Rows(i).Cells(2).Value = item.Key
            DataGridViewFrequency.Rows(i).Cells(3).Value = item.Value & "%"
            'FrequencyDict.Add(item.Key, item.Value)
            ListaEstremi.Add(item.Key + 1)
            ListaValori.Add(item.Value)
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

    Sub InizializeGraphics()
        Me.b = New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
        Me.g = Graphics.FromImage(b)
        Me.g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Me.g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
    End Sub

    Private Sub ButtonHisto_Click(sender As Object, e As EventArgs) Handles ButtonHisto.Click
        Me.InizializeGraphics()
        DrawScene()
    End Sub
    Function X_Viewport(X_World As Double, Viewport As Rectangle, MinX As Double, RangeX As Double) As Integer
        Return CInt(Viewport.Left + Viewport.Width * (X_World - MinX) / RangeX)
    End Function
    Function Y_Viewport(Y_World As Double, Viewport As Rectangle, MinY As Double, RangeY As Double) As Integer
        Return CInt(Viewport.Top + Viewport.Height - Viewport.Height * (Y_World - MinY) / RangeY)
    End Function
    Sub DrawScene()

        g.Clear(Color.White)
        Me.g.DrawRectangle(Pens.Red, Viewport)

        'For Each item As KeyValuePair(Of Integer, Integer) In FrequencyDict
        For Each itemX In ListaEstremi
            Dim X_Viewport As Integer = Me.X_Viewport(itemX, Viewport, MinX_Window, RangeX)
            For Each itemY In ListaValori
                Dim Y_Viewport As Integer = Me.Y_Viewport(itemY, Viewport, MinY_Window, RangeY)

                g.FillEllipse(Brushes.Blue, New Rectangle(New Point(X_Viewport - 3, Y_Viewport - 3), New Size(6, 6)))
                g.DrawString(itemX.ToString.PadLeft(5) & "," & itemY.ToString, Font, Brushes.Green, New Point(X_Viewport, Y_Viewport))
                '''''
                Dim rect As New Rectangle(X_Viewport, Y_Viewport, 15, itemY)
                Dim clr As Color = Color.FromArgb(255, 245, 251, 122)
                Dim the_brush As New SolidBrush(clr)
                Dim the_pen As New Pen(Color.Black, 2)
                g.FillRectangle(the_brush, rect)
                g.DrawRectangle(the_pen, rect)
            Next
        Next
        Me.PictureBox1.Image = b
    End Sub

End Class
