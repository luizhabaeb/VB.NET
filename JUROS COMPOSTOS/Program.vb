Imports System

Module Program
    Sub Main()
        Dim montante, capinicial As Decimal 'Para representar um n�mero com bastante precis�o
        Dim taxaJuros As Double 'Pode ser um n�mero quebrado
        Dim ano As Integer
        Dim sa�da As String 'Vamos utilizar para exibir a quantia ap�s cada ano

        Console.WriteLine("Coloque o capital inicial: ")
        capinicial = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("Qual a taxa de juros?")
        taxaJuros = Console.ReadLine()
        Console.WriteLine()
        sa�da = "Ano" & vbTab & "Quantia" & vbCrLf

        For ano = 1 To 10
            montante = capinicial * (1 + taxaJuros) ^ ano
            sa�da &= ano & vbTab & String.Format("{0:C}", montante) & vbCrLf 'O String.Format � dispens�vel. Daria pra fazer apenas concatenando '& montante'
        Next

        Console.WriteLine(sa�da)
    End Sub
End Module
