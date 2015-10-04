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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.ageDropdown = New System.Windows.Forms.ComboBox()
        Me.maleRadio = New System.Windows.Forms.RadioButton()
        Me.femaleRadio = New System.Windows.Forms.RadioButton()
        Me.dateOfBirthPicker = New System.Windows.Forms.DateTimePicker()
        Me.brownCheckBox = New System.Windows.Forms.CheckBox()
        Me.BlueCheckBox = New System.Windows.Forms.CheckBox()
        Me.BlackCheckBox = New System.Windows.Forms.CheckBox()
        Me.GreenCheckbox = New System.Windows.Forms.CheckBox()
        Me.PinkCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resultBox = New System.Windows.Forms.TextBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sex"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Favorite Colors"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(298, 23)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nameTextBox.TabIndex = 5
        '
        'ageDropdown
        '
        Me.ageDropdown.FormattingEnabled = True
        Me.ageDropdown.Items.AddRange(New Object() {"20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.ageDropdown.Location = New System.Drawing.Point(298, 54)
        Me.ageDropdown.Name = "ageDropdown"
        Me.ageDropdown.Size = New System.Drawing.Size(121, 21)
        Me.ageDropdown.TabIndex = 6
        '
        'maleRadio
        '
        Me.maleRadio.AutoSize = True
        Me.maleRadio.Location = New System.Drawing.Point(298, 94)
        Me.maleRadio.Name = "maleRadio"
        Me.maleRadio.Size = New System.Drawing.Size(48, 17)
        Me.maleRadio.TabIndex = 7
        Me.maleRadio.Tag = "sexValue"
        Me.maleRadio.Text = "Male"
        Me.maleRadio.UseVisualStyleBackColor = True
        '
        'femaleRadio
        '
        Me.femaleRadio.AutoSize = True
        Me.femaleRadio.Location = New System.Drawing.Point(409, 94)
        Me.femaleRadio.Name = "femaleRadio"
        Me.femaleRadio.Size = New System.Drawing.Size(59, 17)
        Me.femaleRadio.TabIndex = 8
        Me.femaleRadio.Tag = "sexValue"
        Me.femaleRadio.Text = "Female"
        Me.femaleRadio.UseVisualStyleBackColor = True
        '
        'dateOfBirthPicker
        '
        Me.dateOfBirthPicker.Location = New System.Drawing.Point(298, 134)
        Me.dateOfBirthPicker.Name = "dateOfBirthPicker"
        Me.dateOfBirthPicker.Size = New System.Drawing.Size(200, 20)
        Me.dateOfBirthPicker.TabIndex = 9
        '
        'brownCheckBox
        '
        Me.brownCheckBox.AutoSize = True
        Me.brownCheckBox.Location = New System.Drawing.Point(298, 172)
        Me.brownCheckBox.Name = "brownCheckBox"
        Me.brownCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.brownCheckBox.TabIndex = 10
        Me.brownCheckBox.Tag = "brown"
        Me.brownCheckBox.Text = "Brown"
        Me.brownCheckBox.UseVisualStyleBackColor = True
        '
        'BlueCheckBox
        '
        Me.BlueCheckBox.AutoSize = True
        Me.BlueCheckBox.Location = New System.Drawing.Point(386, 172)
        Me.BlueCheckBox.Name = "BlueCheckBox"
        Me.BlueCheckBox.Size = New System.Drawing.Size(47, 17)
        Me.BlueCheckBox.TabIndex = 11
        Me.BlueCheckBox.Tag = "blue"
        Me.BlueCheckBox.Text = "Blue"
        Me.BlueCheckBox.UseVisualStyleBackColor = True
        '
        'BlackCheckBox
        '
        Me.BlackCheckBox.AutoSize = True
        Me.BlackCheckBox.Location = New System.Drawing.Point(298, 195)
        Me.BlackCheckBox.Name = "BlackCheckBox"
        Me.BlackCheckBox.Size = New System.Drawing.Size(53, 17)
        Me.BlackCheckBox.TabIndex = 12
        Me.BlackCheckBox.Tag = "black"
        Me.BlackCheckBox.Text = "Black"
        Me.BlackCheckBox.UseVisualStyleBackColor = True
        '
        'GreenCheckbox
        '
        Me.GreenCheckbox.AutoSize = True
        Me.GreenCheckbox.Location = New System.Drawing.Point(386, 195)
        Me.GreenCheckbox.Name = "GreenCheckbox"
        Me.GreenCheckbox.Size = New System.Drawing.Size(55, 17)
        Me.GreenCheckbox.TabIndex = 13
        Me.GreenCheckbox.Tag = "green"
        Me.GreenCheckbox.Text = "Green"
        Me.GreenCheckbox.UseVisualStyleBackColor = True
        '
        'PinkCheckBox
        '
        Me.PinkCheckBox.AutoSize = True
        Me.PinkCheckBox.Location = New System.Drawing.Point(298, 218)
        Me.PinkCheckBox.Name = "PinkCheckBox"
        Me.PinkCheckBox.Size = New System.Drawing.Size(47, 17)
        Me.PinkCheckBox.TabIndex = 14
        Me.PinkCheckBox.Tag = "pink"
        Me.PinkCheckBox.Text = "Pink"
        Me.PinkCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Output"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resultBox
        '
        Me.resultBox.Location = New System.Drawing.Point(12, 287)
        Me.resultBox.Name = "resultBox"
        Me.resultBox.Size = New System.Drawing.Size(487, 20)
        Me.resultBox.TabIndex = 16
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 344)
        Me.Controls.Add(Me.resultBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PinkCheckBox)
        Me.Controls.Add(Me.GreenCheckbox)
        Me.Controls.Add(Me.BlackCheckBox)
        Me.Controls.Add(Me.BlueCheckBox)
        Me.Controls.Add(Me.brownCheckBox)
        Me.Controls.Add(Me.dateOfBirthPicker)
        Me.Controls.Add(Me.femaleRadio)
        Me.Controls.Add(Me.maleRadio)
        Me.Controls.Add(Me.ageDropdown)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents ageDropdown As ComboBox
    Friend WithEvents maleRadio As RadioButton
    Friend WithEvents femaleRadio As RadioButton
    Friend WithEvents dateOfBirthPicker As DateTimePicker
    Friend WithEvents brownCheckBox As CheckBox
    Friend WithEvents BlueCheckBox As CheckBox
    Friend WithEvents BlackCheckBox As CheckBox
    Friend WithEvents GreenCheckbox As CheckBox
    Friend WithEvents PinkCheckBox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents resultBox As TextBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
End Class
