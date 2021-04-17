Module Geometry
    Public Function midPoint(_point1 As PointC, _point2 As PointC) As PointC
        Return New PointC((_point1.getX + _point2.getX) / 2, ((_point1.getY + _point2.getY) / 2))
    End Function

    Public Function pointDistance(_point1 As PointC, _point2 As PointC) As Double
        Return Math.Sqrt(Math.Pow(_point1.getX - _point2.getX, 2) + Math.Pow(_point1.getY - _point2.getY, 2))
    End Function

    Public Function pointTransport(_point As PointC, _length As Double, _phase As Double) As PointC
        Return New PointC(_point.getX + _length * Math.Cos(_phase), _point.getY + _length * Math.Sin(_phase))
    End Function
End Module
