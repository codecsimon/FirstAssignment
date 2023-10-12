Public Class frmMain
    Private Sub btnSizeChart_Click(sender As Object, e As EventArgs) Handles btnSizeChart.Click
        picChart.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class