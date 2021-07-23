<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.TxtBx = New System.Windows.Forms.TextBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.AgregarClienteBtn = New System.Windows.Forms.Button()
        Me.CambiarSuscBtn = New System.Windows.Forms.Button()
        Me.CambiarEntrBtn = New System.Windows.Forms.Button()
        Me.EliminarCliBtn = New System.Windows.Forms.Button()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(313, 21)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(111, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Clientes"
        '
        'DGVCliente
        '
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.Location = New System.Drawing.Point(12, 103)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.RowTemplate.Height = 25
        Me.DGVCliente.Size = New System.Drawing.Size(448, 331)
        Me.DGVCliente.TabIndex = 1
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"ID de usuario", "Nombre", "Correo", "Suscripcion", "Entrenador"})
        Me.CBBuscar.Location = New System.Drawing.Point(479, 103)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(121, 23)
        Me.CBBuscar.TabIndex = 3
        '
        'TxtBx
        '
        Me.TxtBx.Location = New System.Drawing.Point(623, 103)
        Me.TxtBx.Name = "TxtBx"
        Me.TxtBx.Size = New System.Drawing.Size(136, 23)
        Me.TxtBx.TabIndex = 4
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(560, 141)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(99, 23)
        Me.BuscarBtn.TabIndex = 5
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'AgregarClienteBtn
        '
        Me.AgregarClienteBtn.Location = New System.Drawing.Point(479, 202)
        Me.AgregarClienteBtn.Name = "AgregarClienteBtn"
        Me.AgregarClienteBtn.Size = New System.Drawing.Size(258, 23)
        Me.AgregarClienteBtn.TabIndex = 6
        Me.AgregarClienteBtn.Text = "Agregar Cliente"
        Me.AgregarClienteBtn.UseVisualStyleBackColor = True
        '
        'CambiarSuscBtn
        '
        Me.CambiarSuscBtn.Location = New System.Drawing.Point(479, 263)
        Me.CambiarSuscBtn.Name = "CambiarSuscBtn"
        Me.CambiarSuscBtn.Size = New System.Drawing.Size(258, 23)
        Me.CambiarSuscBtn.TabIndex = 7
        Me.CambiarSuscBtn.Text = "Cambiar Suscripción"
        Me.CambiarSuscBtn.UseVisualStyleBackColor = True
        '
        'CambiarEntrBtn
        '
        Me.CambiarEntrBtn.Location = New System.Drawing.Point(479, 321)
        Me.CambiarEntrBtn.Name = "CambiarEntrBtn"
        Me.CambiarEntrBtn.Size = New System.Drawing.Size(258, 23)
        Me.CambiarEntrBtn.TabIndex = 8
        Me.CambiarEntrBtn.Text = "Cambiar Entrenador"
        Me.CambiarEntrBtn.UseVisualStyleBackColor = True
        '
        'EliminarCliBtn
        '
        Me.EliminarCliBtn.Location = New System.Drawing.Point(479, 380)
        Me.EliminarCliBtn.Name = "EliminarCliBtn"
        Me.EliminarCliBtn.Size = New System.Drawing.Size(258, 23)
        Me.EliminarCliBtn.TabIndex = 9
        Me.EliminarCliBtn.Text = "Eliminar Cliente"
        Me.EliminarCliBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 446)
        Me.Controls.Add(Me.EliminarCliBtn)
        Me.Controls.Add(Me.CambiarEntrBtn)
        Me.Controls.Add(Me.CambiarSuscBtn)
        Me.Controls.Add(Me.AgregarClienteBtn)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Controls.Add(Me.TxtBx)
        Me.Controls.Add(Me.CBBuscar)
        Me.Controls.Add(Me.DGVCliente)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents TxtBx As TextBox
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents AgregarClienteBtn As Button
    Friend WithEvents CambiarSuscBtn As Button
    Friend WithEvents CambiarEntrBtn As Button
    Friend WithEvents EliminarCliBtn As Button
End Class
