<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesCli
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Dgv = New System.Windows.Forms.DataGridView
        Me.NumCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdresCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LieuInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.F = New System.Windows.Forms.ComboBox
        Me.E1 = New System.Windows.Forms.ComboBox
        Me.D = New System.Windows.Forms.TextBox
        Me.C = New System.Windows.Forms.TextBox
        Me.B = New System.Windows.Forms.TextBox
        Me.A = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_fer = New System.Windows.Forms.Button
        Me.btn_sup = New System.Windows.Forms.Button
        Me.btn_mod = New System.Windows.Forms.Button
        Me.btn_ajou = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 49)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(619, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "HEURE :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(701, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES CLIENTS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SyGITech.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 393)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des clients"
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCli, Me.NomCli, Me.AdresCli, Me.TelCli, Me.TypInterv, Me.LieuInterv})
        Me.Dgv.Location = New System.Drawing.Point(2, 19)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.Size = New System.Drawing.Size(439, 368)
        Me.Dgv.TabIndex = 0
        '
        'NumCli
        '
        Me.NumCli.FillWeight = 80.0!
        Me.NumCli.HeaderText = "Numéro"
        Me.NumCli.Name = "NumCli"
        Me.NumCli.ReadOnly = True
        '
        'NomCli
        '
        Me.NomCli.HeaderText = "Nom"
        Me.NomCli.Name = "NomCli"
        Me.NomCli.ReadOnly = True
        Me.NomCli.Width = 200
        '
        'AdresCli
        '
        Me.AdresCli.HeaderText = "Adresse"
        Me.AdresCli.Name = "AdresCli"
        Me.AdresCli.ReadOnly = True
        Me.AdresCli.Width = 180
        '
        'TelCli
        '
        Me.TelCli.HeaderText = "Tel"
        Me.TelCli.Name = "TelCli"
        Me.TelCli.ReadOnly = True
        Me.TelCli.Width = 120
        '
        'TypInterv
        '
        Me.TypInterv.HeaderText = "Type"
        Me.TypInterv.Name = "TypInterv"
        Me.TypInterv.ReadOnly = True
        Me.TypInterv.Width = 120
        '
        'LieuInterv
        '
        Me.LieuInterv.HeaderText = "Lieu d'intervention"
        Me.LieuInterv.Name = "LieuInterv"
        Me.LieuInterv.ReadOnly = True
        Me.LieuInterv.Width = 130
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.F)
        Me.GroupBox2.Controls.Add(Me.E1)
        Me.GroupBox2.Controls.Add(Me.D)
        Me.GroupBox2.Controls.Add(Me.C)
        Me.GroupBox2.Controls.Add(Me.B)
        Me.GroupBox2.Controls.Add(Me.A)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(453, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 393)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLIENT"
        '
        'F
        '
        Me.F.FormattingEnabled = True
        Me.F.Items.AddRange(New Object() {"A MA-INFO", "Chez le client"})
        Me.F.Location = New System.Drawing.Point(166, 262)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(121, 24)
        Me.F.TabIndex = 14
        '
        'E1
        '
        Me.E1.FormattingEnabled = True
        Me.E1.Items.AddRange(New Object() {"Sous contrat", "Hors contrat"})
        Me.E1.Location = New System.Drawing.Point(290, 201)
        Me.E1.Name = "E1"
        Me.E1.Size = New System.Drawing.Size(114, 24)
        Me.E1.TabIndex = 13
        '
        'D
        '
        Me.D.Location = New System.Drawing.Point(88, 201)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(118, 22)
        Me.D.TabIndex = 10
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(88, 151)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(199, 22)
        Me.C.TabIndex = 9
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(88, 99)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(316, 22)
        Me.B.TabIndex = 8
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(88, 42)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(100, 22)
        Me.A.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Lieu d'intervention :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tel :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Adresse :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btn_fer)
        Me.Panel2.Controls.Add(Me.btn_sup)
        Me.Panel2.Controls.Add(Me.btn_mod)
        Me.Panel2.Controls.Add(Me.btn_ajou)
        Me.Panel2.Location = New System.Drawing.Point(15, 335)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 52)
        Me.Panel2.TabIndex = 0
        '
        'btn_fer
        '
        Me.btn_fer.Location = New System.Drawing.Point(312, 9)
        Me.btn_fer.Name = "btn_fer"
        Me.btn_fer.Size = New System.Drawing.Size(75, 29)
        Me.btn_fer.TabIndex = 3
        Me.btn_fer.Text = "&Fermer"
        Me.btn_fer.UseVisualStyleBackColor = True
        '
        'btn_sup
        '
        Me.btn_sup.Location = New System.Drawing.Point(199, 10)
        Me.btn_sup.Name = "btn_sup"
        Me.btn_sup.Size = New System.Drawing.Size(96, 29)
        Me.btn_sup.TabIndex = 2
        Me.btn_sup.Text = "&Supprimer"
        Me.btn_sup.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(105, 12)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(75, 29)
        Me.btn_mod.TabIndex = 1
        Me.btn_mod.Text = "&Modifier"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_ajou
        '
        Me.btn_ajou.Location = New System.Drawing.Point(12, 12)
        Me.btn_ajou.Name = "btn_ajou"
        Me.btn_ajou.Size = New System.Drawing.Size(75, 29)
        Me.btn_ajou.TabIndex = 0
        Me.btn_ajou.Text = "&Ajouter"
        Me.btn_ajou.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'GesCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(908, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GesCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesCli"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_fer As System.Windows.Forms.Button
    Friend WithEvents btn_sup As System.Windows.Forms.Button
    Friend WithEvents btn_mod As System.Windows.Forms.Button
    Friend WithEvents btn_ajou As System.Windows.Forms.Button
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents D As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents NumCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LieuInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents F As System.Windows.Forms.ComboBox
End Class
