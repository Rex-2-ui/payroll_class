Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim ExitMessage As String ExitMessage = "Are you sure you want to exit?" If MessageBox.Show(ExitMessage, "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then Application.Exit() End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
