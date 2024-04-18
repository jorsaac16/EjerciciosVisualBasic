Module Ejercicio5
    Sub Main()

        Console.WriteLine("Ingrese la longitud del lado a del triángulo:")
        Dim ladoA As Double = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese la longitud del lado b del triángulo:")
        Dim ladoB As Double = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese la longitud del lado c del triángulo:")
        Dim ladoC As Double = Convert.ToDouble(Console.ReadLine())

        Dim semiperimetro As Double = (ladoA + ladoB + ladoC) / 2

        Dim area As Double = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC))

        Console.WriteLine("El área del triángulo es: " & area)

        Console.ReadKey()

    End Sub

End Module
