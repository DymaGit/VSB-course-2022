Module F1_4
    Sub main()
        Dim rok As Single
        Dim prestup As Boolean
        Dim s As String
        rok = Val(InputBox("Zadej rok"))

        prestupS(rok, prestup)
        s = Str(prestup)

        MsgBox("funckce: " + Str(prestupF(rok)) + Chr(10) + "subrutina: " + s)
    End Sub


    Function prestupF(cislo As Single) As Boolean

        If (cislo Mod 100 = 0 And cislo Mod 400 = 0) Or (cislo Mod 4 = 0 And Not cislo Mod 100 = 0) Then
            prestupF = True
        Else
            prestupF = False
        End If

    End Function

    Sub prestupS(cislo As Single, ByRef prestup As Boolean)
        If (cislo Mod 100 = 0 And cislo Mod 400 = 0) Or (cislo Mod 4 = 0 And Not cislo Mod 100 = 0) Then
            prestup = True
        Else
            prestup = False
        End If
    End Sub


End Module
