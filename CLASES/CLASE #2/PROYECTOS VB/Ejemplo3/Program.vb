Imports System

Module Program
    Sub Main(args As String())
        Dim n1, n2 As Integer

        Console.WriteLine("Ingrese el primer numero: ")
        n1 = Console.ReadLine()

        Console.WriteLine("Ingrese el segundo numero: ")
        n2 = Console.ReadLine()

        multiplicar(n1, n2)

    End Sub


    Sub multiplicar(ByVal n1, ByVal n2)

        Console.WriteLine("Multiplicar {0} * {1} da como resultado = {2}", n1, n2, n1 * n2)
        Console.ReadLine()
    End Sub

End Module
