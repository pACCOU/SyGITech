Imports System.Data.SqlClient
Public Class connexion
    Dim s As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If login.Text = "" Then
            MsgBox("Veuillez saisir votre identifiant", MsgBoxStyle.Information, " Attention !")
            login.Focus()
            Exit Sub
        ElseIf Motpass.Text = "" Then
            MsgBox("Veuillez saisir votre mot de passe", MsgBoxStyle.Information, " Attention !")
            Motpass.Focus()
            Exit Sub
        End If
        If id_encour <> "" Then
            If id_encour <> login.Text Or pass_encour <> Motpass.Text Then
                MsgBox("Veuillez vous connecter avec l'identifiant et le mot de passe initial ou redémarrer le programme .", MsgBoxStyle.Critical, " Attention !")
                Exit Sub
            Else
                id_encour = login.Text
                pass_encour = Motpass.Text
                fermetur_application = False
                Menus.Show()
                Me.Close()
                Exit Sub
            End If
        End If
        parcourir("select Statut from UTILISATEUR where Login ='" & recup(login.Text) & "' and Motpasse='" & recup(Motpass.Text) & "'")

        dr = ObjetCommand.ExecuteReader
        If dr.Read Then
            recuperateur_de_statut = dr.GetString(0)
            dr.Close()
            id_encour = login.Text
            pass_encour = Motpass.Text
            fermetur_application = False
            If recuperateur_de_statut = "Autres utilisateurs" Then
                Menus.EditionDeLaListeDesPériodesDeGarantieToolStripMenuItem.Enabled = False
            Else
                Menus.EditionDeLaListeDesPériodesDeGarantieToolStripMenuItem.Enabled = True
            End If
            Labe4.Text = " Chargement de la session " & recuperateur_de_statut & " en cours... "
            'Labe4.Text = " Chargement de la session en cours... "
            Labe4.Visible = True
            Label1.Visible = True
            ProgressBar1.Visible = True
            ProgressBar1.Value = 3
            Timer1.Start()

        Else
            s = s + 1
            If s < 3 Then
                MsgBox("Nom d'utilisateur ou mot de passe incorrect", MsgBoxStyle.Critical, " Attention !")
                dr.Close()
            Else
                MsgBox("Vous avez atteint le nombre d'essai autorisé", MsgBoxStyle.Critical, " Attention !")
                End
            End If
        End If
    End Sub

    Private Sub connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        Menus.Show()
        Menus.Enabled = True
        Label1.Visible = False
        Labe4.Visible = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub connexion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If fermetur_application = True Then
            End
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dr As DialogResult = MessageBox.Show("Voulez-Vous réellement fermer SyGITech ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            End
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = ProgressBar1.Value & "%"
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Menus.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Motpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Motpass.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub

    Private Sub login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles login.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class