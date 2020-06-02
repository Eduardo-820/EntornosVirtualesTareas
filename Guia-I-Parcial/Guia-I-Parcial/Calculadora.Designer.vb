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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.ButtonPunto = New System.Windows.Forms.Button()
        Me.ButtonResta = New System.Windows.Forms.Button()
        Me.ButtonSuma = New System.Windows.Forms.Button()
        Me.ButtonMulti = New System.Windows.Forms.Button()
        Me.ButtonDivision = New System.Windows.Forms.Button()
        Me.ButtonIgual = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 26)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(47, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(88, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(47, 123)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 30)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(88, 123)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 30)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(6, 87)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(35, 30)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(47, 87)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 30)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(88, 87)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(35, 30)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(6, 195)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(76, 30)
        Me.Button0.TabIndex = 10
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'ButtonPunto
        '
        Me.ButtonPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPunto.Location = New System.Drawing.Point(88, 195)
        Me.ButtonPunto.Name = "ButtonPunto"
        Me.ButtonPunto.Size = New System.Drawing.Size(35, 30)
        Me.ButtonPunto.TabIndex = 11
        Me.ButtonPunto.Text = "."
        Me.ButtonPunto.UseVisualStyleBackColor = True
        '
        'ButtonResta
        '
        Me.ButtonResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResta.Location = New System.Drawing.Point(129, 87)
        Me.ButtonResta.Name = "ButtonResta"
        Me.ButtonResta.Size = New System.Drawing.Size(35, 30)
        Me.ButtonResta.TabIndex = 12
        Me.ButtonResta.Text = "-"
        Me.ButtonResta.UseVisualStyleBackColor = True
        '
        'ButtonSuma
        '
        Me.ButtonSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuma.Location = New System.Drawing.Point(129, 123)
        Me.ButtonSuma.Name = "ButtonSuma"
        Me.ButtonSuma.Size = New System.Drawing.Size(35, 30)
        Me.ButtonSuma.TabIndex = 13
        Me.ButtonSuma.Text = "+"
        Me.ButtonSuma.UseVisualStyleBackColor = True
        '
        'ButtonMulti
        '
        Me.ButtonMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMulti.Location = New System.Drawing.Point(129, 51)
        Me.ButtonMulti.Name = "ButtonMulti"
        Me.ButtonMulti.Size = New System.Drawing.Size(35, 30)
        Me.ButtonMulti.TabIndex = 14
        Me.ButtonMulti.Text = "x"
        Me.ButtonMulti.UseVisualStyleBackColor = True
        '
        'ButtonDivision
        '
        Me.ButtonDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivision.Location = New System.Drawing.Point(88, 51)
        Me.ButtonDivision.Name = "ButtonDivision"
        Me.ButtonDivision.Size = New System.Drawing.Size(35, 30)
        Me.ButtonDivision.TabIndex = 15
        Me.ButtonDivision.Text = "/"
        Me.ButtonDivision.UseVisualStyleBackColor = True
        '
        'ButtonIgual
        '
        Me.ButtonIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIgual.Location = New System.Drawing.Point(129, 159)
        Me.ButtonIgual.Name = "ButtonIgual"
        Me.ButtonIgual.Size = New System.Drawing.Size(35, 66)
        Me.ButtonIgual.TabIndex = 16
        Me.ButtonIgual.Text = "="
        Me.ButtonIgual.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(5, 51)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(77, 30)
        Me.ButtonLimpiar.TabIndex = 17
        Me.ButtonLimpiar.Text = "CE"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(17, 277)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ButtonIgual)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ButtonDivision)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.ButtonMulti)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.ButtonSuma)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.ButtonResta)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.ButtonPunto)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button0)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 240)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculadora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Historial"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 313)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Calculadora"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents ButtonPunto As Button
    Friend WithEvents ButtonResta As Button
    Friend WithEvents ButtonSuma As Button
    Friend WithEvents ButtonMulti As Button
    Friend WithEvents ButtonDivision As Button
    Friend WithEvents ButtonIgual As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
