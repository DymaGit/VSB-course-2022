Module E_10

    Sub main()
        'smyčka DO loop kvůli procvičení. Jednodušší by byla for smyčka
        Dim a As Byte, b As Byte, cislo As Byte, pocet As Byte, min As Byte, i As Byte
        Dim minradek As Byte, minsloupec As Byte
        Dim vypis As String
        Dim pole(3, 3)
        pocet = 1
        vypis = ""
        i = 0

        Do
            Do
                cislo = Val(InputBox("zadej číslo (1 - 20)"))
                pole(a, b) = cislo

                If i = 0 Then
                    min = cislo
                    minradek = b
                    minsloupec = a
                ElseIf cislo < min Then
                    min = cislo
                    minradek = b
                    minsloupec = a
                End If

                i = i + 1

                If pocet Mod 4 = 0 Then
                    vypis = vypis + Str(pole(a, b)) + Chr(10)
                Else
                    vypis = vypis + Str(pole(a, b)) + Chr(9)
                End If
                a = a + 1
                pocet = pocet + 1

            Loop While a < 4
            a = 0
            b = b + 1


        Loop While b < 4

        MsgBox(vypis + Chr(10) + "nejmenší číslo: " + Str(min) + Chr(10) + "sloupcový index je: " + Str(minsloupec + 1) + Chr(10) + "řádkový index je: " + Str(minradek + 1) + Chr(10) + "(přičteno +1 ať se mi neplete v zobrazení tabulky nultý index)")
    End Sub
End Module
