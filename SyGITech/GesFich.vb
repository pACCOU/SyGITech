Imports System.Data.SqlClient
Public Class GesFich
    Private Sub GesFich_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        RemplirGrille("Select NumFich,DatFich,NumSerie,Immat from FICHE", Me.Dgv3)
        RemplirGrille("Select NumSerie,NomMat,Marque,Model,NumCli from MATERIEL", Me.Dgv2)
        RemplirGrille("Select Immat,Nb_Place from VEHICULE", Me.Dgv1)
        Incrémenter()
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub
    Private Sub btnFerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFerm.Click
        Me.Close()
    End Sub
    Private Sub btnAjou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjou.Click
        If Dtp.Text = "" Then
            MsgBox("Veuillez remplir le champ Date")
            Dtp.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le Numéro de serie en cliquant sur le matériel concerné dans la liste des matériels ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez choisir l'immatriculation du véhicule en cliquant sur le véhicule concerné dans la liste des véhicules")
            C.Focus()
            Exit Sub
        End If
        instruction("Insert into FICHE Values ('" & A.Text & "','" & Dtp.Value.Date & "', '" & B.Text & "', '" & C.Text & "')", EN)
        RemplirGrille("Select NumFich,DatFich,NumSerie,Immat from FICHE", Me.Dgv3)
        Vider()
        Incrémenter()
        Procédure1()
    End Sub
    Private Sub Dgv3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv3.CellMouseClick
        A.Text = Dgv3.CurrentRow.Cells(0).Value
        Dtp.Text = Dgv3.CurrentRow.Cells(1).Value
        B.Text = Dgv3.CurrentRow.Cells(2).Value
        C.Text = Dgv3.CurrentRow.Cells(3).Value
        Me.btnAjou.Enabled = False
        Me.btnMod.Enabled = True
        Me.btnSup.Enabled = True
    End Sub
    Private Sub Dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseClick
        C.Text = Dgv1.CurrentRow.Cells(0).Value
    End Sub
    Private Sub Dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv2.CellMouseClick
        B.Text = Dgv2.CurrentRow.Cells(0).Value
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = Now.ToLongTimeString
    End Sub
    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        If A.Text = "" Then
            MsgBox("Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from FICHE WHERE NumFich= '" & A.Text & "'", SU)
            RemplirGrille("Select NumFich,DatFich,NumSerie,Immat from FICHE", Me.Dgv3)
            Vider()
            Incrémenter()
            Procédure1()
        Else
            Vider()
            Incrémenter()
            Procédure1()
        End If
    End Sub
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Dtp.Text = "" Then
            MsgBox("Veuillez remplir le champ Date")
            Dtp.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox("Veuillez choisir le Numéro de serie en cliquant sur le matériel concerné dans la liste des matériels ")
            B.Focus()
            Exit Sub
        ElseIf C.Text = "" Then
            MsgBox("Veuillez choisir l'immatriculation du véhicule en cliquant sur le véhicule concerné dans la liste des véhicules")
            C.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Confirmez vous cette modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update FICHE set '" & Dtp.Value.Date & "',NumSerie= '" & B.Text & "', Immat= '" & C.Text & "'where NumFich= '" & A.Text & "'", MO)
            RemplirGrille("Select NumFich,DatFich,NumSerie,Immat from FICHE", Me.Dgv3)
            Vider()
            Incrémenter()
            Procédure1()
        Else
            Vider()
            Incrémenter()
            Procédure1()
        End If
    End Sub

    Private Sub Dtp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dtp.KeyPress
        e.KeyChar = ""
    End Sub
    Private Sub Vider()
        Me.B.Text = ""
        Me.C.Text = ""
        Me.Dtp.Text = ""
        B.Focus()
    End Sub
    Private Sub Procédure1()
        Me.btnAjou.Enabled = True
        Me.btnMod.Enabled = False
        Me.btnSup.Enabled = False
    End Sub
    Private Sub Incrémenter()
        A.Text = incrémenter_Alpha_numérique("FICHE", "NumFich", "F")
    End Sub
End Class