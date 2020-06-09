Public Class almacenes
    Dim ventasPorAlmacen(9) As Double
    Dim numeroAlmacen, n As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not IsNumeric(txtVentas.Text) And txtVentas.Text <> "" Then
            Beep()
            MsgBox("Solo se permiten valores numericos", MessageBoxIcon.Warning)
            txtVentas.Text = ""
        Else
            CmboxLista.Items.Add(txtNombre)
            ventasPorAlmacen(numeroAlmacen) = Val(txtVentas.Text)
        End If
    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        CmboxSupMedia.Items.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class