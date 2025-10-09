Module Test
    Const C As Double = 300000

    Function DilatationDuTemps(ByVal pDureeFusee As Double, ByVal pVitesseFusee As Double) As Double
        Dim resultat As Double
        resultat = pDureeFusee / Math.Sqrt(1 - pVitesseFusee ^ 2 / C ^ 2)
        Return resultat
    End Function


    Sub Main()
        Dim vitesseFusée, duréeFusée As Double
        Dim choix As Integer
        Do
            Console.WriteLine("1. La dilatation du temps")
            Console.WriteLine("2. La contraction des longueurs")
            Console.WriteLine("3. Loi de composition des vitesses")
            Console.WriteLine("4. Quitter")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?)")
                        vitesseFusée = Console.ReadLine()
                        If vitesseFusée <= 0 Then
                            Console.WriteLine("Vitesse de la fusée > 0")
                        End If
                    Loop Until vitesseFusée > 0
                    Do
                        Console.WriteLine("Durée écoulée dans la fusée (en secondes) ?")
                        duréeFusée = Console.ReadLine()
                        If duréeFusée <= 0 Then
                            Console.WriteLine("Durée > 0")
                        End If
                    Loop Until duréeFusée > 0
                    Console.WriteLine("Durée écoulée sur la terre = " + DilatationDuTemps(duréeFusée, vitesseFusée).ToString() + " secondes")
                Case 2

                Case 3

                        Case 4
                        Console.WriteLine("Au revoir.")
                        Case Else
                        Console.WriteLine("Choix erroné.")
            End Select
        Loop Until choix = 4
        Console.ReadLine()
    End Sub


End Module
