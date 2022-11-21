<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.contenedor_tareas = New System.Windows.Forms.FlowLayoutPanel()
        Me.opc_ordenar = New System.Windows.Forms.ComboBox()
        Me.menu = New System.Windows.Forms.Panel()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'contenedor_tareas
        '
        Me.contenedor_tareas.AutoScroll = True
        Me.contenedor_tareas.Location = New System.Drawing.Point(3, 23)
        Me.contenedor_tareas.Name = "contenedor_tareas"
        Me.contenedor_tareas.Size = New System.Drawing.Size(537, 367)
        Me.contenedor_tareas.TabIndex = 7
        '
        'opc_ordenar
        '
        Me.opc_ordenar.AutoCompleteCustomSource.AddRange(New String() {"Fecha", "Nombre (ASC)", "Nombre (DES)", "Orden de ingreso"})
        Me.opc_ordenar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.opc_ordenar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.opc_ordenar.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.opc_ordenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opc_ordenar.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.opc_ordenar.ForeColor = System.Drawing.Color.White
        Me.opc_ordenar.FormattingEnabled = True
        Me.opc_ordenar.Items.AddRange(New Object() {"Fecha", "Nombre (ASC)", "Nombre (DESC)"})
        Me.opc_ordenar.Location = New System.Drawing.Point(5, 2)
        Me.opc_ordenar.MaxDropDownItems = 10
        Me.opc_ordenar.Name = "opc_ordenar"
        Me.opc_ordenar.Size = New System.Drawing.Size(121, 21)
        Me.opc_ordenar.TabIndex = 7
        Me.opc_ordenar.TabStop = False
        Me.opc_ordenar.Text = "Ordenar por..."
        '
        'menu
        '
        Me.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menu.Controls.Add(Me.Cantidad)
        Me.menu.Location = New System.Drawing.Point(132, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(388, 23)
        Me.menu.TabIndex = 8
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.ForeColor = System.Drawing.Color.White
        Me.Cantidad.Location = New System.Drawing.Point(286, 3)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(58, 15)
        Me.Cantidad.TabIndex = 0
        Me.Cantidad.Text = "Cantidad:"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 390)
        Me.Controls.Add(Me.contenedor_tareas)
        Me.Controls.Add(Me.opc_ordenar)
        Me.Controls.Add(Me.menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents contenedor_tareas As FlowLayoutPanel
    Friend WithEvents opc_ordenar As ComboBox
    Friend WithEvents menu As Panel
    Friend WithEvents Cantidad As Label
End Class
