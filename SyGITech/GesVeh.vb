Imports System.Data.SqlClient
Public Class GesVeh
    Private Sub GesVeh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        RemplirGrille("Select Immat, Nb_Place from VEHICULE", Me.Dgv)
        Timer1.Interval = 1000
        Timer1.Start()
        Procédure1()
    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod.Click
        If A.Text = "" Then
            MsgBox(" Veuilez remplir le champ Immatriculation ")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox(" Veuillez remplir le champ Nombre de places ")
            B.Focus()
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show(" Confirmez vous cette modification ?", " Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Update Vehicule set Nb_Place= '" & B.Text & "' where Immat= '" & A.Text & "'", MO)
            RemplirGrille("Select Immat, Nb_Place from VEHICULE", Me.Dgv)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub

    Private Sub btnajou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ajou.Click
        If A.Text = "" Then
            MsgBox(" Veuilez remplir le champ Immatriculation ")
            A.Focus()
            Exit Sub
        ElseIf B.Text = "" Then
            MsgBox(" Veuillez remplir le champ Nombre de places")
            B.Focus()
            Exit Sub
        End If
        instruction("Insert into VEHICULE Values ('" & A.Text & "', " & B.Text & ")", EN)
        RemplirGrille("Select Immat, Nb_Place from VEHICULE", Me.Dgv)
        Vider()
        Procédure1()
    End Sub

    Private Sub btnsup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sup.Click
        If A.Text = "" Then
            MsgBox(" Veuillez sélectionner l'enregistrement à supprimer ")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show(" Confirmez vous cette suppression ? ", " Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from VEHICULE WHERE Immat= '" & A.Text & "'", SU)
            RemplirGrille(" Select Immat, Nb_Place from VEHICULE ", Me.Dgv)
            Vider()
            Procédure1()
        Else
            Vider()
            Procédure1()
        End If
    End Sub
    Private Sub B_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles B.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(Asc("-"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub Dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv.CellMouseClick
        A.Text = Dgv.CurrentRow.Cells(0).Value
        B.Text = Dgv.CurrentRow.Cells(1).Value
        Procédure2()
    End Sub

    Private Sub btnfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fer.Click
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = Now.ToLongTimeString
    End Sub
    Private Sub Vider()
        A.Text = ""
        B.Text = ""
        A.Focus()
    End Sub
    Private Sub Procédure1()
        Me.btn_ajou.Enabled = True
        Me.btn_mod.Enabled = False
        Me.btn_sup.Enabled = False
    End Sub
    Private Sub Procédure2()
        Me.btn_ajou.Enabled = False
        Me.btn_mod.Enabled = True
        Me.btn_sup.Enabled = True
    End Sub
End Class
