Module F2_1


    Sub main()
        Dim pole(9) As Integer, novepole() As Integer, mira As Integer
        Dim x As Byte
        Dim vypis As String, vypis2 As String, vypis3 As String
        Dim polenov(10) As Integer

        vypis = ""
        vypis2 = ""
        vypis3 = ""
        For x = 0 To 3
            pole(x) = Val(InputBox("zadej úspory jednotlivých lidí"))
        Next

        mira = Val(InputBox("zadej roční úrokovou míru (%)"))

        novepole = urokF(pole, mira)
        urokS(pole, mira, polenov)

        For x = 0 To 3
            vypis = vypis + Str(pole(x)) + ", "       '<--ověření zda se nepřepsalo původní pole
            vypis2 = vypis2 + Str(novepole(x)) + ", "
            vypis3 = vypis3 + Str(polenov(x)) + ", "
        Next

        MsgBox("původní pole: " + vypis + Chr(10) + Chr(10) + "nové pole + úroky (funkce): " + vypis2 + Chr(10) + "nové pole + úroky (subrutina): " + vypis3)

    End Sub


    Function urokF(pol() As Integer, mir As Integer) As Integer()
        Dim uschovna(9) As Integer    '<--musí být definován počet buněk
        Dim i As Byte

        For i = 0 To UBound(pol)
            uschovna(i) = pol(i) + (pol(i) / 100 * mir)
        Next
        urokF = uschovna
    End Function

    Sub urokS(pol() As Integer, mir As Integer, ByRef polenov() As Integer)
        Dim uschovna(10) As Integer
        Dim i As Byte

        For i = 0 To UBound(pol)
            uschovna(i) = pol(i) + (pol(i) / 100 * mir)
        Next

        polenov = uschovna

    End Sub

End Module
