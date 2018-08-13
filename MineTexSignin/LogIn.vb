Public Class LogIn
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As Integer

        Dim username As Integer
        password = 2384156

        username = 6514832

        If TextBox1.Text = username Then
            MsgBox("Logging In", MsgBoxStyle.Information, "MineTex- Logging In")
        End If

        If TextBox2.Text = password Then
            Me.Hide()
            Form1.Show()

        End If
    End Sub
End Class
