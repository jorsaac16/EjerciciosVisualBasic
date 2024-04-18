Module Ejercicio2
    Sub Main()

        Dim celsius As Double
        Dim fahrenheit As Double

        Console.WriteLine("Ingrese la temperatura en grados Celsius:")
        celsius = Convert.ToDouble(Console.ReadLine())

        fahrenheit = (9 / 5) * celsius + 32

        Console.WriteLine("La temperatura en grados Fahrenheit es: " & fahrenheit & " °F")

        Console.ReadKey()

    End Sub
End Module
