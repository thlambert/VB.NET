<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDO = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDO
        '
        Me.btnDO.Location = New System.Drawing.Point(406, 150)
        Me.btnDO.Name = "btnDO"
        Me.btnDO.Size = New System.Drawing.Size(75, 23)
        Me.btnDO.TabIndex = 2
        Me.btnDO.Text = "&JUST DO IT"
        Me.btnDO.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(406, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.SystemColors.Window
        Me.txtResult.Location = New System.Drawing.Point(206, 247)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 2
        Me.txtResult.TabStop = False
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNum2
        '
        Me.txtNum2.AcceptsTab = True
        Me.txtNum2.Location = New System.Drawing.Point(206, 183)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        '
        'txtNum1
        '
        Me.txtNum1.AcceptsTab = True
        Me.txtNum1.Location = New System.Drawing.Point(206, 119)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(203, 94)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(35, 13)
        Me.Label.TabIndex = 5
        Me.Label.Text = "Num1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Num2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test 1Lambertth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDO As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
