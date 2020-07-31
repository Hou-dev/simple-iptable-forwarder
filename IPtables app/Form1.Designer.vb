<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IPTables
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Generate = New System.Windows.Forms.Button()
        Me.OutputBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DestBox = New System.Windows.Forms.TextBox()
        Me.Dest = New System.Windows.Forms.Label()
        Me.PortBox = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProtocolBox = New System.Windows.Forms.TextBox()
        Me.Protocol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Generate
        '
        Me.Generate.Location = New System.Drawing.Point(551, 139)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(140, 69)
        Me.Generate.TabIndex = 0
        Me.Generate.Text = "Generate"
        Me.Generate.UseVisualStyleBackColor = True
        '
        'OutputBox
        '
        Me.OutputBox.Location = New System.Drawing.Point(12, 116)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(533, 96)
        Me.OutputBox.TabIndex = 1
        Me.OutputBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Output"
        '
        'DestBox
        '
        Me.DestBox.Location = New System.Drawing.Point(15, 28)
        Me.DestBox.Name = "DestBox"
        Me.DestBox.Size = New System.Drawing.Size(225, 20)
        Me.DestBox.TabIndex = 3
        '
        'Dest
        '
        Me.Dest.AutoSize = True
        Me.Dest.Location = New System.Drawing.Point(12, 12)
        Me.Dest.Name = "Dest"
        Me.Dest.Size = New System.Drawing.Size(73, 13)
        Me.Dest.TabIndex = 4
        Me.Dest.Text = "Destination IP"
        '
        'PortBox
        '
        Me.PortBox.Location = New System.Drawing.Point(246, 28)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(299, 65)
        Me.PortBox.TabIndex = 5
        Me.PortBox.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ports"
        '
        'ProtocolBox
        '
        Me.ProtocolBox.Location = New System.Drawing.Point(15, 73)
        Me.ProtocolBox.Name = "ProtocolBox"
        Me.ProtocolBox.Size = New System.Drawing.Size(70, 20)
        Me.ProtocolBox.TabIndex = 7
        '
        'Protocol
        '
        Me.Protocol.AutoSize = True
        Me.Protocol.Location = New System.Drawing.Point(12, 57)
        Me.Protocol.Name = "Protocol"
        Me.Protocol.Size = New System.Drawing.Size(46, 13)
        Me.Protocol.TabIndex = 8
        Me.Protocol.Text = "Protocol"
        '
        'IPTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 220)
        Me.Controls.Add(Me.Protocol)
        Me.Controls.Add(Me.ProtocolBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.Dest)
        Me.Controls.Add(Me.DestBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.Generate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IPTables"
        Me.ShowIcon = False
        Me.Text = "IPTables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Generate As Button
    Friend WithEvents OutputBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DestBox As TextBox
    Friend WithEvents Dest As Label
    Friend WithEvents PortBox As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProtocolBox As TextBox
    Friend WithEvents Protocol As Label
End Class
