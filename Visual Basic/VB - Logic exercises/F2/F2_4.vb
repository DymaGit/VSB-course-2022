Module F2_4
    Sub main()
        Dim A(9) As Integer
        Dim C As Byte, i As Byte, kolikrat As Byte
        Dim r As New Random
        Dim vypis As String
        Dim soucet As Byte

        vypis = ""
        C = InputBox("zadej číslo 1-10")

        For i = 0 To 9
            A(i) = r.Next(1, 11)
            vypis = vypis + Str(A(i))
        Next

        kolikrat = pocetvyskytuF(A, C)
        pocetvyskytuS(A, C, soucet)
        MsgBox("losovaná čísla: " + vypis + Chr(10) + "číslo: " + Str(C) + " padlo (fce)" + Str(kolikrat) + "x" + Chr(10) + "číslo: " + Str(C) + " padlo (sbrtn)" + Str(soucet) + "x" + Chr(10))

    End Sub



    Function pocetvyskytuF(pole() As Integer, pocet As Byte) As Byte
        Dim i As Byte, soucet As Byte

        For i = 0 To 9
            If pole(i) = pocet Then
                soucet = soucet + 1
            End If
        Next
        pocetvyskytuF = soucet
    End Function



    Sub pocetvyskytuS(pole() As Integer, pocet As Byte, ByRef soucet As Byte)

        Dim i As Byte

        For i = 0 To 9
            If pole(i) = pocet Then
                soucet = soucet + 1
            End If
        Next

    End Sub

End Module
