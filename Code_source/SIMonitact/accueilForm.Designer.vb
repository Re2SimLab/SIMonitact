<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accueilForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accueilForm))
        Me.bienvenueLabel = New System.Windows.Forms.Label()
        Me.selectTacheLabel = New System.Windows.Forms.Label()
        Me.saisirFormButton = New System.Windows.Forms.Button()
        Me.exportDataButton = New System.Windows.Forms.Button()
        Me.genererBilanButton = New System.Windows.Forms.Button()
        Me.modifFormButton = New System.Windows.Forms.Button()
        Me.developpeurLabel = New System.Windows.Forms.Label()
        Me.ReunionPictureBox = New System.Windows.Forms.PictureBox()
        Me.EuropePictureBox = New System.Windows.Forms.PictureBox()
        Me.CHUPictureBox = New System.Windows.Forms.PictureBox()
        Me.ReUniSimPictureBox = New System.Windows.Forms.PictureBox()
        Me.paramettreButton = New System.Windows.Forms.Button()
        CType(Me.ReunionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EuropePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHUPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReUniSimPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bienvenueLabel
        '
        Me.bienvenueLabel.AutoSize = True
        Me.bienvenueLabel.BackColor = System.Drawing.Color.Transparent
        Me.bienvenueLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bienvenueLabel.ForeColor = System.Drawing.Color.White
        Me.bienvenueLabel.Location = New System.Drawing.Point(149, 91)
        Me.bienvenueLabel.Name = "bienvenueLabel"
        Me.bienvenueLabel.Size = New System.Drawing.Size(285, 24)
        Me.bienvenueLabel.TabIndex = 2
        Me.bienvenueLabel.Text = "Bienvenue dans SIMonitact"
        '
        'selectTacheLabel
        '
        Me.selectTacheLabel.AutoSize = True
        Me.selectTacheLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectTacheLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.selectTacheLabel.Location = New System.Drawing.Point(161, 144)
        Me.selectTacheLabel.Name = "selectTacheLabel"
        Me.selectTacheLabel.Size = New System.Drawing.Size(263, 23)
        Me.selectTacheLabel.TabIndex = 1
        Me.selectTacheLabel.Text = "Veuillez sélectionner une tâche."
        '
        'saisirFormButton
        '
        Me.saisirFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saisirFormButton.BackColor = System.Drawing.Color.White
        Me.saisirFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saisirFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saisirFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saisirFormButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.saisirFormButton.Location = New System.Drawing.Point(62, 196)
        Me.saisirFormButton.Name = "saisirFormButton"
        Me.saisirFormButton.Size = New System.Drawing.Size(215, 28)
        Me.saisirFormButton.TabIndex = 0
        Me.saisirFormButton.TabStop = False
        Me.saisirFormButton.Text = "Saisir une formation"
        Me.saisirFormButton.UseVisualStyleBackColor = False
        '
        'exportDataButton
        '
        Me.exportDataButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.exportDataButton.BackColor = System.Drawing.Color.White
        Me.exportDataButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exportDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportDataButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.exportDataButton.Location = New System.Drawing.Point(62, 245)
        Me.exportDataButton.Name = "exportDataButton"
        Me.exportDataButton.Size = New System.Drawing.Size(215, 28)
        Me.exportDataButton.TabIndex = 2
        Me.exportDataButton.TabStop = False
        Me.exportDataButton.Text = "Exporter des données"
        Me.exportDataButton.UseVisualStyleBackColor = False
        '
        'genererBilanButton
        '
        Me.genererBilanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.genererBilanButton.BackColor = System.Drawing.Color.White
        Me.genererBilanButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.genererBilanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.genererBilanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genererBilanButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.genererBilanButton.Location = New System.Drawing.Point(315, 245)
        Me.genererBilanButton.Name = "genererBilanButton"
        Me.genererBilanButton.Size = New System.Drawing.Size(215, 28)
        Me.genererBilanButton.TabIndex = 1
        Me.genererBilanButton.TabStop = False
        Me.genererBilanButton.Text = "Générer un bilan d'activité"
        Me.genererBilanButton.UseVisualStyleBackColor = False
        '
        'modifFormButton
        '
        Me.modifFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.modifFormButton.BackColor = System.Drawing.Color.White
        Me.modifFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifFormButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.modifFormButton.Location = New System.Drawing.Point(315, 196)
        Me.modifFormButton.Name = "modifFormButton"
        Me.modifFormButton.Size = New System.Drawing.Size(215, 28)
        Me.modifFormButton.TabIndex = 3
        Me.modifFormButton.TabStop = False
        Me.modifFormButton.Text = "Modifier/Supprimer une formation"
        Me.modifFormButton.UseVisualStyleBackColor = False
        '
        'developpeurLabel
        '
        Me.developpeurLabel.AutoSize = True
        Me.developpeurLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.developpeurLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.developpeurLabel.Location = New System.Drawing.Point(3, 302)
        Me.developpeurLabel.Name = "developpeurLabel"
        Me.developpeurLabel.Size = New System.Drawing.Size(373, 14)
        Me.developpeurLabel.TabIndex = 6
        Me.developpeurLabel.Text = "Application développée par : E. Garnier - I. Germain - A. Winer - M. Descoins"
        '
        'ReunionPictureBox
        '
        Me.ReunionPictureBox.ErrorImage = Nothing
        Me.ReunionPictureBox.Image = Global.SIMonitact.My.Resources.Resources.Reunion
        Me.ReunionPictureBox.InitialImage = Nothing
        Me.ReunionPictureBox.Location = New System.Drawing.Point(233, -1)
        Me.ReunionPictureBox.Name = "ReunionPictureBox"
        Me.ReunionPictureBox.Size = New System.Drawing.Size(90, 50)
        Me.ReunionPictureBox.TabIndex = 10
        Me.ReunionPictureBox.TabStop = False
        '
        'EuropePictureBox
        '
        Me.EuropePictureBox.ErrorImage = Nothing
        Me.EuropePictureBox.Image = Global.SIMonitact.My.Resources.Resources.Europe
        Me.EuropePictureBox.InitialImage = Nothing
        Me.EuropePictureBox.Location = New System.Drawing.Point(319, -1)
        Me.EuropePictureBox.Name = "EuropePictureBox"
        Me.EuropePictureBox.Size = New System.Drawing.Size(80, 50)
        Me.EuropePictureBox.TabIndex = 9
        Me.EuropePictureBox.TabStop = False
        '
        'CHUPictureBox
        '
        Me.CHUPictureBox.ErrorImage = Nothing
        Me.CHUPictureBox.Image = Global.SIMonitact.My.Resources.Resources.CHU1
        Me.CHUPictureBox.InitialImage = Nothing
        Me.CHUPictureBox.Location = New System.Drawing.Point(146, -1)
        Me.CHUPictureBox.Name = "CHUPictureBox"
        Me.CHUPictureBox.Size = New System.Drawing.Size(90, 50)
        Me.CHUPictureBox.TabIndex = 8
        Me.CHUPictureBox.TabStop = False
        '
        'ReUniSimPictureBox
        '
        Me.ReUniSimPictureBox.ErrorImage = Nothing
        Me.ReUniSimPictureBox.Image = CType(resources.GetObject("ReUniSimPictureBox.Image"), System.Drawing.Image)
        Me.ReUniSimPictureBox.InitialImage = Nothing
        Me.ReUniSimPictureBox.Location = New System.Drawing.Point(-1, -1)
        Me.ReUniSimPictureBox.Name = "ReUniSimPictureBox"
        Me.ReUniSimPictureBox.Size = New System.Drawing.Size(150, 50)
        Me.ReUniSimPictureBox.TabIndex = 7
        Me.ReUniSimPictureBox.TabStop = False
        '
        'paramettreButton
        '
        Me.paramettreButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.paramettreButton.BackColor = System.Drawing.Color.Transparent
        Me.paramettreButton.BackgroundImage = Global.SIMonitact.My.Resources.Resources._7410416951552644391_24
        Me.paramettreButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paramettreButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.paramettreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.paramettreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.paramettreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paramettreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paramettreButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.paramettreButton.Location = New System.Drawing.Point(558, 286)
        Me.paramettreButton.Name = "paramettreButton"
        Me.paramettreButton.Size = New System.Drawing.Size(27, 27)
        Me.paramettreButton.TabIndex = 4
        Me.paramettreButton.TabStop = False
        Me.paramettreButton.UseVisualStyleBackColor = False
        '
        'accueilForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(591, 319)
        Me.Controls.Add(Me.ReunionPictureBox)
        Me.Controls.Add(Me.EuropePictureBox)
        Me.Controls.Add(Me.CHUPictureBox)
        Me.Controls.Add(Me.ReUniSimPictureBox)
        Me.Controls.Add(Me.developpeurLabel)
        Me.Controls.Add(Me.paramettreButton)
        Me.Controls.Add(Me.modifFormButton)
        Me.Controls.Add(Me.genererBilanButton)
        Me.Controls.Add(Me.exportDataButton)
        Me.Controls.Add(Me.saisirFormButton)
        Me.Controls.Add(Me.selectTacheLabel)
        Me.Controls.Add(Me.bienvenueLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "accueilForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMonitact"
        CType(Me.ReunionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EuropePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHUPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReUniSimPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bienvenueLabel As Label
    Friend WithEvents selectTacheLabel As Label
    Friend WithEvents saisirFormButton As Button
    Friend WithEvents exportDataButton As Button
    Friend WithEvents genererBilanButton As Button
    Friend WithEvents modifFormButton As Button
    Friend WithEvents paramettreButton As Button
    Friend WithEvents developpeurLabel As Label
    Friend WithEvents ReUniSimPictureBox As PictureBox
    Friend WithEvents CHUPictureBox As PictureBox
    Friend WithEvents EuropePictureBox As PictureBox
    Friend WithEvents ReunionPictureBox As PictureBox
End Class
