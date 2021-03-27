﻿Public Class MovimentoLineare
    Private firstPoint As New Point
    Private lastPoint As New Point
    Private targetLine As New Line
    Private cicloidale As New Cicloidale()
    Private trapezoidal As New Trapezoidal()
    Private isTrapezoidal As Boolean

    Public Sub New()
    End Sub

    Public Function setMovement(_firstPoint As Point, _lastPoint As Point, _legge As Cicloidale)
        If _firstPoint.Equals(_lastPoint) Then
            Return False
        End If
        isTrapezoidal = False
        cicloidale.copy(_legge)
        firstPoint = _firstPoint
        lastPoint = _lastPoint
        targetLine.calculateLine(_firstPoint, _lastPoint)
        Return True
    End Function

    Public Function setMovement(_firstPoint As Point, _lastPoint As Point, _legge As Trapezoidal)
        If _firstPoint.Equals(_lastPoint) Then
            Return False
        End If
        isTrapezoidal = True
        trapezoidal.copy(_legge)
        firstPoint = _firstPoint
        lastPoint = _lastPoint
        targetLine.calculateLine(_firstPoint, _lastPoint)
        Return True
    End Function

    Public Function getDistance()
        Return Geometry.pointDistance(firstPoint, lastPoint)
    End Function

    Public Function getNextPeriodA(_isNew As Double)
        Static point As Point
        Dim vel As New Velocity
        If _isNew Then
            point.X = firstPoint.X
            point.Y = firstPoint.Y
        End If
        Dim period As Double
        Dim alpha As New Angles
        Cinematica.calcAngles(point, True)
        alpha.copy(GlobalVar.getAlpha())
        alpha.setMainAngle(alpha.getMainAngle + alpha.getDAngle)
        If isTrapezoidal Then
            vel.Modul = trapezoidal.getSpeed(Geometry.pointDistance(point, firstPoint))
        Else
            vel.Modul = cicloidale.getSpeed(Geometry.pointDistance(point, firstPoint))
        End If

        Return period
    End Function

    Public Function getNextPeriodB()
        Dim period As Double

        Return period
    End Function

End Class