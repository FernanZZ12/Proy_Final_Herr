<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.IDPlbl = New System.Windows.Forms.Label()
        Me.IDClbl = New System.Windows.Forms.Label()
        Me.Marcalbl = New System.Windows.Forms.Label()
        Me.Descriplbl = New System.Windows.Forms.Label()
        Me.Preciolbl = New System.Windows.Forms.Label()
        Me.IDPtxtbx = New System.Windows.Forms.TextBox()
        Me.IDCtxtbx = New System.Windows.Forms.TextBox()
        Me.Marcatxtbx = New System.Windows.Forms.TextBox()
        Me.Descriptxtbx = New System.Windows.Forms.TextBox()
        Me.Preciotxtbx = New System.Windows.Forms.TextBox()
        Me.Cambiarbtn = New System.Windows.Forms.Button()
        Me.Regresarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(269, 26)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(245, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Modificar Producto"
        '
        'IDPlbl
        '
        Me.IDPlbl.AutoSize = True
        Me.IDPlbl.Location = New System.Drawing.Point(217, 114)
        Me.IDPlbl.Name = "IDPlbl"
        Me.IDPlbl.Size = New System.Drawing.Size(89, 15)
        Me.IDPlbl.TabIndex = 1
        Me.IDPlbl.Text = "ID del Producto"
        '
        'IDClbl
        '
        Me.IDClbl.AutoSize = True
        Me.IDClbl.Location = New System.Drawing.Point(217, 176)
        Me.IDClbl.Name = "IDClbl"
        Me.IDClbl.Size = New System.Drawing.Size(88, 15)
        Me.IDClbl.TabIndex = 2
        Me.IDClbl.Text = "ID de Categoría"
        '
        'Marcalbl
        '
        Me.Marcalbl.AutoSize = True
        Me.Marcalbl.Location = New System.Drawing.Point(217, 234)
        Me.Marcalbl.Name = "Marcalbl"
        Me.Marcalbl.Size = New System.Drawing.Size(40, 15)
        Me.Marcalbl.TabIndex = 3
        Me.Marcalbl.Text = "Marca"
        '
        'Descriplbl
        '
        Me.Descriplbl.AutoSize = True
        Me.Descriplbl.Location = New System.Drawing.Point(217, 297)
        Me.Descriplbl.Name = "Descriplbl"
        Me.Descriplbl.Size = New System.Drawing.Size(69, 15)
        Me.Descriplbl.TabIndex = 4
        Me.Descriplbl.Text = "Descripción"
        '
        'Preciolbl
        '
        Me.Preciolbl.AutoSize = True
        Me.Preciolbl.Location = New System.Drawing.Point(217, 367)
        Me.Preciolbl.Name = "Preciolbl"
        Me.Preciolbl.Size = New System.Drawing.Size(40, 15)
        Me.Preciolbl.TabIndex = 5
        Me.Preciolbl.Text = "Precio"
        '
        'IDPtxtbx
        '
        Me.IDPtxtbx.Location = New System.Drawing.Point(414, 111)
        Me.IDPtxtbx.Name = "IDPtxtbx"
        Me.IDPtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.IDPtxtbx.TabIndex = 6
        '
        'IDCtxtbx
        '
        Me.IDCtxtbx.Location = New System.Drawing.Point(414, 168)
        Me.IDCtxtbx.Name = "IDCtxtbx"
        Me.IDCtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.IDCtxtbx.TabIndex = 7
        '
        'Marcatxtbx
        '
        Me.Marcatxtbx.Location = New System.Drawing.Point(414, 234)
        Me.Marcatxtbx.Name = "Marcatxtbx"
        Me.Marcatxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Marcatxtbx.TabIndex = 8
        '
        'Descriptxtbx
        '
        Me.Descriptxtbx.Location = New System.Drawing.Point(414, 297)
        Me.Descriptxtbx.Name = "Descriptxtbx"
        Me.Descriptxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Descriptxtbx.TabIndex = 9
        '
        'Preciotxtbx
        '
        Me.Preciotxtbx.Location = New System.Drawing.Point(414, 364)
        Me.Preciotxtbx.Name = "Preciotxtbx"
        Me.Preciotxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Preciotxtbx.TabIndex = 10
        '
        'Cambiarbtn
        '
        Me.Cambiarbtn.Location = New System.Drawing.Point(639, 176)
        Me.Cambiarbtn.Name = "Cambiarbtn"
        Me.Cambiarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cambiarbtn.TabIndex = 11
        Me.Cambiarbtn.Text = "Modificar"
        Me.Cambiarbtn.UseVisualStyleBackColor = True
        '
        'Regresarbtn
        '
        Me.Regresarbtn.Location = New System.Drawing.Point(639, 259)
        Me.Regresarbtn.Name = "Regresarbtn"
        Me.Regresarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Regresarbtn.TabIndex = 12
        Me.Regresarbtn.Text = "Regresar"
        Me.Regresarbtn.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Regresarbtn)
        Me.Controls.Add(Me.Cambiarbtn)
        Me.Controls.Add(Me.Preciotxtbx)
        Me.Controls.Add(Me.Descriptxtbx)
        Me.Controls.Add(Me.Marcatxtbx)
        Me.Controls.Add(Me.IDCtxtbx)
        Me.Controls.Add(Me.IDPtxtbx)
        Me.Controls.Add(Me.Preciolbl)
        Me.Controls.Add(Me.Descriplbl)
        Me.Controls.Add(Me.Marcalbl)
        Me.Controls.Add(Me.IDClbl)
        Me.Controls.Add(Me.IDPlbl)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents IDPlbl As Label
    Friend WithEvents IDClbl As Label
    Friend WithEvents Marcalbl As Label
    Friend WithEvents Descriplbl As Label
    Friend WithEvents Preciolbl As Label
    Friend WithEvents IDPtxtbx As TextBox
    Friend WithEvents IDCtxtbx As TextBox
    Friend WithEvents Marcatxtbx As TextBox
    Friend WithEvents Descriptxtbx As TextBox
    Friend WithEvents Preciotxtbx As TextBox
    Friend WithEvents Cambiarbtn As Button
    Friend WithEvents Regresarbtn As Button
End Class
