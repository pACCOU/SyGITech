Imports System.Data.SqlClient
Public Class GesCli
    Private Sub GesCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        RemplirGrille("Select NumCli,NomCli,AdresCli,TelCli,TypCli,LieuInterv from CLIENT", Me.Dgv)
        Incrémenter()
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub
    Private Sub D_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles D.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("+"))
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub btn_sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete  from CLIENT WHERE NumCli= '" & A.Text & "'", SU)
            RemplirGrille("Select NumCli,NomCli,AdresCli,TelCli,TypCli,LieuInterv from CLIENT", Me.Dgv)
            Vider()
            Incrémenter()
            Procédure1()
        Else
            Vider()
            Incrémenter()
            Procédure1()
        End If
    End Sub

    Private Sub btn_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod.Click
        If B.Text = "" Then
            MsgBox("Veuillez remplir le champ Nom")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Adresse")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez remplir le champ téléphone")
            D.Focus()
            Exit Sub
        ElseIf E1.Text = "" Then
            MsgBox("Veuillez remplir le champ Type de Client ")
            E1.Focus()
            Exit Sub
        ElseIf F.Text = "" Then
            MsgBox("Veuillez remplir le champ Lieu d'intervention")
            F.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update CLIENT set NomCli= '" & B.Text & "', AdresCli= '" & C.Text & "', TelCli= '" & D.Text & "', TypCli= '" & E1.Text & "', LieuInterv='" & F.Text & "'where NumCli= '" & A.Text & "'", MO)
            RemplirGrille("Select NumCli,NomCli,AdresCli,TelCli,TypCli,LieuInterv from CLIENT", Me.Dgv)
            Vider()
            Incrémenter()
            Procédure1()
        Else
            Vider()
            Incrémenter()
            Procédure1()
        End If
    End Sub

    Private Sub btn_ajou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ajou.Click
        If B.Text = "" Then
            MsgBox("Veuillez remplir le champ Nom")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Adresse")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez remplir le champ téléphone")
            D.Focus()
            Exit Sub
        ElseIf E1.Text = "" Then
            MsgBox("Veuillez remplir le champ Type de Client ")
            E1.Focus()
            Exit Sub
        ElseIf F.Text = "" Then
            MsgBox("Veuillez remplir le champ Lieu d'intervention")
            F.Focus()
            Exit Sub
        End If
        instruction(" Insert into CLIENT Values ('" & A.Text & "', '" & recup(B.Text) & "', '" & recup(C.Text) & "', '" & D.Text & "', '" & E1.Text & "', '" & recup(F.Text) & "')", EN)
        RemplirGrille("Select NumCli,NomCli,AdresCli,TelCli,TypCli,LieuInterv from CLIENT", Me.Dgv)
        Vider()
        Incrémenter()
        Procédure1()
    End Sub
    Private Sub Dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv.CellMouseClick
        A.Text = Dgv.CurrentRow.Cells(0).Value
        B.Text = Dgv.CurrentRow.Cells(1).Value
        C.Text = Dgv.CurrentRow.Cells(2).Value
        D.Text = Dgv.CurrentRow.Cells(3).Value
        E1.Text = Dgv.CurrentRow.Cells(4).Value
        F.Text = Dgv.CurrentRow.Cells(5).Value
        Procédure2()
    End Sub

    Private Sub btn_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fer.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label9.Text = Now.ToLongTimeString
    End Sub

    Private Sub E1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles E1.KeyPress
        e.KeyChar = ""
    End Sub
    Private Sub Procédure1()
        Me.btn_ajou.Enabled = True
        Me.btn_mod.Enabled = False
        Me.btn_sup.Enabled = False
    End Sub
    Private Sub Vider()
        Me.B.Text = ""
        Me.C.Text = ""
        Me.D.Text = ""
        Me.E1.Text = ""
        Me.F.Text = ""
        Me.B.Focus()
    End Sub
    Private Sub Procédure2()
        Me.btn_ajou.Enabled = False
        Me.btn_mod.Enabled = True
        Me.btn_sup.Enabled = True
    End Sub
    Private Sub Incrémenter()
        A.Text = incrémenter_Alpha_numérique("CLIENT", "NumCli", "C")
    End Sub

    Private Sub F_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles F.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub D_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D.TextChanged

    End Sub
End Class
