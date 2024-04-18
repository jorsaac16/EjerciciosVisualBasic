Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim moles As Double
        Dim volumen As Double
        Dim concentracion As Double

        If Double.TryParse(txtmoles.Text, moles) AndAlso Double.TryParse(txtvolumen.Text, volumen) Then
            concentracion = moles / volumen

            txtresultado.Text = "La concentración de la solución es: " & concentracion.ToString("0.00") & " moles/L"

        Else
            MessageBox.Show("Por favor, ingrese valores numéricos válidos para los moles y el volumen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnCombertir_Click(sender As Object, e As EventArgs) Handles btnCombertir.Click
        Dim celsius As Double = Convert.ToDouble(txtcelcius.Text)
        Dim fahrenheit As Double = (celsius * 9 / 5) + 32
        txtfahrenheit.Text = fahrenheit.ToString()
    End Sub

    Private Sub btnResolver_Click(sender As Object, e As EventArgs) Handles btnResolver.Click

        Dim baseMayor As Double
        Dim baseMenor As Double
        Dim altura As Double

        If Double.TryParse(txtB1.Text, baseMayor) AndAlso
           Double.TryParse(txtB2.Text, baseMenor) AndAlso
           Double.TryParse(txtAltura.Text, altura) Then

            Dim area As Double = ((baseMayor + baseMenor) * altura) / 2

            txtSolucion.Text = area.ToString()
        Else
            MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnCalcular2_Click(sender As Object, e As EventArgs) Handles btnCalcular2.Click
        Dim ladoa, ladob, hipotenusa As Double

        ladoa = Double.Parse(txtLadoA.Text)
        ladob = Double.Parse(txtLadoB.Text)

        hipotenusa = Math.Sqrt(Math.Pow(ladoa, 2) + Math.Pow(ladob, 2))

        txthipotenusa.Text = (hipotenusa)
    End Sub

    Private Sub btnResolver1_Click(sender As Object, e As EventArgs) Handles btnResolver1.Click
        Dim numero As Integer
        If Integer.TryParse(txtnumero.Text, numero) AndAlso numero >= 100 AndAlso numero <= 999 Then
            Dim primerDigito As Integer = numero \ 100
            Dim segundoDigito As Integer = (numero \ 10) Mod 10
            Dim tercerDigito As Integer = numero Mod 10

            Dim numeroAlReves As Integer = tercerDigito * 100 + segundoDigito * 10 + primerDigito

            txtnumeroreves.Text = numeroAlReves.ToString()
        Else
            MessageBox.Show("Ingrese un número de tres dígitos.")
        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub btnCArea_Click(sender As Object, e As EventArgs) Handles btnCArea.Click
        Dim ladoA As Double = CDbl(txtL1.Text)
        Dim ladoB As Double = CDbl(txtL2.Text)
        Dim ladoC As Double = CDbl(txtL3.Text)

        Dim si As Double = ladoA + ladoB + ladoC
        Dim semiperimetro = si / 2
        Dim sa As Double = semiperimetro - ladoA
        Dim sb As Double = semiperimetro - ladoB
        Dim sc As Double = semiperimetro - ladoC

        Dim f As Double = semiperimetro * sa * sb * sc
        Dim area As Double = Math.Sqrt(f)

        txtSArea.Text = area.ToString()
    End Sub

    Private Sub btnCalcularDV_Click(sender As Object, e As EventArgs) Handles btnCalcularDV.Click
        Dim aceleracion As Double = CDbl(txtAcelaracion.Text)
        Dim tiempo As Double = CDbl(txtTiempo.Text)

        Dim distancia As Double = 0.5 * aceleracion * (tiempo ^ 2)

        Dim velocidad As Double = aceleracion * tiempo

        txtDistancia.Text = distancia.ToString()
        txtVelocidad.Text = velocidad.ToString()
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim radio As Double = CDbl(txtRadio.Text)

        Dim area As Double = 3.1416 * radio ^ 2

        txtArea.Text = area.ToString()
    End Sub

    Private Sub btnLongitud_Click(sender As Object, e As EventArgs) Handles btnLongitud.Click
        Dim radio = CDbl(txtRadio.Text)

        Dim longitud As Double = 2 * 3.1416 * radio

        txtLongitud.Text = longitud.ToString()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class