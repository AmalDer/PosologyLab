<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRadFem = New System.Windows.Forms.RadioButton()
        Me.btnRadMas = New System.Windows.Forms.RadioButton()
        Me.ListSAffiche = New System.Windows.Forms.ListBox()
        Me.ListSSelectionne = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnDiagnostique = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(70, 22)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(152, 20)
        Me.txtNom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date de naissance"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(407, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRadFem)
        Me.GroupBox1.Controls.Add(Me.btnRadMas)
        Me.GroupBox1.Location = New System.Drawing.Point(153, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 48)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexe"
        '
        'btnRadFem
        '
        Me.btnRadFem.AutoSize = True
        Me.btnRadFem.Location = New System.Drawing.Point(155, 19)
        Me.btnRadFem.Name = "btnRadFem"
        Me.btnRadFem.Size = New System.Drawing.Size(61, 17)
        Me.btnRadFem.TabIndex = 1
        Me.btnRadFem.TabStop = True
        Me.btnRadFem.Text = "Féminin"
        Me.btnRadFem.UseVisualStyleBackColor = True
        '
        'btnRadMas
        '
        Me.btnRadMas.AutoSize = True
        Me.btnRadMas.Location = New System.Drawing.Point(22, 19)
        Me.btnRadMas.Name = "btnRadMas"
        Me.btnRadMas.Size = New System.Drawing.Size(67, 17)
        Me.btnRadMas.TabIndex = 0
        Me.btnRadMas.TabStop = True
        Me.btnRadMas.Text = "Masculin"
        Me.btnRadMas.UseVisualStyleBackColor = True
        '
        'ListSAffiche
        '
        Me.ListSAffiche.FormattingEnabled = True
        Me.ListSAffiche.Location = New System.Drawing.Point(12, 216)
        Me.ListSAffiche.Name = "ListSAffiche"
        Me.ListSAffiche.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListSAffiche.Size = New System.Drawing.Size(336, 147)
        Me.ListSAffiche.TabIndex = 5
        '
        'ListSSelectionne
        '
        Me.ListSSelectionne.FormattingEnabled = True
        Me.ListSSelectionne.Location = New System.Drawing.Point(435, 216)
        Me.ListSSelectionne.Name = "ListSSelectionne"
        Me.ListSSelectionne.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListSSelectionne.Size = New System.Drawing.Size(223, 147)
        Me.ListSSelectionne.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(354, 255)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = ">>>>>>"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(354, 299)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "<<<<<<"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnDiagnostique
        '
        Me.btnDiagnostique.Location = New System.Drawing.Point(293, 394)
        Me.btnDiagnostique.Name = "btnDiagnostique"
        Me.btnDiagnostique.Size = New System.Drawing.Size(136, 31)
        Me.btnDiagnostique.TabIndex = 9
        Me.btnDiagnostique.Text = "Diagnostique"
        Me.btnDiagnostique.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 450)
        Me.Controls.Add(Me.btnDiagnostique)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListSSelectionne)
        Me.Controls.Add(Me.ListSAffiche)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNom)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRadFem As RadioButton
    Friend WithEvents btnRadMas As RadioButton
    Friend WithEvents ListSAffiche As ListBox
    Friend WithEvents ListSSelectionne As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnDiagnostique As Button
End Class
