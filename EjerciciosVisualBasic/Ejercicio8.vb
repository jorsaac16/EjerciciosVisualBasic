Module Ejercicio8
    Sub Main()

        Dim radio As Double
        Dim longitud As Double
        Dim area As Double
        Dim pi As Double = Math.PI

        Console.WriteLine("Ingrese el radio de la circunferencia:")
        radio = Double.Parse(Console.ReadLine())

        longitud = 2 * pi * radio
        area = pi * radio * radio

        Console.WriteLine("Longitud de la circunferencia: " & longitud)
        Console.WriteLine("Area de la circunferencia: " & area)

        Console.ReadKey()
    End Sub
End Module
