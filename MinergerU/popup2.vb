Public Class popup2
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Close()
    End Sub

    Private Sub GunaButton19_Click(sender As Object, e As EventArgs) Handles GunaButton19.Click
        Process.Start("explorer.exe", mods1.TB_chemin_dossier.Text)

    End Sub

    Private Sub popup2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mods1.TabControl1.SelectTab(0)
        mods1.GunaAdvenceButton3.Enabled = True

    End Sub
End Class