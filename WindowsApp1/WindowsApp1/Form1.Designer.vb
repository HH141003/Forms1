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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.rbtUnder = New System.Windows.Forms.RadioButton()
        Me.rbtOver = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(36, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "First name:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(42, 57)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Surname:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(100, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 20)
        Me.txtName.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(100, 54)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(155, 20)
        Me.txtSurname.TabIndex = 3
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(163, 144)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(93, 43)
        Me.cmdStart.TabIndex = 4
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(40, 144)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(93, 43)
        Me.cmdClear.TabIndex = 5
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(42, 203)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 6
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(41, 265)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(215, 37)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'rbtUnder
        '
        Me.rbtUnder.AutoSize = True
        Me.rbtUnder.Location = New System.Drawing.Point(100, 80)
        Me.rbtUnder.Name = "rbtUnder"
        Me.rbtUnder.Size = New System.Drawing.Size(69, 17)
        Me.rbtUnder.TabIndex = 8
        Me.rbtUnder.TabStop = True
        Me.rbtUnder.Text = "Under 24"
        Me.rbtUnder.UseVisualStyleBackColor = True
        '
        'rbtOver
        '
        Me.rbtOver.AutoSize = True
        Me.rbtOver.Location = New System.Drawing.Point(100, 103)
        Me.rbtOver.Name = "rbtOver"
        Me.rbtOver.Size = New System.Drawing.Size(63, 17)
        Me.rbtOver.TabIndex = 9
        Me.rbtOver.TabStop = True
        Me.rbtOver.Text = "Over 24"
        Me.rbtOver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Age:"
        '
        'lblOutput2
        '
        Me.lblOutput2.AutoSize = True
        Me.lblOutput2.Location = New System.Drawing.Point(42, 219)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 349)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtOver)
        Me.Controls.Add(Me.rbtUnder)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents rbtUnder As RadioButton
    Friend WithEvents rbtOver As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput2 As Label
End Class
