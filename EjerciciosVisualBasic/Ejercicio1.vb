Module Ejercicio1
    Sub Main()

        Dim moles As Double
        Dim volumen As Double
        Dim concentracion As Double

        Console.WriteLine("Ingrese el número de moles:")
        moles = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese el volumen de la solución en litros:")
        volumen = Convert.ToDouble(Console.ReadLine())

        concentracion = moles / volumen

        Console.WriteLine("La concentración de la solución es: " & concentracion & " moles/L")

        Console.ReadKey()

    End Sub
End Module
