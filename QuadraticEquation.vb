Public Class QuadraticEquation
    'Dim a As Double
    'Dim b As Double
    'Dim c As Double
    Dim solution As Double

    Private Function delta(a As Double, b As Double, c As Double)
        Return Math.Pow(b, 2) - 4 * a * c
    End Function

    Public Sub solve(a As Double, b As Double, c As Double, sign As Integer)
        solution = (-b + Math.Sign(sign) * Math.Sqrt(Math.Abs(delta(a, b, c)))) / (2 * a)
    End Sub
End Class
