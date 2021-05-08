Public Class PointC
    Private x As Double
    Private y As Double

    Public Sub New()

    End Sub

    Public Sub New(_x As Double, _y As Double)
        x = _x
        y = _y
    End Sub

    Public Sub New(_point As PointC)
        x = _point.getX()
        y = _point.getY()
    End Sub

    Public Function getX() As Double
        Return x
    End Function

    Public Function getY() As Double
        Return y
    End Function

    Public Function copy(_point As PointC) As PointC
        x = _point.getX
        y = _point.getY
        Return New PointC(_point)
    End Function

    Public Sub setX(_x As Double)
        x = _x
    End Sub

    Public Sub setY(_y As Double)
        y = _y
    End Sub

    Public Function getPointF() As PointF
        Return New PointF(x, y)
    End Function

    Public Function isEqual(_pointC As PointC) As Boolean
        If Math.Round(getX, 3) = Math.Round(_pointC.getX, 3) And Math.Round(getY, 3) = Math.Round(_pointC.getY, 3) Then
            Return True
        End If
        Return False
    End Function

End Class
