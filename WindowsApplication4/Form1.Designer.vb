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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.number1 = New System.Windows.Forms.TextBox()
        Me.number2 = New System.Windows.Forms.TextBox()
        Me.result1 = New System.Windows.Forms.TextBox()
        Me.result2 = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.RadioButton()
        Me.subtractButton = New System.Windows.Forms.RadioButton()
        Me.multiplyButton = New System.Windows.Forms.RadioButton()
        Me.divideButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "num1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "num2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "operation"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Result1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Result2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'number1
        '
        Me.number1.Location = New System.Drawing.Point(239, 50)
        Me.number1.Name = "number1"
        Me.number1.Size = New System.Drawing.Size(100, 20)
        Me.number1.TabIndex = 5
        '
        'number2
        '
        Me.number2.Location = New System.Drawing.Point(239, 100)
        Me.number2.Name = "number2"
        Me.number2.Size = New System.Drawing.Size(100, 20)
        Me.number2.TabIndex = 6
        '
        'result1
        '
        Me.result1.Location = New System.Drawing.Point(239, 202)
        Me.result1.Name = "result1"
        Me.result1.Size = New System.Drawing.Size(100, 20)
        Me.result1.TabIndex = 7
        '
        'result2
        '
        Me.result2.Location = New System.Drawing.Point(239, 247)
        Me.result2.Name = "result2"
        Me.result2.Size = New System.Drawing.Size(100, 20)
        Me.result2.TabIndex = 8
        '
        'addButton
        '
        Me.addButton.AutoSize = True
        Me.addButton.Location = New System.Drawing.Point(139, 137)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(82, 17)
        Me.addButton.TabIndex = 9
        Me.addButton.TabStop = True
        Me.addButton.Tag = "operation"
        Me.addButton.Text = "Add number"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'subtractButton
        '
        Me.subtractButton.AutoSize = True
        Me.subtractButton.Location = New System.Drawing.Point(271, 137)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(110, 17)
        Me.subtractButton.TabIndex = 10
        Me.subtractButton.TabStop = True
        Me.subtractButton.Tag = "operation"
        Me.subtractButton.Text = "Subtract Numbers"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.AutoSize = True
        Me.multiplyButton.Location = New System.Drawing.Point(271, 160)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(105, 17)
        Me.multiplyButton.TabIndex = 11
        Me.multiplyButton.TabStop = True
        Me.multiplyButton.Tag = "operation"
        Me.multiplyButton.Text = "Multiply Numbers"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.AutoSize = True
        Me.divideButton.Location = New System.Drawing.Point(139, 160)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(100, 17)
        Me.divideButton.TabIndex = 12
        Me.divideButton.TabStop = True
        Me.divideButton.Tag = "operation"
        Me.divideButton.Text = "Divide Numbers"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 300)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.subtractButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.result2)
        Me.Controls.Add(Me.result1)
        Me.Controls.Add(Me.number2)
        Me.Controls.Add(Me.number1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents number1 As TextBox
    Friend WithEvents number2 As TextBox
    Friend WithEvents result1 As TextBox
    Friend WithEvents result2 As TextBox
    Friend WithEvents addButton As RadioButton
    Friend WithEvents subtractButton As RadioButton
    Friend WithEvents multiplyButton As RadioButton
    Friend WithEvents divideButton As RadioButton
End Class
