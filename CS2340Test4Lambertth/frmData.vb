Public Class frmData
    Private Sub frmData_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim cord As Point
            cord.X = MousePosition.X
            cord.Y = MousePosition.Y
            menuRight.Show()
            menuRight.Location = cord
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmUsers.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        flag = 1
        Application.Exit()
    End Sub

    Private Sub frmData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If flag = 0 Then
            e.Cancel = True
        End If
    End Sub
End Class