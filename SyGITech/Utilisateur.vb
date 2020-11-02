Imports System.Data.SqlClient
Public Class Utilisateur
    Private Sub Enrégistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enrégistrer.Click
        If (Me.nom.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Nom")
            Me.nom.Focus()
            Exit Sub
        End If
        If (Me.prenom.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Prénom")
            Me.prenom.Focus()
            Exit Sub
        End If

        If (Me.id.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Identifiant")
            Me.id.Focus()
            Exit Sub
        End If


        If (Me.mp.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Mot de passe")
            Me.mp.Focus()
            Exit Sub
        End If


        If (Me.cp.Text = "") Then
            MessageBox.Show("Veuillez confirmer le mot de passe")
            Me.cp.Focus()
            Exit Sub
        ElseIf (Me.stat.Text = "") Then
            MessageBox.Show("Veuillez choisir un statut")
            Exit Sub
        End If

        If mp.Text <> cp.Text Then
            MsgBox("les deux mots de passes ne correspondent pas..", MsgBoxStyle.Critical)
            Me.mp.Text = ""
            Me.cp.Text = ""
            Me.mp.Focus()
            Exit Sub
        End If
        Dim rep As DialogResult = MessageBox.Show("Confirmez vous cet enregistrement ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (rep = Windows.Forms.DialogResult.Yes) Then
            ' se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
            instruction("insert into UTILISATEUR values('" & id.Text & "','" & mp.Text & "','" & nom.Text & "','" & prenom.Text & "','" & Stat.Text & "')", EN)
            Me.nom.Text = ""
            Me.prenom.Text = ""
            Me.id.Text = ""
            Me.mp.Text = ""
            Me.cp.Text = ""
            Me.nom.Focus()

        End If
    End Sub
    Private Sub nom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nom.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(Asc("à"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub prenom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prenom.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub mp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mp.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cp.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub

    Private Sub frmUtilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Top = 108
        Me.Left = 310

        Me.nom.Text = ""
        Me.prenom.Text = ""
        Me.id.Text = ""
        Me.mp.Text = ""
        Me.cp.Text = ""
        Me.nom.Focus()
    End Sub
    Private Sub stat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Stat.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fermer.Click
        Me.Dispose()
    End Sub
End Class