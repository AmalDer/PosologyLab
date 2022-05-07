Imports System.Data.OleDb
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        'Le clique sur l'image, renvoie vers l'interface de présentation générale des pathologies 
    End Sub
End Class