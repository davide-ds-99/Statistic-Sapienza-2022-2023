Imports System.IO
Imports FileHelpers



Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Index As Integer
        Try
            Index = InputBox("Enter index of the columns (start from 1 to 4)")
        Catch ex As Exception
        End Try
        DataGridView1.Rows.Clear()
        Dim fileHelperEngine = New FileHelperEngine(Of Student)
        Dim students = fileHelperEngine.ReadFile(Path.Combine(Application.StartupPath, "..\..\..\Statistics_students_dataset_22_23 - Foglio1.csv"))
        Dim i As Integer = 0

        For Each student In students
            i += 1
            DataGridView1.ColumnCount = 2
            If Index < 1 Or Index > 4 Then
                MsgBox("Index out of range", MsgBoxStyle.OkCancel)
                Me.Close()
            ElseIf Index = 1 Then
                If i = 1 Then
                    DataGridView1.Columns(0).Name = student.Name
                    DataGridView1.Columns(1).Name = student.Weight
                Else
                    DataGridView1.Rows.Add(student.Name, student.Weight)
                End If
            ElseIf Index = 2 Then
                If i = 1 Then
                    DataGridView1.Columns(0).Name = student.Name
                    DataGridView1.Columns(1).Name = student.Height
                Else
                    DataGridView1.Rows.Add(student.Name, student.Height)
                End If

            ElseIf Index = 3 Then
                If i = 1 Then
                    DataGridView1.Columns(0).Name = student.Name
                    DataGridView1.Columns(1).Name = student.Age
                Else
                    DataGridView1.Rows.Add(student.Name, student.Age)
                End If
            ElseIf Index = 4 Then
                If i = 1 Then
                    DataGridView1.Columns(0).Name = student.Name
                    DataGridView1.Columns(1).Name = student.ShoesSize
                Else
                    DataGridView1.Rows.Add(student.Name, student.ShoesSize)
                End If
            End If
            'End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileHelperEngine = New FileHelperEngine(Of Student)
        Dim students = fileHelperEngine.ReadFile(Path.Combine(Application.StartupPath, "..\..\..\Statistics_students_dataset_22_23 - Foglio1.csv"))
        Dim i As Integer = 0

        For Each student In students
            i += 1

            If i = 1 Then
                DataGridView1.ColumnCount = 5
                DataGridView1.Columns(0).Name = student.Name
                DataGridView1.Columns(1).Name = student.Weight
                DataGridView1.Columns(2).Name = student.Height
                DataGridView1.Columns(3).Name = student.Age
                DataGridView1.Columns(4).Name = student.ShoesSize
            Else
                DataGridView1.Rows.Add(student.Name, student.Weight, student.Height, student.Age, student.ShoesSize)
            End If
        Next
    End Sub
End Class
