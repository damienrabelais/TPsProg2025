Module TP07_2
    Sub Main()
        Const LOCATIONESSENCE As Double = 30, KILOMETRAGEESSENCE As Double = 0.85
        Const LOCATIONDIESEL As Double = 35, KILOMETRAGEDIESEL As Double = 0.65
        Dim joursDeLocation, distanceAParcourir, coutEssence, coutDiesel As Integer

        Console.WriteLine("Nombre de jours de location ?")
        joursDeLocation = Console.ReadLine
        Console.WriteLine("Distance à parcourir (en kms) ?")
        distanceAParcourir = Console.ReadLine
        coutEssence = joursDeLocation * LOCATIONESSENCE +
      distanceAParcourir * KILOMETRAGEESSENCE
        coutDiesel = joursDeLocation * LOCATIONDIESEL +
      distanceAParcourir * KILOMETRAGEDIESEL
        If coutEssence > coutDiesel Then
            Console.WriteLine("Meilleur choix : Diesel")
        ElseIf coutEssence < coutDiesel Then
            Console.WriteLine("Meilleur choix : Essence")
        Else
            Console.WriteLine("Meilleur choix : Egalité")
        End If
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module
