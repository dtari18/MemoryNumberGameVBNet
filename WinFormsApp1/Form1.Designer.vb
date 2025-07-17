<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        btn8 = New Button()
        btn3 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn6 = New Button()
        btn1 = New Button()
        btn7 = New Button()
        btn2 = New Button()
        btn9 = New Button()
        Timer1 = New Timer(components)
        Label1 = New Label()
        lblTimer = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(219, 627)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 54)
        Button1.TabIndex = 0
        Button1.Text = "SELESAI"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.LemonChiffon
        btn8.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn8.Location = New Point(60, 203)
        btn8.Name = "btn8"
        btn8.Size = New Size(112, 90)
        btn8.TabIndex = 1
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.LemonChiffon
        btn3.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn3.Location = New Point(219, 203)
        btn3.Name = "btn3"
        btn3.Size = New Size(112, 90)
        btn3.TabIndex = 2
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.LemonChiffon
        btn5.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn5.Location = New Point(386, 203)
        btn5.Name = "btn5"
        btn5.Size = New Size(112, 90)
        btn5.TabIndex = 3
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.LemonChiffon
        btn4.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn4.Location = New Point(386, 338)
        btn4.Name = "btn4"
        btn4.Size = New Size(112, 90)
        btn4.TabIndex = 6
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.LemonChiffon
        btn6.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn6.Location = New Point(219, 338)
        btn6.Name = "btn6"
        btn6.Size = New Size(112, 90)
        btn6.TabIndex = 5
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.LemonChiffon
        btn1.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(60, 338)
        btn1.Name = "btn1"
        btn1.Size = New Size(112, 90)
        btn1.TabIndex = 4
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.LemonChiffon
        btn7.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn7.Location = New Point(386, 468)
        btn7.Name = "btn7"
        btn7.Size = New Size(112, 90)
        btn7.TabIndex = 9
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.LemonChiffon
        btn2.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(219, 468)
        btn2.Name = "btn2"
        btn2.Size = New Size(112, 90)
        btn2.TabIndex = 8
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.LemonChiffon
        btn9.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn9.Location = New Point(60, 468)
        btn9.Name = "btn9"
        btn9.Size = New Size(112, 90)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(60, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 38)
        Label1.TabIndex = 10
        Label1.Text = "Waktu : "
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTimer.Location = New Point(193, 70)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(49, 38)
        lblTimer.TabIndex = 11
        lblTimer.Text = "30"
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(386, 66)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 54)
        btnClose.TabIndex = 12
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 710)
        Controls.Add(btnClose)
        Controls.Add(lblTimer)
        Controls.Add(Label1)
        Controls.Add(btn7)
        Controls.Add(btn2)
        Controls.Add(btn9)
        Controls.Add(btn4)
        Controls.Add(btn6)
        Controls.Add(btn1)
        Controls.Add(btn5)
        Controls.Add(btn3)
        Controls.Add(btn8)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Memory Number Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnClose As Button

End Class
