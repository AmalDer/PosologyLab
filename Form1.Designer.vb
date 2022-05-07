<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionPresentation = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOptionFeuillePresentation = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionDiagnostique = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOptionFeuilleDiagnostique = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionPresentation, Me.OptionDiagnostique})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionPresentation
        '
        Me.OptionPresentation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SOptionFeuillePresentation, Me.QuitterToolStripMenuItem})
        Me.OptionPresentation.Name = "OptionPresentation"
        Me.OptionPresentation.Size = New System.Drawing.Size(219, 20)
        Me.OptionPresentation.Text = "&Présentation générale des pathologies"
        Me.OptionPresentation.ToolTipText = "Charger Form2"
        '
        'SOptionFeuillePresentation
        '
        Me.SOptionFeuillePresentation.Name = "SOptionFeuillePresentation"
        Me.SOptionFeuillePresentation.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.SOptionFeuillePresentation.Size = New System.Drawing.Size(239, 22)
        Me.SOptionFeuillePresentation.Text = "Feuille de présentation"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'OptionDiagnostique
        '
        Me.OptionDiagnostique.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SOptionFeuilleDiagnostique, Me.QuitterToolStripMenuItem1})
        Me.OptionDiagnostique.Name = "OptionDiagnostique"
        Me.OptionDiagnostique.Size = New System.Drawing.Size(89, 20)
        Me.OptionDiagnostique.Text = "&Diagnostique"
        Me.OptionDiagnostique.ToolTipText = "Charger Form3"
        '
        'SOptionFeuilleDiagnostique
        '
        Me.SOptionFeuilleDiagnostique.Name = "SOptionFeuilleDiagnostique"
        Me.SOptionFeuilleDiagnostique.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.SOptionFeuilleDiagnostique.Size = New System.Drawing.Size(242, 22)
        Me.SOptionFeuilleDiagnostique.Text = "Feuille de diagnostique"
        '
        'QuitterToolStripMenuItem1
        '
        Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
        Me.QuitterToolStripMenuItem1.Size = New System.Drawing.Size(242, 22)
        Me.QuitterToolStripMenuItem1.Text = "Quitter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionPresentation As ToolStripMenuItem
    Friend WithEvents SOptionFeuillePresentation As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionDiagnostique As ToolStripMenuItem
    Friend WithEvents SOptionFeuilleDiagnostique As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem1 As ToolStripMenuItem
End Class
