Imports System

Module Program
    Sub Main(args As String())
        Dim n1, n2, suma As Integer
        Console.Write("Ingrese el primer numero: " & vbCrLf)
        n1 = Console.ReadLine()
        Console.Write("Ingrese el segundo numero: " & vbCrLf)
        n2 = Console.ReadLine()

        suma = n1 + n2

        Console.WriteLine("La suma de {0} + {1} es igual a = {2}", n1, n2, suma)
        Console.ReadLine()




    End Sub
End Module
