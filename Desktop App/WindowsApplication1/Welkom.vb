Imports System.Net.Mail

Public Class Welkom

    Private Sub Label1_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Website.Show()



        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Login.Close()


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("calc.exe")




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Login.Show()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("R U Sure????", MsgBoxStyle.YesNo)

        Shell("shutdown -s -f -t 00")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Website.Show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected






    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Welkom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If Login.UsernameText.Text = ("WR") Then Admin.Show()
        Me.Hide()

        If Login.UsernameText.Text = ("HK") Then Admin.Show()
        Me.Hide()








    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)




    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class