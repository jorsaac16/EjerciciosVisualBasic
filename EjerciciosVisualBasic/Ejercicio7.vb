Module Ejercicio7
    Sub Main()

        Console.WriteLine("Ingrese la aceleración (a) en m/s^2:")
        Dim aceleracion As Double = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese el tiempo (t) en segundos:")
        Dim tiempo As Double = Convert.ToDouble(Console.ReadLine())

        Dim distancia As Double = 0.5 * aceleracion * (tiempo ^ 2)

        Dim velocidadFinal As Double = aceleracion * tiempo

        Console.WriteLine("Distancia (d): " & distancia & " metros")
        Console.WriteLine("Velocidad final (v): " & velocidadFinal & "m/s")

        Console.ReadKey()

    End Sub
End Module
