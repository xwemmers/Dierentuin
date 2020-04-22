Public Class Monkey
    Inherits Animal

    Public Sub New()
        Energy = 25
    End Sub


    Public Overrides Sub Eat()
        Energy += 5

        If Energy > MaxEnergy Then
            Energy = MaxEnergy
        End If
    End Sub

    Public Overrides Sub UseEnergy()
        Energy -= 3
    End Sub
End Class




Public Class Gorilla
    Inherits Monkey

End Class



Public Class UrangUtang
    Inherits Monkey

End Class
