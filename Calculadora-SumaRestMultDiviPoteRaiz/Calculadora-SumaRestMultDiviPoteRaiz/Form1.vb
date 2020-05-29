Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rbtnSuma.Checked = True Then
            txtSigno.Text = "+"
            txtTotal.Text = Val(txtValor1.Text) + Val(txtValor2.Text)
        ElseIf rbtnResta.Checked = True Then
            txtSigno.Text = "-"
            txtTotal.Text = Val(txtValor1.Text) - Val(txtValor2.Text)
        ElseIf rbtnMultip.Checked = True Then
            txtSigno.Text = "x"
            txtTotal.Text = Val(txtValor1.Text) * Val(txtValor2.Text)
        ElseIf rbtnDivision.Checked = True Then
            txtSigno.Text = "/"
            txtTotal.Text = Val(txtValor1.Text) / Val(txtValor2.Text)
        ElseIf rbtnPotencia.Checked = True Then
            txtSigno.Text = "^"
            txtTotal.Text = Val(txtValor1.Text) ^ Val(txtValor2.Text)
        ElseIf rbtnRaiz.Checked = True Then
            txtSigno.Text = ""
            txtTotal.Text = Val(txtValor1.Text) ^ (0.5)
        End If
    End Sub

    Private Sub rbtnRaiz_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRaiz.CheckedChanged
        If rbtnRaiz.Checked = True Then
            txtValor2.Enabled = False
            txtValor2.Text = "Raiz Cuadrada"
        Else
            txtValor2.Enabled = True
            txtValor2.Clear()
        End If
    End Sub
End Class
