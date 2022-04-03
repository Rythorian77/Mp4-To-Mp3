<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Merge
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StartFile = New System.Windows.Forms.Button()
        Me.EndFile = New System.Windows.Forms.Button()
        Me.Coalesce = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label2.Location = New System.Drawing.Point(35, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Source 2:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label3.Location = New System.Drawing.Point(167, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(482, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label4.Location = New System.Drawing.Point(167, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(482, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label5.Location = New System.Drawing.Point(35, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(653, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "*"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StartFile
        '
        Me.StartFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartFile.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.StartFile.Location = New System.Drawing.Point(756, 43)
        Me.StartFile.Name = "StartFile"
        Me.StartFile.Size = New System.Drawing.Size(114, 34)
        Me.StartFile.TabIndex = 5
        Me.StartFile.Text = "Start File"
        Me.StartFile.UseVisualStyleBackColor = True
        '
        'EndFile
        '
        Me.EndFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EndFile.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.EndFile.Location = New System.Drawing.Point(756, 125)
        Me.EndFile.Name = "EndFile"
        Me.EndFile.Size = New System.Drawing.Size(114, 34)
        Me.EndFile.TabIndex = 6
        Me.EndFile.Text = "End File"
        Me.EndFile.UseVisualStyleBackColor = True
        '
        'Coalesce
        '
        Me.Coalesce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Coalesce.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Coalesce.Location = New System.Drawing.Point(756, 217)
        Me.Coalesce.Name = "Coalesce"
        Me.Coalesce.Size = New System.Drawing.Size(114, 34)
        Me.Coalesce.TabIndex = 7
        Me.Coalesce.Text = "Coalesce"
        Me.Coalesce.UseVisualStyleBackColor = True
        '
        'Merge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(892, 270)
        Me.Controls.Add(Me.Coalesce)
        Me.Controls.Add(Me.EndFile)
        Me.Controls.Add(Me.StartFile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Merge"
        Me.Text = "Merge Audio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StartFile As Button
    Friend WithEvents EndFile As Button
    Friend WithEvents Coalesce As Button
End Class
