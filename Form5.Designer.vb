<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.EntrenaDGV = New System.Windows.Forms.DataGridView()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.NuevoEntreBtn = New System.Windows.Forms.Button()
        Me.ElimEntreBtn = New System.Windows.Forms.Button()
        Me.CodEntrelbl = New System.Windows.Forms.Label()
        Me.Codtxtbx = New System.Windows.Forms.TextBox()
        CType(Me.EntrenaDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(316, 26)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(173, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Entrenadores"
        '
        'EntrenaDGV
        '
        Me.EntrenaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EntrenaDGV.Location = New System.Drawing.Point(35, 131)
        Me.EntrenaDGV.Name = "EntrenaDGV"
        Me.EntrenaDGV.RowTemplate.Height = 25
        Me.EntrenaDGV.Size = New System.Drawing.Size(539, 275)
        Me.EntrenaDGV.TabIndex = 1
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
        'CodEntrelbl
        '
        Me.CodEntrelbl.AutoSize = True
        Me.CodEntrelbl.Location = New System.Drawing.Point(35, 88)
        Me.CodEntrelbl.Name = "CodEntrelbl"
        Me.CodEntrelbl.Size = New System.Drawing.Size(123, 15)
        Me.CodEntrelbl.TabIndex = 6
        Me.CodEntrelbl.Text = "Código de Entrenador"
        '
        'Codtxtbx
        '
        Me.Codtxtbx.Location = New System.Drawing.Point(174, 88)
        Me.Codtxtbx.Name = "Codtxtbx"
        Me.Codtxtbx.Size = New System.Drawing.Size(286, 23)
        Me.Codtxtbx.TabIndex = 7
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Codtxtbx)
        Me.Controls.Add(Me.CodEntrelbl)
        Me.Controls.Add(Me.ElimEntreBtn)
        Me.Controls.Add(Me.NuevoEntreBtn)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Controls.Add(Me.EntrenaDGV)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.EntrenaDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents EntrenaDGV As DataGridView
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents NuevoEntreBtn As Button
    Friend WithEvents ElimEntreBtn As Button
    Friend WithEvents CodEntrelbl As Label
    Friend WithEvents Codtxtbx As TextBox
End Class
