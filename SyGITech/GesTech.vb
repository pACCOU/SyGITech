Imports System.Data.SqlClient
Public Class GesTech
    Private Sub Tech_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        RemplirGrille("Select CodTech ,NomTech,PrenomTech,NumGroup from TECHNICIEN", Me.Dgv2)
        RemplirGrille("Select NumGroup,NomGroup from GROUPE", Me.Dgv1)
        incrémenter()
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub

    Private Sub Dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv2.CellMouseClick
        A.Text = Dgv2.CurrentRow.Cells(0).Value
        B.Text = Dgv2.CurrentRow.Cells(1).Value
        C.Text = Dgv2.CurrentRow.Cells(2).Value
        EE.Text = Dgv2.CurrentRow.Cells(3).Value
        Procédure2()
    End Sub

    Private Sub btn_Ajou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ajou.Click
        If A.Text = "" Then
            MsgBox("Veuillez remplir le champ Code")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez remplir le champ Nom")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Prénoms")
            C.Focus()
            Exit Sub
            'ElseIf EE.Text = "" Then
            '    MsgBox("Veuillez choisir le numéro du groupe en cliquant sur le groupe concerné dans la liste des groupes ")
            '    EE.Focus()
            '    Exit Sub
        End If
        instruction(" Insert into TECHNICIEN Values ('" & A.Text & "', '" & B.Text & "', '" & C.Text & "', '" & EE.Text & "')", EN)
        RemplirGrille("Select CodTech ,NomTech,PrenomTech,NumGroup from TECHNICIEN", Me.Dgv2)
        Incrémenter()
        Vider()
        Procédure1()
    End Sub
    Private Sub Dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseClick
        EE.Text = Dgv1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnFerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ferm.Click
        Me.Dispose()
    End Sub
    Private Sub Procédure1()
        Me.btn_Ajou.Enabled = True
        Me.btn_Mod.Enabled = False
        Me.btn_Sup.Enabled = False
    End Sub
    Private Sub Vider()
        Me.B.Text = ""
        Me.C.Text = ""
        Me.EE.Text = ""
        Me.B.Focus()
    End Sub
    Private Sub Procédure2()
        Me.btn_Ajou.Enabled = False
        Me.btn_Mod.Enabled = True
        Me.btn_Sup.Enabled = True
    End Sub
    Private Sub Incrémenter()
        A.Text = incrémenter_Alpha_numérique("TECHNICIEN", "CodTech", "T")
    End Sub

    Private Sub btn_Sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from TECHNICIEN WHERE CodTech= '" & recup(A.Text) & "'", SU)
            RemplirGrille("Select CodTech ,NomTech,PrenomTech,NumGroup from TECHNICIEN", Me.Dgv2)
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
            MsgBox("Veuillez remplir le champ Nom")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Prénoms")
            C.Focus()
            Exit Sub
        ElseIf EE.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro du groupe ")
            EE.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update TECHNICIEN set NomTech= '" & recup(B.Text) & "', PrenomTech= '" & recup(C.Text) & "',NumGroup= '" & EE.Text & "'where CodTech = '" & recup(A.Text) & "'", MO)
            RemplirGrille("Select CodTech ,NomTech,PrenomTech,NumGroup from TECHNICIEN", Me.Dgv2)
            Vider()
            Incrémenter()
            Procédure1()
        Else
            Vider()
            Incrémenter()
            Procédure1()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label8.Text = Now.ToLongTimeString
    End Sub
End Class
