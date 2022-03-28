Imports System

Module Program
    Sub Main() '←←←← Procedimento principal do programa'
        Dim name, lastname As String

        Console.WriteLine("Type your name: ")
        name = Console.ReadLine()

        Console.WriteLine("Type your last name: ")
        lastname = Console.ReadLine()

        fullname(name, lastname)

        Console.ReadLine()
    End Sub
    Sub fullname(ByVal n As String, ByVal l As String)
        Console.WriteLine(n & " " & l)
    End Sub
End Module
