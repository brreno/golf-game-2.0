Public Class frmMainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSettings.Show()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSettings.Hide()
        Me.Location = New Point(0, 0)

        My.Computer.Audio.Play(My.Resources.GOLFMUSIC, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmLevelSelect.Show()
    End Sub


End Class