Module Test
    Sub Main()
        Dim choix As Integer
        Do
            Console.WriteLine("1. Travailler")
            Console.WriteLine("2. Parler avec son voisin")
            Console.WriteLine("3. Se reposer")
            Console.WriteLine("4. Dormir")
            Console.WriteLine("5. Quitter")
            Console.WriteLine("Saisissez votre choix")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Console.WriteLine("Continuez !")
                Case 2
                    Console.WriteLine("Il faut vous reconcentrer !")
                Case 3
                    Console.WriteLine("Ce n'est pas le moment.")
                Case 4
                    Console.WriteLine("Debout !")
                Case 5
                    Console.WriteLine("Au revoir.")
                Case Else
                    Console.WriteLine("Erreur de saisie.")
            End Select

        Loop Until choix = 5
        Console.ReadLine()

    End Sub
End Module
