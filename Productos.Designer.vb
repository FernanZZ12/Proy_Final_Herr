<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.lblCodProd = New System.Windows.Forms.Label()
        Me.Prodtxtbx = New System.Windows.Forms.TextBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.ModificarProBtn = New System.Windows.Forms.Button()
        Me.EliminarProBtn = New System.Windows.Forms.Button()
        Me.AgregarProBtn = New System.Windows.Forms.Button()
        Me.ProdDGV = New System.Windows.Forms.DataGridView()
        CType(Me.ProdDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(275, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(136, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Productos"
        '
        'lblCodProd
        '
        Me.lblCodProd.AutoSize = True
        Me.lblCodProd.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCodProd.Location = New System.Drawing.Point(27, 83)
        Me.lblCodProd.Name = "lblCodProd"
        Me.lblCodProd.Size = New System.Drawing.Size(143, 20)
        Me.lblCodProd.TabIndex = 1
        Me.lblCodProd.Text = "Código de Producto"
        '
        'Prodtxtbx
        '
        Me.Prodtxtbx.Location = New System.Drawing.Point(193, 84)
        Me.Prodtxtbx.Name = "Prodtxtbx"
        Me.Prodtxtbx.Size = New System.Drawing.Size(264, 23)
        Me.Prodtxtbx.TabIndex = 2
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(490, 84)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBtn.TabIndex = 3
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'ModificarProBtn
        '
        Me.ModificarProBtn.Location = New System.Drawing.Point(594, 166)
        Me.ModificarProBtn.Name = "ModificarProBtn"
        Me.ModificarProBtn.Size = New System.Drawing.Size(172, 23)
        Me.ModificarProBtn.TabIndex = 4
        Me.ModificarProBtn.Text = "Modificar Producto"
        Me.ModificarProBtn.UseVisualStyleBackColor = True
        '
        'EliminarProBtn
        '
        Me.EliminarProBtn.Location = New System.Drawing.Point(594, 225)
        Me.EliminarProBtn.Name = "EliminarProBtn"
        Me.EliminarProBtn.Size = New System.Drawing.Size(172, 23)
        Me.EliminarProBtn.TabIndex = 5
        Me.EliminarProBtn.Text = "Eliminar Producto"
        Me.EliminarProBtn.UseVisualStyleBackColor = True
        '
        'AgregarProBtn
        '
        Me.AgregarProBtn.Location = New System.Drawing.Point(594, 283)
        Me.AgregarProBtn.Name = "AgregarProBtn"
        Me.AgregarProBtn.Size = New System.Drawing.Size(172, 23)
        Me.AgregarProBtn.TabIndex = 6
        Me.AgregarProBtn.Text = "Agregar Producto"
        Me.AgregarProBtn.UseVisualStyleBackColor = True
        '
        'ProdDGV
        '
        Me.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdDGV.Location = New System.Drawing.Point(27, 132)
        Me.ProdDGV.Name = "ProdDGV"
        Me.ProdDGV.RowTemplate.Height = 25
        Me.ProdDGV.Size = New System.Drawing.Size(538, 247)
        Me.ProdDGV.TabIndex = 7
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProdDGV)
        Me.Controls.Add(Me.AgregarProBtn)
        Me.Controls.Add(Me.EliminarProBtn)
        Me.Controls.Add(Me.ModificarProBtn)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Controls.Add(Me.Prodtxtbx)
        Me.Controls.Add(Me.lblCodProd)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Productos"
        Me.Text = "Form4"
        CType(Me.ProdDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblCodProd As Label
    Friend WithEvents Prodtxtbx As TextBox
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents ModificarProBtn As Button
    Friend WithEvents EliminarProBtn As Button
    Friend WithEvents AgregarProBtn As Button
    Friend WithEvents ProdDGV As DataGridView
End Class
