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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        fnTextBox = New TextBox()
        snTextBox = New TextBox()
        ansTextBox = New TextBox()
        addButton = New Button()
        subButton = New Button()
        mulButton = New Button()
        divButton = New Button()
        resetButton = New Button()
        exitButton = New Button()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        AddToolStripMenuItem = New ToolStripMenuItem()
        SubToolStripMenuItem = New ToolStripMenuItem()
        DivToolStripMenuItem = New ToolStripMenuItem()
        MulToolStripMenuItem = New ToolStripMenuItem()
        SelectToolStripMenuItem = New ToolStripMenuItem()
        ToolStripTextBox1 = New ToolStripTextBox()
        EditToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        FileToolStripMenuItem1 = New ToolStripMenuItem()
        AddToolStripMenuItem1 = New ToolStripMenuItem()
        SubToolStripMenuItem1 = New ToolStripMenuItem()
        DivToolStripMenuItem1 = New ToolStripMenuItem()
        MulToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem1 = New ToolStripMenuItem()
        VIewToolStripMenuItem1 = New ToolStripMenuItem()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(291, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 38)
        Label1.TabIndex = 0
        Label1.Text = "CALCULATOR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 1
        Label2.Text = "f number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 2
        Label3.Text = "s number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 25)
        Label4.TabIndex = 3
        Label4.Text = "answer"
        ' 
        ' fnTextBox
        ' 
        fnTextBox.Location = New Point(291, 123)
        fnTextBox.Name = "fnTextBox"
        fnTextBox.Size = New Size(150, 31)
        fnTextBox.TabIndex = 4
        ' 
        ' snTextBox
        ' 
        snTextBox.Location = New Point(291, 178)
        snTextBox.Name = "snTextBox"
        snTextBox.Size = New Size(150, 31)
        snTextBox.TabIndex = 5
        ' 
        ' ansTextBox
        ' 
        ansTextBox.Location = New Point(291, 248)
        ansTextBox.Multiline = True
        ansTextBox.Name = "ansTextBox"
        ansTextBox.ReadOnly = True
        ansTextBox.Size = New Size(150, 56)
        ansTextBox.TabIndex = 6
        ' 
        ' addButton
        ' 
        addButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addButton.Location = New Point(565, 97)
        addButton.Name = "addButton"
        addButton.Size = New Size(112, 34)
        addButton.TabIndex = 7
        addButton.Text = "&ADD"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' subButton
        ' 
        subButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        subButton.Location = New Point(565, 149)
        subButton.Name = "subButton"
        subButton.Size = New Size(112, 34)
        subButton.TabIndex = 8
        subButton.Text = "&SUB"
        subButton.UseVisualStyleBackColor = True
        ' 
        ' mulButton
        ' 
        mulButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mulButton.Location = New Point(565, 215)
        mulButton.Name = "mulButton"
        mulButton.Size = New Size(112, 34)
        mulButton.TabIndex = 9
        mulButton.Text = "&MUL"
        mulButton.UseVisualStyleBackColor = True
        ' 
        ' divButton
        ' 
        divButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        divButton.Location = New Point(565, 270)
        divButton.Name = "divButton"
        divButton.Size = New Size(112, 34)
        divButton.TabIndex = 10
        divButton.Text = "&DIV"
        divButton.UseVisualStyleBackColor = True
        ' 
        ' resetButton
        ' 
        resetButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        resetButton.Location = New Point(167, 354)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(112, 34)
        resetButton.TabIndex = 11
        resetButton.Text = "&RESET"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' exitButton
        ' 
        exitButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exitButton.Location = New Point(443, 354)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(112, 34)
        exitButton.TabIndex = 12
        exitButton.Text = "E&XIT"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, FileToolStripMenuItem1, EditToolStripMenuItem1, VIewToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddToolStripMenuItem, SubToolStripMenuItem, DivToolStripMenuItem, MulToolStripMenuItem, SelectToolStripMenuItem, ToolStripTextBox1})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' AddToolStripMenuItem
        ' 
        AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        AddToolStripMenuItem.Size = New Size(270, 34)
        AddToolStripMenuItem.Text = "Add"
        ' 
        ' SubToolStripMenuItem
        ' 
        SubToolStripMenuItem.Name = "SubToolStripMenuItem"
        SubToolStripMenuItem.Size = New Size(270, 34)
        SubToolStripMenuItem.Text = "Sub"
        ' 
        ' DivToolStripMenuItem
        ' 
        DivToolStripMenuItem.Name = "DivToolStripMenuItem"
        DivToolStripMenuItem.Size = New Size(270, 34)
        DivToolStripMenuItem.Text = "Div"
        ' 
        ' MulToolStripMenuItem
        ' 
        MulToolStripMenuItem.Name = "MulToolStripMenuItem"
        MulToolStripMenuItem.Size = New Size(270, 34)
        MulToolStripMenuItem.Text = "Mul"
        ' 
        ' SelectToolStripMenuItem
        ' 
        SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        SelectToolStripMenuItem.Size = New Size(270, 34)
        SelectToolStripMenuItem.Text = "Select"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 31)
        ToolStripTextBox1.Text = "reset"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(58, 29)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(65, 29)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' FileToolStripMenuItem1
        ' 
        FileToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AddToolStripMenuItem1, SubToolStripMenuItem1, DivToolStripMenuItem1, MulToolStripMenuItem1})
        FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        FileToolStripMenuItem1.Size = New Size(54, 29)
        FileToolStripMenuItem1.Text = "File"
        ' 
        ' AddToolStripMenuItem1
        ' 
        AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        AddToolStripMenuItem1.Size = New Size(148, 34)
        AddToolStripMenuItem1.Text = "Add"
        ' 
        ' SubToolStripMenuItem1
        ' 
        SubToolStripMenuItem1.Name = "SubToolStripMenuItem1"
        SubToolStripMenuItem1.Size = New Size(148, 34)
        SubToolStripMenuItem1.Text = "Sub"
        ' 
        ' DivToolStripMenuItem1
        ' 
        DivToolStripMenuItem1.Name = "DivToolStripMenuItem1"
        DivToolStripMenuItem1.Size = New Size(148, 34)
        DivToolStripMenuItem1.Text = "Div"
        ' 
        ' MulToolStripMenuItem1
        ' 
        MulToolStripMenuItem1.Name = "MulToolStripMenuItem1"
        MulToolStripMenuItem1.Size = New Size(148, 34)
        MulToolStripMenuItem1.Text = "Mul"
        ' 
        ' EditToolStripMenuItem1
        ' 
        EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        EditToolStripMenuItem1.Size = New Size(58, 29)
        EditToolStripMenuItem1.Text = "Edit"
        ' 
        ' VIewToolStripMenuItem1
        ' 
        VIewToolStripMenuItem1.Name = "VIewToolStripMenuItem1"
        VIewToolStripMenuItem1.Size = New Size(66, 29)
        VIewToolStripMenuItem1.Text = "VIew"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = exitButton
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(exitButton)
        Controls.Add(resetButton)
        Controls.Add(divButton)
        Controls.Add(mulButton)
        Controls.Add(subButton)
        Controls.Add(addButton)
        Controls.Add(ansTextBox)
        Controls.Add(snTextBox)
        Controls.Add(fnTextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fnTextBox As TextBox
    Friend WithEvents snTextBox As TextBox
    Friend WithEvents ansTextBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents subButton As Button
    Friend WithEvents mulButton As Button
    Friend WithEvents divButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MulToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SubToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DivToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MulToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VIewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox

End Class
