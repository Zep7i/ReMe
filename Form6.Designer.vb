<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.menu = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_nombre_tarea = New System.Windows.Forms.Label()
        Me.box_nombre_tarea = New System.Windows.Forms.TextBox()
        Me.txt_decorador = New System.Windows.Forms.Label()
        Me.date_finalizacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha = New System.Windows.Forms.Label()
        Me.nueva_tarea = New System.Windows.Forms.Button()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.opc_categoria_adc = New System.Windows.Forms.ComboBox()
        Me.txt_categoria = New System.Windows.Forms.Label()
        Me.txt_plazo = New System.Windows.Forms.Label()
        Me.opc_plazo_fecha = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menu.SuspendLayout()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menu.Controls.Add(Me.btn_minimizar)
        Me.menu.Controls.Add(Me.btn_cerrar)
        Me.menu.Controls.Add(Me.Label16)
        Me.menu.Location = New System.Drawing.Point(0, -1)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(687, 32)
        Me.menu.TabIndex = 4
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.Image = Global.ReMe.My.Resources.Resource1.minus_recurso
        Me.btn_minimizar.Location = New System.Drawing.Point(608, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(35, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 20
        Me.btn_minimizar.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Image = Global.ReMe.My.Resources.Resource1.cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(648, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(35, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 19
        Me.btn_cerrar.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 25)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "ReMe"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nombre_tarea
        '
        Me.txt_nombre_tarea.AutoSize = True
        Me.txt_nombre_tarea.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nombre_tarea.Location = New System.Drawing.Point(258, 134)
        Me.txt_nombre_tarea.Name = "txt_nombre_tarea"
        Me.txt_nombre_tarea.Size = New System.Drawing.Size(175, 25)
        Me.txt_nombre_tarea.TabIndex = 5
        Me.txt_nombre_tarea.Text = "Nombre de la tarea"
        '
        'box_nombre_tarea
        '
        Me.box_nombre_tarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.box_nombre_tarea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.box_nombre_tarea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_nombre_tarea.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_nombre_tarea.ForeColor = System.Drawing.Color.White
        Me.box_nombre_tarea.Location = New System.Drawing.Point(231, 165)
        Me.box_nombre_tarea.MaxLength = 20
        Me.box_nombre_tarea.Name = "box_nombre_tarea"
        Me.box_nombre_tarea.Size = New System.Drawing.Size(226, 20)
        Me.box_nombre_tarea.TabIndex = 6
        Me.box_nombre_tarea.TabStop = False
        Me.box_nombre_tarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_decorador
        '
        Me.txt_decorador.AutoSize = True
        Me.txt_decorador.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_decorador.Location = New System.Drawing.Point(231, 171)
        Me.txt_decorador.Name = "txt_decorador"
        Me.txt_decorador.Size = New System.Drawing.Size(231, 20)
        Me.txt_decorador.TabIndex = 7
        Me.txt_decorador.Text = "_____________________________________"
        '
        'date_finalizacion
        '
        Me.date_finalizacion.CalendarForeColor = System.Drawing.Color.White
        Me.date_finalizacion.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.date_finalizacion.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.date_finalizacion.CalendarTitleForeColor = System.Drawing.Color.White
        Me.date_finalizacion.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.date_finalizacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_finalizacion.CustomFormat = "yyyy-MM-dd"
        Me.date_finalizacion.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.date_finalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_finalizacion.Location = New System.Drawing.Point(235, 239)
        Me.date_finalizacion.MaxDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.date_finalizacion.MinDate = New Date(2022, 10, 19, 0, 0, 0, 0)
        Me.date_finalizacion.Name = "date_finalizacion"
        Me.date_finalizacion.Size = New System.Drawing.Size(216, 27)
        Me.date_finalizacion.TabIndex = 8
        Me.date_finalizacion.TabStop = False
        '
        'txt_fecha
        '
        Me.txt_fecha.AutoSize = True
        Me.txt_fecha.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_fecha.Location = New System.Drawing.Point(251, 206)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(189, 25)
        Me.txt_fecha.TabIndex = 9
        Me.txt_fecha.Text = "Fecha de finalización"
        '
        'nueva_tarea
        '
        Me.nueva_tarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.nueva_tarea.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.nueva_tarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nueva_tarea.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nueva_tarea.ForeColor = System.Drawing.Color.White
        Me.nueva_tarea.Location = New System.Drawing.Point(153, 382)
        Me.nueva_tarea.Name = "nueva_tarea"
        Me.nueva_tarea.Size = New System.Drawing.Size(180, 48)
        Me.nueva_tarea.TabIndex = 10
        Me.nueva_tarea.TabStop = False
        Me.nueva_tarea.Text = "Confirmar"
        Me.nueva_tarea.UseVisualStyleBackColor = False
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_regresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_regresar.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_regresar.ForeColor = System.Drawing.Color.White
        Me.btn_regresar.Location = New System.Drawing.Point(355, 382)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(180, 48)
        Me.btn_regresar.TabIndex = 11
        Me.btn_regresar.TabStop = False
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = False
        '
        'opc_categoria_adc
        '
        Me.opc_categoria_adc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.opc_categoria_adc.FormattingEnabled = True
        Me.opc_categoria_adc.Items.AddRange(New Object() {"Trabajo Practico", "Tarea Normal"})
        Me.opc_categoria_adc.Location = New System.Drawing.Point(181, 322)
        Me.opc_categoria_adc.Name = "opc_categoria_adc"
        Me.opc_categoria_adc.Size = New System.Drawing.Size(121, 23)
        Me.opc_categoria_adc.TabIndex = 14
        Me.opc_categoria_adc.TabStop = False
        Me.opc_categoria_adc.Text = "Categoria"
        '
        'txt_categoria
        '
        Me.txt_categoria.AutoSize = True
        Me.txt_categoria.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_categoria.Location = New System.Drawing.Point(160, 287)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.Size = New System.Drawing.Size(168, 25)
        Me.txt_categoria.TabIndex = 15
        Me.txt_categoria.Text = "Categoria de tarea"
        '
        'txt_plazo
        '
        Me.txt_plazo.AutoSize = True
        Me.txt_plazo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_plazo.Location = New System.Drawing.Point(371, 288)
        Me.txt_plazo.Name = "txt_plazo"
        Me.txt_plazo.Size = New System.Drawing.Size(157, 25)
        Me.txt_plazo.TabIndex = 16
        Me.txt_plazo.Text = "[ Plazo de fecha ]"
        '
        'opc_plazo_fecha
        '
        Me.opc_plazo_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.opc_plazo_fecha.FormattingEnabled = True
        Me.opc_plazo_fecha.Items.AddRange(New Object() {"1 Mes", "1/2 Año (6 Meses)", "1 Año"})
        Me.opc_plazo_fecha.Location = New System.Drawing.Point(388, 322)
        Me.opc_plazo_fecha.Name = "opc_plazo_fecha"
        Me.opc_plazo_fecha.Size = New System.Drawing.Size(121, 23)
        Me.opc_plazo_fecha.TabIndex = 17
        Me.opc_plazo_fecha.TabStop = False
        Me.opc_plazo_fecha.Text = "Plazo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(3, 448)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "[ ] = Opcional"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 471)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.opc_plazo_fecha)
        Me.Controls.Add(Me.txt_plazo)
        Me.Controls.Add(Me.txt_categoria)
        Me.Controls.Add(Me.opc_categoria_adc)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.nueva_tarea)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.date_finalizacion)
        Me.Controls.Add(Me.box_nombre_tarea)
        Me.Controls.Add(Me.txt_nombre_tarea)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.txt_decorador)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReMe"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_nombre_tarea As Label
    Friend WithEvents txt_decorador As Label
    Friend WithEvents date_finalizacion As DateTimePicker
    Friend WithEvents txt_fecha As Label
    Friend WithEvents nueva_tarea As Button
    Friend WithEvents btn_regresar As Button
    Friend WithEvents txt_categoria As Label
    Friend WithEvents txt_plazo As Label
    Friend WithEvents opc_plazo_fecha As ComboBox
    Friend WithEvents Label6 As Label
    Public WithEvents box_nombre_tarea As TextBox
    Public WithEvents opc_categoria_adc As ComboBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_minimizar As PictureBox
End Class
