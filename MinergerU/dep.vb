Imports MySql.Data.MySqlClient
Imports System.Net
Public Class dep

    Private Sub dep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        If dep1 = "mods1" Then
            GunaLabel1.Text = mods1.ListView1.Items(0).SubItems(8).Text
            GunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter

        Else

            If dep1 = "mods2" Then
                GunaLabel1.Text = mods1.ListView1.Items(1).SubItems(8).Text
                GunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Else

                If dep1 = "mods3" Then
                    GunaLabel1.Text = mods1.ListView1.Items(2).SubItems(8).Text
                    GunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
                End If
            End If
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Close()
    End Sub
    Dim Client1 As WebClient = New WebClient
    Private Sub GunaButton19_Click(sender As Object, e As EventArgs) Handles GunaButton19.Click
        If dep1 = "mods1" Then

        Else
            If dep1 = "mods2" Then

            Else
                If dep1 = "mods3" Then
                    AddHandler Client1.DownloadFileCompleted, AddressOf client1_DownloadCompleted

                    Client1.DownloadFileAsync(New Uri(mods1.ListView1.Items(2).SubItems(9).Text), mods1.TB_chemin_dossier.Text & "\" + mods1.ListView1.Items(2).SubItems(10).Text)
                End If
            End If
        End If
    End Sub
    Private Sub client1_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        Me.Hide()
    End Sub
End Class