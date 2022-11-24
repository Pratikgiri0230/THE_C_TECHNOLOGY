Public Class Form2



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        BSCH.Show()
    End Sub



    Private Sub Form2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim G As Graphics = Me.CreateGraphics
        Dim P As Pen
        P = New Pen(Brushes.Black, 2)
        G.DrawLine(P, 0, 120, 1700, 120)
        G.DrawLine(P, 0, 90, 1700, 90)
        G.DrawLine(P, 360, 120, 360, 1700)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class