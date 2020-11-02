Imports System.Data.SqlClient
Public Class Suppression
    Public I, m As String
    Private Sub Btn_Ferm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ferm.Click
        Me.Dispose()
    End Sub

    Private Sub Btn_Sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sup.Click
        If Dgv1.RowCount <> 0 Then
            instruction("Delete from UTILISATEUR WHERE Login ='" & Dgv1.CurrentRow.Cells(0).Value & "' and  Motpasse ='" & Dgv1.CurrentRow.Cells(1).Value & "'", SU)
            RemplirGrille("Select* FROM UTILISATEUR", Me.Dgv1)
        End If
    End Sub

    Private Sub Suppression_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' se_connecter("Data Source=KJEC-PC;Initial Catalog=intervention;Integrated Security=True")
        RemplirGrille("Select* FROM UTILISATEUR", Me.Dgv1)
    End Sub
End Class