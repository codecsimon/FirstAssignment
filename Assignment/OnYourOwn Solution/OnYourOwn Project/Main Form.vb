Public Class frmMain
    Private Sub picFlorist_Click_1(sender As Object, e As EventArgs) Handles picFlorist.Click
        lblShow.Text = "Beautiful flowers"
    End Sub

    Private Sub picMonkey_Click_1(sender As Object, e As EventArgs) Handles picMonkey.Click
        lblShow.Text = "Monkey is in love"
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
