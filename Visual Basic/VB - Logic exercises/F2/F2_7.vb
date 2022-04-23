Module F2_7

    Sub main()
        Dim pole(99) As Integer
        Dim i As Integer
        Dim maximum As Byte
        Dim truefalse As Boolean, truth As Boolean

        i = -1
        Do
            i = i + 1
            pole(i) = Val(InputBox("zadej vzestupnou řadu čísel. 0=konec"))
        Loop While pole(i) > 0

        maximum = i - 1

        truefalse = pravdaF(pole, maximum)
        pravdaS(pole, maximum, truth)

        MsgBox("fce: " + Str(truefalse) + Chr(10) + "sbrtn: " + Str(truth))

    End Sub

    Function pravdaF(cisla() As Integer, max As Byte) As Boolean
        Dim x As Byte
        Dim prevod As Boolean
        For x = 1 To max
            If cisla(x) > cisla(x - 1) Then
                prevod = True
            Else
                prevod = False
                Exit For
            End If
        Next

        pravdaF = prevod
    End Function

    Sub pravdaS(cisla() As Integer, max As Byte, ByRef truth As Boolean)
        Dim x As Byte
        Dim prevod As Boolean
        For x = 1 To max
            If cisla(x) > cisla(x - 1) Then
                prevod = True
            Else
                prevod = False
                Exit For
            End If
        Next

        truth = prevod

    End Sub

End Module
