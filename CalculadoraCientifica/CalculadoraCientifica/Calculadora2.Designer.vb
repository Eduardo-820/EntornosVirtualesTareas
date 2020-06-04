<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtProceso = New System.Windows.Forms.TextBox()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CientificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonMasMenos = New System.Windows.Forms.Button()
        Me.ButtonSen = New System.Windows.Forms.Button()
        Me.ButtonCos = New System.Windows.Forms.Button()
        Me.ButtonTan = New System.Windows.Forms.Button()
        Me.ButtonReciproco = New System.Windows.Forms.Button()
        Me.ButtonXCuadrado = New System.Windows.Forms.Button()
        Me.ButtonRaiz = New System.Windows.Forms.Button()
        Me.ButtonPorcentaje = New System.Windows.Forms.Button()
        Me.ButtonLog = New System.Windows.Forms.Button()
        Me.ButtonPI = New System.Windows.Forms.Button()
        Me.ButtonPotencia = New System.Windows.Forms.Button()
        Me.ButtonMS = New System.Windows.Forms.Button()
        Me.ButtonMC = New System.Windows.Forms.Button()
        Me.ButtonMR = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtProceso
        '
        Me.TxtProceso.Enabled = False
        Me.TxtProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProceso.Location = New System.Drawing.Point(12, 32)
        Me.TxtProceso.Name = "TxtProceso"
        Me.TxtProceso.Size = New System.Drawing.Size(214, 22)
        Me.TxtProceso.TabIndex = 39
        Me.TxtProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOperacion
        '
        Me.TxtOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOperacion.Location = New System.Drawing.Point(12, 55)
        Me.TxtOperacion.Name = "TxtOperacion"
        Me.TxtOperacion.Size = New System.Drawing.Size(214, 26)
        Me.TxtOperacion.TabIndex = 20
        Me.TxtOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonClean
        '
        Me.ButtonClean.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClean.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonClean.Location = New System.Drawing.Point(188, 212)
        Me.ButtonClean.Name = "ButtonClean"
        Me.ButtonClean.Size = New System.Drawing.Size(38, 26)
        Me.ButtonClean.TabIndex = 37
        Me.ButtonClean.Text = "CE"
        Me.ButtonClean.UseVisualStyleBackColor = False
        '
        'ButtonDivision
        '
        Me.ButtonDivision.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivision.Location = New System.Drawing.Point(188, 244)
        Me.ButtonDivision.Name = "ButtonDivision"
        Me.ButtonDivision.Size = New System.Drawing.Size(38, 26)
        Me.ButtonDivision.TabIndex = 35
        Me.ButtonDivision.Text = "/"
        Me.ButtonDivision.UseVisualStyleBackColor = False
        '
        'ButtonMultiplicacion
        '
        Me.ButtonMultiplicacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiplicacion.Location = New System.Drawing.Point(144, 243)
        Me.ButtonMultiplicacion.Name = "ButtonMultiplicacion"
        Me.ButtonMultiplicacion.Size = New System.Drawing.Size(38, 26)
        Me.ButtonMultiplicacion.TabIndex = 34
        Me.ButtonMultiplicacion.Text = "x"
        Me.ButtonMultiplicacion.UseVisualStyleBackColor = False
        '
        'ButtonResta
        '
        Me.ButtonResta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResta.Location = New System.Drawing.Point(188, 276)
        Me.ButtonResta.Name = "ButtonResta"
        Me.ButtonResta.Size = New System.Drawing.Size(38, 26)
        Me.ButtonResta.TabIndex = 33
        Me.ButtonResta.Text = "-"
        Me.ButtonResta.UseVisualStyleBackColor = False
        '
        'ButtonSuma
        '
        Me.ButtonSuma.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuma.Location = New System.Drawing.Point(144, 276)
        Me.ButtonSuma.Name = "ButtonSuma"
        Me.ButtonSuma.Size = New System.Drawing.Size(38, 26)
        Me.ButtonSuma.TabIndex = 32
        Me.ButtonSuma.Text = "+"
        Me.ButtonSuma.UseVisualStyleBackColor = False
        '
        'ButtonIgual
        '
        Me.ButtonIgual.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonIgual.Enabled = False
        Me.ButtonIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIgual.Location = New System.Drawing.Point(144, 308)
        Me.ButtonIgual.Name = "ButtonIgual"
        Me.ButtonIgual.Size = New System.Drawing.Size(82, 26)
        Me.ButtonIgual.TabIndex = 36
        Me.ButtonIgual.Text = "="
        Me.ButtonIgual.UseVisualStyleBackColor = False
        '
        'ButtonPunto
        '
        Me.ButtonPunto.BackColor = System.Drawing.SystemColors.Info
        Me.ButtonPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPunto.Location = New System.Drawing.Point(100, 308)
        Me.ButtonPunto.Name = "ButtonPunto"
        Me.ButtonPunto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonPunto.Size = New System.Drawing.Size(38, 26)
        Me.ButtonPunto.TabIndex = 31
        Me.ButtonPunto.Text = "."
        Me.ButtonPunto.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.SystemColors.Info
        Me.Button0.Location = New System.Drawing.Point(56, 308)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(38, 26)
        Me.Button0.TabIndex = 21
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Info
        Me.Button9.Location = New System.Drawing.Point(100, 212)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(38, 26)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Info
        Me.Button8.Location = New System.Drawing.Point(56, 212)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 26)
        Me.Button8.TabIndex = 29
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Info
        Me.Button7.Location = New System.Drawing.Point(12, 212)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 26)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Info
        Me.Button6.Location = New System.Drawing.Point(100, 244)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 26)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.Location = New System.Drawing.Point(56, 244)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 26)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.Location = New System.Drawing.Point(12, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 26)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.Location = New System.Drawing.Point(100, 276)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 26)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Location = New System.Drawing.Point(56, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 26)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(12, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 26)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(239, 24)
        Me.MenuStrip1.TabIndex = 38
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
        Me.BasicoToolStripMenuItem.Name = "BasicoToolStripMenuItem"
        Me.BasicoToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BasicoToolStripMenuItem.Text = "Basico"
        '
        'CientificaToolStripMenuItem
        '
        Me.CientificaToolStripMenuItem.Enabled = False
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
        'ButtonDel
        '
        Me.ButtonDel.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonDel.Location = New System.Drawing.Point(144, 212)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(38, 26)
        Me.ButtonDel.TabIndex = 40
        Me.ButtonDel.Text = "DE"
        Me.ButtonDel.UseVisualStyleBackColor = False
        '
        'ButtonMasMenos
        '
        Me.ButtonMasMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMasMenos.Location = New System.Drawing.Point(188, 138)
        Me.ButtonMasMenos.Name = "ButtonMasMenos"
        Me.ButtonMasMenos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonMasMenos.Size = New System.Drawing.Size(38, 26)
        Me.ButtonMasMenos.TabIndex = 41
        Me.ButtonMasMenos.Text = "±"
        Me.ButtonMasMenos.UseVisualStyleBackColor = True
        '
        'ButtonSen
        '
        Me.ButtonSen.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSen.Location = New System.Drawing.Point(12, 139)
        Me.ButtonSen.Name = "ButtonSen"
        Me.ButtonSen.Size = New System.Drawing.Size(38, 26)
        Me.ButtonSen.TabIndex = 42
        Me.ButtonSen.Text = "Sen"
        Me.ButtonSen.UseVisualStyleBackColor = False
        '
        'ButtonCos
        '
        Me.ButtonCos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCos.Location = New System.Drawing.Point(56, 139)
        Me.ButtonCos.Name = "ButtonCos"
        Me.ButtonCos.Size = New System.Drawing.Size(38, 26)
        Me.ButtonCos.TabIndex = 43
        Me.ButtonCos.Text = "Cos"
        Me.ButtonCos.UseVisualStyleBackColor = False
        '
        'ButtonTan
        '
        Me.ButtonTan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonTan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTan.Location = New System.Drawing.Point(100, 139)
        Me.ButtonTan.Name = "ButtonTan"
        Me.ButtonTan.Size = New System.Drawing.Size(38, 26)
        Me.ButtonTan.TabIndex = 44
        Me.ButtonTan.Text = "Tan"
        Me.ButtonTan.UseVisualStyleBackColor = False
        '
        'ButtonReciproco
        '
        Me.ButtonReciproco.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonReciproco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReciproco.Location = New System.Drawing.Point(144, 171)
        Me.ButtonReciproco.Name = "ButtonReciproco"
        Me.ButtonReciproco.Size = New System.Drawing.Size(38, 26)
        Me.ButtonReciproco.TabIndex = 45
        Me.ButtonReciproco.Text = "1⁄x"
        Me.ButtonReciproco.UseVisualStyleBackColor = False
        '
        'ButtonXCuadrado
        '
        Me.ButtonXCuadrado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonXCuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonXCuadrado.Location = New System.Drawing.Point(100, 171)
        Me.ButtonXCuadrado.Name = "ButtonXCuadrado"
        Me.ButtonXCuadrado.Size = New System.Drawing.Size(38, 26)
        Me.ButtonXCuadrado.TabIndex = 46
        Me.ButtonXCuadrado.Text = "x²"
        Me.ButtonXCuadrado.UseVisualStyleBackColor = False
        '
        'ButtonRaiz
        '
        Me.ButtonRaiz.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRaiz.Location = New System.Drawing.Point(56, 171)
        Me.ButtonRaiz.Name = "ButtonRaiz"
        Me.ButtonRaiz.Size = New System.Drawing.Size(38, 26)
        Me.ButtonRaiz.TabIndex = 47
        Me.ButtonRaiz.Text = "√"
        Me.ButtonRaiz.UseVisualStyleBackColor = False
        '
        'ButtonPorcentaje
        '
        Me.ButtonPorcentaje.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPorcentaje.Location = New System.Drawing.Point(12, 171)
        Me.ButtonPorcentaje.Name = "ButtonPorcentaje"
        Me.ButtonPorcentaje.Size = New System.Drawing.Size(38, 26)
        Me.ButtonPorcentaje.TabIndex = 48
        Me.ButtonPorcentaje.Text = "%"
        Me.ButtonPorcentaje.UseVisualStyleBackColor = False
        '
        'ButtonLog
        '
        Me.ButtonLog.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLog.Location = New System.Drawing.Point(144, 139)
        Me.ButtonLog.Name = "ButtonLog"
        Me.ButtonLog.Size = New System.Drawing.Size(38, 26)
        Me.ButtonLog.TabIndex = 49
        Me.ButtonLog.Text = "Log"
        Me.ButtonLog.UseVisualStyleBackColor = False
        '
        'ButtonPI
        '
        Me.ButtonPI.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPI.Location = New System.Drawing.Point(12, 308)
        Me.ButtonPI.Name = "ButtonPI"
        Me.ButtonPI.Size = New System.Drawing.Size(38, 26)
        Me.ButtonPI.TabIndex = 50
        Me.ButtonPI.Text = "𝜋"
        Me.ButtonPI.UseVisualStyleBackColor = False
        '
        'ButtonPotencia
        '
        Me.ButtonPotencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonPotencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPotencia.Location = New System.Drawing.Point(188, 172)
        Me.ButtonPotencia.Name = "ButtonPotencia"
        Me.ButtonPotencia.Size = New System.Drawing.Size(38, 26)
        Me.ButtonPotencia.TabIndex = 51
        Me.ButtonPotencia.Text = "^"
        Me.ButtonPotencia.UseVisualStyleBackColor = False
        '
        'ButtonMS
        '
        Me.ButtonMS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMS.Location = New System.Drawing.Point(17, 97)
        Me.ButtonMS.Name = "ButtonMS"
        Me.ButtonMS.Size = New System.Drawing.Size(66, 26)
        Me.ButtonMS.TabIndex = 52
        Me.ButtonMS.Text = "MemSave"
        Me.ButtonMS.UseVisualStyleBackColor = False
        '
        'ButtonMC
        '
        Me.ButtonMC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMC.Location = New System.Drawing.Point(155, 97)
        Me.ButtonMC.Name = "ButtonMC"
        Me.ButtonMC.Size = New System.Drawing.Size(66, 26)
        Me.ButtonMC.TabIndex = 53
        Me.ButtonMC.Text = "MemClean"
        Me.ButtonMC.UseVisualStyleBackColor = False
        '
        'ButtonMR
        '
        Me.ButtonMR.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonMR.Enabled = False
        Me.ButtonMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMR.Location = New System.Drawing.Point(86, 97)
        Me.ButtonMR.Name = "ButtonMR"
        Me.ButtonMR.Size = New System.Drawing.Size(66, 26)
        Me.ButtonMR.TabIndex = 54
        Me.ButtonMR.Text = "MemRestore"
        Me.ButtonMR.UseVisualStyleBackColor = False
        '
        'Calculadora2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonMR)
        Me.Controls.Add(Me.ButtonMC)
        Me.Controls.Add(Me.ButtonMS)
        Me.Controls.Add(Me.ButtonPotencia)
        Me.Controls.Add(Me.ButtonPI)
        Me.Controls.Add(Me.ButtonLog)
        Me.Controls.Add(Me.ButtonPorcentaje)
        Me.Controls.Add(Me.ButtonRaiz)
        Me.Controls.Add(Me.ButtonXCuadrado)
        Me.Controls.Add(Me.ButtonReciproco)
        Me.Controls.Add(Me.ButtonTan)
        Me.Controls.Add(Me.ButtonCos)
        Me.Controls.Add(Me.ButtonSen)
        Me.Controls.Add(Me.ButtonMasMenos)
        Me.Controls.Add(Me.ButtonDel)
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
        Me.Name = "Calculadora2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Cientifica"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtProceso As TextBox
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CientificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonMasMenos As Button
    Friend WithEvents ButtonSen As Button
    Friend WithEvents ButtonCos As Button
    Friend WithEvents ButtonTan As Button
    Friend WithEvents ButtonReciproco As Button
    Friend WithEvents ButtonXCuadrado As Button
    Friend WithEvents ButtonRaiz As Button
    Friend WithEvents ButtonPorcentaje As Button
    Friend WithEvents ButtonLog As Button
    Friend WithEvents ButtonPI As Button
    Friend WithEvents ButtonPotencia As Button
    Friend WithEvents ButtonMS As Button
    Friend WithEvents ButtonMC As Button
    Friend WithEvents ButtonMR As Button
End Class
