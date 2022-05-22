Public Class Form1
    Dim count As Integer = 0
    Dim isx As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If count = 0 Then
            btn1.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn1.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn1.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn1.Enabled = False

        Dim myw As String = "X"
        If btn1.Text = myw And btn2.Text = myw And btn3.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn1.Text = myw And btn5.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn1.Text = myw And btn4.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
        If btn1.Text = myw And btn2.Text = myw And btn3.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn1.Text = myw And btn5.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn1.Text = myw And btn4.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        count = 0
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If count = 0 Then
            btn2.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn2.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn2.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn2.Enabled = False

        Dim myw As String = "X"
        If btn2.Text = myw And btn1.Text = myw And btn3.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn2.Text = myw And btn5.Text = myw And btn8.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()

        End If

        myw = "O"
        If btn2.Text = myw And btn1.Text = myw And btn3.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn2.Text = myw And btn5.Text = myw And btn8.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()

        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If count = 0 Then
            btn3.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn3.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn3.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn3.Enabled = False

        Dim myw As String = "X"
        If btn3.Text = myw And btn2.Text = myw And btn1.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn3.Text = myw And btn5.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn3.Text = myw And btn6.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
        If btn3.Text = myw And btn2.Text = myw And btn1.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn3.Text = myw And btn5.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn3.Text = myw And btn6.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If count = 0 Then
            btn4.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn4.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn4.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn4.Enabled = False

        Dim myw As String = "X"
        If btn4.Text = myw And btn1.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn4.Text = myw And btn5.Text = myw And btn6.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
        If btn4.Text = myw And btn1.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn4.Text = myw And btn5.Text = myw And btn6.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If count = 0 Then
            btn5.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn5.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn5.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn5.Enabled = False

        Dim myw As String = "X"
        If btn5.Text = myw And btn1.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn5.Text = myw And btn3.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn5.Text = myw And btn2.Text = myw And btn8.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn5.Text = myw And btn6.Text = myw And btn4.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
        If btn5.Text = myw And btn1.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn5.Text = myw And btn3.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn5.Text = myw And btn2.Text = myw And btn8.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn5.Text = myw And btn6.Text = myw And btn4.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If count = 0 Then
            btn6.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn6.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn6.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn6.Enabled = False


        Dim myw As String = "X"
        If btn6.Text = myw And btn3.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn6.Text = myw And btn5.Text = myw And btn4.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
        If btn6.Text = myw And btn3.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn6.Text = myw And btn5.Text = myw And btn4.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If count = 0 Then
            btn7.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn7.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn7.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn7.Enabled = False

        Dim myw As String = "X"
        If btn7.Text = myw And btn1.Text = myw And btn4.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn7.Text = myw And btn5.Text = myw And btn3.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn7.Text = myw And btn8.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
        If btn7.Text = myw And btn1.Text = myw And btn4.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn7.Text = myw And btn5.Text = myw And btn3.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn7.Text = myw And btn8.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If count = 0 Then
            btn8.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn8.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn8.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn8.Enabled = False

        Dim myw As String = "X"
        If btn8.Text = myw And btn2.Text = myw And btn5.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn8.Text = myw And btn7.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
        If btn8.Text = myw And btn2.Text = myw And btn5.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn8.Text = myw And btn7.Text = myw And btn9.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If count = 0 Then
            btn9.Text = "X"
            isx = "X"
            count = count + 1
        ElseIf isx = "X" Then
            btn9.Text = "O"
            isx = "O"
            count = count + 1
        ElseIf isx = "O" Then
            btn9.Text = "X"
            isx = "X"
            count = count + 1
        End If
        btn9.Enabled = False

        Dim myw As String = "X"
        If btn9.Text = myw And btn1.Text = myw And btn5.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn9.Text = myw And btn6.Text = myw And btn3.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        ElseIf btn9.Text = myw And btn8.Text = myw And btn7.Text = myw Then
            MessageBox.Show("Player " + myw + " won")
            btnreset.PerformClick()
        End If

        myw = "O"
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        count = 0
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
    End Sub
End Class
