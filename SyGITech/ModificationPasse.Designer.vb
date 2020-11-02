<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificationPasse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificationPasse))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cp = New System.Windows.Forms.TextBox
        Me.np = New System.Windows.Forms.TextBox
        Me.anc = New System.Windows.Forms.TextBox
        Me.id = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Valider = New System.Windows.Forms.Button
        Me.fermer = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 49)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MODIFICATION D'UN MOT DE PASSE"
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
        Me.GroupBox1.Controls.Add(Me.cp)
        Me.GroupBox1.Controls.Add(Me.np)
        Me.GroupBox1.Controls.Add(Me.anc)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(165, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 290)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utilisateur"
        '
        'cp
        '
        Me.cp.Location = New System.Drawing.Point(244, 218)
        Me.cp.Name = "cp"
        Me.cp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cp.Size = New System.Drawing.Size(119, 22)
        Me.cp.TabIndex = 7
        '
        'np
        '
        Me.np.Location = New System.Drawing.Point(244, 157)
        Me.np.Name = "np"
        Me.np.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.np.Size = New System.Drawing.Size(119, 22)
        Me.np.TabIndex = 6
        '
        'anc
        '
        Me.anc.Location = New System.Drawing.Point(244, 100)
        Me.anc.Name = "anc"
        Me.anc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.anc.Size = New System.Drawing.Size(119, 22)
        Me.anc.TabIndex = 5
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(244, 47)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 22)
        Me.id.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Confirmer mot de passe :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nouveau mot de passe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ancien mot de passe :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identifiant :"
        '
        'Valider
        '
        Me.Valider.Image = CType(resources.GetObject("Valider.Image"), System.Drawing.Image)
        Me.Valider.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Valider.Location = New System.Drawing.Point(16, 16)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(88, 62)
        Me.Valider.TabIndex = 8
        Me.Valider.UseVisualStyleBackColor = True
        '
        'fermer
        '
        Me.fermer.Image = CType(resources.GetObject("fermer.Image"), System.Drawing.Image)
        Me.fermer.Location = New System.Drawing.Point(298, 16)
        Me.fermer.Name = "fermer"
        Me.fermer.Size = New System.Drawing.Size(88, 62)
        Me.fermer.TabIndex = 9
        Me.fermer.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.fermer)
        Me.Panel2.Controls.Add(Me.Valider)
        Me.Panel2.Location = New System.Drawing.Point(165, 375)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 92)
        Me.Panel2.TabIndex = 10
        '
        'ModificationPasse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(743, 491)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ModificationPasse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificationPasse"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cp As System.Windows.Forms.TextBox
    Friend WithEvents np As System.Windows.Forms.TextBox
    Friend WithEvents anc As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Valider As System.Windows.Forms.Button
    Friend WithEvents fermer As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
