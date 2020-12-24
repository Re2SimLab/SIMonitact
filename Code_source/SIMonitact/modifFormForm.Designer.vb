<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifFormForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modifFormForm))
        Me.modifFormTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.formulaireValiderPanel = New System.Windows.Forms.Panel()
        Me.supprimerFormButton = New System.Windows.Forms.Button()
        Me.annulerModifFormButton = New System.Windows.Forms.Button()
        Me.modifierFormModifButton = New System.Windows.Forms.Button()
        Me.titreModifFormPanel = New System.Windows.Forms.Panel()
        Me.dateDebComboBox = New System.Windows.Forms.ComboBox()
        Me.filtrerButton = New System.Windows.Forms.Button()
        Me.categoFormComboBox = New System.Windows.Forms.ComboBox()
        Me.categoFormLabel = New System.Windows.Forms.Label()
        Me.dateDebFormLabel = New System.Windows.Forms.Label()
        Me.anneeFormNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.anneeFormLabel = New System.Windows.Forms.Label()
        Me.modifFormationLabel = New System.Windows.Forms.Label()
        Me.modifFormExplicationLabel = New System.Windows.Forms.Label()
        Me.formationDataGridView = New System.Windows.Forms.DataGridView()
        Me.modifFormTableLayoutPanel.SuspendLayout()
        Me.formulaireValiderPanel.SuspendLayout()
        Me.titreModifFormPanel.SuspendLayout()
        CType(Me.anneeFormNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.formationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'modifFormTableLayoutPanel
        '
        Me.modifFormTableLayoutPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.modifFormTableLayoutPanel.ColumnCount = 1
        Me.modifFormTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.modifFormTableLayoutPanel.Controls.Add(Me.formulaireValiderPanel, 0, 2)
        Me.modifFormTableLayoutPanel.Controls.Add(Me.titreModifFormPanel, 0, 0)
        Me.modifFormTableLayoutPanel.Controls.Add(Me.formationDataGridView, 0, 1)
        Me.modifFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.modifFormTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.modifFormTableLayoutPanel.Name = "modifFormTableLayoutPanel"
        Me.modifFormTableLayoutPanel.RowCount = 3
        Me.modifFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.93594!))
        Me.modifFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.92171!))
        Me.modifFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.modifFormTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.modifFormTableLayoutPanel.Size = New System.Drawing.Size(984, 562)
        Me.modifFormTableLayoutPanel.TabIndex = 2
        '
        'formulaireValiderPanel
        '
        Me.formulaireValiderPanel.Controls.Add(Me.supprimerFormButton)
        Me.formulaireValiderPanel.Controls.Add(Me.annulerModifFormButton)
        Me.formulaireValiderPanel.Controls.Add(Me.modifierFormModifButton)
        Me.formulaireValiderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formulaireValiderPanel.Location = New System.Drawing.Point(3, 508)
        Me.formulaireValiderPanel.Name = "formulaireValiderPanel"
        Me.formulaireValiderPanel.Size = New System.Drawing.Size(978, 51)
        Me.formulaireValiderPanel.TabIndex = 2
        '
        'supprimerFormButton
        '
        Me.supprimerFormButton.AutoSize = True
        Me.supprimerFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.supprimerFormButton.BackColor = System.Drawing.Color.White
        Me.supprimerFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.supprimerFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimerFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supprimerFormButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.supprimerFormButton.Location = New System.Drawing.Point(514, 12)
        Me.supprimerFormButton.Name = "supprimerFormButton"
        Me.supprimerFormButton.Size = New System.Drawing.Size(269, 28)
        Me.supprimerFormButton.TabIndex = 6
        Me.supprimerFormButton.Text = "Supprimer la formation sélectionnée"
        Me.supprimerFormButton.UseVisualStyleBackColor = False
        '
        'annulerModifFormButton
        '
        Me.annulerModifFormButton.AutoSize = True
        Me.annulerModifFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.annulerModifFormButton.BackColor = System.Drawing.Color.White
        Me.annulerModifFormButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.annulerModifFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.annulerModifFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annulerModifFormButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.annulerModifFormButton.Location = New System.Drawing.Point(906, 12)
        Me.annulerModifFormButton.Name = "annulerModifFormButton"
        Me.annulerModifFormButton.Size = New System.Drawing.Size(65, 28)
        Me.annulerModifFormButton.TabIndex = 5
        Me.annulerModifFormButton.Text = "Annuler"
        Me.annulerModifFormButton.UseVisualStyleBackColor = False
        '
        'modifierFormModifButton
        '
        Me.modifierFormModifButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.modifierFormModifButton.BackColor = System.Drawing.Color.White
        Me.modifierFormModifButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifierFormModifButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifierFormModifButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifierFormModifButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.modifierFormModifButton.Location = New System.Drawing.Point(195, 12)
        Me.modifierFormModifButton.Name = "modifierFormModifButton"
        Me.modifierFormModifButton.Size = New System.Drawing.Size(269, 28)
        Me.modifierFormModifButton.TabIndex = 4
        Me.modifierFormModifButton.Text = "Modifier la formation sélectionnée"
        Me.modifierFormModifButton.UseVisualStyleBackColor = False
        '
        'titreModifFormPanel
        '
        Me.titreModifFormPanel.Controls.Add(Me.dateDebComboBox)
        Me.titreModifFormPanel.Controls.Add(Me.filtrerButton)
        Me.titreModifFormPanel.Controls.Add(Me.categoFormComboBox)
        Me.titreModifFormPanel.Controls.Add(Me.categoFormLabel)
        Me.titreModifFormPanel.Controls.Add(Me.dateDebFormLabel)
        Me.titreModifFormPanel.Controls.Add(Me.anneeFormNumericUpDown)
        Me.titreModifFormPanel.Controls.Add(Me.anneeFormLabel)
        Me.titreModifFormPanel.Controls.Add(Me.modifFormationLabel)
        Me.titreModifFormPanel.Controls.Add(Me.modifFormExplicationLabel)
        Me.titreModifFormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titreModifFormPanel.Location = New System.Drawing.Point(3, 3)
        Me.titreModifFormPanel.Name = "titreModifFormPanel"
        Me.titreModifFormPanel.Size = New System.Drawing.Size(978, 151)
        Me.titreModifFormPanel.TabIndex = 3
        '
        'dateDebComboBox
        '
        Me.dateDebComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.dateDebComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dateDebComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDebComboBox.FormattingEnabled = True
        Me.dateDebComboBox.ItemHeight = 16
        Me.dateDebComboBox.Location = New System.Drawing.Point(504, 78)
        Me.dateDebComboBox.MaxDropDownItems = 50
        Me.dateDebComboBox.Name = "dateDebComboBox"
        Me.dateDebComboBox.Size = New System.Drawing.Size(114, 24)
        Me.dateDebComboBox.TabIndex = 27
        '
        'filtrerButton
        '
        Me.filtrerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.filtrerButton.BackColor = System.Drawing.Color.White
        Me.filtrerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtrerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filtrerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtrerButton.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.filtrerButton.Location = New System.Drawing.Point(449, 113)
        Me.filtrerButton.Name = "filtrerButton"
        Me.filtrerButton.Size = New System.Drawing.Size(80, 28)
        Me.filtrerButton.TabIndex = 6
        Me.filtrerButton.Text = "Filtrer"
        Me.filtrerButton.UseVisualStyleBackColor = False
        '
        'categoFormComboBox
        '
        Me.categoFormComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.categoFormComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.categoFormComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoFormComboBox.FormattingEnabled = True
        Me.categoFormComboBox.ItemHeight = 16
        Me.categoFormComboBox.Location = New System.Drawing.Point(799, 78)
        Me.categoFormComboBox.MaxDropDownItems = 50
        Me.categoFormComboBox.Name = "categoFormComboBox"
        Me.categoFormComboBox.Size = New System.Drawing.Size(158, 24)
        Me.categoFormComboBox.TabIndex = 25
        '
        'categoFormLabel
        '
        Me.categoFormLabel.AutoSize = True
        Me.categoFormLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoFormLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.categoFormLabel.Location = New System.Drawing.Point(640, 81)
        Me.categoFormLabel.Name = "categoFormLabel"
        Me.categoFormLabel.Size = New System.Drawing.Size(160, 16)
        Me.categoFormLabel.TabIndex = 26
        Me.categoFormLabel.Text = "Catégorie de la formation :"
        '
        'dateDebFormLabel
        '
        Me.dateDebFormLabel.AutoSize = True
        Me.dateDebFormLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDebFormLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dateDebFormLabel.Location = New System.Drawing.Point(243, 81)
        Me.dateDebFormLabel.Name = "dateDebFormLabel"
        Me.dateDebFormLabel.Size = New System.Drawing.Size(262, 16)
        Me.dateDebFormLabel.TabIndex = 24
        Me.dateDebFormLabel.Text = "Date de début de la formation (jj/mm/aaaa) :"
        '
        'anneeFormNumericUpDown
        '
        Me.anneeFormNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anneeFormNumericUpDown.Location = New System.Drawing.Point(151, 79)
        Me.anneeFormNumericUpDown.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.anneeFormNumericUpDown.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.anneeFormNumericUpDown.Name = "anneeFormNumericUpDown"
        Me.anneeFormNumericUpDown.Size = New System.Drawing.Size(69, 22)
        Me.anneeFormNumericUpDown.TabIndex = 20
        Me.anneeFormNumericUpDown.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'anneeFormLabel
        '
        Me.anneeFormLabel.AutoSize = True
        Me.anneeFormLabel.BackColor = System.Drawing.Color.Transparent
        Me.anneeFormLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anneeFormLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.anneeFormLabel.Location = New System.Drawing.Point(10, 81)
        Me.anneeFormLabel.Name = "anneeFormLabel"
        Me.anneeFormLabel.Size = New System.Drawing.Size(142, 16)
        Me.anneeFormLabel.TabIndex = 19
        Me.anneeFormLabel.Text = "Année de la formation :"
        '
        'modifFormationLabel
        '
        Me.modifFormationLabel.AutoSize = True
        Me.modifFormationLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifFormationLabel.ForeColor = System.Drawing.Color.White
        Me.modifFormationLabel.Location = New System.Drawing.Point(9, 6)
        Me.modifFormationLabel.Name = "modifFormationLabel"
        Me.modifFormationLabel.Size = New System.Drawing.Size(275, 22)
        Me.modifFormationLabel.TabIndex = 3
        Me.modifFormationLabel.Text = "Modification d'une formation"
        '
        'modifFormExplicationLabel
        '
        Me.modifFormExplicationLabel.AutoSize = True
        Me.modifFormExplicationLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifFormExplicationLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.modifFormExplicationLabel.Location = New System.Drawing.Point(9, 40)
        Me.modifFormExplicationLabel.Name = "modifFormExplicationLabel"
        Me.modifFormExplicationLabel.Size = New System.Drawing.Size(326, 19)
        Me.modifFormExplicationLabel.TabIndex = 2
        Me.modifFormExplicationLabel.Text = "Veuillez sélectionner une formation à modifier."
        '
        'formationDataGridView
        '
        Me.formationDataGridView.AllowUserToAddRows = False
        Me.formationDataGridView.AllowUserToDeleteRows = False
        Me.formationDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.formationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.formationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formationDataGridView.Location = New System.Drawing.Point(3, 160)
        Me.formationDataGridView.MultiSelect = False
        Me.formationDataGridView.Name = "formationDataGridView"
        Me.formationDataGridView.Size = New System.Drawing.Size(978, 342)
        Me.formationDataGridView.TabIndex = 4
        '
        'modifFormForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.modifFormTableLayoutPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modifFormForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choix de la formation à modifier"
        Me.modifFormTableLayoutPanel.ResumeLayout(False)
        Me.formulaireValiderPanel.ResumeLayout(False)
        Me.formulaireValiderPanel.PerformLayout()
        Me.titreModifFormPanel.ResumeLayout(False)
        Me.titreModifFormPanel.PerformLayout()
        CType(Me.anneeFormNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.formationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents modifFormTableLayoutPanel As TableLayoutPanel
    Friend WithEvents formulaireValiderPanel As Panel
    Friend WithEvents annulerModifFormButton As Button
    Friend WithEvents modifierFormModifButton As Button
    Friend WithEvents titreModifFormPanel As Panel
    Friend WithEvents modifFormationLabel As Label
    Friend WithEvents modifFormExplicationLabel As Label
    Friend WithEvents formationDataGridView As DataGridView
    Friend WithEvents anneeFormLabel As Label
    Friend WithEvents anneeFormNumericUpDown As NumericUpDown
    Friend WithEvents dateDebFormLabel As Label
    Friend WithEvents filtrerButton As Button
    Friend WithEvents categoFormComboBox As ComboBox
    Friend WithEvents categoFormLabel As Label
    Friend WithEvents dateDebComboBox As ComboBox
    Friend WithEvents supprimerFormButton As Button
End Class
