Public MustInherit Class Animal


    'Initialisatie van een object gebeurt in de Constructor
    Public Sub New()
        Energy = 20
    End Sub

    Public Property Name As String
    Public Property Energy As Integer


    'Shared property in C# heet een static property
    Public Shared Property MaxEnergy As Integer = 100

    Public Overridable Sub Eat()
        Energy += 25

        If Energy > MaxEnergy Then
            Energy = MaxEnergy
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim str As String = ""
        Return $"{Name}    {Energy}"
    End Function


    'Abstract method MOET je implementeren in de afgeleide class
    'Hier staat dus ook GEEN default implementatie
    Public MustOverride Sub UseEnergy()


End Class
