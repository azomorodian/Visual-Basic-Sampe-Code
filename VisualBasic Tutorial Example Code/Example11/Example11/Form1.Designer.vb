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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(133, 238)
        Me.ListBox1.TabIndex = 0
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(151, 12)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 1
        Me.txtNum.Text = "10"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 205)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "نمايش"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "سري فيبوناچي"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
