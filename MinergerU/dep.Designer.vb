<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dep
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
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton19 = New Guna.UI.WinForms.GunaButton()
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
        Me.Panel1.Location = New System.Drawing.Point(-101, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 11)
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
        Me.GunaLinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.GunaLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(53, 29)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(342, 30)
        Me.GunaLinkLabel2.TabIndex = 25
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "Dépendance requise pour ce mod"
        Me.GunaLinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(68, 62)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(312, 46)
        Me.GunaLabel3.TabIndex = 26
        Me.GunaLabel3.Text = "Le mod en cours de téléchargement a besoin d'une dépencance." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(68, 105)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(312, 27)
        Me.GunaLabel1.TabIndex = 27
        Me.GunaLabel1.Text = "Nom de la dépendance"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(68, 135)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(312, 42)
        Me.GunaLabel2.TabIndex = 28
        Me.GunaLabel2.Text = "Minerger peut la télécharger pour vous." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voulez vous continuer ?"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.GunaButton1.Location = New System.Drawing.Point(71, 218)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 4
        Me.GunaButton1.Size = New System.Drawing.Size(309, 25)
        Me.GunaButton1.TabIndex = 30
        Me.GunaButton1.Text = "Télécharger seulement le mod"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaButton19.Location = New System.Drawing.Point(71, 183)
        Me.GunaButton19.Name = "GunaButton19"
        Me.GunaButton19.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaButton19.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaButton19.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton19.OnHoverImage = Nothing
        Me.GunaButton19.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton19.Radius = 4
        Me.GunaButton19.Size = New System.Drawing.Size(307, 30)
        Me.GunaButton19.TabIndex = 29
        Me.GunaButton19.Text = "Télécharger la dépendance"
        Me.GunaButton19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(448, 251)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaButton19)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLinkLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dep"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton13 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton19 As Guna.UI.WinForms.GunaButton
End Class
