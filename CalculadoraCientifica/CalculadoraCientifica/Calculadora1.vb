Public Class Calculadora
    'Variables publicas para la clase Calculadora
    Dim valor1, valor2, operacion, respuesta, Mem As Double

    'Numeros y punto
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TxtOperacion.Text = TxtOperacion.Text & "0"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtOperacion.Text = TxtOperacion.Text & "1"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtOperacion.Text = TxtOperacion.Text & "2"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TxtOperacion.Text = TxtOperacion.Text & "3"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TxtOperacion.Text = TxtOperacion.Text & "4"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TxtOperacion.Text = TxtOperacion.Text & "5"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TxtOperacion.Text = TxtOperacion.Text & "6"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TxtOperacion.Text = TxtOperacion.Text & "7"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TxtOperacion.Text = TxtOperacion.Text & "8"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TxtOperacion.Text = TxtOperacion.Text & "9"
    End Sub
    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        Try
            If TxtOperacion.Text.IndexOf(".") > 0 Then
                Beep()
            ElseIf TxtOperacion.Text <> "." And TxtOperacion.Text <> "" Then
                TxtOperacion.Text = TxtOperacion.Text & "."
            Else
                TxtOperacion.Text = "0."
            End If
        Catch ex As Exception

        End Try
    End Sub

    'operaciones
    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        operacion = 1
        valor1 = Val(TxtOperacion.Text)
        TxtOperacion.Clear()
        TxtProceso.Text = valor1 & "+"
        ButtonIgual.Enabled = True
    End Sub
    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        operacion = 2
        valor1 = Val(TxtOperacion.Text)
        TxtOperacion.Clear()
        TxtProceso.Text = valor1 & "-"
        ButtonIgual.Enabled = True
    End Sub
    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        operacion = 3
        valor1 = Val(TxtOperacion.Text)
        TxtOperacion.Clear()
        TxtProceso.Text = valor1 & "x"
        ButtonIgual.Enabled = True
    End Sub
    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        operacion = 4
        valor1 = Val(TxtOperacion.Text)
        TxtOperacion.Clear()
        TxtProceso.Text = valor1 & "÷"
        ButtonIgual.Enabled = True
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        valor2 = Val(TxtOperacion.Text)
        If operacion = 1 Then
            respuesta = valor1 + valor2
            TxtProceso.Text = valor1 & " + " & valor2
            TxtOperacion.Text = respuesta
            valor1 = respuesta
            ButtonIgual.Enabled = False
        ElseIf operacion = 2 Then
            respuesta = valor1 - valor2
            TxtProceso.Text = valor1 & " - " & valor2
            TxtOperacion.Text = respuesta
            valor1 = respuesta
            ButtonIgual.Enabled = False
        ElseIf operacion = 3 Then
            respuesta = valor1 * valor2
            TxtProceso.Text = valor1 & " x " & valor2
            TxtOperacion.Text = respuesta
            valor1 = respuesta
            ButtonIgual.Enabled = False
        ElseIf operacion = 4 Then
            respuesta = valor1 / valor2
            TxtProceso.Text = valor1 & " ÷ " & valor2
            TxtOperacion.Text = respuesta
            valor1 = respuesta
            ButtonIgual.Enabled = False
        End If
    End Sub

    'que solo permita numericos
    Private Sub TxtOperacion_TextChanged(sender As Object, e As EventArgs) Handles TxtOperacion.TextChanged
        If Not IsNumeric(TxtOperacion.Text) And TxtOperacion.Text <> "" Then
            Beep()
            TxtOperacion.Text = ""
        End If
    End Sub

    Private Sub ButtonMS_Click(sender As Object, e As EventArgs) Handles ButtonMS.Click
        Mem = TxtOperacion.Text
        ButtonMR.Enabled = True
    End Sub

    Private Sub ButtonMR_Click(sender As Object, e As EventArgs) Handles ButtonMR.Click
        TxtOperacion.Text = Mem
    End Sub

    Private Sub ButtonMC_Click(sender As Object, e As EventArgs) Handles ButtonMC.Click
        Mem = 0
        ButtonMR.Enabled = False
    End Sub


    'Clean
    Private Sub ButtonClean_Click(sender As Object, e As EventArgs) Handles ButtonClean.Click
        TxtOperacion.Clear()
        TxtProceso.Clear()
        valor1 = 0
        valor2 = 0
        respuesta = 0
        ButtonIgual.Enabled = False
    End Sub

    'Menu Modo
    Private Sub CientificaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CientificaToolStripMenuItem.Click
        Calculadora2.Show()
        Me.Hide()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
