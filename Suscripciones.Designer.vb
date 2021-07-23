<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suscripciones
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
        Me.Codigolbl = New System.Windows.Forms.Label()
        Me.CodigoTxtBx = New System.Windows.Forms.TextBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.ModificarSusBtn = New System.Windows.Forms.Button()
        Me.Nombrelbl = New System.Windows.Forms.Label()
        Me.Suscripciontxtbx = New System.Windows.Forms.TextBox()
        Me.Descripciontxtbx = New System.Windows.Forms.TextBox()
        Me.Descripcionlbl = New System.Windows.Forms.Label()
        Me.Descuentotxtbx = New System.Windows.Forms.TextBox()
        Me.Descuentolbl = New System.Windows.Forms.Label()
        Me.SuscripcionDGV = New System.Windows.Forms.DataGridView()
        CType(Me.SuscripcionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(286, 25)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(176, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Suscripciones"
        '
        'Codigolbl
        '
        Me.Codigolbl.AutoSize = True
        Me.Codigolbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Codigolbl.Location = New System.Drawing.Point(481, 83)
        Me.Codigolbl.Name = "Codigolbl"
        Me.Codigolbl.Size = New System.Drawing.Size(165, 21)
        Me.Codigolbl.TabIndex = 2
        Me.Codigolbl.Text = "Código de Suscripción"
        '
        'CodigoTxtBx
        '
        Me.CodigoTxtBx.Location = New System.Drawing.Point(652, 83)
        Me.CodigoTxtBx.Name = "CodigoTxtBx"
        Me.CodigoTxtBx.Size = New System.Drawing.Size(137, 23)
        Me.CodigoTxtBx.TabIndex = 3
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(574, 122)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(138, 23)
        Me.BuscarBtn.TabIndex = 4
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'ModificarSusBtn
        '
        Me.ModificarSusBtn.Location = New System.Drawing.Point(565, 298)
        Me.ModificarSusBtn.Name = "ModificarSusBtn"
        Me.ModificarSusBtn.Size = New System.Drawing.Size(160, 23)
        Me.ModificarSusBtn.TabIndex = 5
        Me.ModificarSusBtn.Text = "Modificar Suscripción"
        Me.ModificarSusBtn.UseVisualStyleBackColor = True
        '
        'Nombrelbl
        '
        Me.Nombrelbl.AutoSize = True
        Me.Nombrelbl.Location = New System.Drawing.Point(493, 157)
        Me.Nombrelbl.Name = "Nombrelbl"
        Me.Nombrelbl.Size = New System.Drawing.Size(68, 15)
        Me.Nombrelbl.TabIndex = 6
        Me.Nombrelbl.Text = "Suscripcion"
        '
        'Suscripciontxtbx
        '
        Me.Suscripciontxtbx.Location = New System.Drawing.Point(574, 154)
        Me.Suscripciontxtbx.Name = "Suscripciontxtbx"
        Me.Suscripciontxtbx.Size = New System.Drawing.Size(214, 23)
        Me.Suscripciontxtbx.TabIndex = 7
        '
        'Descripciontxtbx
        '
        Me.Descripciontxtbx.Location = New System.Drawing.Point(574, 198)
        Me.Descripciontxtbx.Name = "Descripciontxtbx"
        Me.Descripciontxtbx.Size = New System.Drawing.Size(214, 23)
        Me.Descripciontxtbx.TabIndex = 9
        '
        'Descripcionlbl
        '
        Me.Descripcionlbl.AutoSize = True
        Me.Descripcionlbl.Location = New System.Drawing.Point(493, 201)
        Me.Descripcionlbl.Name = "Descripcionlbl"
        Me.Descripcionlbl.Size = New System.Drawing.Size(69, 15)
        Me.Descripcionlbl.TabIndex = 8
        Me.Descripcionlbl.Text = "Descripcion"
        '
        'Descuentotxtbx
        '
        Me.Descuentotxtbx.Location = New System.Drawing.Point(574, 241)
        Me.Descuentotxtbx.Name = "Descuentotxtbx"
        Me.Descuentotxtbx.Size = New System.Drawing.Size(103, 23)
        Me.Descuentotxtbx.TabIndex = 11
        '
        'Descuentolbl
        '
        Me.Descuentolbl.AutoSize = True
        Me.Descuentolbl.Location = New System.Drawing.Point(493, 244)
        Me.Descuentolbl.Name = "Descuentolbl"
        Me.Descuentolbl.Size = New System.Drawing.Size(63, 15)
        Me.Descuentolbl.TabIndex = 10
        Me.Descuentolbl.Text = "Descuento"
        '
        'SuscripcionDGV
        '
        Me.SuscripcionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuscripcionDGV.Location = New System.Drawing.Point(13, 81)
        Me.SuscripcionDGV.Name = "SuscripcionDGV"
        Me.SuscripcionDGV.RowTemplate.Height = 25
        Me.SuscripcionDGV.Size = New System.Drawing.Size(449, 348)
        Me.SuscripcionDGV.TabIndex = 1
        '
        'Suscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Descuentotxtbx)
        Me.Controls.Add(Me.Descuentolbl)
        Me.Controls.Add(Me.Descripciontxtbx)
        Me.Controls.Add(Me.Descripcionlbl)
        Me.Controls.Add(Me.Suscripciontxtbx)
        Me.Controls.Add(Me.Nombrelbl)
        Me.Controls.Add(Me.ModificarSusBtn)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Controls.Add(Me.CodigoTxtBx)
        Me.Controls.Add(Me.Codigolbl)
        Me.Controls.Add(Me.SuscripcionDGV)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Suscripciones"
        Me.Text = "Form3"
        CType(Me.SuscripcionDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents Codigolbl As Label
    Friend WithEvents CodigoTxtBx As TextBox
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents ModificarSusBtn As Button
    Friend WithEvents Nombrelbl As Label
    Friend WithEvents Suscripciontxtbx As TextBox
    Friend WithEvents Descripciontxtbx As TextBox
    Friend WithEvents Descripcionlbl As Label
    Friend WithEvents Descuentotxtbx As TextBox
    Friend WithEvents Descuentolbl As Label
    Friend WithEvents SuscripcionDGV As DataGridView
End Class
