Public Class MovimentoCircolare
    Private pointPartenza As New Point
    Private pointArrivo As New Point
    Private pointIntermedio As New Point
    Private circle As New Circle()

    Public Sub New()

    End Sub

    Public Sub New(_point1 As Point, _point2 As Point, _point3 As Point)
        circle.calculateCircle(_point1, _point2, _point3)

    End Sub


End Class
