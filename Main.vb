Public Class Main

    Dim pointPartenza As New Point
    Dim pointArrivo As New Point
    Dim setPartenza As Boolean = False
    Dim setArrivo As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblP_partenza.Text = lblP_partenza.Text + " (0;0)"
        lblP_arrivo.Text = lblP_arrivo.Text + " (0;0)"

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
        End If

        If setArrivo Then
            pointArrivo.X = e.X
            pointArrivo.Y = e.Y
            setArrivo = False
                lblP_arrivo.Text = "(X,Y) PARTENZA: (" + CStr(e.X) + "," + CStr(e.Y) + ")"
            btnSetPosPartenza.BackColor = Color.LightGray
            btnSetPosArrivo.BackColor = Color.LightGray
        End If



    End Sub

    Private Sub btnSetPosPartenza_Click(sender As Object, e As EventArgs) Handles btnSetPosPartenza.Click
        If setArrivo = False Then 'verifico che non sia già attivo set arrivo
            setPartenza = True
            btnSetPosPartenza.BackColor = Color.Green
            btnSetPosArrivo.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnSetPosArrivo_Click(sender As Object, e As EventArgs) Handles btnSetPosArrivo.Click
        If setPartenza = False Then 'verifico che non sia già attivo set partenza
            setArrivo = True
            btnSetPosPartenza.BackColor = Color.Red
            btnSetPosArrivo.BackColor = Color.Green
        End If
    End Sub
End Class
