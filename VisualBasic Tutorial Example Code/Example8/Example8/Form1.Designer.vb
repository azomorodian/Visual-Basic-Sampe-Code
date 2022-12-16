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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtm = New System.Windows.Forms.TextBox()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Power"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtm
        '
        Me.txtm.Location = New System.Drawing.Point(11, 12)
        Me.txtm.Name = "txtm"
        Me.txtm.Size = New System.Drawing.Size(36, 20)
        Me.txtm.TabIndex = 1
        Me.txtm.Text = "3"
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(73, 12)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(38, 20)
        Me.txtn.TabIndex = 2
        Me.txtn.Text = "4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "="
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(148, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(43, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "^"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 54)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.txtm)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtm As System.Windows.Forms.TextBox
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
