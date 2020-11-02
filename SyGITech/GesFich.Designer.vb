<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesFich
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Dgv2 = New System.Windows.Forms.DataGridView
        Me.NumSerie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomMat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumClit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Dgv1 = New System.Windows.Forms.DataGridView
        Me.Immat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NbPlace = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C = New System.Windows.Forms.TextBox
        Me.B = New System.Windows.Forms.TextBox
        Me.Dtp = New System.Windows.Forms.DateTimePicker
        Me.A = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnFerm = New System.Windows.Forms.Button
        Me.btnSup = New System.Windows.Forms.Button
        Me.btnMod = New System.Windows.Forms.Button
        Me.btnAjou = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Dgv3 = New System.Windows.Forms.DataGridView
        Me.NumFich = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DatFich = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumMat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Imma = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 217)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des matériels"
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumSerie, Me.NomMat, Me.Marque, Me.Model, Me.NumClit})
        Me.Dgv2.Location = New System.Drawing.Point(6, 19)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.Size = New System.Drawing.Size(431, 192)
        Me.Dgv2.TabIndex = 0
        '
        'NumSerie
        '
        Me.NumSerie.HeaderText = "Numéro"
        Me.NumSerie.Name = "NumSerie"
        Me.NumSerie.ReadOnly = True
        '
        'NomMat
        '
        Me.NomMat.HeaderText = "Nom"
        Me.NomMat.Name = "NomMat"
        Me.NomMat.ReadOnly = True
        '
        'Marque
        '
        Me.Marque.HeaderText = "Marque"
        Me.Marque.Name = "Marque"
        Me.Marque.ReadOnly = True
        '
        'Model
        '
        Me.Model.HeaderText = "Modèle"
        Me.Model.Name = "Model"
        Me.Model.ReadOnly = True
        '
        'NumClit
        '
        Me.NumClit.HeaderText = "Numéro du client"
        Me.NumClit.Name = "NumClit"
        Me.NumClit.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 301)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des véhicules"
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Immat, Me.NbPlace})
        Me.Dgv1.Location = New System.Drawing.Point(6, 17)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(431, 278)
        Me.Dgv1.TabIndex = 0
        '
        'Immat
        '
        Me.Immat.FillWeight = 80.0!
        Me.Immat.HeaderText = "Immatriculation"
        Me.Immat.Name = "Immat"
        Me.Immat.ReadOnly = True
        '
        'NbPlace
        '
        Me.NbPlace.HeaderText = "Nombre de places"
        Me.NbPlace.Name = "NbPlace"
        Me.NbPlace.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C)
        Me.GroupBox2.Controls.Add(Me.B)
        Me.GroupBox2.Controls.Add(Me.Dtp)
        Me.GroupBox2.Controls.Add(Me.A)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(458, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 217)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FICHE"
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(201, 129)
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Size = New System.Drawing.Size(190, 22)
        Me.C.TabIndex = 14
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(201, 94)
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Size = New System.Drawing.Size(190, 22)
        Me.B.TabIndex = 13
        '
        'Dtp
        '
        Me.Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp.Location = New System.Drawing.Point(199, 61)
        Me.Dtp.Name = "Dtp"
        Me.Dtp.Size = New System.Drawing.Size(113, 22)
        Me.Dtp.TabIndex = 10
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(199, 28)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(100, 22)
        Me.A.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Immatriculation véhicule :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numéro série matériel :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnFerm)
        Me.Panel2.Controls.Add(Me.btnSup)
        Me.Panel2.Controls.Add(Me.btnMod)
        Me.Panel2.Controls.Add(Me.btnAjou)
        Me.Panel2.Location = New System.Drawing.Point(15, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 52)
        Me.Panel2.TabIndex = 0
        '
        'btnFerm
        '
        Me.btnFerm.Location = New System.Drawing.Point(312, 9)
        Me.btnFerm.Name = "btnFerm"
        Me.btnFerm.Size = New System.Drawing.Size(75, 29)
        Me.btnFerm.TabIndex = 3
        Me.btnFerm.Text = "&Fermer"
        Me.btnFerm.UseVisualStyleBackColor = True
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(199, 10)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(96, 29)
        Me.btnSup.TabIndex = 2
        Me.btnSup.Text = "&Supprimer"
        Me.btnSup.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(105, 10)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 29)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "&Modifier"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnAjou
        '
        Me.btnAjou.Location = New System.Drawing.Point(12, 9)
        Me.btnAjou.Name = "btnAjou"
        Me.btnAjou.Size = New System.Drawing.Size(75, 29)
        Me.btnAjou.TabIndex = 0
        Me.btnAjou.Text = "&Ajouter"
        Me.btnAjou.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 50)
        Me.Panel1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(690, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(620, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "HEURE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES FICHES"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Dgv3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(458, 293)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(443, 301)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Liste des fiches"
        '
        'Dgv3
        '
        Me.Dgv3.AllowUserToAddRows = False
        Me.Dgv3.AllowUserToDeleteRows = False
        Me.Dgv3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumFich, Me.DatFich, Me.NumMat, Me.Imma})
        Me.Dgv3.Location = New System.Drawing.Point(6, 19)
        Me.Dgv3.Name = "Dgv3"
        Me.Dgv3.ReadOnly = True
        Me.Dgv3.Size = New System.Drawing.Size(429, 276)
        Me.Dgv3.TabIndex = 0
        '
        'NumFich
        '
        Me.NumFich.HeaderText = "Numéro"
        Me.NumFich.Name = "NumFich"
        Me.NumFich.ReadOnly = True
        Me.NumFich.Width = 80
        '
        'DatFich
        '
        Me.DatFich.HeaderText = "Date"
        Me.DatFich.Name = "DatFich"
        Me.DatFich.ReadOnly = True
        '
        'NumMat
        '
        Me.NumMat.HeaderText = "Numéro de série du matériel"
        Me.NumMat.Name = "NumMat"
        Me.NumMat.ReadOnly = True
        Me.NumMat.Width = 120
        '
        'Imma
        '
        Me.Imma.HeaderText = "Immatriculation du véhicule"
        Me.Imma.Name = "Imma"
        Me.Imma.ReadOnly = True
        Me.Imma.Width = 120
        '
        'Timer1
        '
        '
        'GesFich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(911, 606)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GesFich"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesFich"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents NumSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomMat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumClit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnFerm As System.Windows.Forms.Button
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnAjou As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents Immat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NbPlace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFich As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatFich As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumMat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents Dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
