<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnNU = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.menuRight = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SortedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotSortedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(79, 29)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(100, 20)
        Me.txtUN.TabIndex = 2
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(267, 29)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(100, 20)
        Me.txtPW.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(79, 81)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(200, 148)
        Me.ListBox1.TabIndex = 4
        '
        'btnNU
        '
        Me.btnNU.Location = New System.Drawing.Point(304, 81)
        Me.btnNU.Name = "btnNU"
        Me.btnNU.Size = New System.Drawing.Size(75, 23)
        Me.btnNU.TabIndex = 5
        Me.btnNU.Text = "&New User"
        Me.btnNU.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(304, 110)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(304, 139)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAll.TabIndex = 7
        Me.btnRemoveAll.Text = "Remove &All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(304, 168)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(75, 23)
        Me.btnData.TabIndex = 8
        Me.btnData.Text = "&Data"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(304, 197)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'menuRight
        '
        Me.menuRight.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortedToolStripMenuItem, Me.NotSortedToolStripMenuItem})
        Me.menuRight.Name = "menuRight"
        Me.menuRight.Size = New System.Drawing.Size(175, 48)
        '
        'SortedToolStripMenuItem
        '
        Me.SortedToolStripMenuItem.Name = "SortedToolStripMenuItem"
        Me.SortedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SortedToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SortedToolStripMenuItem.Text = "Sorted"
        '
        'NotSortedToolStripMenuItem
        '
        Me.NotSortedToolStripMenuItem.Name = "NotSortedToolStripMenuItem"
        Me.NotSortedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NotSortedToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.NotSortedToolStripMenuItem.Text = "Not Sorted"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnNU)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(300, 220)
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test4Lambertth"
        Me.menuRight.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUN As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnNU As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents btnData As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents menuRight As ContextMenuStrip
    Friend WithEvents SortedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotSortedToolStripMenuItem As ToolStripMenuItem
End Class
