Public Class Form3
    Public SymptomeNarcissisme() As String = {"Avoir un sens grandiose de son importance (exagération des réalisations, des talents, attente à être reconnu(e) comme étant supérieur, sans réussites proportionnées.", "Ettre absorbé(e) par des fantaisies de succès illimité, de pouvoir, de splendeur, de beauté ou d’amour idéal.", "Croire être spécial et unique et ne pouvant être admis ou compris que par des institutions ou des gens spéciaux et de haut niveau.", "Besoin excessif d’être admiré.", "Penser que tout lui est dû: Attente sans raison à bénéficier d’un traitement particulièrement favorable et à ce que ses désirs soient automatiquement satisfaits.", "Exploitatio l’autre dans les relations interpersonnelles: utilisation d'autrui pour parvenir à ses propres fins.", "Manque d’empathie, peu de disposition ou réticence à reconnaître ou à identifier les sentiments ou les besoins des autres.", "Etre souvent envieux des autres ou croire que les autres l’envient.", "Faire preuve d’attitudes et de comportements arrogants et hautains."}
    Public SymptomeBorderline() As String = {"Efforts effrénés pour éviter les abandons réels ou imaginés.", "Un modèle d’instabilité et d’intensité dans les relations interpersonnelles caractérisé par l’alternance entre des positions extrêmes d’idéalisation excessive et de dévalorisation.", "Trouble d’identité et d’instabilité persistante de l’image et de la notion de soi.", "Impulsivité dans au moins 2 secteurs potentiellement préjudiciables pour la personne : dépenses, sexe, abus de substance, conduite dangereuse, boulimie …", "Comportement suicidaire récurrent, gestes ou menaces, comportement d’auto-mutilation.", "Instabilité affective due à une réactivité marquée de l’humeur. (Épisode intense de dysphorie, irritabilité, une anxiété qui dure habituellement quelques heures et rarement plus que quelques jours).", "Sentiments chroniques de vide.", "Colères intenses ou inappropriées ou difficulté à contrôler sa colère (manifestations fréquentes de tempérament, colères constantes, batailles physiques récurrentes.", "Survenue transitoire dans des situations de stress d’une idéation persécutoire ou de symptômes dissociatifs sévères."}
    Public SymptomeHistrionic() As String = {"Inconfort dans les situations où ces individus ne sont pas le centre d’attention.", "L’interaction avec les autres est souvent caractérisée par une séduction inappropriée.", "Expression émotionnelle superficielle et rapidement changeante.", "Utilisent régulièrement leur apparence pour attirer l’attention sur eux.", "Manière de parler trop subjective mais pauvre en détails.", "Montrent de l’auto-dramatisation, de la théâtralité et une expression exagérée d’émotions.", "Suggestibilité, ils sont facilement influencés par autrui ou par les circonstances.", "Considèrent les relations plus intimes qu’elles ne le sont en réalité."}
    Public n As String
    Public s As String
    Public d As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1

        'ajouter à la liste les symptomes relatifs aux 3 pathologies affichés avec un ordre aléatoire
        'j'ai préféré les ajouter manuellement au lieu d'utiliser une boucle pour les ajouter de façon aléatoire
        ListSAffiche.Items.Add(SymptomeNarcissisme(0))
        ListSAffiche.Items.Add(SymptomeNarcissisme(1))
        ListSAffiche.Items.Add(SymptomeBorderline(0))
        ListSAffiche.Items.Add(SymptomeBorderline(1))
        ListSAffiche.Items.Add(SymptomeHistrionic(0))
        ListSAffiche.Items.Add(SymptomeNarcissisme(2))
        ListSAffiche.Items.Add(SymptomeHistrionic(1))
        ListSAffiche.Items.Add(SymptomeHistrionic(2))
        ListSAffiche.Items.Add(SymptomeBorderline(2))
        ListSAffiche.Items.Add(SymptomeNarcissisme(3))
        ListSAffiche.Items.Add(SymptomeBorderline(3))
        ListSAffiche.Items.Add(SymptomeBorderline(4))
        ListSAffiche.Items.Add(SymptomeHistrionic(3))
        ListSAffiche.Items.Add(SymptomeNarcissisme(4))
        ListSAffiche.Items.Add(SymptomeNarcissisme(5))
        ListSAffiche.Items.Add(SymptomeNarcissisme(6))
        ListSAffiche.Items.Add(SymptomeBorderline(5))
        ListSAffiche.Items.Add(SymptomeHistrionic(4))
        ListSAffiche.Items.Add(SymptomeHistrionic(5))
        ListSAffiche.Items.Add(SymptomeBorderline(6))
        ListSAffiche.Items.Add(SymptomeNarcissisme(7))
        ListSAffiche.Items.Add(SymptomeBorderline(7))
        ListSAffiche.Items.Add(SymptomeNarcissisme(8))
        ListSAffiche.Items.Add(SymptomeBorderline(8))
        ListSAffiche.Items.Add(SymptomeHistrionic(6))
        ListSAffiche.Items.Add(SymptomeHistrionic(7))

        n = txtNom.Text 'on donne à n le nom saisi pour l'utiliser ultérieurement dans la BD
        If btnRadFem.Checked = True Then
            s = "Féminin"
        ElseIf btnRadMas.Checked = True Then
            s = "Masculin"
            'on donne à s le sexe choisi pour l'utiliser ultérieurement dans la BD
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim i As Integer
        For i = 0 To ListSAffiche.SelectedItems.Count - 1
            ListSSelectionne.Items.Add(ListSAffiche.SelectedItems.Item(i))
            ListSAffiche.Items.Remove(ListSAffiche.SelectedItems.Item(i))
        Next
        ListSAffiche.SelectedIndex = -1


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim i As Integer
        For i = 0 To ListSSelectionne.SelectedItems.Count - 1
            ListSAffiche.Items.Add(ListSSelectionne.SelectedItems.Item(i))
            ListSSelectionne.Items.Remove(ListSSelectionne.SelectedItems.Item(i))
        Next
        ListSSelectionne.SelectedIndex = -1

    End Sub

    Private Sub btnDiagnostique_Click(sender As Object, e As EventArgs) Handles btnDiagnostique.Click
        If (btnRadFem.Checked = True Or btnRadMas.Checked = True) And txtNom.Text <> "" Then
            Form4.Show()
            Dim j As Integer
            Dim a As String
            Dim k1 As Integer
            Dim k2 As Integer
            Dim k3 As Integer
            k1 = 0
            k2 = 0
            k3 = 0
            For Each a In SymptomeNarcissisme
                For j = 0 To ListSSelectionne.Items.Count - 1

                    If ListSSelectionne.Items.Item(j) = a Then
                        k1 += 1
                    End If
                Next
            Next

            For Each a In SymptomeBorderline
                For j = 0 To ListSSelectionne.Items.Count - 1

                    If ListSSelectionne.Items.Item(j) = a Then
                        k2 += 1
                    End If
                Next
            Next

            For Each a In SymptomeHistrionic
                For j = 0 To ListSSelectionne.Items.Count - 1

                    If ListSSelectionne.Items.Item(j) = a Then
                        k3 += 1
                    End If
                Next
            Next


            If k1 >= 5 And k2 < 5 And k3 < 5 Then
                Form4.LabelEtat.Text = "Narcissisme confirmé"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("C:\Users\amald\source\repos\DEROUICH Amal\Narcissique.jpg")
            ElseIf k2 >= 5 And k1 < 5 And k3 < 5 Then
                Form4.LabelEtat.Text = "Borderline confirmé"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("‪C:\Users\amald\source\repos\DEROUICH Amal\Borderline.jpg")
            ElseIf k3 >= 5 And k1 < 5 And k2 < 5 Then
                Form4.LabelEtat.Text = "Histrionic confirmé"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("‪C:\Users\amald\source\repos\DEROUICH Amal\Histrionic.jpeg")
            ElseIf k1 >= 5 And k2 >= 5 And k3 < 5 Then
                Form4.LabelEtat.Text = "Comorbidité: Narcissisme et borderline"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("C:\Users\amald\source\repos\DEROUICH Amal\Comorbidite.gif")
            ElseIf k1 >= 5 And k3 >= 5 And k2 < 5 Then
                Form4.LabelEtat.Text = "Comorbidité: Narcissisme et Histrionic"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("C:\Users\amald\source\repos\DEROUICH Amal\Comorbidite.gif")
            ElseIf k2 >= 5 And k3 >= 5 And k1 < 5 Then
                Form4.LabelEtat.Text = "Comorbidité: Borderline et Histrionic"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("C:\Users\amald\source\repos\DEROUICH Amal\Comorbidite.gif")
            ElseIf k2 < 5 And k1 < 5 And k3 < 5 Then
                Form4.LabelEtat.Text = "Diagnostic négatif"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("C:\Users\amald\source\repos\DEROUICH Amal\DiagNeg.jpg")
            ElseIf k2 >= 5 And k1 >= 5 And k3 >= 5 Then
                Form4.LabelEtat.Text = "Comorbidité: Narcissisme, Borderline et Histrionic"
                d = Form4.LabelEtat.Text
                Form4.PictureBox1.Image = Image.FromFile("C:\Users\amald\source\repos\DEROUICH Amal\Comorbidite.gif")
            End If
            'la variable d contient l'état du diagnostique pour l'utiliser ultérieurement dans la BD
        Else
            MsgBox("Attention! Complétez vos informations s'il-vous-plait!")
        End If
    End Sub
End Class