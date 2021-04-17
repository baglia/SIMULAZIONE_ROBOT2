Public Class Scheduling
    Private periods1 As New Queue(Of Integer)
    Private periods2 As New Queue(Of Integer)



    Public Function getPeriod1()
        If periods1.Count = 0 Then
            Return -1
        End If
        Return periods1.Dequeue()
    End Function

    Public Function getPeriod2()
        If periods2.Count = 0 Then
            Return -1
        End If
        Return periods2.Dequeue()
    End Function

    Public Async Sub startCalcLoop()
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
        periods1.Enqueue(_movementLinear.getNextPeriodA(True))
        periods2.Enqueue(_movementLinear.getNextPeriodB(True))
        While (True)
            periods1.Enqueue(_movementLinear.getNextPeriodA(False))
            periods2.Enqueue(_movementLinear.getNextPeriodB(False))
        End While
    End Sub

    Private Sub calcLoop(_movementCircular As MovimentoCircolare)
        While (True)

        End While
    End Sub
End Class
