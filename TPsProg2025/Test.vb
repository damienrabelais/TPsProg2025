Module Test

    Function PérimètreCercle(ByVal pRayon As Double) As Double
        Dim perimetre As Double
        perimetre = 2 * Math.PI * pRayon
        Return perimetre
        'Return 2 * Math.PI * pRayon
    End Function



    Sub Main() ' Programme principal
        Dim choix As Integer
        Dim rayon As Double
        Do
            Console.WriteLine("1. Calcul du périmètre d'un cercle.")
            Console.WriteLine("2. Calcul de la surface d'un cercle.")
            Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
            Console.WriteLine("4. Calcul de la surface d'un rectangle.")
            Console.WriteLine("5. Quitter.")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()

            Select Case choix
                Case 1
                    Console.WriteLine("1. Calcul du périmètre d'un cercle.")
                    Do
                        Console.WriteLine("Rayon ?")
                        rayon = Console.ReadLine()
                        If rayon <= 0 Then
                            Console.WriteLine("Rayon > 0")
                        End If
                    Loop Until rayon > 0
                    Console.WriteLine("Périmètre: " + PérimètreCercle(rayon).ToString())
                Case 2
                    Console.WriteLine("2. Calcul de la surface d'un cercle.")
                Case 5
                    Console.WriteLine("Au revoir")
                Case Else
                    Console.WriteLine("Erreur de saisie")
            End Select
        Loop Until choix = 5


        Console.ReadLine()
    End Sub ' Fin du main
End Module
