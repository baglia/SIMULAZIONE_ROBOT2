Public Class Scheduling
    Private periods1 As New Queue(Of Period)
    Private periods2 As New Queue(Of Period)



    Public Function getPeriod1() As Period
        If periods1.Count = 0 Then
            Return New Period(False)
        End If
        Return periods1.Dequeue()
    End Function

    Public Function getPeriod2() As Period
        If periods2.Count = 0 Then
            Return New Period(False)
        End If
        Return periods2.Dequeue()
    End Function

    Public Sub startCalcLoop()
        If GlobalVar.getStart Then
            'setup
            Dim trap As New Trapezoidal(GlobalVar.getMaxSpeed, GlobalVar.getDistance, GlobalVar.getMaxAccel)
            Dim cyc As New Cicloidale(GlobalVar.getMaxSpeed, GlobalVar.getDistance)
            Dim movementLinear As New MovimentoLineare()
            If GlobalVar.getIsCycloidal Then
                movementLinear.setMovement(GlobalVar.getStartPoint, GlobalVar.getEndPoint, cyc)
            Else
                movementLinear.setMovement(GlobalVar.getStartPoint, GlobalVar.getEndPoint, trap)
            End If
            GlobalVar.setStart(False)
            'loop
            If GlobalVar.getIsLinear Then
                calcLoop(movementLinear)
            Else
                '!!!!!calcLoop() circolare
            End If
        End If
    End Sub

    Private Sub calcLoop(_movementLinear As MovimentoLineare)
        Dim period1, period2 As New Period
        periods1.Enqueue(_movementLinear.getNextPeriodA(True))
        periods2.Enqueue(_movementLinear.getNextPeriodB(True))
        While (True)
            period1.copy(_movementLinear.getNextPeriodA(False))
            period2.copy(_movementLinear.getNextPeriodB(False))
            If period1.getIsEnd And period2.getIsEnd Then
                Exit While
            End If
            periods1.Enqueue(period1)
            periods2.Enqueue(period2)
        End While
    End Sub

    Private Sub calcLoop(_movementCircular As MovimentoCircolare)
        While (True)

        End While
    End Sub
End Class
