Public Class formulaireForm

    ' -------------------------------------------- VARIABLES -------------------------------------------- '
    ' Variables nécessaires au fonctionnement
    Public Shared nbDemiJour As Decimal = 1
    Public nbFormateurDisplay As Decimal = 0
    Public nbAideFormDisplay As Decimal = 0
    Public nbParDisplay As Decimal = 0
    Public Shared newFormation As New accueilForm.Formation
    Public Shared listeDJ As New List(Of accueilForm.DJ)
    Public Shared listeFormateur As New List(Of accueilForm.Formateur)
    Public Shared listeAideFormateur As New List(Of accueilForm.Aide_formateur)
    Public Shared listeParticipant As New List(Of accueilForm.Participant)

    ' Variable modification d'une formation
    Public Shadows modifForm As Boolean = False
    Public Shared IDModifForm As Integer

    ' Lecture des tables de la BDD
    ' Formation 
    Public Shared strFormation As String = "SELECT * FROM Formation"
    Public Shared dtFormation As New DataTable
    Public Shared daFormation As New OleDbDataAdapter(strFormation, accueilForm.myConnection)
    ' DJ
    Public Shared strDJ As String = "SELECT * FROM DJ"
    Public Shared dtDJ As New DataTable
    Public Shared daDJ As New OleDbDataAdapter(strDJ, accueilForm.myConnection)
    ' Formateur
    Public Shared strFormateur As String = "SELECT * FROM Formateur"
    Public Shared dtFormateur As New DataTable
    Public Shared daFormateur As New OleDbDataAdapter(strFormateur, accueilForm.myConnection)
    ' AideFormateur
    Public Shared strAideFormateur As String = "SELECT * FROM AideFormateur"
    Public Shared dtAideFormateur As New DataTable
    Public Shared daAideFormateur As New OleDbDataAdapter(strAideFormateur, accueilForm.myConnection)
    ' Participant
    Public Shared strParticipant As String = "SELECT * FROM Participant"
    Public Shared dtParticipant As New DataTable
    Public Shared daParticipant As New OleDbDataAdapter(strParticipant, accueilForm.myConnection)




    ' --------------------------------------- FONCTIONS GESTION APP --------------------------------------- '
    ' Ouverture de la forme Formulaire
    Private Sub formulaireForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Chargement des données 
        daFormation.Fill(dtFormation)
        daDJ.Fill(dtDJ)
        daFormateur.Fill(dtFormateur)
        daAideFormateur.Fill(dtAideFormateur)
        daParticipant.Fill(dtParticipant)

        ' ---- Onglet Formation ---- '
        ' Année de la formation
        anneeFormNumericUpDown.Value = System.DateTime.Today.Year
        ' Catégories de la formation
        categoFormComboBox.Items.AddRange((From row As DataRow In dtFormation.Rows Select row("categorie")).Distinct.ToArray)
        categoFormComboBox.Sorted = True
        ' Intitulé de la formation
        titreFormTextBox.Text = ""
        ' Structure organisatrice de la formation
        structureComboBox.Items.AddRange((From row As DataRow In dtFormation.Rows Select row("structure_organisatrice")).Distinct.ToArray)
        structureComboBox.Sorted = True
        ' Nom responsable pédagogique de la formation
        respPedNomComboBox.Items.AddRange((From row As DataRow In dtFormation.Rows Select row("responsable_nom")).Distinct.ToArray)
        respPedNomComboBox.Sorted = True
        ' Prénom responsable pédagogique de la formation
        respPedPrenomComboBox.Items.AddRange((From row As DataRow In dtFormation.Rows Select row("responsable_prenom")).Distinct.ToArray)
        respPedPrenomComboBox.Sorted = True
        ' Lieu de la formation
        lieuFormComboBox.Items.AddRange((From row As DataRow In dtFormation.Rows Select row("lieu")).Distinct.ToArray)
        lieuFormComboBox.Sorted = True
        ' Date de la premiere demi-journee de formation
        dateDJ1DateTimePicker.Value = System.DateTime.Today.ToShortDateString
        'Nb de formateurs 
        nbFormNumericUpDown.Value = 1
        'Nb d'aide formateur 
        nbAideFormNumericUpDown.Value = 0
        'Nb de participants 
        nbParticipantNumericUpDown.Value = 1

        ' ---- Onglet Formateur ---- '
        ' Nom des formateurs
        nomFormateurComboBox.Items.AddRange((From row As DataRow In dtFormateur.Rows Select row("nom")).Distinct.ToArray)
        nomFormateurComboBox.Sorted = True
        ' Prénom des formateurs
        prenomFormateurComboBox.Items.AddRange((From row As DataRow In dtFormateur.Rows Select row("prenom")).Distinct.ToArray)
        prenomFormateurComboBox.Sorted = True
        ' Profession des formateurs
        profFormateurComboBox.Items.AddRange((From row As DataRow In dtFormateur.Rows Select row("profession")).Distinct.ToArray)
        profFormateurComboBox.Sorted = True
        ' Service des formateurs
        serviceFormateurComboBox.Items.AddRange((From row As DataRow In dtFormateur.Rows Select row("service")).Distinct.ToArray)
        serviceFormateurComboBox.Sorted = True
        ' Lieu profession des formateurs
        lieuProfFormateurComboBox.Items.AddRange((From row As DataRow In dtFormateur.Rows Select row("lieu_profession")).Distinct.ToArray)
        lieuProfFormateurComboBox.Sorted = True
        ' Mail des formateurs
        mailFormateurTextBox.Text = ""
        ' Num adeli des formateurs
        numADELIFormateurTextBox.Text = "NA"
        ' Droit images des formateurs
        droitImageFormateurCheckBox.Checked = False

        ' ---- Onglet Aide Formateur ---- '
        ' Nom des aide-formateurs
        nomAideFormComboBox.Items.AddRange((From row As DataRow In dtAideFormateur.Rows Select row("nom")).Distinct.ToArray)
        nomAideFormComboBox.Sorted = True
        ' Prénom des aide-formateurs
        prenomAideFormComboBox.Items.AddRange((From row As DataRow In dtAideFormateur.Rows Select row("prenom")).Distinct.ToArray)
        prenomAideFormComboBox.Sorted = True
        ' Profession des aide-formateurs
        profAideFormComboBox.Items.AddRange((From row As DataRow In dtAideFormateur.Rows Select row("profession")).Distinct.ToArray)
        profAideFormComboBox.Sorted = True
        ' Service des aide-formateurs
        serviceAideFormComboBox.Items.AddRange((From row As DataRow In dtAideFormateur.Rows Select row("service")).Distinct.ToArray)
        serviceAideFormComboBox.Sorted = True
        ' Lieu profession des aide-formateurs
        lieuProfAideFormComboBox.Items.AddRange((From row As DataRow In dtAideFormateur.Rows Select row("lieu_profession")).Distinct.ToArray)
        lieuProfAideFormComboBox.Sorted = True
        ' Mail des aide-formateurs
        mailAideFormTextBox.Text = ""
        ' Num adeli des aide-formateurs
        numADELIAideFormTextBox.Text = "NA"
        ' Droit images des aide-formateurs
        droitImageAideFormCheckBox.Checked = False

        ' ---- Onglet Participant ---- '
        ' Nom des participants
        nomParComboBox.Items.AddRange((From row As DataRow In dtParticipant.Rows Select row("nom")).Distinct.ToArray)
        nomParComboBox.Sorted = True
        ' Prénom des participants
        prenomParComboBox.Items.AddRange((From row As DataRow In dtParticipant.Rows Select row("prenom")).Distinct.ToArray)
        prenomParComboBox.Sorted = True
        ' Profession des participants
        profParComboBox.Items.AddRange((From row As DataRow In dtParticipant.Rows Select row("profession")).Distinct.ToArray)
        profParComboBox.Sorted = True
        ' Service des participants
        serviceParComboBox.Items.AddRange((From row As DataRow In dtParticipant.Rows Select row("service")).Distinct.ToArray)
        serviceParComboBox.Sorted = True
        ' Lieu profession des participants
        lieuProfParComboBox.Items.AddRange((From row As DataRow In dtParticipant.Rows Select row("lieu_profession")).Distinct.ToArray)
        lieuProfParComboBox.Sorted = True
        ' Mail des participants
        mailParTextBox.Text = ""
        ' Num adeli des participants
        numADELIParTextBox.Text = "NA"
        ' Droit images des participants
        droitImageParCheckBox.Checked = False

        ' ---- Onglet Recette et frais ---- '
        recetteTextBox.Text = "0"
        fraisTextBox.Text = "0"

        ' Si la form est ouverte en mode modification d'une formation, lancer la sub de remplissage automatique du formulaire (voir fonctions supplémentaires)
        If modifForm Then
            loadModifForm(IDModifForm)
        End If
    End Sub

    ' Fermeture de la form
    Private Sub formulaireForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' Ferme ré-ouvre l'accueil
        Application.Restart() ' Relance l'appli pour prendre en compte les modifs faites à la BDD
        accueilForm.Show()
    End Sub

    Private Sub annulerFormulaireButton_Click(sender As Object, e As EventArgs) Handles annulerFormulaireButton.Click
        ' Ferme la form du formulaire et affiche la form de l'accueil
        Me.Close() ' Appel la sub de fermeture de l'app
    End Sub

    Private Sub dateDJPanel_MouseEnter(sender As Object, e As System.EventArgs) Handles dateDJPanel.MouseEnter
        ' Active le scroll de la souris quand la souris est sur le panel du choix des dates des DJ
        dateDJPanel.Select()
    End Sub

    Private Sub nbDemiJourNumericUpDown_MouseWheel(sender As Object, e As MouseEventArgs) Handles nbDemiJourNumericUpDown.MouseWheel
        ' Désactive le scroll pour le choix du nombre de demi-journées
        Dim MW As HandledMouseEventArgs = CType(e, HandledMouseEventArgs)
        MW.Handled = True
    End Sub

    Private Sub formateurFlowLayoutPanel_MouseEnter(sender As Object, e As EventArgs) Handles formateurFlowLayoutPanel.MouseEnter
        ' Active le scroll 
        formateurFlowLayoutPanel.Select()
    End Sub

    Private Sub aideformateurFlowLayoutPanel_MouseEnter(sender As Object, e As EventArgs) Handles AideFormFlowLayoutPanel.MouseEnter
        ' Active le scroll 
        AideFormFlowLayoutPanel.Select()
    End Sub

    Private Sub participantFlowLayoutPanel_MouseEnter(sender As Object, e As EventArgs) Handles participantFlowLayoutPanel.MouseEnter
        ' Active le scroll 
        participantFlowLayoutPanel.Select()
    End Sub




    ' ----------------------------- FONCTIONS GESTION REMPLISSAGE FORMULAIRE ----------------------------- '

    ' ---- ONGLET FORMATION ---- '
    ' Gestion du choix de l'année de formation
    Private Sub anneeFormNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles anneeFormNumericUpDown.ValueChanged
        ' Sauvegarde l'année de formation choisie
        dateDJ1DateTimePicker.Value = Date.ParseExact("01/01/" + anneeFormNumericUpDown.Value.ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
    End Sub

    ' Gestion du nom du responsable pédago de formation et changement des prénoms possibles (en fonction des données de la BDD)
    Private Sub respPedNomComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles respPedNomComboBox.SelectedIndexChanged
        If (From row As DataRow In dtFormation.Rows Select row("responsable_nom")).Distinct.ToList.Contains(respPedNomComboBox.SelectedItem) Then
            Dim rows() As DataRow = dtFormation.Select("responsable_nom = '" & respPedNomComboBox.SelectedItem & "'")
            Dim tmp As New List(Of String)
            For i As Integer = 0 To rows.Length - 1
                tmp.Add(rows(i).Item("responsable_prenom"))
            Next
            respPedPrenomComboBox.Items.Clear()
            respPedPrenomComboBox.Items.AddRange(tmp.Distinct.ToArray)
            respPedPrenomComboBox.Sorted = True
            respPedPrenomComboBox.Text = respPedPrenomComboBox.Items(0).ToString
        End If
    End Sub

    ' Gestion du nombre de demi-journées et ajout/suppression des choix de date
    Private Sub nbDemiJourNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles nbDemiJourNumericUpDown.ValueChanged
        ' Si le nb de demi-journées de formation diminue, il faut supprimer des choix de date des demi-journées 
        ' Si le nb de demi-journées de formation augmente, il faut rajouter des choix de date des demi-journées 
        If nbDemiJourNumericUpDown.Value < nbDemiJour Then
            ' Récupère le Label à supprimer et le supprime
            Dim lbl = Me.Controls.Find("dateDJ" & nbDemiJour & "Label", True).FirstOrDefault()
            If lbl IsNot Nothing Then
                lbl.Dispose()
            End If
            ' Récupère le DateTimePicker à supprimer et le supprime
            Dim dtp = Me.Controls.Find("dateDJ" & nbDemiJour & "DateTimePicker", True).FirstOrDefault()
            If dtp IsNot Nothing Then
                dtp.Dispose()
            End If
            ' Récupère le comboBox à supprimer et le supprime
            Dim cbb = Me.Controls.Find("ampm" & nbDemiJour & "ComboBox", True).FirstOrDefault()
            If cbb IsNot Nothing Then
                cbb.Dispose()
            End If

        ElseIf nbDemiJourNumericUpDown.Value > nbDemiJour Then
            ' Crée un nouveau Label et défini ses propriétés
            Dim lbl As Label = New Label
            lbl.Name = "dateDJ" & nbDemiJourNumericUpDown.Value.ToString & "Label"
            lbl.Width = 135
            lbl.Height = 16
            lbl.Text = "Date demi-journée " + nbDemiJourNumericUpDown.Value.ToString() + " :"
            lbl.ForeColor = Color.DarkSlateGray
            lbl.Font = New Font("Arial", 9.75)
            lbl.Left = 7
            lbl.Top = 18 + nbDemiJour * 30
            lbl.Visible = True
            dateDJPanel.Controls.Add(lbl) ' ajoute le Label
            ' Crée un nouveau DateTimePicker et défini ses propriétés
            Dim dtp As DateTimePicker = New DateTimePicker
            Dim dtpPrev = Me.Controls.Find("dateDJ" & nbDemiJour & "DateTimePicker", True).FirstOrDefault()
            Dim curDate As Date = Date.ParseExact(dtpPrev.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            dtp.Name = "dateDJ" & nbDemiJourNumericUpDown.Value & "DateTimePicker"
            dtp.Format = DateTimePickerFormat.Short
            dtp.MinDate = New DateTime(2010, 1, 1)
            dtp.MaxDate = New DateTime(2100, 12, 31)
            dtp.Left = 188
            dtp.Top = 13 + nbDemiJour * 30
            dtp.Width = 119
            dtp.Height = 22
            dtp.Visible = True
            dtp.Value = curDate
            If nbDemiJourNumericUpDown.Value Mod 2 > 0 Then ' Augmente la date du DateTimePicker toutes les 2 demi-journées
                dtp.Value = dtp.Value.AddDays(1)
            End If
            dateDJPanel.Controls.Add(dtp) ' ajoute le DateTimePicker
            ' Crée un nouveau combobox et défini ses propriétés
            Dim cbb As ComboBox = New ComboBox
            cbb.Name = "ampm" & nbDemiJourNumericUpDown.Value.ToString & "ComboBox"
            cbb.Width = 119
            cbb.Height = 24
            cbb.Items.Add("AM")
            cbb.Items.Add("PM")
            cbb.Items.Add("Nuit")
            cbb.DropDownStyle = ComboBoxStyle.DropDownList
            cbb.Left = 331
            cbb.Top = 11 + nbDemiJour * 30
            cbb.Visible = True
            dateDJPanel.Controls.Add(cbb) ' ajoute le ComboBox
        End If

        ' Mise à jour du nb de demi-journées de la formation
        nbDemiJour = nbDemiJourNumericUpDown.Value
    End Sub

    ' Gestion du choix de date de la 1ère DJ (demi-journée)
    Private Sub dateDJ1DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles dateDJ1DateTimePicker.ValueChanged
        ' Sauvegarde de la date de la 1ère DJ
        Dim nbDJ As Integer = 1
        Dim dtp As DateTimePicker
        ' Mise à jour des dates des autres DJ si existantes
        If nbDemiJour > 1 Then
            For i As Integer = 2 To nbDemiJour
                dtp = Me.Controls.Find("dateDJ" & i & "DateTimePicker", True).FirstOrDefault()
                dtp.Value = Format(dateDJ1DateTimePicker.Value.AddDays(Math.Truncate(nbDJ / 2)), "dd/MM/yyyy")
                If dtp.Value.DayOfWeek = DayOfWeek.Saturday Then
                    dtp.Value = Format(dateDJ1DateTimePicker.Value.AddDays(Math.Truncate(nbDJ / 2) + 2), "dd/MM/yyyy")
                    nbDJ = nbDJ + 4
                End If
                nbDJ += 1
            Next
        End If
    End Sub



    ' ---- ONGLET FORMATEUR ---- '
    ' Gestion du choix du nom du formateur et màj des prénoms possibles
    Private Sub nomFormateurComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nomFormateurComboBox.SelectedIndexChanged
        If (From row As DataRow In dtFormateur.Rows Select row("nom")).Distinct.ToList.Contains(nomFormateurComboBox.SelectedItem) Then
            Dim rows() As DataRow = dtFormateur.Select("nom = '" & nomFormateurComboBox.SelectedItem & "'")
            Dim tmp As New List(Of String)
            For i As Integer = 0 To rows.Length - 1
                tmp.Add(rows(i).Item("prenom"))
            Next
            prenomFormateurComboBox.Items.Clear()
            prenomFormateurComboBox.Items.AddRange(tmp.Distinct.ToArray)
            prenomFormateurComboBox.Sorted = True
            prenomFormateurComboBox.Text = prenomFormateurComboBox.Items(0).ToString
        End If
    End Sub

    ' Gestion du choix du prenom du formateur et màj des infos formateurs s'il existe déjà dans la BDD
    Private Sub prenomFormateurComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prenomFormateurComboBox.SelectedIndexChanged
        Dim rows() As DataRow = dtFormateur.Select("nom = '" & nomFormateurComboBox.SelectedItem & "' and prenom = '" & prenomFormateurComboBox.SelectedItem & "'")
        If rows.Length > 0 Then
            IDFormateurTextBox.Enabled = True
            IDFormateurTextBox.Text = rows(0).Item("ID_formateur").ToString
            profFormateurComboBox.Text = rows(0).Item("profession").ToString
            serviceFormateurComboBox.Text = rows(0).Item("service").ToString
            lieuProfFormateurComboBox.Text = rows(0).Item("lieu_profession").ToString
            mailFormateurTextBox.Text = rows(0).Item("mail").ToString
            numADELIFormateurTextBox.Text = rows(0).Item("num_ADELI_matricule").ToString
            If rows(0).Item("droit_image").ToString = "Oui" Then
                droitImageFormateurCheckBox.Checked = True
            Else
                droitImageFormateurCheckBox.Checked = False
            End If
            If rows(0).Item("formateur_certifie").ToString = "Oui" Then
                formateurCertifieCheckBox.Checked = True
            Else
                formateurCertifieCheckBox.Checked = False
            End If
        End If
    End Sub

    ' Sub qui ajoute un formateur (infos formateurs + boutons modif et suppr) dans le panel qui liste les formateurs
    Private Sub ajouterFormateurButton_Click(sender As Object, e As EventArgs) Handles ajouterFormateurButton.Click
        ' Vérifie que toutes les cases soient remplies
        If nomFormateurComboBox.Text = "" Or prenomFormateurComboBox.Text = "" Or profFormateurComboBox.Text = "" Or serviceFormateurComboBox.Text = "" Or lieuProfFormateurComboBox.Text = "" Or mailFormateurTextBox.Text = "" Or numADELIFormateurTextBox.Text = "" Then
            MsgBox("Veuillez remplir toutes les cases (mettre 'NA' si information non connue) pour ajouter un formateur.")
            Exit Sub
        End If

        ' MàJ paramètres 
        nbFormateurDisplay += 1
        Dim droitImage As String = "Non"
        If droitImageFormateurCheckBox.Checked Then
            droitImage = "Oui"
        End If
        Dim formateurCertifie As String = "Non"
        If formateurCertifieCheckBox.Checked Then
            formateurCertifie = "Oui"
        End If

        ' Crée un nouveau Label et défini ses propriétés
        Dim lbl As Label = New Label
        lbl.Name = "Formateur_" & nbFormateurDisplay.ToString & "_Label"
        lbl.AutoSize = False
        lbl.TextAlign = ContentAlignment.MiddleLeft
        lbl.Width = 805
        lbl.Height = 30
        lbl.Text = nbFormateurDisplay.ToString + " | " + IDFormateurTextBox.Text.ToString + " | " + nomFormateurComboBox.Text.ToUpper.Replace("'", " ") + " | " + prenomFormateurComboBox.Text.Replace("'", " ") + " | " + profFormateurComboBox.Text + " | " + serviceFormateurComboBox.Text.Replace("'", " ") + " | " + lieuProfFormateurComboBox.Text.Replace("'", " ") + " | " + mailFormateurTextBox.Text.Replace("'", " ") + " | " + numADELIFormateurTextBox.Text.Replace("'", " ") + " | " + droitImage + " | " + formateurCertifie
        lbl.ForeColor = Color.Black
        lbl.Font = New Font("Arial", 9.75)
        lbl.Visible = True
        lbl.AutoEllipsis = True
        formateurFlowLayoutPanel.Controls.Add(lbl) ' ajoute le Label

        ' Crée un nouveau bouton Modif et défini ses propriétés
        Dim bt2 As Button = New Button
        bt2.Name = "Modif_Formateur_" & nbFormateurDisplay.ToString & "_Button"
        bt2.Text = "Modif." ' "-"
        bt2.ForeColor = Color.DarkSlateGray
        bt2.Font = New Font("Microsoft Sans Serif", 8.75)
        bt2.FlatStyle = FlatStyle.Flat
        bt2.BackColor = Color.White
        bt2.TextAlign = ContentAlignment.TopCenter
        bt2.Width = 55
        bt2.Height = 25
        Dim old2 As Padding = bt2.Margin
        bt2.Margin = New Padding(10, old2.Top, old2.Right, old2.Bottom)
        bt2.Visible = True
        AddHandler bt2.Click, AddressOf Me.ModifButton_Click
        formateurFlowLayoutPanel.Controls.Add(bt2) ' ajoute le Bouton

        ' Crée un nouveau bouton Suppr et défini ses propriétés
        Dim bt As Button = New Button
        bt.Name = "Suppr_Formateur_" & nbFormateurDisplay.ToString & "_Button"
        bt.Text = "Suppr." ' "-"
        bt.ForeColor = Color.DarkSlateGray
        bt.Font = New Font("Microsoft Sans Serif", 8.75)
        bt.FlatStyle = FlatStyle.Flat
        bt.BackColor = Color.White
        bt.TextAlign = ContentAlignment.TopCenter
        bt.Width = 55
        bt.Height = 25
        Dim old As Padding = bt.Margin
        bt.Margin = New Padding(10, old.Top, old.Right, old.Bottom)
        bt.Visible = True
        AddHandler bt.Click, AddressOf Me.SupprButton_Click
        formateurFlowLayoutPanel.Controls.Add(bt) ' ajoute le Bouton

        ' Remet les cases à NULL
        IDFormateurTextBox.Text = ""
        IDFormateurTextBox.Enabled = False
        nomFormateurComboBox.Text = ""
        prenomFormateurComboBox.Text = ""
        profFormateurComboBox.Text = ""
        serviceFormateurComboBox.Text = ""
        lieuProfFormateurComboBox.Text = ""
        mailFormateurTextBox.Text = ""
        numADELIFormateurTextBox.Text = "NA"
        droitImageFormateurCheckBox.Checked = False
        formateurCertifieCheckBox.Checked = False
    End Sub


    ' ---- ONGLET AIDE - FORMATEUR ---- '
    ' Gestion du choix du nom des aide-formateurs et màj des prénoms possibles
    Private Sub nomAideFormComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nomAideFormComboBox.SelectedIndexChanged
        If (From row As DataRow In dtAideFormateur.Rows Select row("nom")).Distinct.ToList.Contains(nomAideFormComboBox.SelectedItem) Then
            Dim rows() As DataRow = dtAideFormateur.Select("nom = '" & nomAideFormComboBox.SelectedItem & "'")
            Dim tmp As New List(Of String)
            For i As Integer = 0 To rows.Length - 1
                tmp.Add(rows(i).Item("prenom"))
            Next
            prenomAideFormComboBox.Items.Clear()
            prenomAideFormComboBox.Items.AddRange(tmp.Distinct.ToArray)
            prenomAideFormComboBox.Sorted = True
            prenomAideFormComboBox.Text = prenomAideFormComboBox.Items(0).ToString
        End If
    End Sub

    ' Gestion du choix du prenom des aide-formateurs et màj des infos aide-formateur s'il existe déjà dans la BDD
    Private Sub prenomAideFormComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prenomAideFormComboBox.SelectedIndexChanged
        Dim rows() As DataRow = dtAideFormateur.Select("nom = '" & nomAideFormComboBox.SelectedItem & "' and prenom = '" & prenomAideFormComboBox.SelectedItem & "'")
        If rows.Length > 0 Then
            IDAideFormTextBox.Enabled = True
            IDAideFormTextBox.Text = rows(0).Item("ID_aide_formateur").ToString
            profAideFormComboBox.Text = rows(0).Item("profession").ToString
            serviceAideFormComboBox.Text = rows(0).Item("service").ToString
            lieuProfAideFormComboBox.Text = rows(0).Item("lieu_profession").ToString
            mailAideFormTextBox.Text = rows(0).Item("mail").ToString
            numADELIAideFormTextBox.Text = rows(0).Item("num_ADELI_matricule").ToString
            If rows(0).Item("droit_image").ToString = "Oui" Then
                droitImageAideFormCheckBox.Checked = True
            Else
                droitImageAideFormCheckBox.Checked = False
            End If
        End If
    End Sub

    '  Sub qui ajoute un aide-formateur (infos aide-formateur + boutons modif et suppr) dans le panel qui liste les aide-formateurs
    Private Sub ajouterAideFormButton_Click(sender As Object, e As EventArgs) Handles ajouterAideFormButton.Click
        ' Vérifie que toutes les cases soient remplies
        If nomAideFormComboBox.Text = "" Or prenomAideFormComboBox.Text = "" Or profAideFormComboBox.Text = "" Or serviceAideFormComboBox.Text = "" Or lieuProfAideFormComboBox.Text = "" Or mailAideFormTextBox.Text = "" Or numADELIAideFormTextBox.Text = "" Then
            MsgBox("Veuillez remplir toutes les cases (mettre 'NA' si information non connue) pour ajouter un aide-formateur.")
            Exit Sub
        End If

        ' MàJ paramètres 
        nbAideFormDisplay += 1
        Dim droitImage As String = "Non"
        If droitImageAideFormCheckBox.Checked Then
            droitImage = "Oui"
        End If

        ' Crée un nouveau Label et défini ses propriétés
        Dim lbl As Label = New Label
        lbl.Name = "AideForm_" & nbAideFormDisplay.ToString & "_Label"
        lbl.AutoSize = False
        lbl.TextAlign = ContentAlignment.MiddleLeft
        lbl.Width = 805
        lbl.Height = 30
        lbl.Text = nbAideFormDisplay.ToString + " | " + IDAideFormTextBox.Text + " | " + nomAideFormComboBox.Text.ToUpper.Replace("'", " ") + " | " + prenomAideFormComboBox.Text.Replace("'", " ") + " | " + profAideFormComboBox.Text.Replace("'", " ") + " | " + serviceAideFormComboBox.Text.Replace("'", " ") + " | " + lieuProfAideFormComboBox.Text.Replace("'", " ") + " | " + mailAideFormTextBox.Text.Replace("'", " ") + " | " + numADELIAideFormTextBox.Text.Replace("'", " ") + " | " + droitImage
        lbl.ForeColor = Color.Black
        lbl.Font = New Font("Arial", 9.75)
        lbl.Visible = True
        lbl.AutoEllipsis = True
        AideFormFlowLayoutPanel.Controls.Add(lbl) ' ajoute le Label

        ' Crée un nouveau bouton Modif et défini ses propriétés
        Dim bt2 As Button = New Button
        bt2.Name = "Modif_AideForm_" & nbAideFormDisplay.ToString & "_Button"
        bt2.Text = "Modif." ' "-"
        bt2.ForeColor = Color.DarkSlateGray
        bt2.Font = New Font("Microsoft Sans Serif", 8.75)
        bt2.FlatStyle = FlatStyle.Flat
        bt2.BackColor = Color.White
        bt2.TextAlign = ContentAlignment.TopCenter
        bt2.Width = 55
        bt2.Height = 25
        Dim old2 As Padding = bt2.Margin
        bt2.Margin = New Padding(10, old2.Top, old2.Right, old2.Bottom)
        bt2.Visible = True
        AddHandler bt2.Click, AddressOf Me.ModifButton_Click
        AideFormFlowLayoutPanel.Controls.Add(bt2) ' ajoute le Bouton

        ' Crée un nouveau bouton Suppr et défini ses propriétés
        Dim bt As Button = New Button
        bt.Name = "Suppr_AideForm_" & nbAideFormDisplay.ToString & "_Button"
        bt.Text = "Suppr." ' "-"
        bt.ForeColor = Color.DarkSlateGray
        bt.Font = New Font("Microsoft Sans Serif", 8.75)
        bt.FlatStyle = FlatStyle.Flat
        bt.BackColor = Color.White
        bt.TextAlign = ContentAlignment.TopCenter
        bt.Width = 55
        bt.Height = 25
        Dim old As Padding = bt.Margin
        bt.Margin = New Padding(10, old.Top, old.Right, old.Bottom)
        bt.Visible = True
        AddHandler bt.Click, AddressOf Me.SupprButton_Click
        AideFormFlowLayoutPanel.Controls.Add(bt) ' ajoute le Bouton

        ' Remet les cases à NULL
        IDAideFormTextBox.Text = ""
        IDAideFormTextBox.Enabled = False
        nomAideFormComboBox.Text = ""
        prenomAideFormComboBox.Text = ""
        profAideFormComboBox.Text = ""
        serviceAideFormComboBox.Text = ""
        lieuProfAideFormComboBox.Text = ""
        mailAideFormTextBox.Text = ""
        numADELIAideFormTextBox.Text = "NA"
        droitImageAideFormCheckBox.Checked = False

    End Sub



    ' ---- ONGLET PARTICIPANT ---- '
    ' Gestion du choix du nom du participant et màj des prénoms possibles
    Private Sub nomParComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nomParComboBox.SelectedIndexChanged
        If (From row As DataRow In dtParticipant.Rows Select row("nom")).Distinct.ToList.Contains(nomParComboBox.SelectedItem) Then
            Dim rows() As DataRow = dtParticipant.Select("nom = '" & nomParComboBox.SelectedItem & "'")
            Dim tmp As New List(Of String)
            For i As Integer = 0 To rows.Length - 1
                tmp.Add(rows(i).Item("prenom"))
            Next
            prenomParComboBox.Items.Clear()
            prenomParComboBox.Items.AddRange(tmp.Distinct.ToArray)
            prenomParComboBox.Sorted = True
            prenomParComboBox.Text = prenomParComboBox.Items(0).ToString
        End If
    End Sub

    ' Gestion du choix du prenom du participant et màj des infos du participant s'il existe déjà dans la BDD
    Private Sub prenomParComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prenomParComboBox.SelectedIndexChanged
        Dim rows() As DataRow = dtParticipant.Select("nom = '" & nomParComboBox.SelectedItem & "' and prenom = '" & prenomParComboBox.SelectedItem & "'")
        If rows.Length > 0 Then
            IDParTextBox.Enabled = True
            IDParTextBox.Text = rows(0).Item("ID_participant").ToString
            profParComboBox.Text = rows(0).Item("profession").ToString
            serviceParComboBox.Text = rows(0).Item("service").ToString
            lieuProfParComboBox.Text = rows(0).Item("lieu_profession").ToString
            mailParTextBox.Text = rows(0).Item("mail").ToString
            numADELIParTextBox.Text = rows(0).Item("num_ADELI_matricule").ToString
            If rows(0).Item("droit_image").ToString = "Oui" Then
                droitImageParCheckBox.Checked = True
            Else
                droitImageParCheckBox.Checked = False
            End If
        End If
    End Sub

    ' Sub qui ajoute un participant (infos participant + boutons modif et suppr) dans le panel qui liste les participants
    Public Sub ajouterParButton_Click(sender As Object, e As EventArgs) Handles ajouterParButton.Click
        ' Vérifie que toutes les cases soient remplies
        If nomParComboBox.Text = "" Or prenomParComboBox.Text = "" Or profParComboBox.Text = "" Or serviceParComboBox.Text = "" Or lieuProfParComboBox.Text = "" Or mailParTextBox.Text = "" Or numADELIParTextBox.Text = "" Then
            MsgBox("Veuillez remplir toutes les cases (mettre 'NA' si information non connue) pour ajouter un participant.")
            Exit Sub
        End If

        ' MàJ paramètres 
        nbParDisplay += 1
        Dim droitImage As String = "Non"
        If droitImageParCheckBox.Checked Then
            droitImage = "Oui"
        End If

        ' Crée un nouveau Label et défini ses propriétés
        Dim lbl As Label = New Label
        lbl.Name = "Par_" & nbParDisplay.ToString & "_Label"
        lbl.AutoSize = False
        lbl.TextAlign = ContentAlignment.MiddleLeft
        lbl.Width = 790
        lbl.Height = 30
        lbl.Text = nbParDisplay.ToString + " | " + IDParTextBox.Text + " | " + nomParComboBox.Text.ToUpper.Replace("'", " ") + " | " + prenomParComboBox.Text.Replace("'", " ") + " | " + profParComboBox.Text.Replace("'", " ") + " | " + serviceParComboBox.Text.Replace("'", " ") + " | " + lieuProfParComboBox.Text.Replace("'", " ") + " | " + mailParTextBox.Text.Replace("'", " ") + " | " + numADELIParTextBox.Text.Replace("'", " ") + " | " + droitImage
        lbl.ForeColor = Color.Black
        lbl.Font = New Font("Arial", 9.75)
        lbl.Visible = True
        lbl.AutoEllipsis = True
        participantFlowLayoutPanel.Controls.Add(lbl) ' ajoute le Label

        ' Crée un nouveau bouton Modif et défini ses propriétés
        Dim bt2 As Button = New Button
        bt2.Name = "Modif_Par_" & nbParDisplay.ToString & "_Button"
        bt2.Text = "Modif." ' "-"
        bt2.ForeColor = Color.DarkSlateGray
        bt2.Font = New Font("Microsoft Sans Serif", 8.75)
        bt2.FlatStyle = FlatStyle.Flat
        bt2.BackColor = Color.White
        bt2.TextAlign = ContentAlignment.TopCenter
        bt2.Width = 55
        bt2.Height = 25
        Dim old2 As Padding = bt2.Margin
        bt2.Margin = New Padding(10, old2.Top, old2.Right, old2.Bottom)
        bt2.Visible = True
        AddHandler bt2.Click, AddressOf Me.ModifButton_Click
        participantFlowLayoutPanel.Controls.Add(bt2) ' ajoute le Bouton

        ' Crée un nouveau bouton Suppr et défini ses propriétés
        Dim bt As Button = New Button
        bt.Name = "Suppr_Par_" & nbParDisplay.ToString & "_Button"
        bt.Text = "Suppr." ' "-"
        bt.ForeColor = Color.DarkSlateGray
        bt.Font = New Font("Microsoft Sans Serif", 8.75)
        bt.FlatStyle = FlatStyle.Flat
        bt.BackColor = Color.White
        bt.TextAlign = ContentAlignment.TopCenter
        bt.Width = 55
        bt.Height = 25
        Dim old As Padding = bt.Margin
        bt.Margin = New Padding(10, old.Top, old.Right, old.Bottom)
        bt.Visible = True
        AddHandler bt.Click, AddressOf Me.SupprButton_Click
        participantFlowLayoutPanel.Controls.Add(bt) ' ajoute le Bouton

        ' Remet les cases à NULL
        IDParTextBox.Text = ""
        IDParTextBox.Enabled = False
        nomParComboBox.Text = ""
        prenomParComboBox.Text = ""
        profParComboBox.Text = ""
        serviceParComboBox.Text = ""
        lieuProfParComboBox.Text = ""
        mailParTextBox.Text = ""
        numADELIParTextBox.Text = "NA"
        droitImageParCheckBox.Checked = False
    End Sub


    ' ---- ONGLET RECETTE ET FRAIS ---- '
    ' Vérifie que la valeur de recette saisi est correcte
    Private Sub recetteTextBox_Leave(sender As Object, e As EventArgs) Handles recetteTextBox.Leave
        Dim result As Double = 0.0
        If Double.TryParse(recetteTextBox.Text.Replace(".", ","), result) = False Then
            recetteTextBox.Text = "0"
            MsgBox("veuillez entrer un nombre valide.")
        End If

    End Sub

    ' Vérifie que la valeur des frais saisi est correcte
    Private Sub fraisTextBox_Leave(sender As Object, e As EventArgs) Handles fraisTextBox.Leave
        Dim result As Double = 0.0
        If Double.TryParse(fraisTextBox.Text.Replace(".", ","), result) = False Then
            fraisTextBox.Text = "0"
            MsgBox("veuillez entrer un nombre valide.")
        End If
    End Sub





    ' ----------------------------------- VALIDATION DU FORMULAIRE ----------------------------------- '
    Private Sub validerFormulaireButton_Click(sender As Object, e As EventArgs) Handles validerFormulaireButton.Click
        ' ---- VERIFICATIONS REMPLISSAGE ---- '
        ' Onglet Formation
        If anneeFormNumericUpDown.Text = "" Or categoFormComboBox.Text = "" Or titreFormTextBox.Text = "" Or structureComboBox.Text = "" Or respPedNomComboBox.Text = "" Or respPedPrenomComboBox.Text = "" Or formCSSOIComboBox.Text = "" Or lieuFormComboBox.Text = "" Or nbFormNumericUpDown.Text = "" Or nbAideFormNumericUpDown.Text = "" Or nbParticipantNumericUpDown.Text = "" Or nbDemiJourNumericUpDown.Text = "" Or dateDJ1DateTimePicker.Value.ToString() = "" Or ampm1ComboBox.Text = "" Then
            MsgBox("Veuillez vérifier les données saisies dans l'onglet Formation.", MsgBoxStyle.OkOnly, "Erreur")
            Exit Sub
        End If
        If nbFormNumericUpDown.Value + nbAideFormNumericUpDown.Value = 0 Then
            MsgBox("La formation doit comprendre au moins 1 formateur ou aide-formateur pour être valide.", MsgBoxStyle.OkOnly, "Erreur")
            Exit Sub
        End If
        For i As Integer = 1 To nbDemiJour
            Dim dtp As DateTimePicker = Me.Controls.Find("dateDJ" & i & "DateTimePicker", True).FirstOrDefault()
            Dim cbb As ComboBox = Me.Controls.Find("ampm" & i & "ComboBox", True).FirstOrDefault()
            If cbb.Text = "" Or dtp.Text = "" Then
                MsgBox("Veuillez vérifier que les matinées/après-midi/nuit (AM/PM/Nuit) soient bien définies pour chaque demi-journées.", MsgBoxStyle.OkOnly, "Erreur")
                Exit Sub
            End If
        Next
        ' Onglet Formateur
        If nbFormNumericUpDown.Value <> formateurFlowLayoutPanel.Controls.Count / 3 Then
            MsgBox("Le nombre de formateurs saisie dans l'onglet Formation est différent du nombre de formateurs renseigné dans l'onglet Formateurs.", MsgBoxStyle.OkOnly, "Erreur")
            Exit Sub
        End If
        ' Onglet Aide - Formateur
        If nbAideFormNumericUpDown.Value <> AideFormFlowLayoutPanel.Controls.Count / 3 Then
            MsgBox("Le nombre d'aide-formateurs saisie dans l'onglet Formation est différent du nombre d'aide-formateurs renseigné dans l'onglet Aide formateurs.", MsgBoxStyle.OkOnly, "Erreur")
            Exit Sub
        End If
        ' Onglet Participant
        If nbParticipantNumericUpDown.Value <> participantFlowLayoutPanel.Controls.Count / 3 Then
            MsgBox("Le nombre de participants saisie dans l'onglet Formation est différent du nombre de participants renseigné dans l'onglet Participants.", MsgBoxStyle.OkOnly, "Erreur")
            Exit Sub
        End If
        ' Onglet Recette et Frais
        If recetteTextBox.Text = "" Or fraisTextBox.Text = "" Or etatTitreComboBox.Text = "" Then
            MsgBox("Veuillez vérifier les données saisies dans l'onglet Recette et Frais.", MsgBoxStyle.OkOnly, "Erreur")
            Exit Sub
        End If


        ' ---- REMPLISSAGE VARIABLES ---- '
        ' Nettoyage des listes 
        listeDJ.Clear()
        listeFormateur.Clear()
        listeAideFormateur.Clear()
        listeParticipant.Clear()
        ' Formation 
        ' ID
        If modifForm Then
            newFormation.ID = IDModifForm
        Else
            Dim tmp As DataView = dtFormation.AsDataView
            tmp.RowFilter = "annee = " & anneeFormNumericUpDown.Value.ToString
            If tmp.Count = 0 Then
                newFormation.ID = CDbl(Val(anneeFormNumericUpDown.Value.ToString & "0001"))
            Else
                tmp.Sort = "ID_formation Desc"
                newFormation.ID = tmp(0)(0) + 1
            End If
        End If
        ' autre variables
        newFormation.annee = anneeFormNumericUpDown.Value
        newFormation.date_debut = dateDJ1DateTimePicker.Value.Date.ToString("MM/dd/yyyy")
        newFormation.nb_DJ = nbDemiJourNumericUpDown.Value
        newFormation.categorie = categoFormComboBox.Text.Replace("'", " ")
        newFormation.intitule = titreFormTextBox.Text.Replace("'", " ")
        newFormation.structure_organisatrice = structureComboBox.Text.Replace("'", " ")
        newFormation.responsable_nom = respPedNomComboBox.Text.ToUpper.Replace("'", " ")
        newFormation.responsable_prenom = respPedPrenomComboBox.Text.Replace("'", " ")
        newFormation.formation_centre = formCSSOIComboBox.Text
        newFormation.lieu = lieuFormComboBox.Text.Replace("'", " ")
        newFormation.nb_formateur = nbFormNumericUpDown.Value
        newFormation.nb_aide_formateur = nbAideFormNumericUpDown.Value
        newFormation.nb_participant = nbParticipantNumericUpDown.Value

        ' DJs
        Dim IDDJMax As Integer
        If dtDJ.Rows.Count = 0 Then
            IDDJMax = 1
        Else
            IDDJMax = dtDJ.Select("ID_DJ = MAX(ID_DJ)")(0).Item("ID_DJ") + 1
        End If
        Dim DJrows() As DataRow = dtDJ.Select("ID_formation = " & IDModifForm)
        For i As Integer = 1 To nbDemiJourNumericUpDown.Value
            Dim newDJ As New accueilForm.DJ
            If modifForm And i <= DJrows.Length Then
                newDJ.ID = DJrows(i - 1).Item("ID_DJ")
            Else
                newDJ.ID = IDDJMax
                IDDJMax += 1
            End If
            Dim dtp As New DateTimePicker
            dtp = Me.Controls.Find("dateDJ" & i & "DateTimePicker", True).FirstOrDefault()
            newDJ.dateDJ = dtp.Value.Date.ToString("MM/dd/yyyy")
            newDJ.AMPM = Me.Controls.Find("ampm" & i & "ComboBox", True).FirstOrDefault().Text
            newDJ.jour_entier = "Non"
            listeDJ.Add(newDJ)
        Next
        For i As Integer = 0 To (nbDemiJour - 2)
            For j As Integer = i To (nbDemiJour - 1)
                If i <> j Then
                    If listeDJ(i).dateDJ = listeDJ(j).dateDJ Then
                        If listeDJ(i).AMPM = listeDJ(j).AMPM Then
                            MsgBox("Attention, deux demi-journées sont identiques. Vérifier les dates et la définition des matin/après-midi/nuit.", MsgBoxStyle.OkOnly, "Erreur")
                            Exit Sub
                        Else
                            listeDJ(i).jour_entier = "Oui"
                            listeDJ(j).jour_entier = "Oui"
                        End If
                    End If
                End If
            Next
        Next

        ' Formateur
        Dim IDFormMax As Integer
        If dtFormateur.Rows.Count = 0 Then
            IDFormMax = 1
        Else
            IDFormMax = dtFormateur.Select("ID_formateur = MAX(ID_formateur)")(0).Item("ID_formateur") + 1
        End If
        For Each ctr In formateurFlowLayoutPanel.Controls
            If TypeOf (ctr) Is Label Then
                Dim str As New List(Of String)(Split(ctr.Text, " | "))
                Dim IDForm As New Integer
                If str(1) = "" Or str(1) = "NA" Or Not Integer.TryParse(str(1), IDForm) Then
                    IDForm = IDFormMax
                    IDFormMax += 1
                Else
                    IDForm = str(1)
                End If
                listeFormateur.Add(New accueilForm.Formateur With {.ID = IDForm, .nom = str(2), .prenom = str(3), .profession = str(4), .service = str(5), .lieu_profession = str(6), .mail = str(7), .num_ADELI_matricule = str(8), .droit_image = str(9), .formateur_certifie = str(10)})
            End If
        Next

        ' Aide-Formateur
        Dim IDAideFormMax As Integer
        If dtAideFormateur.Rows.Count = 0 Then
            IDAideFormMax = 1
        Else
            IDAideFormMax = dtAideFormateur.Select("ID_aide_formateur = MAX(ID_aide_formateur)")(0).Item("ID_aide_formateur") + 1
        End If
        For Each ctr In AideFormFlowLayoutPanel.Controls
            If TypeOf (ctr) Is Label Then
                Dim str As New List(Of String)(Split(ctr.Text, " | "))
                Dim IDAideForm As New Integer
                If str(1) = "" Or str(1) = "NA" Or Not Integer.TryParse(str(1), IDAideForm) Then
                    IDAideForm = IDAideFormMax
                    IDAideFormMax += 1
                Else
                    IDAideForm = str(1)
                End If
                listeAideFormateur.Add(New accueilForm.Aide_formateur With {.ID = IDAideForm, .nom = str(2), .prenom = str(3), .profession = str(4), .service = str(5), .lieu_profession = str(6), .mail = str(7), .num_ADELI_matricule = str(8), .droit_image = str(9)})
            End If
        Next

        ' Participant
        Dim IDParMax As Integer
        If dtParticipant.Rows.Count = 0 Then
            IDParMax = 1
        Else
            IDParMax = dtParticipant.Select("ID_participant = MAX(ID_participant)")(0).Item("ID_participant") + 1
        End If
        For Each ctr In participantFlowLayoutPanel.Controls
            If TypeOf (ctr) Is Label Then
                Dim str As New List(Of String)(Split(ctr.Text, " | "))
                Dim IDParticipant As New Integer
                If str(1) = "" Or str(1) = "NA" Or Not Integer.TryParse(str(1), IDParticipant) Then
                    IDParticipant = IDParMax
                    IDParMax += 1
                Else
                    IDParticipant = str(1)
                End If
                listeParticipant.Add(New accueilForm.Participant With {.ID = IDParticipant, .nom = str(2), .prenom = str(3), .profession = str(4), .service = str(5), .lieu_profession = str(6), .mail = str(7), .num_ADELI_matricule = str(8), .droit_image = str(9)})
            End If
        Next

        ' Recette et frais 
        newFormation.recette = CDbl(Val(recetteTextBox.Text))
        newFormation.frais = CDbl(Val(fraisTextBox.Text))
        newFormation.etat_titre = etatTitreComboBox.Text

        ' Affiche la Form presence qui associe les formateurs/aide-formateurs/participants à chaque demi-journée
        presenceForm.Show()
        Me.Enabled = False
    End Sub



    ' ----------------------------------- FONCTIONS SUPPLEMENTAIRES ----------------------------------- '
    ' Fonction qui gère les bouttons qui supprime des formateurs/aide-formateurs/participants
    Private Sub SupprButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' récupère le nom du bouton
        Dim number As String = Split(sender.Name, "_")(2)
        Dim pers As String = Split(sender.Name, "_")(1)
        ' Récupère le Label à supprimer et le supprime
        Dim lbl = Me.Controls.Find(pers & "_" & number & "_Label", True).FirstOrDefault()
        If lbl IsNot Nothing Then
            lbl.Dispose()
        End If
        ' Récupère le Button Suppr à supprimer et le supprime
        Dim bt = Me.Controls.Find("Suppr_" & pers & "_" & number & "_Button", True).FirstOrDefault()
        If bt IsNot Nothing Then
            bt.Dispose()
        End If
        ' Récupère le Button Modif à supprimer et le supprime
        Dim bt2 = Me.Controls.Find("Modif_" & pers & "_" & number & "_Button", True).FirstOrDefault()
        If bt2 IsNot Nothing Then
            bt2.Dispose()
        End If
    End Sub

    ' Fonction qui gère les bouttons qui modifie des formateurs/aide-formateurs/participants
    Private Sub ModifButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' récupère le nom du bouton
        Dim number As String = Split(sender.Name, "_")(2)
        Dim pers As String = Split(sender.Name, "_")(1)
        ' Récupère le Label à supprimer et remet les infos dans le formulaire 
        Dim lbl = Me.Controls.Find(pers & "_" & number & "_Label", True).FirstOrDefault()
        Dim infoPar As String() = Split(lbl.Text, " | ")
        Dim id = Me.Controls.Find("ID" & pers & "Textbox", True).FirstOrDefault()
        id.Text = infoPar(1)
        id.Enabled = True
        Dim nom = Me.Controls.Find("nom" & pers & "ComboBox", True).FirstOrDefault()
        nom.Text = infoPar(2)
        Dim prenom = Me.Controls.Find("prenom" & pers & "ComboBox", True).FirstOrDefault()
        prenom.Text = infoPar(3)
        Dim prof = Me.Controls.Find("prof" & pers & "ComboBox", True).FirstOrDefault()
        prof.Text = infoPar(4)
        Dim service = Me.Controls.Find("service" & pers & "ComboBox", True).FirstOrDefault()
        service.Text = infoPar(5)
        Dim lieuProf = Me.Controls.Find("lieuProf" & pers & "ComboBox", True).FirstOrDefault()
        lieuProf.Text = infoPar(6)
        Dim mail = Me.Controls.Find("mail" & pers & "TextBox", True).FirstOrDefault()
        mail.Text = infoPar(7)
        Dim numADELI = Me.Controls.Find("numADELI" & pers & "TextBox", True).FirstOrDefault()
        numADELI.Text = infoPar(8)
        Dim droitImage As CheckBox = Me.Controls.Find("droitImage" & pers & "CheckBox", True).FirstOrDefault()
        If infoPar(9) = "Oui" Then
            droitImage.Checked = True
        Else
            droitImage.Checked = False
        End If
        If pers = "Formateur" Then
            If infoPar(10) = "Oui" Then
                formateurCertifieCheckBox.Checked = True
            Else
                formateurCertifieCheckBox.Checked = False
            End If
        End If

        ' Supprime la ligne (label, boutons modif et suppr) en appelant la Sub SupprButton_Click
        SupprButton_Click(sender, e)
    End Sub


    ' Fonction qui charge les données d'une formation pour la modifier
    Private Sub loadModifForm(ByVal IDForm As Integer)
        ' Onglet formation
        anneeFormNumericUpDown.Value = dtFormation.Select("ID_formation = " & IDForm).First.Item("annee").ToString()
        categoFormComboBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("categorie").ToString()
        titreFormTextBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("intitule").ToString()
        structureComboBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("structure_organisatrice").ToString()
        respPedNomComboBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("responsable_nom").ToString()
        respPedPrenomComboBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("responsable_prenom").ToString()
        formCSSOIComboBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("formation_centre").ToString()
        lieuFormComboBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("lieu").ToString()
        nbFormNumericUpDown.Value = dtFormation.Select("ID_formation = " & IDForm).First.Item("nb_formateur").ToString()
        nbAideFormNumericUpDown.Value = dtFormation.Select("ID_formation = " & IDForm).First.Item("nb_aide_formateur").ToString()
        nbParticipantNumericUpDown.Value = dtFormation.Select("ID_formation = " & IDForm).First.Item("nb_participant").ToString()
        ' DJ
        Dim DJrows() As DataRow = dtDJ.Select("ID_formation = " & IDForm)
        dateDJ1DateTimePicker.Value = Convert.ToDateTime(DJrows(0).Item("date").ToString())
        ampm1ComboBox.Text = DJrows(0).Item("AMPM").ToString()
        Dim IDDJstr As String = "ID_DJ = " & DJrows(0).Item("ID_DJ").ToString()
        If DJrows.Count > 1 Then
            For i As Integer = 1 To DJrows.Count - 1
                ' DJ
                nbDemiJourNumericUpDown.UpButton()
                Dim dtp As New DateTimePicker
                dtp = Me.Controls.Find("dateDJ" & i + 1 & "DateTimePicker", True).FirstOrDefault()
                dtp.Value = Convert.ToDateTime(DJrows(i).Item("date").ToString())
                Dim cbb As New ComboBox
                cbb = Me.Controls.Find("ampm" & i + 1 & "ComboBox", True).FirstOrDefault()
                cbb.Text = DJrows(i).Item("AMPM").ToString()
                IDDJstr = IDDJstr & " OR ID_DJ = " & DJrows(i).Item("ID_DJ").ToString()
            Next
        End If
        ' Onglet Formateur
        Dim command = New OleDbCommand("SELECT DJFormateur.ID_formateur FROM DJFormateur WHERE " & IDDJstr, accueilForm.myConnection)
        Dim idFormateur As New List(Of Integer)
        Dim rdr = command.ExecuteReader
        While rdr.Read()
            If idFormateur.Contains(rdr.GetValue(0)) = False Then
                idFormateur.Add(rdr.GetValue(0))
            End If
        End While
        For i As Integer = 1 To idFormateur.Count
            nomFormateurComboBox.Text = dtFormateur.Select("ID_formateur = " & idFormateur(i - 1)).First.Item("nom").ToString()
            prenomFormateurComboBox.Text = dtFormateur.Select("ID_formateur = " & idFormateur(i - 1)).First.Item("prenom").ToString()
            ajouterFormateurButton_Click(Nothing, Nothing)
        Next
        nomFormateurComboBox.Text = ""
        prenomFormateurComboBox.Text = ""
        mailFormateurTextBox.Text = ""
        numADELIFormateurTextBox.Text = "NA"
        profFormateurComboBox.Text = ""
        serviceFormateurComboBox.Text = ""
        lieuProfFormateurComboBox.Text = ""
        droitImageFormateurCheckBox.Checked = False
        formateurCertifieCheckBox.Checked = False
        ' Onglet aide-Formateur
        Dim command2 = New OleDbCommand("SELECT DJAideFormateur.ID_aide_formateur FROM DJAideFormateur WHERE " & IDDJstr, accueilForm.myConnection)
        Dim idAideForm As New List(Of Integer)
        Dim rdr2 = command2.ExecuteReader
        While rdr2.Read()
            If idAideForm.Contains(rdr2.GetValue(0)) = False Then
                idAideForm.Add(rdr2.GetValue(0))
            End If
        End While
        For i As Integer = 1 To idAideForm.Count
            nomAideFormComboBox.Text = dtAideFormateur.Select("ID_aide_formateur = " & idAideForm(i - 1)).First.Item("nom").ToString()
            prenomAideFormComboBox.Text = dtAideFormateur.Select("ID_aide_formateur = " & idAideForm(i - 1)).First.Item("prenom").ToString()
            ajouterAideFormButton_Click(Nothing, Nothing)
        Next
        nomAideFormComboBox.Text = ""
        prenomAideFormComboBox.Text = ""
        mailAideFormTextBox.Text = ""
        numADELIAideFormTextBox.Text = "NA"
        profAideFormComboBox.Text = ""
        serviceAideFormComboBox.Text = ""
        lieuProfAideFormComboBox.Text = ""
        droitImageAideFormCheckBox.Checked = False
        ' Onglet Participant
        Dim command3 = New OleDbCommand("SELECT DJParticipant.ID_participant FROM DJParticipant WHERE " & IDDJstr, accueilForm.myConnection)
        Dim idPar As New List(Of Integer)
        Dim rdr3 = command3.ExecuteReader
        While rdr3.Read()
            If idPar.Contains(rdr3.GetValue(0)) = False Then
                idPar.Add(rdr3.GetValue(0))
            End If
        End While
        For i As Integer = 1 To idPar.Count
            nomParComboBox.Text = dtParticipant.Select("ID_participant = " & idPar(i - 1)).First.Item("nom").ToString()
            prenomParComboBox.Text = dtParticipant.Select("ID_participant = " & idPar(i - 1)).First.Item("prenom").ToString()
            ajouterParButton_Click(Nothing, Nothing)
        Next
        nomParComboBox.Text = ""
        prenomParComboBox.Text = ""
        mailParTextBox.Text = ""
        numADELIParTextBox.Text = "NA"
        profParComboBox.Text = ""
        serviceParComboBox.Text = ""
        lieuProfParComboBox.Text = ""
        droitImageParCheckBox.Checked = False
        ' Onglet Recette et frais
        recetteTextBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("recette").ToString()
        fraisTextBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("frais").ToString()
        etatTitreComboBox.Text = dtFormation.Select("ID_formation = " & IDForm).First.Item("etat_titre").ToString()
    End Sub


End Class