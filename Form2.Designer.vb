<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        usernameTextBox = New TextBox()
        passwordTextBox = New TextBox()
        resetButton = New Button()
        loginButton = New Button()
        exitButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(288, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 32)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(98, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 28)
        Label2.TabIndex = 1
        Label2.Text = "User Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(98, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 28)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(252, 105)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(150, 31)
        usernameTextBox.TabIndex = 3
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(252, 192)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(150, 31)
        passwordTextBox.TabIndex = 4
        ' 
        ' resetButton
        ' 
        resetButton.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        resetButton.Location = New Point(98, 302)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(112, 45)
        resetButton.TabIndex = 5
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' loginButton
        ' 
        loginButton.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginButton.Location = New Point(276, 302)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(112, 45)
        loginButton.TabIndex = 6
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' exitButton
        ' 
        exitButton.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exitButton.Location = New Point(482, 302)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(112, 45)
        exitButton.TabIndex = 7
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(exitButton)
        Controls.Add(loginButton)
        Controls.Add(resetButton)
        Controls.Add(passwordTextBox)
        Controls.Add(usernameTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents resetButton As Button
    Friend WithEvents loginButton As Button
    Friend WithEvents exitButton As Button
End Class
