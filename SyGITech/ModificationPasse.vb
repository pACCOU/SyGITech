Imports System.Data.SqlClient
Public Class ModificationPasse
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        Me.Top = 108
        Me.Left = 310
        Me.id.Text = ""
        Me.anc.Text = ""
        Me.np.Text = ""
        Me.cp.Text = ""
        Me.id.Focus()

    End Sub

    Private Sub valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Valider.Click
        If id.Text = "" Then
            MsgBox(" Veuillez saisir l'identifiant ")
            Exit Sub
        End If
        If anc.Text = "" Then
            MsgBox(" Veuillez saisir l'ancien mot de passe ")
            Exit Sub
        End If
        If np.Text <> cp.Text Then
            MsgBox("Confirmation du mot de passe non conforme")
            cp.Focus()
        ElseIf np.Text = "" Or cp.Text = "" Then
            MsgBox("Veuillez saisir et confirmer le mot de passe")
        Else
            parcourir("select * from Utilisateur where Login ='" & id.Text & "' and Motpasse='" & anc.Text & "'")
            Dim dr As SqlDataReader = ObjetCommand.ExecuteReader
            If dr.Read Then
                dr.Close()
                instruction("update UTILISATEUR set Motpasse='" & np.Text & "' where Login ='" & id.Text & "' and Motpasse='" & anc.Text & "'", MO)
                Me.id.Text = ""
                Me.anc.Text = ""
                Me.np.Text = ""
                Me.id.Text = ""
                Me.cp.Text = ""
                Me.id.Focus()
            Else
                MsgBox(" Identifiant ou l'ancien mot de passe incorrect", MsgBoxStyle.Exclamation)
                id.Focus()
            End If
        End If
    End Sub

    Private Sub initialiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.id.Text = ""
        Me.anc.Text = ""
        Me.np.Text = ""
        Me.id.Text = ""
        Me.cp.Text = ""
        Me.id.Focus()
    End Sub

    Private Sub fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub initialiser_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.id.Text = ""
        Me.anc.Text = ""
        Me.np.Text = ""
        Me.cp.Text = ""
        Me.id.Focus()
    End Sub

    Private Sub id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
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

    Private Sub id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id.TextChanged

    End Sub

    Private Sub anc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles anc.KeyPress
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

    Private Sub anc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anc.TextChanged

    End Sub

    Private Sub np_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles np.KeyPress
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

    Private Sub np_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles np.TextChanged

    End Sub

    Private Sub cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cp.KeyPress
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
    Private Sub fermer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fermer.Click
        Me.Dispose()
    End Sub
End Class