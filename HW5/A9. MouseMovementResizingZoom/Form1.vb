Public Class Form1

    Public b As Bitmap
    Public g As Graphics


    'WINDOW
    Public Viewport As New Rectangle(10, 10, 500, 500)


    Sub InizializeGraphics()
        Me.b = New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
        Me.g = Graphics.FromImage(b)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.InizializeGraphics()
        Me.DrawScene()

    End Sub

    Sub DrawScene()

        g.Clear(Color.White)
        Dim myPen As Pen
        myPen = New Pen(Color.Red, 5)
        myPen.DashStyle = Drawing2D.DashStyle.Dash
        Me.g.DrawRectangle(myPen, Viewport)

        Me.PictureBox1.Image = b
    End Sub

    Function X_Viewport(X_World As Double, Viewport As Rectangle, MinX As Double, RangeX As Double) As Integer
        Return CInt(Viewport.Left + Viewport.Width * (X_World - MinX) / RangeX)
    End Function
    Function Y_Viewport(Y_World As Double, Viewport As Rectangle, MinY As Double, RangeY As Double) As Integer
        Return CInt(Viewport.Top + Viewport.Height - Viewport.Height * (Y_World - MinY) / RangeY)
    End Function


    Private Viewport_At_MouseDown As Rectangle
    Private MouseLocation_At_MouseDown As Point
    Private Dragging_Started As Boolean
    Private Resizing_Started As Boolean

    Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If Me.Viewport.Contains(e.X, e.Y) Then
            Me.Viewport_At_MouseDown = Me.Viewport
            Me.MouseLocation_At_MouseDown = New Point(e.X, e.Y)
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Me.Dragging_Started = True
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                Me.Resizing_Started = True
            End If

        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If Me.Dragging_Started Then
            Dim Delta_X As Integer = e.X - Me.MouseLocation_At_MouseDown.X
            Dim Delta_Y As Integer = e.Y - Me.MouseLocation_At_MouseDown.Y

            Me.Viewport.X = Me.Viewport_At_MouseDown.X + Delta_X
            Me.Viewport.Y = Me.MouseLocation_At_MouseDown.Y + Delta_Y
            Me.DrawScene()
        ElseIf Me.Resizing_Started Then
            Dim Delta_X As Integer = e.X - Me.MouseLocation_At_MouseDown.X
            Dim Delta_Y As Integer = e.Y - Me.MouseLocation_At_MouseDown.Y

            Me.Viewport.Width = Me.Viewport_At_MouseDown.X + Delta_X
            Me.Viewport.Height = Me.MouseLocation_At_MouseDown.Y + Delta_Y
            Me.DrawScene()
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Me.Dragging_Started = False
        Me.Resizing_Started = False
    End Sub


    Private Sub PictureBox1_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseWheel
        Dim Change_x As Integer = CInt(Me.Viewport.Width / 10)
        Dim Change_y As Integer = CInt(Me.Viewport.Height * Change_x / Me.Viewport.Width)

        If e.Delta > 0 Then
            Me.Viewport.X -= Change_x
            Me.Viewport.Width += 2 * Change_x

            Me.Viewport.Y -= Change_y
            Me.Viewport.Height += 2 * Change_y

            Me.DrawScene()

        ElseIf e.Delta < 0 Then
            Me.Viewport.X += Change_x
            Me.Viewport.Width -= 2 * Change_x

            Me.Viewport.Y += Change_y
            Me.Viewport.Height -= 2 * Change_y

            Me.DrawScene()
        End If

    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Me.PictureBox1.Focus()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.CurrentCulture = Globalization.CultureInfo.InvariantCulture
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()

    End Sub
End Class
Public Class DataSet
    Public DataPoints As New List(Of DataPoint)
End Class
