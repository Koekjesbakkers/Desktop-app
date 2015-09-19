Public Class Login
    Dim setting As New My.MySettings()

    Private Sub Button1_click(sender As Object, e As EventArgs) Handles Button1.Click


        If UsernameText.Text = ("WR") And PasswordText.Text = ("test") Then

            Welkom.Show()
            Welkom.MaskedTextBox1.Text = ("Welcome Wesley Reinders")
            Me.Hide()
            MsgBox("Welcome Wesley Reinders", MsgBoxStyle.Exclamation)
        ElseIf UsernameText.Text = setting.Username2 And PasswordText.Text = setting.pass2 Then
            Welkom.Show()
            Welkom.MaskedTextBox1.Text = ("Welcome Hakan Kartal")
            Me.Hide()
            MsgBox("Welcome Hakan Kartal", MsgBoxStyle.Exclamation)









        Else
            MsgBox("Incorrect Login Details", MsgBoxStyle.Critical)

        End If
        'If CheckBox1.Checked = True And UsernameText.Text = "WR" And PasswordText.Text = setting.pass Then
        'Change.Show()
        'Welkom.Close()




        'End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameText.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub PasswordText_TextChanged(sender As Object, e As EventArgs) Handles PasswordText.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Enter(sender As Object, e As EventArgs) Handles Button1.Enter

    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.dropbox.com/home/Public/Desktop%20app/Desktop%20App")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
            MessageBox.Show("You have the current version")
        Else
            MessageBox.Show("Newer version available")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
