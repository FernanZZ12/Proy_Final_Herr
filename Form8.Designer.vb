<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        Me.Regresarbtn = New System.Windows.Forms.Button()
        Me.IDPtxtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(285, 59)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(228, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Eliminar Producto"
        '
        'IDPlbl
        '
        Me.IDPlbl.AutoSize = True
        Me.IDPlbl.Location = New System.Drawing.Point(246, 184)
        Me.IDPlbl.Name = "IDPlbl"
        Me.IDPlbl.Size = New System.Drawing.Size(89, 15)
        Me.IDPlbl.TabIndex = 1
        Me.IDPlbl.Text = "ID del Producto"
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Location = New System.Drawing.Point(653, 131)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Eliminarbtn.TabIndex = 2
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = True
        '
        'Regresarbtn
        '
        Me.Regresarbtn.Location = New System.Drawing.Point(653, 219)
        Me.Regresarbtn.Name = "Regresarbtn"
        Me.Regresarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Regresarbtn.TabIndex = 3
        Me.Regresarbtn.Text = "Regresar"
        Me.Regresarbtn.UseVisualStyleBackColor = True
        '
        'IDPtxtbx
        '
        Me.IDPtxtbx.Location = New System.Drawing.Point(413, 181)
        Me.IDPtxtbx.Name = "IDPtxtbx"
        Me.IDPtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.IDPtxtbx.TabIndex = 4
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IDPtxtbx)
        Me.Controls.Add(Me.Regresarbtn)
        Me.Controls.Add(Me.Eliminarbtn)
        Me.Controls.Add(Me.IDPlbl)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents IDPlbl As Label
    Friend WithEvents Eliminarbtn As Button
    Friend WithEvents Regresarbtn As Button
    Friend WithEvents IDPtxtbx As TextBox
End Class
