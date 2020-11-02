<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesFact
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.NumFiche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatFich = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Immat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dgv2 = New System.Windows.Forms.DataGridView()
        Me.CodInterve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypInterv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatInterv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dgv3 = New System.Windows.Forms.DataGridView()
        Me.CodTache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibTâch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DureTheo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodTech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.D = New System.Windows.Forms.DateTimePicker()
        Me.F = New System.Windows.Forms.TextBox()
        Me.EE = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.TextBox()
        Me.B = New System.Windows.Forms.TextBox()
        Me.A = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Ferm = New System.Windows.Forms.Button()
        Me.btn_Sup = New System.Windows.Forms.Button()
        Me.btn_Mod = New System.Windows.Forms.Button()
        Me.btn_Ajou = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Dgv4 = New System.Windows.Forms.DataGridView()
        Me.NumFich = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodInterv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodTach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dureff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dgv4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(593, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des fiches"
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumFiche, Me.DatFich, Me.NumSerie, Me.Immat})
        Me.Dgv1.Location = New System.Drawing.Point(8, 26)
        Me.Dgv1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(576, 267)
        Me.Dgv1.TabIndex = 18
        '
        'NumFiche
        '
        Me.NumFiche.HeaderText = "Numéro"
        Me.NumFiche.Name = "NumFiche"
        Me.NumFiche.ReadOnly = True
        '
        'DatFich
        '
        Me.DatFich.HeaderText = "Date"
        Me.DatFich.Name = "DatFich"
        Me.DatFich.ReadOnly = True
        '
        'NumSerie
        '
        Me.NumSerie.HeaderText = "Numérode serie du matériel"
        Me.NumSerie.Name = "NumSerie"
        Me.NumSerie.ReadOnly = True
        '
        'Immat
        '
        Me.Immat.HeaderText = "Immatriculation du véhicule"
        Me.Immat.Name = "Immat"
        Me.Immat.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgv2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 404)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(593, 219)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste des interventions"
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodInterve, Me.TypInterv, Me.DatInterv, Me.NumGroup})
        Me.Dgv2.Location = New System.Drawing.Point(8, 26)
        Me.Dgv2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.Size = New System.Drawing.Size(576, 186)
        Me.Dgv2.TabIndex = 19
        '
        'CodInterve
        '
        Me.CodInterve.HeaderText = "Code"
        Me.CodInterve.Name = "CodInterve"
        Me.CodInterve.ReadOnly = True
        '
        'TypInterv
        '
        Me.TypInterv.HeaderText = "Type"
        Me.TypInterv.Name = "TypInterv"
        Me.TypInterv.ReadOnly = True
        Me.TypInterv.Width = 200
        '
        'DatInterv
        '
        Me.DatInterv.HeaderText = "Date"
        Me.DatInterv.Name = "DatInterv"
        Me.DatInterv.ReadOnly = True
        '
        'NumGroup
        '
        Me.NumGroup.HeaderText = "Numéro du groupe de techniciens"
        Me.NumGroup.Name = "NumGroup"
        Me.NumGroup.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(29, 630)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(593, 273)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des tâches"
        '
        'Dgv3
        '
        Me.Dgv3.AllowUserToAddRows = False
        Me.Dgv3.AllowUserToDeleteRows = False
        Me.Dgv3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodTache, Me.LibTâch, Me.DureTheo, Me.CodTech})
        Me.Dgv3.Location = New System.Drawing.Point(4, 22)
        Me.Dgv3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv3.Name = "Dgv3"
        Me.Dgv3.ReadOnly = True
        Me.Dgv3.Size = New System.Drawing.Size(580, 244)
        Me.Dgv3.TabIndex = 0
        '
        'CodTache
        '
        Me.CodTache.HeaderText = "Code"
        Me.CodTache.Name = "CodTache"
        Me.CodTache.ReadOnly = True
        '
        'LibTâch
        '
        Me.LibTâch.HeaderText = "Libellé"
        Me.LibTâch.Name = "LibTâch"
        Me.LibTâch.ReadOnly = True
        Me.LibTâch.Width = 200
        '
        'DureTheo
        '
        Me.DureTheo.HeaderText = "Durée théorique"
        Me.DureTheo.Name = "DureTheo"
        Me.DureTheo.ReadOnly = True
        '
        'CodTech
        '
        Me.CodTech.HeaderText = "Code du technicien"
        Me.CodTech.Name = "CodTech"
        Me.CodTech.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.D)
        Me.GroupBox4.Controls.Add(Me.F)
        Me.GroupBox4.Controls.Add(Me.EE)
        Me.GroupBox4.Controls.Add(Me.C)
        Me.GroupBox4.Controls.Add(Me.B)
        Me.GroupBox4.Controls.Add(Me.A)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Panel2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(647, 81)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(716, 315)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Facturer"
        '
        'D
        '
        Me.D.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D.Location = New System.Drawing.Point(264, 130)
        Me.D.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(132, 26)
        Me.D.TabIndex = 13
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(264, 206)
        Me.F.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(132, 26)
        Me.F.TabIndex = 12
        '
        'EE
        '
        Me.EE.Location = New System.Drawing.Point(264, 170)
        Me.EE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EE.Name = "EE"
        Me.EE.Size = New System.Drawing.Size(132, 26)
        Me.EE.TabIndex = 11
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(264, 98)
        Me.C.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Size = New System.Drawing.Size(132, 26)
        Me.C.TabIndex = 10
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(264, 64)
        Me.B.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Size = New System.Drawing.Size(132, 26)
        Me.B.TabIndex = 9
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(264, 28)
        Me.A.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(132, 26)
        Me.A.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 209)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Montant :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Durée effective :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 137)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Code tâche :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Code intervention :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numéro fiche :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btn_Ferm)
        Me.Panel2.Controls.Add(Me.btn_Sup)
        Me.Panel2.Controls.Add(Me.btn_Mod)
        Me.Panel2.Controls.Add(Me.btn_Ajou)
        Me.Panel2.Location = New System.Drawing.Point(31, 244)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 63)
        Me.Panel2.TabIndex = 1
        '
        'btn_Ferm
        '
        Me.btn_Ferm.Location = New System.Drawing.Point(528, 12)
        Me.btn_Ferm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Ferm.Name = "btn_Ferm"
        Me.btn_Ferm.Size = New System.Drawing.Size(100, 36)
        Me.btn_Ferm.TabIndex = 3
        Me.btn_Ferm.Text = "&Fermer"
        Me.btn_Ferm.UseVisualStyleBackColor = True
        '
        'btn_Sup
        '
        Me.btn_Sup.Location = New System.Drawing.Point(343, 12)
        Me.btn_Sup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Sup.Name = "btn_Sup"
        Me.btn_Sup.Size = New System.Drawing.Size(128, 36)
        Me.btn_Sup.TabIndex = 2
        Me.btn_Sup.Text = "&Supprimer"
        Me.btn_Sup.UseVisualStyleBackColor = True
        '
        'btn_Mod
        '
        Me.btn_Mod.Location = New System.Drawing.Point(177, 12)
        Me.btn_Mod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Mod.Name = "btn_Mod"
        Me.btn_Mod.Size = New System.Drawing.Size(100, 36)
        Me.btn_Mod.TabIndex = 1
        Me.btn_Mod.Text = "&Modifier"
        Me.btn_Mod.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(29, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1332, 61)
        Me.Panel1.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1155, 23)
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
        Me.Label6.Location = New System.Drawing.Point(1048, 26)
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
        Me.Label1.Location = New System.Drawing.Point(480, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES FACTURES"
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Dgv4)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(647, 411)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(716, 492)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Liste des factures"
        '
        'Dgv4
        '
        Me.Dgv4.AllowUserToAddRows = False
        Me.Dgv4.AllowUserToDeleteRows = False
        Me.Dgv4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumFich, Me.CodInterv, Me.CodTach, Me.DatFact, Me.Dureff, Me.Montant})
        Me.Dgv4.Location = New System.Drawing.Point(8, 22)
        Me.Dgv4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv4.Name = "Dgv4"
        Me.Dgv4.ReadOnly = True
        Me.Dgv4.Size = New System.Drawing.Size(700, 463)
        Me.Dgv4.TabIndex = 0
        '
        'NumFich
        '
        Me.NumFich.HeaderText = "Numéro de fiche"
        Me.NumFich.Name = "NumFich"
        Me.NumFich.ReadOnly = True
        '
        'CodInterv
        '
        Me.CodInterv.HeaderText = "Code de l'intervention"
        Me.CodInterv.Name = "CodInterv"
        Me.CodInterv.ReadOnly = True
        '
        'CodTach
        '
        Me.CodTach.HeaderText = "Code de la tâche"
        Me.CodTach.Name = "CodTach"
        Me.CodTach.ReadOnly = True
        '
        'DatFact
        '
        Me.DatFact.HeaderText = "Date"
        Me.DatFact.Name = "DatFact"
        Me.DatFact.ReadOnly = True
        '
        'Dureff
        '
        Me.Dureff.HeaderText = "Durée effective"
        Me.Dureff.Name = "Dureff"
        Me.Dureff.ReadOnly = True
        '
        'Montant
        '
        Me.Montant.HeaderText = "Montant"
        Me.Montant.Name = "Montant"
        Me.Montant.ReadOnly = True
        Me.Montant.Width = 130
        '
        'Timer1
        '
        '
        'GesFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1375, 918)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "GesFact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesFact"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Dgv4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Ferm As System.Windows.Forms.Button
    Friend WithEvents btn_Sup As System.Windows.Forms.Button
    Friend WithEvents btn_Mod As System.Windows.Forms.Button
    Friend WithEvents btn_Ajou As System.Windows.Forms.Button
    Friend WithEvents F As System.Windows.Forms.TextBox
    Friend WithEvents EE As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv4 As System.Windows.Forms.DataGridView
    Friend WithEvents D As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumFich As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatFact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dureff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Montant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFiche As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatFich As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Immat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodInterve As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibTâch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureTheo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
