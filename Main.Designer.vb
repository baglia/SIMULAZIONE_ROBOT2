<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.TimerSim = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.numTolleranza = New System.Windows.Forms.NumericUpDown()
        Me.numAmax = New System.Windows.Forms.NumericUpDown()
        Me.numVmax = New System.Windows.Forms.NumericUpDown()
        Me.numVmin = New System.Windows.Forms.NumericUpDown()
        Me.numStep2 = New System.Windows.Forms.NumericUpDown()
        Me.numStep1 = New System.Windows.Forms.NumericUpDown()
        Me.numLength2 = New System.Windows.Forms.NumericUpDown()
        Me.numLength1 = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImposta = New System.Windows.Forms.Button()
        Me.grpSimulazione.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sliderVelocità, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.numTolleranza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numVmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numVmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStep2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStep1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLength2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLength1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
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
        Me.sliderVelocità.Location = New System.Drawing.Point(117, 167)
        Me.sliderVelocità.Name = "sliderVelocità"
        Me.sliderVelocità.Size = New System.Drawing.Size(210, 56)
        Me.sliderVelocità.TabIndex = 0
        '
        'comboAccelerazioneLineare
        '
        Me.comboAccelerazioneLineare.FormattingEnabled = True
        Me.comboAccelerazioneLineare.Items.AddRange(New Object() {"Tre tratti", "Cicloidale"})
        Me.comboAccelerazioneLineare.Location = New System.Drawing.Point(117, 126)
        Me.comboAccelerazioneLineare.Name = "comboAccelerazioneLineare"
        Me.comboAccelerazioneLineare.Size = New System.Drawing.Size(210, 24)
        Me.comboAccelerazioneLineare.TabIndex = 1
        '
        'lblTipoAccelerazione
        '
        Me.lblTipoAccelerazione.AutoSize = True
        Me.lblTipoAccelerazione.Location = New System.Drawing.Point(6, 126)
        Me.lblTipoAccelerazione.Name = "lblTipoAccelerazione"
        Me.lblTipoAccelerazione.Size = New System.Drawing.Size(105, 17)
        Me.lblTipoAccelerazione.TabIndex = 2
        Me.lblTipoAccelerazione.Text = "Accelerazione: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Velocità: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Spostamento:"
        '
        'comboTipoSpostamento
        '
        Me.comboTipoSpostamento.FormattingEnabled = True
        Me.comboTipoSpostamento.Items.AddRange(New Object() {"Lineare", "Circolare"})
        Me.comboTipoSpostamento.Location = New System.Drawing.Point(117, 313)
        Me.comboTipoSpostamento.Name = "comboTipoSpostamento"
        Me.comboTipoSpostamento.Size = New System.Drawing.Size(210, 24)
        Me.comboTipoSpostamento.TabIndex = 4
        '
        'txtRaggio
        '
        Me.txtRaggio.Location = New System.Drawing.Point(117, 354)
        Me.txtRaggio.Name = "txtRaggio"
        Me.txtRaggio.Size = New System.Drawing.Size(210, 22)
        Me.txtRaggio.TabIndex = 6
        '
        'btnVersoRotazione
        '
        Me.btnVersoRotazione.Location = New System.Drawing.Point(117, 393)
        Me.btnVersoRotazione.Name = "btnVersoRotazione"
        Me.btnVersoRotazione.Size = New System.Drawing.Size(210, 56)
        Me.btnVersoRotazione.TabIndex = 7
        Me.btnVersoRotazione.Text = "Button1"
        Me.btnVersoRotazione.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Raggio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Verso:"
        '
        'btnTerzoPunto
        '
        Me.btnTerzoPunto.Location = New System.Drawing.Point(252, 466)
        Me.btnTerzoPunto.Name = "btnTerzoPunto"
        Me.btnTerzoPunto.Size = New System.Drawing.Size(75, 23)
        Me.btnTerzoPunto.TabIndex = 11
        Me.btnTerzoPunto.Text = "SET"
        Me.btnTerzoPunto.UseVisualStyleBackColor = True
        '
        'lblTerzoPunto
        '
        Me.lblTerzoPunto.AutoSize = True
        Me.lblTerzoPunto.Location = New System.Drawing.Point(3, 466)
        Me.lblTerzoPunto.Name = "lblTerzoPunto"
        Me.lblTerzoPunto.Size = New System.Drawing.Size(190, 17)
        Me.lblTerzoPunto.TabIndex = 10
        Me.lblTerzoPunto.Text = "(X,Y) PUNTO INTERMEDIO: "
        '
        'TimerSim
        '
        Me.TimerSim.Interval = 20
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(467, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(347, 546)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TrackBar1)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnTerzoPunto)
        Me.TabPage1.Controls.Add(Me.sliderVelocità)
        Me.TabPage1.Controls.Add(Me.lblTerzoPunto)
        Me.TabPage1.Controls.Add(Me.comboAccelerazioneLineare)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblTipoAccelerazione)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnVersoRotazione)
        Me.TabPage1.Controls.Add(Me.comboTipoSpostamento)
        Me.TabPage1.Controls.Add(Me.txtRaggio)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(339, 517)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controllo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 492)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Imposta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBar1.Location = New System.Drawing.Point(117, 240)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(210, 56)
        Me.TrackBar1.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Velocità: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.numTolleranza)
        Me.TabPage2.Controls.Add(Me.numAmax)
        Me.TabPage2.Controls.Add(Me.numVmax)
        Me.TabPage2.Controls.Add(Me.numVmin)
        Me.TabPage2.Controls.Add(Me.numStep2)
        Me.TabPage2.Controls.Add(Me.numStep1)
        Me.TabPage2.Controls.Add(Me.numLength2)
        Me.TabPage2.Controls.Add(Me.numLength1)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnImposta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(339, 517)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Parametri"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'numTolleranza
        '
        Me.numTolleranza.Location = New System.Drawing.Point(246, 310)
        Me.numTolleranza.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numTolleranza.Name = "numTolleranza"
        Me.numTolleranza.Size = New System.Drawing.Size(72, 22)
        Me.numTolleranza.TabIndex = 23
        '
        'numAmax
        '
        Me.numAmax.Location = New System.Drawing.Point(246, 270)
        Me.numAmax.Name = "numAmax"
        Me.numAmax.Size = New System.Drawing.Size(72, 22)
        Me.numAmax.TabIndex = 22
        '
        'numVmax
        '
        Me.numVmax.Location = New System.Drawing.Point(246, 230)
        Me.numVmax.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numVmax.Name = "numVmax"
        Me.numVmax.Size = New System.Drawing.Size(72, 22)
        Me.numVmax.TabIndex = 21
        '
        'numVmin
        '
        Me.numVmin.Location = New System.Drawing.Point(246, 190)
        Me.numVmin.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numVmin.Name = "numVmin"
        Me.numVmin.Size = New System.Drawing.Size(72, 22)
        Me.numVmin.TabIndex = 20
        '
        'numStep2
        '
        Me.numStep2.Location = New System.Drawing.Point(246, 150)
        Me.numStep2.Maximum = New Decimal(New Integer() {250000, 0, 0, 0})
        Me.numStep2.Name = "numStep2"
        Me.numStep2.Size = New System.Drawing.Size(72, 22)
        Me.numStep2.TabIndex = 19
        '
        'numStep1
        '
        Me.numStep1.Location = New System.Drawing.Point(246, 110)
        Me.numStep1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numStep1.Name = "numStep1"
        Me.numStep1.Size = New System.Drawing.Size(72, 22)
        Me.numStep1.TabIndex = 18
        '
        'numLength2
        '
        Me.numLength2.Location = New System.Drawing.Point(246, 70)
        Me.numLength2.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.numLength2.Name = "numLength2"
        Me.numLength2.Size = New System.Drawing.Size(72, 22)
        Me.numLength2.TabIndex = 17
        '
        'numLength1
        '
        Me.numLength1.Location = New System.Drawing.Point(246, 30)
        Me.numLength1.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.numLength1.Name = "numLength1"
        Me.numLength1.Size = New System.Drawing.Size(72, 22)
        Me.numLength1.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Tolleranza [μm]"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(216, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Accelerazione massima [mm/s^2]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Velocità massima [mm/s]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Velocità minima [mm/s]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Passi/Giro asse 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Passi/Giro asse 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Lunghezza asse 2 [mm]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Lunghezza asse 1 [mm]"
        '
        'btnImposta
        '
        Me.btnImposta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImposta.Location = New System.Drawing.Point(231, 462)
        Me.btnImposta.Name = "btnImposta"
        Me.btnImposta.Size = New System.Drawing.Size(102, 48)
        Me.btnImposta.TabIndex = 0
        Me.btnImposta.Text = "IMPOSTA"
        Me.btnImposta.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 599)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grpSimulazione)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Simulazione"
        Me.grpSimulazione.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sliderVelocità, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.numTolleranza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numVmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numVmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStep2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStep1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLength2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLength1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents TimerSim As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnImposta As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label14 As Label
    Friend WithEvents numTolleranza As NumericUpDown
    Friend WithEvents numAmax As NumericUpDown
    Friend WithEvents numVmax As NumericUpDown
    Friend WithEvents numVmin As NumericUpDown
    Friend WithEvents numStep2 As NumericUpDown
    Friend WithEvents numStep1 As NumericUpDown
    Friend WithEvents numLength2 As NumericUpDown
    Friend WithEvents numLength1 As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
