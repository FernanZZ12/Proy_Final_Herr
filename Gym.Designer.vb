﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gymbokuform
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
        Me.Facturalbl = New System.Windows.Forms.Label()
        Me.FacturaDGV = New System.Windows.Forms.DataGridView()
        Me.CodProtxtbx = New System.Windows.Forms.TextBox()
        Me.CodProductolbl = New System.Windows.Forms.Label()
        Me.Agregarbttn = New System.Windows.Forms.Button()
        Me.ID_usulbl = New System.Windows.Forms.Label()
        Me.Idusutxtbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Subtotallbl = New System.Windows.Forms.Label()
        Me.Subtotaltxtbox = New System.Windows.Forms.TextBox()
        Me.Descuentolbl = New System.Windows.Forms.Label()
        Me.Desctxtbx = New System.Windows.Forms.TextBox()
        Me.Totallbl = New System.Windows.Forms.Label()
        Me.Totaltxtbx = New System.Windows.Forms.TextBox()
        Me.AgregFactbttn = New System.Windows.Forms.Button()
        Me.numlbl = New System.Windows.Forms.Label()
        Me.FactNumlbl = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuscripcionesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrenadoresItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanteamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cantlbl = New System.Windows.Forms.Label()
        Me.Cantidadtxtbx = New System.Windows.Forms.TextBox()
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        CType(Me.FacturaDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Facturalbl
        '
        Me.Facturalbl.AutoSize = True
        Me.Facturalbl.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Facturalbl.Location = New System.Drawing.Point(332, 18)
        Me.Facturalbl.Name = "Facturalbl"
        Me.Facturalbl.Size = New System.Drawing.Size(109, 40)
        Me.Facturalbl.TabIndex = 0
        Me.Facturalbl.Text = "Factura"
        '
        'FacturaDGV
        '
        Me.FacturaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDGV.Location = New System.Drawing.Point(12, 135)
        Me.FacturaDGV.Name = "FacturaDGV"
        Me.FacturaDGV.RowTemplate.Height = 25
        Me.FacturaDGV.Size = New System.Drawing.Size(558, 500)
        Me.FacturaDGV.TabIndex = 1
        '
        'CodProtxtbx
        '
        Me.CodProtxtbx.Location = New System.Drawing.Point(12, 106)
        Me.CodProtxtbx.Name = "CodProtxtbx"
        Me.CodProtxtbx.Size = New System.Drawing.Size(332, 23)
        Me.CodProtxtbx.TabIndex = 2
        '
        'CodProductolbl
        '
        Me.CodProductolbl.AutoSize = True
        Me.CodProductolbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CodProductolbl.Location = New System.Drawing.Point(12, 78)
        Me.CodProductolbl.Name = "CodProductolbl"
        Me.CodProductolbl.Size = New System.Drawing.Size(181, 25)
        Me.CodProductolbl.TabIndex = 3
        Me.CodProductolbl.Text = "Codigo de Producto"
        '
        'Agregarbttn
        '
        Me.Agregarbttn.Location = New System.Drawing.Point(447, 105)
        Me.Agregarbttn.Name = "Agregarbttn"
        Me.Agregarbttn.Size = New System.Drawing.Size(123, 23)
        Me.Agregarbttn.TabIndex = 4
        Me.Agregarbttn.Text = "Agregar Producto"
        Me.Agregarbttn.UseVisualStyleBackColor = True
        '
        'ID_usulbl
        '
        Me.ID_usulbl.AutoSize = True
        Me.ID_usulbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ID_usulbl.Location = New System.Drawing.Point(597, 107)
        Me.ID_usulbl.Name = "ID_usulbl"
        Me.ID_usulbl.Size = New System.Drawing.Size(86, 21)
        Me.ID_usulbl.TabIndex = 5
        Me.ID_usulbl.Text = "ID_Usuario"
        '
        'Idusutxtbx
        '
        Me.Idusutxtbx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Idusutxtbx.Location = New System.Drawing.Point(689, 102)
        Me.Idusutxtbx.Name = "Idusutxtbx"
        Me.Idusutxtbx.Size = New System.Drawing.Size(100, 29)
        Me.Idusutxtbx.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(-646, 557)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Subtotal"
        '
        'Subtotallbl
        '
        Me.Subtotallbl.AutoSize = True
        Me.Subtotallbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Subtotallbl.Location = New System.Drawing.Point(12, 650)
        Me.Subtotallbl.Name = "Subtotallbl"
        Me.Subtotallbl.Size = New System.Drawing.Size(68, 21)
        Me.Subtotallbl.TabIndex = 8
        Me.Subtotallbl.Text = "Subtotal"
        '
        'Subtotaltxtbox
        '
        Me.Subtotaltxtbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Subtotaltxtbox.Location = New System.Drawing.Point(87, 647)
        Me.Subtotaltxtbox.Name = "Subtotaltxtbox"
        Me.Subtotaltxtbox.Size = New System.Drawing.Size(97, 29)
        Me.Subtotaltxtbox.TabIndex = 9
        '
        'Descuentolbl
        '
        Me.Descuentolbl.AutoSize = True
        Me.Descuentolbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Descuentolbl.Location = New System.Drawing.Point(204, 650)
        Me.Descuentolbl.Name = "Descuentolbl"
        Me.Descuentolbl.Size = New System.Drawing.Size(83, 21)
        Me.Descuentolbl.TabIndex = 10
        Me.Descuentolbl.Text = "Descuento"
        '
        'Desctxtbx
        '
        Me.Desctxtbx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Desctxtbx.Location = New System.Drawing.Point(293, 647)
        Me.Desctxtbx.Name = "Desctxtbx"
        Me.Desctxtbx.Size = New System.Drawing.Size(104, 29)
        Me.Desctxtbx.TabIndex = 11
        '
        'Totallbl
        '
        Me.Totallbl.AutoSize = True
        Me.Totallbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Totallbl.Location = New System.Drawing.Point(419, 650)
        Me.Totallbl.Name = "Totallbl"
        Me.Totallbl.Size = New System.Drawing.Size(42, 21)
        Me.Totallbl.TabIndex = 12
        Me.Totallbl.Text = "Total"
        '
        'Totaltxtbx
        '
        Me.Totaltxtbx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Totaltxtbx.Location = New System.Drawing.Point(467, 647)
        Me.Totaltxtbx.Name = "Totaltxtbx"
        Me.Totaltxtbx.Size = New System.Drawing.Size(100, 29)
        Me.Totaltxtbx.TabIndex = 13
        '
        'AgregFactbttn
        '
        Me.AgregFactbttn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AgregFactbttn.Location = New System.Drawing.Point(627, 638)
        Me.AgregFactbttn.Name = "AgregFactbttn"
        Me.AgregFactbttn.Size = New System.Drawing.Size(145, 45)
        Me.AgregFactbttn.TabIndex = 14
        Me.AgregFactbttn.Text = "Agregar Factura"
        Me.AgregFactbttn.UseVisualStyleBackColor = True
        '
        'numlbl
        '
        Me.numlbl.AutoSize = True
        Me.numlbl.Location = New System.Drawing.Point(130, 686)
        Me.numlbl.Name = "numlbl"
        Me.numlbl.Size = New System.Drawing.Size(32, 15)
        Me.numlbl.TabIndex = 15
        Me.numlbl.Text = "num"
        '
        'FactNumlbl
        '
        Me.FactNumlbl.AutoSize = True
        Me.FactNumlbl.Location = New System.Drawing.Point(12, 686)
        Me.FactNumlbl.Name = "FactNumlbl"
        Me.FactNumlbl.Size = New System.Drawing.Size(112, 15)
        Me.FactNumlbl.TabIndex = 16
        Me.FactNumlbl.Text = "Numero de Factura:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesItem, Me.SuscripcionesItem, Me.ProductosItem, Me.EntrenadoresItem, Me.FacturaItem, Me.PlanteamientoToolStripMenuItem, Me.PresentacionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesItem
        '
        Me.ClientesItem.Name = "ClientesItem"
        Me.ClientesItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesItem.Text = "Clientes"
        '
        'SuscripcionesItem
        '
        Me.SuscripcionesItem.Name = "SuscripcionesItem"
        Me.SuscripcionesItem.Size = New System.Drawing.Size(91, 20)
        Me.SuscripcionesItem.Text = "Suscripciones"
        '
        'ProductosItem
        '
        Me.ProductosItem.Name = "ProductosItem"
        Me.ProductosItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosItem.Text = "Productos"
        '
        'EntrenadoresItem
        '
        Me.EntrenadoresItem.Name = "EntrenadoresItem"
        Me.EntrenadoresItem.Size = New System.Drawing.Size(88, 20)
        Me.EntrenadoresItem.Text = "Entrenadores"
        '
        'FacturaItem
        '
        Me.FacturaItem.Name = "FacturaItem"
        Me.FacturaItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturaItem.Text = "Facturas"
        '
        'PlanteamientoToolStripMenuItem
        '
        Me.PlanteamientoToolStripMenuItem.Name = "PlanteamientoToolStripMenuItem"
        Me.PlanteamientoToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.PlanteamientoToolStripMenuItem.Text = "Planteamiento"
        '
        'PresentacionToolStripMenuItem
        '
        Me.PresentacionToolStripMenuItem.Name = "PresentacionToolStripMenuItem"
        Me.PresentacionToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PresentacionToolStripMenuItem.Text = "Presentacion"
        '
        'Cantlbl
        '
        Me.Cantlbl.AutoSize = True
        Me.Cantlbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cantlbl.Location = New System.Drawing.Point(350, 109)
        Me.Cantlbl.Name = "Cantlbl"
        Me.Cantlbl.Size = New System.Drawing.Size(39, 20)
        Me.Cantlbl.TabIndex = 19
        Me.Cantlbl.Text = "Cant"
        '
        'Cantidadtxtbx
        '
        Me.Cantidadtxtbx.Location = New System.Drawing.Point(395, 106)
        Me.Cantidadtxtbx.Name = "Cantidadtxtbx"
        Me.Cantidadtxtbx.Size = New System.Drawing.Size(46, 23)
        Me.Cantidadtxtbx.TabIndex = 20
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Eliminarbtn.Location = New System.Drawing.Point(627, 210)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(145, 37)
        Me.Eliminarbtn.TabIndex = 21
        Me.Eliminarbtn.Text = "Eliminar Producto"
        Me.Eliminarbtn.UseVisualStyleBackColor = True
        '
        'gymbokuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 713)
        Me.Controls.Add(Me.Eliminarbtn)
        Me.Controls.Add(Me.Cantidadtxtbx)
        Me.Controls.Add(Me.Cantlbl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FactNumlbl)
        Me.Controls.Add(Me.numlbl)
        Me.Controls.Add(Me.AgregFactbttn)
        Me.Controls.Add(Me.Totaltxtbx)
        Me.Controls.Add(Me.Totallbl)
        Me.Controls.Add(Me.Desctxtbx)
        Me.Controls.Add(Me.Descuentolbl)
        Me.Controls.Add(Me.Subtotaltxtbox)
        Me.Controls.Add(Me.Subtotallbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Idusutxtbx)
        Me.Controls.Add(Me.ID_usulbl)
        Me.Controls.Add(Me.Agregarbttn)
        Me.Controls.Add(Me.CodProductolbl)
        Me.Controls.Add(Me.CodProtxtbx)
        Me.Controls.Add(Me.FacturaDGV)
        Me.Controls.Add(Me.Facturalbl)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "gymbokuform"
        Me.Text = "Gym  Boku"
        CType(Me.FacturaDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Facturalbl As Label
    Friend WithEvents FacturaDGV As DataGridView
    Friend WithEvents CodProtxtbx As TextBox
    Friend WithEvents CodProductolbl As Label
    Friend WithEvents Agregarbttn As Button
    Friend WithEvents ID_usulbl As Label
    Friend WithEvents Idusutxtbx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Subtotallbl As Label
    Friend WithEvents Subtotaltxtbox As TextBox
    Friend WithEvents Descuentolbl As Label
    Friend WithEvents Desctxtbx As TextBox
    Friend WithEvents Totallbl As Label
    Friend WithEvents Totaltxtbx As TextBox
    Friend WithEvents AgregFactbttn As Button
    Friend WithEvents numlbl As Label
    Friend WithEvents FactNumlbl As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesItem As ToolStripMenuItem
    Friend WithEvents SuscripcionesItem As ToolStripMenuItem
    Friend WithEvents ProductosItem As ToolStripMenuItem
    Friend WithEvents EntrenadoresItem As ToolStripMenuItem
    Friend WithEvents FacturaItem As ToolStripMenuItem
    Friend WithEvents Cantlbl As Label
    Friend WithEvents Cantidadtxtbx As TextBox
    Friend WithEvents PlanteamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Eliminarbtn As Button
End Class
