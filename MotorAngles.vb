Public Class MotorAngles
    Private mainAngle As New Angle
    Private secondAngle As New Angle
    Private dAngle As New Angle

    Public Sub New()
    End Sub

    Public Sub New(_step As Integer)
        dAngle.setRad(CDbl(Math.PI * 2 / _step))
    End Sub

    Public Sub New(_angle As MotorAngles)
        mainAngle.setRad(_angle.getMainAngle())
        secondAngle.setRad(_angle.getSecondAngle())
        dAngle.setRad(_angle.getDAngle())
    End Sub

    Public Sub setDAngle(_step As Integer)
        dAngle.setRad(CDbl(Math.PI * 2 / _step))
    End Sub

    Public Sub setMainAngle(_angle As Double)
        mainAngle.setRad(_angle)
    End Sub

    Public Sub setSecondAngle(_secondAngle As Double)
        secondAngle.setRad(_secondAngle)
    End Sub

    Public Function getDAngle() As Double
        Return dAngle.getRad
    End Function

    Public Function getMainAngle() As Double
        Return mainAngle.getRad
    End Function

    Public Function getSecondAngle() As Double
        Return secondAngle.getRad
    End Function

    Public Sub copy(_angle As MotorAngles)
        mainAngle.setRad(_angle.getMainAngle())
        secondAngle.setRad(_angle.getSecondAngle())
        dAngle.setRad(_angle.getDAngle())
    End Sub
End Class
