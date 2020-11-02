Public Class GesInterv
    Private Sub GesInterv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemplirGrille("Select CodInterv,TypInterv,DatInterv, NumGroup from INTERVENTION", Me.Dgv2)
        RemplirGrille("Select NumGroup,NomGroup,CodTech from GROUPE", Me.Dgv1)
        Incrémenter()
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub

    Private Sub btn_Ajou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ajou.Click
        If A.Text = "" Then
            MsgBox("Veuillez remplir le champ Code")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez remplir le champ Type")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Date")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez choisir le numéro du groupe en cliquant sur le groupe concerné dans la liste des groupes")
            D.Focus()
            Exit Sub
        End If
        instruction(" Insert into INTERVENTION Values ('" & A.Text & "', '" & B.Text & "', '" & C.Text & "','" & D.Text & "')", EN)
        RemplirGrille("Select CodInterv,TypInterv,DatInterv, NumGroup from INTERVENTION", Me.Dgv2)
        Vider()
        Incrémenter()
        Procédure1()
    End Sub

    Private Sub Dgv2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv2.CellContentClick
        A.Text = Dgv2.CurrentRow.Cells(0).Value
        B.Text = Dgv2.CurrentRow.Cells(1).Value
        C.Text = Dgv2.CurrentRow.Cells(2).Value
        D.Text = Dgv2.CurrentRow.Cells(3).Value
        Procédure2()
    End Sub
    Private Sub Dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseClick
        D.Text = Dgv1.CurrentRow.Cells(2).Value
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
        Me.B.Focus()
    End Sub
    Private Sub Procédure2()
        Me.btn_Ajou.Enabled = False
        Me.btn_Mod.Enabled = True
        Me.btn_Sup.Enabled = True
    End Sub
    Private Sub Incrémenter()
        A.Text = incrémenter_Alpha_numérique("INTERVENTION", "CodInterv", "I")
    End Sub
    Private Sub btn_Sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from INTERVENTION WHERE CodInterv= '" & recup(A.Text) & "'", SU)
            RemplirGrille("Select CodInterv,TypInterv,DatInterv, NumGroup from INTERVENTION", Me.Dgv2)
            Vider()
            Incrémenter()
            Procédure1()
        Else
            Vider()
            Incrémenter()
            Procédure1()
        End If
    End Sub
    Private Sub btn_Mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mod.Click
        If A.Text = "" Then
            MsgBox("Veuillez remplir le champ Code")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez remplir le champ Type")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Date")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez choisir le numéro du groupe en cliquant sur le groupe concerné dans la liste des groupes")
            D.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update INTERVENTION set TypInterv= '" & recup(B.Text) & "', DatInterv= '" & recup(C.Text) & "', NumGroup= '" & recup(D.Text) & "'where CodInterv= '" & recup(A.Text) & "'", MO)
            RemplirGrille("Select CodInterv,TypInterv,DatInterv, NumGroup from INTERVENTION", Me.Dgv2)
            Vider()
            Incrémenter()
            Procédure1()
        Else
            Vider()
            Incrémenter()
            Procédure1()
        End If
    End Sub

    Private Sub btn_Ferm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ferm.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label8.Text = Now.ToLongTimeString
    End Sub

    Private Sub C_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C.KeyPress
        e.KeyChar = ""
    End Sub
End Class