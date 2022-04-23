Module F2_11
    Sub main()
        Dim znak(99) As String, pole() As String, vystup() As String
        Dim i As Integer
        Dim sifra As Byte
        Dim imax As Byte
        Dim vypis As String, vypis2 As String, vypis3 As String

        vypis2 = ""
        vypis = ""
        vypis3 = ""
        i = -1
        Do
            i = i + 1
            znak(i) = InputBox("zadej znak. 0=konec")
        Loop Until znak(i) = "0"

        imax = i - 1
        sifra = InputBox("zadej o kolik pozic se znak posune")

        pole = kodF(znak, sifra, imax)
        kodS(znak, sifra, imax, vystup)

        For i = 0 To imax
            vypis2 = vypis2 + znak(i) + ", "
            vypis = vypis + pole(i) + ", "
            vypis3 = vypis3 + vystup(i)
        Next

        MsgBox("fce: " + vypis2 + Chr(10) + "sbrtn: " + vypis3 + Chr(10) + "posun o:" + Str(sifra) + Chr(10))


    End Sub


    Function kodF(vstup() As String, pocet As Byte, max As Byte) As String()
        Dim save(99) As Integer
        Dim prevod(99) As String

        For i = 0 To max
            save(i) = Asc(vstup(i)) + pocet
            If save(i) > 122 Then
                save(i) = save(i) - 26
            End If
        Next
        For i = 0 To max

            prevod(i) = Chr(save(i))
        Next

        kodF = prevod
    End Function
    Sub kodS(vstup() As String, pocet As Byte, max As Byte, ByRef vystup() As String)
        Dim save(99) As Integer
        Dim prevod(99) As String

        For i = 0 To max
            save(i) = Asc(vstup(i)) + pocet
            If save(i) > 122 Then
                save(i) = save(i) - 26
            End If
        Next
        For i = 0 To max

            prevod(i) = Chr(save(i))
        Next

        vystup = prevod

    End Sub

End Module
