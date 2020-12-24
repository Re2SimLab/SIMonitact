Public Class exportForm
    ' -------------------------------------------- VARIABLES -------------------------------------------- '
    ' Lecture des tables de la BDD
    ' Formation 
    Public Shared strFormation As String = "SELECT * FROM Formation"
    Public Shared dtFormation As New DataTable
    Public Shared daFormation As New OleDbDataAdapter(strFormation, accueilForm.myConnection)


    ' --------------------------------------- FONCTIONS GESTION APP --------------------------------------- '
    ' Fermeture de la form
    Private Sub exportForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' Ferme l'application
        Application.Restart() ' Relance l'appli pour prendre en compte les modifs faites à la BDD
        accueilForm.Show()
    End Sub

    Private Sub annulerExtracFormButton_Click(sender As Object, e As EventArgs) Handles annulerExtracFormButton.Click
        accueilForm.Show()
        Me.Close()
    End Sub

    Private Sub exportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Chargement des données 
        daFormation.Fill(dtFormation)

        ' Année à extraire de la formation
        anneeExtractionNumericUpDown.Value = System.DateTime.Today.Year

        ' Coche les checkBox
        formationCheckBox.Checked = True
        DJCheckBox.Checked = True
        formateurCheckBox.Checked = True
        aideFormCheckBox.Checked = True
        participantCheckBox.Checked = True
    End Sub


    ' ----------------------- FONCTIONS GESTION DES OPTIONS D'EXTRACTION ----------------------- '
    ' Gestion de la sélection de l'option par année
    Private Sub anneeExtractionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles anneeExtractionRadioButton.CheckedChanged
        If anneeExtractionRadioButton.Checked Then
            anneeExtractionNumericUpDown.Enabled = True
        Else
            anneeExtractionNumericUpDown.Enabled = False
        End If
    End Sub

    ' Gestion du check formation automatique (sélectionne/déselectionne l'ensemble des variavles)
    Private Sub formationCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles formationCheckBox.CheckedChanged
        Dim state As Boolean = False
        If formationCheckBox.Checked Then
            state = True
        End If
        For i As Integer = 0 To formationCheckedListBox.Items.Count - 1
            formationCheckedListBox.SetItemChecked(i, state)
        Next i
    End Sub

    ' Gestion du check DJ automatique (sélectionne/déselectionne l'ensemble des variavles)
    Private Sub DJCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DJCheckBox.CheckedChanged
        Dim state As Boolean = False
        If DJCheckBox.Checked Then
            state = True
        End If
        For i As Integer = 0 To DJCheckedListBox.Items.Count - 1
            DJCheckedListBox.SetItemChecked(i, state)
        Next i
    End Sub

    ' Gestion du check formateur automatique (sélectionne/déselectionne l'ensemble des variavles)
    Private Sub formateurCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles formateurCheckBox.CheckedChanged
        Dim state As Boolean = False
        If formateurCheckBox.Checked Then
            state = True
        End If
        For i As Integer = 0 To formateurCheckedListBox.Items.Count - 1
            formateurCheckedListBox.SetItemChecked(i, state)
        Next i
    End Sub

    ' Gestion du check aideForm automatique (sélectionne/déselectionne l'ensemble des variavles)
    Private Sub aideFormCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles aideFormCheckBox.CheckedChanged
        Dim state As Boolean = False
        If aideFormCheckBox.Checked Then
            state = True
        End If
        For i As Integer = 0 To aideFormCheckedListBox.Items.Count - 1
            aideFormCheckedListBox.SetItemChecked(i, state)
        Next i
    End Sub

    ' Gestion du check participant automatique (sélectionne/déselectionne l'ensemble des variavles)
    Private Sub participantCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles participantCheckBox.CheckedChanged
        Dim state As Boolean = False
        If participantCheckBox.Checked Then
            state = True
        End If
        For i As Integer = 0 To participantCheckedListBox.Items.Count - 1
            participantCheckedListBox.SetItemChecked(i, state)
        Next i
    End Sub




    ' -------------------------------- FONCTION D'EXTRACTION DES DONNEES --------------------------------- '

    ' Gestion de l'extraction des données
    Private Sub extraireButton_Click(sender As Object, e As EventArgs) Handles extraireButton.Click
        ' Vérification qu'au moins une variable a été coché pour l'extraction
        Dim extractFormation As Boolean = True
        Dim extractDJ As Boolean = True
        Dim extractFormateur As Boolean = True
        Dim extractAideFormateur As Boolean = True
        Dim extractParticipant As Boolean = True
        If formationCheckedListBox.CheckedItems.Count = 0 Then
            extractFormation = False
        End If
        If DJCheckedListBox.CheckedItems.Count = 0 Then
            extractDJ = False
        End If
        If formateurCheckedListBox.CheckedItems.Count = 0 Then
            extractFormateur = False
        End If
        If aideFormCheckedListBox.CheckedItems.Count = 0 Then
            extractAideFormateur = False
        End If
        If participantCheckedListBox.CheckedItems.Count = 0 Then
            extractParticipant = False
        End If
        If extractFormation = False And extractDJ = False And extractFormateur = False And extractAideFormateur = False And extractParticipant = False Then
            MsgBox("Veuillez sélectionner au minimum une variable à extraire.")
            Exit Sub
        End If
        ' Vérifie qu'il y ait au moins une formation à extraire
        If dtFormation.Rows.Count = 0 Then
            MsgBox("Il n'y a aucune formation dans la base de données. Saisissez une formation pour pouvoir extraire les données.")
            Exit Sub
        End If

        ' Change le curseur pour montrer que l'app s'execute (extraction un peu longue)
        Me.Cursor = Cursors.WaitCursor

        ' Définition du fichier Excel 
        Dim strPathFile As String = SIMonitact.My.Settings.PathExtractionBDD.ToString & "\" & Today.ToString("yyyy.MM.dd") & "_Monitact_ExtractionBDD_ALL"
        If anneeExtractionRadioButton.Checked Then
            strPathFile = strPathFile.Substring(0, strPathFile.Length - 3) & "Annee" & anneeExtractionNumericUpDown.Value.ToString
        End If
        Dim strExcel As String = " INTO [Excel 12.0 Xml;DATABASE=" & strPathFile & ".xlsx;HDR=Yes]"

        ' Vérif si le fichier Excel est déjà existant et demande si on doit le remplacer
        If My.Computer.FileSystem.FileExists(strPathFile & ".xlsx") Then
            Dim result As DialogResult = MessageBox.Show("Le fichier d'extraction " & strPathFile.Split("\").Last.ToString & ".xlsx existe déjà. Voulez-vous le remplacer par cette nouvelle extraction ?", "Erreur fichier", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                My.Computer.FileSystem.DeleteFile(strPathFile & ".xlsx")
            Else
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        ' Défini les variables à extraire de la table Formation
        Dim strFormationTOT As String = "SELECT DISTINCT "
        Dim strFormation As String = "SELECT DISTINCT "
        If formationCheckedListBox.CheckedItems.Count <> 0 Then
            For i As Integer = 1 To formationCheckedListBox.CheckedItems.Count
                strFormationTOT = strFormationTOT & "Formation." & formationCheckedListBox.CheckedItems(i - 1).ToString() & " As formation_" & formationCheckedListBox.CheckedItems(i - 1).ToString() & ", "
                strFormation = strFormation & formationCheckedListBox.CheckedItems(i - 1).ToString() & ", "
            Next
        End If
        strFormation = strFormation.Substring(0, strFormation.Length - 2) & strExcel & ".[Formation] FROM Formation;"

        ' Défini les variables à extraire de la table DJ
        Dim strDJTOT As String = ""
        Dim strDJ As String = "SELECT "
        If DJCheckedListBox.CheckedItems.Count <> 0 Then
            For i As Integer = 1 To DJCheckedListBox.CheckedItems.Count
                strDJTOT = strDJTOT & "DJ." & DJCheckedListBox.CheckedItems(i - 1).ToString() & " As DJ_" & DJCheckedListBox.CheckedItems(i - 1).ToString() & ", "
                strDJ = strDJ & "DJ." & DJCheckedListBox.CheckedItems(i - 1).ToString() & ", "
            Next
        End If
        strDJ = strDJ.Substring(0, strDJ.Length - 2) & strExcel & ".[DJ] FROM Formation INNER JOIN DJ ON Formation.[ID_formation] = DJ.[ID_formation];"

        ' Défini les variables à extraire de la table Formateur
        Dim strFormateurTOT As String = ""
        Dim strFormateur As String = "SELECT DISTINCT "
        If formateurCheckedListBox.CheckedItems.Count <> 0 Then
            For i As Integer = 1 To formateurCheckedListBox.CheckedItems.Count
                strFormateurTOT = strFormateurTOT & "Formateur." & formateurCheckedListBox.CheckedItems(i - 1).ToString() & " As formateur_" & formateurCheckedListBox.CheckedItems(i - 1).ToString() & ", "
                strFormateur = strFormateur & "Formateur." & formateurCheckedListBox.CheckedItems(i - 1).ToString() & ", "
            Next
        End If
        strFormateur = strFormateur.Substring(0, strFormateur.Length - 2) & strExcel & ".[Formateur] FROM (Formation INNER JOIN DJ ON Formation.[ID_formation] = DJ.[ID_formation]) INNER JOIN (Formateur INNER JOIN DJFormateur ON Formateur.[ID_formateur] = DJFormateur.[ID_formateur]) ON DJ.[ID_DJ] = DJFormateur.[ID_DJ];"

        ' Défini les variables à extraire de la table Aide-Formateur
        Dim strAideFormateurTOT As String = ""
        Dim strAideFormateur As String = "SELECT DISTINCT "
        If aideFormCheckedListBox.CheckedItems.Count <> 0 Then
            For i As Integer = 1 To aideFormCheckedListBox.CheckedItems.Count
                strAideFormateurTOT = strAideFormateurTOT & "AideFormateur." & aideFormCheckedListBox.CheckedItems(i - 1).ToString() & " As aide_formateur_" & aideFormCheckedListBox.CheckedItems(i - 1).ToString() & ", "
                strAideFormateur = strAideFormateur & "AideFormateur." & aideFormCheckedListBox.CheckedItems(i - 1).ToString() & ", "
            Next
        End If
        strAideFormateur = strAideFormateur.Substring(0, strAideFormateur.Length - 2) & strExcel & ".[AideFormateur] FROM (Formation INNER JOIN DJ ON Formation.[ID_formation] = DJ.[ID_formation]) INNER JOIN (AideFormateur INNER JOIN DJAideFormateur ON AideFormateur.[ID_aide_formateur] = DJAideFormateur.[ID_aide_formateur]) ON DJ.[ID_DJ] = DJAideFormateur.[ID_DJ];"

        ' Défini les variables à extraire de la table Participant
        Dim strParticipantTOT As String = ""
        Dim strParticipant As String = "SELECT DISTINCT "
        If participantCheckedListBox.CheckedItems.Count <> 0 Then
            For i As Integer = 1 To participantCheckedListBox.CheckedItems.Count
                strParticipantTOT = strParticipantTOT & "Participant." & participantCheckedListBox.CheckedItems(i - 1).ToString() & " As participant_" & participantCheckedListBox.CheckedItems(i - 1).ToString() & ", "
                strParticipant = strParticipant & "Participant." & participantCheckedListBox.CheckedItems(i - 1).ToString() & ", "
            Next
        End If
        strParticipant = strParticipant.Substring(0, strParticipant.Length - 2) & strExcel & ".[Participant] FROM (Formation INNER JOIN DJ ON Formation.[ID_formation] = DJ.[ID_formation]) INNER JOIN (Participant INNER JOIN DJParticipant ON Participant.[ID_participant] = DJParticipant.[ID_participant]) ON DJ.[ID_DJ] = DJParticipant.[ID_DJ];"

        ' Défini les requetes d'extraction sur l'ensemble des tables (INNER JOIN)
        Dim strALL As String = strFormationTOT & strDJTOT & strFormateurTOT & strParticipantTOT
        Dim strALLAideForm As String = strFormationTOT & strDJTOT & strFormateurTOT & strAideFormateurTOT & strParticipantTOT
        strALL = strALL.Substring(0, strALL.Length - 2)
        strALLAideForm = strALLAideForm.Substring(0, strALLAideForm.Length - 2)
        strALL = strALL & strExcel & ".[DataALL] FROM ((Formation INNER JOIN DJ ON Formation.[ID_formation] = DJ.[ID_formation]) INNER JOIN (Formateur INNER JOIN DJFormateur ON Formateur.[ID_formateur] = DJFormateur.[ID_formateur]) ON DJ.[ID_DJ] = DJFormateur.[ID_DJ]) INNER JOIN (Participant INNER JOIN DJParticipant ON Participant.[ID_participant] = DJParticipant.[ID_participant]) ON DJ.[ID_DJ] = DJParticipant.[ID_DJ];"
        strALLAideForm = strALLAideForm & strExcel & ".[Data_AideFormateur] FROM (((Formation INNER JOIN DJ ON Formation.[ID_formation] = DJ.[ID_formation]) INNER JOIN (Formateur INNER JOIN DJFormateur ON Formateur.[ID_formateur] = DJFormateur.[ID_formateur]) ON DJ.[ID_DJ] = DJFormateur.[ID_DJ]) INNER JOIN (Participant INNER JOIN DJParticipant ON Participant.[ID_participant] = DJParticipant.[ID_participant]) ON DJ.[ID_DJ] = DJParticipant.[ID_DJ]) INNER JOIN (AideFormateur INNER JOIN DJAideFormateur ON AideFormateur.[ID_aide_formateur] = DJAideFormateur.[ID_aide_formateur]) ON DJ.[ID_DJ] = DJAideFormateur.[ID_DJ];"

        ' Défini si les extractions sont globales ou sur une année spécifique
        If anneeExtractionRadioButton.Checked Then
            strALL = strALL.Substring(0, strALL.Length - 1) & " WHERE Formation.annee = " & anneeExtractionNumericUpDown.Value.ToString & ";"
            strALLAideForm = strALLAideForm.Substring(0, strALLAideForm.Length - 1) & " WHERE Formation.annee = " & anneeExtractionNumericUpDown.Value.ToString & ";"
            strFormation = strFormation.Substring(0, strFormation.Length - 1) & " WHERE Formation.annee = " & anneeExtractionNumericUpDown.Value.ToString & ";"
            strDJ = strDJ.Substring(0, strDJ.Length - 1) & " WHERE Formation.annee = " & anneeExtractionNumericUpDown.Value.ToString & ";"
            strFormateur = strFormateur.Substring(0, strFormateur.Length - 1) & " WHERE Formation.annee = " & anneeExtractionNumericUpDown.Value.ToString & ";"
            strAideFormateur = strAideFormateur.Substring(0, strAideFormateur.Length - 1) & " WHERE Formation.annee = " & anneeExtractionNumericUpDown.Value.ToString & ";"
            strParticipant = strParticipant.Substring(0, strParticipant.Length - 1) & " WHERE Formation.annee = " & anneeExtractionNumericUpDown.Value.ToString & ";"
        End If

        ' Execute les requtes d'extraction de la BDD
        Dim commandALL = New OleDbCommand(strALL, accueilForm.myConnection)
        commandALL.ExecuteNonQuery()
        If extractAideFormateur Then
            Dim commandALLAideForm = New OleDbCommand(strALLAideForm, accueilForm.myConnection)
            commandALLAideForm.ExecuteNonQuery()
        End If
        If extractFormation Then
            Dim commandFormation = New OleDbCommand(strFormation, accueilForm.myConnection)
            commandFormation.ExecuteNonQuery()
        End If
        If extractDJ Then
            Dim commandDJ = New OleDbCommand(strDJ, accueilForm.myConnection)
            commandDJ.ExecuteNonQuery()
        End If
        If extractFormateur Then
            Dim commandFormateur = New OleDbCommand(strFormateur, accueilForm.myConnection)
            commandFormateur.ExecuteNonQuery()
        End If
        If extractAideFormateur Then
            Dim commandAideFormateur = New OleDbCommand(strAideFormateur, accueilForm.myConnection)
            commandAideFormateur.ExecuteNonQuery()
        End If
        If extractParticipant Then
            Dim commandParticipant = New OleDbCommand(strParticipant, accueilForm.myConnection)
            commandParticipant.ExecuteNonQuery()
        End If

        ' Remet le curseur par défaut et ferme la form
        Me.Cursor = Cursors.Default
        MsgBox("L'extraction des données a été réalisée avec succès.")
        Me.Close()
    End Sub

End Class