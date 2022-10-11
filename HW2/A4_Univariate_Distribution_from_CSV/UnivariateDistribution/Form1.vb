Imports System.IO
Imports FileHelpers

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileHelperEngine = New FileHelperEngine(Of Student)
        Dim students = fileHelperEngine.ReadFile(Path.Combine(Application.StartupPath, "..\..\..\Statistics_students_dataset_22_23 - Foglio1.csv"))
        Dim i As Integer = 0

        For Each student In students
            i += 1

            If i = 1 Then
                DataGridView1.ColumnCount = 2
                DataGridView1.Columns(0).Name = student.Name
                DataGridView1.Columns(1).Name = student.Age
            Else
                DataGridView1.Rows.Add(student.Name, student.Age)
            End If
        Next
    End Sub
End Class
