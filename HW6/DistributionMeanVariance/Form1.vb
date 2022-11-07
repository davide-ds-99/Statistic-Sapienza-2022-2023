Public Class Form1
    Dim die As New List(Of Integer)({1, 2, 3, 4, 5, 6})
    Dim length_die = die.Count
    Dim p = (1 / length_die)
    Function CheckLimit()
        If String.IsNullOrEmpty(TextBoxN.Text) Then
            MsgBox("Insert N into Box (es. 1,...,1000)")
            Return False
        End If
        Return True
    End Function
    Public Function Mean(list As List(Of Integer), probability As Double) As Double
        Dim m As New Double
        m = 0
        For Each number In list
            m += number * probability
        Next
        'MsgBox(m)
        Return m
    End Function
    Public Function Variance(list As List(Of Integer)) As Double
        Dim m = Mean(die, p)
        Dim v As New Double
        v = 0
        For Each number In list
            v += Math.Pow((m - number), 2) / 6
        Next
        'MsgBox(Math.Round(v, 2))
        Return Math.Round(v, 2)
    End Function
    'Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
    '    Dim Generator As System.Random = New System.Random()
    '    Return Generator.Next(Min, Max)
    'End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonMean.Click
        If CheckLimit() Then
            Try
                Dim n = CInt(TextBoxN.Text)
                Mean(die, p)
                Randomize()
                Dim randoms(n) As Integer
                For i As Integer = 0 To n - 1
                    randoms(i) = CInt(Int((n * Rnd()) + 1))
                Next

                For i = 0 To n - 1
                    Console.WriteLine(randoms(i))
                Next i
                'MsgBox(array_flip(5))
            Catch ex As Exception
                MsgBox("Insert an Integer and not anymore")
            End Try
        End If
    End Sub

    Private Sub ButtonVariance_Click(sender As Object, e As EventArgs) Handles ButtonVariance.Click
        If CheckLimit() Then
            Try
                Dim n = CInt(TextBoxN.Text)
                Variance(die)
            Catch ex As Exception
                MsgBox("Insert an Integer and not anymore")
            End Try
        End If
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class
