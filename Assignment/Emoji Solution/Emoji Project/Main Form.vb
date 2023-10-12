' Name:         Emoji Project
' Purpose:      Display a message corresponding to an emoji.
' Programmer:   <your name> on <current date>

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picCrying_Click(sender As Object, e As EventArgs) Handles picCrying.Click
        lblMessage.Text = "I am Crying"
    End Sub

    Private Sub picHappy_Click(sender As Object, e As EventArgs) Handles picHappy.Click
        lblMessage.Text = "I am Happy"
    End Sub

    Private Sub picLove_Click(sender As Object, e As EventArgs) Handles picLove.Click
        lblMessage.Text = "I am in Love"
    End Sub

    Private Sub picSad_Click(sender As Object, e As EventArgs) Handles picSad.Click
        lblMessage.Text = "I am Sad"
    End Sub

    Private Sub picTired_Click(sender As Object, e As EventArgs) Handles picTired.Click
        lblMessage.Text = "I am Tired"
    End Sub
End Class
