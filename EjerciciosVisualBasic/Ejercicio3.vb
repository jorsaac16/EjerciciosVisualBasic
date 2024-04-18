Module Ejercicio3
    Sub Main()

        Console.Write("Ingrese la longitud de la base mayor del trapecio: ")
        Dim baseMayor As Double = CDbl(Console.ReadLine())

        Console.Write("Ingrese la longitud de la base menor del trapecio: ")
        Dim baseMenor As Double = CDbl(Console.ReadLine())

        Console.Write("Ingrese la altura del trapecio: ")
        Dim altura As Double = CDbl(Console.ReadLine())

        Dim area As Double = ((baseMayor + baseMenor) * altura) / 2

        Console.WriteLine("El área del trapecio es: " & area)

        Console.WriteLine("Presione cualquier tecla para salir...")

        Console.ReadKey()

    End Sub

End Module
