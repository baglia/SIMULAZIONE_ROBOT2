Public Class Trapezoidal
    Private line1 As New Line()
    Private line2 As New Line()
    Private line3 As New Line()
    Private point1 As New Point
    Private point2 As New Point
    Private isError As Boolean
    Private distance As Double

    Public Sub New()

    End Sub

    Public Sub New(_maxSpeed As Integer, _distance As Double, _accel As Double)
        If _accel < GlobalVar.getMaxAccel() Then
            calculateProfile(_accel, _distance, _maxSpeed)
            isError = False
        Else
            isError = True
        End If
    End Sub

    Public Sub New(_distance As Double, _time As Integer)
        Dim accel As Double
        accel = 2 * (GlobalVar.getMaxSpeed() - GlobalVar.getMinSpeed()) / (_time - _distance / GlobalVar.getMaxSpeed())
        If accel < GlobalVar.getMaxAccel() Then
            calculateProfile(accel, _distance, GlobalVar.getMaxSpeed())
            isError = False
        Else
            isError = True
        End If
    End Sub

    Private Sub calculateProfile(_accel As Integer, _distance As Double, _maxSpeed As Integer)
        line1.calculateLine(New Point(0, GlobalVar.getMinSpeed()), _accel)
        line2.calculateLine(New Point(0, _maxSpeed), 0)
        line3.calculateLine(New Point(_distance, GlobalVar.getMinSpeed()), -_accel)
        point1 = line1.getIntercectionPoint(line2)
        point2 = line2.getIntercectionPoint(line3)
        distance = _distance
    End Sub

    Public Function getSpeed(_distance As Double)
        If _distance <= distance Then
            If _distance < point1.X Then
                Return line1.Y(_distance)
            ElseIf _distance > point1.X And _distance < point2.X Then
                Return line2.Y(_distance)
            Else
                Return line3.Y(_distance)
            End If
            isError = False
        Else
            isError = True
            Return -1
        End If
    End Function

    Public Function getError()
        Return isError
    End Function

    Public Function getLine1()
        Return line1
    End Function

    Public Function getLine2()
        Return line2
    End Function

    Public Function getLine3()
        Return line3
    End Function

    Public Function getPoint1()
        Return point1
    End Function

    Public Function getPoint2()
        Return point2
    End Function

    Public Function getDistance()
        Return distance
    End Function

    Public Sub copy(_legge As Trapezoidal)
        line1.copy(_legge.getLine1())
        line2.copy(_legge.getLine2())
        line3.copy(_legge.getLine3())
        point1.X = _legge.getPoint1().x
        point1.Y = _legge.getPoint1().y
        point2.X = _legge.getPoint2().x
        point2.Y = _legge.getPoint2().y
        distance = _legge.getDistance()
    End Sub
End Class
