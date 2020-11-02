Public Class frm_liste_des__periodes_de_garantie

    Private Sub frm_liste_des__periodes_de_garantie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        ObjetCommand = cnx.CreateCommand
        Dim ds As New DataSet1
        ObjetCommand.CommandText = "select * from req_périodes_de_garantie_par_client"
        ds.Tables("périodes_de_garanties").Load(ObjetCommand.ExecuteReader())
        If ds.Tables("périodes_de_garanties").Rows.Count <= 0 Then
            MsgBox("Aucune donnée.", MsgBoxStyle.Information, " Attention !")
            Me.Close() : Exit Sub
        End If
        Dim cr As New Cryst_periode_de_garentie_par_client
        cr.SetDataSource(ds.Tables("périodes_de_garanties"))
        Me.CrystalReportViewer1.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class