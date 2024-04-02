Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to exist", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dialog = DialogResult.Yes) Then
            Application.ExitThread()

            End
        End If
    End Sub

    Private Sub usernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBox.TextChanged

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        usernameTextBox.Clear()
        passwordTextBox.Clear()
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If (usernameTextBox.Text = "joshua" And passwordTextBox.Text = "joshua") Then
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Wrong username or password", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub passwordTextBox_TextChanged(sender As Object, e As EventArgs) Handles passwordTextBox.TextChanged

    End Sub
End Class