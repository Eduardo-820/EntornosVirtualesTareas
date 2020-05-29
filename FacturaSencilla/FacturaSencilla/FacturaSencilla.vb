Public Class FacturaSencilla
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim PUnitario, Cantidad As Integer
        Dim Descuento, ISV, SubTotal, Total As Double
        Dim AplicarDescuento, AplicarISV As Boolean

        If txtPUnitario.Text = "" Then  'si no entra en la validacion
            MsgBox("Escriba un numero en la casilla de Precio Unitario.", vbInformation)
        ElseIf txtCantidad.Text = "" Then
            MsgBox("Escriba un numero en la casilla de Cantidad.", vbInformation)
        ElseIf Not IsNumeric(txtPUnitario.Text) Or Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Precio Unitario y Cantidad deben ser valores numericos.", vbInformation)
        ElseIf Val(txtPUnitario.Text) < 0 Or Val(txtCantidad.Text) < 0 Then
            MsgBox("No se permiten valores negativos para la operacion.", vbInformation)

        Else 'si entra en la validacion
            PUnitario = Val(txtPUnitario.Text)
            Cantidad = Val(txtCantidad.Text)

            AplicarDescuento = checkboxDescuento.Checked
            AplicarISV = checkboxISV.Checked
            Descuento = 0
            SubTotal = PUnitario * Cantidad

            If AplicarDescuento = True Then
                Descuento = SubTotal * (Val(comboxDescuento.Text) / 100)
                Total = SubTotal - Descuento
            End If

            If AplicarISV = True Then
                ISV = SubTotal * (Val(comboxISV.Text) / 100)
                Total = SubTotal + ISV
            End If

            txtSubtotal.Text = SubTotal
            txtDescuento.Text = Descuento
            txtISV.Text = ISV
            txtTotal.Text = Total
            btnNuevo.Enabled = True
        End If
    End Sub

    'Casillas Descuento/ISV
    Private Sub checkboxDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxDescuento.CheckedChanged
        If checkboxDescuento.Checked = True Then
            comboxDescuento.Enabled = True
            checkboxISV.Checked = False
            comboxISV.Enabled = False
            comboxISV.Text = ""
        End If
    End Sub

    Private Sub checkboxISV_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxISV.CheckedChanged
        If checkboxISV.Checked = True Then
            comboxISV.Enabled = True
            checkboxDescuento.Checked = False
            comboxDescuento.Enabled = False
            comboxDescuento.Text = ""
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPUnitario.Clear()
        txtCantidad.Clear()
        checkboxDescuento.Checked = False
        checkboxISV.Checked = False
        comboxDescuento.Enabled = False
        comboxDescuento.Text = ""
        comboxISV.Enabled = False
        comboxISV.Text = ""
        txtSubtotal.Clear()
        txtDescuento.Clear()
        txtISV.Clear()
        txtTotal.Clear()

        btnNuevo.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
