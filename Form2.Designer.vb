<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Titulolbl = New System.Windows.Forms.Label()
        Me.ClienteDGV = New System.Windows.Forms.DataGridView()
        Me.BuscarCB = New System.Windows.Forms.ComboBox()
        Me.BuscarTxtbx = New System.Windows.Forms.TextBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.AgregarClienteBtn = New System.Windows.Forms.Button()
        Me.CambiarSuscBtn = New System.Windows.Forms.Button()
        Me.CambiarEntrBtn = New System.Windows.Forms.Button()
        Me.EliminarCliBtn = New System.Windows.Forms.Button()
        CType(Me.ClienteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(313, 21)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(111, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Clientes"
        '
        'ClienteDGV
        '
        Me.ClienteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDGV.Location = New System.Drawing.Point(12, 103)
        Me.ClienteDGV.Name = "ClienteDGV"
        Me.ClienteDGV.RowTemplate.Height = 25
        Me.ClienteDGV.Size = New System.Drawing.Size(448, 331)
        Me.ClienteDGV.TabIndex = 1
        '
        'BuscarCB
        '
        Me.BuscarCB.FormattingEnabled = True
        Me.BuscarCB.Items.AddRange(New Object() {"ID de usuario", "Nombre", "Correo", "Suscripcion", "Entrenador"})
        Me.BuscarCB.Location = New System.Drawing.Point(479, 103)
        Me.BuscarCB.Name = "BuscarCB"
        Me.BuscarCB.Size = New System.Drawing.Size(121, 23)
        Me.BuscarCB.TabIndex = 3
        '
        'BuscarTxtbx
        '
        Me.BuscarTxtbx.Location = New System.Drawing.Point(623, 103)
        Me.BuscarTxtbx.Name = "BuscarTxtbx"
        Me.BuscarTxtbx.Size = New System.Drawing.Size(136, 23)
        Me.BuscarTxtbx.TabIndex = 4
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
        Me.Controls.Add(Me.BuscarTxtbx)
        Me.Controls.Add(Me.BuscarCB)
        Me.Controls.Add(Me.ClienteDGV)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ClienteDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents ClienteDGV As DataGridView
    Friend WithEvents BuscarCB As ComboBox
    Friend WithEvents BuscarTxtbx As TextBox
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents AgregarClienteBtn As Button
    Friend WithEvents CambiarSuscBtn As Button
    Friend WithEvents CambiarEntrBtn As Button
    Friend WithEvents EliminarCliBtn As Button
End Class
