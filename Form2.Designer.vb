<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRadHistrionic = New System.Windows.Forms.RadioButton()
        Me.btnRadBorderline = New System.Windows.Forms.RadioButton()
        Me.btnRadNarcissisme = New System.Windows.Forms.RadioButton()
        Me.MsgInformation = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRadHistrionic)
        Me.GroupBox1.Controls.Add(Me.btnRadBorderline)
        Me.GroupBox1.Controls.Add(Me.btnRadNarcissisme)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trouble de la personnalité"
        '
        'btnRadHistrionic
        '
        Me.btnRadHistrionic.AutoSize = True
        Me.btnRadHistrionic.Location = New System.Drawing.Point(323, 32)
        Me.btnRadHistrionic.Name = "btnRadHistrionic"
        Me.btnRadHistrionic.Size = New System.Drawing.Size(68, 17)
        Me.btnRadHistrionic.TabIndex = 2
        Me.btnRadHistrionic.TabStop = True
        Me.btnRadHistrionic.Text = "Histrionic"
        Me.btnRadHistrionic.UseVisualStyleBackColor = True
        '
        'btnRadBorderline
        '
        Me.btnRadBorderline.AutoSize = True
        Me.btnRadBorderline.Location = New System.Drawing.Point(178, 32)
        Me.btnRadBorderline.Name = "btnRadBorderline"
        Me.btnRadBorderline.Size = New System.Drawing.Size(72, 17)
        Me.btnRadBorderline.TabIndex = 1
        Me.btnRadBorderline.TabStop = True
        Me.btnRadBorderline.Text = "Borderline"
        Me.btnRadBorderline.UseVisualStyleBackColor = True
        '
        'btnRadNarcissisme
        '
        Me.btnRadNarcissisme.AutoSize = True
        Me.btnRadNarcissisme.Location = New System.Drawing.Point(17, 32)
        Me.btnRadNarcissisme.Name = "btnRadNarcissisme"
        Me.btnRadNarcissisme.Size = New System.Drawing.Size(81, 17)
        Me.btnRadNarcissisme.TabIndex = 0
        Me.btnRadNarcissisme.TabStop = True
        Me.btnRadNarcissisme.Text = "Narcissisme"
        Me.btnRadNarcissisme.UseVisualStyleBackColor = True
        '
        'MsgInformation
        '
        Me.MsgInformation.AutoSize = True
        Me.MsgInformation.Location = New System.Drawing.Point(26, 171)
        Me.MsgInformation.Name = "MsgInformation"
        Me.MsgInformation.Size = New System.Drawing.Size(39, 13)
        Me.MsgInformation.TabIndex = 2
        Me.MsgInformation.Text = "Label2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 401)
        Me.Controls.Add(Me.MsgInformation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRadHistrionic As RadioButton
    Friend WithEvents btnRadBorderline As RadioButton
    Friend WithEvents btnRadNarcissisme As RadioButton
    Friend WithEvents MsgInformation As Label
End Class
