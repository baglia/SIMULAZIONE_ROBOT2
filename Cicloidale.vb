Public Class Cicloidale
    Dim a As Double
    Dim b As Double
    Dim distance As Double
    Dim isError As Boolean

    Public Sub New()

    End Sub

    Public Sub New(_maxSpeed As Integer, _distance As Double)
        If _maxSpeed < GlobalVar.getMaxSpeed() Then
            a = (_maxSpeed - GlobalVar.getMinSpeed()) / 2
            b = 2 * Math.PI / _distance
            isError = False
        Else
            isError = True
        End If
    End Sub

    Public Function getSpeed(_distance As Double)
        If _distance < distance Then
            isError = False
            Return a * (Math.Cos(b * _distance + Math.PI) + 1) + GlobalVar.getMinSpeed()
        Else
            isError = True
            Return -1
        End If
    End Function

    Public Function getError()
        Return isError
    End Function
End Class
