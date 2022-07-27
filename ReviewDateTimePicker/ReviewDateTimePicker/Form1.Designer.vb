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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker8 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker9 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(13, 50)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dddd,dd/MM/yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(13, 89)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 2
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker4.Location = New System.Drawing.Point(13, 128)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.ShowUpDown = True
        Me.DateTimePicker4.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker4.TabIndex = 3
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy - hh:m:s"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(13, 165)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker5.TabIndex = 4
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.CustomFormat = " 'H'ari dddd Pukul hh:m"
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker6.Location = New System.Drawing.Point(13, 201)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker6.TabIndex = 5
        '
        'DateTimePicker7
        '
        Me.DateTimePicker7.Checked = False
        Me.DateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker7.Location = New System.Drawing.Point(13, 239)
        Me.DateTimePicker7.Name = "DateTimePicker7"
        Me.DateTimePicker7.ShowCheckBox = True
        Me.DateTimePicker7.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker7.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "s/d"
        '
        'DateTimePicker8
        '
        Me.DateTimePicker8.Checked = False
        Me.DateTimePicker8.Enabled = False
        Me.DateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker8.Location = New System.Drawing.Point(146, 239)
        Me.DateTimePicker8.Name = "DateTimePicker8"
        Me.DateTimePicker8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker8.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker8.TabIndex = 8
        '
        'DateTimePicker9
        '
        Me.DateTimePicker9.CustomFormat = "'H'ari dddd , Tan'gg'al dd/MM/yyyy Pukul m:ss WIB "
        Me.DateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker9.Location = New System.Drawing.Point(13, 276)
        Me.DateTimePicker9.Name = "DateTimePicker9"
        Me.DateTimePicker9.Size = New System.Drawing.Size(310, 20)
        Me.DateTimePicker9.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 308)
        Me.Controls.Add(Me.DateTimePicker9)
        Me.Controls.Add(Me.DateTimePicker8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker7)
        Me.Controls.Add(Me.DateTimePicker6)
        Me.Controls.Add(Me.DateTimePicker5)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form1"
        Me.Text = "Apriyandi_19421284"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker7 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker8 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker9 As System.Windows.Forms.DateTimePicker

End Class
