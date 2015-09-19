Public Class MiniMazeGame
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Finish_MouseEnter(sender As Object, e As EventArgs) Handles Finish.MouseEnter
        'Show a congratulatory message box, then close resume to next level form'
        MessageBox.Show("Well Done! You've completed level one.")
        Close()
    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)

    End Sub


    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        MoveToStart()


    End Sub
End Class
