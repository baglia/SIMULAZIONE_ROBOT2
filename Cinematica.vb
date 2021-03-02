Public Class Cinematica
    Dim alpha As Double
    Dim beta As Double
    Dim length1 As Double
    Dim length2 As Double
    Dim firstPoint As New Point
    Dim lastPoint As New Point
    Dim midPoint As New Point
    Dim pointJoint1 As New Point
    Dim isCounterClockwise As Boolean
    Dim time As Double
    Dim isLinear As Boolean
    Dim linearMov As New MovimentoLineare
    Dim circularMov As New MovimentoCircolare

    Private Function calcModule(_point As Point)
        Return Math.Sqrt(Math.Pow(_point.X, 2) + Math.Pow(_point.Y, 2))
    End Function

    Private Function calcPhase(_point As Point)
        Return Math.Atan2(_point.Y, _point.X)
    End Function

    Private Sub calcAngles(_point As Point)
        alpha = calcPhase(_point) + Math.Acos((Math.Pow(length1, 2) + Math.Pow(calcModule(_point), 2) - Math.Pow(length2, 2)) / (2 * length1 * calcModule(_point)))
        beta = Math.PI - Math.Acos((Math.Pow(length1, 2) - Math.Pow(calcModule(_point), 2) + Math.Pow(length2, 2)) / (2 * length1 * length2)) - alpha
    End Sub

    Private Sub calcJoint1(_point As Point)
        calcAngles(_point)
        pointJoint1.X = length1 * Math.Cos(alpha)
        pointJoint1.Y = length1 * Math.Sin(alpha)
    End Sub

    'Public Function setTime(_time As Double)
    '    time = _time
    'End Function

    'Public Function getPuntoJoint1()
    '    Return pointJoint1
    'End Function



End Class
