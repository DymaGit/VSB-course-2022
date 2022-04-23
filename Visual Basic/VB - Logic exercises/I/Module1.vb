Module Module1



    Structure stZam
        Dim Jmeno As String
        Dim Naroz As Date
        Dim Plat As Double
    End Structure

    Sub Main()
        Dim osoba1 As stZam, Petr As stZam, Jirka As stZam
        Dim Z(0 To 2) As stZam

        osoba1.Jmeno = "Karel"
        osoba1.Naroz = #6/11/1961#
        osoba1.Plat = 15000
        Console.WriteLine("jmeno: " + osoba1.Jmeno + " " + osoba1.Naroz + ", plat: " + Str(osoba1.Plat))


        With Petr
            .Jmeno = "Petr"
            .Naroz = #6/11/1951#
            .Plat = 20000
        End With
        Console.WriteLine(Petr.Jmeno + " " + Petr.Naroz + Str(Petr.Plat))


        With Z(1) : .Jmeno = "Prvni" : .Naroz = # 8/10/1992# : .Plat = 7800 : End With
        With Z(2) : .Jmeno = "Druhy" : .Naroz = # 1/12/1982# : .Plat = 10200 : End With

        Console.WriteLine(Z(1).Jmeno + " " + Z(1).Naroz + Str(Z(1).Plat))
        Console.WriteLine(Z(2).Jmeno + " " + Z(2).Naroz + Str(Z(2).Plat))




    End Sub

End Module
