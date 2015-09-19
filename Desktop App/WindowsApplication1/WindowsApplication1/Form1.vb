Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Hakan" And TextBox2.Text = "Nuke6" Or TextBox1.Text = "Wesley" And TextBox2.Text = "Nuke5" Then
            Welkom.Show()
            Me.Hide()
        Else
            MsgBox("Foute inlog code")
            Me.Close()


        End If
    End Sub
End Class
