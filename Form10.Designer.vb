<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.Problemalbl = New System.Windows.Forms.Label()
        Me.Aceptarbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Problemalbl
        '
        Me.Problemalbl.AutoSize = True
        Me.Problemalbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Problemalbl.Location = New System.Drawing.Point(36, 107)
        Me.Problemalbl.Name = "Problemalbl"
        Me.Problemalbl.Size = New System.Drawing.Size(702, 112)
        Me.Problemalbl.TabIndex = 0
        Me.Problemalbl.Text = resources.GetString("Problemalbl.Text")
        '
        'Aceptarbtn
        '
        Me.Aceptarbtn.Location = New System.Drawing.Point(365, 303)
        Me.Aceptarbtn.Name = "Aceptarbtn"
        Me.Aceptarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Aceptarbtn.TabIndex = 1
        Me.Aceptarbtn.Text = "Aceptar"
        Me.Aceptarbtn.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Aceptarbtn)
        Me.Controls.Add(Me.Problemalbl)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Problemalbl As Label
    Friend WithEvents Aceptarbtn As Button
End Class
