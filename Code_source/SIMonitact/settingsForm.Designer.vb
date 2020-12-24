<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsForm))
        Me.annulerSettingsButton = New System.Windows.Forms.Button()
        Me.saveSettingsButton = New System.Windows.Forms.Button()
        Me.pathBDDTextBox = New System.Windows.Forms.TextBox()
        Me.pathBDDLabel = New System.Windows.Forms.Label()
        Me.pathBackupBDDTextBox = New System.Windows.Forms.TextBox()
        Me.pathBackupBDDLabel = New System.Windows.Forms.Label()
        Me.pathExtracTextBox = New System.Windows.Forms.TextBox()
        Me.pathExtracLabel = New System.Windows.Forms.Label()
        Me.saisieSettingsLabel = New System.Windows.Forms.Label()
        Me.paramettreButton = New System.Windows.Forms.Button()
        Me.pathbDDButton = New System.Windows.Forms.Button()
        Me.pathBDDSIMonitactButton = New System.Windows.Forms.Button()
        Me.pathBackupBDDButton = New System.Windows.Forms.Button()
        Me.pathExtracButton = New System.Windows.Forms.Button()
        Me.pathBDDFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.pathBackupBDDFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.pathExtracFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.mdpTextBox = New System.Windows.Forms.TextBox()
        Me.mdpLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'annulerSettingsButton
        '
        Me.annulerSettingsButton.AutoSize = True
        Me.annulerSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.annulerSettingsButton.BackColor = System.Drawing.Color.White
        Me.annulerSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.annulerSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.annulerSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annulerSettingsButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.annulerSettingsButton.Location = New System.Drawing.Point(514, 279)
        Me.annulerSettingsButton.Name = "annulerSettingsButton"
        Me.annulerSettingsButton.Size = New System.Drawing.Size(65, 28)
        Me.annulerSettingsButton.TabIndex = 3
        Me.annulerSettingsButton.Text = "Annuler"
        Me.annulerSettingsButton.UseVisualStyleBackColor = False
        '
        'saveSettingsButton
        '
        Me.saveSettingsButton.AutoSize = True
        Me.saveSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saveSettingsButton.BackColor = System.Drawing.Color.White
        Me.saveSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveSettingsButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.saveSettingsButton.Location = New System.Drawing.Point(194, 279)
        Me.saveSettingsButton.Name = "saveSettingsButton"
        Me.saveSettingsButton.Size = New System.Drawing.Size(218, 28)
        Me.saveSettingsButton.TabIndex = 2
        Me.saveSettingsButton.Text = "Sauvegarder les paramètres"
        Me.saveSettingsButton.UseVisualStyleBackColor = False
        '
        'pathBDDTextBox
        '
        Me.pathBDDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathBDDTextBox.Location = New System.Drawing.Point(16, 71)
        Me.pathBDDTextBox.Name = "pathBDDTextBox"
        Me.pathBDDTextBox.Size = New System.Drawing.Size(530, 22)
        Me.pathBDDTextBox.TabIndex = 17
        '
        'pathBDDLabel
        '
        Me.pathBDDLabel.AutoSize = True
        Me.pathBDDLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathBDDLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pathBDDLabel.Location = New System.Drawing.Point(13, 52)
        Me.pathBDDLabel.Name = "pathBDDLabel"
        Me.pathBDDLabel.Size = New System.Drawing.Size(164, 16)
        Me.pathBDDLabel.TabIndex = 18
        Me.pathBDDLabel.Text = "Chemin d'accès à la BDD :"
        '
        'pathBackupBDDTextBox
        '
        Me.pathBackupBDDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathBackupBDDTextBox.Location = New System.Drawing.Point(16, 125)
        Me.pathBackupBDDTextBox.Name = "pathBackupBDDTextBox"
        Me.pathBackupBDDTextBox.Size = New System.Drawing.Size(530, 22)
        Me.pathBackupBDDTextBox.TabIndex = 19
        '
        'pathBackupBDDLabel
        '
        Me.pathBackupBDDLabel.AutoSize = True
        Me.pathBackupBDDLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathBackupBDDLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pathBackupBDDLabel.Location = New System.Drawing.Point(13, 106)
        Me.pathBackupBDDLabel.Name = "pathBackupBDDLabel"
        Me.pathBackupBDDLabel.Size = New System.Drawing.Size(326, 16)
        Me.pathBackupBDDLabel.TabIndex = 20
        Me.pathBackupBDDLabel.Text = "Chemin d'accès de la sauvegarde (backup) de la BDD :"
        '
        'pathExtracTextBox
        '
        Me.pathExtracTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathExtracTextBox.Location = New System.Drawing.Point(16, 179)
        Me.pathExtracTextBox.Name = "pathExtracTextBox"
        Me.pathExtracTextBox.Size = New System.Drawing.Size(530, 22)
        Me.pathExtracTextBox.TabIndex = 21
        '
        'pathExtracLabel
        '
        Me.pathExtracLabel.AutoSize = True
        Me.pathExtracLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathExtracLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pathExtracLabel.Location = New System.Drawing.Point(13, 160)
        Me.pathExtracLabel.Name = "pathExtracLabel"
        Me.pathExtracLabel.Size = New System.Drawing.Size(315, 16)
        Me.pathExtracLabel.TabIndex = 22
        Me.pathExtracLabel.Text = "Chemin d'enregistrement des extractions de la BDD :"
        '
        'saisieSettingsLabel
        '
        Me.saisieSettingsLabel.AutoSize = True
        Me.saisieSettingsLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saisieSettingsLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.saisieSettingsLabel.Location = New System.Drawing.Point(12, 20)
        Me.saisieSettingsLabel.Name = "saisieSettingsLabel"
        Me.saisieSettingsLabel.Size = New System.Drawing.Size(391, 19)
        Me.saisieSettingsLabel.TabIndex = 23
        Me.saisieSettingsLabel.Text = "Veuillez rentrer les différents paramètres de SIMonitact."
        '
        'paramettreButton
        '
        Me.paramettreButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.paramettreButton.BackColor = System.Drawing.Color.Transparent
        Me.paramettreButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paramettreButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.paramettreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.paramettreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.paramettreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paramettreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paramettreButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.paramettreButton.Location = New System.Drawing.Point(552, 83)
        Me.paramettreButton.Name = "paramettreButton"
        Me.paramettreButton.Size = New System.Drawing.Size(27, 27)
        Me.paramettreButton.TabIndex = 24
        Me.paramettreButton.TabStop = False
        Me.paramettreButton.UseVisualStyleBackColor = False
        '
        'pathbDDButton
        '
        Me.pathbDDButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pathbDDButton.BackColor = System.Drawing.Color.Transparent
        Me.pathbDDButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pathbDDButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.pathbDDButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.pathbDDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.pathbDDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pathbDDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathbDDButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pathbDDButton.Location = New System.Drawing.Point(552, 83)
        Me.pathbDDButton.Name = "pathbDDButton"
        Me.pathbDDButton.Size = New System.Drawing.Size(27, 27)
        Me.pathbDDButton.TabIndex = 24
        Me.pathbDDButton.TabStop = False
        Me.pathbDDButton.UseVisualStyleBackColor = False
        '
        'pathBDDSIMonitactButton
        '
        Me.pathBDDSIMonitactButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pathBDDSIMonitactButton.BackColor = System.Drawing.Color.Transparent
        Me.pathBDDSIMonitactButton.BackgroundImage = Global.SIMonitact.My.Resources.Resources._290088311558096434_24
        Me.pathBDDSIMonitactButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pathBDDSIMonitactButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.pathBDDSIMonitactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.pathBDDSIMonitactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.pathBDDSIMonitactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pathBDDSIMonitactButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathBDDSIMonitactButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pathBDDSIMonitactButton.Location = New System.Drawing.Point(552, 69)
        Me.pathBDDSIMonitactButton.Name = "pathBDDSIMonitactButton"
        Me.pathBDDSIMonitactButton.Size = New System.Drawing.Size(27, 27)
        Me.pathBDDSIMonitactButton.TabIndex = 24
        Me.pathBDDSIMonitactButton.TabStop = False
        Me.pathBDDSIMonitactButton.UseVisualStyleBackColor = False
        '
        'pathBackupBDDButton
        '
        Me.pathBackupBDDButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pathBackupBDDButton.BackColor = System.Drawing.Color.Transparent
        Me.pathBackupBDDButton.BackgroundImage = Global.SIMonitact.My.Resources.Resources._290088311558096434_24
        Me.pathBackupBDDButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pathBackupBDDButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.pathBackupBDDButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.pathBackupBDDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.pathBackupBDDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pathBackupBDDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathBackupBDDButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pathBackupBDDButton.Location = New System.Drawing.Point(552, 123)
        Me.pathBackupBDDButton.Name = "pathBackupBDDButton"
        Me.pathBackupBDDButton.Size = New System.Drawing.Size(27, 27)
        Me.pathBackupBDDButton.TabIndex = 25
        Me.pathBackupBDDButton.TabStop = False
        Me.pathBackupBDDButton.UseVisualStyleBackColor = False
        '
        'pathExtracButton
        '
        Me.pathExtracButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pathExtracButton.BackColor = System.Drawing.Color.Transparent
        Me.pathExtracButton.BackgroundImage = Global.SIMonitact.My.Resources.Resources._290088311558096434_24
        Me.pathExtracButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pathExtracButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.pathExtracButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.pathExtracButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.pathExtracButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pathExtracButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathExtracButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pathExtracButton.Location = New System.Drawing.Point(552, 177)
        Me.pathExtracButton.Name = "pathExtracButton"
        Me.pathExtracButton.Size = New System.Drawing.Size(27, 27)
        Me.pathExtracButton.TabIndex = 26
        Me.pathExtracButton.TabStop = False
        Me.pathExtracButton.UseVisualStyleBackColor = False
        '
        'mdpTextBox
        '
        Me.mdpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdpTextBox.Location = New System.Drawing.Point(16, 233)
        Me.mdpTextBox.Name = "mdpTextBox"
        Me.mdpTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mdpTextBox.Size = New System.Drawing.Size(196, 22)
        Me.mdpTextBox.TabIndex = 27
        '
        'mdpLabel
        '
        Me.mdpLabel.AutoSize = True
        Me.mdpLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdpLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.mdpLabel.Location = New System.Drawing.Point(13, 214)
        Me.mdpLabel.Name = "mdpLabel"
        Me.mdpLabel.Size = New System.Drawing.Size(199, 16)
        Me.mdpLabel.TabIndex = 28
        Me.mdpLabel.Text = "Mot de passe d'accès à la BDD :"
        '
        'settingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(591, 319)
        Me.Controls.Add(Me.mdpTextBox)
        Me.Controls.Add(Me.mdpLabel)
        Me.Controls.Add(Me.pathExtracButton)
        Me.Controls.Add(Me.pathBackupBDDButton)
        Me.Controls.Add(Me.pathBDDSIMonitactButton)
        Me.Controls.Add(Me.saisieSettingsLabel)
        Me.Controls.Add(Me.pathExtracTextBox)
        Me.Controls.Add(Me.pathExtracLabel)
        Me.Controls.Add(Me.pathBackupBDDTextBox)
        Me.Controls.Add(Me.pathBackupBDDLabel)
        Me.Controls.Add(Me.pathBDDTextBox)
        Me.Controls.Add(Me.pathBDDLabel)
        Me.Controls.Add(Me.annulerSettingsButton)
        Me.Controls.Add(Me.saveSettingsButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres SIMonitact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents annulerSettingsButton As Button
    Friend WithEvents saveSettingsButton As Button
    Friend WithEvents pathBDDTextBox As TextBox
    Friend WithEvents pathBDDLabel As Label
    Friend WithEvents pathBackupBDDTextBox As TextBox
    Friend WithEvents pathBackupBDDLabel As Label
    Friend WithEvents pathExtracTextBox As TextBox
    Friend WithEvents pathExtracLabel As Label
    Friend WithEvents saisieSettingsLabel As Label
    Friend WithEvents pathBDDSIMonitactButton As Button
    Friend WithEvents paramettreButton As Button
    Friend WithEvents pathbDDButton As Button
    Friend WithEvents pathBackupBDDButton As Button
    Friend WithEvents pathExtracButton As Button
    Friend WithEvents pathBDDFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents pathBackupBDDFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents pathExtracFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents mdpTextBox As TextBox
    Friend WithEvents mdpLabel As Label
End Class
