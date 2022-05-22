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

    End Sub
End Class
