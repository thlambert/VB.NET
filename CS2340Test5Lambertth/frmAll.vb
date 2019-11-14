Public Class frmAll
    Private Sub frmAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet1.Employee)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            EmployeeBindingSource.EndEdit()
            EmployeeTableAdapter.Update(Test5DataSet1)
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMoveLastItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveNextItem.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Me.EmployeeTableAdapter.Fill(Me.Test5DataSet1.Employee)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Me.Hide()
        frmList.Show()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMoveLastItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        BindingNavigatorMoveNextItem.Enabled = True
    End Sub


End Class
