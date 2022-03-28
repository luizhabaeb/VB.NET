Imports System

Module Program
    Sub Main()
        Dim counter As Integer = 1

        Do Until counter > 10 'Inverso, preciso ver se é maior que 10, pois preciso do teste FALSO.'
            Console.WriteLine(counter)
            counter += 1
        Loop

        Console.ReadLine()
    End Sub
End Module