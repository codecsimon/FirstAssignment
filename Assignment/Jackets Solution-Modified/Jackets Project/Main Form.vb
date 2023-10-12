Public Class frmMain
    Private Sub btnSizeChart_Click(sender As Object, e As EventArgs) Handles btnSizeChart.Click
        picChart.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        'Displays a black jacket
        picJacket.Image = My.Resources.BlackJacket

    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        'Displays a blue jacket
        picJacket.Image = My.Resources.BlueJacket
    End Sub

    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click
        'Displays a brown jacket
        picJacket.Image = My.Resources.BrownJacket

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        'Displays a Red jacket
        picJacket.Image = My.Resources.RedJacket
    End Sub
End Class