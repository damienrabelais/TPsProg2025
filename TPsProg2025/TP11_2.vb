Module TP11_2
    Function Factorielle(ByVal pN As Integer) As Double
        Dim resultat As Double = 1
        Dim i As Integer
        For i = 1 To pN
            resultat = resultat * i
        Next
        Return resultat
    End Function
    Sub main()
        Dim n As Integer
        Do
            Do
                Console.WriteLine("Saisir un nombre n >= 0 ou n=-1 pour sortir")
                n = Console.ReadLine()
                If n < 0 And n <> -1 Then
                    Console.WriteLine("n >= 0 ou n=-1 pour sortir")
                End If
            Loop Until n >= 0 Or n = -1
            If n <> -1 Then
                Console.WriteLine("La factorielle de ce nombre est " + Factorielle(n).ToString())
            End If
        Loop Until n = -1
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module
