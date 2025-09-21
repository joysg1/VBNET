Imports System

Module Program
    Sub Main(args As String())
        Dim n1, n2, alt As Integer



        Console.WriteLine("Ingrese el primer numero: ")
        n1 = Console.ReadLine()

        Console.WriteLine("Ingrese el segundo numero: ")
        n2 = Console.ReadLine()

        Console.WriteLine("La suma de {0} y {1} es igual a = {2} ", n1, n2, n1 + n2)

        Console.WriteLine("La resta de {0} y {1} es igual a = {2} ", n1, n2, n1 - n2)

        Console.WriteLine("La multiplicacion de {0} y {1} es igual a = {2} ", n1, n2, n1 * n2)

        Console.WriteLine("La division entera de {0} y {1} es igual a = {2} ", n1, n2, n1 \ n2)

        Console.WriteLine("La division real  {0} y {1} es igual a = {2} ", n1, n2, n1 / n2)

        Console.WriteLine("La potencia de {0} a la  {1} es igual a = {2} ", n1, n2, Math.Pow(n1, n2))




        Randomize()
        alt = Int((99 - 1) * Rnd() + 1)

        Console.WriteLine("El numero aleatorio es el = {0}", alt)

        Console.ReadLine()
    End Sub
End Module
