Module F2_8
    Sub main()
        Dim pole(99) As Integer, i As Integer
        Dim max As Byte
        Dim vysledek As Integer, por As Integer
        i = -1
        Do
            i = i + 1
            pole(i) = Val(InputBox("zadej vzestupnou řadu čísel.0=konec"))
        Loop While pole(i) > 0
        max = i - 1

        vysledek = vzestupF(pole, max)
        vzestupS(pole, max, por)
        If vysledek < 0 Then
            MsgBox("fce:" + Str(vysledek) + Chr(10) + "sbrtn: " + Str(por))

        Else
            MsgBox("(fce) řada byla narušena " + Str(vysledek) + ". " + "číslem" + Chr(10) + "(sbrtn) řada byla narušena " + Str(por) + ". " + "číslem")
        End If

    End Sub


    Function vzestupF(cisla() As Integer, maximum As Byte) As Integer
        Dim x As Byte
        Dim pocet As Byte
        Dim por As Integer
        pocet = 1

        For x = 1 To maximum
            pocet = pocet + 1

            If cisla(x) < cisla(x - 1) Then
                por = pocet
                Exit For
            End If

            If cisla(x) > cisla(x - 1) Then
                por = -1
            End If
        Next
        vzestupF = por
    End Function

    Sub vzestupS(cisla() As Integer, maximum As Byte, ByRef por As Integer)
        Dim x As Byte
        Dim pocet As Byte

        pocet = 1

        For x = 1 To maximum
            pocet = pocet + 1

            If cisla(x) < cisla(x - 1) Then
                por = pocet
                Exit For
            End If

            If cisla(x) > cisla(x - 1) Then
                por = -1
            End If
        Next



    End Sub

End Module
