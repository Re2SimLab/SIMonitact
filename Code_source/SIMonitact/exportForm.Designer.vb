<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(exportForm))
        Me.saisieExtractionLabel = New System.Windows.Forms.Label()
        Me.anneeExtractionNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.extraireButton = New System.Windows.Forms.Button()
        Me.extractionSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.allExtractionRadioButton = New System.Windows.Forms.RadioButton()
        Me.anneeExtractionRadioButton = New System.Windows.Forms.RadioButton()
        Me.selecVariableTabControl = New System.Windows.Forms.TabControl()
        Me.selecVariableTabPage = New System.Windows.Forms.TabPage()
        Me.selecVariablePanel = New System.Windows.Forms.Panel()
        Me.aideFormCheckBox = New System.Windows.Forms.CheckBox()
        Me.participantCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.participantCheckBox = New System.Windows.Forms.CheckBox()
        Me.aideFormCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.formateurCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.formateurCheckBox = New System.Windows.Forms.CheckBox()
        Me.DJCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.DJCheckBox = New System.Windows.Forms.CheckBox()
        Me.formationCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.formationCheckBox = New System.Windows.Forms.CheckBox()
        Me.participantLabel = New System.Windows.Forms.Label()
        Me.formateurLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.annulerExtracFormButton = New System.Windows.Forms.Button()
        CType(Me.anneeExtractionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.selecVariableTabControl.SuspendLayout()
        Me.selecVariableTabPage.SuspendLayout()
        Me.selecVariablePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'saisieExtractionLabel
        '
        Me.saisieExtractionLabel.AutoSize = True
        Me.saisieExtractionLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saisieExtractionLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.saisieExtractionLabel.Location = New System.Drawing.Point(22, 23)
        Me.saisieExtractionLabel.Name = "saisieExtractionLabel"
        Me.saisieExtractionLabel.Size = New System.Drawing.Size(640, 38)
        Me.saisieExtractionLabel.TabIndex = 3
        Me.saisieExtractionLabel.Text = "Veuillez sélectionner les options pour extraire les données de la base de données" &
    " SIMonitact." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/!\ L'extraction peut prendre quelques minutes."
        '
        'anneeExtractionNumericUpDown
        '
        Me.anneeExtractionNumericUpDown.Enabled = False
        Me.anneeExtractionNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anneeExtractionNumericUpDown.Location = New System.Drawing.Point(700, 78)
        Me.anneeExtractionNumericUpDown.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.anneeExtractionNumericUpDown.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.anneeExtractionNumericUpDown.Name = "anneeExtractionNumericUpDown"
        Me.anneeExtractionNumericUpDown.Size = New System.Drawing.Size(112, 22)
        Me.anneeExtractionNumericUpDown.TabIndex = 19
        Me.anneeExtractionNumericUpDown.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'extraireButton
        '
        Me.extraireButton.AutoSize = True
        Me.extraireButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.extraireButton.BackColor = System.Drawing.Color.White
        Me.extraireButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.extraireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.extraireButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extraireButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.extraireButton.Location = New System.Drawing.Point(418, 522)
        Me.extraireButton.Name = "extraireButton"
        Me.extraireButton.Size = New System.Drawing.Size(162, 28)
        Me.extraireButton.TabIndex = 30
        Me.extraireButton.Text = "Extraire les données"
        Me.extraireButton.UseVisualStyleBackColor = False
        '
        'extractionSaveFileDialog
        '
        Me.extractionSaveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm"
        Me.extractionSaveFileDialog.Title = "Choisir le nom et l'emplacement du fichier"
        '
        'allExtractionRadioButton
        '
        Me.allExtractionRadioButton.AutoSize = True
        Me.allExtractionRadioButton.Checked = True
        Me.allExtractionRadioButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allExtractionRadioButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.allExtractionRadioButton.Location = New System.Drawing.Point(174, 78)
        Me.allExtractionRadioButton.Name = "allExtractionRadioButton"
        Me.allExtractionRadioButton.Size = New System.Drawing.Size(214, 20)
        Me.allExtractionRadioButton.TabIndex = 31
        Me.allExtractionRadioButton.TabStop = True
        Me.allExtractionRadioButton.Text = "Extraire l'ensemble des données"
        Me.allExtractionRadioButton.UseVisualStyleBackColor = True
        '
        'anneeExtractionRadioButton
        '
        Me.anneeExtractionRadioButton.AutoSize = True
        Me.anneeExtractionRadioButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anneeExtractionRadioButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.anneeExtractionRadioButton.Location = New System.Drawing.Point(479, 76)
        Me.anneeExtractionRadioButton.Name = "anneeExtractionRadioButton"
        Me.anneeExtractionRadioButton.Size = New System.Drawing.Size(215, 20)
        Me.anneeExtractionRadioButton.TabIndex = 33
        Me.anneeExtractionRadioButton.Text = "Extraire les données de l'année :"
        Me.anneeExtractionRadioButton.UseVisualStyleBackColor = True
        '
        'selecVariableTabControl
        '
        Me.selecVariableTabControl.Controls.Add(Me.selecVariableTabPage)
        Me.selecVariableTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selecVariableTabControl.Location = New System.Drawing.Point(12, 117)
        Me.selecVariableTabControl.Name = "selecVariableTabControl"
        Me.selecVariableTabControl.SelectedIndex = 0
        Me.selecVariableTabControl.Size = New System.Drawing.Size(978, 393)
        Me.selecVariableTabControl.TabIndex = 34
        '
        'selecVariableTabPage
        '
        Me.selecVariableTabPage.Controls.Add(Me.selecVariablePanel)
        Me.selecVariableTabPage.Location = New System.Drawing.Point(4, 25)
        Me.selecVariableTabPage.Name = "selecVariableTabPage"
        Me.selecVariableTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.selecVariableTabPage.Size = New System.Drawing.Size(970, 364)
        Me.selecVariableTabPage.TabIndex = 0
        Me.selecVariableTabPage.Text = "Choix des variables à extraire"
        Me.selecVariableTabPage.UseVisualStyleBackColor = True
        '
        'selecVariablePanel
        '
        Me.selecVariablePanel.AutoScroll = True
        Me.selecVariablePanel.Controls.Add(Me.aideFormCheckBox)
        Me.selecVariablePanel.Controls.Add(Me.participantCheckedListBox)
        Me.selecVariablePanel.Controls.Add(Me.participantCheckBox)
        Me.selecVariablePanel.Controls.Add(Me.aideFormCheckedListBox)
        Me.selecVariablePanel.Controls.Add(Me.formateurCheckedListBox)
        Me.selecVariablePanel.Controls.Add(Me.formateurCheckBox)
        Me.selecVariablePanel.Controls.Add(Me.DJCheckedListBox)
        Me.selecVariablePanel.Controls.Add(Me.DJCheckBox)
        Me.selecVariablePanel.Controls.Add(Me.formationCheckedListBox)
        Me.selecVariablePanel.Controls.Add(Me.formationCheckBox)
        Me.selecVariablePanel.Controls.Add(Me.participantLabel)
        Me.selecVariablePanel.Controls.Add(Me.formateurLabel)
        Me.selecVariablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.selecVariablePanel.Location = New System.Drawing.Point(3, 3)
        Me.selecVariablePanel.Name = "selecVariablePanel"
        Me.selecVariablePanel.Size = New System.Drawing.Size(964, 358)
        Me.selecVariablePanel.TabIndex = 0
        '
        'aideFormCheckBox
        '
        Me.aideFormCheckBox.AutoSize = True
        Me.aideFormCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aideFormCheckBox.Location = New System.Drawing.Point(585, 12)
        Me.aideFormCheckBox.Name = "aideFormCheckBox"
        Me.aideFormCheckBox.Size = New System.Drawing.Size(115, 20)
        Me.aideFormCheckBox.TabIndex = 30
        Me.aideFormCheckBox.Text = "Aide-formateur"
        Me.aideFormCheckBox.UseVisualStyleBackColor = True
        '
        'participantCheckedListBox
        '
        Me.participantCheckedListBox.FormattingEnabled = True
        Me.participantCheckedListBox.Items.AddRange(New Object() {"ID_participant", "nom", "prenom", "profession", "service", "lieu_profession", "num_ADELI_matricule", "mail", "droit_image"})
        Me.participantCheckedListBox.Location = New System.Drawing.Point(770, 37)
        Me.participantCheckedListBox.Name = "participantCheckedListBox"
        Me.participantCheckedListBox.Size = New System.Drawing.Size(160, 310)
        Me.participantCheckedListBox.TabIndex = 29
        '
        'participantCheckBox
        '
        Me.participantCheckBox.AutoSize = True
        Me.participantCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.participantCheckBox.Location = New System.Drawing.Point(770, 12)
        Me.participantCheckBox.Name = "participantCheckBox"
        Me.participantCheckBox.Size = New System.Drawing.Size(90, 20)
        Me.participantCheckBox.TabIndex = 28
        Me.participantCheckBox.Text = "Participant"
        Me.participantCheckBox.UseVisualStyleBackColor = True
        '
        'aideFormCheckedListBox
        '
        Me.aideFormCheckedListBox.FormattingEnabled = True
        Me.aideFormCheckedListBox.Items.AddRange(New Object() {"ID_aide_formateur", "nom", "prenom", "profession", "service", "lieu_profession", "num_ADELI_matricule", "mail", "droit_image"})
        Me.aideFormCheckedListBox.Location = New System.Drawing.Point(585, 38)
        Me.aideFormCheckedListBox.Name = "aideFormCheckedListBox"
        Me.aideFormCheckedListBox.Size = New System.Drawing.Size(160, 310)
        Me.aideFormCheckedListBox.TabIndex = 27
        '
        'formateurCheckedListBox
        '
        Me.formateurCheckedListBox.FormattingEnabled = True
        Me.formateurCheckedListBox.Items.AddRange(New Object() {"ID_formateur", "nom", "prenom", "profession", "service", "lieu_profession", "formateur_certifie", "num_ADELI_matricule", "mail", "droit_image"})
        Me.formateurCheckedListBox.Location = New System.Drawing.Point(400, 38)
        Me.formateurCheckedListBox.Name = "formateurCheckedListBox"
        Me.formateurCheckedListBox.Size = New System.Drawing.Size(160, 310)
        Me.formateurCheckedListBox.TabIndex = 26
        '
        'formateurCheckBox
        '
        Me.formateurCheckBox.AutoSize = True
        Me.formateurCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formateurCheckBox.Location = New System.Drawing.Point(400, 12)
        Me.formateurCheckBox.Name = "formateurCheckBox"
        Me.formateurCheckBox.Size = New System.Drawing.Size(88, 20)
        Me.formateurCheckBox.TabIndex = 25
        Me.formateurCheckBox.Text = "Formateur"
        Me.formateurCheckBox.UseVisualStyleBackColor = True
        '
        'DJCheckedListBox
        '
        Me.DJCheckedListBox.FormattingEnabled = True
        Me.DJCheckedListBox.Items.AddRange(New Object() {"ID_DJ", "ID_formation", "date", "AMPM", "jour_entier", "nb_formateur", "nb_aide_formateur", "nb_participant"})
        Me.DJCheckedListBox.Location = New System.Drawing.Point(215, 37)
        Me.DJCheckedListBox.Name = "DJCheckedListBox"
        Me.DJCheckedListBox.Size = New System.Drawing.Size(160, 310)
        Me.DJCheckedListBox.TabIndex = 24
        '
        'DJCheckBox
        '
        Me.DJCheckBox.AutoSize = True
        Me.DJCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DJCheckBox.Location = New System.Drawing.Point(215, 12)
        Me.DJCheckBox.Name = "DJCheckBox"
        Me.DJCheckBox.Size = New System.Drawing.Size(136, 20)
        Me.DJCheckBox.TabIndex = 23
        Me.DJCheckBox.Text = "Demi-journée (DJ)"
        Me.DJCheckBox.UseVisualStyleBackColor = True
        '
        'formationCheckedListBox
        '
        Me.formationCheckedListBox.FormattingEnabled = True
        Me.formationCheckedListBox.Items.AddRange(New Object() {"ID_formation", "annee", "date_debut", "nb_DJ", "categorie", "intitule", "structure_organisatrice", "responsable_nom", "responsable_prenom", "formation_centre", "lieu", "nb_formateur", "nb_aide_formateur", "nb_participant", "recette", "frais", "etat_titre"})
        Me.formationCheckedListBox.Location = New System.Drawing.Point(30, 38)
        Me.formationCheckedListBox.Name = "formationCheckedListBox"
        Me.formationCheckedListBox.Size = New System.Drawing.Size(160, 310)
        Me.formationCheckedListBox.TabIndex = 22
        '
        'formationCheckBox
        '
        Me.formationCheckBox.AutoSize = True
        Me.formationCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formationCheckBox.Location = New System.Drawing.Point(30, 12)
        Me.formationCheckBox.Name = "formationCheckBox"
        Me.formationCheckBox.Size = New System.Drawing.Size(87, 20)
        Me.formationCheckBox.TabIndex = 21
        Me.formationCheckBox.Text = "Formation"
        Me.formationCheckBox.UseVisualStyleBackColor = True
        '
        'participantLabel
        '
        Me.participantLabel.AutoSize = True
        Me.participantLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.participantLabel.ForeColor = System.Drawing.Color.Teal
        Me.participantLabel.Location = New System.Drawing.Point(490, 17)
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
        'annulerExtracFormButton
        '
        Me.annulerExtracFormButton.AutoSize = True
        Me.annulerExtracFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.annulerExtracFormButton.BackColor = System.Drawing.Color.White
        Me.annulerExtracFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.annulerExtracFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.annulerExtracFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annulerExtracFormButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.annulerExtracFormButton.Location = New System.Drawing.Point(907, 522)
        Me.annulerExtracFormButton.Name = "annulerExtracFormButton"
        Me.annulerExtracFormButton.Size = New System.Drawing.Size(65, 28)
        Me.annulerExtracFormButton.TabIndex = 35
        Me.annulerExtracFormButton.Text = "Annuler"
        Me.annulerExtracFormButton.UseVisualStyleBackColor = False
        '
        'exportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.annulerExtracFormButton)
        Me.Controls.Add(Me.selecVariableTabControl)
        Me.Controls.Add(Me.anneeExtractionRadioButton)
        Me.Controls.Add(Me.allExtractionRadioButton)
        Me.Controls.Add(Me.extraireButton)
        Me.Controls.Add(Me.anneeExtractionNumericUpDown)
        Me.Controls.Add(Me.saisieExtractionLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "exportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extraction des données"
        CType(Me.anneeExtractionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.selecVariableTabControl.ResumeLayout(False)
        Me.selecVariableTabPage.ResumeLayout(False)
        Me.selecVariablePanel.ResumeLayout(False)
        Me.selecVariablePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents saisieExtractionLabel As Label
    Friend WithEvents anneeExtractionNumericUpDown As NumericUpDown
    Friend WithEvents extraireButton As Button
    Friend WithEvents extractionSaveFileDialog As SaveFileDialog
    Friend WithEvents allExtractionRadioButton As RadioButton
    Friend WithEvents anneeExtractionRadioButton As RadioButton
    Friend WithEvents selecVariableTabControl As TabControl
    Friend WithEvents selecVariableTabPage As TabPage
    Friend WithEvents selecVariablePanel As Panel
    Friend WithEvents participantCheckBox As CheckBox
    Friend WithEvents aideFormCheckedListBox As CheckedListBox
    Friend WithEvents formateurCheckedListBox As CheckedListBox
    Friend WithEvents formateurCheckBox As CheckBox
    Friend WithEvents DJCheckedListBox As CheckedListBox
    Friend WithEvents DJCheckBox As CheckBox
    Friend WithEvents formationCheckedListBox As CheckedListBox
    Friend WithEvents formationCheckBox As CheckBox
    Friend WithEvents participantLabel As Label
    Friend WithEvents formateurLabel As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents participantCheckedListBox As CheckedListBox
    Friend WithEvents aideFormCheckBox As CheckBox
    Friend WithEvents annulerExtracFormButton As Button
End Class
