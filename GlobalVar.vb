Module GlobalVar
    Dim maxAccel As Integer
    Dim maxSpeed As Integer
    Dim minSpeed As Integer
    Dim dAlpha As Double
    Dim dBeta As Double
    Dim GlobalVar As Double
    Dim GlobalVar As Double

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
        Return dAlpha
    End Function

    Public Function getDBeta()
        Return dBeta
    End Function

    Public Function getLength1()
        Return GlobalVar
    End Function

    Public Function getLength2()
        Return GlobalVar
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
        dAlpha = 2 * Math.PI / _steps
    End Sub

    Public Sub setDBeta(_steps As Integer)
        dBeta = 2 * Math.PI / _steps
    End Sub

    Public Sub setLength1(_length1 As Integer)
        GlobalVar = _length1
    End Sub

    Public Sub setLength2(_length2 As Integer)
        GlobalVar = _length2
    End Sub
End Module
