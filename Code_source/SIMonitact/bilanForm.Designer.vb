<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bilanForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bilanForm))
        Me.genererBilanButton = New System.Windows.Forms.Button()
        Me.bilanLabel = New System.Windows.Forms.Label()
        Me.periode1Label = New System.Windows.Forms.Label()
        Me.periodeDebDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.periode2Label = New System.Windows.Forms.Label()
        Me.periodeFinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.bilanPanel = New System.Windows.Forms.Panel()
        Me.bilanReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bilanPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'genererBilanButton
        '
        Me.genererBilanButton.AutoSize = True
        Me.genererBilanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.genererBilanButton.BackColor = System.Drawing.Color.White
        Me.genererBilanButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.genererBilanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.genererBilanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genererBilanButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.genererBilanButton.Location = New System.Drawing.Point(280, 124)
        Me.genererBilanButton.Name = "genererBilanButton"
        Me.genererBilanButton.Size = New System.Drawing.Size(198, 28)
        Me.genererBilanButton.TabIndex = 29
        Me.genererBilanButton.Text = "Générer le bilan d'activité"
        Me.genererBilanButton.UseVisualStyleBackColor = False
        '
        'bilanLabel
        '
        Me.bilanLabel.AutoSize = True
        Me.bilanLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bilanLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.bilanLabel.Location = New System.Drawing.Point(12, 20)
        Me.bilanLabel.Name = "bilanLabel"
        Me.bilanLabel.Size = New System.Drawing.Size(696, 38)
        Me.bilanLabel.TabIndex = 30
        Me.bilanLabel.Text = "Veuillez sélectionner une période puis générer le bilan d'activité. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliquez sur" &
    " Sauvegarder (disquette) pour exporter le rapport en PDF, Word ou Excel ou sur I" &
    "mprimer."
        '
        'periode1Label
        '
        Me.periode1Label.AutoSize = True
        Me.periode1Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periode1Label.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.periode1Label.Location = New System.Drawing.Point(18, 84)
        Me.periode1Label.Name = "periode1Label"
        Me.periode1Label.Size = New System.Drawing.Size(306, 16)
        Me.periode1Label.TabIndex = 32
        Me.periode1Label.Text = "Générer un bilan d'activité pour la période allant du :"
        '
        'periodeDebDateTimePicker
        '
        Me.periodeDebDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodeDebDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodeDebDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.periodeDebDateTimePicker.Location = New System.Drawing.Point(330, 79)
        Me.periodeDebDateTimePicker.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.periodeDebDateTimePicker.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.periodeDebDateTimePicker.Name = "periodeDebDateTimePicker"
        Me.periodeDebDateTimePicker.Size = New System.Drawing.Size(119, 22)
        Me.periodeDebDateTimePicker.TabIndex = 31
        Me.periodeDebDateTimePicker.Value = New Date(2019, 1, 1, 0, 0, 0, 0)
        '
        'periode2Label
        '
        Me.periode2Label.AutoSize = True
        Me.periode2Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periode2Label.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.periode2Label.Location = New System.Drawing.Point(468, 84)
        Me.periode2Label.Name = "periode2Label"
        Me.periode2Label.Size = New System.Drawing.Size(32, 16)
        Me.periode2Label.TabIndex = 33
        Me.periode2Label.Text = "Au :"
        '
        'periodeFinDateTimePicker
        '
        Me.periodeFinDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodeFinDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodeFinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.periodeFinDateTimePicker.Location = New System.Drawing.Point(506, 79)
        Me.periodeFinDateTimePicker.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.periodeFinDateTimePicker.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.periodeFinDateTimePicker.Name = "periodeFinDateTimePicker"
        Me.periodeFinDateTimePicker.Size = New System.Drawing.Size(119, 22)
        Me.periodeFinDateTimePicker.TabIndex = 34
        Me.periodeFinDateTimePicker.Value = New Date(2019, 1, 1, 0, 0, 0, 0)
        '
        'bilanPanel
        '
        Me.bilanPanel.Controls.Add(Me.bilanReportViewer)
        Me.bilanPanel.Location = New System.Drawing.Point(11, 176)
        Me.bilanPanel.Name = "bilanPanel"
        Me.bilanPanel.Size = New System.Drawing.Size(760, 646)
        Me.bilanPanel.TabIndex = 35
        '
        'bilanReportViewer
        '
        Me.bilanReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bilanReportViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bilanReportViewer.LocalReport.ReportEmbeddedResource = "SIMonitact.bilanReport.rdlc"
        Me.bilanReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.bilanReportViewer.Name = "bilanReportViewer"
        Me.bilanReportViewer.ServerReport.BearerToken = Nothing
        Me.bilanReportViewer.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.bilanReportViewer.Size = New System.Drawing.Size(760, 646)
        Me.bilanReportViewer.TabIndex = 0
        '
        'bilanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(779, 811)
        Me.Controls.Add(Me.bilanPanel)
        Me.Controls.Add(Me.periodeFinDateTimePicker)
        Me.Controls.Add(Me.periode2Label)
        Me.Controls.Add(Me.periode1Label)
        Me.Controls.Add(Me.periodeDebDateTimePicker)
        Me.Controls.Add(Me.bilanLabel)
        Me.Controls.Add(Me.genererBilanButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bilanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Création d'un bilan d'activité"
        Me.bilanPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents genererBilanButton As Button
    Friend WithEvents bilanLabel As Label
    Friend WithEvents periode1Label As Label
    Friend WithEvents periodeDebDateTimePicker As DateTimePicker
    Friend WithEvents periode2Label As Label
    Friend WithEvents periodeFinDateTimePicker As DateTimePicker
    Friend WithEvents bilanPanel As Panel
    Friend WithEvents bilanReportViewer As ReportViewer
End Class
