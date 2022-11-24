
Public Class BSCH


    Sub SWITCHPANEL(ByVal PANEL As Form)

        Panel1.Controls.Clear()
        PANEL.TopLevel = False
        Panel1.Controls.Add(PANEL)
        PANEL.Show()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SWITCHPANEL(BSCAD)


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SWITCHPANEL(BSCUP)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SWITCHPANEL(BSCDE)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        SWITCHPANEL(BSCRCPT)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SWITCHPANEL(Bscre)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SWITCHPANEL(BSCFE)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Splitter1.SplitterMoved

    End Sub
End Class