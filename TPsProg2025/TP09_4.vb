Imports System.Runtime.Remoting.Messaging

Module TP09_4

    Sub main()
        Dim vente, total As Double
        Dim noSemaine As Integer
        Dim nomRepresant, reponse As String

        Do
            Console.WriteLine("Nom du représentant ?")
            nomRepresant = Console.ReadLine()
            total = 0
            For noSemaine = 1 To 4
                Do
                    Console.WriteLine("Semaine " + noSemaine.ToString() + ": Ventes H.T hebdomadaires (0 pour stopper la saisie) ?")
                    vente = Console.ReadLine()
                    If vente < 0 Then
                        Console.WriteLine("Ventes ne peuvent être < 0")
                    End If
                Loop Until vente >= 0
                If vente = 0 Then
                    Exit For
                End If
                total = total + vente
            Next
            Console.WriteLine("Total des ventes H.T. = " + total.ToString())
            Console.WriteLine("Commission =  " + (total * 0.1).ToString())

            Do
                Console.WriteLine("Autre représentant (O/N)")
                reponse = Console.ReadLine()
                If reponse <> "O" And reponse <> "N" Then
                    Console.WriteLine("O ou N")
                End If
            Loop Until reponse = "O" Or reponse = "N"

        Loop Until reponse = "N"
        Console.WriteLine("Au revoir.")
        Console.ReadLine()

    End Sub

End Module
