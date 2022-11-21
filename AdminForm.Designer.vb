<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.menu = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.txt_registrados = New System.Windows.Forms.Label()
        Me.registrados = New System.Windows.Forms.Label()
        Me.contenedor_reportes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.menu.SuspendLayout()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contenedor_reportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menu.Controls.Add(Me.btn_minimizar)
        Me.menu.Controls.Add(Me.btn_cerrar)
        Me.menu.Controls.Add(Me.titulo)
        Me.menu.Location = New System.Drawing.Point(0, -1)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(710, 32)
        Me.menu.TabIndex = 5
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.Image = Global.ReMe.My.Resources.Resource1.minus_recurso
        Me.btn_minimizar.Location = New System.Drawing.Point(631, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(35, 30)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 24
        Me.btn_minimizar.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Image = Global.ReMe.My.Resources.Resource1.cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(671, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(35, 30)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 23
        Me.btn_cerrar.TabStop = False
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titulo.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titulo.ForeColor = System.Drawing.Color.White
        Me.titulo.Location = New System.Drawing.Point(0, 0)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(184, 25)
        Me.titulo.TabIndex = 2
        Me.titulo.Text = "ReMe -> Admin Panel"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_registrados
        '
        Me.txt_registrados.AutoSize = True
        Me.txt_registrados.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_registrados.Location = New System.Drawing.Point(257, 62)
        Me.txt_registrados.Name = "txt_registrados"
        Me.txt_registrados.Size = New System.Drawing.Size(194, 28)
        Me.txt_registrados.TabIndex = 6
        Me.txt_registrados.Text = "Usuarios Registrados"
        '
        'registrados
        '
        Me.registrados.AutoSize = True
        Me.registrados.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.registrados.Location = New System.Drawing.Point(339, 100)
        Me.registrados.Name = "registrados"
        Me.registrados.Size = New System.Drawing.Size(23, 28)
        Me.registrados.TabIndex = 7
        Me.registrados.Text = "0"
        '
        'contenedor_reportes
        '
        Me.contenedor_reportes.AutoScroll = True
        Me.contenedor_reportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.contenedor_reportes.Controls.Add(Me.Label8)
        Me.contenedor_reportes.Controls.Add(Me.Label9)
        Me.contenedor_reportes.Controls.Add(Me.Label10)
        Me.contenedor_reportes.Controls.Add(Me.Label11)
        Me.contenedor_reportes.Controls.Add(Me.Label12)
        Me.contenedor_reportes.Controls.Add(Me.Label13)
        Me.contenedor_reportes.Location = New System.Drawing.Point(12, 149)
        Me.contenedor_reportes.Name = "contenedor_reportes"
        Me.contenedor_reportes.Size = New System.Drawing.Size(686, 310)
        Me.contenedor_reportes.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(41, 5, 41, 5)
        Me.Label8.Size = New System.Drawing.Size(167, 38)
        Me.Label8.TabIndex = 20
        Me.Label8.Tag = "header"
        Me.Label8.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(176, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(25, 5, 25, 5)
        Me.Label9.Size = New System.Drawing.Size(87, 38)
        Me.Label9.TabIndex = 15
        Me.Label9.Tag = "header"
        Me.Label9.Text = "Ap"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(269, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(25, 5, 25, 5)
        Me.Label10.Size = New System.Drawing.Size(88, 38)
        Me.Label10.TabIndex = 16
        Me.Label10.Tag = "header"
        Me.Label10.Text = "Dp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(363, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(25, 5, 25, 5)
        Me.Label11.Size = New System.Drawing.Size(96, 38)
        Me.Label11.TabIndex = 17
        Me.Label11.Tag = "header"
        Me.Label11.Text = "Imp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(465, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(25, 5, 25, 5)
        Me.Label12.Size = New System.Drawing.Size(92, 38)
        Me.Label12.TabIndex = 18
        Me.Label12.Tag = "header"
        Me.Label12.Text = "Olv"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(563, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(25, 5, 25, 5)
        Me.Label13.Size = New System.Drawing.Size(93, 38)
        Me.Label13.TabIndex = 19
        Me.Label13.Tag = "header"
        Me.Label13.Text = "Gbl"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(16, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(41, 1, 41, 5)
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(167, 34)
        Me.Label6.TabIndex = 14
        Me.Label6.Tag = "header"
        Me.Label6.Text = "Nombre"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(189, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(25, 1, 25, 5)
        Me.Label1.Size = New System.Drawing.Size(87, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Tag = "header"
        Me.Label1.Text = "Ap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(282, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(25, 1, 25, 5)
        Me.Label2.Size = New System.Drawing.Size(88, 34)
        Me.Label2.TabIndex = 10
        Me.Label2.Tag = "header"
        Me.Label2.Text = "Dp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(376, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(25, 1, 25, 5)
        Me.Label3.Size = New System.Drawing.Size(96, 34)
        Me.Label3.TabIndex = 11
        Me.Label3.Tag = "header"
        Me.Label3.Text = "Imp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(478, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(25, 1, 25, 5)
        Me.Label4.Size = New System.Drawing.Size(92, 34)
        Me.Label4.TabIndex = 12
        Me.Label4.Tag = "header"
        Me.Label4.Text = "Olv"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(576, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(25, 1, 25, 5)
        Me.Label5.Size = New System.Drawing.Size(93, 34)
        Me.Label5.TabIndex = 13
        Me.Label5.Tag = "header"
        Me.Label5.Text = "Gbl"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(118, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(479, 46)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "No hay usuarios para mostrar..."
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 471)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.contenedor_reportes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.registrados)
        Me.Controls.Add(Me.txt_registrados)
        Me.Controls.Add(Me.menu)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contenedor_reportes.ResumeLayout(False)
        Me.contenedor_reportes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu As Panel
    Friend WithEvents titulo As Label
    Friend WithEvents txt_registrados As Label
    Friend WithEvents registrados As Label
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents contenedor_reportes As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
