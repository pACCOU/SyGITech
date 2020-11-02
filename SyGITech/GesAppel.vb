Imports System.Data.SqlClient
Public Class GesAppel
    Private Sub GesAppel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        RemplirGrille("Select NumAppel,DatAppel,HeureAppel,DureAppel,CodTech,NumCli from APPEL", Me.Dgv3)
        RemplirGrille("Select CodTech,NomTech,PrenomTech from TECHNICIEN", Me.Dgv2)
        RemplirGrille("Select NumCli,NomCli,AdresCli,TelCli,TypCli,LieuInterv from CLIENT", Me.Dgv1)
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub
    Private Sub Procédure1()
        Me.btn_Ajou.Enabled = True
        Me.btn_Mod.Enabled = False
        Me.btn_Sup.Enabled = False
    End Sub
    Private Sub Vider()
        Me.A.Text = ""
        Me.B.Text = ""
        Me.C.Text = ""
        Me.D.Text = ""
        Me.EE.Text = ""
        Me.F.Text = ""
        Me.A.Focus()
    End Sub
    Private Sub Procédure2()
        Me.btn_Ajou.Enabled = False
        Me.btn_Mod.Enabled = True
        Me.btn_Sup.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = Now.ToLongTimeString
    End Sub
    Private Sub Dgv3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv3.CellMouseClick
        A.Text = Dgv3.CurrentRow.Cells(0).Value
        D.Text = Dgv3.CurrentRow.Cells(1).Value
        EE.Text = Dgv3.CurrentRow.Cells(2).Value
        F.Text = Dgv3.CurrentRow.Cells(3).Value
        B.Text = Dgv3.CurrentRow.Cells(4).Value
        C.Text = Dgv3.CurrentRow.Cells(5).Value
        Procédure2()
    End Sub
    Private Sub Dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv2.CellMouseClick
        B.Text = Dgv2.CurrentRow.Cells(0).Value
    End Sub
    Private Sub Dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseClick
        C.Text = Dgv1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btn_Ajou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ajou.Click
        If A.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro")
            A.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez remplir le champ Date")
            D.Focus()
            Exit Sub
        ElseIf EE.Text = "" Then
            MsgBox("Veuillez remplir le champ Heure")
            EE.Focus()
            Exit Sub
        ElseIf F.Text = "" Then
            MsgBox("Veuillez remplir le champ Durée")
            F.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez remplir le champ Code du technicien en cliquant sur le technicien concerné dans la liste des techniciens ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro du client en cliquant sur le client concerné dans la liste des clients")
            C.Focus()
            Exit Sub
        End If
        instruction(" Insert into APPEL Values ('" & A.Text & "', '" & D.Value.Date & "', '" & EE.Text & "', '" & F.Text & "','" & B.Text & "','" & C.Text & "')", EN)
        RemplirGrille("Select NumAppel,DatAppel,HeureAppel,DureAppel,CodTech,NumCli from APPEL", Me.Dgv3)
        Vider()
        Procédure1()
    End Sub

    Private Sub A_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles A.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("+"))
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub

    Private Sub btn_Sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from APPEL WHERE NumAppel= '" & A.Text & "'", SU)
            RemplirGrille("Select NumAppel,DatAppel,HeureAppel,DureAppel,CodTech,NumCli from APPEL", Me.Dgv3)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub

    Private Sub btn_Mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mod.Click
        If A.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro")
            A.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez remplir le champ Date")
            D.Focus()
            Exit Sub
        ElseIf EE.Text = "" Then
            MsgBox("Veuillez remplir le champ Heure")
            EE.Focus()
            Exit Sub
        ElseIf F.Text = "" Then
            MsgBox("Veuillez remplir le champ Durée")
            F.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez remplir le champ Code du technicien en cliquant sur le technicien concerné dans la liste des techniciens ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro du client en cliquant sur le client concerné dans la liste des clients")
            C.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update APPEL set '" & D.Value.Date & "', HeureAppel= '" & recup(EE.Text) & "', DureAppel= '" & recup(F.Text) & "', CodTech= '" & B.Text & "', NumCli= '" & C.Text & "'where NumAppel= '" & recup(A.Text) & "'", MO)
            RemplirGrille("Select NumAppel,DatAppel,HeureAppel,DureAppel,CodTech,NumCli from APPEL", Me.Dgv3)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub

    Private Sub btn_Ferm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ferm.Click
        Me.Close()
    End Sub

    Private Sub D_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles D.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class