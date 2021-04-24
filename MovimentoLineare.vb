Public Class MovimentoLineare
    Private firstPoint As New PointC
    Private lastPoint As New PointC
    Private targetLine As New Line
    Private cicloidale As New Cicloidale()
    Private trapezoidal As New Trapezoidal()
    Private isTrapezoidal As Boolean

    Public Sub New()
    End Sub

    Public Sub New(_firstPoint As PointC, _lastpoint As PointC, _cycloidal As Cicloidale)
        firstPoint.copy(_firstPoint)
        lastPoint.copy(_lastpoint)
        targetLine.calculateLine(firstPoint, lastPoint)
        cicloidale.copy(_cycloidal)
        isTrapezoidal = False
    End Sub

    Public Sub New(_firstPoint As PointC, _lastpoint As PointC, _trapezoidal As Trapezoidal)
        firstPoint.copy(_firstPoint)
        lastPoint.copy(_lastpoint)
        targetLine.calculateLine(firstPoint, lastPoint)
        trapezoidal.copy(_trapezoidal)
        isTrapezoidal = True
    End Sub

    Public Function setMovement(_firstPoint As PointC, _lastPoint As PointC, _legge As Cicloidale)
        If _firstPoint.Equals(_lastPoint) Then
            Return False
        End If
        isTrapezoidal = False
        cicloidale.copy(_legge)
        firstPoint.copy(_firstPoint)
        lastPoint.copy(_lastPoint)
        targetLine.calculateLine(_firstPoint, _lastPoint)
        Return True
    End Function

    Public Function setMovement(_firstPoint As PointC, _lastPoint As PointC, _legge As Trapezoidal)
        If _firstPoint.Equals(_lastPoint) Then
            Return False
        End If
        isTrapezoidal = True
        trapezoidal.copy(_legge)
        firstPoint.copy(_firstPoint)
        lastPoint.copy(_lastPoint)
        targetLine.calculateLine(_firstPoint, _lastPoint)
        Return True
    End Function

    Public Function getDistance()
        Return Geometry.pointDistance(firstPoint, lastPoint)
    End Function

    Public Function getNextPeriodA(_isNew As Boolean) As Period
        Static point As PointC
        Dim vel As New Velocity
        If _isNew Then
            point.copy(firstPoint)
        End If
        Cinematica.calcAngles(point, True)
        If isTrapezoidal Then
            vel.Modul = trapezoidal.getSpeed(Geometry.pointDistance(point, firstPoint))

        Else
            vel.Modul = cicloidale.getSpeed(Geometry.pointDistance(point, firstPoint))
        End If
        vel.Phase = Math.Atan2(lastPoint.getY - firstPoint.getY, lastPoint.getX - firstPoint.getX)
        Dim omega As Double = Cinematica.calcJointSpeed(vel, point, True)
        If omega > 0 Then
            Dim angle As New Angle(GlobalVar.getAlpha.getMainAngle + GlobalVar.getAlpha.getDAngle, False)
            Cinematica.calcBeta(angle.getRad, targetLine, point, lastPoint, True)
        Else
            Dim angle As New Angle(GlobalVar.getAlpha.getMainAngle - GlobalVar.getAlpha.getDAngle, False)
            Cinematica.calcBeta(angle.getRad, targetLine, point, lastPoint, True)
        End If
        point.copy(Cinematica.calcPointFromAngles(GlobalVar.getAlpha.getMainAngle, GlobalVar.getAlpha.getSecondAngle))
        If Geometry.pointDistance(point, lastPoint) < GlobalVar.getTolerance Then
            Return New Period(True)
        End If
        Return New Period(CInt((GlobalVar.getAlpha.getDAngle / omega) * 1000))
    End Function

    Public Function getNextPeriodB(_isNew As Boolean) As Period
        Static point As PointC
        Dim vel As New Velocity
        If _isNew Then
            point.copy(firstPoint)
        End If
        Cinematica.calcAngles(point, False)
        If isTrapezoidal Then
            vel.Modul = trapezoidal.getSpeed(Geometry.pointDistance(point, firstPoint))
        Else
            vel.Modul = cicloidale.getSpeed(Geometry.pointDistance(point, firstPoint))
        End If
        vel.Phase = Math.Atan2(lastPoint.getY - firstPoint.getY, lastPoint.getX - firstPoint.getX)
        Dim omega As Double = Cinematica.calcJointSpeed(vel, point, False)
        If omega > 0 Then
            Dim angle As New Angle(GlobalVar.getBeta.getMainAngle + GlobalVar.getBeta.getDAngle, False)
            Cinematica.calcAlpha(angle.getRad, targetLine, point, lastPoint, False)
        Else
            Dim angle As New Angle(GlobalVar.getBeta.getMainAngle - GlobalVar.getBeta.getDAngle, False)
            Cinematica.calcAlpha(angle.getRad, targetLine, point, lastPoint, False)
        End If
        point.copy(Cinematica.calcPointFromAngles(GlobalVar.getBeta.getSecondAngle, GlobalVar.getBeta.getMainAngle))
        If Geometry.pointDistance(point, lastPoint) < GlobalVar.getTolerance Then
            Return New Period(True)
        End If
        Return New Period(CInt((GlobalVar.getAlpha.getDAngle / omega) * 1000))
    End Function

End Class
