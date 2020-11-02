<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesAppel
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dgv2 = New System.Windows.Forms.DataGridView()
        Me.CodeTech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomTech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomTech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.TextBox()
        Me.B = New System.Windows.Forms.TextBox()
        Me.D = New System.Windows.Forms.DateTimePicker()
        Me.A = New System.Windows.Forms.TextBox()
        Me.btn_Mod = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Ajou = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dgv3 = New System.Windows.Forms.DataGridView()
        Me.NumAppel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatAppel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureAppel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DureAppel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodTech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Sup = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_Ferm = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.NumClii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LieuInterv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.F = New System.Windows.Forms.TextBox()
        Me.EE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 90)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(775, 359)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des techniciens"
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeTech, Me.NomTech, Me.PrenomTech, Me.NumGroup})
        Me.Dgv2.Location = New System.Drawing.Point(8, 23)
        Me.Dgv2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.Size = New System.Drawing.Size(760, 329)
        Me.Dgv2.TabIndex = 0
        '
        'CodeTech
        '
        Me.CodeTech.HeaderText = "Code"
        Me.CodeTech.Name = "CodeTech"
        Me.CodeTech.ReadOnly = True
        '
        'NomTech
        '
        Me.NomTech.HeaderText = "Nom"
        Me.NomTech.Name = "NomTech"
        Me.NomTech.ReadOnly = True
        Me.NomTech.Width = 150
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
        Me.NumGroup.HeaderText = "Numéro du groupe"
        Me.NumGroup.Name = "NumGroup"
        Me.NumGroup.ReadOnly = True
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(236, 250)
        Me.C.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Size = New System.Drawing.Size(132, 26)
        Me.C.TabIndex = 14
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(236, 212)
        Me.B.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Size = New System.Drawing.Size(132, 26)
        Me.B.TabIndex = 13
        '
        'D
        '
        Me.D.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D.Location = New System.Drawing.Point(235, 73)
        Me.D.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(149, 26)
        Me.D.TabIndex = 10
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(235, 31)
        Me.A.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(132, 26)
        Me.A.TabIndex = 7
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(140, 12)
        Me.btn_Mod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(100, 36)
        Me.btn_Mod.TabIndex = 1
        Me.btn_Mod.Text = "&Modifier"
        Me.btn_Mod.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 250)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Numéro client :"
        '
        'btn_Ajou
        '
        Me.btn_Ajou.Location = New System.Drawing.Point(16, 11)
        Me.btn_Ajou.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Ajou.Name = "btn_Ajou"
        Me.btn_Ajou.Size = New System.Drawing.Size(100, 36)
        Me.btn_Ajou.TabIndex = 0
        Me.btn_Ajou.Text = "&Ajouter"
        Me.btn_Ajou.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(15, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1493, 61)
        Me.Panel1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1267, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1169, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 22)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "HEURE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(603, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES APPELS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.SyGITech.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Code technicien :"
        '
        'Dgv3
        '
        Me.Dgv3.AllowUserToAddRows = False
        Me.Dgv3.AllowUserToDeleteRows = False
        Me.Dgv3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumAppel, Me.DatAppel, Me.HeureAppel, Me.DureAppel, Me.CodTech, Me.NumCli})
        Me.Dgv3.Location = New System.Drawing.Point(8, 23)
        Me.Dgv3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv3.Name = "Dgv3"
        Me.Dgv3.ReadOnly = True
        Me.Dgv3.Size = New System.Drawing.Size(696, 311)
        Me.Dgv3.TabIndex = 0
        '
        'NumAppel
        '
        Me.NumAppel.HeaderText = "Numéro"
        Me.NumAppel.Name = "NumAppel"
        Me.NumAppel.ReadOnly = True
        '
        'DatAppel
        '
        Me.DatAppel.HeaderText = "Date"
        Me.DatAppel.Name = "DatAppel"
        Me.DatAppel.ReadOnly = True
        '
        'HeureAppel
        '
        Me.HeureAppel.HeaderText = "Heure"
        Me.HeureAppel.Name = "HeureAppel"
        Me.HeureAppel.ReadOnly = True
        '
        'DureAppel
        '
        Me.DureAppel.HeaderText = "Durée"
        Me.DureAppel.Name = "DureAppel"
        Me.DureAppel.ReadOnly = True
        '
        'CodTech
        '
        Me.CodTech.HeaderText = "Code du technicien"
        Me.CodTech.Name = "CodTech"
        Me.CodTech.ReadOnly = True
        '
        'NumCli
        '
        Me.NumCli.HeaderText = "Numéro du client"
        Me.NumCli.Name = "NumCli"
        Me.NumCli.ReadOnly = True
        '
        'btn_Sup
        '
        Me.btn_Sup.Location = New System.Drawing.Point(265, 12)
        Me.btn_Sup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Sup.Name = "btn_Sup"
        Me.btn_Sup.Size = New System.Drawing.Size(128, 36)
        Me.btn_Sup.TabIndex = 2
        Me.btn_Sup.Text = "&Supprimer"
        Me.btn_Sup.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Dgv3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(797, 457)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(712, 341)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Liste des appels"
        '
        'btn_Ferm
        '
        Me.btn_Ferm.Location = New System.Drawing.Point(416, 11)
        Me.btn_Ferm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Ferm.Name = "btn_Ferm"
        Me.btn_Ferm.Size = New System.Drawing.Size(100, 36)
        Me.btn_Ferm.TabIndex = 3
        Me.btn_Ferm.Text = "&Fermer"
        Me.btn_Ferm.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btn_Ferm)
        Me.Panel2.Controls.Add(Me.btn_Sup)
        Me.Panel2.Controls.Add(Me.btn_Mod)
        Me.Panel2.Controls.Add(Me.btn_Ajou)
        Me.Panel2.Location = New System.Drawing.Point(93, 288)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 63)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 460)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(775, 337)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des clients"
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumClii, Me.NomCli, Me.AdressCli, Me.TelCli, Me.TypCli, Me.LieuInterv})
        Me.Dgv1.Location = New System.Drawing.Point(8, 21)
        Me.Dgv1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(759, 309)
        Me.Dgv1.TabIndex = 0
        '
        'NumClii
        '
        Me.NumClii.FillWeight = 80.0!
        Me.NumClii.HeaderText = "Numéro"
        Me.NumClii.Name = "NumClii"
        Me.NumClii.ReadOnly = True
        Me.NumClii.Width = 120
        '
        'NomCli
        '
        Me.NomCli.HeaderText = "Nom"
        Me.NomCli.Name = "NomCli"
        Me.NomCli.ReadOnly = True
        Me.NomCli.Width = 200
        '
        'AdressCli
        '
        Me.AdressCli.HeaderText = "Adresse"
        Me.AdressCli.Name = "AdressCli"
        Me.AdressCli.ReadOnly = True
        '
        'TelCli
        '
        Me.TelCli.HeaderText = "Téléphone"
        Me.TelCli.Name = "TelCli"
        Me.TelCli.ReadOnly = True
        '
        'TypCli
        '
        Me.TypCli.HeaderText = "Type"
        Me.TypCli.Name = "TypCli"
        Me.TypCli.ReadOnly = True
        '
        'LieuInterv
        '
        Me.LieuInterv.HeaderText = "Lieu d'intervention"
        Me.LieuInterv.Name = "LieuInterv"
        Me.LieuInterv.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.F)
        Me.GroupBox2.Controls.Add(Me.EE)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.C)
        Me.GroupBox2.Controls.Add(Me.B)
        Me.GroupBox2.Controls.Add(Me.D)
        Me.GroupBox2.Controls.Add(Me.A)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(797, 90)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(712, 359)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "APPEL"
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(235, 169)
        Me.F.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(132, 26)
        Me.F.TabIndex = 18
        '
        'EE
        '
        Me.EE.Location = New System.Drawing.Point(235, 121)
        Me.EE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EE.Name = "EE"
        Me.EE.Size = New System.Drawing.Size(149, 26)
        Me.EE.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 172)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Durée :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Heure :"
        '
        'Timer1
        '
        '
        'GesAppel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1516, 811)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "GesAppel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesAppel"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents D As System.Windows.Forms.DateTimePicker
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents btn_Mod As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Ajou As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Sup As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Ferm As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents F As System.Windows.Forms.TextBox
    Friend WithEvents EE As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumClii As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdressCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LieuInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAppel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatAppel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeureAppel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureAppel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumCli As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
