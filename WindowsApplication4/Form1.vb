Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1, num2, result As Integer

        num1 = Val(number1.Text)
        num2 = Val(number2.Text)

        If addButton.Checked Then
            result = num1 + num2
        End If

        If subtractButton.Checked Then
            result = num1 - num2
        End If

        If divideButton.Checked Then
            result = num1 / num2
        End If

        If multiplyButton.Checked Then
            result = num1 * num2
        End If

        result1.Text = result

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim num1, num2, result As Integer
        result = 0
        num1 = Val(number1.Text)
        num2 = Val(number2.Text)

        For a = num1 + 1 To num2 - 1
            result = a + result
        Next

        result2.Text = result

    End Sub
End Class
