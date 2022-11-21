<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.menu = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.box_usuario = New System.Windows.Forms.TextBox()
        Me.txt_decorador_usuario = New System.Windows.Forms.Label()
        Me.txt_nombre_usuario = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.Label()
        Me.box_email = New System.Windows.Forms.TextBox()
        Me.btn_iniciar_sesion = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_registrarse = New System.Windows.Forms.Button()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.Label()
        Me.txt_decorador_email = New System.Windows.Forms.Label()
        Me.box_clave = New System.Windows.Forms.TextBox()
        Me.txt_decorador_clave = New System.Windows.Forms.Label()
        Me.txt_error_login = New System.Windows.Forms.Label()
        Me.opc_mail = New System.Windows.Forms.ComboBox()
        Me.txt_com = New System.Windows.Forms.Label()
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
        Me.menu.Controls.Add(Me.titulo)
        Me.menu.Controls.Add(Me.btn_cerrar)
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
        Me.btn_minimizar.TabIndex = 25
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
        Me.titulo.Size = New System.Drawing.Size(166, 25)
        Me.titulo.TabIndex = 2
        Me.titulo.Text = "ReMe -> Loguearse"
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
        Me.btn_cerrar.TabIndex = 24
        Me.btn_cerrar.TabStop = False
        '
        'box_usuario
        '
        Me.box_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.box_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.box_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_usuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_usuario.ForeColor = System.Drawing.Color.White
        Me.box_usuario.Location = New System.Drawing.Point(239, 162)
        Me.box_usuario.MaxLength = 15
        Me.box_usuario.Name = "box_usuario"
        Me.box_usuario.Size = New System.Drawing.Size(226, 20)
        Me.box_usuario.TabIndex = 1
        Me.box_usuario.TabStop = False
        Me.box_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_decorador_usuario
        '
        Me.txt_decorador_usuario.AutoSize = True
        Me.txt_decorador_usuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_decorador_usuario.Location = New System.Drawing.Point(239, 168)
        Me.txt_decorador_usuario.Name = "txt_decorador_usuario"
        Me.txt_decorador_usuario.Size = New System.Drawing.Size(231, 20)
        Me.txt_decorador_usuario.TabIndex = 9
        Me.txt_decorador_usuario.Text = "_____________________________________"
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.AutoSize = True
        Me.txt_nombre_usuario.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(266, 124)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(175, 25)
        Me.txt_nombre_usuario.TabIndex = 10
        Me.txt_nombre_usuario.Text = "Nombre de usuario"
        '
        'txt_clave
        '
        Me.txt_clave.AutoSize = True
        Me.txt_clave.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_clave.Location = New System.Drawing.Point(299, 214)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(108, 25)
        Me.txt_clave.TabIndex = 13
        Me.txt_clave.Text = "Contraseña"
        '
        'box_email
        '
        Me.box_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.box_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.box_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_email.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_email.ForeColor = System.Drawing.Color.White
        Me.box_email.Location = New System.Drawing.Point(177, 305)
        Me.box_email.MaxLength = 24
        Me.box_email.Name = "box_email"
        Me.box_email.Size = New System.Drawing.Size(187, 20)
        Me.box_email.TabIndex = 3
        Me.box_email.TabStop = False
        Me.box_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.box_email.Visible = False
        '
        'btn_iniciar_sesion
        '
        Me.btn_iniciar_sesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_iniciar_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_iniciar_sesion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_iniciar_sesion.FlatAppearance.BorderSize = 2
        Me.btn_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_iniciar_sesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_iniciar_sesion.ForeColor = System.Drawing.Color.White
        Me.btn_iniciar_sesion.Location = New System.Drawing.Point(218, 314)
        Me.btn_iniciar_sesion.Name = "btn_iniciar_sesion"
        Me.btn_iniciar_sesion.Size = New System.Drawing.Size(128, 44)
        Me.btn_iniciar_sesion.TabIndex = 14
        Me.btn_iniciar_sesion.TabStop = False
        Me.btn_iniciar_sesion.Text = "Iniciar Sesión"
        Me.btn_iniciar_sesion.UseVisualStyleBackColor = False
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_registrar.FlatAppearance.BorderSize = 2
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Location = New System.Drawing.Point(367, 314)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(128, 44)
        Me.btn_registrar.TabIndex = 15
        Me.btn_registrar.TabStop = False
        Me.btn_registrar.Text = "Registrarse"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 447)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Dracula Theme"
        '
        'btn_registrarse
        '
        Me.btn_registrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btn_registrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_registrarse.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_registrarse.FlatAppearance.BorderSize = 2
        Me.btn_registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrarse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_registrarse.ForeColor = System.Drawing.Color.White
        Me.btn_registrarse.Location = New System.Drawing.Point(218, 370)
        Me.btn_registrarse.Name = "btn_registrarse"
        Me.btn_registrarse.Size = New System.Drawing.Size(128, 44)
        Me.btn_registrarse.TabIndex = 17
        Me.btn_registrarse.TabStop = False
        Me.btn_registrarse.Text = "Registrarse"
        Me.btn_registrarse.UseVisualStyleBackColor = False
        Me.btn_registrarse.Visible = False
        '
        'btn_atras
        '
        Me.btn_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_atras.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_atras.FlatAppearance.BorderSize = 2
        Me.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_atras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_atras.ForeColor = System.Drawing.Color.White
        Me.btn_atras.Location = New System.Drawing.Point(367, 370)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(128, 44)
        Me.btn_atras.TabIndex = 18
        Me.btn_atras.TabStop = False
        Me.btn_atras.Text = "Atras"
        Me.btn_atras.UseVisualStyleBackColor = False
        Me.btn_atras.Visible = False
        '
        'txt_email
        '
        Me.txt_email.AutoSize = True
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_email.Location = New System.Drawing.Point(325, 277)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(58, 25)
        Me.txt_email.TabIndex = 21
        Me.txt_email.Text = "Email"
        Me.txt_email.Visible = False
        '
        'txt_decorador_email
        '
        Me.txt_decorador_email.AutoSize = True
        Me.txt_decorador_email.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_decorador_email.Location = New System.Drawing.Point(173, 311)
        Me.txt_decorador_email.Name = "txt_decorador_email"
        Me.txt_decorador_email.Size = New System.Drawing.Size(195, 20)
        Me.txt_decorador_email.TabIndex = 20
        Me.txt_decorador_email.Text = "_______________________________"
        Me.txt_decorador_email.Visible = False
        '
        'box_clave
        '
        Me.box_clave.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.box_clave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.box_clave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.box_clave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_clave.ForeColor = System.Drawing.Color.White
        Me.box_clave.Location = New System.Drawing.Point(239, 242)
        Me.box_clave.MaxLength = 12
        Me.box_clave.Name = "box_clave"
        Me.box_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.box_clave.Size = New System.Drawing.Size(226, 20)
        Me.box_clave.TabIndex = 2
        Me.box_clave.TabStop = False
        Me.box_clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_decorador_clave
        '
        Me.txt_decorador_clave.AutoSize = True
        Me.txt_decorador_clave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_decorador_clave.Location = New System.Drawing.Point(239, 248)
        Me.txt_decorador_clave.Name = "txt_decorador_clave"
        Me.txt_decorador_clave.Size = New System.Drawing.Size(231, 20)
        Me.txt_decorador_clave.TabIndex = 23
        Me.txt_decorador_clave.Text = "_____________________________________"
        '
        'txt_error_login
        '
        Me.txt_error_login.AutoSize = True
        Me.txt_error_login.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_error_login.Location = New System.Drawing.Point(293, 337)
        Me.txt_error_login.Name = "txt_error_login"
        Me.txt_error_login.Size = New System.Drawing.Size(156, 19)
        Me.txt_error_login.TabIndex = 24
        Me.txt_error_login.Text = "* Esto no deberia verse.."
        Me.txt_error_login.Visible = False
        '
        'opc_mail
        '
        Me.opc_mail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.opc_mail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.opc_mail.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.opc_mail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.opc_mail.ForeColor = System.Drawing.Color.White
        Me.opc_mail.FormattingEnabled = True
        Me.opc_mail.Items.AddRange(New Object() {"gmail", "hotmail", "yahoo"})
        Me.opc_mail.Location = New System.Drawing.Point(370, 305)
        Me.opc_mail.Name = "opc_mail"
        Me.opc_mail.Size = New System.Drawing.Size(121, 25)
        Me.opc_mail.TabIndex = 25
        Me.opc_mail.TabStop = False
        Me.opc_mail.Text = "gmail"
        Me.opc_mail.Visible = False
        '
        'txt_com
        '
        Me.txt_com.AutoSize = True
        Me.txt_com.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_com.Location = New System.Drawing.Point(494, 307)
        Me.txt_com.Name = "txt_com"
        Me.txt_com.Size = New System.Drawing.Size(43, 21)
        Me.txt_com.TabIndex = 26
        Me.txt_com.Text = ".com"
        Me.txt_com.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 471)
        Me.Controls.Add(Me.txt_com)
        Me.Controls.Add(Me.opc_mail)
        Me.Controls.Add(Me.txt_error_login)
        Me.Controls.Add(Me.box_clave)
        Me.Controls.Add(Me.txt_decorador_clave)
        Me.Controls.Add(Me.box_email)
        Me.Controls.Add(Me.box_usuario)
        Me.Controls.Add(Me.btn_atras)
        Me.Controls.Add(Me.btn_registrarse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Controls.Add(Me.txt_decorador_usuario)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.btn_iniciar_sesion)
        Me.Controls.Add(Me.txt_decorador_email)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
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
    Friend WithEvents titulo As Label
    Friend WithEvents box_usuario As TextBox
    Friend WithEvents txt_decorador_usuario As Label
    Friend WithEvents txt_nombre_usuario As Label
    Friend WithEvents txt_clave As Label
    Friend WithEvents box_email As TextBox
    Friend WithEvents btn_iniciar_sesion As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_registrarse As Button
    Friend WithEvents btn_atras As Button
    Friend WithEvents txt_email As Label
    Friend WithEvents txt_decorador_email As Label
    Friend WithEvents box_clave As TextBox
    Friend WithEvents txt_decorador_clave As Label
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents txt_error_login As Label
    Friend WithEvents opc_mail As ComboBox
    Friend WithEvents txt_com As Label
End Class
