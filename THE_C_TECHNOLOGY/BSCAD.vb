
Public Class BSCAD

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("DO YOU WANT EXIT ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("DO YOU WANT CLEAR ALL ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each CNT As Control In Me.Controls
                If TypeOf CNT Is TextBox Then
                    CNT.Text = String.Empty
                End If
            Next
            For Each CNTB As Control In Me.Controls
                If TypeOf CNTB Is ComboBox Then
                    CNTB.Text = String.Empty
                End If
            Next
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenFileDialog1.ShowDialog()
            TXTIMG.Text = OpenFileDialog1.FileName
            Exit Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txtgender.Text = "MALE"

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txtgender.Text = "FEMALE"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        txtdob.Text = DateTimePicker2.Value.ToShortDateString
    End Sub
    Private Sub TXTIMG_TextChanged(sender As Object, e As EventArgs) Handles TXTIMG.TextChanged
        If (System.IO.File.Exists(TXTIMG.Text)) Then
            pic.Image = Image.FromFile(TXTIMG.Text)
        End If
        If TXTIMG.Text = "" Then
            pic.Hide()
        Else
            pic.Show()

        End If
    End Sub



End Class