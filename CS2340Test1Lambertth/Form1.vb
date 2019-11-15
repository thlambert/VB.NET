Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDO_Click(sender As Object, e As EventArgs) Handles btnDO.Click
        Dim result As Double
        Dim input As String
        input = txtNum1.Text.Trim()
        If IsNumeric(input) And InStr(input, "e", CompareMethod.Text) = 0 Then

        Else
            MessageBox.Show("Num1 is invalid!", "Exam 1", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNum1.Focus()
            Exit Sub
        End If
        input = txtNum2.Text.Trim()
        If IsNumeric(input) And InStr(input, "e", CompareMethod.Text) = 0 Then
            If (input = 0) Then
                MessageBox.Show("Cannot divide by zero!", "Exam 1", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNum2.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Num2 is invalid!", "Exam 1", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNum2.Focus()
            Exit Sub
        End If

        result = txtNum1.Text.Trim / txtNum2.Text.Trim
        txtResult.Text = Format(result, "Standard")




    End Sub
End Class
