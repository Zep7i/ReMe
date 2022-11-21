<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AjustesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjustesForm))
        Me.menu = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.Label()
        Me.box_usuario_nuevo = New System.Windows.Forms.TextBox()
        Me.decorador1 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.Label()
        Me.box_contraseña = New System.Windows.Forms.TextBox()
        Me.decorador2 = New System.Windows.Forms.Label()
        Me.Contenedor_secciones = New System.Windows.Forms.Panel()
        Me.btn_regresar_ajustes = New System.Windows.Forms.Button()
        Me.btn_cambiar_contraseña = New System.Windows.Forms.Button()
        Me.btn_cambiar_usuario = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_error_ajustes = New System.Windows.Forms.Label()
        Me.menu.SuspendLayout()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor_secciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menu.Controls.Add(Me.btn_minimizar)
        Me.menu.Controls.Add(Me.titulo)
        Me.menu.Controls.Add(Me.btn_cerrar)
        Me.menu.Location = New System.Drawing.Point(0, -1)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(687, 32)
        Me.menu.TabIndex = 5
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.Image = Global.ReMe.My.Resources.Resource1.minus_recurso
        Me.btn_minimizar.Location = New System.Drawing.Point(608, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(35, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 24
        Me.btn_minimizar.TabStop = False
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titulo.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titulo.ForeColor = System.Drawing.Color.White
        Me.titulo.Location = New System.Drawing.Point(0, 0)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(142, 25)
        Me.titulo.TabIndex = 2
        Me.titulo.Text = "ReMe -> Ajustes"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Image = Global.ReMe.My.Resources.Resource1.cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(648, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(35, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 23
        Me.btn_cerrar.TabStop = False
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.AutoSize = True
        Me.txt_nombre_usuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(336, 152)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(192, 21)
        Me.txt_nombre_usuario.TabIndex = 11
        Me.txt_nombre_usuario.Text = "Nuevo nombre de usuario"
        '
        'box_usuario_nuevo
        '
        Me.box_usuario_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.box_usuario_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.box_usuario_nuevo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_usuario_nuevo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_usuario_nuevo.ForeColor = System.Drawing.Color.White
        Me.box_usuario_nuevo.Location = New System.Drawing.Point(316, 176)
        Me.box_usuario_nuevo.MaxLength = 20
        Me.box_usuario_nuevo.Name = "box_usuario_nuevo"
        Me.box_usuario_nuevo.Size = New System.Drawing.Size(226, 20)
        Me.box_usuario_nuevo.TabIndex = 1
        Me.box_usuario_nuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'decorador1
        '
        Me.decorador1.AutoSize = True
        Me.decorador1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.decorador1.Location = New System.Drawing.Point(316, 182)
        Me.decorador1.Name = "decorador1"
        Me.decorador1.Size = New System.Drawing.Size(231, 20)
        Me.decorador1.TabIndex = 13
        Me.decorador1.Text = "_____________________________________"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.AutoSize = True
        Me.txt_contraseña.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_contraseña.Location = New System.Drawing.Point(375, 221)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(108, 25)
        Me.txt_contraseña.TabIndex = 14
        Me.txt_contraseña.Text = "Contraseña"
        '
        'box_contraseña
        '
        Me.box_contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.box_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.box_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_contraseña.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_contraseña.ForeColor = System.Drawing.Color.White
        Me.box_contraseña.Location = New System.Drawing.Point(316, 251)
        Me.box_contraseña.MaxLength = 12
        Me.box_contraseña.Name = "box_contraseña"
        Me.box_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.box_contraseña.Size = New System.Drawing.Size(226, 20)
        Me.box_contraseña.TabIndex = 2
        Me.box_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'decorador2
        '
        Me.decorador2.AutoSize = True
        Me.decorador2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.decorador2.Location = New System.Drawing.Point(316, 257)
        Me.decorador2.Name = "decorador2"
        Me.decorador2.Size = New System.Drawing.Size(231, 20)
        Me.decorador2.TabIndex = 16
        Me.decorador2.Text = "_____________________________________"
        '
        'Contenedor_secciones
        '
        Me.Contenedor_secciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Contenedor_secciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contenedor_secciones.Controls.Add(Me.btn_regresar_ajustes)
        Me.Contenedor_secciones.Controls.Add(Me.btn_cambiar_contraseña)
        Me.Contenedor_secciones.Controls.Add(Me.btn_cambiar_usuario)
        Me.Contenedor_secciones.Location = New System.Drawing.Point(1, 28)
        Me.Contenedor_secciones.Name = "Contenedor_secciones"
        Me.Contenedor_secciones.Size = New System.Drawing.Size(172, 449)
        Me.Contenedor_secciones.TabIndex = 17
        '
        'btn_regresar_ajustes
        '
        Me.btn_regresar_ajustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_regresar_ajustes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_regresar_ajustes.FlatAppearance.BorderSize = 2
        Me.btn_regresar_ajustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_regresar_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_regresar_ajustes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_regresar_ajustes.ForeColor = System.Drawing.Color.White
        Me.btn_regresar_ajustes.Location = New System.Drawing.Point(1, 390)
        Me.btn_regresar_ajustes.Name = "btn_regresar_ajustes"
        Me.btn_regresar_ajustes.Size = New System.Drawing.Size(165, 49)
        Me.btn_regresar_ajustes.TabIndex = 8
        Me.btn_regresar_ajustes.TabStop = False
        Me.btn_regresar_ajustes.Text = "<- Regresar"
        Me.btn_regresar_ajustes.UseVisualStyleBackColor = False
        '
        'btn_cambiar_contraseña
        '
        Me.btn_cambiar_contraseña.FlatAppearance.BorderSize = 0
        Me.btn_cambiar_contraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_cambiar_contraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambiar_contraseña.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cambiar_contraseña.ForeColor = System.Drawing.Color.White
        Me.btn_cambiar_contraseña.Location = New System.Drawing.Point(4, 70)
        Me.btn_cambiar_contraseña.Name = "btn_cambiar_contraseña"
        Me.btn_cambiar_contraseña.Size = New System.Drawing.Size(161, 57)
        Me.btn_cambiar_contraseña.TabIndex = 7
        Me.btn_cambiar_contraseña.TabStop = False
        Me.btn_cambiar_contraseña.Text = "Cambiar contraseña"
        Me.btn_cambiar_contraseña.UseVisualStyleBackColor = True
        '
        'btn_cambiar_usuario
        '
        Me.btn_cambiar_usuario.FlatAppearance.BorderSize = 0
        Me.btn_cambiar_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_cambiar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambiar_usuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cambiar_usuario.ForeColor = System.Drawing.Color.White
        Me.btn_cambiar_usuario.Location = New System.Drawing.Point(4, 7)
        Me.btn_cambiar_usuario.Name = "btn_cambiar_usuario"
        Me.btn_cambiar_usuario.Size = New System.Drawing.Size(161, 57)
        Me.btn_cambiar_usuario.TabIndex = 6
        Me.btn_cambiar_usuario.TabStop = False
        Me.btn_cambiar_usuario.Text = "Cambiar nombre de usuario"
        Me.btn_cambiar_usuario.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_confirmar.FlatAppearance.BorderSize = 2
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.Location = New System.Drawing.Point(364, 318)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(128, 44)
        Me.btn_confirmar.TabIndex = 20
        Me.btn_confirmar.TabStop = False
        Me.btn_confirmar.Text = "Confirmar!"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'txt_error_ajustes
        '
        Me.txt_error_ajustes.AutoSize = True
        Me.txt_error_ajustes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_error_ajustes.Location = New System.Drawing.Point(328, 289)
        Me.txt_error_ajustes.Name = "txt_error_ajustes"
        Me.txt_error_ajustes.Size = New System.Drawing.Size(156, 19)
        Me.txt_error_ajustes.TabIndex = 21
        Me.txt_error_ajustes.Text = "* Esto no deberia verse.."
        Me.txt_error_ajustes.Visible = False
        '
        'AjustesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 471)
        Me.Controls.Add(Me.txt_error_ajustes)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.box_contraseña)
        Me.Controls.Add(Me.decorador2)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.box_usuario_nuevo)
        Me.Controls.Add(Me.decorador1)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.Contenedor_secciones)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AjustesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AjustesForm"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor_secciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu As Panel
    Friend WithEvents titulo As Label
    Friend WithEvents txt_nombre_usuario As Label
    Friend WithEvents box_usuario_nuevo As TextBox
    Friend WithEvents decorador1 As Label
    Friend WithEvents txt_contraseña As Label
    Friend WithEvents box_contraseña As TextBox
    Friend WithEvents decorador2 As Label
    Friend WithEvents Contenedor_secciones As Panel
    Friend WithEvents btn_cambiar_usuario As Button
    Friend WithEvents btn_cambiar_contraseña As Button
    Friend WithEvents btn_regresar_ajustes As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents txt_error_ajustes As Label
End Class
