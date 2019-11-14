Imports System.IO
Public Class Form1
    Dim files As String
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim fileName
        Dim DlgOpenFile As New OpenFileDialog()
        DlgOpenFile.InitialDirectory = "C:\temp"
        DlgOpenFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|VB files (*.vb)|*.vb"
        DlgOpenFile.FilterIndex = 0
        If DlgOpenFile.ShowDialog() = DialogResult.OK Then
            fileName = DlgOpenFile.FileName
            txtData.Text = File.ReadAllText(fileName)
        Else
            MessageBox.Show("No file selected", "Lab 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtData.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        Dim fileName
        Dim saveFileDlg As New SaveFileDialog()
        Dim stmWriter As StreamWriter = Nothing
        'saveFileDlg.InitialDirectory = "C:\temp"
        saveFileDlg.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDlg.FilterIndex = 1
        saveFileDlg.RestoreDirectory = True
        If saveFileDlg.ShowDialog() = DialogResult.OK Then
            fileName = saveFileDlg.FileName
            File.WriteAllText(fileName, txtData.Text)
            'stmWriter = New StreamWriter(fileName)
            stmWriter = File.AppendText(fileName)
            stmWriter.Write(txtData.Text)
            stmWriter.Close()
        End If
        btnSave.Enabled = True
        files = fileName

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fileName
        Dim saveFileDlg As New SaveFileDialog()
        Dim stmWriter As StreamWriter = Nothing
        'saveFileDlg.InitialDirectory = "C:\temp"
        saveFileDlg.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDlg.FilterIndex = 1
        saveFileDlg.RestoreDirectory = True

        fileName = saveFileDlg.FileName
        File.WriteAllText(files, txtData.Text)
        'stmWriter = New StreamWriter(fileName)
        stmWriter = File.AppendText(files)
        stmWriter.Write(txtData.Text)
        stmWriter.Close()


    End Sub
End Class
