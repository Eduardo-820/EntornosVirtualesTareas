<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtSigno = New System.Windows.Forms.TextBox()
        Me.rbtnPotencia = New System.Windows.Forms.RadioButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.rbtnRaiz = New System.Windows.Forms.RadioButton()
        Me.rbtnDivision = New System.Windows.Forms.RadioButton()
        Me.rbtnMultip = New System.Windows.Forms.RadioButton()
        Me.rbtnResta = New System.Windows.Forms.RadioButton()
        Me.rbtnSuma = New System.Windows.Forms.RadioButton()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(108, 124)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 19
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtSigno
        '
        Me.txtSigno.Enabled = False
        Me.txtSigno.Location = New System.Drawing.Point(133, 98)
        Me.txtSigno.Name = "txtSigno"
        Me.txtSigno.Size = New System.Drawing.Size(27, 20)
        Me.txtSigno.TabIndex = 20
        '
        'rbtnPotencia
        '
        Me.rbtnPotencia.AutoSize = True
        Me.rbtnPotencia.Location = New System.Drawing.Point(207, 37)
        Me.rbtnPotencia.Name = "rbtnPotencia"
        Me.rbtnPotencia.Size = New System.Drawing.Size(66, 17)
        Me.rbtnPotencia.TabIndex = 15
        Me.rbtnPotencia.TabStop = True
        Me.rbtnPotencia.Text = "potencia"
        Me.rbtnPotencia.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(96, 153)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 21
        '
        'rbtnRaiz
        '
        Me.rbtnRaiz.AutoSize = True
        Me.rbtnRaiz.Location = New System.Drawing.Point(207, 60)
        Me.rbtnRaiz.Name = "rbtnRaiz"
        Me.rbtnRaiz.Size = New System.Drawing.Size(41, 17)
        Me.rbtnRaiz.TabIndex = 16
        Me.rbtnRaiz.TabStop = True
        Me.rbtnRaiz.Text = "raiz"
        Me.rbtnRaiz.UseVisualStyleBackColor = True
        '
        'rbtnDivision
        '
        Me.rbtnDivision.AutoSize = True
        Me.rbtnDivision.Location = New System.Drawing.Point(108, 60)
        Me.rbtnDivision.Name = "rbtnDivision"
        Me.rbtnDivision.Size = New System.Drawing.Size(60, 17)
        Me.rbtnDivision.TabIndex = 14
        Me.rbtnDivision.TabStop = True
        Me.rbtnDivision.Text = "division"
        Me.rbtnDivision.UseVisualStyleBackColor = True
        '
        'rbtnMultip
        '
        Me.rbtnMultip.AutoSize = True
        Me.rbtnMultip.Location = New System.Drawing.Point(108, 36)
        Me.rbtnMultip.Name = "rbtnMultip"
        Me.rbtnMultip.Size = New System.Drawing.Size(88, 17)
        Me.rbtnMultip.TabIndex = 13
        Me.rbtnMultip.TabStop = True
        Me.rbtnMultip.Text = "multiplicacion"
        Me.rbtnMultip.UseVisualStyleBackColor = True
        '
        'rbtnResta
        '
        Me.rbtnResta.AutoSize = True
        Me.rbtnResta.Location = New System.Drawing.Point(27, 61)
        Me.rbtnResta.Name = "rbtnResta"
        Me.rbtnResta.Size = New System.Drawing.Size(48, 17)
        Me.rbtnResta.TabIndex = 12
        Me.rbtnResta.TabStop = True
        Me.rbtnResta.Text = "resta"
        Me.rbtnResta.UseVisualStyleBackColor = True
        '
        'rbtnSuma
        '
        Me.rbtnSuma.AutoSize = True
        Me.rbtnSuma.Location = New System.Drawing.Point(27, 37)
        Me.rbtnSuma.Name = "rbtnSuma"
        Me.rbtnSuma.Size = New System.Drawing.Size(50, 17)
        Me.rbtnSuma.TabIndex = 11
        Me.rbtnSuma.TabStop = True
        Me.rbtnSuma.Text = "suma"
        Me.rbtnSuma.UseVisualStyleBackColor = True
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(166, 98)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 18
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(27, 98)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 192)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtSigno)
        Me.Controls.Add(Me.rbtnPotencia)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.rbtnRaiz)
        Me.Controls.Add(Me.rbtnDivision)
        Me.Controls.Add(Me.rbtnMultip)
        Me.Controls.Add(Me.rbtnResta)
        Me.Controls.Add(Me.rbtnSuma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtSigno As TextBox
    Friend WithEvents rbtnPotencia As RadioButton
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents rbtnRaiz As RadioButton
    Friend WithEvents rbtnDivision As RadioButton
    Friend WithEvents rbtnMultip As RadioButton
    Friend WithEvents rbtnResta As RadioButton
    Friend WithEvents rbtnSuma As RadioButton
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
End Class
