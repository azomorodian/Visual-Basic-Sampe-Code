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
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(75, 61)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 0
        Me.txtX.Text = "1"
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(75, 87)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(100, 20)
        Me.txtn.TabIndex = 1
        Me.txtn.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "n"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "S = sinx + sin2x + ... + sinnx"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "P = S=sinx*sin2x * ... * sinnx"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(15, 180)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(195, 20)
        Me.txtResult.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 212)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.txtX)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
