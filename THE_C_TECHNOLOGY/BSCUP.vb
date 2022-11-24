
Public Class BSCUP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        OpenFileDialog1.ShowDialog()
        Label13.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("DO YOU WANT CLEAR ALL ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            For Each CNT As Control In Me.Controls
                If TypeOf CNT Is TextBox Then
                    CNT.Text = String.Empty
                End If
            Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("DO YOU WANT EXIT ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Close()
        End If

    End Sub



    Private Sub Label13_TextChanged(sender As Object, e As EventArgs) Handles Label13.TextChanged
        If (System.IO.File.Exists(Label13.Text)) Then
            PictureBox1.Image = Image.FromFile(Label13.Text)
        End If
        If Label13.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()

        End If
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TXTDOB.Text = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TXTGENDER.Text = "MALE"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TXTGENDER.Text = "FEMALE"
    End Sub



End Class