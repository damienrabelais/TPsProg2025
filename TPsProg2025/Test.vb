Module Test

    Sub Main()
        Dim n As Integer
        Dim compteur As Double
        ' Saisir avant de rentrer (ou non) dans la boucle !
        'Console.WriteLine("Entrez un nombre (0 pour fin) : ")
        'n = Console.ReadLine()
        n = 1
        While n <> 0   ' boucle de saisie des nombres
            'Console.WriteLine("Le carré vaut : " + (n * n).ToString)
            compteur = compteur + 1
            Console.WriteLine(compteur)
            'Console.WriteLine("Entrez un nombre (0 pour fin) : ")
            'n = Console.ReadLine()
        End While
        Console.WriteLine("n  = 0, au revoir")
        Console.ReadLine()
    End Sub

End Module
