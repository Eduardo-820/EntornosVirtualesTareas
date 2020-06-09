<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadenaDeNumeros
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
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.cmboxNumeros = New System.Windows.Forms.ComboBox()
        Me.txtNumPares = New System.Windows.Forms.TextBox()
        Me.txtNumImpares = New System.Windows.Forms.TextBox()
        Me.txtNumPositivos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumNegativos = New System.Windows.Forms.TextBox()
        Me.txtNumIngresados = New System.Windows.Forms.TextBox()
        Me.txtNumSumaTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(25, 26)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(123, 20)
        Me.txtIngresar.TabIndex = 0
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(51, 52)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "Ingresar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'cmboxNumeros
        '
        Me.cmboxNumeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxNumeros.Enabled = False
        Me.cmboxNumeros.FormattingEnabled = True
        Me.cmboxNumeros.Location = New System.Drawing.Point(25, 81)
        Me.cmboxNumeros.Name = "cmboxNumeros"
        Me.cmboxNumeros.Size = New System.Drawing.Size(123, 21)
        Me.cmboxNumeros.TabIndex = 2
        '
        'txtNumPares
        '
        Me.txtNumPares.Location = New System.Drawing.Point(254, 26)
        Me.txtNumPares.Name = "txtNumPares"
        Me.txtNumPares.ReadOnly = True
        Me.txtNumPares.Size = New System.Drawing.Size(100, 20)
        Me.txtNumPares.TabIndex = 3
        '
        'txtNumImpares
        '
        Me.txtNumImpares.Location = New System.Drawing.Point(254, 52)
        Me.txtNumImpares.Name = "txtNumImpares"
        Me.txtNumImpares.ReadOnly = True
        Me.txtNumImpares.Size = New System.Drawing.Size(100, 20)
        Me.txtNumImpares.TabIndex = 4
        '
        'txtNumPositivos
        '
        Me.txtNumPositivos.Location = New System.Drawing.Point(254, 78)
        Me.txtNumPositivos.Name = "txtNumPositivos"
        Me.txtNumPositivos.ReadOnly = True
        Me.txtNumPositivos.Size = New System.Drawing.Size(100, 20)
        Me.txtNumPositivos.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pares"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Impares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Positivos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Negativos"
        '
        'txtNumNegativos
        '
        Me.txtNumNegativos.Location = New System.Drawing.Point(254, 104)
        Me.txtNumNegativos.Name = "txtNumNegativos"
        Me.txtNumNegativos.ReadOnly = True
        Me.txtNumNegativos.Size = New System.Drawing.Size(100, 20)
        Me.txtNumNegativos.TabIndex = 10
        '
        'txtNumIngresados
        '
        Me.txtNumIngresados.Location = New System.Drawing.Point(254, 130)
        Me.txtNumIngresados.Name = "txtNumIngresados"
        Me.txtNumIngresados.ReadOnly = True
        Me.txtNumIngresados.Size = New System.Drawing.Size(100, 20)
        Me.txtNumIngresados.TabIndex = 11
        '
        'txtNumSumaTotal
        '
        Me.txtNumSumaTotal.Location = New System.Drawing.Point(254, 156)
        Me.txtNumSumaTotal.Name = "txtNumSumaTotal"
        Me.txtNumSumaTotal.ReadOnly = True
        Me.txtNumSumaTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtNumSumaTotal.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cantidad Ingresada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Sumatoria"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 163)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(51, 23)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cadenaDeNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 198)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumSumaTotal)
        Me.Controls.Add(Me.txtNumIngresados)
        Me.Controls.Add(Me.txtNumNegativos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumPositivos)
        Me.Controls.Add(Me.txtNumImpares)
        Me.Controls.Add(Me.txtNumPares)
        Me.Controls.Add(Me.cmboxNumeros)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtIngresar)
        Me.MaximizeBox = False
        Me.Name = "cadenaDeNumeros"
        Me.ShowIcon = False
        Me.Text = "Cadena de Numeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents cmboxNumeros As ComboBox
    Friend WithEvents txtNumPares As TextBox
    Friend WithEvents txtNumImpares As TextBox
    Friend WithEvents txtNumPositivos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumNegativos As TextBox
    Friend WithEvents txtNumIngresados As TextBox
    Friend WithEvents txtNumSumaTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSalir As Button
End Class
