Module GlobalVar
    Dim maxAccel As Integer
    Dim maxSpeed As Integer
    Dim minSpeed As Integer

    Public Function getMaxAccel()
        Return maxAccel
    End Function

    Public Function getMaxSpeed()
        Return maxSpeed
    End Function

    Public Function getMinSpeed()
        Return minSpeed
    End Function
    Public Sub setMaxSpeed(_maxSpeed As Integer)
        maxSpeed = _maxSpeed
    End Sub

    Public Sub setMaxAccel(_maxAccel As Integer)
        maxAccel = _maxAccel
    End Sub

    Public Sub setMinSpeed(_minSpeed)
        minSpeed = _minSpeed
    End Sub
End Module
