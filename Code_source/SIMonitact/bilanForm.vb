
Public Class bilanForm
    ' -------------------------------------------- VARIABLES -------------------------------------------- '
    ' Lecture des tables de la BDD
    ' Formation 
    Public Shared strFormation As String = "SELECT * FROM Formation"
    Public Shared dtFormation As New DataTable
    Public Shared daFormation As New OleDbDataAdapter(strFormation, accueilForm.myConnection)

    ' DJ
    Public Shared strDJ As String = "SELECT DISTINCT Count(ID_DJ) AS nb_DJ, Sum(nb_formateur) AS nb_tot_formateur, Avg(nb_formateur) AS moy_formateur, Sum(nb_aide_formateur) AS nb_tot_aide_formateur, Avg(nb_aide_formateur) AS moy_aide_formateur, Sum(nb_participant) AS nb_tot_participant, Avg(nb_participant) AS moy_participant FROM DJ"
    Public Shared dtDJ As New DataTable
    Public Shared daDJ As New OleDbDataAdapter(strDJ, accueilForm.myConnection)


    ' --------------------------------------- FONCTIONS GESTION APP --------------------------------------- '
    ' Gestion de la fermeture de la form
    Private Sub titreForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' Ferme ré-ouvre l'accueil
        Application.Restart() 'Relance SIMOnitact pour prendre en compte les modifs faites à la BDD
        accueilForm.Show()
    End Sub

    ' Gestion du lancement de la form
    Private Sub bilanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Chargement des données 
        daFormation.Fill(dtFormation)
        daDJ.Fill(dtDJ)

        ' Ajoute les data au reportviewer
        Dim DJrds = New ReportDataSource("bilanDataSet", dtDJ)
        Dim FormationRDS = New ReportDataSource("formationDataSet", dtFormation)
        bilanReportViewer.LocalReport.DataSources.Add(DJrds)
        bilanReportViewer.LocalReport.DataSources.Add(FormationRDS)
        bilanReportViewer.LocalReport.ReportEmbeddedResource = "SIMonitact.bilanReport.rdlc"
        bilanReportViewer.RefreshReport()

        ' MàJ des dates
        Dim annee As Integer = System.DateTime.Today.Year
        periodeDebDateTimePicker.Value = "01/01/" & annee
        periodeFinDateTimePicker.Value = "31/12/" & annee
    End Sub


    ' ------------------------------------- FONCTIONS CREATION BILAN ------------------------------------- '
    ' Créer un bilan d'activité
    Private Sub genererBilanButton_Click(sender As Object, e As EventArgs) Handles genererBilanButton.Click
        ' Vérifie que la date de fin de la période est après celle du début
        If periodeFinDateTimePicker.Value.Date <= periodeDebDateTimePicker.Value.Date Then
            MsgBox("Veuillez entrez une date de fin ultérieure à la date de début de la période.")
            Exit Sub
        End If

        ' Mise à jour de la période
        Dim bilanRPC As New ReportParameterCollection
        bilanRPC.Add(New ReportParameter("titreParameter", "Bilan d'activité pour la période du " & periodeDebDateTimePicker.Value.ToShortDateString & " au " & periodeFinDateTimePicker.Value.ToShortDateString))

        ' Mise à jour du tableau
        Dim strPeriode As String = " WHERE DJ.[date]>=#" & periodeDebDateTimePicker.Value.Date.ToString("MM/dd/yyyy") & "# AND DJ.[date]<=#" & periodeFinDateTimePicker.Value.Date.ToString("MM/dd/yyyy") & "#"
        strDJ = "SELECT DISTINCT Count(ID_DJ) AS nb_DJ, Avg(nb_formateur) AS moy_formateur, Avg(nb_aide_formateur) AS moy_aide_formateur, Avg(nb_participant) AS moy_participant FROM DJ" & strPeriode
        Dim strForm As String = "SELECT COUNT(DJFormateur.ID_formateur) as nb_form FROM (SELECT DISTINCT DJFormateur.ID_formateur FROM DJ INNER JOIN DJFormateur ON DJ.[ID_DJ] = DJFormateur.[ID_DJ]" & strPeriode & ")"
        Dim strAideForm As String = "SELECT COUNT(DJAideFormateur.ID_aide_formateur) as nb_aide_form FROM (SELECT DISTINCT DJAideFormateur.ID_aide_formateur FROM DJ INNER JOIN DJAideFormateur ON DJ.[ID_DJ] = DJAideFormateur.[ID_DJ]" & strPeriode & ")"
        Dim strPar As String = "SELECT COUNT(DJParticipant.ID_participant) as nb_par FROM (SELECT DISTINCT DJParticipant.ID_participant FROM DJ INNER JOIN DJParticipant ON DJ.[ID_DJ] = DJParticipant.[ID_DJ]" & strPeriode & ")"
        Dim commandDJ = New OleDbCommand(strDJ, accueilForm.myConnection)
        Dim commandForm = New OleDbCommand(strForm, accueilForm.myConnection)
        Dim commandAideForm = New OleDbCommand(strAideForm, accueilForm.myConnection)
        Dim commandPar = New OleDbCommand(strPar, accueilForm.myConnection)
        Dim rdr = commandDJ.ExecuteReader
        Try
            While rdr.Read()
                bilanRPC.Add(New ReportParameter("nbDJParameter", rdr.GetValue(0).ToString))
                bilanRPC.Add(New ReportParameter("moyFormParameter", rdr.GetValue(1).ToString))
                bilanRPC.Add(New ReportParameter("moyAideFormParameter", rdr.GetValue(2).ToString))
                bilanRPC.Add(New ReportParameter("moyParParameter", rdr.GetValue(3).ToString))
            End While
            bilanRPC.Add(New ReportParameter("nbFormParameter", commandForm.ExecuteScalar.ToString))
            bilanRPC.Add(New ReportParameter("nbAideFormParameter", commandAideForm.ExecuteScalar.ToString))
            bilanRPC.Add(New ReportParameter("nbParParameter", commandPar.ExecuteScalar.ToString))
            bilanReportViewer.LocalReport.SetParameters(bilanRPC)
        Catch ex As Exception
            MsgBox("Aucune formation n'a été trouvée pour la période sélectionnée. Veuillez saisir une autre période.")
            Exit Sub
        Finally
            rdr.Close()
        End Try

        ' Mise à jour des graphs
        strFormation = "SELECT * FROM Formation WHERE [date_debut]>=#" & periodeDebDateTimePicker.Value.Date.ToString("MM/dd/yyyy") & "# AND [date_debut]<=#" & periodeFinDateTimePicker.Value.Date.ToString("MM/dd/yyyy") & "#"
        daFormation = New OleDbDataAdapter(strFormation, accueilForm.myConnection)
        dtFormation = New DataTable
        daFormation.Fill(dtFormation)
        Dim FormationRDS = New ReportDataSource("formationDataSet", dtFormation)
        Dim DJrds = New ReportDataSource("bilanDataSet", dtDJ)
        bilanReportViewer.LocalReport.DataSources.Clear()
        bilanReportViewer.LocalReport.DataSources.Add(FormationRDS)
        bilanReportViewer.LocalReport.DataSources.Add(DJrds)
        bilanReportViewer.LocalReport.ReportEmbeddedResource = "SIMonitact.bilanReport.rdlc"
        bilanReportViewer.Visible = True

        ' Actualisation du rapport
        bilanReportViewer.RefreshReport()
    End Sub

End Class