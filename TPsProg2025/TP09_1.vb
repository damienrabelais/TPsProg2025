Module TP09_1
    Sub Main()
        Dim note, nbNotesSup10, nbNotes, somme As Integer
        Dim pourcentage, moyenne As Double
        nbNotes = 0
        nbNotesSup10 = 0
        Console.WriteLine("Entrez une note (-1 pour fin) :")
        note = Console.ReadLine()
        While note <> -1  ' boucle de saisie des notes 
            somme = somme + note
            nbNotes = nbNotes + 1
            If note > 10 Then
                nbNotesSup10 = nbNotesSup10 + 1
            End If
            Console.WriteLine("Entrez une note (-1 pour fin) : ")
            note = Console.ReadLine()
        End While
        pourcentage = (nbNotesSup10 / nbNotes) * 100
        Console.WriteLine("Vous avez " + pourcentage.ToString() + " % de notes > à 10")
        moyenne = somme / nbNotes
        Console.WriteLine("Votre moyenne est de  " + moyenne.ToString())
        Console.ReadLine()
    End Sub
End Module
