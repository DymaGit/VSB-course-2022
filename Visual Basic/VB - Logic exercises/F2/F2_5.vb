Module F2_5
    Sub main()
        Dim pocethodu As Byte
        Dim vypis3 As String
        Dim uschovna(99) As Integer
        Dim vystup As String
        pocethodu = Val(InputBox("zadje počet hodů"))

        vypis3 = pocetpadlychF(pocethodu)
        polepadlychS(pocethodu, vystup)
        MsgBox("fce:" + vypis3 + Chr(10) + "sbrtn: " + vystup)


    End Sub

    Function pocetpadlychF(pocet As Byte) As String
        Dim padlecisla(99) As Integer, pole(99) As Integer
        Dim r As New Random
        Dim i As Byte
        Dim vypis As String, vypis2 As String

        vypis = ""
        vypis2 = ""
        For i = 0 To pocet - 1
            pole(i) = 0
        Next

        For i = 0 To pocet - 1
            padlecisla(i) = r.Next(1, 11)
            pole(padlecisla(i)) = pole(padlecisla(i)) + 1
            vypis2 = vypis2 + Str(padlecisla(i))
        Next

        For i = 1 To 10
            If pole(i) > 0 Then
                vypis = vypis + Str(i) + " padlo " + Str(pole(i)) + "x" + Chr(10)
            End If
        Next

        pocetpadlychF = vypis2 + Chr(10) + Chr(10) + vypis

    End Function


    Sub polepadlychS(pocet As Byte, ByRef vystup As String)

        Dim padlecisla(99) As Integer, pole(99) As Integer
        Dim r As New Random
        Dim i As Byte
        Dim vypis As String, vypis2 As String

        vypis = ""
        vypis2 = ""
        For i = 0 To pocet - 1
            pole(i) = 0
        Next

        For i = 0 To pocet - 1
            padlecisla(i) = r.Next(1, 11)
            pole(padlecisla(i)) = pole(padlecisla(i)) + 1
            vypis2 = vypis2 + Str(padlecisla(i))
        Next

        For i = 1 To 10
            If pole(i) > 0 Then
                vypis = vypis + Str(i) + " padlo " + Str(pole(i)) + "x" + Chr(10)
            End If
        Next

        vystup = vypis2 + Chr(10) + Chr(10) + vypis

    End Sub

End Module
