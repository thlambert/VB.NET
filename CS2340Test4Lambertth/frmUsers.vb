Public Class frmUsers
    Dim invalidinput As Boolean
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        flag = 1
        Application.Exit()
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        Me.Hide()
        frmData.Show()
    End Sub

    Private Sub frmUsers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If flag = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtUN.MaxLength = 6
        Me.txtPW.MaxLength = 8
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ListBox1.Items.Remove(ListBox1.SelectedItems)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        ListBox1.Items.Remove(ListBox1.SelectedItems)
    End Sub

    Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim cord As Point
            cord.X = MousePosition.X
            cord.Y = MousePosition.Y
            menuRight.Show()
            menuRight.Location = cord
        End If
    End Sub

    Private Sub SortedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortedToolStripMenuItem.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub NotSortedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotSortedToolStripMenuItem.Click
        ListBox1.Sorted = False
    End Sub

    Private Sub btnNU_Click(sender As Object, e As EventArgs) Handles btnNU.Click
        If (txtUN.Text.Trim <> "") Then
            If (txtPW.Text.Trim <> "") Then
                txtUN.TextAlign = HorizontalAlignment.Left
                txtPW.TextAlign = HorizontalAlignment.Right
                ListBox1.Items.Add(txtUN.Text + "    " + txtPW.Text)
            End If
        End If
    End Sub

    Private Sub txtUN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtPW_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPW.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class
