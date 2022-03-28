Imports System
Module Módulo1

    Sub Main()
        'CONDICIONAL ANINHADO
        'DISPLAYS MESSAGES ACCORDING TO THE UMIDITY AIR INSERTED BY THE USER'
        'Over 90% → Rain.'
        'Between 70% and 90% → It can Rain.'
        'Between 50% and 70% → Cloudy.'
        'Under 50% → Clean Weather.'

        Dim umidity As String
        Do
            Console.WriteLine("Input Umidity Value: ")
            umidity = Console.ReadLine()
            Console.WriteLine()

            If umidity > 90 Then
                Console.WriteLine("Today's gonna rain.")
            ElseIf umidity >= 70 Then
                Console.WriteLine("It can rain.")
            ElseIf umidity >= 50 Then
                Console.WriteLine("It's Cloudy.")
            Else
                Console.WriteLine("Clean Weather.")
            End If

        Loop



    End Sub
End Module
