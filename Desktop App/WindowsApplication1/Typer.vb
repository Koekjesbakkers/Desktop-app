Public Class Typer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles StopTyper.Click
        Timer1.Enabled = False
        MsgBox("Auto Typer has stopped")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        SendKeys.Send(TextBox1.Text)
        SendKeys.Send("{Enter}")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartTyper.Click
        Timer1.Interval = TextBox2.Text * 1000
        Timer1.Enabled = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Typer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


    End Sub

    Private Sub Typer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Welkom.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles StartTyper.KeyDown





    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles StopTyper.KeyDown

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StartTyper.KeyPress




    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class