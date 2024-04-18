Module Ejercicio4
    Sub Main()

        Dim ladoa, ladob, hipotenusa As Double

        Console.WriteLine("Ingrese la primera longitud del lado a del triangulo rectangulo:")
        ladoa = Double.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese la segunda longitud del lado b del triangulo rectangulo:")
        ladob = Double.Parse(Console.ReadLine())

        hipotenusa = Math.Sqrt(Math.Pow(ladoa, 2) + Math.Pow(ladob, 2))

        Console.WriteLine("La hipotenusa del triángulo rectángulo es: " & hipotenusa)

        Console.ReadKey()

    End Sub
End Module
