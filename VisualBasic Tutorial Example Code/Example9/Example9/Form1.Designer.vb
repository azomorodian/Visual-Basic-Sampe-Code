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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBMM = New System.Windows.Forms.TextBox()
        Me.txtKMM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(271, 15)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        Me.txtNum1.Text = "78"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(271, 41)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        Me.txtNum2.Text = "24"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(377, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "عدد اول"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "عدد دوم"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ب.م.م"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ک.م.م"
        '
        'txtBMM
        '
        Me.txtBMM.Location = New System.Drawing.Point(12, 18)
        Me.txtBMM.Name = "txtBMM"
        Me.txtBMM.Size = New System.Drawing.Size(100, 20)
        Me.txtBMM.TabIndex = 7
        '
        'txtKMM
        '
        Me.txtKMM.Location = New System.Drawing.Point(12, 44)
        Me.txtKMM.Name = "txtKMM"
        Me.txtKMM.Size = New System.Drawing.Size(100, 20)
        Me.txtKMM.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 81)
        Me.Controls.Add(Me.txtKMM)
        Me.Controls.Add(Me.txtBMM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "Form1"
        Me.Text = "محاسبه بزرگترين مقسوم عليه مشترک و کوچکترين مضرب مشترک"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBMM As System.Windows.Forms.TextBox
    Friend WithEvents txtKMM As System.Windows.Forms.TextBox

End Class
