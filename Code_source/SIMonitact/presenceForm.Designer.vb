<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class presenceForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(presenceForm))
        Me.presenceTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.presenceTabControl = New System.Windows.Forms.TabControl()
        Me.presenceTabPage = New System.Windows.Forms.TabPage()
        Me.presencePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.partiLabel = New System.Windows.Forms.Label()
        Me.formLabel = New System.Windows.Forms.Label()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.participantLabel = New System.Windows.Forms.Label()
        Me.formateurLabel = New System.Windows.Forms.Label()
        Me.formulaireValiderPanel = New System.Windows.Forms.Panel()
        Me.annulerPresenceButton = New System.Windows.Forms.Button()
        Me.validerPresenceButton = New System.Windows.Forms.Button()
        Me.titreFormulairePanel = New System.Windows.Forms.Panel()
        Me.presenceFormulaireLabel = New System.Windows.Forms.Label()
        Me.presenceExplicationLabel = New System.Windows.Forms.Label()
        Me.presenceTableLayoutPanel.SuspendLayout()
        Me.presenceTabControl.SuspendLayout()
        Me.presenceTabPage.SuspendLayout()
        Me.presencePanel.SuspendLayout()
        Me.formulaireValiderPanel.SuspendLayout()
        Me.titreFormulairePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'presenceTableLayoutPanel
        '
        Me.presenceTableLayoutPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.presenceTableLayoutPanel.ColumnCount = 1
        Me.presenceTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.presenceTableLayoutPanel.Controls.Add(Me.presenceTabControl, 0, 1)
        Me.presenceTableLayoutPanel.Controls.Add(Me.formulaireValiderPanel, 0, 2)
        Me.presenceTableLayoutPanel.Controls.Add(Me.titreFormulairePanel, 0, 0)
        Me.presenceTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.presenceTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.presenceTableLayoutPanel.Name = "presenceTableLayoutPanel"
        Me.presenceTableLayoutPanel.RowCount = 3
        Me.presenceTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.presenceTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.presenceTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.presenceTableLayoutPanel.Size = New System.Drawing.Size(984, 562)
        Me.presenceTableLayoutPanel.TabIndex = 1
        '
        'presenceTabControl
        '
        Me.presenceTabControl.Controls.Add(Me.presenceTabPage)
        Me.presenceTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.presenceTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presenceTabControl.Location = New System.Drawing.Point(3, 87)
        Me.presenceTabControl.Name = "presenceTabControl"
        Me.presenceTabControl.SelectedIndex = 0
        Me.presenceTabControl.Size = New System.Drawing.Size(978, 415)
        Me.presenceTabControl.TabIndex = 1
        '
        'presenceTabPage
        '
        Me.presenceTabPage.Controls.Add(Me.presencePanel)
        Me.presenceTabPage.Location = New System.Drawing.Point(4, 25)
        Me.presenceTabPage.Name = "presenceTabPage"
        Me.presenceTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.presenceTabPage.Size = New System.Drawing.Size(970, 386)
        Me.presenceTabPage.TabIndex = 0
        Me.presenceTabPage.Text = "Formation"
        Me.presenceTabPage.UseVisualStyleBackColor = True
        '
        'presencePanel
        '
        Me.presencePanel.AutoScroll = True
        Me.presencePanel.Controls.Add(Me.Label1)
        Me.presencePanel.Controls.Add(Me.CheckedListBox3)
        Me.presencePanel.Controls.Add(Me.partiLabel)
        Me.presencePanel.Controls.Add(Me.formLabel)
        Me.presencePanel.Controls.Add(Me.CheckedListBox2)
        Me.presencePanel.Controls.Add(Me.CheckedListBox1)
        Me.presencePanel.Controls.Add(Me.participantLabel)
        Me.presencePanel.Controls.Add(Me.formateurLabel)
        Me.presencePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.presencePanel.Location = New System.Drawing.Point(3, 3)
        Me.presencePanel.Name = "presencePanel"
        Me.presencePanel.Size = New System.Drawing.Size(964, 380)
        Me.presencePanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(16, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Aide-formateurs :"
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Location = New System.Drawing.Point(19, 232)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(415, 140)
        Me.CheckedListBox3.TabIndex = 21
        '
        'partiLabel
        '
        Me.partiLabel.AutoSize = True
        Me.partiLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partiLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.partiLabel.Location = New System.Drawing.Point(495, 20)
        Me.partiLabel.Name = "partiLabel"
        Me.partiLabel.Size = New System.Drawing.Size(85, 16)
        Me.partiLabel.TabIndex = 20
        Me.partiLabel.Text = "Participants :"
        '
        'formLabel
        '
        Me.formLabel.AutoSize = True
        Me.formLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.formLabel.Location = New System.Drawing.Point(16, 20)
        Me.formLabel.Name = "formLabel"
        Me.formLabel.Size = New System.Drawing.Size(82, 16)
        Me.formLabel.TabIndex = 19
        Me.formLabel.Text = "Formateurs :"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(498, 45)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(415, 327)
        Me.CheckedListBox2.TabIndex = 18
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(19, 45)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(415, 140)
        Me.CheckedListBox1.TabIndex = 17
        '
        'participantLabel
        '
        Me.participantLabel.AutoSize = True
        Me.participantLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.participantLabel.ForeColor = System.Drawing.Color.Teal
        Me.participantLabel.Location = New System.Drawing.Point(495, 24)
        Me.participantLabel.Name = "participantLabel"
        Me.participantLabel.Size = New System.Drawing.Size(0, 16)
        Me.participantLabel.TabIndex = 16
        '
        'formateurLabel
        '
        Me.formateurLabel.AutoSize = True
        Me.formateurLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formateurLabel.ForeColor = System.Drawing.Color.Teal
        Me.formateurLabel.Location = New System.Drawing.Point(16, 24)
        Me.formateurLabel.Name = "formateurLabel"
        Me.formateurLabel.Size = New System.Drawing.Size(0, 16)
        Me.formateurLabel.TabIndex = 3
        '
        'formulaireValiderPanel
        '
        Me.formulaireValiderPanel.Controls.Add(Me.annulerPresenceButton)
        Me.formulaireValiderPanel.Controls.Add(Me.validerPresenceButton)
        Me.formulaireValiderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formulaireValiderPanel.Location = New System.Drawing.Point(3, 508)
        Me.formulaireValiderPanel.Name = "formulaireValiderPanel"
        Me.formulaireValiderPanel.Size = New System.Drawing.Size(978, 51)
        Me.formulaireValiderPanel.TabIndex = 2
        '
        'annulerPresenceButton
        '
        Me.annulerPresenceButton.AutoSize = True
        Me.annulerPresenceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.annulerPresenceButton.BackColor = System.Drawing.Color.White
        Me.annulerPresenceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.annulerPresenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.annulerPresenceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annulerPresenceButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.annulerPresenceButton.Location = New System.Drawing.Point(906, 12)
        Me.annulerPresenceButton.Name = "annulerPresenceButton"
        Me.annulerPresenceButton.Size = New System.Drawing.Size(65, 28)
        Me.annulerPresenceButton.TabIndex = 5
        Me.annulerPresenceButton.Text = "Annuler"
        Me.annulerPresenceButton.UseVisualStyleBackColor = False
        '
        'validerPresenceButton
        '
        Me.validerPresenceButton.AutoSize = True
        Me.validerPresenceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.validerPresenceButton.BackColor = System.Drawing.Color.White
        Me.validerPresenceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.validerPresenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.validerPresenceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validerPresenceButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.validerPresenceButton.Location = New System.Drawing.Point(368, 12)
        Me.validerPresenceButton.Name = "validerPresenceButton"
        Me.validerPresenceButton.Size = New System.Drawing.Size(244, 28)
        Me.validerPresenceButton.TabIndex = 4
        Me.validerPresenceButton.Text = "ENREGISTRER LA FORMATION"
        Me.validerPresenceButton.UseVisualStyleBackColor = False
        '
        'titreFormulairePanel
        '
        Me.titreFormulairePanel.Controls.Add(Me.presenceFormulaireLabel)
        Me.titreFormulairePanel.Controls.Add(Me.presenceExplicationLabel)
        Me.titreFormulairePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titreFormulairePanel.Location = New System.Drawing.Point(3, 3)
        Me.titreFormulairePanel.Name = "titreFormulairePanel"
        Me.titreFormulairePanel.Size = New System.Drawing.Size(978, 78)
        Me.titreFormulairePanel.TabIndex = 3
        '
        'presenceFormulaireLabel
        '
        Me.presenceFormulaireLabel.AutoSize = True
        Me.presenceFormulaireLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presenceFormulaireLabel.ForeColor = System.Drawing.Color.White
        Me.presenceFormulaireLabel.Location = New System.Drawing.Point(9, 6)
        Me.presenceFormulaireLabel.Name = "presenceFormulaireLabel"
        Me.presenceFormulaireLabel.Size = New System.Drawing.Size(211, 22)
        Me.presenceFormulaireLabel.TabIndex = 3
        Me.presenceFormulaireLabel.Text = "Formulaire Formation"
        '
        'presenceExplicationLabel
        '
        Me.presenceExplicationLabel.AutoSize = True
        Me.presenceExplicationLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presenceExplicationLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.presenceExplicationLabel.Location = New System.Drawing.Point(9, 40)
        Me.presenceExplicationLabel.Name = "presenceExplicationLabel"
        Me.presenceExplicationLabel.Size = New System.Drawing.Size(700, 19)
        Me.presenceExplicationLabel.TabIndex = 2
        Me.presenceExplicationLabel.Text = "Veuillez associer les formateurs, aide-formateurs et participants à chaque demi-j" &
    "ournée de formation."
        '
        'presenceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.presenceTableLayoutPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "presenceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Présence des formateurs/aide-formateur/participants par demi-journée de formation" &
    ""
        Me.presenceTableLayoutPanel.ResumeLayout(False)
        Me.presenceTabControl.ResumeLayout(False)
        Me.presenceTabPage.ResumeLayout(False)
        Me.presencePanel.ResumeLayout(False)
        Me.presencePanel.PerformLayout()
        Me.formulaireValiderPanel.ResumeLayout(False)
        Me.formulaireValiderPanel.PerformLayout()
        Me.titreFormulairePanel.ResumeLayout(False)
        Me.titreFormulairePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents presenceTableLayoutPanel As TableLayoutPanel
    Friend WithEvents formulaireValiderPanel As Panel
    Friend WithEvents annulerPresenceButton As Button
    Friend WithEvents validerPresenceButton As Button
    Friend WithEvents titreFormulairePanel As Panel
    Friend WithEvents presenceFormulaireLabel As Label
    Friend WithEvents presenceExplicationLabel As Label
    Friend WithEvents presenceTabControl As TabControl
    Friend WithEvents presenceTabPage As TabPage
    Friend WithEvents presencePanel As Panel
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents participantLabel As Label
    Friend WithEvents formateurLabel As Label
    Friend WithEvents formLabel As Label
    Friend WithEvents partiLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox3 As CheckedListBox
End Class
