Public Class Form1
    Dim n1, n2, r1, r2 As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Valor()
        r2 = n1 Mod n2
        Label4.Text = r2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Valor()
        r1 = Math.Pow(n1, n2)
        Label2.Text = r1

    End Sub

    Sub Valor()
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)


    End Sub







End Class
