Public Class MovimentoCircolare
    Dim pointPartenza As New Point
    Dim pointArrivo As New Point
    Dim pointIntermedio As New Point
    Dim circle As New Circle()

    Public Sub New()

    End Sub

    Public Sub New(_point1 As Point, _point2 As Point, _point3 As Point)
        circle.calculateCircle(_point1, _point2, _point3)

    End Sub


End Class
