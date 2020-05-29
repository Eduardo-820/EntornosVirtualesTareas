<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaSencilla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboxISV = New System.Windows.Forms.ComboBox()
        Me.checkboxISV = New System.Windows.Forms.CheckBox()
        Me.comboxDescuento = New System.Windows.Forms.ComboBox()
        Me.checkboxDescuento = New System.Windows.Forms.CheckBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPUnitario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtISV)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(326, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 220)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles Factura"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(82, 117)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total"
        '
        'txtISV
        '
        Me.txtISV.Location = New System.Drawing.Point(82, 87)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(100, 20)
        Me.txtISV.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ISV"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(82, 57)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(82, 27)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Subtotal"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(233, 210)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Location = New System.Drawing.Point(233, 88)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(233, 58)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboxISV)
        Me.GroupBox1.Controls.Add(Me.checkboxISV)
        Me.GroupBox1.Controls.Add(Me.comboxDescuento)
        Me.GroupBox1.Controls.Add(Me.checkboxDescuento)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPUnitario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 220)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'comboxISV
        '
        Me.comboxISV.Enabled = False
        Me.comboxISV.FormattingEnabled = True
        Me.comboxISV.Items.AddRange(New Object() {"15", "17"})
        Me.comboxISV.Location = New System.Drawing.Point(24, 176)
        Me.comboxISV.Name = "comboxISV"
        Me.comboxISV.Size = New System.Drawing.Size(158, 21)
        Me.comboxISV.TabIndex = 6
        '
        'checkboxISV
        '
        Me.checkboxISV.AutoSize = True
        Me.checkboxISV.Location = New System.Drawing.Point(24, 153)
        Me.checkboxISV.Name = "checkboxISV"
        Me.checkboxISV.Size = New System.Drawing.Size(95, 17)
        Me.checkboxISV.TabIndex = 5
        Me.checkboxISV.Text = "Aplicar ISV (%)"
        Me.checkboxISV.UseVisualStyleBackColor = True
        '
        'comboxDescuento
        '
        Me.comboxDescuento.Enabled = False
        Me.comboxDescuento.FormattingEnabled = True
        Me.comboxDescuento.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.comboxDescuento.Location = New System.Drawing.Point(24, 117)
        Me.comboxDescuento.Name = "comboxDescuento"
        Me.comboxDescuento.Size = New System.Drawing.Size(158, 21)
        Me.comboxDescuento.TabIndex = 4
        '
        'checkboxDescuento
        '
        Me.checkboxDescuento.AutoSize = True
        Me.checkboxDescuento.Location = New System.Drawing.Point(24, 94)
        Me.checkboxDescuento.Name = "checkboxDescuento"
        Me.checkboxDescuento.Size = New System.Drawing.Size(128, 17)
        Me.checkboxDescuento.TabIndex = 3
        Me.checkboxDescuento.Text = "Aplicar descuento (%)"
        Me.checkboxDescuento.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(82, 57)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad"
        '
        'txtPUnitario
        '
        Me.txtPUnitario.Location = New System.Drawing.Point(82, 27)
        Me.txtPUnitario.Name = "txtPUnitario"
        Me.txtPUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtPUnitario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P. unitario"
        '
        'FacturaSencilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 274)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FacturaSencilla"
        Me.Text = "Factura"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtISV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents comboxISV As ComboBox
    Friend WithEvents checkboxISV As CheckBox
    Friend WithEvents comboxDescuento As ComboBox
    Friend WithEvents checkboxDescuento As CheckBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPUnitario As TextBox
    Friend WithEvents Label1 As Label
End Class
