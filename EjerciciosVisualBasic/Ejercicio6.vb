Module Ejercicio6
    Sub Main()

        Console.WriteLine("Ingrese un número de tres dígitos:")
        Dim numero As Integer = Integer.Parse(Console.ReadLine())

        If numero >= 100 AndAlso numero <= 999 Then
            Dim primerDigito As Integer = numero \ 100
            Dim segundoDigito As Integer = (numero \ 10) Mod 10
            Dim tercerDigito As Integer = numero Mod 10

            Dim numeroAlReves As Integer = tercerDigito * 100 + segundoDigito * 10 + primerDigito

            Console.WriteLine("El número al revés es: " & numeroAlReves)
        Else
            Console.WriteLine("El número ingresado no es de tres dígitos.")
        End If

        Console.ReadKey()

    End Sub
End Module
