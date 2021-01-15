
Imports Newtonsoft.Json
Imports AutoUpdaterDotNET


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        If mods1.GunaCheckBox6.Checked = True Then


            mods1.Show()
            Me.Opacity = 0%
            Me.ShowInTaskbar = False
        Else

        End If

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Me.Close()
    End Sub

    Private Sub GunaButton1_Click_1(sender As Object, e As EventArgs) Handles GunaButton1.Click
        mods1.Show()
        AutoUpdater.Start("https://minerger.fr/Updates/maj.xml")
        ShowIcon = False
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mods1.Show()
        Me.Hide()
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked


    End Sub
End Class