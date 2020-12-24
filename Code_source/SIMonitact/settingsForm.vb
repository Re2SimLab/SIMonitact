Public Class settingsForm
    ' --------------------------------------- FONCTIONS GESTION APP --------------------------------------- '
    Private Sub annulerSettingsButton_Click(sender As Object, e As EventArgs) Handles annulerSettingsButton.Click
        ' Ferme la form des paramètres et affiche la form de l'accueil
        Me.Close()
    End Sub

    ' Gestion de la fermeture de la form
    Private Sub settingsForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' Ferme ré-ouvre l'accueil
        Application.Restart() 'Relance SIMonitact pour prendre en compte les changements
        accueilForm.Show()
    End Sub

    ' Gestion du lancement de la form
    Private Sub settingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Récupère les paramètres sauvegardés dans SIMonitact et les affiche
        pathBDDFolderBrowserDialog.SelectedPath = SIMonitact.My.Settings.PathBDD.ToString
        pathBDDTextBox.Text = My.Settings.PathBDD.ToString
        pathBackupBDDFolderBrowserDialog.SelectedPath = SIMonitact.My.Settings.PathBackupBDD.ToString
        pathBackupBDDTextBox.Text = SIMonitact.My.Settings.PathBackupBDD.ToString
        pathExtracFolderBrowserDialog.SelectedPath = SIMonitact.My.Settings.PathExtractionBDD.ToString
        pathExtracTextBox.Text = SIMonitact.My.Settings.PathExtractionBDD.ToString
        mdpTextBox.Text = SIMonitact.My.Settings.mdpBDD.ToString
    End Sub

    ' Gestion de la recherche du chemin d'accès la BDD
    Private Sub pathBDDSIMonitactButton_Click(sender As Object, e As EventArgs) Handles pathBDDSIMonitactButton.Click
        Dim result As DialogResult = pathBDDFolderBrowserDialog.ShowDialog
        If result = 1 Then
            pathBDDTextBox.Text = pathBDDFolderBrowserDialog.SelectedPath
        End If
    End Sub

    ' Gestion de la recherche du chemin d'accès la Backup de la BDD
    Private Sub pathBackupBDDButton_Click(sender As Object, e As EventArgs) Handles pathBackupBDDButton.Click
        Dim result As DialogResult = pathBackupBDDFolderBrowserDialog.ShowDialog
        If result = 1 Then
            pathBackupBDDTextBox.Text = pathBackupBDDFolderBrowserDialog.SelectedPath
        End If
    End Sub

    ' Gestion de la recherche du chemin d'accès aux extractions
    Private Sub pathExtracButton_Click(sender As Object, e As EventArgs) Handles pathExtracButton.Click
        Dim result As DialogResult = pathExtracFolderBrowserDialog.ShowDialog
        If result = 1 Then
            pathExtracTextBox.Text = pathExtracFolderBrowserDialog.SelectedPath
        End If
    End Sub



    ' ----------------------------------- FONCTIONS REMPLISSSAGE PATHS ----------------------------------- '
    ' Enregistrement des nouveaux paramètres dans l'application
    Private Sub saveSettingsButton_Click(sender As Object, e As EventArgs) Handles saveSettingsButton.Click
        ' Vérifie que les données rentrées sont correctes
        If My.Computer.FileSystem.DirectoryExists(pathBDDTextBox.Text) = False Or My.Computer.FileSystem.DirectoryExists(pathBackupBDDTextBox.Text) = False Or My.Computer.FileSystem.DirectoryExists(pathExtracTextBox.Text) = False Then
            MsgBox("Un ou plusieurs chemin(s) d'accès est incorrect. Veuillez vérifier les chemins d'accès renseigner.")
            Exit Sub
        ElseIf mdpTextBox.Text = "" Then

        Else
            SIMonitact.My.Settings.PathBDD = pathBDDTextBox.Text
            SIMonitact.My.Settings.PathBackupBDD = pathBackupBDDTextBox.Text
            SIMonitact.My.Settings.PathExtractionBDD = pathExtracTextBox.Text
            SIMonitact.My.Settings.mdpBDD = mdpTextBox.Text
            My.Settings.Save()
        End If
        Me.Close()
    End Sub

End Class