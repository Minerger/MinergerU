<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class popup1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaButton13 = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinkLabel2
        '
        Me.GunaLinkLabel2.ActiveLinkColor = System.Drawing.Color.White
        Me.GunaLinkLabel2.AutoSize = True
        Me.GunaLinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.GunaLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(61, 21)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(168, 60)
        Me.GunaLinkLabel2.TabIndex = 20
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "Téléchargement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en cours"
        Me.GunaLinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        'Panel1
        '
        Me.Panel1.BackColor = Global.MinergerU.My.MySettings.Default.colorheader
        Me.Panel1.Controls.Add(Me.GunaButton13)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.MinergerU.My.MySettings.Default, "colorheader", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(-206, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 11)
        Me.Panel1.TabIndex = 23
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(57, 87)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(177, 26)
        Me.GunaLinkLabel1.TabIndex = 25
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Le panel de mods sera accessible" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "à la fin du téléchargement"
        Me.GunaLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaProgressBar1.Location = New System.Drawing.Point(54, 117)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaProgressBar1.Size = New System.Drawing.Size(183, 21)
        Me.GunaProgressBar1.TabIndex = 26
        Me.GunaProgressBar1.Value = 100
        '
        'popup1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 144)
        Me.Controls.Add(Me.GunaProgressBar1)
        Me.Controls.Add(Me.GunaLinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaLinkLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "popup1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "popup1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton13 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
End Class
