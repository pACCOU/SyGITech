<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utilisateur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utilisateur))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.prenom = New System.Windows.Forms.TextBox
        Me.nom = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Stat = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cp = New System.Windows.Forms.TextBox
        Me.mp = New System.Windows.Forms.TextBox
        Me.id = New System.Windows.Forms.TextBox
        Me.Enrégistrer = New System.Windows.Forms.Button
        Me.Fermer = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 49)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENREGISTREMENT DES UTILISATEURS"
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
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(156, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 149)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utilisateur"
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(114, 92)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(269, 22)
        Me.prenom.TabIndex = 3
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(114, 44)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(117, 22)
        Me.nom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Prénoms :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Stat)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cp)
        Me.GroupBox2.Controls.Add(Me.mp)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(156, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 276)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sécurité"
        '
        'Stat
        '
        Me.Stat.FormattingEnabled = True
        Me.Stat.Items.AddRange(New Object() {"Administrateur", "Autres utilisateurs"})
        Me.Stat.Location = New System.Drawing.Point(228, 225)
        Me.Stat.Name = "Stat"
        Me.Stat.Size = New System.Drawing.Size(138, 24)
        Me.Stat.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Staut :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Reécrire mot de passe :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Mot de passe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Identifiant :"
        '
        'cp
        '
        Me.cp.Location = New System.Drawing.Point(228, 171)
        Me.cp.Name = "cp"
        Me.cp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cp.Size = New System.Drawing.Size(155, 22)
        Me.cp.TabIndex = 2
        '
        'mp
        '
        Me.mp.Location = New System.Drawing.Point(228, 107)
        Me.mp.Name = "mp"
        Me.mp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mp.Size = New System.Drawing.Size(155, 22)
        Me.mp.TabIndex = 1
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(228, 42)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(155, 22)
        Me.id.TabIndex = 0
        '
        'Enrégistrer
        '
        Me.Enrégistrer.Image = CType(resources.GetObject("Enrégistrer.Image"), System.Drawing.Image)
        Me.Enrégistrer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Enrégistrer.Location = New System.Drawing.Point(15, 10)
        Me.Enrégistrer.Name = "Enrégistrer"
        Me.Enrégistrer.Size = New System.Drawing.Size(88, 62)
        Me.Enrégistrer.TabIndex = 23
        Me.Enrégistrer.UseVisualStyleBackColor = True
        '
        'Fermer
        '
        Me.Fermer.Image = CType(resources.GetObject("Fermer.Image"), System.Drawing.Image)
        Me.Fermer.Location = New System.Drawing.Point(134, 10)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(87, 62)
        Me.Fermer.TabIndex = 25
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Fermer)
        Me.Panel2.Controls.Add(Me.Enrégistrer)
        Me.Panel2.Location = New System.Drawing.Point(294, 510)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 81)
        Me.Panel2.TabIndex = 26
        '
        'Utilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(815, 603)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Utilisateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilisateur"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents prenom As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cp As System.Windows.Forms.TextBox
    Friend WithEvents mp As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Enrégistrer As System.Windows.Forms.Button
    Friend WithEvents Fermer As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Stat As System.Windows.Forms.ComboBox
End Class
