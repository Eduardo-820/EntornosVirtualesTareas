Public Class almacenes
    Dim numeroAlmacen As Integer
    Dim ventasPorAlmacen(9), total, media As Double
    Dim name1, name2, name3, name4 As String

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        CmboxLista.Items.Clear()
        CmboxSupMedia.Items.Clear()
        txtNombre.Clear()
        txtVentas.Clear()
        txtmedia.Clear()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not IsNumeric(txtVentas.Text) And txtVentas.Text <> "" Then
            Beep()
            MsgBox("Solo se permiten valores numericos", MessageBoxIcon.Warning)
            txtVentas.Text = ""
        Else
            CmboxLista.Enabled = True
            CmboxLista.Items.Add(txtNombre.Text)
            ventasPorAlmacen(numeroAlmacen) = Val(txtVentas.Text)
            numeroAlmacen += 1
        End If
    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        total = 0
        CmboxSupMedia.Items.Clear()
        CmboxSupMedia.Enabled = True

        For i = 0 To numeroAlmacen Step 1
            total += ventasPorAlmacen(i)
        Next

        media = total / numeroAlmacen
        txtmedia.Text = media

        For i = 0 To numeroAlmacen Step 1
            If ventasPorAlmacen(i) > media Then
                CmboxSupMedia.Items.Add(CmboxLista.Items.Item(i))
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class