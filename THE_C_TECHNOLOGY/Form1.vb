Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "ADMIN" And TextBox2.Text = "ADMIN" Then
            Me.Hide()
            Form2.Show()
        ElseIf TextBox1.Text = "" And TEXTBOX2.TEXT = "" Then
            MsgBox("PLEASE ENTER: 'USERNAME & PASSWORD'")
        Else
            MsgBox("WRONG : 'USERNAME & PASSWORD'")
        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class
