Module GlobalVar
    Private maxAccel As Integer
    Private maxSpeed As Integer
    Private minSpeed As Integer
    Private length1 As Integer
    Private length2 As Integer
    Private alpha As New Angles()
    Private beta As New Angles()

    Public Function getMaxAccel()
        Return maxAccel
    End Function

    Public Function getMaxSpeed()
        Return maxSpeed
    End Function

    Public Function getMinSpeed()
        Return minSpeed
    End Function

    Public Function getDAlpha()
        Return alpha.getDAngle()
    End Function

    Public Function getDBeta()
        Return beta.getDAngle()
    End Function

    Public Function getLength1()
        Return length1
    End Function

    Public Function getLength2()
        Return length2
    End Function

    Public Function getAlpha()
        Return alpha
    End Function

    Public Function getBeta()
        Return beta
    End Function

    Public Sub setMaxSpeed(_maxSpeed As Integer)
        maxSpeed = _maxSpeed
    End Sub

    Public Sub setMaxAccel(_maxAccel As Integer)
        maxAccel = _maxAccel
    End Sub

    Public Sub setMinSpeed(_minSpeed As Integer)
        minSpeed = _minSpeed
    End Sub

    Public Sub setDAlpha(_steps As Integer)
        alpha.setDAngle(2 * Math.PI / _steps)
    End Sub

    Public Sub setDBeta(_steps As Integer)
        beta.setDAngle(2 * Math.PI / _steps)
    End Sub

    Public Sub setLength1(_length1 As Integer)
        length1 = _length1
    End Sub

    Public Sub setLength2(_length2 As Integer)
        length2 = _length2
    End Sub

    Public Sub setAlpha(_alpha As Double, _beta As Double)
        alpha.setMainAngle(_alpha)
        alpha.setSecondAngle(_beta)
    End Sub

    Public Sub setBeta(_beta As Double, _alpha As Double)
        beta.setMainAngle(_beta)
        beta.setSecondAngle(_alpha)
    End Sub
End Module
