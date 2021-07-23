<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Nombrelbl = New System.Windows.Forms.Label()
        Me.Correolbl = New System.Windows.Forms.Label()
        Me.Correotxtbx = New System.Windows.Forms.TextBox()
        Me.Nombretxtbx = New System.Windows.Forms.TextBox()
        Me.IDtxtbx = New System.Windows.Forms.TextBox()
        Me.RegresarBtn = New System.Windows.Forms.Button()
        Me.AñadirBtn = New System.Windows.Forms.Button()
        Me.Titulolbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(225, 155)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(79, 15)
        Me.IDlbl.TabIndex = 0
        Me.IDlbl.Text = "Identificación"
        '
        'Nombrelbl
        '
        Me.Nombrelbl.AutoSize = True
        Me.Nombrelbl.Location = New System.Drawing.Point(225, 228)
        Me.Nombrelbl.Name = "Nombrelbl"
        Me.Nombrelbl.Size = New System.Drawing.Size(51, 15)
        Me.Nombrelbl.TabIndex = 1
        Me.Nombrelbl.Text = "Nombre"
        '
        'Correolbl
        '
        Me.Correolbl.AutoSize = True
        Me.Correolbl.Location = New System.Drawing.Point(225, 306)
        Me.Correolbl.Name = "Correolbl"
        Me.Correolbl.Size = New System.Drawing.Size(43, 15)
        Me.Correolbl.TabIndex = 2
        Me.Correolbl.Text = "Correo"
        '
        'Correotxtbx
        '
        Me.Correotxtbx.Location = New System.Drawing.Point(369, 306)
        Me.Correotxtbx.Name = "Correotxtbx"
        Me.Correotxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Correotxtbx.TabIndex = 3
        '
        'Nombretxtbx
        '
        Me.Nombretxtbx.Location = New System.Drawing.Point(369, 220)
        Me.Nombretxtbx.Name = "Nombretxtbx"
        Me.Nombretxtbx.Size = New System.Drawing.Size(100, 23)
        Me.Nombretxtbx.TabIndex = 4
        '
        'IDtxtbx
        '
        Me.IDtxtbx.Location = New System.Drawing.Point(369, 147)
        Me.IDtxtbx.Name = "IDtxtbx"
        Me.IDtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.IDtxtbx.TabIndex = 5
        '
        'RegresarBtn
        '
        Me.RegresarBtn.Location = New System.Drawing.Point(582, 255)
        Me.RegresarBtn.Name = "RegresarBtn"
        Me.RegresarBtn.Size = New System.Drawing.Size(75, 23)
        Me.RegresarBtn.TabIndex = 6
        Me.RegresarBtn.Text = "Regresar"
        Me.RegresarBtn.UseVisualStyleBackColor = True
        '
        'AñadirBtn
        '
        Me.AñadirBtn.Location = New System.Drawing.Point(582, 192)
        Me.AñadirBtn.Name = "AñadirBtn"
        Me.AñadirBtn.Size = New System.Drawing.Size(75, 23)
        Me.AñadirBtn.TabIndex = 7
        Me.AñadirBtn.Text = "Añadir"
        Me.AñadirBtn.UseVisualStyleBackColor = True
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(278, 44)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(258, 37)
        Me.Titulolbl.TabIndex = 8
        Me.Titulolbl.Text = "Añadir Entrenadores"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Titulolbl)
        Me.Controls.Add(Me.AñadirBtn)
        Me.Controls.Add(Me.RegresarBtn)
        Me.Controls.Add(Me.IDtxtbx)
        Me.Controls.Add(Me.Nombretxtbx)
        Me.Controls.Add(Me.Correotxtbx)
        Me.Controls.Add(Me.Correolbl)
        Me.Controls.Add(Me.Nombrelbl)
        Me.Controls.Add(Me.IDlbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDlbl As Label
    Friend WithEvents Nombrelbl As Label
    Friend WithEvents Correolbl As Label
    Friend WithEvents Correotxtbx As TextBox
    Friend WithEvents Nombretxtbx As TextBox
    Friend WithEvents IDtxtbx As TextBox
    Friend WithEvents RegresarBtn As Button
    Friend WithEvents AñadirBtn As Button
    Friend WithEvents Titulolbl As Label
End Class
