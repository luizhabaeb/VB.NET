Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim text As String = "My First WinForms!"

        MessageBox.Show(text, "Testing...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    End Sub
End Class
