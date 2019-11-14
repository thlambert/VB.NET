Public Class frmSqrt
    Dim nonNumberEntered As Boolean
    Dim temp As Double
    Dim pos As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        Me.Hide()
        frmBack.Show()
    End Sub

    Private Sub frmSqrt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Anchor = AnchorStyles.None
        txtSquare.Anchor = AnchorStyles.None
        lblInput.Anchor = AnchorStyles.None
        lblSqrt.Anchor = AnchorStyles.None
        btnCompute.Anchor = AnchorStyles.None
        btnExit.Anchor = AnchorStyles.None
        btnSwitch.Anchor = AnchorStyles.None
        txtSquare.Text = Format(DialogResult, "D")
    End Sub

    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        nonNumberEntered = False
        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And
           (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) And
           (e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Decimal And e.KeyCode <> Keys.OemPeriod) Then
            nonNumberEntered = True
        End If
        If (e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.OemPeriod) Then
            pos = InStr(txtInput.Text, ".", CompareMethod.Binary)
            If (pos > 0) Then
                nonNumberEntered = True
            End If
        End If

    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If nonNumberEntered = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If (txtInput.Text = "") Then

        Else
            temp = txtInput.Text.Trim()
            temp = Math.Sqrt(temp)
            txtSquare.Text = temp.ToString("n")
        End If
    End Sub
End Class
