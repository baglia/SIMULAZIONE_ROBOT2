Public Class Circle
    Private pointCenter As Point
    Private radius As Double


    Public Sub New(_radius As Double)
        If (Not setRadius(_radius)) Then
            radius = 0
        End If
    End Sub

    Public Sub New()
    End Sub

    Public Function setRadius(_radius As Double)
        If _radius <= 0 Then
            Return False
        End If
        radius = _radius
        Return True
    End Function

    Public Function calculateCircle(_point1 As Point, _point2 As Point, _point3 As Point)

        Dim midPoint1 As New Point(Geometry.midPoint(_point1, _point2).x, Geometry.midPoint(_point1, _point2).y)
        Dim midPoint2 As New Point(Geometry.midPoint(_point2, _point3).x, Geometry.midPoint(_point2, _point3).y)
        Dim line1 As New Line(_point1, _point2)
        Dim line2 As New Line(_point2, _point3)
        If line1.Equals(line2) Then
            Return False
        End If
        Dim lineOrt1 As New Line(midPoint1, CDbl(line1.getOrtogonalSlope()))
        Dim lineOrt2 As New Line(midPoint2, CDbl(line2.getOrtogonalSlope()))
        pointCenter = lineOrt1.getIntercectionPoint(lineOrt2)
        radius = Geometry.pointDistance(pointCenter, _point1)
        Return True
    End Function
End Class
