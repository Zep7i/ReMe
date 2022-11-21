<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nueva_tarea = New System.Windows.Forms.Button()
        Me.Abrir_Importantes = New System.Windows.Forms.Button()
        Me.Abrir_Olvidadas = New System.Windows.Forms.Button()
        Me.Abrir_Aprobadas = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.Panel()
        Me.btn_ajustes = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Contenedor_secciones = New System.Windows.Forms.Panel()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_cerrar_sesion = New System.Windows.Forms.Button()
        Me.AbrirTareas = New System.Windows.Forms.Button()
        Me.Contenedor_tareas = New System.Windows.Forms.Panel()
        Me.eliminar_tareas = New System.Windows.Forms.Button()
        Me.Notif_Globales_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Notif_Importantes_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Vencimiento_Olvidadas_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Vencimiento_Globales_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Vencimiento_Importantes_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.menu.SuspendLayout()
        CType(Me.btn_ajustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor_secciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'nueva_tarea
        '
        Me.nueva_tarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.nueva_tarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nueva_tarea.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.nueva_tarea.FlatAppearance.BorderSize = 2
        Me.nueva_tarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nueva_tarea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nueva_tarea.ForeColor = System.Drawing.Color.White
        Me.nueva_tarea.Location = New System.Drawing.Point(302, 438)
        Me.nueva_tarea.Name = "nueva_tarea"
        Me.nueva_tarea.Size = New System.Drawing.Size(128, 44)
        Me.nueva_tarea.TabIndex = 0
        Me.nueva_tarea.TabStop = False
        Me.nueva_tarea.Text = "Nueva tarea"
        Me.nueva_tarea.UseCompatibleTextRendering = True
        Me.nueva_tarea.UseVisualStyleBackColor = False
        '
        'Abrir_Importantes
        '
        Me.Abrir_Importantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Abrir_Importantes.FlatAppearance.BorderSize = 0
        Me.Abrir_Importantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Abrir_Importantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Abrir_Importantes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Abrir_Importantes.ForeColor = System.Drawing.Color.White
        Me.Abrir_Importantes.Location = New System.Drawing.Point(4, 67)
        Me.Abrir_Importantes.Margin = New System.Windows.Forms.Padding(0)
        Me.Abrir_Importantes.Name = "Abrir_Importantes"
        Me.Abrir_Importantes.Size = New System.Drawing.Size(161, 60)
        Me.Abrir_Importantes.TabIndex = 1
        Me.Abrir_Importantes.TabStop = False
        Me.Abrir_Importantes.Text = "Importantes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Abrir_Importantes.UseVisualStyleBackColor = False
        '
        'Abrir_Olvidadas
        '
        Me.Abrir_Olvidadas.FlatAppearance.BorderSize = 0
        Me.Abrir_Olvidadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Abrir_Olvidadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Abrir_Olvidadas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Abrir_Olvidadas.ForeColor = System.Drawing.Color.White
        Me.Abrir_Olvidadas.Location = New System.Drawing.Point(4, 131)
        Me.Abrir_Olvidadas.Name = "Abrir_Olvidadas"
        Me.Abrir_Olvidadas.Size = New System.Drawing.Size(161, 57)
        Me.Abrir_Olvidadas.TabIndex = 2
        Me.Abrir_Olvidadas.TabStop = False
        Me.Abrir_Olvidadas.Text = "Olvidadas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Abrir_Olvidadas.UseVisualStyleBackColor = True
        '
        'Abrir_Aprobadas
        '
        Me.Abrir_Aprobadas.FlatAppearance.BorderSize = 0
        Me.Abrir_Aprobadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Abrir_Aprobadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Abrir_Aprobadas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Abrir_Aprobadas.ForeColor = System.Drawing.Color.White
        Me.Abrir_Aprobadas.Location = New System.Drawing.Point(4, 194)
        Me.Abrir_Aprobadas.Name = "Abrir_Aprobadas"
        Me.Abrir_Aprobadas.Size = New System.Drawing.Size(161, 57)
        Me.Abrir_Aprobadas.TabIndex = 3
        Me.Abrir_Aprobadas.TabStop = False
        Me.Abrir_Aprobadas.Text = "Aprobadas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Abrir_Aprobadas.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menu.Controls.Add(Me.btn_ajustes)
        Me.menu.Controls.Add(Me.btn_minimizar)
        Me.menu.Controls.Add(Me.btn_cerrar)
        Me.menu.Controls.Add(Me.Label16)
        Me.menu.Location = New System.Drawing.Point(0, -1)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(694, 32)
        Me.menu.TabIndex = 3
        '
        'btn_ajustes
        '
        Me.btn_ajustes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ajustes.Image = Global.ReMe.My.Resources.Resource1.boton_ajustes
        Me.btn_ajustes.Location = New System.Drawing.Point(568, 0)
        Me.btn_ajustes.Name = "btn_ajustes"
        Me.btn_ajustes.Size = New System.Drawing.Size(35, 30)
        Me.btn_ajustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_ajustes.TabIndex = 23
        Me.btn_ajustes.TabStop = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.Image = Global.ReMe.My.Resources.Resource1.minus_recurso
        Me.btn_minimizar.Location = New System.Drawing.Point(608, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(35, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 22
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
        Me.btn_cerrar.TabIndex = 21
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
        'Contenedor_secciones
        '
        Me.Contenedor_secciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Contenedor_secciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contenedor_secciones.Controls.Add(Me.txt_usuario)
        Me.Contenedor_secciones.Controls.Add(Me.btn_cerrar_sesion)
        Me.Contenedor_secciones.Controls.Add(Me.AbrirTareas)
        Me.Contenedor_secciones.Controls.Add(Me.Abrir_Aprobadas)
        Me.Contenedor_secciones.Controls.Add(Me.Abrir_Importantes)
        Me.Contenedor_secciones.Controls.Add(Me.Abrir_Olvidadas)
        Me.Contenedor_secciones.Location = New System.Drawing.Point(1, 31)
        Me.Contenedor_secciones.Name = "Contenedor_secciones"
        Me.Contenedor_secciones.Size = New System.Drawing.Size(172, 470)
        Me.Contenedor_secciones.TabIndex = 4
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.CausesValidation = False
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_usuario.ForeColor = System.Drawing.Color.White
        Me.txt_usuario.Location = New System.Drawing.Point(4, 402)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.ReadOnly = True
        Me.txt_usuario.ShortcutsEnabled = False
        Me.txt_usuario.Size = New System.Drawing.Size(161, 22)
        Me.txt_usuario.TabIndex = 10
        Me.txt_usuario.TabStop = False
        Me.txt_usuario.Text = "Pablo"
        Me.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_usuario.WordWrap = False
        '
        'btn_cerrar_sesion
        '
        Me.btn_cerrar_sesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_cerrar_sesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_cerrar_sesion.FlatAppearance.BorderSize = 2
        Me.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar_sesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cerrar_sesion.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar_sesion.Location = New System.Drawing.Point(0, 431)
        Me.btn_cerrar_sesion.Name = "btn_cerrar_sesion"
        Me.btn_cerrar_sesion.Size = New System.Drawing.Size(168, 36)
        Me.btn_cerrar_sesion.TabIndex = 9
        Me.btn_cerrar_sesion.TabStop = False
        Me.btn_cerrar_sesion.Text = "Cerrar Sesión"
        Me.btn_cerrar_sesion.UseVisualStyleBackColor = False
        '
        'AbrirTareas
        '
        Me.AbrirTareas.FlatAppearance.BorderSize = 0
        Me.AbrirTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.AbrirTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbrirTareas.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AbrirTareas.ForeColor = System.Drawing.Color.White
        Me.AbrirTareas.Location = New System.Drawing.Point(4, 5)
        Me.AbrirTareas.Name = "AbrirTareas"
        Me.AbrirTareas.Size = New System.Drawing.Size(161, 57)
        Me.AbrirTareas.TabIndex = 6
        Me.AbrirTareas.TabStop = False
        Me.AbrirTareas.Text = "Tareas"
        Me.AbrirTareas.UseVisualStyleBackColor = True
        '
        'Contenedor_tareas
        '
        Me.Contenedor_tareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Contenedor_tareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contenedor_tareas.Location = New System.Drawing.Point(172, 31)
        Me.Contenedor_tareas.Name = "Contenedor_tareas"
        Me.Contenedor_tareas.Size = New System.Drawing.Size(522, 391)
        Me.Contenedor_tareas.TabIndex = 5
        '
        'eliminar_tareas
        '
        Me.eliminar_tareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.eliminar_tareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.eliminar_tareas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.eliminar_tareas.FlatAppearance.BorderSize = 2
        Me.eliminar_tareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_tareas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.eliminar_tareas.ForeColor = System.Drawing.Color.White
        Me.eliminar_tareas.Location = New System.Drawing.Point(452, 438)
        Me.eliminar_tareas.Name = "eliminar_tareas"
        Me.eliminar_tareas.Size = New System.Drawing.Size(128, 44)
        Me.eliminar_tareas.TabIndex = 6
        Me.eliminar_tareas.TabStop = False
        Me.eliminar_tareas.Text = "Eliminar tareas"
        Me.eliminar_tareas.UseVisualStyleBackColor = False
        '
        'Notif_Globales_Timer
        '
        Me.Notif_Globales_Timer.Interval = 19000
        '
        'Notif_Importantes_Timer
        '
        Me.Notif_Importantes_Timer.Interval = 17000
        '
        'Vencimiento_Olvidadas_Timer
        '
        Me.Vencimiento_Olvidadas_Timer.Interval = 12000
        '
        'Vencimiento_Globales_Timer
        '
        Me.Vencimiento_Globales_Timer.Interval = 18000
        '
        'Vencimiento_Importantes_Timer
        '
        Me.Vencimiento_Importantes_Timer.Interval = 16000
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 500)
        Me.Controls.Add(Me.eliminar_tareas)
        Me.Controls.Add(Me.Contenedor_tareas)
        Me.Controls.Add(Me.Contenedor_secciones)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.nueva_tarea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReMe - Inicio"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        CType(Me.btn_ajustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor_secciones.ResumeLayout(False)
        Me.Contenedor_secciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nueva_tarea As Button
    Friend WithEvents menu As Panel
    Friend WithEvents Abrir_Importantes As Button
    Friend WithEvents Abrir_Olvidadas As Button
    Friend WithEvents Abrir_Aprobadas As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Contenedor_secciones As Panel
    Friend WithEvents AbrirTareas As Button
    Friend WithEvents Contenedor_tareas As Panel
    Friend WithEvents eliminar_tareas As Button
    Friend WithEvents btn_cerrar_sesion As Button
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_ajustes As PictureBox
    Public WithEvents Notif_Globales_Timer As Timer
    Friend WithEvents Notif_Importantes_Timer As Timer
    Public WithEvents Vencimiento_Olvidadas_Timer As Timer
    Friend WithEvents Vencimiento_Globales_Timer As Timer
    Friend WithEvents Vencimiento_Importantes_Timer As Timer
    Friend WithEvents txt_usuario As TextBox
End Class
