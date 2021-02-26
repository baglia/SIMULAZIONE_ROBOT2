Public Class Line
    Dim slope As Double
    Dim offset As Double

    Public Sub New(point1 As Point, point2 As Point)
        calculateLine(point1, point2)
    End Sub

    Public Sub New(point As Point, _slope As Double)
        calculateLine(point, _slope)
    End Sub

    Public Function calculateLine(point1 As Point, point2 As Point)
        If point1.Equals(point2) Then
            Return False
        End If
        slope = (point1.Y - point2.Y) / (point1.X - point2.X)
        offset = point1.Y - point1.X * slope
        Return True
    End Function

    Public Function calculateLine(point As Point, _slope As Double)
        slope = _slope
        offset = point.Y - point.X * slope
    End Function

    Public Function X(Y As Double)
        Return (Y - offset) / slope
    End Function

    Public Function Y(X As Double)
        Return X * slope + offset
    End Function

    Public Function getSlope()
        Return slope
    End Function

    Public Function getOffset()
        Return offset
    End Function

    Public Function getOrtogonalSlope()
        Dim ortogonalSlope As Double
        ortogonalSlope = -1 / slope
        Return ortogonalSlope
    End Function

End Class
