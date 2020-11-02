<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesGroup
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
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.EE = New System.Windows.Forms.TextBox
        Me.btn_Ajou = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Dgv2 = New System.Windows.Forms.DataGridView
        Me.NumGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodTech = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.B = New System.Windows.Forms.TextBox
        Me.A = New System.Windows.Forms.TextBox
        Me.btn_Mod = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_Sup = New System.Windows.Forms.Button
        Me.btn_Ferm = New System.Windows.Forms.Button
        Me.Dgv1 = New System.Windows.Forms.DataGridView
        Me.CODETech = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomTech = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrenomTech = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.D = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.C = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(759, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "HEURE :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(820, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES GROUPES"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 49)
        Me.Panel1.TabIndex = 6
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
        'EE
        '
        Me.EE.Location = New System.Drawing.Point(149, 27)
        Me.EE.Name = "EE"
        Me.EE.ReadOnly = True
        Me.EE.Size = New System.Drawing.Size(96, 22)
        Me.EE.TabIndex = 11
        '
        'btn_Ajou
        '
        Me.btn_Ajou.Location = New System.Drawing.Point(12, 12)
        Me.btn_Ajou.Name = "btn_Ajou"
        Me.btn_Ajou.Size = New System.Drawing.Size(75, 29)
        Me.btn_Ajou.TabIndex = 0
        Me.btn_Ajou.Text = "&Ajouter"
        Me.btn_Ajou.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 436)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1001, 263)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des groupes"
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumGroup, Me.NomGroup, Me.CodTech})
        Me.Dgv2.Location = New System.Drawing.Point(6, 19)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.Size = New System.Drawing.Size(989, 239)
        Me.Dgv2.TabIndex = 0
        '
        'NumGroup
        '
        Me.NumGroup.HeaderText = "Numéro "
        Me.NumGroup.Name = "NumGroup"
        Me.NumGroup.ReadOnly = True
        '
        'NomGroup
        '
        Me.NomGroup.HeaderText = "Nom"
        Me.NomGroup.Name = "NomGroup"
        Me.NomGroup.ReadOnly = True
        '
        'CodTech
        '
        Me.CodTech.HeaderText = "Code du technicien"
        Me.CodTech.Name = "CodTech"
        Me.CodTech.ReadOnly = True
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(127, 70)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(265, 22)
        Me.B.TabIndex = 8
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(127, 33)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(157, 22)
        Me.A.TabIndex = 7
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(121, 12)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(75, 29)
        Me.btn_Mod.TabIndex = 1
        Me.btn_Mod.Text = "&Modifier"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Code technicien:"
        '
        'btn_Sup
        '
        Me.btn_Sup.Location = New System.Drawing.Point(240, 12)
        Me.btn_Sup.Name = "btn_Sup"
        Me.btn_Sup.Size = New System.Drawing.Size(96, 29)
        Me.btn_Sup.TabIndex = 2
        Me.btn_Sup.Text = "&Supprimer"
        Me.btn_Sup.UseVisualStyleBackColor = True
        '
        'btn_Ferm
        '
        Me.btn_Ferm.Location = New System.Drawing.Point(374, 12)
        Me.btn_Ferm.Name = "btn_Ferm"
        Me.btn_Ferm.Size = New System.Drawing.Size(75, 29)
        Me.btn_Ferm.TabIndex = 3
        Me.btn_Ferm.Text = "&Fermer"
        Me.btn_Ferm.UseVisualStyleBackColor = True
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODETech, Me.NomTech, Me.PrenomTech})
        Me.Dgv1.Location = New System.Drawing.Point(2, 19)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(450, 323)
        Me.Dgv1.TabIndex = 0
        '
        'CODETech
        '
        Me.CODETech.FillWeight = 80.0!
        Me.CODETech.HeaderText = "Code"
        Me.CODETech.Name = "CODETech"
        Me.CODETech.ReadOnly = True
        '
        'NomTech
        '
        Me.NomTech.HeaderText = "Nom"
        Me.NomTech.Name = "NomTech"
        Me.NomTech.ReadOnly = True
        Me.NomTech.Width = 180
        '
        'PrenomTech
        '
        Me.PrenomTech.HeaderText = "Prénoms"
        Me.PrenomTech.Name = "PrenomTech"
        Me.PrenomTech.ReadOnly = True
        Me.PrenomTech.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 348)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des techniciens"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.B)
        Me.GroupBox2.Controls.Add(Me.A)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(465, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 348)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GROUPE"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.D)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.C)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.EE)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(483, 136)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chef du groupe"
        '
        'D
        '
        Me.D.Location = New System.Drawing.Point(149, 101)
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Size = New System.Drawing.Size(266, 22)
        Me.D.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Prénoms:"
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(149, 64)
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Size = New System.Drawing.Size(173, 22)
        Me.C.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btn_Ferm)
        Me.Panel2.Controls.Add(Me.btn_Sup)
        Me.Panel2.Controls.Add(Me.btn_Mod)
        Me.Panel2.Controls.Add(Me.btn_Ajou)
        Me.Panel2.Location = New System.Drawing.Point(28, 276)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 52)
        Me.Panel2.TabIndex = 0
        '
        'Timer1
        '
        '
        'GesGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1010, 702)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "GesGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesGroup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents EE As System.Windows.Forms.TextBox
    Friend WithEvents btn_Ajou As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents btn_Mod As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_Sup As System.Windows.Forms.Button
    Friend WithEvents btn_Ferm As System.Windows.Forms.Button
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents D As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CODETech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTech As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
