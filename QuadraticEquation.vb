Public Class QuadraticEquation
    'Dim a As Double
    'Dim b As Double
    'Dim c As Double
    Dim solution As Double

    Private Function delta(_a As Double, _b As Double, _c As Double)
        Return Math.Pow(_b, 2) - 4 * _a * _c
    End Function

    Public Sub solve(_a As Double, _b As Double, _c As Double, _sign As Integer)
        solution = (-_b + Math.Sign(_sign) * Math.Sqrt(Math.Abs(delta(_a, _b, _c)))) / (2 * _a)
    End Sub

    Public Function getSolution(_a As Double, _b As Double, _c As Double, _sign As Integer)
        solve(_a, _b, _c, _sign)
        Return solution
    End Function
    Public Function getSolution()
        Return solution
    End Function
End Class
