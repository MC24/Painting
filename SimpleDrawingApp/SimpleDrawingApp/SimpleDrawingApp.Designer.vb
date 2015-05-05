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
        Me.pbCanvas = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPenWidth = New System.Windows.Forms.TextBox()
        Me.btnSetWidth = New System.Windows.Forms.Button()
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCanvas
        '
        Me.pbCanvas.Location = New System.Drawing.Point(13, 13)
        Me.pbCanvas.Name = "pbCanvas"
        Me.pbCanvas.Size = New System.Drawing.Size(476, 452)
        Me.pbCanvas.TabIndex = 0
        Me.pbCanvas.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(509, 181)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(182, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear drawing area"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(509, 116)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(182, 23)
        Me.btnColor.TabIndex = 8
        Me.btnColor.Text = "Select pen color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(513, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter a pen width"
        '
        'txtPenWidth
        '
        Me.txtPenWidth.Location = New System.Drawing.Point(516, 40)
        Me.txtPenWidth.Name = "txtPenWidth"
        Me.txtPenWidth.Size = New System.Drawing.Size(91, 20)
        Me.txtPenWidth.TabIndex = 9
        '
        'btnSetWidth
        '
        Me.btnSetWidth.Location = New System.Drawing.Point(613, 40)
        Me.btnSetWidth.Name = "btnSetWidth"
        Me.btnSetWidth.Size = New System.Drawing.Size(75, 23)
        Me.btnSetWidth.TabIndex = 10
        Me.btnSetWidth.Text = "Set width"
        Me.btnSetWidth.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 477)
        Me.Controls.Add(Me.btnSetWidth)
        Me.Controls.Add(Me.txtPenWidth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.pbCanvas)
        Me.Name = "Form1"
        Me.Text = "Simple Drawing App"
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPenWidth As System.Windows.Forms.TextBox
    Friend WithEvents btnSetWidth As System.Windows.Forms.Button

End Class
