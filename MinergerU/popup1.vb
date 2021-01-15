
Imports System.IO
Public Class popup1
    Private Sub GunaButton19_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub popup1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mods1.TabControl1.SelectTab(10)
        mods1.GunaAdvenceButton3.Enabled = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked

    End Sub
    ' Private Sub popup1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    System.Threading.Thread.Sleep(5000)
    'Me.Close()
    ' End Sub
End Class