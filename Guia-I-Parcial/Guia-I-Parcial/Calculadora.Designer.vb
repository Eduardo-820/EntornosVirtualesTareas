<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonMR = New System.Windows.Forms.Button()
        Me.ButtonMC = New System.Windows.Forms.Button()
        Me.ButtonMS = New System.Windows.Forms.Button()
        Me.TxtOperacion = New System.Windows.Forms.TextBox()
        Me.ButtonClean = New System.Windows.Forms.Button()
        Me.ButtonDivision = New System.Windows.Forms.Button()
        Me.ButtonMultiplicacion = New System.Windows.Forms.Button()
        Me.ButtonResta = New System.Windows.Forms.Button()
        Me.ButtonSuma = New System.Windows.Forms.Button()
        Me.ButtonIgual = New System.Windows.Forms.Button()
        Me.ButtonPunto = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CboxHistorial = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ButtonMR
        '
        Me.ButtonMR.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonMR.Enabled = False
        Me.ButtonMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMR.Location = New System.Drawing.Point(71, 70)
        Me.ButtonMR.Name = "ButtonMR"
        Me.ButtonMR.Size = New System.Drawing.Size(51, 26)
        Me.ButtonMR.TabIndex = 79
        Me.ButtonMR.Text = "MR"
        Me.ButtonMR.UseVisualStyleBackColor = False
        '
        'ButtonMC
        '
        Me.ButtonMC.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMC.Location = New System.Drawing.Point(128, 70)
        Me.ButtonMC.Name = "ButtonMC"
        Me.ButtonMC.Size = New System.Drawing.Size(51, 26)
        Me.ButtonMC.TabIndex = 78
        Me.ButtonMC.Text = "MC"
        Me.ButtonMC.UseVisualStyleBackColor = False
        '
        'ButtonMS
        '
        Me.ButtonMS.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMS.Location = New System.Drawing.Point(14, 70)
        Me.ButtonMS.Name = "ButtonMS"
        Me.ButtonMS.Size = New System.Drawing.Size(51, 26)
        Me.ButtonMS.TabIndex = 77
        Me.ButtonMS.Text = "MS"
        Me.ButtonMS.UseVisualStyleBackColor = False
        '
        'TxtOperacion
        '
        Me.TxtOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOperacion.Location = New System.Drawing.Point(11, 38)
        Me.TxtOperacion.Name = "TxtOperacion"
        Me.TxtOperacion.Size = New System.Drawing.Size(170, 26)
        Me.TxtOperacion.TabIndex = 58
        Me.TxtOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonClean
        '
        Me.ButtonClean.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClean.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonClean.Location = New System.Drawing.Point(11, 99)
        Me.ButtonClean.Name = "ButtonClean"
        Me.ButtonClean.Size = New System.Drawing.Size(82, 26)
        Me.ButtonClean.TabIndex = 75
        Me.ButtonClean.Text = "CE"
        Me.ButtonClean.UseVisualStyleBackColor = False
        '
        'ButtonDivision
        '
        Me.ButtonDivision.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivision.Location = New System.Drawing.Point(99, 99)
        Me.ButtonDivision.Name = "ButtonDivision"
        Me.ButtonDivision.Size = New System.Drawing.Size(38, 26)
        Me.ButtonDivision.TabIndex = 73
        Me.ButtonDivision.Text = "/"
        Me.ButtonDivision.UseVisualStyleBackColor = False
        '
        'ButtonMultiplicacion
        '
        Me.ButtonMultiplicacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiplicacion.Location = New System.Drawing.Point(143, 99)
        Me.ButtonMultiplicacion.Name = "ButtonMultiplicacion"
        Me.ButtonMultiplicacion.Size = New System.Drawing.Size(38, 26)
        Me.ButtonMultiplicacion.TabIndex = 72
        Me.ButtonMultiplicacion.Text = "x"
        Me.ButtonMultiplicacion.UseVisualStyleBackColor = False
        '
        'ButtonResta
        '
        Me.ButtonResta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResta.Location = New System.Drawing.Point(143, 131)
        Me.ButtonResta.Name = "ButtonResta"
        Me.ButtonResta.Size = New System.Drawing.Size(38, 26)
        Me.ButtonResta.TabIndex = 71
        Me.ButtonResta.Text = "-"
        Me.ButtonResta.UseVisualStyleBackColor = False
        '
        'ButtonSuma
        '
        Me.ButtonSuma.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuma.Location = New System.Drawing.Point(143, 160)
        Me.ButtonSuma.Name = "ButtonSuma"
        Me.ButtonSuma.Size = New System.Drawing.Size(38, 55)
        Me.ButtonSuma.TabIndex = 70
        Me.ButtonSuma.Text = "+"
        Me.ButtonSuma.UseVisualStyleBackColor = False
        '
        'ButtonIgual
        '
        Me.ButtonIgual.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonIgual.Enabled = False
        Me.ButtonIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIgual.Location = New System.Drawing.Point(99, 218)
        Me.ButtonIgual.Name = "ButtonIgual"
        Me.ButtonIgual.Size = New System.Drawing.Size(82, 26)
        Me.ButtonIgual.TabIndex = 74
        Me.ButtonIgual.Text = "="
        Me.ButtonIgual.UseVisualStyleBackColor = False
        '
        'ButtonPunto
        '
        Me.ButtonPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPunto.Location = New System.Drawing.Point(55, 218)
        Me.ButtonPunto.Name = "ButtonPunto"
        Me.ButtonPunto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonPunto.Size = New System.Drawing.Size(38, 26)
        Me.ButtonPunto.TabIndex = 69
        Me.ButtonPunto.Text = "."
        Me.ButtonPunto.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button0.Location = New System.Drawing.Point(11, 218)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(38, 26)
        Me.Button0.TabIndex = 59
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button9.Location = New System.Drawing.Point(99, 131)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(38, 26)
        Me.Button9.TabIndex = 68
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button8.Location = New System.Drawing.Point(55, 131)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 26)
        Me.Button8.TabIndex = 67
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(11, 131)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 26)
        Me.Button7.TabIndex = 66
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(99, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 26)
        Me.Button6.TabIndex = 65
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(55, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 26)
        Me.Button5.TabIndex = 64
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(11, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 26)
        Me.Button4.TabIndex = 63
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(99, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 26)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(55, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 26)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(11, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 26)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CboxHistorial
        '
        Me.CboxHistorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboxHistorial.FormattingEnabled = True
        Me.CboxHistorial.Location = New System.Drawing.Point(11, 12)
        Me.CboxHistorial.Name = "CboxHistorial"
        Me.CboxHistorial.Size = New System.Drawing.Size(170, 21)
        Me.CboxHistorial.TabIndex = 80
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 260)
        Me.Controls.Add(Me.CboxHistorial)
        Me.Controls.Add(Me.ButtonMR)
        Me.Controls.Add(Me.ButtonMC)
        Me.Controls.Add(Me.ButtonMS)
        Me.Controls.Add(Me.TxtOperacion)
        Me.Controls.Add(Me.ButtonClean)
        Me.Controls.Add(Me.ButtonDivision)
        Me.Controls.Add(Me.ButtonMultiplicacion)
        Me.Controls.Add(Me.ButtonResta)
        Me.Controls.Add(Me.ButtonSuma)
        Me.Controls.Add(Me.ButtonIgual)
        Me.Controls.Add(Me.ButtonPunto)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Calculadora"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ButtonMR As Button
    Friend WithEvents ButtonMC As Button
    Friend WithEvents ButtonMS As Button
    Friend WithEvents TxtOperacion As TextBox
    Friend WithEvents ButtonClean As Button
    Friend WithEvents ButtonDivision As Button
    Friend WithEvents ButtonMultiplicacion As Button
    Friend WithEvents ButtonResta As Button
    Friend WithEvents ButtonSuma As Button
    Friend WithEvents ButtonIgual As Button
    Friend WithEvents ButtonPunto As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CboxHistorial As ComboBox
End Class
