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
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.txtm = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(191, 43)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(45, 20)
        Me.txtn.TabIndex = 0
        '
        'txtm
        '
        Me.txtm.Location = New System.Drawing.Point(191, 69)
        Me.txtm.Name = "txtm"
        Me.txtm.Size = New System.Drawing.Size(45, 20)
        Me.txtm.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(552, 131)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 178
        Me.LineShape1.X2 = 194
        Me.LineShape1.Y1 = 33
        Me.LineShape1.Y2 = 33
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 178
        Me.LineShape2.X2 = 177
        Me.LineShape2.Y1 = 34
        Me.LineShape2.Y2 = 98
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 177
        Me.LineShape3.X2 = 193
        Me.LineShape3.Y1 = 99
        Me.LineShape3.Y2 = 99
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 245
        Me.LineShape4.X2 = 244
        Me.LineShape4.Y1 = 34
        Me.LineShape4.Y2 = 98
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 227
        Me.LineShape5.X2 = 243
        Me.LineShape5.Y1 = 99
        Me.LineShape5.Y2 = 99
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 228
        Me.LineShape6.X2 = 244
        Me.LineShape6.Y1 = 33
        Me.LineShape6.Y2 = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 73)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "m"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "n"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 73)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(266, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 73)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "="
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(342, 59)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(448, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 102)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 131)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtm)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents txtm As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
