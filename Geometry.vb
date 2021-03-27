Module Geometry
    Public Function midPoint(_point1 As Point, _point2 As Point)
        Return New Point((_point1.X + _point2.X) / 2, ((_point1.Y + _point2.Y) / 2))
    End Function

    Public Function pointDistance(_point1 As Point, _point2 As Point)
        Return Math.Sqrt(Math.Pow(_point1.X - _point2.X, 2) + Math.Pow(_point1.Y - _point2.Y, 2))
    End Function
End Module
