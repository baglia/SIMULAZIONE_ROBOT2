<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpSimulazione = New System.Windows.Forms.GroupBox()
        Me.panelSimTop = New System.Windows.Forms.Panel()
        Me.lblP_partenza = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSetPosArrivo = New System.Windows.Forms.Button()
        Me.btnSetPosPartenza = New System.Windows.Forms.Button()
        Me.lblP_arrivo = New System.Windows.Forms.Label()
        Me.sliderVelocità = New System.Windows.Forms.TrackBar()
        Me.comboAccelerazioneLineare = New System.Windows.Forms.ComboBox()
        Me.lblTipoAccelerazione = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboTipoSpostamento = New System.Windows.Forms.ComboBox()
        Me.txtRaggio = New System.Windows.Forms.TextBox()
        Me.btnVersoRotazione = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTerzoPunto = New System.Windows.Forms.Button()
        Me.lblTerzoPunto = New System.Windows.Forms.Label()
        Me.grpSimulazione.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sliderVelocità, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSimulazione
        '
        Me.grpSimulazione.Controls.Add(Me.panelSimTop)
        Me.grpSimulazione.Location = New System.Drawing.Point(12, 12)
        Me.grpSimulazione.Name = "grpSimulazione"
        Me.grpSimulazione.Size = New System.Drawing.Size(449, 546)
        Me.grpSimulazione.TabIndex = 0
        Me.grpSimulazione.TabStop = False
        Me.grpSimulazione.Text = "Simulazione"
        '
        'panelSimTop
        '
        Me.panelSimTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelSimTop.Location = New System.Drawing.Point(6, 21)
        Me.panelSimTop.Name = "panelSimTop"
        Me.panelSimTop.Size = New System.Drawing.Size(437, 519)
        Me.panelSimTop.TabIndex = 0
        '
        'lblP_partenza
        '
        Me.lblP_partenza.AutoSize = True
        Me.lblP_partenza.Location = New System.Drawing.Point(6, 29)
        Me.lblP_partenza.Name = "lblP_partenza"
        Me.lblP_partenza.Size = New System.Drawing.Size(126, 17)
        Me.lblP_partenza.TabIndex = 1
        Me.lblP_partenza.Text = "(X,Y) PARTENZA: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSetPosArrivo)
        Me.GroupBox1.Controls.Add(Me.btnSetPosPartenza)
        Me.GroupBox1.Controls.Add(Me.lblP_arrivo)
        Me.GroupBox1.Controls.Add(Me.lblP_partenza)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 94)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Coordinate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(X,Y) ARRIVO: "
        '
        'btnSetPosArrivo
        '
        Me.btnSetPosArrivo.Location = New System.Drawing.Point(240, 56)
        Me.btnSetPosArrivo.Name = "btnSetPosArrivo"
        Me.btnSetPosArrivo.Size = New System.Drawing.Size(75, 23)
        Me.btnSetPosArrivo.TabIndex = 4
        Me.btnSetPosArrivo.Text = "SET"
        Me.btnSetPosArrivo.UseVisualStyleBackColor = True
        '
        'btnSetPosPartenza
        '
        Me.btnSetPosPartenza.Location = New System.Drawing.Point(240, 24)
        Me.btnSetPosPartenza.Name = "btnSetPosPartenza"
        Me.btnSetPosPartenza.Size = New System.Drawing.Size(75, 23)
        Me.btnSetPosPartenza.TabIndex = 3
        Me.btnSetPosPartenza.Text = "SET"
        Me.btnSetPosPartenza.UseVisualStyleBackColor = True
        '
        'lblP_arrivo
        '
        Me.lblP_arrivo.AutoSize = True
        Me.lblP_arrivo.Location = New System.Drawing.Point(6, 59)
        Me.lblP_arrivo.Name = "lblP_arrivo"
        Me.lblP_arrivo.Size = New System.Drawing.Size(104, 17)
        Me.lblP_arrivo.TabIndex = 2
        Me.lblP_arrivo.Text = "(X,Y) ARRIVO: "
        '
        'sliderVelocità
        '
        Me.sliderVelocità.BackColor = System.Drawing.SystemColors.Control
        Me.sliderVelocità.Location = New System.Drawing.Point(578, 207)
        Me.sliderVelocità.Name = "sliderVelocità"
        Me.sliderVelocità.Size = New System.Drawing.Size(210, 56)
        Me.sliderVelocità.TabIndex = 0
        '
        'comboAccelerazioneLineare
        '
        Me.comboAccelerazioneLineare.FormattingEnabled = True
        Me.comboAccelerazioneLineare.Items.AddRange(New Object() {"Tre tratti", "Cicloidale"})
        Me.comboAccelerazioneLineare.Location = New System.Drawing.Point(578, 153)
        Me.comboAccelerazioneLineare.Name = "comboAccelerazioneLineare"
        Me.comboAccelerazioneLineare.Size = New System.Drawing.Size(210, 24)
        Me.comboAccelerazioneLineare.TabIndex = 1
        '
        'lblTipoAccelerazione
        '
        Me.lblTipoAccelerazione.AutoSize = True
        Me.lblTipoAccelerazione.Location = New System.Drawing.Point(467, 153)
        Me.lblTipoAccelerazione.Name = "lblTipoAccelerazione"
        Me.lblTipoAccelerazione.Size = New System.Drawing.Size(105, 17)
        Me.lblTipoAccelerazione.TabIndex = 2
        Me.lblTipoAccelerazione.Text = "Accelerazione: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(467, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Velocità: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(467, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Spostamento:"
        '
        'comboTipoSpostamento
        '
        Me.comboTipoSpostamento.FormattingEnabled = True
        Me.comboTipoSpostamento.Items.AddRange(New Object() {"Lineare", "Circolare"})
        Me.comboTipoSpostamento.Location = New System.Drawing.Point(578, 303)
        Me.comboTipoSpostamento.Name = "comboTipoSpostamento"
        Me.comboTipoSpostamento.Size = New System.Drawing.Size(210, 24)
        Me.comboTipoSpostamento.TabIndex = 4
        '
        'txtRaggio
        '
        Me.txtRaggio.Location = New System.Drawing.Point(578, 358)
        Me.txtRaggio.Name = "txtRaggio"
        Me.txtRaggio.Size = New System.Drawing.Size(210, 22)
        Me.txtRaggio.TabIndex = 6
        '
        'btnVersoRotazione
        '
        Me.btnVersoRotazione.Location = New System.Drawing.Point(578, 419)
        Me.btnVersoRotazione.Name = "btnVersoRotazione"
        Me.btnVersoRotazione.Size = New System.Drawing.Size(210, 30)
        Me.btnVersoRotazione.TabIndex = 7
        Me.btnVersoRotazione.Text = "Button1"
        Me.btnVersoRotazione.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Raggio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(467, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Verso:"
        '
        'btnTerzoPunto
        '
        Me.btnTerzoPunto.Location = New System.Drawing.Point(713, 497)
        Me.btnTerzoPunto.Name = "btnTerzoPunto"
        Me.btnTerzoPunto.Size = New System.Drawing.Size(75, 23)
        Me.btnTerzoPunto.TabIndex = 11
        Me.btnTerzoPunto.Text = "SET"
        Me.btnTerzoPunto.UseVisualStyleBackColor = True
        '
        'lblTerzoPunto
        '
        Me.lblTerzoPunto.AutoSize = True
        Me.lblTerzoPunto.Location = New System.Drawing.Point(467, 503)
        Me.lblTerzoPunto.Name = "lblTerzoPunto"
        Me.lblTerzoPunto.Size = New System.Drawing.Size(190, 17)
        Me.lblTerzoPunto.TabIndex = 10
        Me.lblTerzoPunto.Text = "(X,Y) PUNTO INTERMEDIO: "
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 578)
        Me.Controls.Add(Me.btnTerzoPunto)
        Me.Controls.Add(Me.lblTerzoPunto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVersoRotazione)
        Me.Controls.Add(Me.txtRaggio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboTipoSpostamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTipoAccelerazione)
        Me.Controls.Add(Me.comboAccelerazioneLineare)
        Me.Controls.Add(Me.sliderVelocità)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpSimulazione)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Simulazione"
        Me.grpSimulazione.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sliderVelocità, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSimulazione As GroupBox
    Friend WithEvents panelSimTop As Panel
    Friend WithEvents lblP_partenza As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSetPosArrivo As Button
    Friend WithEvents btnSetPosPartenza As Button
    Friend WithEvents lblP_arrivo As Label
    Friend WithEvents sliderVelocità As TrackBar
    Friend WithEvents comboAccelerazioneLineare As ComboBox
    Friend WithEvents lblTipoAccelerazione As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comboTipoSpostamento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRaggio As TextBox
    Friend WithEvents btnVersoRotazione As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTerzoPunto As Button
    Friend WithEvents lblTerzoPunto As Label
End Class
