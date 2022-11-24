
Public Class BSCFE


    Private Sub Label17_TextChanged(sender As Object, e As EventArgs) Handles Label17.TextChanged
        If (System.IO.File.Exists(Label17.Text)) Then
            pic.Image = Image.FromFile(Label17.Text)
        End If
        If Label17.Text = "" Then
            pic.Hide()
        Else
            pic.Show()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label6.Enabled = True
        Label7.Enabled = True
        Label8.Enabled = True
        Label9.Enabled = True
        Label10.Enabled = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        TXT1IN.Enabled = True
        TXT2IN.Enabled = True
        TXT3IN.Enabled = True
        TXT4IN.Enabled = True
        TXT5IN.Enabled = True
        TXT1IN.Visible = True
        TXT2IN.Visible = True
        TXT3IN.Visible = True
        TXT4IN.Visible = True
        TXT5IN.Visible = True
        TXT1D.Enabled = True
        TXT2D.Enabled = True
        TXT3D.Enabled = True
        TXT4D.Enabled = True
        TXT5D.Enabled = True
        TXT1D.Visible = True
        TXT2D.Visible = True
        TXT3D.Visible = True
        TXT4D.Visible = True
        TXT5D.Visible = True



    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label6.Enabled = False
        Label7.Enabled = False
        Label8.Enabled = False
        Label9.Enabled = False
        Label10.Enabled = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        TXT1IN.Enabled = False
        TXT2IN.Enabled = False
        TXT3IN.Enabled = False
        TXT4IN.Enabled = False
        TXT5IN.Enabled = False
        TXT1IN.Visible = False
        TXT2IN.Visible = False
        TXT3IN.Visible = False
        TXT4IN.Visible = False
        TXT5IN.Visible = False
        TXT1D.Enabled = False
        TXT2D.Enabled = False
        TXT3D.Enabled = False
        TXT4D.Enabled = False
        TXT5D.Enabled = False
        TXT1D.Visible = False
        TXT2D.Visible = False
        TXT3D.Visible = False
        TXT4D.Visible = False
        TXT5D.Visible = False

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TXT1IN.TextChanged
        If TXT1IN.Text = "" Then
            TXT1D.Text = ""
        Else
            TXT1D.Text = DateTimePicker1.Value.ToShortDateString
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TXT2IN.TextChanged
        If TXT2IN.Text = "" Then
            TXT2D.Text = ""
        Else
            TXT2D.Text = DateTimePicker1.Value.ToShortDateString
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TXT3IN.TextChanged
        If TXT3IN.Text = "" Then
            TXT3D.Text = ""
        Else
            TXT3D.Text = DateTimePicker1.Value.ToShortDateString
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TXT4IN.TextChanged
        If TXT4IN.Text = "" Then
            TXT4D.Text = ""
        Else
            TXT4D.Text = DateTimePicker1.Value.ToShortDateString
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TXT5IN.TextChanged
        If TXT5IN.Text = "" Then
            TXT5D.Text = ""
        Else
            TXT5D.Text = DateTimePicker1.Value.ToShortDateString
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton2.Checked = True Then
            TXTFP.Text = TextBox1.Text
        ElseIf TXT1IN.Text = "" Then
            TXT1IN.Text = TextBox1.Text
        ElseIf TXT2IN.Text = "" Then
            TXT2IN.Text = TextBox1.Text
        ElseIf TXT3IN.Text = "" Then
            TXT3IN.Text = TextBox1.Text
        ElseIf TXT4IN.Text = "" Then
            TXT4IN.Text = TextBox1.Text
        ElseIf TXT5IN.Text = "" Then
            TXT5IN.Text = TextBox1.Text
        Else
            MsgBox("YOU HAVE REACHED MAXIMUM INSTALMENT")

        End If
        If RadioButton1.Checked Then
            TXTFP.Text = Val(TXT1IN.Text) + Val(TXT2IN.Text) + Val(TXT3IN.Text) + Val(TXT4IN.Text) + Val(TXT5IN.Text)
            TXTRF.Text = Val(TXTTF.Text) - Val(TXTFP.Text)
        Else
            TXTRF.Text = Val(TXTTF.Text) - Val(TXTFP.Text)
        End If
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("DO YOU WANT CLEAR ALL ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each CF As Control In Me.Controls
                If TypeOf CF Is TextBox Then
                    CF.Text = String.Empty
                End If
            Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("DO YOU WANT EXIT ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Close()
        End If
    End Sub


    Private Sub notfound()
        MsgBox("The Search Item was not Found")

    End Sub
End Class

