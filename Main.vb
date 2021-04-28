Public Class Main

    Dim pointPartenza As New PointC
    Dim pointArrivo As New PointC
    Dim pointTerzoPunto As New PointC
    Dim setPartenza As Boolean = False
    Dim setArrivo As Boolean = False
    Dim setTerzoPunto As Boolean = False
    Dim scheduler As New Scheduling
    Dim alpha, beta As New Angle()
    Dim thPeriod1 As New Threading.Thread(AddressOf calcPeriod1)
    Dim thPeriod2 As New Threading.Thread(AddressOf calcPeriod2)
    Dim thPopulate As New Threading.Thread(AddressOf populateQueue)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pointPartenza.setX(0)
        pointPartenza.setY(0)
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
        numLength1.Value = 370
        numLength2.Value = 260
        numStep1.Value = 50000
        numStep2.Value = 25000
        numVmax.Value = 100
        numVmin.Value = 10
        numAmax.Value = 10
        numTolleranza.Value = 1
    End Sub


    Private Sub panelSimTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelSimTop.MouseDown 'funzione viene lanciata 
        'quando clicco sul form (evento mouseDown)

        If setPartenza Then 'se sto settando la partenza salvo le coordinate del punto in cui ho cliccato in pointPartenza
            pointPartenza.setX(e.X * 10)
            pointPartenza.setY(e.Y * 10)
            setPartenza = False
            lblP_partenza.Text = "(X,Y) PARTENZA: (" + CStr(pointPartenza.getX) + "," + CStr(pointPartenza.getY) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
            btnTerzoPunto.BackColor = Color.LightGray
        End If

        If setArrivo Then
            pointArrivo.setX(e.X * 10)
            pointArrivo.setY(e.Y * 10)
            setArrivo = False
            lblP_arrivo.Text = "(X,Y) ARRIVO: (" + CStr(pointArrivo.getX) + "," + CStr(pointArrivo.getY) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
            btnTerzoPunto.BackColor = Color.LightGray
        End If

        If setTerzoPunto Then
            pointTerzoPunto.setX(e.X * 10)
            pointTerzoPunto.setY(e.Y * 10)
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
        Dim verde As New Pen(Color.Green, 8)
        Dim giallo As New Pen(Color.GreenYellow, 8)
        Dim azzurro As New Pen(Color.LightBlue, 8)
        Dim origineTop As New Point(panelSimTop.Width / 2, panelSimTop.Height / 2)
        Dim j1 As New Point
        Dim pleft As New Point
        Dim pTop As New Point
        gTop.Clear(Color.Black)
        gTop.DrawLine(azzurro, pointPartenza.getPointF, pointArrivo.getPointF)

    End Sub

    Private Sub comboTipoSpostamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipoSpostamento.SelectedIndexChanged

        btnTerzoPunto.Enabled = comboTipoSpostamento.SelectedIndex
        btnVersoRotazione.Enabled = comboTipoSpostamento.SelectedIndex
        txtRaggio.Enabled = comboTipoSpostamento.SelectedIndex
    End Sub

    Private Sub calcPeriod1()
        Dim period As New Period(scheduler.getPeriod1())
        If Not period.getIsPeriod Then
            Threading.Thread.Sleep(0)
            Return
        ElseIf period.getIsEnd Then
            thPeriod1.Abort()
        ElseIf period.getIsPeriod > 0 Then
            Threading.Thread.Sleep(period.getIsPeriod)
            alpha.setRad(alpha.getRad + GlobalVar.getAlpha.getDAngle)
        ElseIf period.getIsPeriod = 0 Then
            Threading.Thread.Sleep(period.getIsPeriod)
        Else
            Threading.Thread.Sleep(Math.Abs(period.getIsPeriod))
            alpha.setRad(alpha.getRad - GlobalVar.getAlpha.getDAngle)
        End If
    End Sub

    Private Sub calcPeriod2()
        Dim period As New Period(scheduler.getPeriod2())
        If Not period.getIsPeriod Then
            Threading.Thread.Sleep(0)
            Return
        ElseIf period.getIsEnd Then
            thPeriod2.Abort()
        ElseIf period.getIsPeriod > 0 Then
            Threading.Thread.Sleep(period.getIsPeriod)
            alpha.setRad(beta.getRad + GlobalVar.getBeta.getDAngle)
        ElseIf period.getIsPeriod = 0 Then
            Threading.Thread.Sleep(period.getIsPeriod)
        Else
            Threading.Thread.Sleep(Math.Abs(period.getIsPeriod))
            alpha.setRad(beta.getRad - GlobalVar.getBeta.getDAngle)
        End If

    End Sub

    Private Sub populateQueue()
        scheduler.startCalcLoop()
        thPopulate.Abort()
    End Sub

    Private Sub btnImposta_Click(sender As Object, e As EventArgs) Handles btnImposta.Click
        GlobalVar.setLength1(numLength1.Value)
        GlobalVar.setLength2(numLength2.Value)
        GlobalVar.setDAlpha(numStep1.Value)
        GlobalVar.setDBeta(numStep2.Value)
        GlobalVar.setMaxAccel(numAmax.Value)
        GlobalVar.setMaxSpeed(numVmax.Value)
        GlobalVar.setMinSpeed(numVmin.Value)
        GlobalVar.setTolerance(numTolleranza.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalVar.setIsCycloidal(True)
        GlobalVar.setIsLinear(True)
        GlobalVar.setStart(True)
        pointPartenza.setX(200)
        pointPartenza.setY(210)
        pointArrivo.setX(260)
        pointArrivo.setY(350)
        GlobalVar.setStartPoint(pointPartenza)
        GlobalVar.setEndPoint(pointArrivo)
        GlobalVar.setDAlpha(numStep1.Value)
        GlobalVar.setDBeta(numStep2.Value)
        startCompute()
    End Sub

    Private Sub startCompute()
        thPeriod1.Start()
        thPeriod2.Start()
        thPopulate.Start()
    End Sub


End Class
