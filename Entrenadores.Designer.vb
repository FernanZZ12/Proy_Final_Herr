<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrenadores
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
        Me.DGVEntre = New System.Windows.Forms.DataGridView()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.NuevoEntreBtn = New System.Windows.Forms.Button()
        Me.ElimEntreBtn = New System.Windows.Forms.Button()
        Me.lblCodEntre = New System.Windows.Forms.Label()
        Me.TxtBx = New System.Windows.Forms.TextBox()
        CType(Me.DGVEntre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(316, 26)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(173, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Entrenadores"
        '
        'DGVEntre
        '
        Me.DGVEntre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntre.Location = New System.Drawing.Point(35, 131)
        Me.DGVEntre.Name = "DGVEntre"
        Me.DGVEntre.RowTemplate.Height = 25
        Me.DGVEntre.Size = New System.Drawing.Size(539, 275)
        Me.DGVEntre.TabIndex = 1
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(499, 87)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBtn.TabIndex = 2
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'NuevoEntreBtn
        '
        Me.NuevoEntreBtn.Location = New System.Drawing.Point(602, 200)
        Me.NuevoEntreBtn.Name = "NuevoEntreBtn"
        Me.NuevoEntreBtn.Size = New System.Drawing.Size(168, 23)
        Me.NuevoEntreBtn.TabIndex = 3
        Me.NuevoEntreBtn.Text = "Nuevo Entrenador"
        Me.NuevoEntreBtn.UseVisualStyleBackColor = True
        '
        'ElimEntreBtn
        '
        Me.ElimEntreBtn.Location = New System.Drawing.Point(602, 266)
        Me.ElimEntreBtn.Name = "ElimEntreBtn"
        Me.ElimEntreBtn.Size = New System.Drawing.Size(168, 23)
        Me.ElimEntreBtn.TabIndex = 4
        Me.ElimEntreBtn.Text = "Eliminar Entrenador"
        Me.ElimEntreBtn.UseVisualStyleBackColor = True
        '
        'lblCodEntre
        '
        Me.lblCodEntre.AutoSize = True
        Me.lblCodEntre.Location = New System.Drawing.Point(35, 88)
        Me.lblCodEntre.Name = "lblCodEntre"
        Me.lblCodEntre.Size = New System.Drawing.Size(123, 15)
        Me.lblCodEntre.TabIndex = 6
        Me.lblCodEntre.Text = "Código de Entrenador"
        '
        'TxtBx
        '
        Me.TxtBx.Location = New System.Drawing.Point(174, 88)
        Me.TxtBx.Name = "TxtBx"
        Me.TxtBx.Size = New System.Drawing.Size(286, 23)
        Me.TxtBx.TabIndex = 7
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtBx)
        Me.Controls.Add(Me.lblCodEntre)
        Me.Controls.Add(Me.ElimEntreBtn)
        Me.Controls.Add(Me.NuevoEntreBtn)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Controls.Add(Me.DGVEntre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DGVEntre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents DGVEntre As DataGridView
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents NuevoEntreBtn As Button
    Friend WithEvents ElimEntreBtn As Button
    Friend WithEvents lblCodEntre As Label
    Friend WithEvents TxtBx As TextBox
End Class
