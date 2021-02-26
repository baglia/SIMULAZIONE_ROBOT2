Public Class Main

    Dim pointPartenza As New Point
    Dim pointArrivo As New Point
    Dim pointTerzoPunto As New Point
    Dim setPartenza As Boolean = False
    Dim setArrivo As Boolean = False
    Dim setTerzoPunto As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pointPartenza.X = 0
        pointPartenza.Y = 0
        pointArrivo.X = 0
        pointArrivo.Y = 0
        pointTerzoPunto.X = 0
        pointTerzoPunto.Y = 0
        lblP_partenza.Text = lblP_partenza.Text + " (0;0)"
        lblP_arrivo.Text = lblP_arrivo.Text + " (0;0)"
        lblTerzoPunto.Text = lblP_arrivo.Text + " (0;0)"
        btnTerzoPunto.Enabled = False
        btnVersoRotazione.Enabled = False
        txtRaggio.Enabled = False
    End Sub

    Private Sub panelSimTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelSimTop.MouseDown 'funzione viene lanciata 
        'quando clicco sul form (evento mouseDown)

        If setPartenza Then 'se sto settando la partenza salvo le coordinate del punto in cui ho cliccato in pointPartenza
            pointPartenza.X = e.X
            pointPartenza.Y = e.Y
            setPartenza = False
            lblP_partenza.Text = "(X,Y) PARTENZA: (" + CStr(e.X) + "," + CStr(e.Y) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
            btnTerzoPunto.BackColor = Color.LightGray
        End If

        If setArrivo Then
            pointArrivo.X = e.X
            pointArrivo.Y = e.Y
            setArrivo = False
            lblP_arrivo.Text = "(X,Y) ARRIVO: (" + CStr(e.X) + "," + CStr(e.Y) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
            btnTerzoPunto.BackColor = Color.LightGray
        End If

        If setTerzoPunto Then
            pointTerzoPunto.X = e.X
            pointTerzoPunto.Y = e.Y
            setTerzoPunto = False
            lblTerzoPunto.Text = "(X,Y) PUNTO INTERMEDIO: (" + CStr(e.X) + "," + CStr(e.Y) + ")"
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
        gTop.DrawLine(azzurro, pointPartenza, pointArrivo)

    End Sub

    Private Sub comboTipoSpostamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipoSpostamento.SelectedIndexChanged

        btnTerzoPunto.Enabled = comboTipoSpostamento.SelectedIndex
        btnVersoRotazione.Enabled = comboTipoSpostamento.SelectedIndex
        txtRaggio.Enabled = comboTipoSpostamento.SelectedIndex
    End Sub
End Class
