Public Class frmList
    Private Sub btnAllEmps_Click(sender As Object, e As EventArgs) Handles btnAllEmps.Click
        Me.Hide()
        frmAll.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)
    End Sub

    Private Sub frmList_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ListBox1.Items.Add(frmAll.Test5DataSet1)
    End Sub

    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test5DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet.Employee)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            EmployeeBindingSource.EndEdit()
            EmployeeTableAdapter.Update(Test5DataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class