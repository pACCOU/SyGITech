Imports System.Data.SqlClient
Public Class GesMat
    Private Sub GesMat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        RemplirGrille("Select NumSerie,NomMat,Marque,Model,NumCli from MATERIEL", Me.Dgv2)
        RemplirGrille("Select NumCli,NomCli,AdresCli,TelCli,TypCli,LieuInterv from CLIENT", Me.Dgv1)
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub
    Private Sub btn_Ajou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ajou.Click
        If A.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro de serie")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez remplir le champ Nom")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Marque")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez remplir le champ Modèle")
            D.Focus()
            Exit Sub
        ElseIf EE.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro du Client ")
            EE.Focus()
            Exit Sub
        End If
        instruction(" Insert into MATERIEL Values ('" & recup(A.Text) & "', '" & recup(B.Text) & "', '" & recup(C.Text) & "', '" & recup(D.Text) & "', '" & EE.Text & "')", EN)
        RemplirGrille("Select NumSerie,NomMat,Marque,Model,NumCli from MATERIEL", Me.Dgv2)
        Vider()
        Procédure1()
    End Sub
    Private Sub Dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseClick
        EE.Text = Dgv1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv2.CellMouseClick
        A.Text = Dgv2.CurrentRow.Cells(0).Value
        B.Text = Dgv2.CurrentRow.Cells(1).Value
        C.Text = Dgv2.CurrentRow.Cells(2).Value
        D.Text = Dgv2.CurrentRow.Cells(3).Value
        EE.Text = Dgv2.CurrentRow.Cells(4).Value
        Procédure2()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ferm.Click
        Me.Close()
    End Sub
    Private Sub btn_Mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mod.Click
        If A.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro de serie")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez remplir le champ Nom")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez remplir le champ Marque")
            C.Focus()
            Exit Sub
        ElseIf D.Text = "" Then
            MsgBox("Veuillez remplir le champ Modèle")
            D.Focus()
            Exit Sub
        ElseIf EE.Text = "" Then
            MsgBox("Veuillez remplir le champ Numéro du Client ")
            EE.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update MATERIEL set NomMat= '" & recup(B.Text) & "', Marque= '" & recup(C.Text) & "', Model= '" & recup(D.Text) & "', NumCli= '" & EE.Text & "'where NumSerie= '" & recup(A.Text) & "'", MO)
            RemplirGrille("Select NumSerie,NomMat,Marque,Model,NumCli from MATERIEL", Me.Dgv2)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label8.Text = Now.ToLongTimeString
    End Sub
    Private Sub btn_Sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from MATERIEL WHERE NumSerie= '" & recup(A.Text) & "'", SU)
            RemplirGrille("Select NumSerie,NomMat,Marque,Model,NumCli from MATERIEL", Me.Dgv2)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
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
        Me.A.Focus()
    End Sub
    Private Sub Procédure2()
        Me.btn_Ajou.Enabled = False
        Me.btn_Mod.Enabled = True
        Me.btn_Sup.Enabled = True
    End Sub
End Class