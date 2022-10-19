Public Class Interval
    Implements IComparable(Of Interval)

    Public LowerEnd As Integer
    Public UpperEnd As Integer

    Function ContainsValue(v As Double) As Boolean
        Return v > Me.LowerEnd AndAlso v <= Me.UpperEnd
    End Function

    Overrides Function ToString() As String
        Return "(" & LowerEnd & "  " & UpperEnd & "]"

    End Function

    Public Function CompareTo(other As Interval) As Integer Implements System.IComparable(Of Interval).CompareTo
        Return Comparer(Of Double).Default.Compare(Me.LowerEnd, other.LowerEnd)
    End Function
End Class
