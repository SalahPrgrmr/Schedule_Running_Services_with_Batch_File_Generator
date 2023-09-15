<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dFile = New System.Windows.Forms.Button()
        Me.sFile = New System.Windows.Forms.Button()
        Me.selfilename = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab1)
        Me.TabControl1.Controls.Add(Me.Tab2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 703)
        Me.TabControl1.TabIndex = 0
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.Label2)
        Me.Tab1.Controls.Add(Me.Label1)
        Me.Tab1.Controls.Add(Me.dFile)
        Me.Tab1.Controls.Add(Me.sFile)
        Me.Tab1.Controls.Add(Me.selfilename)
        Me.Tab1.Controls.Add(Me.RichTextBox1)
        Me.Tab1.Controls.Add(Me.ListBox1)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(892, 677)
        Me.Tab1.TabIndex = 1
        Me.Tab1.Text = "File Generator"
        Me.Tab1.ToolTipText = "Create Or Edit Or Remove Files"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "File Content:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "List of Files:"
        '
        'dFile
        '
        Me.dFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFile.Location = New System.Drawing.Point(806, 4)
        Me.dFile.Name = "dFile"
        Me.dFile.Size = New System.Drawing.Size(68, 22)
        Me.dFile.TabIndex = 34
        Me.dFile.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.dFile, "Don't Worry , You Can Find The Deleted File in RecycleBin")
        Me.dFile.UseVisualStyleBackColor = True
        '
        'sFile
        '
        Me.sFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFile.Location = New System.Drawing.Point(737, 4)
        Me.sFile.Name = "sFile"
        Me.sFile.Size = New System.Drawing.Size(68, 22)
        Me.sFile.TabIndex = 33
        Me.sFile.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.sFile, "Save As File with Current Name")
        Me.sFile.UseVisualStyleBackColor = True
        '
        'selfilename
        '
        Me.selfilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.selfilename.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selfilename.Location = New System.Drawing.Point(381, 4)
        Me.selfilename.Name = "selfilename"
        Me.selfilename.Size = New System.Drawing.Size(346, 22)
        Me.selfilename.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.selfilename, "Current File Name , You Can Edit it if You Need a Copy of File 👍")
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(285, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(599, 628)
        Me.RichTextBox1.TabIndex = 31
        Me.RichTextBox1.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(8, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(271, 626)
        Me.ListBox1.TabIndex = 30
        '
        'Tab2
        '
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(892, 677)
        Me.Tab2.TabIndex = 0
        Me.Tab2.Tag = "#WinServSch"
        Me.Tab2.Text = "Schedule Win Services"
        Me.Tab2.ToolTipText = "Add New Windows Services to Schedule them"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 703)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "TechTune Application - Programming Solutions"
        Me.TabControl1.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Public WithEvents Tab2 As TabPage
    Public WithEvents Tab1 As TabPage
    Friend WithEvents sFile As Button
    Friend WithEvents selfilename As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents dFile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
