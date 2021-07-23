<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Facturalbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Facturatxtbox = New System.Windows.Forms.TextBox()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.Totaltxtbx = New System.Windows.Forms.TextBox()
        Me.Totallbl = New System.Windows.Forms.Label()
        Me.Desctxtbx = New System.Windows.Forms.TextBox()
        Me.Descuentolbl = New System.Windows.Forms.Label()
        Me.Subtotaltxtbox = New System.Windows.Forms.TextBox()
        Me.Subtotallbl = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Facturalbl
        '
        Me.Facturalbl.AutoSize = True
        Me.Facturalbl.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Facturalbl.Location = New System.Drawing.Point(330, 20)
        Me.Facturalbl.Name = "Facturalbl"
        Me.Facturalbl.Size = New System.Drawing.Size(122, 45)
        Me.Facturalbl.TabIndex = 0
        Me.Facturalbl.Text = "Factura"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(561, 305)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(591, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero de Factura"
        '
        'Facturatxtbox
        '
        Me.Facturatxtbox.Location = New System.Drawing.Point(706, 86)
        Me.Facturatxtbox.Name = "Facturatxtbox"
        Me.Facturatxtbox.Size = New System.Drawing.Size(73, 23)
        Me.Facturatxtbox.TabIndex = 3
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(666, 153)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 4
        Me.Buscarbtn.Text = "Buscar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'Totaltxtbx
        '
        Me.Totaltxtbx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Totaltxtbx.Location = New System.Drawing.Point(471, 397)
        Me.Totaltxtbx.Name = "Totaltxtbx"
        Me.Totaltxtbx.Size = New System.Drawing.Size(100, 29)
        Me.Totaltxtbx.TabIndex = 19
        '
        'Totallbl
        '
        Me.Totallbl.AutoSize = True
        Me.Totallbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Totallbl.Location = New System.Drawing.Point(423, 400)
        Me.Totallbl.Name = "Totallbl"
        Me.Totallbl.Size = New System.Drawing.Size(42, 21)
        Me.Totallbl.TabIndex = 18
        Me.Totallbl.Text = "Total"
        '
        'Desctxtbx
        '
        Me.Desctxtbx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Desctxtbx.Location = New System.Drawing.Point(297, 397)
        Me.Desctxtbx.Name = "Desctxtbx"
        Me.Desctxtbx.Size = New System.Drawing.Size(104, 29)
        Me.Desctxtbx.TabIndex = 17
        '
        'Descuentolbl
        '
        Me.Descuentolbl.AutoSize = True
        Me.Descuentolbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Descuentolbl.Location = New System.Drawing.Point(208, 400)
        Me.Descuentolbl.Name = "Descuentolbl"
        Me.Descuentolbl.Size = New System.Drawing.Size(83, 21)
        Me.Descuentolbl.TabIndex = 16
        Me.Descuentolbl.Text = "Descuento"
        '
        'Subtotaltxtbox
        '
        Me.Subtotaltxtbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Subtotaltxtbox.Location = New System.Drawing.Point(91, 397)
        Me.Subtotaltxtbox.Name = "Subtotaltxtbox"
        Me.Subtotaltxtbox.Size = New System.Drawing.Size(97, 29)
        Me.Subtotaltxtbox.TabIndex = 15
        '
        'Subtotallbl
        '
        Me.Subtotallbl.AutoSize = True
        Me.Subtotallbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Subtotallbl.Location = New System.Drawing.Point(16, 400)
        Me.Subtotallbl.Name = "Subtotallbl"
        Me.Subtotallbl.Size = New System.Drawing.Size(68, 21)
        Me.Subtotallbl.TabIndex = 14
        Me.Subtotallbl.Text = "Subtotal"
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Totaltxtbx)
        Me.Controls.Add(Me.Totallbl)
        Me.Controls.Add(Me.Desctxtbx)
        Me.Controls.Add(Me.Descuentolbl)
        Me.Controls.Add(Me.Subtotaltxtbox)
        Me.Controls.Add(Me.Subtotallbl)
        Me.Controls.Add(Me.Buscarbtn)
        Me.Controls.Add(Me.Facturatxtbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Facturalbl)
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Facturalbl As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Facturatxtbox As TextBox
    Friend WithEvents Buscarbtn As Button
    Friend WithEvents Totaltxtbx As TextBox
    Friend WithEvents Totallbl As Label
    Friend WithEvents Desctxtbx As TextBox
    Friend WithEvents Descuentolbl As Label
    Friend WithEvents Subtotaltxtbox As TextBox
    Friend WithEvents Subtotallbl As Label
End Class
