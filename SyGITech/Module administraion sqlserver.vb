Imports System.Data.SqlClient

Module Module1
    Public id_encour As String
    Public pass_encour As String
    Public fermetur_application As Boolean
    Public dr As SqlDataReader
    Public recuperateur_de_statut As String
    Public ObjetCommand As New SqlCommand
    Public cnx As New SqlConnection

    Public EN As String = "Enregistrement effectué avec succès"
    Public MO As String = "Modification effectuée avec succès"
    Public SU As String = "Suppression effectuée avec succès"

    ' Permet de se connecter à une base de données
    '"" source est la chaîne de connexion
    Public Sub se_connecter(ByVal souce As String)
        Try
            cnx.ConnectionString = souce
            cnx.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Permet de remplir les grilles des datagridview
    '"" req est la requête que l'on veut exécuter
    '"" nomgrille est le nom de la grille à remplir
    ''''remplir grille
    Public Sub RemplirGrille(ByVal req As String, ByVal nomgrille As DataGridView)
        Try
            '  dr.Close()
            ObjetCommand.CommandText = req
            ObjetCommand.Connection = cnx
            dr = ObjetCommand.ExecuteReader
            Dim I, J, K As Integer
            nomgrille.Rows.Clear()
            I = 0
            J = dr.FieldCount
            While dr.Read()
                nomgrille.Rows.Add()
                K = 0
                While K < J
                    nomgrille.Rows(I).Cells(K).Value = dr(K)
                    K = K + 1
                End While
                I = I + 1

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()
    End Sub
    'Premet d'incrémenter avec précision du textbox
    '"" Table est le nom de la table dans la base de données
    '"" champ est le nomb du champ dans la base de données
    '"" text0 est le nom du textbox
    Public Sub incrémenter_numero(ByVal Table As String, ByVal Champ As String, ByVal text0 As System.Windows.Forms.TextBox)
        Try
            'dr.Close()
            ObjetCommand = cnx.CreateCommand
            ObjetCommand.CommandType = CommandType.Text
            ObjetCommand.CommandText = "select top 1 " & Champ & " from " & Table & " order by " & Champ & " desc "
            dr = ObjetCommand.ExecuteReader
            If dr.Read Then
                If dr.GetValue(0) >= 1000 Then
                    text0.Text = dr.GetValue(0) + 1
                ElseIf dr.GetValue(0) >= 100 Then
                    text0.Text = "0" & dr.GetValue(0) + 1
                ElseIf dr.GetValue(0) >= 10 Then
                    text0.Text = "0" & "0" & dr.GetValue(0) + 1
                ElseIf dr.GetValue(0) < 10 Then
                    text0.Text = "0" & "0" & "0" & dr.GetValue(0) + 1
                End If
            Else
                text0.Text = "0" & "0" & "0" & 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()
    End Sub
    'Permet de faire des incrémentations avec des lettres et des chiffres
    '"" le caractere est le ceractère à écrir avant le numéro
    Public Function incrémenter_Alpha_numérique(ByVal Table As String, ByVal Champ As String, Optional ByVal LeCaractere As String = "") As String
        Try
            ' dr.Close()
            Dim vnum As String
            ObjetCommand = cnx.CreateCommand
            ObjetCommand.CommandText = "select max(" & Champ & ") as LeGrd from " & Table
            dr = ObjetCommand.ExecuteReader
            If Not dr.Read Then
                vnum = 1
            Else
                If dr.IsDBNull(0) Then
                    vnum = 1
                Else
                    vnum = Val(Right(dr("LeGrd"), Len(dr("LeGrd")) - 3)) + 1
                End If
            End If
            If vnum < 10 Then
                incrémenter_Alpha_numérique = LeCaractere & "000" & vnum
            Else
                If vnum < 100 Then
                    incrémenter_Alpha_numérique = LeCaractere & "00" & vnum
                Else
                    If vnum < 1000 Then
                        incrémenter_Alpha_numérique = LeCaractere & "0" & vnum
                    Else
                        incrémenter_Alpha_numérique = LeCaractere & vnum
                    End If
                End If
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    'Permet de faire des incrémentations concernant les autres contrôles comme des combos, etc...
    Public Function incrémenter_numero_autre(ByVal Table As String, ByVal Champ As String) As Double
        Try
            ' dr.Close()
            ObjetCommand = cnx.CreateCommand
            ObjetCommand.CommandType = CommandType.Text
            ObjetCommand.CommandText = "select top 1 " & Champ & " from " & Table & " order by " & Champ & " desc "
            dr = ObjetCommand.ExecuteReader
            If dr.Read Then
                If dr.GetValue(0) >= 1000 Then
                    incrémenter_numero_autre = dr.GetValue(0) + 1
                ElseIf dr.GetValue(0) >= 100 Then
                    incrémenter_numero_autre = "0" & dr.GetValue(0) + 1
                ElseIf dr.GetValue(0) >= 10 Then
                    incrémenter_numero_autre = "0" & "0" & dr.GetValue(0) + 1
                ElseIf dr.GetValue(0) < 10 Then
                    incrémenter_numero_autre = "0" & "0" & "0" & dr.GetValue(0) + 1
                End If
            Else
                incrémenter_numero_autre = "0" & "0" & "0" & 1
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Permet de remplir les combo 
    '""req est la requête
    '""NomCombo est le nom vdu combo
    Public Sub remplir_Combo1(ByVal req As String, ByVal NomCombo As ComboBox)
        Try
            ' dr.Close()
            Dim Machaîne As String
            Machaîne = req
            ObjetCommand.CommandText = Machaîne
            dr = ObjetCommand.ExecuteReader
            NomCombo.Items.Clear()
            While dr.Read
                NomCombo.Items.Add(dr(0))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Permet de remplir un combo avec possibilité de récupérer le numéro
    '"" champ1 est le code
    '"" champ1 est le libellé
    '"" Table  est la Table
    '"" nom_combo est le nom du combo
    Public Sub remplir_combo2(ByVal champ1 As String, ByVal champ2 As String, ByVal Table As String, ByVal nom_combo As ComboBox)
        Try
            '  dr.Close()
            ObjetCommand.CommandType = CommandType.Text
            ObjetCommand.CommandText = "select " & champ1 & " ,  " & champ2 & " from " & Table & ""
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(ObjetCommand)
            da.Fill(ds, Table)
            nom_combo.DataSource = ds.Tables(Table)
            nom_combo.ValueMember = champ1
            nom_combo.DisplayMember = champ2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Permet de faire des enregistrements , modifications et des suppressions avec la gestion des msgbox
    '"" req est la requête
    '"" msg est le msg
    Public Sub instruction(ByVal req As String, Optional ByVal msg As String = "")
        ObjetCommand = cnx.CreateCommand
        Try
            ObjetCommand.CommandText = req
            ObjetCommand.ExecuteNonQuery()
            If msg <> "" Then
                MsgBox(msg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub parcourir(ByVal req As String)
        Try
            ObjetCommand = cnx.CreateCommand
            ObjetCommand.CommandText = req
            ' ObjetCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Permet de gérer les problèmes liés aux apostrophes

    Public Function recup(ByVal Sstring As String) As String
        Try
            Sstring = Replace(Sstring, "'", Chr(180))
            Return Sstring
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function mettreApostrophe(ByVal Sstring As String)
        Try
            Sstring = Replace(Trim(Sstring), Chr(180), "'")
            Return Sstring
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ''Public Sub instruction(ByVal reqs As String, Optional ByVal msg As String = "")
    ''    Dim cnxp As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=soutenance.mdb;")
    ''    cnxp.Open()
    ''    Dim objetcommandp As OleDbCommand = cnxp.CreateCommand
    ''    objetcommandp.CommandType = CommandType.Text
    ''    objetcommandp.CommandText = reqs
    ''    objetcommandp.ExecuteNonQuery()
    ''    MsgBox(msg)
    ''End Sub
End Module
