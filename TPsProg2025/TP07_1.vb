Module TP07_1

    Sub Main()
        Dim montantSaisi, remise, montantNet As Double
        Console.WriteLine("Veuillez taper votre montant")
        montantSaisi = Console.ReadLine()
        If montantSaisi < 2000 Then
            remise = 0
            Console.WriteLine("Pas de remise")
        ElseIf montantSaisi <= 5000 Then
            remise = montantSaisi * 1 / 100
            Console.WriteLine("Remise de 1%")
        Else
            remise = montantSaisi * 2 / 100
            Console.WriteLine("Remise de 2%")
        End If
        montantNet = montantSaisi - remise
        Console.WriteLine("Le montant net est : " + montantNet.ToString())
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub

End Module
