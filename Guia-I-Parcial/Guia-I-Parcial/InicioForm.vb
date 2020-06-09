Public Class InicioForm
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Calculadora.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub FormulaGeneralCuadraticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulaGeneralCuadraticaToolStripMenuItem.Click
        formulaGeneralCuadratica.Show()
    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem.Click
        almacenes.Show()
    End Sub

    Private Sub CadenaDeNumerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadenaDeNumerosToolStripMenuItem.Click
        cadenaDeNumeros.Show()
    End Sub
End Class
