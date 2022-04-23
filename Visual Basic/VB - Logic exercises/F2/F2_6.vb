Module F2_6
    Sub main()
        Dim pole(99) As Integer, novepole() As Integer, novepolicko() As Integer
        Dim i As Integer
        Dim max As Byte
        Dim vypis As String, vypis2 As String

        vypis = ""
        vypis2 = ""
        i = -1
        Do
            i = i + 1
            pole(i) = Val(InputBox("zadej řadu čísel. 0=konec"))
        Loop While pole(i) > 0

        max = i - 1
        novepole = sudacislazpoleF(pole, max)
        sudacislaS(pole, max, novepolicko)
        For i = 0 To max
            If novepole(i) > 0 Then
                vypis = vypis + Str(novepole(i))
                vypis2 = vypis2 + Str(novepolicko(i))
            End If
        Next
        MsgBox("fce: " + vypis + Chr(10) + "sbrtn: " + vypis2)

    End Sub


    Function sudacislazpoleF(cisla() As Integer, maximum As Byte) As Integer()
        Dim x As Byte
        Dim uschovna(99) As Integer

        For x = 0 To maximum
            If cisla(x) Mod 2 = 0 Then
                uschovna(x) = cisla(x)
            End If
        Next
        sudacislazpoleF = uschovna
    End Function

    Sub sudacislaS(cisla() As Integer, maximum As Byte, ByRef novepolicko() As Integer)
        Dim x As Byte
        Dim uschovna(99) As Integer

        For x = 0 To maximum
            If cisla(x) Mod 2 = 0 Then
                uschovna(x) = cisla(x)
            End If
        Next

        novepolicko = uschovna

    End Sub

End Module
