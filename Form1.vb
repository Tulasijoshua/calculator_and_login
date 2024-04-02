Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If String.IsNullOrWhiteSpace(fnTextBox.Text) OrElse Not IsNumeric(fnTextBox.Text) Then
            MessageBox.Show("Please enter a valid number for First Number.", "Invalid Input")
            Return
        End If

        ' Check if the last name textbox is empty or contains a non-numeric value
        If String.IsNullOrWhiteSpace(snTextBox.Text) OrElse Not IsNumeric(snTextBox.Text) Then
            MessageBox.Show("Please enter a valid number for Second Number.", "Invalid Input")
            Return
        End If

        Dim firstNumber As Double = Double.Parse(fnTextBox.Text)
        Dim secondNumber As Double = Double.Parse(snTextBox.Text)
        Dim result As Double = firstNumber + secondNumber

        MessageBox.Show($"The result of {firstNumber} + {secondNumber} is {result}", "Calculation Result")
    End Sub

    Private Sub ansTextBox_TextChanged(sender As Object, e As EventArgs) Handles snTextBox.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        reset()
    End Sub

    Private Sub fnTextBox_TextChanged(sender As Object, e As EventArgs) Handles fnTextBox.TextChanged

    End Sub

    Private Sub subButton_Click(sender As Object, e As EventArgs) Handles subButton.Click
        Dim firstNumber As Double
        Dim secondNumber As Double
        If Double.TryParse(fnTextBox.Text, firstNumber) AndAlso Double.TryParse(snTextBox.Text, secondNumber) Then
            Dim result As Double = firstNumber - secondNumber
            ansTextBox.Text = result.ToString()
        Else
            MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mulButton_Click(sender As Object, e As EventArgs) Handles mulButton.Click
        Dim firstNumber As Double
        Dim secondNumber As Double
        If Double.TryParse(fnTextBox.Text, firstNumber) AndAlso Double.TryParse(snTextBox.Text, secondNumber) Then
            Dim result As Double = firstNumber * secondNumber
            ansTextBox.Text = result.ToString()
        Else
            MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub divButton_Click(sender As Object, e As EventArgs) Handles divButton.Click
        Try
            Dim firstNumber As Double
            Dim secondNumber As Double
            If Double.TryParse(fnTextBox.Text, firstNumber) AndAlso Double.TryParse(snTextBox.Text, secondNumber) Then
                If secondNumber <> 0 Then
                    Dim result As Double = firstNumber / secondNumber
                    ansTextBox.Text = result.ToString()
                Else
                    MessageBox.Show("Cannot divide by zero.", "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ar As ArithmeticException
            MessageBox.Show("Arithmetic exception")
        Catch dbo As DivideByZeroException
            MessageBox.Show("Cannot be divided zero")
        Catch ex As Exception
            MessageBox.Show("An error occurred")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ansTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles ansTextBox.TextChanged

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click, addButton.Click, AddToolStripMenuItem1.Click
        Dim firstNumber As Double
        Dim secondNumber As Double
        If Double.TryParse(fnTextBox.Text, firstNumber) AndAlso Double.TryParse(snTextBox.Text, secondNumber) Then
            Dim result As Double = firstNumber + secondNumber
            ansTextBox.Text = result.ToString()
        Else
            MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click

    End Sub

    Private Sub reset()
        fnTextBox.Clear()
        snTextBox.Clear()
        ansTextBox.Clear()

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        reset()
    End Sub

    Private Sub SubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubToolStripMenuItem.Click

    End Sub
End Class
