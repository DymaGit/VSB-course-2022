Module F2_9
    Sub main()
        Dim pole(99) As Integer
        Dim i As Integer
        Dim maximum As Byte
        Dim truefalse As Boolean, prevod As Boolean

        i = -1
        Do
            i = i + 1
            pole(i) = Val(InputBox("zadej lineární posloupnost. 0=konec"))
        Loop While pole(i) > 0

        maximum = i - 1

        truefalse = pravdaF(pole, maximum)
        pravdaS(pole, maximum, prevod)
        MsgBox("fce: " + Str(truefalse) + Chr(10) + "sbrtn: " + Str(prevod))

    End Sub

    Function pravdaF(cisla() As Integer, max As Byte) As Boolean
        Dim x As Byte
        Dim prevod As Boolean
        Dim linear As Integer

        linear = cisla(1) - cisla(0)


        For x = 1 To max

            If cisla(x) - (cisla(x - 1)) = linear Then
                prevod = True
            Else
                prevod = False
                Exit For
            End If
        Next
        pravdaF = prevod
    End Function


    Sub pravdaS(cisla() As Integer, max As Byte, ByRef prevod As Boolean)
        Dim x As Byte
        Dim linear As Integer

        linear = cisla(1) - cisla(0)


        For x = 1 To max

            If cisla(x) - (cisla(x - 1)) = linear Then
                prevod = True
            Else
                prevod = False
                Exit For
            End If
        Next

    End Sub


End Module