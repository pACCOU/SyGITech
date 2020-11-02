Public Class frm_liste_des_appel_par_client

    Private Sub frm_liste_des_appel_par_client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        ObjetCommand = cnx.CreateCommand
        Dim ds As New DataSet1
        ObjetCommand.CommandText = "select * from req_liste_des_appel_par_client"
        ds.Tables("ds_liste_des_appel_par_client").Load(ObjetCommand.ExecuteReader())
        If ds.Tables("ds_liste_des_appel_par_client").Rows.Count <= 0 Then
            MsgBox("Aucune donnée.", MsgBoxStyle.Information, " Attention !")
            Me.Close() : Exit Sub
        End If
        Dim cr As New cry_liste_des_appel_par_client
        cr.SetDataSource(ds.Tables("ds_liste_des_appel_par_client"))
        Me.CrystalReportViewer1.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class