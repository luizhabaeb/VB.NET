﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim input As String
        input = Nothing
        While input <> "output"
            input = InputBox("Type any word: ")
            Console.WriteLine(input)
        End While

    End Sub

End Class