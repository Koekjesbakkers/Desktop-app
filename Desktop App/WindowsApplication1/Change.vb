Public Class Change
    Dim setting As New My.MySettings()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CurrentPass.Text = setting.pass Then
            setting.pass = NewPass.Text
            setting.Save()









            End
        Else
            MsgBox("Error!!", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class