Imports System.Web
Imports Awesomium.Core

Public Class Form1

    Private Sub btn_GoBack_Click(sender As Object, e As EventArgs) Handles btn_GoBack.Click
        WebControl2.GoBack()
    End Sub

    Private Sub btn_GoForward_Click(sender As Object, e As EventArgs) Handles btn_GoForward.Click
        WebControl2.GoForward()
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        If txtB_Link.Text.Contains("http://") Or txtB_Link.Text.Contains("https://") Then
            WebControl2.Source = New Uri(txtB_Link.Text)
        ElseIf Not txtB_Link.Text.Contains("http://") Then
            WebControl2.Source = New Uri("http://" + txtB_Link.Text)

        End If
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        WebControl2.Refresh()
    End Sub

    Private Sub btn_NewTab_Click(sender As Object, e As EventArgs) Handles btn_NewTab.Click
        Dim l As New Form1
        l.Show()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Stop_Click(sender As Object, e As EventArgs) Handles btn_Stop.Click
        WebControl2.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebControl1.Enabled = False
        WebControl2.Source = New Uri("http://google.com.br")
    End Sub

    Private Sub Aba1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Aba1ToolStripMenuItem.Click
        WebControl2.Source = New Uri("http://google.com.br")
    End Sub

    Private Sub YoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeToolStripMenuItem.Click
        WebControl2.Source = New Uri("http://youtube.com.br")
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookToolStripMenuItem.Click
        WebControl2.Source = New Uri("http://facebook.com.br")
    End Sub

    Private Sub GmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GmailToolStripMenuItem.Click
        WebControl2.Source = New Uri("http://gmail.com.br")
    End Sub

    Private Sub HotmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotmailToolStripMenuItem.Click
        WebControl2.Source = New Uri("http://hotmail.com.br")
    End Sub

    Private Sub NetflixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetflixToolStripMenuItem.Click
        WebControl2.Source = New Uri("http://netflix.com.br")
    End Sub

    Private Sub WebControl2_TargetURLChanged(sender As Object, e As UrlEventArgs) Handles WebControl2.TargetURLChanged
        txtB_Link.Text = WebControl2.Source.ToString
    End Sub
End Class
