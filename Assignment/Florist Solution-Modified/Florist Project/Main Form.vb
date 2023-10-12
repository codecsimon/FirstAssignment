Public Class frmMain


    Private Sub btnShow_Click_1(sender As Object, e As EventArgs) Handles btnShow.Click
        picHours.Visible = True
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        picHours.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
