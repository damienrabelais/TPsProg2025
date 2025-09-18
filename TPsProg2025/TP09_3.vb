Module TP09_3
    Sub Main()
        Dim n, i, nombre As Integer
        Do
            Console.WriteLine("Saisir le nombre de chiffres pairs :")
            n = Console.ReadLine()

        Loop Until n > 0
        nombre = 0
        For i = 1 To n
            nombre = nombre + 2
            Console.WriteLine(nombre)
        Next
        Console.ReadLine()
    End Sub

End Module
