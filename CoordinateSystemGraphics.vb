Public Class CoordinateSystemGraphics
    Private offsetX As Integer
    Private offsetY As Integer
    Private factor As Integer

    Public Sub New()
    End Sub

    Public Sub New(_offsetX As Integer, _offsetY As Integer, _factor As Integer)
        setValues(_offsetX, _offsetY, _factor)
    End Sub

    Public Function graphic2World(_point As PointF) As PointC
        Return New PointC((_point.X - offsetX) * factor, (_point.Y - offsetY) * factor)
    End Function

    Public Function world2Graphic(_point As PointC) As PointF
        Return New PointF((_point.getX / factor) + offsetX, (_point.getY / factor) + offsetY)
    End Function

    Public Function toPointF(_point As PointC) As PointF
        Return New PointF(_point.getX, _point.getY)
    End Function

    Public Function toPointC(_point As PointF) As PointC
        Return New PointC(_point.X, _point.Y)
    End Function

    Public Sub setValues(_offsetX As Integer, _offsetY As Integer, _factor As Integer)
        offsetX = _offsetX
        offsetY = _offsetY
        factor = _factor
    End Sub
End Class

