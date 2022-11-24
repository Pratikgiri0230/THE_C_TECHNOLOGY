Public Class BSCDE
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MessageBox.Show("DO YOU WANT EXIT ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If

    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("DO YOU WANT DELETE CURRENT FORM ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

        End If
    End Sub






    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If (System.IO.File.Exists(Label1.Text)) Then
            PictureBox1.Image = Image.FromFile(Label1.Text)
        End If
        If Label1.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()

        End If
    End Sub
End Class