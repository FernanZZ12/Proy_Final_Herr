<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Nombrelbl = New System.Windows.Forms.Label()
        Me.Emaillbl = New System.Windows.Forms.Label()
        Me.Entrenalbl = New System.Windows.Forms.Label()
        Me.IDtxtbx = New System.Windows.Forms.TextBox()
        Me.Nombretxtbx = New System.Windows.Forms.TextBox()
        Me.Emailtxtbx = New System.Windows.Forms.TextBox()
        Me.Entrenatxtbx = New System.Windows.Forms.TextBox()
        Me.Añadirbtn = New System.Windows.Forms.Button()
        Me.Regresarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(314, 22)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(202, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Agregar Cliente"
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(262, 99)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(80, 15)
        Me.IDlbl.TabIndex = 1
        Me.IDlbl.Text = "ID del Usuario"
        '
        'Nombrelbl
        '
        Me.Nombrelbl.AutoSize = True
        Me.Nombrelbl.Location = New System.Drawing.Point(262, 157)
        Me.Nombrelbl.Name = "Nombrelbl"
        Me.Nombrelbl.Size = New System.Drawing.Size(51, 15)
        Me.Nombrelbl.TabIndex = 2
        Me.Nombrelbl.Text = "Nombre"
        '
        'Emaillbl
        '
        Me.Emaillbl.AutoSize = True
        Me.Emaillbl.Location = New System.Drawing.Point(262, 213)
        Me.Emaillbl.Name = "Emaillbl"
        Me.Emaillbl.Size = New System.Drawing.Size(43, 15)
        Me.Emaillbl.TabIndex = 3
        Me.Emaillbl.Text = "Correo"
        '
        'Entrenalbl
        '
        Me.Entrenalbl.AutoSize = True
        Me.Entrenalbl.Location = New System.Drawing.Point(261, 296)
        Me.Entrenalbl.Name = "Entrenalbl"
        Me.Entrenalbl.Size = New System.Drawing.Size(81, 15)
        Me.Entrenalbl.TabIndex = 5
        Me.Entrenalbl.Text = "ID_Entrenador"
        '
        'IDtxtbx
        '
        Me.IDtxtbx.Location = New System.Drawing.Point(451, 96)
        Me.IDtxtbx.Name = "IDtxtbx"
        Me.IDtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.IDtxtbx.TabIndex = 6
        '
        'Nombretxtbx
        '
        Me.Nombretxtbx.Location = New System.Drawing.Point(451, 149)
        Me.Nombretxtbx.Name = "Nombretxtbx"
        Me.Nombretxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Nombretxtbx.TabIndex = 7
        '
        'Emailtxtbx
        '
        Me.Emailtxtbx.Location = New System.Drawing.Point(451, 213)
        Me.Emailtxtbx.Name = "Emailtxtbx"
        Me.Emailtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Emailtxtbx.TabIndex = 8
        '
        'Entrenatxtbx
        '
        Me.Entrenatxtbx.Location = New System.Drawing.Point(451, 296)
        Me.Entrenatxtbx.Name = "Entrenatxtbx"
        Me.Entrenatxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Entrenatxtbx.TabIndex = 10
        '
        'Añadirbtn
        '
        Me.Añadirbtn.Location = New System.Drawing.Point(649, 172)
        Me.Añadirbtn.Name = "Añadirbtn"
        Me.Añadirbtn.Size = New System.Drawing.Size(75, 23)
        Me.Añadirbtn.TabIndex = 11
        Me.Añadirbtn.Text = "Añadir"
        Me.Añadirbtn.UseVisualStyleBackColor = True
        '
        'Regresarbtn
        '
        Me.Regresarbtn.Location = New System.Drawing.Point(649, 244)
        Me.Regresarbtn.Name = "Regresarbtn"
        Me.Regresarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Regresarbtn.TabIndex = 12
        Me.Regresarbtn.Text = "Regresar"
        Me.Regresarbtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Regresarbtn)
        Me.Controls.Add(Me.Añadirbtn)
        Me.Controls.Add(Me.Entrenatxtbx)
        Me.Controls.Add(Me.Emailtxtbx)
        Me.Controls.Add(Me.Nombretxtbx)
        Me.Controls.Add(Me.IDtxtbx)
        Me.Controls.Add(Me.Entrenalbl)
        Me.Controls.Add(Me.Emaillbl)
        Me.Controls.Add(Me.Nombrelbl)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents IDlbl As Label
    Friend WithEvents Nombrelbl As Label
    Friend WithEvents Emaillbl As Label
    Friend WithEvents Entrenalbl As Label
    Friend WithEvents IDtxtbx As TextBox
    Friend WithEvents Nombretxtbx As TextBox
    Friend WithEvents Emailtxtbx As TextBox
    Friend WithEvents Entrenatxtbx As TextBox
    Friend WithEvents Añadirbtn As Button
    Friend WithEvents Regresarbtn As Button
End Class
