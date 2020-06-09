Public Class cadenaDeNumeros
    Dim numeros, numPositivos, numNegativos, numImpares, numPares As Integer

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Dim valor, sumatoria As Double
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If Not IsNumeric(txtIngresar.Text) And txtIngresar.Text <> "" Then
                Beep()
                MsgBox("Solo se permiten valores numericos")
                txtIngresar.Text = ""
            Else
                cmboxNumeros.Enabled = True
                numeros += 1
                valor = Val(txtIngresar.Text)
                cmboxNumeros.Items.Add(valor)
                sumatoria += valor
                txtNumSumaTotal.Text = sumatoria

                If valor < 0 Then
                    numNegativos += 1
                Else
                    numPositivos += 1
                End If

                If valor Mod 2 = 0 Then
                    numPares += 1
                Else
                    numImpares += 1
                End If
                txtNumIngresados.Text = numeros
                txtNumPositivos.Text = numPositivos
                txtNumNegativos.Text = numNegativos
                txtNumPares.Text = numPares
                txtNumImpares.Text = numImpares
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class