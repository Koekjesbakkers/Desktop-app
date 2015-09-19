Public Class Admin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welkom.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Typer.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Login.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If Login.UsernameText.Text = ("HK") Then Process.Start("C:\Riot Games\League of Legends\lol.launcher.exe") Else MsgBox("File not found")
        If Login.UsernameText.Text = ("WR") Then Process.Start("G:\Games\lol\lol.laucher.exe") Else MsgBox("File not found")








    End Sub

    Private Sub minigamebutton_Click(sender As Object, e As EventArgs) Handles minigamebutton.Click
        MiniMazeGame.Show()
    End Sub
End Class