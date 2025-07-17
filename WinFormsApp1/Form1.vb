Public Class Form1
    Dim nilai As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nilai = 1
        Timer1.Start()
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = lblTimer.Text - 1
        If lblTimer.Text = 0 Then
            Timer1.Stop()
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn1.Text = nilai Then
            nilai = nilai + 1
            btn1.Text = ""
            btn1.BackColor = Color.Green
            btn1.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.Text = nilai Then
            nilai = nilai + 1
            btn2.Text = ""
            btn2.BackColor = Color.Green
            btn2.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If btn3.Text = nilai Then
            nilai = nilai + 1
            btn3.Text = ""
            btn3.BackColor = Color.Green
            btn3.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If btn4.Text = nilai Then
            nilai = nilai + 1
            btn4.Text = ""
            btn4.BackColor = Color.Green
            btn4.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If btn5.Text = nilai Then
            nilai = nilai + 1
            btn5.Text = ""
            btn5.BackColor = Color.Green
            btn5.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If btn6.Text = nilai Then
            nilai = nilai + 1
            btn6.Text = ""
            btn6.BackColor = Color.Green
            btn6.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If btn7.Text = nilai Then
            nilai = nilai + 1
            btn7.Text = ""
            btn7.BackColor = Color.Green
            btn7.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If btn8.Text = nilai Then
            nilai = nilai + 1
            btn8.Text = ""
            btn8.BackColor = Color.Green
            btn8.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If btn9.Text = nilai Then
            nilai = nilai + 1
            btn9.Text = ""
            btn9.BackColor = Color.Green
            btn9.Enabled = False
        Else
            MsgBox("Salah!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
        FormAwal.Show()
    End Sub
End Class
