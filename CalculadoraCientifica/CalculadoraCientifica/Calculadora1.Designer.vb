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
        Me.ButtonIgual = New System.Windows.Forms.Button()
        Me.ButtonSuma = New System.Windows.Forms.Button()
        Me.ButtonResta = New System.Windows.Forms.Button()
        Me.ButtonMultiplicacion = New System.Windows.Forms.Button()
        Me.ButtonDivision = New System.Windows.Forms.Button()
        Me.ButtonClean = New System.Windows.Forms.Button()
        Me.TxtOperacion = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CientificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtProceso = New System.Windows.Forms.TextBox()
        Me.ButtonMR = New System.Windows.Forms.Button()
        Me.ButtonMC = New System.Windows.Forms.Button()
        Me.ButtonMS = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(56, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 26)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(100, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 26)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 26)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(56, 178)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 26)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(100, 178)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 26)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 149)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 26)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(56, 149)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 26)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(100, 149)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(38, 26)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(12, 236)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(38, 26)
        Me.Button0.TabIndex = 1
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'ButtonPunto
        '
        Me.ButtonPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPunto.Location = New System.Drawing.Point(56, 236)
        Me.ButtonPunto.Name = "ButtonPunto"
        Me.ButtonPunto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonPunto.Size = New System.Drawing.Size(38, 26)
        Me.ButtonPunto.TabIndex = 11
        Me.ButtonPunto.Text = "."
        Me.ButtonPunto.UseVisualStyleBackColor = True
        '
        'ButtonIgual
        '
        Me.ButtonIgual.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonIgual.Enabled = False
        Me.ButtonIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIgual.Location = New System.Drawing.Point(100, 236)
        Me.ButtonIgual.Name = "ButtonIgual"
        Me.ButtonIgual.Size = New System.Drawing.Size(82, 26)
        Me.ButtonIgual.TabIndex = 16
        Me.ButtonIgual.Text = "="
        Me.ButtonIgual.UseVisualStyleBackColor = False
        '
        'ButtonSuma
        '
        Me.ButtonSuma.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuma.Location = New System.Drawing.Point(144, 178)
        Me.ButtonSuma.Name = "ButtonSuma"
        Me.ButtonSuma.Size = New System.Drawing.Size(38, 55)
        Me.ButtonSuma.TabIndex = 12
        Me.ButtonSuma.Text = "+"
        Me.ButtonSuma.UseVisualStyleBackColor = False
        '
        'ButtonResta
        '
        Me.ButtonResta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResta.Location = New System.Drawing.Point(144, 149)
        Me.ButtonResta.Name = "ButtonResta"
        Me.ButtonResta.Size = New System.Drawing.Size(38, 26)
        Me.ButtonResta.TabIndex = 13
        Me.ButtonResta.Text = "-"
        Me.ButtonResta.UseVisualStyleBackColor = False
        '
        'ButtonMultiplicacion
        '
        Me.ButtonMultiplicacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiplicacion.Location = New System.Drawing.Point(144, 117)
        Me.ButtonMultiplicacion.Name = "ButtonMultiplicacion"
        Me.ButtonMultiplicacion.Size = New System.Drawing.Size(38, 26)
        Me.ButtonMultiplicacion.TabIndex = 14
        Me.ButtonMultiplicacion.Text = "x"
        Me.ButtonMultiplicacion.UseVisualStyleBackColor = False
        '
        'ButtonDivision
        '
        Me.ButtonDivision.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivision.Location = New System.Drawing.Point(100, 117)
        Me.ButtonDivision.Name = "ButtonDivision"
        Me.ButtonDivision.Size = New System.Drawing.Size(38, 26)
        Me.ButtonDivision.TabIndex = 15
        Me.ButtonDivision.Text = "/"
        Me.ButtonDivision.UseVisualStyleBackColor = False
        '
        'ButtonClean
        '
        Me.ButtonClean.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClean.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonClean.Location = New System.Drawing.Point(12, 117)
        Me.ButtonClean.Name = "ButtonClean"
        Me.ButtonClean.Size = New System.Drawing.Size(82, 26)
        Me.ButtonClean.TabIndex = 17
        Me.ButtonClean.Text = "CE"
        Me.ButtonClean.UseVisualStyleBackColor = False
        '
        'TxtOperacion
        '
        Me.TxtOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOperacion.Location = New System.Drawing.Point(13, 56)
        Me.TxtOperacion.Name = "TxtOperacion"
        Me.TxtOperacion.Size = New System.Drawing.Size(169, 26)
        Me.TxtOperacion.TabIndex = 0
        Me.TxtOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(196, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModoToolStripMenuItem
        '
        Me.ModoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicoToolStripMenuItem, Me.CientificaToolStripMenuItem})
        Me.ModoToolStripMenuItem.Name = "ModoToolStripMenuItem"
        Me.ModoToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ModoToolStripMenuItem.Text = "Modo"
        '
        'BasicoToolStripMenuItem
        '
        Me.BasicoToolStripMenuItem.Enabled = False
        Me.BasicoToolStripMenuItem.Name = "BasicoToolStripMenuItem"
        Me.BasicoToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BasicoToolStripMenuItem.Text = "Basico"
        '
        'CientificaToolStripMenuItem
        '
        Me.CientificaToolStripMenuItem.Name = "CientificaToolStripMenuItem"
        Me.CientificaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CientificaToolStripMenuItem.Text = "Cientifica"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TxtProceso
        '
        Me.TxtProceso.Enabled = False
        Me.TxtProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProceso.Location = New System.Drawing.Point(13, 33)
        Me.TxtProceso.Name = "TxtProceso"
        Me.TxtProceso.Size = New System.Drawing.Size(169, 22)
        Me.TxtProceso.TabIndex = 19
        Me.TxtProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonMR
        '
        Me.ButtonMR.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMR.Enabled = False
        Me.ButtonMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMR.Location = New System.Drawing.Point(72, 88)
        Me.ButtonMR.Name = "ButtonMR"
        Me.ButtonMR.Size = New System.Drawing.Size(51, 26)
        Me.ButtonMR.TabIndex = 57
        Me.ButtonMR.Text = "MR"
        Me.ButtonMR.UseVisualStyleBackColor = False
        '
        'ButtonMC
        '
        Me.ButtonMC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMC.Location = New System.Drawing.Point(129, 88)
        Me.ButtonMC.Name = "ButtonMC"
        Me.ButtonMC.Size = New System.Drawing.Size(51, 26)
        Me.ButtonMC.TabIndex = 56
        Me.ButtonMC.Text = "MC"
        Me.ButtonMC.UseVisualStyleBackColor = False
        '
        'ButtonMS
        '
        Me.ButtonMS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMS.Location = New System.Drawing.Point(15, 88)
        Me.ButtonMS.Name = "ButtonMS"
        Me.ButtonMS.Size = New System.Drawing.Size(51, 26)
        Me.ButtonMS.TabIndex = 55
        Me.ButtonMS.Text = "MS"
        Me.ButtonMS.UseVisualStyleBackColor = False
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonMR)
        Me.Controls.Add(Me.ButtonMC)
        Me.Controls.Add(Me.ButtonMS)
        Me.Controls.Add(Me.TxtProceso)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents ButtonIgual As Button
    Friend WithEvents ButtonSuma As Button
    Friend WithEvents ButtonResta As Button
    Friend WithEvents ButtonMultiplicacion As Button
    Friend WithEvents ButtonDivision As Button
    Friend WithEvents ButtonClean As Button
    Friend WithEvents TxtOperacion As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CientificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtProceso As TextBox
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonMR As Button
    Friend WithEvents ButtonMC As Button
    Friend WithEvents ButtonMS As Button
End Class
