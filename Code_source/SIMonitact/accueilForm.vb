Public Class accueilForm

    ' -------------------------------------- DEFINITION DES CLASSES -------------------------------------- '
    Public Class Formation
        Public Property ID As String
        Public Property annee As Decimal
        Public Property date_debut As String
        Public Property nb_DJ As Decimal
        Public Property categorie As String
        Public Property intitule As String
        Public Property structure_organisatrice As String
        Public Property responsable_nom As String
        Public Property responsable_prenom As String
        Public Property formation_centre As String
        Public Property lieu As String
        Public Property nb_formateur As Decimal
        Public Property nb_aide_formateur As Decimal
        Public Property nb_participant As Decimal
        Public Property recette As Decimal
        Public Property frais As Decimal
        Public Property etat_titre As String
        Public Property liste_DJ As New List(Of DJ)
    End Class

    Public Class DJ
        Public Property ID As String
        Public Property dateDJ As String
        Public Property AMPM As String
        Public Property jour_entier As String
        Public Property nb_formateur As Decimal
        Public Property nb_aide_formateur As Decimal
        Public Property nb_participant As Decimal
        Public Property liste_formateur As New List(Of Formateur)
        Public Property liste_aide_formateur As New List(Of Aide_formateur)
        Public Property liste_participant As New List(Of Participant)
    End Class

    Public Class Formateur
        Public Property ID As String
        Public Property nom As String
        Public Property prenom As String
        Public Property profession As String
        Public Property service As String
        Public Property lieu_profession As String
        Public Property formateur_certifie As String
        Public Property num_ADELI_matricule As String
        Public Property mail As String
        Public Property droit_image As String
    End Class

    Public Class Aide_formateur
        Public Property ID As String
        Public Property nom As String
        Public Property prenom As String
        Public Property profession As String
        Public Property service As String
        Public Property lieu_profession As String
        Public Property num_ADELI_matricule As String
        Public Property mail As String
        Public Property droit_image As String
    End Class

    Public Class Participant
        Public Property ID As String
        Public Property nom As String
        Public Property prenom As String
        Public Property profession As String
        Public Property service As String
        Public Property lieu_profession As String
        Public Property num_ADELI_matricule As String
        Public Property mail As String
        Public Property droit_image As String
    End Class



    ' -------------------------------- DEFINITION DES VARIABLES GLOBALES -------------------------------- '
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader



    ' -------------------------------------- FFONCTIONS GESTION BDD -------------------------------------- '
    ' Fonction qui ouvre la connection avec la BDD de SIMonitact
    Public Sub openBDD()
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" &
            SIMonitact.My.Settings.PathBDD.ToString & "\SIMonitactBDD.accdb;Jet OLEDB:Database Password=" &
            SIMonitact.My.Settings.mdpBDD.ToString & ";"
        myConnection.Open()
    End Sub

    ' Fonction qui ferme la connection avec la BDD de SIMonitact
    Public Sub closeBDD()
        myConnection.Close()
    End Sub

    ' Fonction qui ajoute toute une formation dans la BDD de SIMonitact
    Public Sub addFormationAllBDD(ByVal formation As Formation, ByVal listeFormateur As List(Of Formateur),
                                  ByVal listeAideFormateur As List(Of Aide_formateur), ByVal listeParticipant As List(Of Participant))
        addFormationBDD(formation)
        addFormateurBDD(listeFormateur)
        addAideFormateurBDD(listeAideFormateur)
        addParticipantBDD(listeParticipant)
        addDJBDD(formation.liste_DJ, formation.ID, True)
    End Sub

    ' Fonction qui supprime toute une formation de la BDD de SIMonitact
    Public Sub supprFormationAllBDD(ByVal formSupprID As Integer)
        supprDJBDD(formSupprID)
        deleteFormationBDD(formSupprID)
    End Sub

    ' Fonction qui ajoute les données 'formation' dans la BDD de SIMonitact
    Public Sub addFormationBDD(ByVal formation As Formation)
        Dim str As String = "INSERT INTO Formation " &
            "VALUES (" &
            formation.ID & ", " &
            formation.annee & ", #" &
            formation.date_debut & "#, " &
            formation.nb_DJ & ", '" &
            formation.categorie & "', '" &
            formation.intitule & "', '" &
            formation.structure_organisatrice & "', '" &
            formation.responsable_nom & "', '" &
            formation.responsable_prenom & "', '" &
            formation.formation_centre & "', '" &
            formation.lieu & "', " &
            formation.nb_formateur & ", " &
            formation.nb_aide_formateur & ", " &
            formation.nb_participant & ", " &
            formation.recette & ", " &
            formation.frais & ", '" &
            formation.etat_titre & "')"
        Dim command = New OleDbCommand(str, myConnection)
        command.ExecuteNonQuery()
    End Sub

    ' Fonction qui supprime les données d'une formation dans la BDD de SIMonitact
    Public Sub deleteFormationBDD(ByVal formSupprID As Integer)
        Dim commandFormationSuppr = New OleDbCommand("DELETE * FROM Formation WHERE ID_formation=" & formSupprID, myConnection)
        commandFormationSuppr.ExecuteNonQuery()
    End Sub

    ' Fonction qui ajoute les données 'DJ' dans la BDD de SIMonitact
    Public Sub addDJBDD(ByVal listeDJ As List(Of DJ), ByVal ID_formation As Integer, Optional ByVal autoJT As Boolean = True)
        For i As Integer = 0 To listeDJ.Count - 1
            'MsgBox(listeDJ(i).dateDJ)
            Dim str As String = "INSERT INTO DJ " &
            "VALUES (" &
            listeDJ(i).ID & ", " &
            ID_formation & ", #" &
            listeDJ(i).dateDJ & "#, '" &
            listeDJ(i).AMPM & "', '" &
            listeDJ(i).jour_entier & "', " &
            listeDJ(i).nb_formateur & ", " &
            listeDJ(i).nb_aide_formateur & ", " &
            listeDJ(i).nb_participant & ")"
            Dim command = New OleDbCommand(str, myConnection)
            command.ExecuteNonQuery()

            ' Joint table
            If autoJT Then
                ' DJFormateur
                If listeDJ(i).nb_formateur <> 0 Then
                    Dim commandID1 = New OleDbCommand("SELECT MAX(ID_DJFormateur) FROM DJFormateur", myConnection)
                    Dim idForm As Integer
                    If commandID1.ExecuteScalar.Equals(DBNull.Value) Then
                        idForm = 1
                    Else
                        idForm = CInt(commandID1.ExecuteScalar) + 1
                    End If
                    For j As Integer = 0 To listeDJ(i).nb_formateur - 1
                        Dim strForm As String = "INSERT INTO DJFormateur " &
            "VALUES (" &
            idForm & ", " &
            listeDJ(i).ID & ", " &
            listeDJ(i).liste_formateur(j).ID & ")"
                        Dim commandForm = New OleDbCommand(strForm, myConnection)
                        commandForm.ExecuteNonQuery()
                        idForm += 1
                    Next
                End If
                ' DJAideForm
                If listeDJ(i).nb_aide_formateur <> 0 Then
                    Dim commandID2 = New OleDbCommand("SELECT MAX(ID_DJAideFormateur) FROM DJAideFormateur", myConnection)
                    Dim idAideForm As Integer
                    If commandID2.ExecuteScalar.Equals(DBNull.Value) Then
                        idAideForm = 1
                    Else
                        idAideForm = CInt(commandID2.ExecuteScalar) + 1
                    End If
                    For j As Integer = 0 To listeDJ(i).nb_aide_formateur - 1
                        Dim strAideForm As String = "INSERT INTO DJAideFormateur " &
            "VALUES (" &
            idAideForm & ", " &
            listeDJ(i).ID & ", " &
            listeDJ(i).liste_aide_formateur(j).ID & ")"
                        Dim commandAideForm = New OleDbCommand(strAideForm, myConnection)
                        commandAideForm.ExecuteNonQuery()
                        idAideForm += 1
                    Next
                End If
                ' DJParticipant
                If listeDJ(i).nb_participant <> 0 Then
                    Dim commandID3 = New OleDbCommand("SELECT MAX(ID_DJParticipant) FROM DJParticipant", myConnection)
                    Dim idPar As Integer
                    If commandID3.ExecuteScalar.Equals(DBNull.Value) Then
                        idPar = 1
                    Else
                        idPar = CInt(commandID3.ExecuteScalar) + 1
                    End If
                    For j As Integer = 0 To listeDJ(i).nb_participant - 1
                        Dim strPar As String = "INSERT INTO DJParticipant " &
            "VALUES (" &
            idPar & ", " &
            listeDJ(i).ID & ", " &
            listeDJ(i).liste_participant(j).ID & ")"
                        Dim commandPar = New OleDbCommand(strPar, myConnection)
                        commandPar.ExecuteNonQuery()
                        idPar += 1
                    Next
                End If
            End If
        Next
    End Sub

    ' Fonction qui supprime les données 'DJ' dans la BDD de SIMonitact
    Public Sub supprDJBDD(ByVal formSupprID As Integer)
        ' Récupère les ID des DJ à suppr
        Dim commandIDDJ = New OleDbCommand("SELECT ID_DJ FROM DJ WHERE DJ.ID_formation = " & formSupprID, myConnection)
        Dim idDJ As New List(Of Integer)
        Dim rdrDJ = commandIDDJ.ExecuteReader
        While rdrDJ.Read()
            If idDJ.Contains(rdrDJ.GetValue(0)) = False Then
                idDJ.Add(rdrDJ.GetValue(0))
            End If
        End While

        ' Supprime les lignes des tables DJFormateur, DJAideFormateur et DJParticipant puis de la table DJ
        If idDJ.Count <> 0 Then
            For i As Integer = 0 To idDJ.Count - 1
                ' ---- DJFormateur ---- '
                ' Récupère les ID formateurs et regarde s'ils ont fait d'autre DJ de formation (détermine s'il faut supprimer le formateur)
                Dim commandIDForm = New OleDbCommand("SELECT ID_formateur FROM DJFormateur WHERE ID_DJ=" & idDJ(i), myConnection)
                Dim idForm As New List(Of Integer)
                Dim rdrForm = commandIDForm.ExecuteReader
                While rdrForm.Read()
                    If idForm.Contains(rdrForm.GetValue(0)) = False Then
                        idForm.Add(rdrForm.GetValue(0))
                    End If
                End While
                Dim idFormSuppr As New List(Of Integer)
                If idForm.Count <> 0 Then
                    For j As Integer = 0 To idForm.Count - 1
                        Dim commandCountForm = New OleDbCommand("SELECT COUNT(ID_formateur) FROM DJFormateur WHERE ID_formateur=" & idForm(j), myConnection)
                        Dim countForm As Integer = CInt(commandCountForm.ExecuteScalar)
                        If countForm = 1 Then
                            idFormSuppr.Add(idForm(j))
                        End If
                    Next
                End If
                ' Supprime lignes dans DJFormateur
                Dim commandFormSuppr = New OleDbCommand("DELETE * FROM DJFormateur WHERE ID_DJ=" & idDJ(i), myConnection)
                commandFormSuppr.ExecuteNonQuery()
                ' Supprime les formateur dans Formateur
                If idFormSuppr.Count <> 0 Then
                    deleteFormateurBDD(idFormSuppr)
                End If

                ' ---- DJAideFormateur ----
                ' Récupère les ID aide-formateurs et regarde s'ils ont fait d'autre DJ de formation (détermine s'il faut supprimer l'aide-formateur)
                Dim commandIDAideForm = New OleDbCommand("SELECT ID_aide_formateur FROM DJAideFormateur WHERE ID_DJ=" & idDJ(i), myConnection)
                Dim idAideForm As New List(Of Integer)
                Dim rdrAideForm = commandIDAideForm.ExecuteReader
                While rdrAideForm.Read()
                    If idAideForm.Contains(rdrAideForm.GetValue(0)) = False Then
                        idAideForm.Add(rdrAideForm.GetValue(0))
                    End If
                End While
                Dim idAideFormSuppr As New List(Of Integer)
                If idAideForm.Count <> 0 Then
                    For j As Integer = 0 To idAideForm.Count - 1
                        Dim commandCountAideForm = New OleDbCommand("SELECT COUNT(ID_aide_formateur) FROM DJAideFormateur WHERE ID_aide_formateur=" & idAideForm(j), myConnection)
                        Dim countAideForm As Integer = CInt(commandCountAideForm.ExecuteScalar)
                        If countAideForm = 1 Then
                            idAideFormSuppr.Add(idAideForm(j))
                        End If
                    Next
                End If
                ' Supprime lignes dans DJAideFormateur
                Dim commandAideFormSuppr = New OleDbCommand("DELETE * FROM DJAideFormateur WHERE ID_DJ=" & idDJ(i), myConnection)
                commandAideFormSuppr.ExecuteNonQuery()
                ' Supprime les aide-formateurs dans AideFormateur
                If idAideFormSuppr.Count <> 0 Then
                    deleteAideFormateurBDD(idAideFormSuppr)
                End If


                ' ---- DJParticipant ---- '
                ' Récupère les ID participants et regarde s'ils ont fait d'autre DJ de formation (détermine s'il faut supprimer le participant)
                Dim commandIDPar = New OleDbCommand("SELECT ID_participant FROM DJParticipant WHERE ID_DJ=" & idDJ(i), myConnection)
                Dim idPar As New List(Of Integer)
                Dim rdrPar = commandIDPar.ExecuteReader
                While rdrPar.Read()
                    If idPar.Contains(rdrPar.GetValue(0)) = False Then
                        idPar.Add(rdrPar.GetValue(0))
                    End If
                End While
                Dim idParSuppr As New List(Of Integer)
                If idPar.Count <> 0 Then
                    For j As Integer = 0 To idPar.Count - 1
                        Dim commandCountPar = New OleDbCommand("SELECT COUNT(ID_participant) FROM DJParticipant WHERE ID_participant=" & idPar(j), myConnection)
                        Dim countPar As Integer = CInt(commandCountPar.ExecuteScalar)
                        If countPar = 1 Then
                            idParSuppr.Add(idPar(j))
                        End If
                    Next
                End If
                ' Supprime lignes dans DJParticipant
                Dim commandParSuppr = New OleDbCommand("DELETE * FROM DJParticipant WHERE ID_DJ=" & idDJ(i), myConnection)
                commandParSuppr.ExecuteNonQuery()
                ' Supprime les participants dans Participant
                If idParSuppr.Count <> 0 Then
                    deleteParticipantBDD(idParSuppr)
                End If

                ' ---- DJ ---- '
                Dim commandDJSuppr = New OleDbCommand("DELETE * FROM DJ WHERE ID_DJ=" & idDJ(i), myConnection)
                commandDJSuppr.ExecuteNonQuery()
            Next
        End If
    End Sub

    ' Fonction qui ajoute les données 'formateur' dans la BDD de SIMonitact
    Public Sub addFormateurBDD(ByVal listeFormateur As List(Of Formateur))
        For i As Integer = 0 To listeFormateur.Count - 1
            Dim str As String = ""
            Dim commandIDForm = New OleDbCommand("SELECT ID_formateur FROM Formateur WHERE ID_formateur=" & listeFormateur(i).ID, myConnection)
            Dim rdrForm = commandIDForm.ExecuteReader
            If rdrForm.HasRows Then
                str = "UPDATE Formateur " &
            "SET " &
            "nom='" & listeFormateur(i).nom & "', " &
            "prenom='" & listeFormateur(i).prenom & "', " &
            "profession='" & listeFormateur(i).profession & "', " &
            "service='" & listeFormateur(i).service & "', " &
            "lieu_profession='" & listeFormateur(i).lieu_profession & "', " &
            "formateur_certifie='" & listeFormateur(i).formateur_certifie & "', " &
            "num_ADELI_matricule='" & listeFormateur(i).num_ADELI_matricule & "', " &
            "mail='" & listeFormateur(i).mail & "', " &
            "droit_image='" & listeFormateur(i).droit_image & "' " &
            "WHERE [ID_formateur]=" & listeFormateur(i).ID
            Else
                str = "INSERT INTO Formateur " &
            "VALUES (" &
            listeFormateur(i).ID & ", '" &
            listeFormateur(i).nom & "', '" &
            listeFormateur(i).prenom & "', '" &
            listeFormateur(i).profession & "', '" &
            listeFormateur(i).service & "', '" &
            listeFormateur(i).lieu_profession & "', '" &
            listeFormateur(i).formateur_certifie & "', '" &
            listeFormateur(i).num_ADELI_matricule & "', '" &
            listeFormateur(i).mail & "', '" &
            listeFormateur(i).droit_image & "')"
            End If
            Dim command = New OleDbCommand(str, myConnection)
            command.ExecuteNonQuery()
        Next
    End Sub

    ' Fonction qui supprime les données 'formateur' dans la BDD de SIMonitact
    Public Sub deleteFormateurBDD(ByVal listeFormateur As List(Of Integer))
        If listeFormateur.Count <> 0 Then
            For i As Integer = 0 To listeFormateur.Count - 1
                Dim commandFormSuppr = New OleDbCommand("DELETE * FROM Formateur WHERE ID_formateur=" & listeFormateur(i), myConnection)
                commandFormSuppr.ExecuteNonQuery()
            Next
        End If
    End Sub

    ' Fonction qui ajoute les données 'aide formateur' dans la BDD de SIMonitact
    Public Sub addAideFormateurBDD(ByVal listeAideForm As List(Of Aide_formateur))
        For i As Integer = 0 To listeAideForm.Count - 1
            Dim str As String = ""
            Dim commandIDAideForm = New OleDbCommand("SELECT ID_aide_formateur FROM AideFormateur WHERE ID_aide_formateur=" & listeAideForm(i).ID, myConnection)
            Dim rdrAideForm = commandIDAideForm.ExecuteReader
            If rdrAideForm.HasRows Then
                str = "UPDATE AideFormateur " &
            "SET " &
            "nom='" & listeAideForm(i).nom & "', " &
            "prenom='" & listeAideForm(i).prenom & "', " &
            "profession='" & listeAideForm(i).profession & "', " &
            "service='" & listeAideForm(i).service & "', " &
            "lieu_profession='" & listeAideForm(i).lieu_profession & "', " &
            "num_ADELI_matricule='" & listeAideForm(i).num_ADELI_matricule & "', " &
            "mail='" & listeAideForm(i).mail & "', " &
            "droit_image='" & listeAideForm(i).droit_image & "' " &
            "WHERE [ID_aide_formateur]=" & listeAideForm(i).ID
            Else
                str = "INSERT INTO AideFormateur " &
            "VALUES (" &
            listeAideForm(i).ID & ", '" &
            listeAideForm(i).nom & "', '" &
            listeAideForm(i).prenom & "', '" &
            listeAideForm(i).profession & "', '" &
            listeAideForm(i).service & "', '" &
            listeAideForm(i).lieu_profession & "', '" &
            listeAideForm(i).num_ADELI_matricule & "', '" &
            listeAideForm(i).mail & "', '" &
            listeAideForm(i).droit_image & "')"
            End If
            Dim command = New OleDbCommand(str, myConnection)
            command.ExecuteNonQuery()
        Next
    End Sub

    ' Fonction qui supprime les données 'aide-formateur' dans la BDD de SIMonitact
    Public Sub deleteAideFormateurBDD(ByVal listeAideFormateur As List(Of Integer))
        If listeAideFormateur.Count <> 0 Then
            For i As Integer = 0 To listeAideFormateur.Count - 1
                Dim commandAideFormSuppr = New OleDbCommand("DELETE * FROM AideFormateur WHERE ID_aide_formateur=" & listeAideFormateur(i), myConnection)
                commandAideFormSuppr.ExecuteNonQuery()
            Next
        End If
    End Sub

    ' Fonction qui ajoute les données 'participant' dans la BDD de SIMonitact
    Public Sub addParticipantBDD(ByVal listeParticipant As List(Of Participant))
        For i As Integer = 0 To listeParticipant.Count - 1
            Dim str As String = ""
            Dim commandIDPar = New OleDbCommand("SELECT ID_participant FROM Participant WHERE ID_participant=" & listeParticipant(i).ID, myConnection)
            Dim rdrPar = commandIDPar.ExecuteReader
            If rdrPar.HasRows Then
                str = "UPDATE Participant " &
                "SET " &
                "nom='" & listeParticipant(i).nom & "', " &
                "prenom='" & listeParticipant(i).prenom & "', " &
                "profession='" & listeParticipant(i).profession & "', " &
                "service='" & listeParticipant(i).service & "', " &
                "lieu_profession='" & listeParticipant(i).lieu_profession & "', " &
                "num_ADELI_matricule='" & listeParticipant(i).num_ADELI_matricule & "', " &
                "mail='" & listeParticipant(i).mail & "', " &
                "droit_image='" & listeParticipant(i).droit_image & "' " &
                "WHERE [ID_participant]=" & listeParticipant(i).ID
            Else
                str = "INSERT INTO Participant " &
            "VALUES (" &
            listeParticipant(i).ID & ", '" &
            listeParticipant(i).nom & "', '" &
            listeParticipant(i).prenom & "', '" &
            listeParticipant(i).profession & "', '" &
            listeParticipant(i).service & "', '" &
            listeParticipant(i).lieu_profession & "', '" &
            listeParticipant(i).num_ADELI_matricule & "', '" &
            listeParticipant(i).mail & "', '" &
            listeParticipant(i).droit_image & "')"
            End If
            Dim command = New OleDbCommand(str, myConnection)
            command.ExecuteNonQuery()
        Next
    End Sub

    ' Fonction qui supprime les données 'participant' dans la BDD de SIMonitact
    Public Sub deleteParticipantBDD(ByVal listeParticipant As List(Of Integer))
        If listeParticipant.Count <> 0 Then
            For i As Integer = 0 To listeParticipant.Count - 1
                Dim commandParSuppr = New OleDbCommand("DELETE * FROM Participant WHERE ID_participant=" & listeParticipant(i), myConnection)
                commandParSuppr.ExecuteNonQuery()
            Next
        End If
    End Sub




    ' --------------------------------------- FONCTIONS GESTION APP --------------------------------------- '
    ' Fermeture de la forme accueil
    Private Sub accueilForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        closeBDD()
        If My.Computer.FileSystem.FileExists(SIMonitact.My.Settings.PathBackupBDD.ToString & "\SIMonitactBDDBackup.accdb") Then
            My.Computer.FileSystem.DeleteFile(SIMonitact.My.Settings.PathBackupBDD.ToString & "\SIMonitactBDDBackup.accdb")
        End If
        My.Computer.FileSystem.CopyFile(SIMonitact.My.Settings.PathBDD.ToString & "\SIMonitactBDD.accdb", SIMonitact.My.Settings.PathBackupBDD.ToString & "\SIMonitactBDDBackup.accdb")
    End Sub

    ' Ouverture de la forme accueil
    Private Sub accueilForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If SIMonitact.My.Settings.PathBDD = "" Then
            SIMonitact.My.Settings.PathBDD = Application.StartupPath.ToString
        End If
        If SIMonitact.My.Settings.PathBackupBDD = "" Then
            SIMonitact.My.Settings.PathBackupBDD = Application.StartupPath.ToString
        End If
        If SIMonitact.My.Settings.PathExtractionBDD = "" Then
            SIMonitact.My.Settings.PathExtractionBDD = Application.StartupPath.ToString
        End If
        openBDD()
    End Sub

    ' Clique sur le boutton formulaire
    Private Sub saisirFormButton_Click(sender As Object, e As EventArgs) Handles saisirFormButton.Click
        ' Ouvre la form de saisie des formulaires et cache la form d'accueil
        formulaireForm.Show()
        Me.Hide()
    End Sub

    ' Clique sur le boutton export
    Private Sub exportButton_Click(sender As Object, e As EventArgs) Handles exportDataButton.Click
        ' Ouvre la form d'export des données et cache la form d'accueil
        exportForm.Show()
        Me.Hide()
    End Sub

    ' Clique sur le boutton bilan
    Private Sub genererBilanButton_Click(sender As Object, e As EventArgs) Handles genererBilanButton.Click
        ' Ouvre la form de création de bilan et cache la form d'accueil
        bilanForm.Show()
        Me.Hide()
    End Sub

    ' Clique sur le boutton modification formation
    Private Sub modifFormButton_Click(sender As Object, e As EventArgs) Handles modifFormButton.Click
        ' Ouvre la form de modif des formation et cache la form d'accueil
        modifFormForm.Show()
        Me.Hide()
    End Sub

    ' Clique sur le boutton settings de SIMonitact
    Private Sub paramettreButton_Click(sender As Object, e As EventArgs) Handles paramettreButton.Click
        ' Ouvre la form des paramètres de l'appli et cache la form d'accueil
        settingsForm.Show()
        Me.Hide()
    End Sub


End Class
