<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Menu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtChargeStatus = New System.Windows.Forms.Label()
        Me.txtFullLifetime = New System.Windows.Forms.Label()
        Me.txtBatteryPercent = New System.Windows.Forms.Label()
        Me.txtLifeRemaining = New System.Windows.Forms.Label()
        Me.txtPowerLineStatus = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.ListBox()
        Me.L2 = New System.Windows.Forms.ListBox()
        Me.B0 = New System.Windows.Forms.Label()
        Me.B1 = New System.Windows.Forms.Label()
        Me.TIMENOW = New System.Windows.Forms.Label()
        Me.B2 = New System.Windows.Forms.Label()
        Me.TIMEBEFORE1UC = New System.Windows.Forms.Label()
        Me.MinFromStart = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B3 = New System.Windows.Forms.Label()
        Me.B4 = New System.Windows.Forms.Label()
        Me.B5 = New System.Windows.Forms.Label()
        Me.NST = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TPLOC = New System.Windows.Forms.TextBox()
        Me.TPNET = New System.Windows.Forms.TextBox()
        Me.LPLOC = New System.Windows.Forms.Label()
        Me.LPNET = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Menu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ContextMenuStrip = Me.Menu1
        Me.ProgressBar1.Location = New System.Drawing.Point(5, 18)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(163, 13)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 4
        '
        'Menu1
        '
        Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnTopToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(111, 48)
        '
        'OnTopToolStripMenuItem
        '
        Me.OnTopToolStripMenuItem.CheckOnClick = True
        Me.OnTopToolStripMenuItem.Name = "OnTopToolStripMenuItem"
        Me.OnTopToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OnTopToolStripMenuItem.Text = "on Top"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtChargeStatus
        '
        Me.txtChargeStatus.AutoSize = True
        Me.txtChargeStatus.Location = New System.Drawing.Point(9, 33)
        Me.txtChargeStatus.Name = "txtChargeStatus"
        Me.txtChargeStatus.Size = New System.Drawing.Size(82, 13)
        Me.txtChargeStatus.TabIndex = 6
        Me.txtChargeStatus.Text = "txtChargeStatus"
        '
        'txtFullLifetime
        '
        Me.txtFullLifetime.AutoSize = True
        Me.txtFullLifetime.Location = New System.Drawing.Point(9, 52)
        Me.txtFullLifetime.Name = "txtFullLifetime"
        Me.txtFullLifetime.Size = New System.Drawing.Size(70, 13)
        Me.txtFullLifetime.TabIndex = 6
        Me.txtFullLifetime.Text = "txtFullLifetime"
        '
        'txtBatteryPercent
        '
        Me.txtBatteryPercent.AutoSize = True
        Me.txtBatteryPercent.Location = New System.Drawing.Point(9, 71)
        Me.txtBatteryPercent.Name = "txtBatteryPercent"
        Me.txtBatteryPercent.Size = New System.Drawing.Size(88, 13)
        Me.txtBatteryPercent.TabIndex = 6
        Me.txtBatteryPercent.Text = "txtBatteryPercent"
        '
        'txtLifeRemaining
        '
        Me.txtLifeRemaining.AutoSize = True
        Me.txtLifeRemaining.Location = New System.Drawing.Point(9, 89)
        Me.txtLifeRemaining.Name = "txtLifeRemaining"
        Me.txtLifeRemaining.Size = New System.Drawing.Size(85, 13)
        Me.txtLifeRemaining.TabIndex = 6
        Me.txtLifeRemaining.Text = "txtLifeRemaining"
        '
        'txtPowerLineStatus
        '
        Me.txtPowerLineStatus.AutoSize = True
        Me.txtPowerLineStatus.Location = New System.Drawing.Point(9, 106)
        Me.txtPowerLineStatus.Name = "txtPowerLineStatus"
        Me.txtPowerLineStatus.Size = New System.Drawing.Size(98, 13)
        Me.txtPowerLineStatus.TabIndex = 6
        Me.txtPowerLineStatus.Text = "txtPowerLineStatus"
        '
        'L1
        '
        Me.L1.FormattingEnabled = True
        Me.L1.Location = New System.Drawing.Point(180, 263)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(39, 56)
        Me.L1.TabIndex = 7
        Me.L1.Visible = False
        '
        'L2
        '
        Me.L2.FormattingEnabled = True
        Me.L2.Location = New System.Drawing.Point(224, 263)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(78, 56)
        Me.L2.TabIndex = 8
        Me.L2.Visible = False
        '
        'B0
        '
        Me.B0.AutoSize = True
        Me.B0.Location = New System.Drawing.Point(9, 263)
        Me.B0.Name = "B0"
        Me.B0.Size = New System.Drawing.Size(20, 13)
        Me.B0.TabIndex = 9
        Me.B0.Text = "B0"
        '
        'B1
        '
        Me.B1.AutoSize = True
        Me.B1.Location = New System.Drawing.Point(9, 280)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(20, 13)
        Me.B1.TabIndex = 10
        Me.B1.Text = "B1"
        '
        'TIMENOW
        '
        Me.TIMENOW.AutoSize = True
        Me.TIMENOW.Location = New System.Drawing.Point(4, 2)
        Me.TIMENOW.Name = "TIMENOW"
        Me.TIMENOW.Size = New System.Drawing.Size(63, 13)
        Me.TIMENOW.TabIndex = 11
        Me.TIMENOW.Text = "TIME NOW"
        '
        'B2
        '
        Me.B2.AutoSize = True
        Me.B2.Location = New System.Drawing.Point(9, 298)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(20, 13)
        Me.B2.TabIndex = 12
        Me.B2.Text = "B2"
        '
        'TIMEBEFORE1UC
        '
        Me.TIMEBEFORE1UC.AutoSize = True
        Me.TIMEBEFORE1UC.Location = New System.Drawing.Point(9, 243)
        Me.TIMEBEFORE1UC.Name = "TIMEBEFORE1UC"
        Me.TIMEBEFORE1UC.Size = New System.Drawing.Size(185, 13)
        Me.TIMEBEFORE1UC.TabIndex = 13
        Me.TIMEBEFORE1UC.Text = "TIME BEFORE 1% CHARGING UNIT"
        '
        'MinFromStart
        '
        Me.MinFromStart.AutoSize = True
        Me.MinFromStart.Location = New System.Drawing.Point(9, 222)
        Me.MinFromStart.Name = "MinFromStart"
        Me.MinFromStart.Size = New System.Drawing.Size(69, 13)
        Me.MinFromStart.TabIndex = 14
        Me.MinFromStart.Text = "MinFromStart"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "-------------------"
        '
        'B3
        '
        Me.B3.AutoSize = True
        Me.B3.Location = New System.Drawing.Point(94, 263)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(20, 13)
        Me.B3.TabIndex = 16
        Me.B3.Text = "B3"
        '
        'B4
        '
        Me.B4.AutoSize = True
        Me.B4.Location = New System.Drawing.Point(94, 280)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(20, 13)
        Me.B4.TabIndex = 17
        Me.B4.Text = "B4"
        '
        'B5
        '
        Me.B5.AutoSize = True
        Me.B5.Location = New System.Drawing.Point(94, 298)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(20, 13)
        Me.B5.TabIndex = 18
        Me.B5.Text = "B5"
        '
        'NST
        '
        Me.NST.AutoSize = True
        Me.NST.Location = New System.Drawing.Point(8, 134)
        Me.NST.Name = "NST"
        Me.NST.Size = New System.Drawing.Size(22, 13)
        Me.NST.TabIndex = 19
        Me.NST.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "-------------------"
        '
        'TPLOC
        '
        Me.TPLOC.Location = New System.Drawing.Point(119, 325)
        Me.TPLOC.Name = "TPLOC"
        Me.TPLOC.Size = New System.Drawing.Size(100, 20)
        Me.TPLOC.TabIndex = 21
        Me.TPLOC.Text = "10.0.0.1"
        '
        'TPNET
        '
        Me.TPNET.Location = New System.Drawing.Point(232, 326)
        Me.TPNET.Name = "TPNET"
        Me.TPNET.Size = New System.Drawing.Size(100, 20)
        Me.TPNET.TabIndex = 22
        Me.TPNET.Text = "www.youtube.com"
        '
        'LPLOC
        '
        Me.LPLOC.AutoSize = True
        Me.LPLOC.Location = New System.Drawing.Point(8, 151)
        Me.LPLOC.Name = "LPLOC"
        Me.LPLOC.Size = New System.Drawing.Size(28, 13)
        Me.LPLOC.TabIndex = 23
        Me.LPLOC.Text = "LOC"
        '
        'LPNET
        '
        Me.LPNET.AutoSize = True
        Me.LPNET.Location = New System.Drawing.Point(8, 169)
        Me.LPNET.Name = "LPNET"
        Me.LPNET.Size = New System.Drawing.Size(29, 13)
        Me.LPNET.TabIndex = 24
        Me.LPNET.Text = "NET"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(398, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(264, 420)
        Me.ListBox1.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 562)
        Me.ContextMenuStrip = Me.Menu1
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LPNET)
        Me.Controls.Add(Me.LPLOC)
        Me.Controls.Add(Me.TPNET)
        Me.Controls.Add(Me.TPLOC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NST)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.TIMENOW)
        Me.Controls.Add(Me.txtPowerLineStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MinFromStart)
        Me.Controls.Add(Me.TIMEBEFORE1UC)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.B0)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.txtLifeRemaining)
        Me.Controls.Add(Me.txtBatteryPercent)
        Me.Controls.Add(Me.txtFullLifetime)
        Me.Controls.Add(Me.txtChargeStatus)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Battary Info."
        Me.Menu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Menu1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtChargeStatus As Label
    Friend WithEvents txtFullLifetime As Label
    Friend WithEvents txtBatteryPercent As Label
    Friend WithEvents txtLifeRemaining As Label
    Friend WithEvents txtPowerLineStatus As Label
    Friend WithEvents L1 As ListBox
    Friend WithEvents L2 As ListBox
    Friend WithEvents B0 As Label
    Friend WithEvents B1 As Label
    Friend WithEvents TIMENOW As Label
    Friend WithEvents B2 As Label
    Friend WithEvents TIMEBEFORE1UC As Label
    Friend WithEvents MinFromStart As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents B3 As Label
    Friend WithEvents B4 As Label
    Friend WithEvents B5 As Label
    Friend WithEvents NST As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TPLOC As TextBox
    Friend WithEvents TPNET As TextBox
    Friend WithEvents LPLOC As Label
    Friend WithEvents LPNET As Label
    Friend WithEvents ListBox1 As ListBox
End Class
