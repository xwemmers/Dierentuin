Public Class Form1

    Dim Zoo As New List(Of Animal)

    Sub RefreshUI()
        lbx.DataSource = Nothing
        lbx.DataSource = Zoo
        dgv.DataSource = Nothing
        dgv.DataSource = Zoo
    End Sub

    Private Sub btnNewMonkey_Click(sender As Object, e As EventArgs) Handles btnNewMonkey.Click

        Dim m As New Monkey
        m.Name = "Caesar"
        Zoo.Add(m)
        RefreshUI()

    End Sub

    Private Sub btnNewLion_Click(sender As Object, e As EventArgs) Handles btnNewLion.Click
        Dim l As New Lion
        l.Name = "Simba"
        Zoo.Add(l)



        RefreshUI()
    End Sub

    Private Sub btnNewElephant_Click(sender As Object, e As EventArgs) Handles btnNewElephant.Click
        Dim el As New Elephant
        el.Name = "Dombo"
        Zoo.Add(el)
        RefreshUI()
    End Sub

    Private Sub btnFeedAll_Click(sender As Object, e As EventArgs) Handles btnFeedAll.Click
        'Alle dieren worden gevoederd
        For Each a In Zoo
            a.Eat()
        Next

        RefreshUI()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each a In Zoo
            If TypeOf a Is Monkey Then

                a.Eat()
            End If
        Next

        RefreshUI()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each a In Zoo
            Try
                Dim leeuw As Lion = DirectCast(a, Lion)
                leeuw.Eat()

            Catch ex As Exception

            End Try
        Next

        RefreshUI()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each a In Zoo
            Dim olifant As Elephant = TryCast(a, Elephant)

            If olifant IsNot Nothing Then
                olifant.Fly()
                olifant.Eat()
            End If
        Next

        RefreshUI()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'De OfType functie filtert eerst alle olifanten uit de Zoo
        For Each o In Zoo.OfType(Of Elephant)
            o.Eat()
            o.Fly()
        Next

        RefreshUI()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Maak een kopie van de Zoo want anders zal de Zoo verzameling geblokkeerd zijn 
        'en dan mag je in de For Each geen Remove op die collectie doen
        For Each a In Zoo.ToList
            a.UseEnergy()

            If a.Energy < 0 Then
                Zoo.Remove(a)
            End If
        Next

        RefreshUI()
    End Sub
End Class
