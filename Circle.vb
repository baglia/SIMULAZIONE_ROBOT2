Public Class Circle
    Dim pointCenter As Point
    Dim radius As Double


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

    Public Function calculateCircle(point1 As Point, point2 As Point, pointCenter As Point)
        Dim line As New Line(point1, point2)
        Dim ortogonalLine As New Line(point1, CDbl(line.getOrtogonalSlope()))
        Dim sign As Int16
        If point1.Y < point2.Y Then
            If point1.X < point2.X Then
                sign = -1
            Else
                sign = +1
            End If
        Else
            If point1.X < point2.X Then
                sign = +1
            Else
                sign = -1
            End If
        End If


    End Function
End Class
