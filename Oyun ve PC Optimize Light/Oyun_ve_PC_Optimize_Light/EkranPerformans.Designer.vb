<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EkranPerformans
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EkranPerformans))
        Me.ramknk = New System.Windows.Forms.Timer(Me.components)
        Me.ram = New System.Windows.Forms.ProgressBar()
        Me.cpu = New System.Windows.Forms.ProgressBar()
        Me.lblram = New MetroFramework.Controls.MetroLabel()
        Me.lblcpu = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'ramknk
        '
        Me.ramknk.Enabled = True
        Me.ramknk.Interval = 500
        '
        'ram
        '
        Me.ram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ram.Location = New System.Drawing.Point(17, 34)
        Me.ram.Margin = New System.Windows.Forms.Padding(2)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(225, 12)
        Me.ram.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ram.TabIndex = 0
        '
        'cpu
        '
        Me.cpu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cpu.Location = New System.Drawing.Point(17, 75)
        Me.cpu.Margin = New System.Windows.Forms.Padding(2)
        Me.cpu.Name = "cpu"
        Me.cpu.Size = New System.Drawing.Size(225, 12)
        Me.cpu.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.cpu.TabIndex = 0
        '
        'lblram
        '
        Me.lblram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblram.AutoSize = True
        Me.lblram.Location = New System.Drawing.Point(17, 13)
        Me.lblram.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblram.Name = "lblram"
        Me.lblram.Size = New System.Drawing.Size(0, 0)
        Me.lblram.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblram.TabIndex = 1
        Me.lblram.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblram.UseStyleColors = True
        '
        'lblcpu
        '
        Me.lblcpu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcpu.AutoSize = True
        Me.lblcpu.Location = New System.Drawing.Point(17, 54)
        Me.lblcpu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcpu.Name = "lblcpu"
        Me.lblcpu.Size = New System.Drawing.Size(0, 0)
        Me.lblcpu.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblcpu.TabIndex = 1
        Me.lblcpu.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblcpu.UseStyleColors = True
        '
        'EkranPerformans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 106)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblcpu)
        Me.Controls.Add(Me.lblram)
        Me.Controls.Add(Me.cpu)
        Me.Controls.Add(Me.ram)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EkranPerformans"
        Me.Padding = New System.Windows.Forms.Padding(15, 30, 15, 16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Performans Ölçüm"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ramknk As Timer
    Friend WithEvents ram As ProgressBar
    Friend WithEvents cpu As ProgressBar
    Friend WithEvents lblram As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblcpu As MetroFramework.Controls.MetroLabel
End Class
