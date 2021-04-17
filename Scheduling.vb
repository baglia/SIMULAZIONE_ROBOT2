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

    Public Sub startCalcLoop()
        If GlobalVar.getStart Then
            'setup
            Dim trap As New Trapezoidal(GlobalVar.getMaxSpeed, GlobalVar.getDistance, GlobalVar.getMaxAccel)
            GlobalVar.setStart(False)
            'loop
            calcLoop()
        End If
    End Sub
    Private Sub calcLoop()
        While (True)

        End While
    End Sub
End Class
