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

    Public Function calcJoint1(_alpha As Double)
        Dim pointJoint1 As Point
        pointJoint1.X = GlobalVar.getLength1() * Math.Cos(_alpha)
        pointJoint1.Y = GlobalVar.getLength1() * Math.Sin(_alpha)
        Return pointJoint1

    End Function


    Private Function calcModule(_point As Point)
        Return Math.Sqrt(Math.Pow(_point.X, 2) + Math.Pow(_point.Y, 2))
    End Function

    Private Function calcPhase(_point As Point)
        Return Math.Atan2(_point.Y, _point.X)
    End Function

    Public Function calcJointSpeed(_velocity As Velocity, _point As Point, _isAlpha As Boolean) As Double
        'punto di giunzione tra V1 e V2
        Dim point12 As New Point
        'punto finale della velocità totale 
        Dim pointV2 As New Point(_velocity.Modul * Math.Cos(_velocity.Phase), _velocity.Modul * Math.Sin(_velocity.Phase))
        Dim Q2 As Double
        Dim omega As Double
        Dim phase As Double
        If _isAlpha Then
            Q2 = pointV2.Y - pointV2.X * Math.Tan(GlobalVar.getAlpha.getMainAngle)
            point12.X = Q2 / (Math.Tan(GlobalVar.getAlpha.getMainAngle + Math.PI / 2) - Math.Tan(GlobalVar.getBeta.getSecondAngle + Math.PI / 2))
            point12.Y = Math.Tan(GlobalVar.getAlpha.getMainAngle + Math.PI / 2) * point12.X
            omega = Geometry.pointDistance(New Point(0, 0), New Point(point12.X, point12.Y)) / GlobalVar.getLength1
            phase = Math.Atan2(point12.Y, point12.X)
            If Not GlobalVar.getAlpha.getMainAngle + Math.PI / 2.0 = phase Then
                omega *= -1
            End If
        Else
            Q2 = pointV2.Y - pointV2.X * Math.Tan(GlobalVar.getBeta.getMainAngle)
            point12.X = Q2 / (Math.Tan(GlobalVar.getAlpha.getMainAngle + Math.PI / 2) - Math.Tan(GlobalVar.getBeta.getSecondAngle + Math.PI / 2))
            point12.Y = Math.Tan(GlobalVar.getBeta.getMainAngle + Math.PI / 2) * point12.X
            omega = Geometry.pointDistance(pointV2, New Point(point12.X, point12.Y)) / GlobalVar.getLength2
            phase = Math.Atan2(pointV2.Y - point12.Y, pointV2.X - point12.X)
            If Not GlobalVar.getBeta.getMainAngle + Math.PI / 2.0 = phase Then
                omega *= -1
            End If
        End If
        Return omega
    End Function

    Public Function calcBeta(_alpha As Angles, _targetLine As Line, _previousPoint As Point, _lastPoint As Point, _isAlpha As Boolean) As Double
        Dim joint1 As New Point(calcJoint1(_alpha.getMainAngle).x, calcJoint1(_alpha.getMainAngle).y)
        Dim point1, point2, point As New Point
        point1.X = QuadraticEquation.solve(1 + Math.Pow(_targetLine.getSlope, 2), -2 * joint1.X + 2 * (_targetLine.getOffset - joint1.Y) * _targetLine.getSlope, Math.Pow(_targetLine.getOffset - joint1.Y, 2) + Math.Pow(joint1.X, 2) - Math.Pow(GlobalVar.getLength2, 2), 1)
        point1.Y = point1.X * _targetLine.getSlope + _targetLine.getOffset
        point2.X = QuadraticEquation.solve(1 + Math.Pow(_targetLine.getSlope, 2), -2 * joint1.X + 2 * (_targetLine.getOffset - joint1.Y) * _targetLine.getSlope, Math.Pow(_targetLine.getOffset - joint1.Y, 2) + Math.Pow(joint1.X, 2) - Math.Pow(GlobalVar.getLength2, 2), -1)
        point2.Y = point1.X * _targetLine.getSlope + _targetLine.getOffset
        If Geometry.pointDistance(_previousPoint, _lastPoint) > Geometry.pointDistance(_lastPoint, point1) Or Geometry.pointDistance(_previousPoint, _lastPoint) > Geometry.pointDistance(_previousPoint, point1) Then
            point.X = point2.X
            point.Y = point2.Y
        ElseIf Geometry.pointDistance(_previousPoint, _lastPoint) > Geometry.pointDistance(_lastPoint, point2) Or Geometry.pointDistance(_previousPoint, _lastPoint) > Geometry.pointDistance(_previousPoint, point2) Then
            point.X = point1.X
            point.Y = point1.Y
        ElseIf Geometry.pointDistance(_previousPoint, point1) < Geometry.pointDistance(_previousPoint, point2) Then
            point.X = point1.X
            point.Y = point1.Y
        Else
            point.X = point2.X
            point.Y = point2.Y
        End If
        calcAngles(point, _isAlpha)
    End Function

End Module
