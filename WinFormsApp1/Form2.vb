Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim nilai As Integer
    Dim TimeClue As Integer
    Dim health As Integer

    Sub clueShow()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btn10.Enabled = False
        btn11.Enabled = False
        btn12.Enabled = False
    End Sub

    Sub clueClose()
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btn10.Enabled = True
        btn11.Enabled = True
        btn12.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btn10.Text = ""
        btn11.Text = ""
        btn12.Text = ""

        btn1.BackColor = Color.Red
        btn2.BackColor = Color.Red
        btn3.BackColor = Color.Red
        btn4.BackColor = Color.Red
        btn5.BackColor = Color.Red
        btn6.BackColor = Color.Red
        btn7.BackColor = Color.Red
        btn8.BackColor = Color.Red
        btn9.BackColor = Color.Red
        btn10.BackColor = Color.Red
        btn11.BackColor = Color.Red
        btn12.BackColor = Color.Red

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nilai = 1
        TimeClue = 4
        health = 3
        TimerClue.Start()
        Me.FormBorderStyle = FormBorderStyle.None


    End Sub

    Private Sub TimerClue_Tick(sender As Object, e As EventArgs) Handles TimerClue.Tick
        TimeClue = TimeClue - 1
        clueShow()
        If TimeClue <= 0 Then
            TimerClue.Stop()
            clueClose()
            Timer1.Start()

        End If
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
            btn10.Enabled = False
            btn11.Enabled = False
            btn12.Enabled = False
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If nilai = 1 Then
            nilai = nilai + 1
            btn1.Text = "1"
            btn1.BackColor = Color.LemonChiffon
            btn1.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If nilai = 2 Then
            nilai = nilai + 1
            btn2.Text = "2"
            btn2.BackColor = Color.LemonChiffon
            btn2.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If nilai = 3 Then
            nilai = nilai + 1
            btn3.Text = "3"
            btn3.BackColor = Color.LemonChiffon
            btn3.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If nilai = 4 Then
            nilai = nilai + 1
            btn4.Text = "4"
            btn4.BackColor = Color.LemonChiffon
            btn4.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If nilai = 5 Then
            nilai = nilai + 1
            btn5.Text = "5"
            btn5.BackColor = Color.LemonChiffon
            btn5.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If nilai = 6 Then
            nilai = nilai + 1
            btn6.Text = "6"
            btn6.BackColor = Color.LemonChiffon
            btn6.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If nilai = 7 Then
            nilai = nilai + 1
            btn7.Text = "7"
            btn7.BackColor = Color.LemonChiffon
            btn7.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If nilai = 8 Then
            nilai = nilai + 1
            btn8.Text = "8"
            btn8.BackColor = Color.LemonChiffon
            btn8.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")
            End If
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If nilai = 1 Then
            nilai = nilai + 1
            btn9.Text = "9"
            btn9.BackColor = Color.LemonChiffon
            btn9.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        clueShow()

    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If nilai = 10 Then
            nilai = nilai + 1
            btn10.Text = "10"
            btn10.BackColor = Color.LemonChiffon
            btn10.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        If nilai = 11 Then
            nilai = nilai + 1
            btn11.Text = "11"
            btn11.BackColor = Color.LemonChiffon
            btn11.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If nilai = 12 Then
            nilai = nilai + 1
            btn12.Text = "12"
            btn12.BackColor = Color.LemonChiffon
            btn12.Enabled = False
        Else
            MsgBox("Salah!")
            health = health - 1
            lblhealth.Text = lblhealth.Text.Substring(0, lblhealth.Text.Length - 1)
            If health = 0 Then
                Timer1.Stop()
                MsgBox("Game Over!")

            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
        FormAwal.Show()

    End Sub
End Class