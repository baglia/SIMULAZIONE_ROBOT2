Public Class Cinematica
    Dim alpha As Double
    Dim beta As Double
    Dim braccio1 As Double
    Dim braccio2 As Double
    Dim pointPartenza As New Point
    Dim pointArrivo As New Point
    Dim pointintermedio As New Point
    Dim pointJoint1 As New Point
    Dim isAntiorario As Boolean
    Dim tempo As Double
    Dim isLineare As Boolean
    Dim lineare As New MovimentoLineare
    Dim circolare As New MovimentoCircolare
    Dim raggio As Double

    Private Function modulo(punto As Point)
        Return Math.Sqrt(Math.Pow(punto.X, 2) + Math.Pow(punto.Y, 2))
    End Function

    Private Function fase(punto As Point)
        Return Math.Atan2(punto.Y, punto.X)
    End Function

    Private Sub calcoloAngoli(punto As Point)
        alpha = fase(punto) + Math.Acos((Math.Pow(braccio1, 2) + Math.Pow(modulo(punto), 2) - Math.Pow(braccio2, 2)) / (2 * braccio1 * modulo(punto)))
        beta = Math.PI - Math.Acos((Math.Pow(braccio1, 2) - Math.Pow(modulo(punto), 2) + Math.Pow(braccio2, 2)) / (2 * braccio1 * braccio2)) - alpha
    End Sub

    Private Sub calcoloJoint1(punto As Point)
        calcoloAngoli(punto)
        pointJoint1.X = braccio1 * Math.Cos(alpha)
        pointJoint1.Y = braccio1 * Math.Sin(alpha)
    End Sub

    Public Function setTempo(_tempo As Double)
        tempo = _tempo
    End Function

    Public Function getPuntoJoint1()
        Return pointJoint1
    End Function

    Private Function distanzaPunti(punto1 As Point, punto2 As Point)
        Return Math.Sqrt(Math.Pow(punto1.X - punto2.X, 2) + Math.Pow(punto1.Y - punto2.Y, 2))
    End Function

End Class
