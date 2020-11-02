Imports System.Data.SqlClient
Public Class GesFact
    Private Sub GesFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemplirGrille("Select NumFich,CodInterv,CodTach,DatFact,Dureff,Montant from FACTURER", Me.Dgv4)
        RemplirGrille("Select  CodTach,LibTach,DureTheo,CodTech from TACHE", Me.Dgv3)
        RemplirGrille("Select CodInterv,TypInterv,DatInterv, NumGroup from INTERVENTION", Me.Dgv2)
        RemplirGrille("Select NumFich,DatFich,NumSerie,Immat from FICHE", Me.Dgv1)
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub
    Private Sub Vider()
        Me.A.Text = ""
        Me.B.Text = ""
        Me.C.Text = ""
        Me.D.Text = ""
        Me.EE.Text = ""
        Me.F.Text = ""
        A.Focus()
    End Sub
    Private Sub Procédure1()
        Me.btn_Ajou.Enabled = True
        Me.btn_Mod.Enabled = False
        Me.btn_Sup.Enabled = False
    End Sub
    Private Sub btn_Ajou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ajou.Click
        If A.Text = "" Then
            MsgBox("Veuillez choisir le Numéro de la fiche en cliquant sur la fiche concernée dans la liste des fiches")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le code de l'intervention en cliquant sur l'intervention concernée dans la liste des interventions ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez choisir le code de la tâche en cliquant sur la tâche concernée dans la liste des tâches")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez le champ Date")
            D.Focus()
            Exit Sub
        ElseIf EE.Text = "" Then
            MsgBox("Veuillez le champ Durée effective")
            EE.Focus()
            Exit Sub
        ElseIf F.Text = "" Then
            MsgBox("Veuillez le champ Montant")
            F.Focus()
            Exit Sub
        End If
        instruction("Insert into FACTURER Values ('" & A.Text & "', '" & B.Text & "', '" & C.Text & "', '" & D.Text & "', '" & EE.Text & "', '" & F.Text & "')", EN)
        RemplirGrille("Select NumFich,CodInterv,CodTach,DatFact,Dureff,Montant from FACTURER", Me.Dgv4)
        Vider()
        Procédure1()
    End Sub
    Private Sub btn_Sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from FACTURER WHERE NumFich= '" & A.Text & "' and CodInterv= '" & B.Text & "' and CodTach= '" & C.Text & "'", SU)
            RemplirGrille("Select NumFich,CodInterv,CodTach,DatFact,Dureff,Montant from FACTURER", Me.Dgv4)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub
    Private Sub btn_Mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mod.Click
        If A.Text = "" Then
            MsgBox("Veuillez choisir le Numéro de la fiche en cliquant sur la fiche concernée dans la liste des fiches")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le code de l'intervention en cliquant sur l'intervention concernée dans la liste des interventions ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez choisir le code de la tâche en cliquant sur la tâche concernée dans la liste des tâches")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez le champ Date")
            D.Focus()
            Exit Sub
        ElseIf EE.Text = "" Then
            MsgBox("Veuillez le champ Durée effective")
            EE.Focus()
            Exit Sub
        ElseIf F.Text = "" Then
            MsgBox("Veuillez le champ Montant")
            F.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update FACTURER set '" & D.Value.Date & "',Dureff= '" & EE.Text & "',Montant= '" & F.Text & "' where  NumFich= '" & A.Text & "' and CodInterv= '" & B.Text & "' and CodTach= '" & C.Text & "'", MO)
            RemplirGrille("Select NumFich,CodInterv,CodTach,DatFact,Dureff,Montant from FACTURER", Me.Dgv4)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub
    Private Sub Dgv4_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv4.CellMouseClick
        A.Text = Dgv4.CurrentRow.Cells(0).Value
        B.Text = Dgv4.CurrentRow.Cells(1).Value
        C.Text = Dgv4.CurrentRow.Cells(2).Value
        D.Text = Dgv4.CurrentRow.Cells(3).Value
        EE.Text = Dgv4.CurrentRow.Cells(4).Value
        F.Text = Dgv4.CurrentRow.Cells(5).Value
        Me.btn_Ajou.Enabled = False
        Me.btn_Mod.Enabled = True
        Me.btn_Sup.Enabled = True
    End Sub
    Private Sub Dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseClick
        A.Text = Dgv1.CurrentRow.Cells(0).Value
    End Sub
    Private Sub Dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv2.CellMouseClick
        B.Text = Dgv2.CurrentRow.Cells(0).Value
    End Sub
    Private Sub Dgv3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv3.CellMouseClick
        C.Text = Dgv3.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = Now.ToLongTimeString
    End Sub

    Private Sub D_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles D.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub btn_Ferm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ferm.Click
        Me.Dispose()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class