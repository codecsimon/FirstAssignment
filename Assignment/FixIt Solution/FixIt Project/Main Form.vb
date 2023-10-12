' Name:         FixIt Project
' Purpose:      Display the picture and price of a parrot.
' Programmer:   <your name> on <current date>

Public Class frmMain


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Display the price.

        lblPrice.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close 
        Me.Close()
    End Sub
End Class
