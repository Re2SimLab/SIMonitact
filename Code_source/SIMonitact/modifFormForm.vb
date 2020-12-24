Public Class modifFormForm
    ' -------------------------------------------- VARIABLES -------------------------------------------- '
    ' Lecture des tables de la BDD
    ' Formation 
    Public Shared strFormation As String = "SELECT * FROM Formation"
    Public Shared dtFormation As New DataTable
    Public Shared daFormation As New OleDbDataAdapter(strFormation, accueilForm.myConnection)



    ' --------------------------------------- FONCTIONS GESTION APP --------------------------------------- '
    ' Ouverture de la form modif formation et initialisation des controls
    Private Sub modifFormForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Chargement des données 
        daFormation.Fill(dtFormation)

        ' Année de la formation
        anneeFormNumericUpDown.Value = System.DateTime.Today.Year

        ' Date debut de la formation
        Dim rows() As DataRow = dtFormation.Select("", "date_debut ASC")
        Dim tmp As New List(Of String)
        For i As Integer = 0 To rows.Length - 1
            tmp.Add(rows(i).Item("date_debut"))
        Next
        dateDebComboBox.Items.AddRange(tmp.Distinct.ToArray)

        ' Catégories de la formation
        categoFormComboBox.Items.AddRange((From row As DataRow In dtFormation.Rows Select row("categorie")).Distinct.ToArray)
        categoFormComboBox.Sorted = True

        ' Data grid view
        formationDataGridView.AutoGenerateColumns = False
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "ID_formation", .DataPropertyName = "ID_formation", .Width = 72})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "annee", .DataPropertyName = "annee", .Width = 50})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "date_debut", .DataPropertyName = "date_debut", .Width = 70})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "nb_DJ", .DataPropertyName = "nb_DJ", .Width = 42})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "categorie", .DataPropertyName = "categorie", .Width = 120})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "intitule", .DataPropertyName = "intitule", .Width = 210})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "structure_organisatrice", .DataPropertyName = "structure_organisatrice", .Width = 130})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "responsable_nom", .DataPropertyName = "responsable_nom", .Width = 110})
        formationDataGridView.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "responsable_prenom", .DataPropertyName = "responsable_prenom", .Width = 114})
        formationDataGridView.DataSource = dtFormation
    End Sub

    ' Fermeture de la forme accueil
    Private Sub modifFormForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If formulaireForm.modifForm = False Then
            accueilForm.Show()
        End If
    End Sub

    ' Clique sur le boutton annuler
    Private Sub annulerModifFormButton_Click(sender As Object, e As EventArgs) Handles annulerModifFormButton.Click
        accueilForm.Show()
        Me.Close()
    End Sub

    ' Active le scroll du datagridview
    Private Sub formationDataGridView_MouseEnter(sender As Object, e As EventArgs) Handles formationDataGridView.MouseEnter
        ' Active le scroll 
        formationDataGridView.Select()
    End Sub




    ' ----------------------------- FONCTIONS FILTRAGE ET SELECTION FORMATION ----------------------------- '
    ' Filtre le datagridview
    Private Sub filtrerButton_Click(sender As Object, e As EventArgs) Handles filtrerButton.Click
        Dim bs As New BindingSource
        bs.DataSource = dtFormation
        bs.RemoveFilter()

        ' Filtre annee
        bs.Filter = "annee = " & anneeFormNumericUpDown.Value
        ' Filtre date debut
        If dateDebComboBox.Text <> "" Then
            bs.Filter = bs.Filter.ToString & " AND date_debut = '" & dateDebComboBox.Text & "'"
        End If
        ' Filtre categorie
        If categoFormComboBox.Text <> "" Then
            bs.Filter = bs.Filter.ToString & " AND categorie = '" & categoFormComboBox.Text & "'"
        End If
        ' MaJ datagridview
        formationDataGridView.DataSource = bs
    End Sub

    ' Sélectionne la formation à modifier et ouvre la form formulaire en mode modification (formulaireForm.modifForm = True)
    Private Sub modifierFormModifButton_Click(sender As Object, e As EventArgs) Handles modifierFormModifButton.Click
        If IsNothing(formationDataGridView.CurrentRow) Then
            MsgBox("Veuillez sélectionner une formation pour la modifier.")
            Exit Sub
        Else
            formulaireForm.modifForm = True
            formulaireForm.IDModifForm = CInt(formationDataGridView.CurrentRow.DataBoundItem("ID_formation"))
            formulaireForm.Show()
            Me.Close()
        End If
    End Sub

    ' Sélectionne la formation à supprimer et la supprime
    Private Sub supprimerFormButton_Click(sender As Object, e As EventArgs) Handles supprimerFormButton.Click
        If IsNothing(formationDataGridView.CurrentRow) Then
            MsgBox("Veuillez sélectionner une formation pour la supprimer.")
            Exit Sub
        Else
            Dim formSupprID As Integer = CInt(formationDataGridView.CurrentRow.DataBoundItem("ID_formation"))
            accueilForm.supprFormationAllBDD(formSupprID)
            MsgBox("La formation " & formSupprID & " a été supprimée.")

            Application.Restart()
            Me.Close()
        End If
    End Sub
End Class