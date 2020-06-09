Public Class formulaGeneralCuadratica
    Dim a, b, c, Raiz, RaizResuelta, SolucionPositiva, SolucionNegativa

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txta_TextChanged(sender As Object, e As EventArgs) Handles txta.TextChanged
        If Not IsNumeric(txta.Text) And txta.Text <> "" Then
            Beep()
            txta.Text = ""
        End If
    End Sub

    Private Sub txtb_TextChanged(sender As Object, e As EventArgs) Handles txtb.TextChanged
        If Not IsNumeric(txtb.Text) And txtb.Text <> "" Then
            Beep()
            txtb.Text = ""
        End If
    End Sub

    Private Sub txtc_TextChanged(sender As Object, e As EventArgs) Handles txtc.TextChanged
        If Not IsNumeric(txtc.Text) And txtc.Text <> "" Then
            Beep()
            txtc.Text = ""
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            a = Val(txta.Text)
            b = Val(txtb.Text)
            c = Val(txtc.Text)
            Raiz = (b ^ 2) - 4 * a * c
            RaizResuelta = Raiz ^ (1 / 2)
            SolucionPositiva = (-b + RaizResuelta) / (2 * a)
            SolucionNegativa = (-b - RaizResuelta) / (2 * a)
            txtSolucion1.Text = SolucionPositiva
            txtSolucion2.Text = SolucionNegativa
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class