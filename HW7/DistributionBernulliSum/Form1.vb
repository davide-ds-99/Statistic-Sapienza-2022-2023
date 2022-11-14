Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim n = 100
    Dim coin As New List(Of String)({"T", "C"})

    Function CheckLimit()
        If String.IsNullOrEmpty(TextBoxLambda.Text) Then
            MsgBox("Insert Lambda into Box (es. 1,...,100)")
            Return False
        End If
        Return True
    End Function
    Private Sub ButtonIteration_Click(sender As Object, e As EventArgs) Handles ButtonIteration.Click
        Chart.Titles.Clear()
        Chart.Series.Clear()
        If CheckLimit() Then
            Try
                'CHART
                Chart.Titles.Add("@TO-DO")
                Dim s As New Series
                s.Name = "@TO-DO"
                'Change to a line graph.
                s.ChartType = SeriesChartType.Column

                Dim lambda = CInt(TextBoxLambda.Text)

                Dim dictionary = New Dictionary(Of String, Integer)
                For Each side In coin
                    dictionary.Add(side, 0)
                Next
                Dim random As New Random
                Dim temp_random As Integer

                For index As Integer = 0 To n - 1
                    temp_random = random.Next(1, 101)
                    Console.WriteLine(temp_random)
                    If temp_random >= lambda Then
                        dictionary(coin(0)) += 1
                    Else
                        dictionary(coin(1)) += 1
                    End If
                Next
                Console.WriteLine("############")
                Console.WriteLine(dictionary(coin(0)))
                Console.WriteLine(dictionary(coin(1)))
            Catch ex As Exception
                MsgBox("Insert an Integer and not anymore")
            End Try
        End If
    End Sub
End Class
