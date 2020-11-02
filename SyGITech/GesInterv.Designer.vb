<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesInterv
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.D = New System.Windows.Forms.TextBox
        Me.btn_Ajou = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Dgv2 = New System.Windows.Forms.DataGridView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.B = New System.Windows.Forms.TextBox
        Me.A = New System.Windows.Forms.TextBox
        Me.btn_Mod = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_Sup = New System.Windows.Forms.Button
        Me.btn_Ferm = New System.Windows.Forms.Button
        Me.Dgv1 = New System.Windows.Forms.DataGridView
        Me.NumGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodTech = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CodeInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DatInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumGroupe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 49)
        Me.Panel1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(656, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "HEURE :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(716, 13)
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
        Me.Label1.Size = New System.Drawing.Size(391, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES INTERVENTIONS"
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
        'D
        '
        Me.D.Location = New System.Drawing.Point(148, 179)
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Size = New System.Drawing.Size(100, 22)
        Me.D.TabIndex = 11
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 362)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(895, 238)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des interventions"
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeInterv, Me.TypInterv, Me.DatInterv, Me.NumGroupe})
        Me.Dgv2.Location = New System.Drawing.Point(6, 20)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.Size = New System.Drawing.Size(883, 212)
        Me.Dgv2.TabIndex = 0
        '
        'Timer1
        '
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(148, 78)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(265, 22)
        Me.B.TabIndex = 8
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(148, 33)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(99, 22)
        Me.A.TabIndex = 7
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(105, 12)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(75, 29)
        Me.btn_Mod.TabIndex = 1
        Me.btn_Mod.Text = "&Modifier"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numéro groupe :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date :"
        '
        'btn_Sup
        '
        Me.btn_Sup.Location = New System.Drawing.Point(199, 10)
        Me.btn_Sup.Name = "btn_Sup"
        Me.btn_Sup.Size = New System.Drawing.Size(96, 29)
        Me.btn_Sup.TabIndex = 2
        Me.btn_Sup.Text = "&Supprimer"
        Me.btn_Sup.UseVisualStyleBackColor = True
        '
        'btn_Ferm
        '
        Me.btn_Ferm.Location = New System.Drawing.Point(312, 9)
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
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumGroup, Me.NomGroup, Me.CodTech})
        Me.Dgv1.Location = New System.Drawing.Point(2, 19)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(439, 257)
        Me.Dgv1.TabIndex = 0
        '
        'NumGroup
        '
        Me.NumGroup.FillWeight = 80.0!
        Me.NumGroup.HeaderText = "Numéro"
        Me.NumGroup.Name = "NumGroup"
        Me.NumGroup.ReadOnly = True
        '
        'NomGroup
        '
        Me.NomGroup.HeaderText = "Nom"
        Me.NomGroup.Name = "NomGroup"
        Me.NomGroup.ReadOnly = True
        Me.NomGroup.Width = 200
        '
        'CodTech
        '
        Me.CodTech.HeaderText = "Code du technicien"
        Me.CodTech.Name = "CodTech"
        Me.CodTech.ReadOnly = True
        Me.CodTech.Width = 180
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 282)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des groupes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type :"
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
        Me.GroupBox2.Location = New System.Drawing.Point(464, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 281)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INTERVENTION"
        '
        'C
        '
        Me.C.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.C.Location = New System.Drawing.Point(148, 127)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(113, 22)
        Me.C.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 33)
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
        Me.Panel2.Location = New System.Drawing.Point(15, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 52)
        Me.Panel2.TabIndex = 0
        '
        'CodeInterv
        '
        Me.CodeInterv.FillWeight = 119.797!
        Me.CodeInterv.HeaderText = "Code de l'intervention"
        Me.CodeInterv.Name = "CodeInterv"
        Me.CodeInterv.ReadOnly = True
        '
        'TypInterv
        '
        Me.TypInterv.FillWeight = 119.797!
        Me.TypInterv.HeaderText = "Type d'intervention"
        Me.TypInterv.Name = "TypInterv"
        Me.TypInterv.ReadOnly = True
        '
        'DatInterv
        '
        Me.DatInterv.FillWeight = 40.60914!
        Me.DatInterv.HeaderText = "Date"
        Me.DatInterv.Name = "DatInterv"
        Me.DatInterv.ReadOnly = True
        '
        'NumGroupe
        '
        Me.NumGroupe.FillWeight = 119.797!
        Me.NumGroupe.HeaderText = "Numéro du groupe"
        Me.NumGroupe.Name = "NumGroupe"
        Me.NumGroupe.ReadOnly = True
        '
        'GesInterv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(914, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "GesInterv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesInterv"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents D As System.Windows.Forms.TextBox
    Friend WithEvents btn_Ajou As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents btn_Mod As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Sup As System.Windows.Forms.Button
    Friend WithEvents btn_Ferm As System.Windows.Forms.Button
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents C As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumGroupe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
