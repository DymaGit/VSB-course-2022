Module F1_8
    Sub main()
        Dim mesic As Integer
        Dim dny As Integer
        mesic = Val(InputBox("Zadej číslo měsíce. 1-12"))

        pocetdnimesiceS(mesic, dny)

        MsgBox("funkce: " + Str(pocetdnimesiceF(mesic)) + Chr(10) + "subrutina: " + Str(dny))

    End Sub


    Function pocetdnimesiceF(moon As Integer) As Integer
        Select Case moon
            Case 1
                pocetdnimesiceF = 31
            Case 2
                pocetdnimesiceF = 28
            Case 3
                pocetdnimesiceF = 31
            Case 4
                pocetdnimesiceF = 30
            Case 5
                pocetdnimesiceF = 31
            Case 6
                pocetdnimesiceF = 30
            Case 7
                pocetdnimesiceF = 31
            Case 8
                pocetdnimesiceF = 31
            Case 9
                pocetdnimesiceF = 30
            Case 10
                pocetdnimesiceF = 31
            Case 11
                pocetdnimesiceF = 30
            Case 12
                pocetdnimesiceF = 31
            Case Else
                pocetdnimesiceF = -1
        End Select
    End Function

    Sub pocetdnimesiceS(moon As Integer, ByRef dny As Integer)
        Select Case moon
            Case 1
                dny = 31
            Case 2
                dny = 28
            Case 3
                dny = 31
            Case 4
                dny = 30
            Case 5
                dny = 31
            Case 6
                dny = 30
            Case 7
                dny = 31
            Case 8
                dny = 31
            Case 9
                dny = 30
            Case 10
                dny = 31
            Case 11
                dny = 30
            Case 12
                dny = 31
            Case Else
                dny = -1
        End Select


    End Sub






End Module
