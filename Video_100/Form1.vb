Public Class Form1
    Private Sub btnShowMsg_Click(sender As Object, e As EventArgs) Handles btnShowMsg.Click
        Using myDoStuff As New doStuff
            myDoStuff.showMessage()
            myDoStuff.showMoreMessages()
        End Using
    End Sub
End Class
