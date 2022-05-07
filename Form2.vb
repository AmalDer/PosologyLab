Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub btnRadNarcissisme_CheckedChanged(sender As Object, e As EventArgs) Handles btnRadNarcissisme.CheckedChanged
        MsgInformation.Text = "Les individus qui ont une personnalité narcissique ont habituellement un besoin
excessif d’être admirés. Leur estime d’eux-mêmes est en règle générale très
fragile. Ils envient souvent les autres et peuvent être jaloux du succès ou
des biens des autres pensant qu’eux-mêmes seraient plus dignes de ces
réalisations, de cette gloire et de ces privilèges. Leur attitude est
souvent arrogante, méprisante ou condescendante."
    End Sub

    Private Sub btnRadBorderline_CheckedChanged(sender As Object, e As EventArgs) Handles btnRadBorderline.CheckedChanged
        MsgInformation.Text = "Le trouble de la personnalité limite (ou borderline) est caractérisé par des
émotions intenses, des comportements impulsifs et une instabilité de l'identité
et des relations. Mode général d'instabilité dans les relations interpersonnelles
avec une image de soi déformée et une impulsivité marquée. Ces caractéristiques
sont présentes dès l'âge adulte et dans des contextes divers. Les femmes sont
d’avantages affectées par cette maladie. Les symptômes sont très variés et
peuvent aller jusqu'à la psychose."
    End Sub

    Private Sub btnRadHistrionic_CheckedChanged(sender As Object, e As EventArgs) Handles btnRadHistrionic.CheckedChanged
        MsgInformation.Text = "L'histrionique souffre généralement d'un manque d'introspection, d'un besoin de
valorisation narcissique de la part d'autrui, d'émotivité excessive et donc
d'un manque de rationalisation. L'objectif thérapeutique principal est donc
de rehausser l'image de soi et d'apprendre au patient à analyser rationnellement
les situations plutôt qu'intuitivement ou affectivement. Le risque réel de suicide
est inconnu mais l’expérience clinique suggère que ces individus présentent un
risque accru de gestes ou de menaces suicidaires dont le but est d’obtenir plus
d’attention ou de soin."
    End Sub
End Class