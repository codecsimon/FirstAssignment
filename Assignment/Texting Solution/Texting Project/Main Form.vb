Public Class frmMain
    Private Sub picBFF_Click(sender As Object, e As EventArgs) Handles picBFF.Click
        lblMessage.Text = "Best Friends Forever"

    End Sub

    Private Sub picBRB_Click(sender As Object, e As EventArgs) Handles picBRB.Click
        lblMessage.Text = "Best Friends Forever"
    End Sub

    Private Sub picIDK_Click(sender As Object, e As EventArgs) Handles picIDK.Click
        lblMessage.Text = "Best Friends Forever"
    End Sub

    Private Sub picLOL_Click(sender As Object, e As EventArgs) Handles picLOL.Click
        lblMessage.Text = "Lots of Love"
    End Sub

    Private Sub picSRY_Click(sender As Object, e As EventArgs) Handles picSRY.Click
        lblMessage.Text = "seriosly"
    End Sub

    Private Sub picXO_Click(sender As Object, e As EventArgs) Handles picXO.Click
        lblMessage.Text = "Best Friends Forever"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class