Imports System.Data.SqlClient
Public Class GesPériod
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = Now.ToLongTimeString
    End Sub

    Private Sub GesPériod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemplirGrille("Select CodInterv,NumCli,PeriodeGarantie from POSSEDER", Me.Dgv3)
        RemplirGrille("Select NumCli,NomCli,AdresCli,TelCli,TypCli,LieuInterv from CLIENT", Me.Dgv2)
        RemplirGrille("Select CodInterv,TypInterv,DatInterv, NumGroup from INTERVENTION", Me.Dgv1)
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub
    Private Sub Vider()
        Me.A.Text = ""
        Me.B.Text = ""
        Me.C.Text = ""
        A.Focus()
    End Sub
    Private Sub Procédure1()
        Me.btnAjou.Enabled = True
        Me.btnMod.Enabled = False
        Me.btnSup.Enabled = False
    End Sub

    Private Sub btnAjou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjou.Click
        If A.Text = "" Then
            MsgBox("Veuillez choisir le Code de l'intervention en cliquant sur l'intervention concernée dans la liste des interventions ")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le Numéro du client en cliquant sur le client concerné dans la liste des clients ")
            B.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le Numéro de serie en cliquant sur le matériel concerné dans la liste des matériels ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Période de garanties")
            C.Focus()
            Exit Sub
        End If
        instruction("Insert into POSSEDER Values ('" & A.Text & "', '" & B.Text & "', '" & C.Text & "')", EN)
        RemplirGrille("Select CodInterv,NumCli,PeriodeGarantie from POSSEDER", Me.Dgv3)
        Vider()
        Procédure1()
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from POSSEDER WHERE CodInterv= '" & A.Text & "'and NumCli= '" & B.Text & "'", SU)
            RemplirGrille("Select CodInterv,NumCli,PeriodeGarantie from POSSEDER", Me.Dgv3)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If A.Text = "" Then
            MsgBox("Veuillez choisir le Code de l'intervention en cliquant sur l'intervention concernée dans la liste des interventions ")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le Numéro du client en cliquant sur le client concerné dans la liste des clients ")
            B.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le Numéro de serie en cliquant sur le matériel concerné dans la liste des matériels ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Période de garanties")
            C.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update POSSEDER set PeriodeGarantie='" & C.Text & "'where CodInterv= '" & A.Text & "' And NumCli = '" & B.Text & "'", MO)
            RemplirGrille("Select CodInterv,NumCli,PeriodeGarantie from POSSEDER", Me.Dgv3)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub
    Private Sub Dgv3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv3.CellMouseClick
        A.Text = Dgv3.CurrentRow.Cells(0).Value
        B.Text = Dgv3.CurrentRow.Cells(1).Value
        C.Text = Dgv3.CurrentRow.Cells(2).Value
        Me.btnAjou.Enabled = False
        Me.btnMod.Enabled = True
        Me.btnSup.Enabled = True
    End Sub
    Private Sub Dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseClick
        A.Text = Dgv1.CurrentRow.Cells(0).Value
    End Sub
    Private Sub Dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv2.CellMouseClick
        B.Text = Dgv2.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnFerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFerm.Click
        Me.Close()
    End Sub
End Class