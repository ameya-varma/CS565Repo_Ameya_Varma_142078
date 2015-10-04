Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim age As String
        Dim dateOfBirth As Date
        Dim favoriteColors As String
        Dim brown, black, green, blue, pink, sex As String

        brown = ""
        black = ""
        green = ""
        blue = ""
        pink = ""
        sex = ""

        name = nameTextBox.Text
        age = ageDropdown.Text

        If maleRadio.Checked Then
            sex = "MALE"
        End If
        If femaleRadio.Checked Then
            sex = "FEMALE"
        End If

        dateOfBirth = dateOfBirthPicker.Text

        If brownCheckBox.Checked Then
            brown = "brown"
        End If

        If BlackCheckBox.Checked Then
            black = "black"
        End If

        If BlueCheckBox.Checked Then
            blue = "blue"
        End If

        If GreenCheckbox.Checked Then
            green = "green"
        End If

        If PinkCheckBox.Checked Then
            pink = "pink"
        End If

        favoriteColors = black + " " + blue + " " + pink + " " + green + "  " + brown

        resultBox.Text = "My name is: " + name + "My Age is: " + age + "Gender: " + sex + "Date Of Birth: " + dateOfBirth + "Favorite Color: " + favoriteColors



    End Sub


End Class
