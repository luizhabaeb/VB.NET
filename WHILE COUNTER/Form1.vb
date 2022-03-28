Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter As Integer = 1
        While counter <= 15
            Console.Write(counter & " ")
            counter += 1
        End While

        Console.ReadLine()

    End Sub
End Class
