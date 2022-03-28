Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim texto As String = "MOZÃO, PEGA 1 SORVETIN PA NOIS - E DA UM SOSSEGO NESSA MANUELA"
        MessageBox.Show(texto, "PEGA A VISÃO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
    End Sub
End Class
