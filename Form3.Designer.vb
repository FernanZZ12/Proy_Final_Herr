<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.RegresarBtn = New System.Windows.Forms.Button()
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        Me.IDtxtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Titulolbl
        '
        Me.Titulolbl.AutoSize = True
        Me.Titulolbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulolbl.Location = New System.Drawing.Point(272, 39)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(203, 37)
        Me.Titulolbl.TabIndex = 0
        Me.Titulolbl.Text = "Eliminar Cliente"
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(222, 185)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(81, 15)
        Me.IDlbl.TabIndex = 1
        Me.IDlbl.Text = "ID Del Usuario"
        '
        'RegresarBtn
        '
        Me.RegresarBtn.Location = New System.Drawing.Point(606, 207)
        Me.RegresarBtn.Name = "RegresarBtn"
        Me.RegresarBtn.Size = New System.Drawing.Size(75, 23)
        Me.RegresarBtn.TabIndex = 2
        Me.RegresarBtn.Text = "Regresar"
        Me.RegresarBtn.UseVisualStyleBackColor = True
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Location = New System.Drawing.Point(606, 147)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Eliminarbtn.TabIndex = 3
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = True
        '
        'IDtxtbx
        '
        Me.IDtxtbx.Location = New System.Drawing.Point(361, 182)
        Me.IDtxtbx.Name = "IDtxtbx"
        Me.IDtxtbx.Size = New System.Drawing.Size(127, 23)
        Me.IDtxtbx.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IDtxtbx)
        Me.Controls.Add(Me.Eliminarbtn)
        Me.Controls.Add(Me.RegresarBtn)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Titulolbl)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulolbl As Label
    Friend WithEvents IDlbl As Label
    Friend WithEvents RegresarBtn As Button
    Public WithEvents Eliminarbtn As Button
    Friend WithEvents IDtxtbx As TextBox
End Class
