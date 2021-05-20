Public Class MovimentoLineare
    Private firstPoint As New PointC
    Private lastPoint As New PointC
    Private targetLine As New Line
    Private cicloidale As New Cicloidale()
    Private trapezoidal As New Trapezoidal()
    Private isTrapezoidal As Boolean
    Dim fileA As System.IO.StreamWriter
    Dim fileB As System.IO.StreamWriter
    Dim dataA, dataB As String



    Public Sub New()
        creazioneFile()
    End Sub

    Public Sub New(_firstPoint As PointC, _lastpoint As PointC, _cycloidal As Cicloidale)
        firstPoint.copy(_firstPoint)
        lastPoint.copy(_lastpoint)
        targetLine.calculateLine(firstPoint, lastPoint)
        cicloidale.copy(_cycloidal)
        isTrapezoidal = False
        creazioneFile()
    End Sub

    Public Sub New(_firstPoint As PointC, _lastpoint As PointC, _trapezoidal As Trapezoidal)
        firstPoint.copy(_firstPoint)
        lastPoint.copy(_lastpoint)
        targetLine.calculateLine(firstPoint, lastPoint)
        trapezoidal.copy(_trapezoidal)
        isTrapezoidal = True
        creazioneFile()
    End Sub

    Private Sub creazioneFile()
        fileA = My.Computer.FileSystem.OpenTextFileWriter("D:\fileA.txt", True)
        fileB = My.Computer.FileSystem.OpenTextFileWriter("D:\fileB.txt", True)

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
        Static point As New PointC
        Dim vel As New Velocity
        If _isNew Then
            point.copy(firstPoint)
            Cinematica.calcAngles(point, True)
        End If

        If Not targetLine.isPointOf(point) Then
            'Return New Period(True, True)
            Dim a As Integer = 22
        End If

        If isTrapezoidal Then
            vel.Modul = trapezoidal.getSpeed(Geometry.pointDistance(point, firstPoint))
        Else
            vel.Modul = cicloidale.getSpeed(Geometry.pointDistance(point, firstPoint))
        End If
        vel.Phase = Math.Atan2(lastPoint.getY - firstPoint.getY, lastPoint.getX - firstPoint.getX)
        Dim omega As Double = Cinematica.calcJointSpeed(vel, point, True)
        If omega > 0 Then
            Dim angle As New Angle(GlobalVar.getAlpha.getMainAngle + GlobalVar.getAlpha.getDAngle, False)
            Cinematica.calcBeta(angle, targetLine, point, lastPoint, True)
        Else
            Dim angle As New Angle(GlobalVar.getAlpha.getMainAngle - GlobalVar.getAlpha.getDAngle, False)
            Cinematica.calcBeta(angle, targetLine, point, lastPoint, True)
        End If
        point.copy(Cinematica.calcPointFromAngles(GlobalVar.getAlpha.getMainAngle, GlobalVar.getAlpha.getSecondAngle))
        fileB.WriteLine(point.getX.ToString + ";" + point.getY.ToString + ";")
        'fileB.WriteLine(GlobalVar.getAlpha.getMainAngle.ToString + ";" + GlobalVar.getAlpha.getSecondAngle.ToString + ";")
        If Geometry.pointDistance(point, lastPoint) < GlobalVar.getTolerance Then
            Return New Period(True, False)
        End If
        Return New Period((GlobalVar.getAlpha.getDAngle / omega) * 1000)
    End Function

    Public Function getNextPeriodB(_isNew As Boolean) As Period

        Static point As New PointC
        Dim vel As New Velocity
        If _isNew Then
            point.copy(firstPoint)
            Cinematica.calcAngles(point, False)
        End If

        If Not targetLine.isPointOf(point) Then
            'Return New Period(True, True)
            Dim a As Integer = 22
        End If
        If isTrapezoidal Then
            vel.Modul = trapezoidal.getSpeed(Geometry.pointDistance(point, firstPoint))
        Else
            vel.Modul = cicloidale.getSpeed(Geometry.pointDistance(point, firstPoint))
            If cicloidale.getError Then
                Dim a As Integer = 22
            End If
        End If
            vel.Phase = Math.Atan2(lastPoint.getY - firstPoint.getY, lastPoint.getX - firstPoint.getX)
        Dim omega As Double = Cinematica.calcJointSpeed(vel, point, False)
        If omega > 0 Then
            Dim angle As New Angle(GlobalVar.getBeta.getMainAngle + GlobalVar.getBeta.getDAngle, False)
            Cinematica.calcAlpha(angle, targetLine, point, lastPoint, False)
        Else
            Dim angle As New Angle(GlobalVar.getBeta.getMainAngle - GlobalVar.getBeta.getDAngle, False)
            Cinematica.calcAlpha(angle, targetLine, point, lastPoint, False)
        End If
        point.copy(Cinematica.calcPointFromAngles(GlobalVar.getBeta.getSecondAngle, GlobalVar.getBeta.getMainAngle))
        fileA.WriteLine(point.getX.ToString + ";" + point.getY.ToString + ";")

        If Geometry.pointDistance(point, lastPoint) < GlobalVar.getTolerance Then
            Return New Period(True, False)
        End If
        Return New Period((GlobalVar.getBeta.getDAngle / omega) * 1000)
    End Function

End Class
