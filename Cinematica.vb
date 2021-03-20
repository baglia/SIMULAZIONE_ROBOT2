Public Class Cinematica
    Dim alpha As Double
    Dim beta As Double
    Dim pointJoint1 As New Point


    Private Function calcModule(_point As Point)
        Return Math.Sqrt(Math.Pow(_point.X, 2) + Math.Pow(_point.Y, 2))
    End Function

    Private Function calcPhase(_point As Point)
        Return Math.Atan2(_point.Y, _point.X)
    End Function

    Private Sub calcAngles(_point As Point)
        alpha = calcPhase(_point) + Math.Acos((Math.Pow(GlobalVar.getLength1(), 2) + Math.Pow(calcModule(_point), 2) - Math.Pow(GlobalVar.getLength2(), 2)) / (2 * GlobalVar.getLength2() * calcModule(_point)))
        beta = Math.PI - Math.Acos((Math.Pow(GlobalVar.getLength1(), 2) - Math.Pow(calcModule(_point), 2) + Math.Pow(GlobalVar.getLength2(), 2)) / (2 * GlobalVar.getLength2() * GlobalVar.getLength2())) - alpha
    End Sub

    Public Sub calcJoint1(_point As Point)
        calcAngles(_point)
        pointJoint1.X = GlobalVar.getLength1() * Math.Cos(alpha)
        pointJoint1.Y = GlobalVar.getLength1() * Math.Sin(alpha)
    End Sub


End Class
