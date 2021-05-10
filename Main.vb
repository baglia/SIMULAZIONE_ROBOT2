Imports System.Threading
Public Class Main

    Dim pointPartenza As New PointC
    Dim pointArrivo As New PointC
    Dim pointTerzoPunto As New PointC
    Dim setPartenza As Boolean = False
    Dim setArrivo As Boolean = False
    Dim setTerzoPunto As Boolean = False
    Dim isEndMovement As Boolean = True
    Dim scheduler As New Scheduling
    Dim alpha, beta As New Angle()
    Dim thPeriod1 As New Threading.Thread(AddressOf calcPeriod1)
    Dim thPeriod2 As New Threading.Thread(AddressOf calcPeriod2)
    Dim thPopulate As New Threading.Thread(AddressOf populateQueue)
    Dim pointConverter As New CoordinateSystemGraphics
    Dim value As Integer
    Const _FACTOR As Integer = 2000
    Private Shared LockObject As New Object()
    Private isError As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pointPartenza.setX(370000)
        pointPartenza.setY(260000)
        pointArrivo.setX(0)
        pointArrivo.setY(0)
        pointTerzoPunto.setX(0)
        pointTerzoPunto.setY(0)
        lblP_partenza.Text = lblP_partenza.Text + " (0;0)"
        lblP_arrivo.Text = lblP_arrivo.Text + " (0;0)"
        lblTerzoPunto.Text = lblP_arrivo.Text + " (0;0)"
        btnTerzoPunto.Enabled = False
        btnVersoRotazione.Enabled = False
        txtRaggio.Enabled = False
        alpha.setRad(0)
        beta.setRad(Math.PI / 2)
        numLength1.Value = 370000
        numLength2.Value = 260000
        numStep1.Value = 50000
        numStep2.Value = 25000
        numVmax.Value = 100000
        numVmin.Value = 10000
        numAmax.Value = 100
        numTolleranza.Value = 1000
        pointConverter.setValues(panelSimTop.Width / 2, panelSimTop.Height / 2, _FACTOR)
        'TimerSim.Start()
        setParam()
        comboTipoSpostamento.SelectedIndex = 0
        comboAccelerazioneLineare.SelectedIndex = 1
        Dim d As Double = Math.Acos(370000 ^ 4 / 370001 ^ 4)
    End Sub


    Private Sub panelSimTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelSimTop.MouseDown 'funzione viene lanciata 
        'quando clicco sul form (evento mouseDown)

        If setPartenza Then 'se sto settando la partenza salvo le coordinate del punto in cui ho cliccato in pointPartenza
            pointPartenza.copy(pointConverter.graphic2World(New PointF(e.X, e.Y)))
            setPartenza = False
            lblP_partenza.Text = "(X,Y) PARTENZA: (" + CStr(pointPartenza.getX) + "," + CStr(pointPartenza.getY) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
            btnTerzoPunto.BackColor = Color.LightGray
        End If

        If setArrivo Then
            pointArrivo.copy(pointConverter.graphic2World(New PointF(e.X, e.Y)))
            setArrivo = False
            lblP_arrivo.Text = "(X,Y) ARRIVO: (" + CStr(pointArrivo.getX) + "," + CStr(pointArrivo.getY) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
            btnTerzoPunto.BackColor = Color.LightGray
        End If

        If setTerzoPunto Then
            pointTerzoPunto.copy(pointConverter.graphic2World(New PointF(e.X, e.Y)))
            setTerzoPunto = False
            lblTerzoPunto.Text = "(X,Y) PUNTO INTERMEDIO: (" + CStr(pointTerzoPunto.getX) + "," + CStr(pointTerzoPunto.getY) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
            btnTerzoPunto.BackColor = Color.LightGray
        End If
        simulazione()

    End Sub

    Private Sub btnSetPosPartenza_Click(sender As Object, e As EventArgs) Handles btnSetPosPartenza.Click
        If setArrivo = False And setTerzoPunto = False Then 'verifico che non sia già attivo set arrivo
            setPartenza = True
            btnSetPosPartenza.BackColor = Color.Green
            btnSetPosArrivo.BackColor = Color.Red
            btnTerzoPunto.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnSetPosArrivo_Click(sender As Object, e As EventArgs) Handles btnSetPosArrivo.Click
        If setPartenza = False And setTerzoPunto = False Then 'verifico che non sia già attivo set partenza
            setArrivo = True
            btnSetPosPartenza.BackColor = Color.Red
            btnTerzoPunto.BackColor = Color.Red
            btnSetPosArrivo.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnTerzoPunto_Click(sender As Object, e As EventArgs) Handles btnTerzoPunto.Click
        If setPartenza = False And setArrivo = False Then 'verifico che non sia già attivo set partenza
            setTerzoPunto = True
            btnSetPosPartenza.BackColor = Color.Red
            btnSetPosArrivo.BackColor = Color.Red
            btnTerzoPunto.BackColor = Color.Green
        End If
    End Sub

    Private Sub simulazione()

        Dim gTop As Graphics = panelSimTop.CreateGraphics()
        Dim penRobot As New Pen(Color.Green, 8)
        Dim penLine As New Pen(Color.GreenYellow, 4)
        Dim penJoints As New Pen(Color.LightBlue, 8)
        Dim origin As New PointF(pointConverter.world2Graphic(New PointC(0, 0)).X, pointConverter.world2Graphic(New PointC(0, 0)).Y)
        Dim j1 As New PointF(pointConverter.world2Graphic(New PointC(GlobalVar.getLength1 * Math.Cos(alpha.getRad), GlobalVar.getLength1 * Math.Sin(alpha.getRad))).X, pointConverter.world2Graphic(New PointC(GlobalVar.getLength1 * Math.Cos(alpha.getRad), GlobalVar.getLength1 * Math.Sin(alpha.getRad))).Y)
        Dim j2 As New PointF(pointConverter.world2Graphic(Cinematica.calcPointFromAngles(alpha.getRad, beta.getRad)).X, pointConverter.world2Graphic(Cinematica.calcPointFromAngles(alpha.getRad, beta.getRad)).Y)
        gTop.Clear(Color.Black)
        gTop.DrawLine(penJoints, pointConverter.world2Graphic(pointPartenza), pointConverter.world2Graphic(pointArrivo))
        gTop.DrawLine(penRobot, origin, j1)
        gTop.DrawLine(penRobot, j1, j2)


    End Sub

    Private Sub comboTipoSpostamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipoSpostamento.SelectedIndexChanged

        btnTerzoPunto.Enabled = comboTipoSpostamento.SelectedIndex
        btnVersoRotazione.Enabled = comboTipoSpostamento.SelectedIndex
        txtRaggio.Enabled = comboTipoSpostamento.SelectedIndex
    End Sub

    Private Sub calcPeriod1()
        Dim period As New Period()
        While True
            period.copy(scheduler.getPeriod1())
            value += 1

            If Not period.getIsPeriod And Not period.getIsEnd Then
                'Threading.Thread.Sleep(0)
            ElseIf Not period.getIsPeriod And period.getIsEnd Then
                thPeriod2.Abort()
                isEndMovement = True
                isError = True
                Return
            ElseIf period.getIsEnd Then
                thPeriod1.Abort()
                isEndMovement = True
                Return
            ElseIf period.getPeriod > 0 Then
                'Threading.Thread.Sleep(period.getPeriod)
                alpha.setRad(alpha.getRad + GlobalVar.getAlpha.getDAngle)
            ElseIf period.getPeriod = 0 Then
                'Threading.Thread.Sleep(period.getPeriod)
            Else
                'Threading.Thread.Sleep(Math.Abs(period.getPeriod))
                alpha.setRad(alpha.getRad - GlobalVar.getAlpha.getDAngle)
            End If

        End While
    End Sub

    Private Sub calcPeriod2()
        Dim period As New Period()
        While True
            period.copy(scheduler.getPeriod2)

            If Not period.getIsPeriod And Not period.getIsEnd Then
                'Threading.Thread.Sleep(0)
            ElseIf Not period.getIsPeriod And period.getIsEnd Then
                thPeriod2.Abort()
                isEndMovement = True
                isError = True
                Return
            ElseIf period.getIsEnd Then
                thPeriod2.Abort()
                isEndMovement = True
                Return
            ElseIf period.getPeriod > 0 Then
                'Threading.Thread.Sleep(period.getPeriod)
                beta.setRad(beta.getRad + GlobalVar.getBeta.getDAngle)
            ElseIf period.getPeriod = 0 Then
                'Threading.Thread.Sleep(period.getPeriod)
            Else
                'Threading.Thread.Sleep(Math.Abs(period.getPeriod))

                beta.setRad(beta.getRad - GlobalVar.getBeta.getDAngle)
            End If

        End While
    End Sub

    Private Sub populateQueue()
        scheduler.startCalcLoop()
        thPopulate.Abort()
    End Sub

    Private Sub btnImposta_Click(sender As Object, e As EventArgs) Handles btnImposta.Click
        setParam()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isEndMovement Then
            GlobalVar.setIsCycloidal(True)
            GlobalVar.setIsLinear(True)
            GlobalVar.setStart(True)
            'pointPartenza.setX(260000)
            'pointPartenza.setY(328000)
            'pointArrivo.setX(394000)
            'pointArrivo.setY(256000)
            GlobalVar.setStartPoint(pointPartenza)
            GlobalVar.setEndPoint(pointArrivo)
            GlobalVar.setDAlpha(numStep1.Value)
            GlobalVar.setDBeta(numStep2.Value)
            startCompute()
            setParam()
        End If
    End Sub

    Private Sub TimerSim_Tick(sender As Object, e As EventArgs) Handles TimerSim.Tick
        simulazione()
        If isError Then
            lblMov.Text = "error"
        ElseIf Not isEndMovement Then
            lblMov.Text = "MOVING"
        Else
            lblMov.Text = "NOT MOVING"
            TimerSim.Stop()
        End If
        'NumericUpDown1.Value = Math.Floor(alpha.getDeg)
        'NumericUpDown2.Value = Math.Floor(beta.getDeg)

    End Sub
    Private Sub setParam()
        GlobalVar.setLength1(numLength1.Value)
        GlobalVar.setLength2(numLength2.Value)
        GlobalVar.setDAlpha(numStep1.Value)
        GlobalVar.setDBeta(numStep2.Value)
        GlobalVar.setMaxAccel(numAmax.Value)
        GlobalVar.setMaxSpeed(numVmax.Value)
        GlobalVar.setMinSpeed(numVmin.Value)
        GlobalVar.setTolerance(numTolleranza.Value)
        Cinematica.calcAngles(pointPartenza, True)
        alpha.setRad(GlobalVar.alpha.getMainAngle)
        beta.setRad(GlobalVar.alpha.getSecondAngle)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cinematica.calcAngles(pointArrivo, True)
        alpha.setRad(GlobalVar.getAlpha.getMainAngle)
        beta.setRad(GlobalVar.getAlpha.getSecondAngle)
        simulazione()
    End Sub

    Private Sub startCompute()
        isEndMovement = False
        TimerSim.Start()
        thPeriod1.Start()
        thPeriod2.Start()
        thPopulate.Start()
        '================= VEDERE CICLO THREAD ======================
    End Sub


End Class
