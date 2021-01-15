<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup2
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaButton13 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaButton19 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.MinergerU.My.MySettings.Default.colorheader
        Me.Panel1.Controls.Add(Me.GunaButton13)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.MinergerU.My.MySettings.Default, "colorheader", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 11)
        Me.Panel1.TabIndex = 24
        '
        'GunaButton13
        '
        Me.GunaButton13.Animated = True
        Me.GunaButton13.AnimationHoverSpeed = 0.07!
        Me.GunaButton13.AnimationSpeed = 0.03!
        Me.GunaButton13.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton13.BaseColor = Global.MinergerU.My.MySettings.Default.bcolor
        Me.GunaButton13.BorderColor = Global.MinergerU.My.MySettings.Default.bcolor
        Me.GunaButton13.BorderSize = 2
        Me.GunaButton13.DataBindings.Add(New System.Windows.Forms.Binding("BaseColor", Global.MinergerU.My.MySettings.Default, "bcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GunaButton13.DataBindings.Add(New System.Windows.Forms.Binding("OnHoverBaseColor", Global.MinergerU.My.MySettings.Default, "onhoverbasecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GunaButton13.DataBindings.Add(New System.Windows.Forms.Binding("OnHoverBorderColor", Global.MinergerU.My.MySettings.Default, "onhoverbasecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GunaButton13.DataBindings.Add(New System.Windows.Forms.Binding("BorderColor", Global.MinergerU.My.MySettings.Default, "bcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GunaButton13.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton13.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton13.ForeColor = System.Drawing.Color.White
        Me.GunaButton13.Image = Nothing
        Me.GunaButton13.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton13.Location = New System.Drawing.Point(604, 4)
        Me.GunaButton13.Name = "GunaButton13"
        Me.GunaButton13.OnHoverBaseColor = Global.MinergerU.My.MySettings.Default.onhoverbasecolor
        Me.GunaButton13.OnHoverBorderColor = Global.MinergerU.My.MySettings.Default.onhoverbasecolor
        Me.GunaButton13.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton13.OnHoverImage = Nothing
        Me.GunaButton13.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton13.Radius = 10
        Me.GunaButton13.Size = New System.Drawing.Size(43, 30)
        Me.GunaButton13.TabIndex = 20
        Me.GunaButton13.Text = "x"
        Me.GunaButton13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLinkLabel2
        '
        Me.GunaLinkLabel2.ActiveLinkColor = System.Drawing.Color.White
        Me.GunaLinkLabel2.AutoSize = True
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.GunaLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(61, 21)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(168, 60)
        Me.GunaLinkLabel2.TabIndex = 25
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "Téléchargement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "terminé"
        Me.GunaLinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaButton19
        '
        Me.GunaButton19.Animated = True
        Me.GunaButton19.AnimationHoverSpeed = 0.07!
        Me.GunaButton19.AnimationSpeed = 0.03!
        Me.GunaButton19.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton19.BaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaButton19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaButton19.BorderSize = 2
        Me.GunaButton19.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton19.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton19.ForeColor = System.Drawing.Color.White
        Me.GunaButton19.Image = Nothing
        Me.GunaButton19.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton19.Location = New System.Drawing.Point(64, 84)
        Me.GunaButton19.Name = "GunaButton19"
        Me.GunaButton19.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaButton19.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaButton19.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton19.OnHoverImage = Nothing
        Me.GunaButton19.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton19.Radius = 4
        Me.GunaButton19.Size = New System.Drawing.Size(162, 24)
        Me.GunaButton19.TabIndex = 26
        Me.GunaButton19.Text = "Accéder au dossier"
        Me.GunaButton19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaButton1.BorderSize = 2
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(88, 114)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 4
        Me.GunaButton1.Size = New System.Drawing.Size(114, 21)
        Me.GunaButton1.TabIndex = 27
        Me.GunaButton1.Text = "Fermer"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'popup2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 145)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaButton19)
        Me.Controls.Add(Me.GunaLinkLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "popup2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "popup2"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton13 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton19 As Guna.UI.WinForms.GunaButton
End Class
