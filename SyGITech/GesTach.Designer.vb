<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesTach
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C = New System.Windows.Forms.TextBox
        Me.D = New System.Windows.Forms.TextBox
        Me.B = New System.Windows.Forms.TextBox
        Me.A = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_Ferm = New System.Windows.Forms.Button
        Me.btn_Sup = New System.Windows.Forms.Button
        Me.btn_Mod = New System.Windows.Forms.Button
        Me.btn_Ajou = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Dgv1 = New System.Windows.Forms.DataGridView
        Me.CodeTeche = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomTeche = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrenomTech = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Dgv2 = New System.Windows.Forms.DataGridView
        Me.CodTach = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LibTach = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DureTheo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodeTeh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libellé :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(9, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 49)
        Me.Panel1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(846, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "HEURE :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(910, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES TACHES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.SyGITech.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C)
        Me.GroupBox2.Controls.Add(Me.D)
        Me.GroupBox2.Controls.Add(Me.B)
        Me.GroupBox2.Controls.Add(Me.A)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(468, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(627, 337)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TACHE"
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(186, 153)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(100, 22)
        Me.C.TabIndex = 12
        '
        'D
        '
        Me.D.BackColor = System.Drawing.SystemColors.Window
        Me.D.Location = New System.Drawing.Point(186, 200)
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Size = New System.Drawing.Size(100, 22)
        Me.D.TabIndex = 11
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(186, 104)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(346, 22)
        Me.B.TabIndex = 8
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(187, 51)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(99, 22)
        Me.A.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numéro technicien :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Durée théorique :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btn_Ferm)
        Me.Panel2.Controls.Add(Me.btn_Sup)
        Me.Panel2.Controls.Add(Me.btn_Mod)
        Me.Panel2.Controls.Add(Me.btn_Ajou)
        Me.Panel2.Location = New System.Drawing.Point(39, 262)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(550, 52)
        Me.Panel2.TabIndex = 0
        '
        'btn_Ferm
        '
        Me.btn_Ferm.Location = New System.Drawing.Point(443, 10)
        Me.btn_Ferm.Name = "btn_Ferm"
        Me.btn_Ferm.Size = New System.Drawing.Size(75, 29)
        Me.btn_Ferm.TabIndex = 3
        Me.btn_Ferm.Text = "&Fermer"
        Me.btn_Ferm.UseVisualStyleBackColor = True
        '
        'btn_Sup
        '
        Me.btn_Sup.Location = New System.Drawing.Point(282, 10)
        Me.btn_Sup.Name = "btn_Sup"
        Me.btn_Sup.Size = New System.Drawing.Size(96, 29)
        Me.btn_Sup.TabIndex = 2
        Me.btn_Sup.Text = "&Supprimer"
        Me.btn_Sup.UseVisualStyleBackColor = True
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(145, 10)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(75, 29)
        Me.btn_Mod.TabIndex = 1
        Me.btn_Mod.Text = "&Modifier"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'btn_Ajou
        '
        Me.btn_Ajou.Location = New System.Drawing.Point(18, 10)
        Me.btn_Ajou.Name = "btn_Ajou"
        Me.btn_Ajou.Size = New System.Drawing.Size(75, 29)
        Me.btn_Ajou.TabIndex = 0
        Me.btn_Ajou.Text = "&Ajouter"
        Me.btn_Ajou.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 337)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des techniciens"
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeTeche, Me.NomTeche, Me.PrenomTech, Me.NumGroup})
        Me.Dgv1.Location = New System.Drawing.Point(2, 19)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(439, 312)
        Me.Dgv1.TabIndex = 0
        '
        'CodeTeche
        '
        Me.CodeTeche.FillWeight = 80.0!
        Me.CodeTeche.HeaderText = "Code"
        Me.CodeTeche.Name = "CodeTeche"
        Me.CodeTeche.ReadOnly = True
        '
        'NomTeche
        '
        Me.NomTeche.HeaderText = "Nom"
        Me.NomTeche.Name = "NomTeche"
        Me.NomTeche.ReadOnly = True
        Me.NomTeche.Width = 180
        '
        'PrenomTech
        '
        Me.PrenomTech.HeaderText = "Prénoms"
        Me.PrenomTech.Name = "PrenomTech"
        Me.PrenomTech.ReadOnly = True
        Me.PrenomTech.Width = 200
        '
        'NumGroup
        '
        Me.NumGroup.HeaderText = "Numéro du Groupe"
        Me.NumGroup.Name = "NumGroup"
        Me.NumGroup.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 410)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1080, 299)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des tâches"
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodTach, Me.LibTach, Me.DureTheo, Me.CodeTeh})
        Me.Dgv2.Location = New System.Drawing.Point(6, 20)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.Size = New System.Drawing.Size(1068, 273)
        Me.Dgv2.TabIndex = 0
        '
        'CodTach
        '
        Me.CodTach.HeaderText = "Code "
        Me.CodTach.Name = "CodTach"
        Me.CodTach.ReadOnly = True
        '
        'LibTach
        '
        Me.LibTach.HeaderText = "Libellé"
        Me.LibTach.Name = "LibTach"
        Me.LibTach.ReadOnly = True
        '
        'DureTheo
        '
        Me.DureTheo.HeaderText = "Durée théorique"
        Me.DureTheo.Name = "DureTheo"
        Me.DureTheo.ReadOnly = True
        '
        'CodeTeh
        '
        Me.CodeTeh.HeaderText = "Code du technicien"
        Me.CodeTeh.Name = "CodeTeh"
        Me.CodeTeh.ReadOnly = True
        '
        'Timer1
        '
        '
        'GesTach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1114, 712)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "GesTach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesTach"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents D As System.Windows.Forms.TextBox
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Ferm As System.Windows.Forms.Button
    Friend WithEvents btn_Sup As System.Windows.Forms.Button
    Friend WithEvents btn_Mod As System.Windows.Forms.Button
    Friend WithEvents btn_Ajou As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents CodTach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibTach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureTheo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeTeh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeTeche As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomTeche As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumGroup As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
