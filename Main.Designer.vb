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
        Me.btnSetPosArrivo = New System.Windows.Forms.Button()
        Me.btnSetPosPartenza = New System.Windows.Forms.Button()
        Me.lblP_arrivo = New System.Windows.Forms.Label()
        Me.grpSimulazione.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSimulazione
        '
        Me.grpSimulazione.Controls.Add(Me.panelSimTop)
        Me.grpSimulazione.Location = New System.Drawing.Point(12, 12)
        Me.grpSimulazione.Name = "grpSimulazione"
        Me.grpSimulazione.Size = New System.Drawing.Size(449, 426)
        Me.grpSimulazione.TabIndex = 0
        Me.grpSimulazione.TabStop = False
        Me.grpSimulazione.Text = "Simulazione"
        '
        'panelSimTop
        '
        Me.panelSimTop.Location = New System.Drawing.Point(6, 21)
        Me.panelSimTop.Name = "panelSimTop"
        Me.panelSimTop.Size = New System.Drawing.Size(437, 399)
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
        Me.GroupBox1.Controls.Add(Me.btnSetPosArrivo)
        Me.GroupBox1.Controls.Add(Me.btnSetPosPartenza)
        Me.GroupBox1.Controls.Add(Me.lblP_arrivo)
        Me.GroupBox1.Controls.Add(Me.lblP_partenza)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnSetPosArrivo
        '
        Me.btnSetPosArrivo.Location = New System.Drawing.Point(240, 53)
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpSimulazione)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.grpSimulazione.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSimulazione As GroupBox
    Friend WithEvents panelSimTop As Panel
    Friend WithEvents lblP_partenza As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSetPosArrivo As Button
    Friend WithEvents btnSetPosPartenza As Button
    Friend WithEvents lblP_arrivo As Label
End Class
