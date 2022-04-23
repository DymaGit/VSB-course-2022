Module F2_10
    Sub main()

        Dim imax As Byte
        Dim pole(99) As Integer, i As Integer, prevod() As Integer, poli() As Integer
        Dim r As New Random
        Dim vypis1 As String, vypis2 As String, vypis3 As String

        vypis1 = ""
        vypis2 = ""
        vypis3 = ""
        i = -1
        Do
            i = i + 1
            pole(i) = Val(InputBox("zadej řadu čísel. 0=konec"))
        Loop While pole(i) > 0
        imax = i - 1

        prevod = serazenepoleF(pole, imax)
        serazenepoleS(pole, imax, poli)
        For i = 0 To imax
            vypis1 = vypis1 + Str(pole(i))
            vypis2 = vypis2 + Str(prevod(i))
            vypis3 = vypis3 + Str(poli(i))
        Next

        MsgBox("původní čísla: " + vypis1 + Chr(10) + Chr(10) + "seřazená čísla (fce): " + vypis2 + Chr(10) + "seřazená čísla (sbrtn): " + vypis3)

    End Sub

    Function serazenepoleF(fcepole() As Integer, maximum As Byte) As Integer()
        Dim dalsi As Byte, save As Byte, a As Byte
        Dim novepole(99) As Integer

        For i = 0 To maximum
            novepole(i) = fcepole(i)
        Next
        Do
            For i = 0 To maximum - 1
                dalsi = i + 1
                If novepole(i) > novepole(dalsi) Then
                    save = novepole(i)
                    novepole(i) = novepole(dalsi)
                    novepole(dalsi) = save
                End If
            Next
            a = a + 1
        Loop While a < maximum

        serazenepoleF = novepole
    End Function


    Sub serazenepoleS(fcepole() As Integer, maximum As Byte, ByRef poli() As Integer)
        Dim dalsi As Byte, save As Byte, a As Byte
        Dim novepole(99) As Integer
        For i = 0 To maximum
            novepole(i) = fcepole(i)
        Next
        Do
            For i = 0 To maximum - 1
                dalsi = i + 1
                If novepole(i) > novepole(dalsi) Then
                    save = novepole(i)
                    novepole(i) = novepole(dalsi)
                    novepole(dalsi) = save
                End If
            Next
            a = a + 1
        Loop While a < maximum

        poli = novepole
    End Sub


End Module
