<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btn_1
        '
        Me.btn_1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_1.Location = New System.Drawing.Point(33, 25)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(94, 29)
        Me.btn_1.TabIndex = 0
        Me.btn_1.Text = "Click me"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Location = New System.Drawing.Point(212, 157)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(123, 20)
        Me.lbl_1.TabIndex = 1
        Me.lbl_1.Text = "Nice to meet you"
        Me.lbl_1.Visible = False
        '
        'btn_2
        '
        Me.btn_2.Location = New System.Drawing.Point(21, 268)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(128, 29)
        Me.btn_2.TabIndex = 2
        Me.btn_2.Text = "Change color"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Location = New System.Drawing.Point(443, 25)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(94, 29)
        Me.btn_3.TabIndex = 3
        Me.btn_3.Text = "Click me 3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(485, 193)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "checkme"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(473, 281)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(125, 24)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Checkme after"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.btn_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_1 As Button
    Friend WithEvents lbl_1 As Label
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
End Class
