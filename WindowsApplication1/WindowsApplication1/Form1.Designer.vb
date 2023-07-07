<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RstltsTxtBx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.CsvBtn = New System.Windows.Forms.Button()
        Me.BgRstTxtBx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSaveBtn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PwrTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input (n)"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 71)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(3, 114)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(754, 625)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Outputs"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(964, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RstltsTxtBx
        '
        Me.RstltsTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RstltsTxtBx.Location = New System.Drawing.Point(763, 98)
        Me.RstltsTxtBx.Name = "RstltsTxtBx"
        Me.RstltsTxtBx.ReadOnly = True
        Me.RstltsTxtBx.Size = New System.Drawing.Size(284, 22)
        Me.RstltsTxtBx.TabIndex = 7
        Me.RstltsTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(763, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Results Count"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(676, 34)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(81, 35)
        Me.ResetBtn.TabIndex = 5
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseCompatibleTextRendering = True
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'CsvBtn
        '
        Me.CsvBtn.Location = New System.Drawing.Point(584, 34)
        Me.CsvBtn.Name = "CsvBtn"
        Me.CsvBtn.Size = New System.Drawing.Size(86, 35)
        Me.CsvBtn.TabIndex = 4
        Me.CsvBtn.Text = "Csv Save"
        Me.CsvBtn.UseCompatibleTextRendering = True
        Me.CsvBtn.UseVisualStyleBackColor = True
        '
        'BgRstTxtBx
        '
        Me.BgRstTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BgRstTxtBx.Location = New System.Drawing.Point(763, 162)
        Me.BgRstTxtBx.Name = "BgRstTxtBx"
        Me.BgRstTxtBx.ReadOnly = True
        Me.BgRstTxtBx.Size = New System.Drawing.Size(284, 22)
        Me.BgRstTxtBx.TabIndex = 8
        Me.BgRstTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(763, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Biggest Result"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'TxtSaveBtn
        '
        Me.TxtSaveBtn.Location = New System.Drawing.Point(496, 34)
        Me.TxtSaveBtn.Name = "TxtSaveBtn"
        Me.TxtSaveBtn.Size = New System.Drawing.Size(83, 35)
        Me.TxtSaveBtn.TabIndex = 3
        Me.TxtSaveBtn.Text = "Txt Save"
        Me.TxtSaveBtn.UseCompatibleTextRendering = True
        Me.TxtSaveBtn.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 763)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1051, 25)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(330, 20)
        Me.ToolStripStatusLabel1.Text = "collatz conjecture by / Ahmed Samir (evry1falls) "
        '
        'PwrTxtBox
        '
        Me.PwrTxtBox.Location = New System.Drawing.Point(264, 20)
        Me.PwrTxtBox.Multiline = True
        Me.PwrTxtBox.Name = "PwrTxtBox"
        Me.PwrTxtBox.Size = New System.Drawing.Size(226, 71)
        Me.PwrTxtBox.TabIndex = 14
        Me.PwrTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Power ^ n"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 788)
        Me.Controls.Add(Me.PwrTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TxtSaveBtn)
        Me.Controls.Add(Me.BgRstTxtBx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CsvBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.RstltsTxtBx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "collatz conjecture"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RstltsTxtBx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents CsvBtn As Button
    Friend WithEvents BgRstTxtBx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSaveBtn As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PwrTxtBox As TextBox
    Friend WithEvents Label5 As Label
End Class
