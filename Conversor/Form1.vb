Public Class Form1

    'Subrutina BtnCalcular
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If editOrigen.Text.Length > 0 Then
            'El usuario ha rellenado algo
            Dim suma As Object
            Dim numero As Decimal = 0

            If rbOriDec.Checked Then
                'Guardamos el numero decimal
                numero = Convert.ToDecimal(editOrigen.Text)
            End If

            If rbOrigBin.Checked Then
                Dim binario As String

                'Convertimos binario a decimal
                binario = Trim(editOrigen.Text)
                binario = StrReverse(binario)

                For I = 1 To Len(binario)

                    Dim X As Double
                    X = 2 ^ (I - 1)
                    suma = suma + (Int(Mid$(binario, I, 1)) * X)

                Next I

                numero = suma
            End If

            If rbOrigHex.Checked Then
                'Hexadecimal a numero
                numero = Convert.ToInt32(editOrigen.Text, 16)
            End If

            If numero <> 0 Then
                calcular(numero)
            End If
        Else
            Console.WriteLine("No hay nada!")
        End If
    End Sub

    'Metodo calcular siempre desde un Decimal
    Function calcular(ByVal num As Decimal)
        'Recibimos el numero
        Console.WriteLine("He recibido el numero ")
        Console.WriteLine(num)

        If rbDesDec.Checked Then
            editDestino.Text = Convert.ToString(num)
        End If

        If rbDesBin.Checked Then
            'Convertir Decimal a Binario
            Dim Resto As Object

            Do Until num < 2
                Resto = Resto & Str(num Mod 2)
                num = Int(num / 2)
            Loop
            Resto = Resto & num

            editDestino.Text = Convert.ToString(Resto)
        End If

        If rbDesHex.Checked Then
            'Convertir Decimal a Hexadecimal
            editDestino.Text = Hex(num)
        End If

    End Function

    'Subrutina limpiar
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Textos
        editOrigen.Text = ""
        editDestino.Text = ""

        'RadioButtons
        rbOriDec.Checked = False
        rbOrigBin.Checked = False
        rbOrigHex.Checked = False

        rbDesDec.Checked = False
        rbDesBin.Checked = False
        rbDesHex.Checked = False

        Console.WriteLine("Formulario reseteado correctamente")
    End Sub

End Class
