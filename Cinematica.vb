Module Cinematica
    Public Sub calcAngles(_point As Point, _isAlpha As Boolean)
        Dim alpha As Double
        Dim beta As Double
        alpha = calcPhase(_point) + Math.Acos((Math.Pow(GlobalVar.getLength1(), 2) + Math.Pow(calcModule(_point), 2) - Math.Pow(GlobalVar.getLength2(), 2)) / (2 * GlobalVar.getLength2() * calcModule(_point)))
        beta = Math.PI - Math.Acos((Math.Pow(GlobalVar.getLength1(), 2) - Math.Pow(calcModule(_point), 2) + Math.Pow(GlobalVar.getLength2(), 2)) / (2 * GlobalVar.getLength2() * GlobalVar.getLength2())) - alpha
        If _isAlpha Then
            GlobalVar.setAlpha(alpha, beta)
        Else
            GlobalVar.setBeta(beta, alpha)
        End If
    End Sub

    Public Function calcJoint1()
        Dim pointJoint1 As Point
        pointJoint1.X = GlobalVar.getLength1() * Math.Cos(GlobalVar.getAlpha())
        pointJoint1.Y = GlobalVar.getLength1() * Math.Sin(GlobalVar.getAlpha())
        Return pointJoint1
    End Function

    Public Function calcOmegaA(_point As Point, _vel As Double, _tangente As Line)

    End Function
    Private Function calcModule(_point As Point)
        Return Math.Sqrt(Math.Pow(_point.X, 2) + Math.Pow(_point.Y, 2))
    End Function

    Private Function calcPhase(_point As Point)
        Return Math.Atan2(_point.Y, _point.X)
    End Function




End Module
