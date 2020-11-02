<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesVeh
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Dgv = New System.Windows.Forms.DataGridView
        Me.Immat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NbPlace = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.B = New System.Windows.Forms.TextBox
        Me.A = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_fer = New System.Windows.Forms.Button
        Me.btn_mod = New System.Windows.Forms.Button
        Me.btn_sup = New System.Windows.Forms.Button
        Me.btn_ajou = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des véhicules"
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Immat, Me.NbPlace})
        Me.Dgv.Location = New System.Drawing.Point(3, 21)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.Size = New System.Drawing.Size(447, 211)
        Me.Dgv.TabIndex = 0
        '
        'Immat
        '
        Me.Immat.HeaderText = "Immatriculation"
        Me.Immat.Name = "Immat"
        Me.Immat.ReadOnly = True
        '
        'NbPlace
        '
        Me.NbPlace.FillWeight = 120.0!
        Me.NbPlace.HeaderText = "Nombre de place"
        Me.NbPlace.Name = "NbPlace"
        Me.NbPlace.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.B)
        Me.GroupBox2.Controls.Add(Me.A)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(465, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(469, 238)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VEHICULE"
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(168, 92)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(100, 22)
        Me.B.TabIndex = 8
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(166, 46)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(100, 22)
        Me.A.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_fer)
        Me.Panel1.Controls.Add(Me.btn_mod)
        Me.Panel1.Controls.Add(Me.btn_sup)
        Me.Panel1.Controls.Add(Me.btn_ajou)
        Me.Panel1.Location = New System.Drawing.Point(55, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 56)
        Me.Panel1.TabIndex = 6
        '
        'btn_fer
        '
        Me.btn_fer.Location = New System.Drawing.Point(261, 12)
        Me.btn_fer.Name = "btn_fer"
        Me.btn_fer.Size = New System.Drawing.Size(75, 34)
        Me.btn_fer.TabIndex = 1
        Me.btn_fer.Text = "&Fermer"
        Me.btn_fer.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(84, 10)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(75, 34)
        Me.btn_mod.TabIndex = 4
        Me.btn_mod.Text = "&Modifier"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_sup
        '
        Me.btn_sup.Location = New System.Drawing.Point(165, 10)
        Me.btn_sup.Name = "btn_sup"
        Me.btn_sup.Size = New System.Drawing.Size(90, 34)
        Me.btn_sup.TabIndex = 5
        Me.btn_sup.Text = "&Supprimer"
        Me.btn_sup.UseVisualStyleBackColor = True
        '
        'btn_ajou
        '
        Me.btn_ajou.Location = New System.Drawing.Point(3, 10)
        Me.btn_ajou.Name = "btn_ajou"
        Me.btn_ajou.Size = New System.Drawing.Size(75, 34)
        Me.btn_ajou.TabIndex = 3
        Me.btn_ajou.Text = "&Ajouter"
        Me.btn_ajou.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Immatriculation :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de places :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DES VEHICULES"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 60)
        Me.Panel2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(720, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "HEURE :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(811, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SyGITech.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'GesVeh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(940, 350)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GesVeh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesVeh"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_mod As System.Windows.Forms.Button
    Friend WithEvents btn_sup As System.Windows.Forms.Button
    Friend WithEvents btn_ajou As System.Windows.Forms.Button
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents btn_fer As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Immat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NbPlace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
