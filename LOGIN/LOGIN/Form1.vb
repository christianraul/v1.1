Public Class Form1

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim a, b, res As Integer
        a = (txtnum1.Text)
        b = (txtnum2.Text)
        res = a + b
        txtresul.Text = res

    End Sub
End Class
