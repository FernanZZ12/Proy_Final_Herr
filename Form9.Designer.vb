<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.PClbl = New System.Windows.Forms.Label()
        Me.Userlbl = New System.Windows.Forms.Label()
        Me.Presentlbl = New System.Windows.Forms.Label()
        Me.Sigbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PClbl
        '
        Me.PClbl.AutoSize = True
        Me.PClbl.Location = New System.Drawing.Point(142, 132)
        Me.PClbl.Name = "PClbl"
        Me.PClbl.Size = New System.Drawing.Size(41, 15)
        Me.PClbl.TabIndex = 0
        Me.PClbl.Text = "Label1"
        '
        'Userlbl
        '
        Me.Userlbl.AutoSize = True
        Me.Userlbl.Location = New System.Drawing.Point(142, 223)
        Me.Userlbl.Name = "Userlbl"
        Me.Userlbl.Size = New System.Drawing.Size(41, 15)
        Me.Userlbl.TabIndex = 1
        Me.Userlbl.Text = "Label2"
        '
        'Presentlbl
        '
        Me.Presentlbl.AutoSize = True
        Me.Presentlbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Presentlbl.Location = New System.Drawing.Point(242, 6)
        Me.Presentlbl.Name = "Presentlbl"
        Me.Presentlbl.Size = New System.Drawing.Size(284, 435)
        Me.Presentlbl.TabIndex = 2
        Me.Presentlbl.Text = resources.GetString("Presentlbl.Text")
        '
        'Sigbtn
        '
        Me.Sigbtn.Location = New System.Drawing.Point(649, 196)
        Me.Sigbtn.Name = "Sigbtn"
        Me.Sigbtn.Size = New System.Drawing.Size(75, 23)
        Me.Sigbtn.TabIndex = 3
        Me.Sigbtn.Text = "Siguiente"
        Me.Sigbtn.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Sigbtn)
        Me.Controls.Add(Me.Presentlbl)
        Me.Controls.Add(Me.Userlbl)
        Me.Controls.Add(Me.PClbl)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PClbl As Label
    Friend WithEvents Userlbl As Label
    Friend WithEvents Presentlbl As Label
    Friend WithEvents Sigbtn As Button
End Class
