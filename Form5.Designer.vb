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
        Me.IDUlbl = New System.Windows.Forms.Label()
        Me.IDElbl = New System.Windows.Forms.Label()
        Me.IDUtxtbx = New System.Windows.Forms.TextBox()
        Me.IDEtxtbx = New System.Windows.Forms.TextBox()
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.RegresarBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(265, 41)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(255, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Cambiar Entrenador"
        '
        'IDUlbl
        '
        Me.IDUlbl.AutoSize = True
        Me.IDUlbl.Location = New System.Drawing.Point(265, 144)
        Me.IDUlbl.Name = "IDUlbl"
        Me.IDUlbl.Size = New System.Drawing.Size(80, 15)
        Me.IDUlbl.TabIndex = 1
        Me.IDUlbl.Text = "ID del Usuario"
        '
        'IDElbl
        '
        Me.IDElbl.AutoSize = True
        Me.IDElbl.Location = New System.Drawing.Point(265, 253)
        Me.IDElbl.Name = "IDElbl"
        Me.IDElbl.Size = New System.Drawing.Size(99, 15)
        Me.IDElbl.TabIndex = 2
        Me.IDElbl.Text = "ID Del Entrenador"
        '
        'IDUtxtbx
        '
        Me.IDUtxtbx.Location = New System.Drawing.Point(438, 136)
        Me.IDUtxtbx.Name = "IDUtxtbx"
        Me.IDUtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.IDUtxtbx.TabIndex = 3
        '
        'IDEtxtbx
        '
        Me.IDEtxtbx.Location = New System.Drawing.Point(438, 250)
        Me.IDEtxtbx.Name = "IDEtxtbx"
        Me.IDEtxtbx.Size = New System.Drawing.Size(100, 23)
        Me.IDEtxtbx.TabIndex = 4
        '
        'ModificarBtn
        '
        Me.ModificarBtn.Location = New System.Drawing.Point(651, 159)
        Me.ModificarBtn.Name = "ModificarBtn"
        Me.ModificarBtn.Size = New System.Drawing.Size(75, 23)
        Me.ModificarBtn.TabIndex = 5
        Me.ModificarBtn.Text = "Modificar"
        Me.ModificarBtn.UseVisualStyleBackColor = True
        '
        'RegresarBtn
        '
        Me.RegresarBtn.Location = New System.Drawing.Point(651, 222)
        Me.RegresarBtn.Name = "RegresarBtn"
        Me.RegresarBtn.Size = New System.Drawing.Size(75, 23)
        Me.RegresarBtn.TabIndex = 6
        Me.RegresarBtn.Text = "Regresar"
        Me.RegresarBtn.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RegresarBtn)
        Me.Controls.Add(Me.ModificarBtn)
        Me.Controls.Add(Me.IDEtxtbx)
        Me.Controls.Add(Me.IDUtxtbx)
        Me.Controls.Add(Me.IDElbl)
        Me.Controls.Add(Me.IDUlbl)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents IDUlbl As Label
    Friend WithEvents IDElbl As Label
    Friend WithEvents IDUtxtbx As TextBox
    Friend WithEvents IDEtxtbx As TextBox
    Friend WithEvents ModificarBtn As Button
    Friend WithEvents RegresarBtn As Button
End Class
