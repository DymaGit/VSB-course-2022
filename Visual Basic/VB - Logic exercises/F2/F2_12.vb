Module F2_12
    Sub main()
        Dim slovo(99) As String, vystup() As String, policko() As String
        Dim i As Integer
        Dim imax As Byte, sifra As Byte
        Dim vypis As String, vypis2 As String, vypis3 As String
        i = -1
        vypis = ""
        vypis2 = ""
        vypis3 = ""
        Do
            i = i + 1
            slovo(i) = InputBox("zadej slovo. 0=konec")
        Loop Until slovo(i) = "0"
        imax = i - 1
        sifra = InputBox("zadej o kolik pozic se zasifrují písmena")

        vystup = kodslovF(slovo, sifra, imax)
        kodslovS(slovo, sifra, imax, policko)
        For i = 0 To imax
            vypis2 = vypis2 + slovo(i) + ", "
            vypis = vypis + vystup(i) + ", "
            vypis3 = vypis3 + policko(i) + ", "
        Next
        MsgBox("původní slova: " + vypis2 + Chr(10) + "posunuto o: " + Str(sifra) + Chr(10) + "kódovaná slova (fce): " + vypis + Chr(10) + "kódovaná slova (sbrtn): " + vypis3)

    End Sub


    Function kodslovF(pole() As String, kod As Byte, max As Byte) As String()
        Dim delka As Byte, x As Byte
        Dim uschovna As String
        Dim slovo(99) As String
        Dim ret As String
        ret = ""
        For i = 0 To max
            delka = Len(pole(i))
            For x = 0 To delka - 1
                uschovna = Mid(pole(i), 1 + x, delka - x)
                If (Asc(uschovna) + kod) > 122 Then
                    ret = ret + Chr(Asc(uschovna) + kod - 26)
                Else
                    ret = ret + Chr(Asc(uschovna) + kod)
                End If
            Next

            slovo(i) = ret
            ret = ""
        Next
        kodslovF = slovo
    End Function


    Sub kodslovS(pole() As String, kod As Byte, max As Byte, ByRef policko() As String)
        Dim delka As Byte, x As Byte
        Dim uschovna As String
        Dim slovo(99) As String
        Dim ret As String
        ret = ""
        For i = 0 To max
            delka = Len(pole(i))
            For x = 0 To delka - 1
                uschovna = Mid(pole(i), 1 + x, delka - x)
                If (Asc(uschovna) + kod) > 122 Then
                    ret = ret + Chr(Asc(uschovna) + kod - 26)
                Else
                    ret = ret + Chr(Asc(uschovna) + kod)
                End If
            Next

            slovo(i) = ret
            ret = ""
        Next
        policko = slovo




    End Sub


End Module
