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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigolbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Nombrelbl = New System.Windows.Forms.Label()
        Me.Suscripciontxtbx = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Descripcionlbl = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Descuentolbl = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(286, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suscripciones"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(449, 348)
        Me.DataGridView1.TabIndex = 1
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(652, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(574, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(565, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Modificar Suscripción"
        Me.Button2.UseVisualStyleBackColor = True
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(574, 198)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 23)
        Me.TextBox2.TabIndex = 9
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(574, 241)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(103, 23)
        Me.TextBox3.TabIndex = 11
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Descuentolbl)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Descripcionlbl)
        Me.Controls.Add(Me.Suscripciontxtbx)
        Me.Controls.Add(Me.Nombrelbl)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Codigolbl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Codigolbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Nombrelbl As Label
    Friend WithEvents Suscripciontxtbx As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Descripcionlbl As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Descuentolbl As Label
End Class
