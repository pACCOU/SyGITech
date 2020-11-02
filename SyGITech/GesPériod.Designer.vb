<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesPériod
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.NumClii = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.NomCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.B = New System.Windows.Forms.TextBox
        Me.A = New System.Windows.Forms.TextBox
        Me.AdressCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LieuInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C = New System.Windows.Forms.TextBox
        Me.TelCli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnFerm = New System.Windows.Forms.Button
        Me.Dgv3 = New System.Windows.Forms.DataGridView
        Me.CodInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumClis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PeriodeGarantie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSup = New System.Windows.Forms.Button
        Me.btnMod = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAjou = New System.Windows.Forms.Button
        Me.Dgv2 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Dgv1 = New System.Windows.Forms.DataGridView
        Me.CodeInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DatInterv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumGroupe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(9, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1073, 50)
        Me.Panel1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(934, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(870, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "HEURE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES PERIODES DE GARANTIES"
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
        'NumClii
        '
        Me.NumClii.FillWeight = 80.0!
        Me.NumClii.HeaderText = "Numéro"
        Me.NumClii.Name = "NumClii"
        Me.NumClii.ReadOnly = True
        Me.NumClii.Width = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Code intervention :"
        '
        'NomCli
        '
        Me.NomCli.HeaderText = "Nom"
        Me.NomCli.Name = "NomCli"
        Me.NomCli.ReadOnly = True
        Me.NomCli.Width = 200
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(193, 98)
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Size = New System.Drawing.Size(100, 22)
        Me.B.TabIndex = 14
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(193, 44)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(100, 22)
        Me.A.TabIndex = 13
        '
        'AdressCli
        '
        Me.AdressCli.HeaderText = "Adresse"
        Me.AdressCli.Name = "AdressCli"
        Me.AdressCli.ReadOnly = True
        '
        'LieuInterv
        '
        Me.LieuInterv.HeaderText = "Lieu d'intervention"
        Me.LieuInterv.Name = "LieuInterv"
        Me.LieuInterv.ReadOnly = True
        '
        'TypCli
        '
        Me.TypCli.HeaderText = "Type"
        Me.TypCli.Name = "TypCli"
        Me.TypCli.ReadOnly = True
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(193, 143)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(100, 22)
        Me.C.TabIndex = 7
        '
        'TelCli
        '
        Me.TelCli.HeaderText = "Téléphone"
        Me.TelCli.Name = "TelCli"
        Me.TelCli.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Numéro client :"
        '
        'Timer1
        '
        '
        'btnFerm
        '
        Me.btnFerm.Location = New System.Drawing.Point(460, 10)
        Me.btnFerm.Name = "btnFerm"
        Me.btnFerm.Size = New System.Drawing.Size(75, 29)
        Me.btnFerm.TabIndex = 3
        Me.btnFerm.Text = "&Fermer"
        Me.btnFerm.UseVisualStyleBackColor = True
        '
        'Dgv3
        '
        Me.Dgv3.AllowUserToAddRows = False
        Me.Dgv3.AllowUserToDeleteRows = False
        Me.Dgv3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodInterv, Me.NumClis, Me.PeriodeGarantie})
        Me.Dgv3.Location = New System.Drawing.Point(6, 19)
        Me.Dgv3.Name = "Dgv3"
        Me.Dgv3.ReadOnly = True
        Me.Dgv3.Size = New System.Drawing.Size(608, 319)
        Me.Dgv3.TabIndex = 0
        '
        'CodInterv
        '
        Me.CodInterv.HeaderText = "Code de l'intervention"
        Me.CodInterv.Name = "CodInterv"
        Me.CodInterv.ReadOnly = True
        '
        'NumClis
        '
        Me.NumClis.HeaderText = "Numéro du client"
        Me.NumClis.Name = "NumClis"
        Me.NumClis.ReadOnly = True
        '
        'PeriodeGarantie
        '
        Me.PeriodeGarantie.HeaderText = "Période de garanties"
        Me.PeriodeGarantie.Name = "PeriodeGarantie"
        Me.PeriodeGarantie.ReadOnly = True
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(307, 10)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(96, 29)
        Me.btnSup.TabIndex = 2
        Me.btnSup.Text = "&Supprimer"
        Me.btnSup.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(168, 10)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 29)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "&Modifier"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Dgv3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(462, 342)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(620, 344)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Liste des périodes de garanties"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.B)
        Me.GroupBox2.Controls.Add(Me.A)
        Me.GroupBox2.Controls.Add(Me.C)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(462, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 259)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POSSEDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Période de garanties :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnFerm)
        Me.Panel2.Controls.Add(Me.btnSup)
        Me.Panel2.Controls.Add(Me.btnMod)
        Me.Panel2.Controls.Add(Me.btnAjou)
        Me.Panel2.Location = New System.Drawing.Point(23, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 52)
        Me.Panel2.TabIndex = 0
        '
        'btnAjou
        '
        Me.btnAjou.Location = New System.Drawing.Point(38, 10)
        Me.btnAjou.Name = "btnAjou"
        Me.btnAjou.Size = New System.Drawing.Size(75, 29)
        Me.btnAjou.TabIndex = 0
        Me.btnAjou.Text = "&Ajouter"
        Me.btnAjou.UseVisualStyleBackColor = True
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumClii, Me.NomCli, Me.AdressCli, Me.TelCli, Me.TypCli, Me.LieuInterv})
        Me.Dgv2.Location = New System.Drawing.Point(6, 17)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.Size = New System.Drawing.Size(429, 321)
        Me.Dgv2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 342)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 344)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des clients"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Dgv1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(9, 77)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(443, 259)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Liste des interventions"
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeInterv, Me.TypInterv, Me.DatInterv, Me.NumGroupe})
        Me.Dgv1.Location = New System.Drawing.Point(6, 20)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(431, 233)
        Me.Dgv1.TabIndex = 0
        '
        'CodeInterv
        '
        Me.CodeInterv.HeaderText = "Code de l'intervention"
        Me.CodeInterv.Name = "CodeInterv"
        Me.CodeInterv.ReadOnly = True
        '
        'TypInterv
        '
        Me.TypInterv.HeaderText = "Type d'intervention"
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
        'NumGroupe
        '
        Me.NumGroupe.HeaderText = "Numéro du groupe"
        Me.NumGroupe.Name = "NumGroupe"
        Me.NumGroupe.ReadOnly = True
        '
        'GesPériod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1094, 698)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GesPériod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesPériod"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NumClii As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NomCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents AdressCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LieuInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents TelCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnFerm As System.Windows.Forms.Button
    Friend WithEvents Dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAjou As System.Windows.Forms.Button
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodeInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumGroupe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodInterv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumClis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodeGarantie As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
