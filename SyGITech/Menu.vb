
Imports System.Data.SqlClient
Public Class Menus
    Private Sub défiler(ByVal x As Object, ByVal y As Object, ByVal direction As String, ByVal v As Integer)
        Select Case direction
            Case Is = "Gauche"
                x.left = IIf(x.left > -x.width, x.left - v, y.width)
        End Select
    End Sub
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Now.ToLongTimeString
        Label3.Text = Now.Date
    End Sub
    Private Sub GestionDesVéhiculesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesVéhiculesToolStripMenuItem.Click
        GesVeh.ShowDialog()
    End Sub

    Private Sub GestionDesClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesClientsToolStripMenuItem.Click
        GesCli.ShowDialog()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End

    End Sub

    Private Sub GestionDesTechniciensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesTechniciensToolStripMenuItem.Click
        GesTech.ShowDialog()
    End Sub

    Private Sub GestionDesMatérielsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesMatérielsToolStripMenuItem.Click
        GesMat.ShowDialog()
    End Sub

    Private Sub GestionDesFichesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesFichesToolStripMenuItem.Click
        GesFich.ShowDialog()
    End Sub

    Private Sub GestionDesInterventionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesInterventionsToolStripMenuItem.Click
        GesInterv.ShowDialog()
    End Sub

    Private Sub GestionDesGroupesDeTechniciensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesGroupesDeTechniciensToolStripMenuItem.Click
        GesGroup.ShowDialog()
    End Sub

    Private Sub GestionDesTâchesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesTâchesToolStripMenuItem.Click
        GesTach.ShowDialog()
    End Sub

    Private Sub EditionDeLaListeDesAppelsParClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditionDeLaListeDesAppelsParClientToolStripMenuItem.Click
        GesPro.ShowDialog()
    End Sub

    Private Sub GestionDesAppelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesAppelsToolStripMenuItem.Click
        GesAppel.ShowDialog()
    End Sub

    Private Sub GestionDesPériodesDeGarantiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QestionDesPériodesDeGarantiesToolStripMenuItem.Click
        GesPériod.ShowDialog()
    End Sub

    Private Sub GestionDesFacturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesFacturesToolStripMenuItem.Click
        GesFact.ShowDialog()
    End Sub

    Private Sub EditionDeLaListeDesPériodesDeGarantieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditionDeLaListeDesPériodesDeGarantieToolStripMenuItem.Click
        Utilisateur.ShowDialog()
    End Sub

    Private Sub EditionDeLaListeDesAppelsParClientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditionDeLaListeDesAppelsParClientToolStripMenuItem1.Click
        frm_liste_des_appel_par_client.ShowDialog()
    End Sub

    Private Sub EditionDeLaListeDesPériodesDeGarantieToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditionDeLaListeDesPériodesDeGarantieToolStripMenuItem1.Click
        frm_liste_des__periodes_de_garantie.ShowDialog()
    End Sub

    Private Sub tmrgauche_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrgauche.Tick
        Call défiler(pnlgauche1, pnlgauche2, "Gauche", 10)
    End Sub

    Private Sub OUTILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OUTILSToolStripMenuItem.Click

    End Sub

    Private Sub ModificationDunUtilisateurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationDunUtilisateurToolStripMenuItem.Click
        ModificationPasse.ShowDialog()
    End Sub

    Private Sub SuppressionDunUtilisateurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppressionDunUtilisateurToolStripMenuItem.Click
        Suppression.ShowDialog()
    End Sub

    Private Sub pnlgauche1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlgauche1.Paint

    End Sub

    Private Sub pnlgauche2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlgauche2.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class