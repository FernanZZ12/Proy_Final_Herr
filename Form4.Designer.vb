<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Suscriplbl = New System.Windows.Forms.Label()
        Me.SuscripCB = New System.Windows.Forms.ComboBox()
        Me.CambiarBtn = New System.Windows.Forms.Button()
        Me.RegresarBtn = New System.Windows.Forms.Button()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.IDtxtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(245, 39)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(258, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Cambiar Suscripción"
        '
        'Suscriplbl
        '
        Me.Suscriplbl.AutoSize = True
        Me.Suscriplbl.Location = New System.Drawing.Point(201, 266)
        Me.Suscriplbl.Name = "Suscriplbl"
        Me.Suscriplbl.Size = New System.Drawing.Size(110, 15)
        Me.Suscriplbl.TabIndex = 1
        Me.Suscriplbl.Text = "Tipo de Suscripción"
        '
        'SuscripCB
        '
        Me.SuscripCB.FormattingEnabled = True
        Me.SuscripCB.Items.AddRange(New Object() {"SI", "GD", "PL"})
        Me.SuscripCB.Location = New System.Drawing.Point(364, 258)
        Me.SuscripCB.Name = "SuscripCB"
        Me.SuscripCB.Size = New System.Drawing.Size(121, 23)
        Me.SuscripCB.TabIndex = 2
        '
        'CambiarBtn
        '
        Me.CambiarBtn.Location = New System.Drawing.Point(605, 163)
        Me.CambiarBtn.Name = "CambiarBtn"
        Me.CambiarBtn.Size = New System.Drawing.Size(75, 23)
        Me.CambiarBtn.TabIndex = 3
        Me.CambiarBtn.Text = "Cambiar"
        Me.CambiarBtn.UseVisualStyleBackColor = True
        '
        'RegresarBtn
        '
        Me.RegresarBtn.Location = New System.Drawing.Point(605, 231)
        Me.RegresarBtn.Name = "RegresarBtn"
        Me.RegresarBtn.Size = New System.Drawing.Size(75, 23)
        Me.RegresarBtn.TabIndex = 4
        Me.RegresarBtn.Text = "Regresar"
        Me.RegresarBtn.UseVisualStyleBackColor = True
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(201, 163)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(81, 15)
        Me.IDlbl.TabIndex = 5
        Me.IDlbl.Text = "ID Del Usuario"
        '
        'IDtxtbx
        '
        Me.IDtxtbx.Location = New System.Drawing.Point(364, 155)
        Me.IDtxtbx.Name = "IDtxtbx"
        Me.IDtxtbx.Size = New System.Drawing.Size(121, 23)
        Me.IDtxtbx.TabIndex = 6
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IDtxtbx)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.RegresarBtn)
        Me.Controls.Add(Me.CambiarBtn)
        Me.Controls.Add(Me.SuscripCB)
        Me.Controls.Add(Me.Suscriplbl)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents Suscriplbl As Label
    Friend WithEvents SuscripCB As ComboBox
    Friend WithEvents CambiarBtn As Button
    Friend WithEvents RegresarBtn As Button
    Friend WithEvents IDlbl As Label
    Friend WithEvents IDtxtbx As TextBox
End Class
