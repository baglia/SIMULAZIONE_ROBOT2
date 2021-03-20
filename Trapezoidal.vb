Public Class Trapezoidal
    Dim line1 As New Line()
    Dim line2 As New Line()
    Dim line3 As New Line()
    Dim point1 As New Point
    Dim point2 As New Point
    Dim isError As Boolean
    Dim distance As Double

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
End Class
