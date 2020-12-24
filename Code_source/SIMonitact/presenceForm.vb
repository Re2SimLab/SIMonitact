Public Class presenceForm

    ' --------------------------------------- FONCTIONS GESTION APP --------------------------------------- '
    ' Gestion du bouton fermer la Form : retour sur la Form du formulaire
    Private Sub formulaireForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        formulaireForm.Show()
        formulaireForm.Enabled = True
    End Sub

    ' Gestion du bouton annuler : retour sur la Form du formulaire
    Private Sub annulerPresenceButton_Click(sender As Object, e As EventArgs) Handles annulerPresenceButton.Click
        formulaireForm.Show()
        formulaireForm.Enabled = True
        Me.Close()
    End Sub


    ' ------------------------------------ FONCTIONS GESTION CONTROLES ------------------------------------ '
    ' Initialisation de la Form et de ses controles
    Private Sub presenceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pour chaque DJ: créer un  onglet, ajouter les formateurs, aide-formateurs et participants et checker checkbox par defaut
        ' Si la form est ouverte en mode modification d'une formation, réassocier les formateurs/aide-formateurs/participants à leur DJ
        For i As Integer = 1 To formulaireForm.listeDJ.Count
            ' Crée l'onglet de la demi-journée
            Dim tabpage As New TabPage
            tabpage.Name = "presence" + i.ToString() + "TabPage"
            tabpage.Text = formulaireForm.listeDJ(i - 1).dateDJ.ToString + " - " + formulaireForm.listeDJ(i - 1).AMPM

            ' Ajoute un panel
            Dim pan As New Panel
            pan.Name = "presence" + i.ToString() + "Panel"
            pan.BackColor = Color.White
            pan.Parent = tabpage
            pan.Dock = DockStyle.Fill
            tabpage.Controls.Add(pan)

            ' Ajoute le label Formateur
            Dim lbl1 As New Label
            lbl1.Name = "formateur" & i.ToString() & "Label"
            lbl1.AutoSize = True
            lbl1.Text = "Formateurs :"
            lbl1.ForeColor = Color.Teal
            lbl1.Font = New Font("Arial", 9.75)
            lbl1.Left = 16
            lbl1.Top = 20
            lbl1.Visible = True
            pan.Controls.Add(lbl1) ' ajoute le Label

            ' Ajoute le label Aide-Formateur
            Dim lbl3 As New Label
            lbl3.Name = "aideForm" & i.ToString() & "Label"
            lbl3.AutoSize = True
            lbl3.Text = "Aide-formateurs :"
            lbl3.ForeColor = Color.Teal
            lbl3.Font = New Font("Arial", 9.75)
            lbl3.Left = 16
            lbl3.Top = 207
            lbl3.Visible = True
            pan.Controls.Add(lbl3) ' ajoute le Label

            ' Ajoute le label Participant
            Dim lbl2 As New Label
            lbl2.Name = "participant" & i.ToString() & "Label"
            lbl2.AutoSize = True
            lbl2.Text = "Participants :"
            lbl2.ForeColor = Color.Teal
            lbl2.Font = New Font("Arial", 9.75)
            lbl2.Left = 495
            lbl2.Top = 20
            lbl2.Visible = True
            pan.Controls.Add(lbl2) ' ajoute le Label

            ' Ajoute la CheckedListBox des formateurs
            Dim cbl1 As New CheckedListBox
            cbl1.Name = "formateur" & i.ToString() & "CheckedListBox"
            cbl1.Left = 19
            cbl1.Top = 45
            cbl1.Width = 415
            cbl1.Height = 140
            cbl1.Visible = True
            For j As Integer = 1 To formulaireForm.listeFormateur.Count
                cbl1.Items.Add(formulaireForm.listeFormateur(j - 1).ID + " - " + formulaireForm.listeFormateur(j - 1).prenom + " " + formulaireForm.listeFormateur(j - 1).nom)
                cbl1.SetItemChecked(j - 1, True)
            Next
            ' Si form ouverte en mode modification d'une formation : refaire les liens DJ/formateurs
            If formulaireForm.modifForm And formulaireForm.dtDJ.Select("ID_DJ = " & formulaireForm.listeDJ(i - 1).ID).Count <> 0 Then
                If formulaireForm.dtDJ.Select("ID_DJ = " & formulaireForm.listeDJ(i - 1).ID).First.Item("nb_formateur").ToString <> formulaireForm.listeFormateur.Count.ToString Then
                    Dim command = New OleDbCommand("SELECT ID_formateur FROM DJFormateur WHERE ID_DJ = " & formulaireForm.listeDJ(i - 1).ID, accueilForm.myConnection)
                    Dim idFormateur As New List(Of Integer)
                    Dim rdr = command.ExecuteReader
                    While rdr.Read()
                        If idFormateur.Contains(rdr.GetValue(0)) = False Then
                            idFormateur.Add(rdr.GetValue(0))
                        End If
                    End While
                    For k As Integer = 0 To cbl1.Items.Count - 1
                        If idFormateur.Contains(Split(cbl1.Items(k).ToString, " - ")(0)) = False Then
                            cbl1.SetItemChecked(k, False)
                        End If
                    Next
                End If
            End If
            pan.Controls.Add(cbl1) ' ajoute la CheckedListBox

            ' Ajoute la CheckedListBox des aide-formateurs
            Dim cbl3 As New CheckedListBox
            cbl3.Name = "aideForm" & i.ToString() & "CheckedListBox"
            cbl3.Left = 19
            cbl3.Top = 232
            cbl3.Width = 415
            cbl3.Height = 140
            cbl3.Visible = True
            For j As Integer = 1 To formulaireForm.listeAideFormateur.Count
                cbl3.Items.Add(formulaireForm.listeAideFormateur(j - 1).ID + " - " + formulaireForm.listeAideFormateur(j - 1).prenom + " " + formulaireForm.listeAideFormateur(j - 1).nom)
                cbl3.SetItemChecked(j - 1, True)
            Next
            ' Si form ouverte en mode modification d'une formation : refaire les liens DJ/aide-formateurs
            If formulaireForm.modifForm And formulaireForm.dtDJ.Select("ID_DJ = " & formulaireForm.listeDJ(i - 1).ID).Count <> 0 Then
                If formulaireForm.dtDJ.Select("ID_DJ = " & formulaireForm.listeDJ(i - 1).ID).First.Item("nb_aide_formateur").ToString <> formulaireForm.listeAideFormateur.Count.ToString Then
                    Dim command = New OleDbCommand("SELECT ID_aide_formateur FROM DJAideFormateur WHERE ID_DJ = " & formulaireForm.listeDJ(i - 1).ID, accueilForm.myConnection)
                    Dim idAideForm As New List(Of Integer)
                    Dim rdr = command.ExecuteReader
                    While rdr.Read()
                        If idAideForm.Contains(rdr.GetValue(0)) = False Then
                            idAideForm.Add(rdr.GetValue(0))
                        End If
                    End While
                    For k As Integer = 0 To cbl3.Items.Count - 1
                        If idAideForm.Contains(Split(cbl3.Items(k).ToString, " - ")(0)) = False Then
                            cbl3.SetItemChecked(k, False)
                        End If
                    Next
                End If
            End If
            pan.Controls.Add(cbl3) ' ajoute la CheckedListBox

            ' Ajoute la CheckedListBox des participants
            Dim cbl2 As New CheckedListBox
            cbl2.Name = "participant" & i.ToString() & "CheckedListBox"
            cbl2.Left = 498
            cbl2.Top = 45
            cbl2.Width = 415
            cbl2.Height = 327
            cbl2.Visible = True
            For j As Integer = 1 To formulaireForm.listeParticipant.Count
                cbl2.Items.Add(formulaireForm.listeParticipant(j - 1).ID + " - " + formulaireForm.listeParticipant(j - 1).prenom + " " + formulaireForm.listeParticipant(j - 1).nom)
                cbl2.SetItemChecked(j - 1, True)
            Next
            ' ' Si form ouverte en mode modification d'une formation : refaire les liens DJ/participants
            If formulaireForm.modifForm And formulaireForm.dtDJ.Select("ID_DJ = " & formulaireForm.listeDJ(i - 1).ID).Count <> 0 Then
                If formulaireForm.dtDJ.Select("ID_DJ = " & formulaireForm.listeDJ(i - 1).ID).First.Item("nb_participant").ToString <> formulaireForm.listeParticipant.Count.ToString Then
                    Dim command = New OleDbCommand("SELECT ID_participant FROM DJParticipant WHERE ID_DJ = " & formulaireForm.listeDJ(i - 1).ID, accueilForm.myConnection)
                    Dim idParticipant As New List(Of Integer)
                    Dim rdr = command.ExecuteReader
                    While rdr.Read()
                        If idParticipant.Contains(rdr.GetValue(0)) = False Then
                            idParticipant.Add(rdr.GetValue(0))
                        End If
                    End While
                    For k As Integer = 0 To cbl2.Items.Count - 1
                        If idParticipant.Contains(Split(cbl2.Items(k).ToString, " - ")(0)) = False Then
                            cbl2.SetItemChecked(k, False)
                        End If
                    Next
                End If
            End If
            pan.Controls.Add(cbl2) ' ajoute la CheckedListBox

            ' Ajoute l'onglet au TabControl
            presenceTabControl.TabPages.Add(tabpage)
        Next

        ' Supprime le premier onglet qui était utilisé pour la création du TabControl
        presenceTabControl.TabPages.RemoveByKey("presenceTabPage")
    End Sub

    ' Enregistrer la formation
    Private Sub validerPresenceButton_Click(sender As Object, e As EventArgs) Handles validerPresenceButton.Click
        ' Pour chaque DJ : vérifie les associations formateurs/aide-formateurs/participants avec la DJ et les enregistre
        For i As Integer = 1 To formulaireForm.listeDJ.Count
            Dim cbl1 As New CheckedListBox
            cbl1 = Me.Controls.Find("formateur" & i.ToString() & "CheckedListBox", True).FirstOrDefault()
            Dim cbl2 As New CheckedListBox
            cbl2 = Me.Controls.Find("aideForm" & i.ToString() & "CheckedListBox", True).FirstOrDefault()
            Dim cbl3 As New CheckedListBox
            cbl3 = Me.Controls.Find("participant" & i.ToString() & "CheckedListBox", True).FirstOrDefault()

            ' Vérifie qu'au moins un item soit coché
            If cbl1.CheckedItems.Count + cbl2.CheckedItems.Count = 0 Then
                MsgBox("Veuillez sélectionner au moins un formateur ou aide-formateur par demi-journée.", MsgBoxStyle.OkOnly, "Erreur")
                Exit Sub
            End If
            If cbl3.CheckedItems.Count = 0 Then
                MsgBox("Veuillez sélectionner au moins un participant par demi-journée.", MsgBoxStyle.OkOnly, "Erreur")
                Exit Sub
            End If

            ' Ajoute les formateurs à la DJ 
            formulaireForm.listeDJ(i - 1).nb_formateur = cbl1.CheckedItems.Count
            formulaireForm.listeDJ(i - 1).liste_formateur.Clear()
            If cbl1.CheckedItems.Count <> 0 Then
                For j As Integer = 1 To cbl1.Items.Count
                    If cbl1.GetItemChecked(j - 1) Then
                        Dim str As New List(Of String)(Split(cbl1.Items(j - 1).ToString, " - "))
                        formulaireForm.listeDJ(i - 1).liste_formateur.Add(formulaireForm.listeFormateur.Find(Function(c) c.ID = str(0)))
                    End If
                Next
            End If

            ' Ajoute les aide-formateurs à la DJ  
            formulaireForm.listeDJ(i - 1).nb_aide_formateur = cbl2.CheckedItems.Count
            formulaireForm.listeDJ(i - 1).liste_aide_formateur.Clear()
            If cbl2.CheckedItems.Count <> 0 Then
                For j As Integer = 1 To cbl2.Items.Count
                    If cbl2.GetItemChecked(j - 1) Then
                        Dim str As New List(Of String)(Split(cbl2.Items(j - 1).ToString, " - "))
                        formulaireForm.listeDJ(i - 1).liste_aide_formateur.Add(formulaireForm.listeAideFormateur.Find(Function(c) c.ID = str(0)))
                    End If
                Next
            End If

            ' Ajoute les participants à la DJ 
            formulaireForm.listeDJ(i - 1).nb_participant = cbl3.CheckedItems.Count
            formulaireForm.listeDJ(i - 1).liste_participant.Clear()
            If cbl3.CheckedItems.Count <> 0 Then
                For j As Integer = 1 To cbl3.Items.Count
                    If cbl3.GetItemChecked(j - 1) Then
                        Dim str As New List(Of String)(Split(cbl3.Items(j - 1).ToString, " - "))
                        formulaireForm.listeDJ(i - 1).liste_participant.Add(formulaireForm.listeParticipant.Find(Function(c) c.ID = str(0)))
                    End If
                Next
            End If
        Next

        ' Associe la liste des DJ (dans laquelle chaque DJ a sa liste de formateurs/aide-formateurs/participants) à la formation
        formulaireForm.newFormation.liste_DJ = formulaireForm.listeDJ


        ' Lance la fonction d'écriture dans la BDD ou de suppression puis écriture si la form est ouverte en mode 'modification'
        If formulaireForm.modifForm Then
            accueilForm.supprFormationAllBDD(formulaireForm.IDModifForm)
            accueilForm.addFormationAllBDD(formulaireForm.newFormation, formulaireForm.listeFormateur, formulaireForm.listeAideFormateur, formulaireForm.listeParticipant)
            MsgBox("Formation a bien été modifiée dans la base de données.", MsgBoxStyle.OkOnly, "Formation modifiée")
        Else
            accueilForm.addFormationAllBDD(formulaireForm.newFormation, formulaireForm.listeFormateur, formulaireForm.listeAideFormateur, formulaireForm.listeParticipant)
            MsgBox("Formation enregistrée dans la base de données.", MsgBoxStyle.OkOnly, "Formation validée")
        End If

        ' Fermeture de la Form
        Me.Close()
        formulaireForm.Enabled = True
        formulaireForm.Close()
        accueilForm.Show()
    End Sub

End Class