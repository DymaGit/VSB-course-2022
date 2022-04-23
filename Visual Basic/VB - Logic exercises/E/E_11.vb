Module E_11
    Sub main()
        Dim pole(3, 3) As Integer
        Dim a As Byte, b As Byte
        Dim vypis As String, vypis2 As String
        Dim x As Byte
        vypis = ""
        vypis2 = ""
        x = 1

        For b = 0 To 3
            For a = 0 To 3
                pole(a, b) = Val(InputBox("zadej 16 čísel"))
                If x Mod 4 = 0 Then
                    vypis = vypis + Str(pole(a, b)) + Chr(10)
                Else
                    vypis = vypis + Str(pole(a, b)) + Chr(9)
                End If
                x = x + 1
            Next
        Next

        x = 1

        For b = 0 To 3
            For a = 0 To 3
                If x Mod 4 = 0 Then
                    vypis2 = vypis2 + Str(pole(b, a)) + Chr(10)
                Else
                    vypis2 = vypis2 + Str(pole(b, a)) + Chr(9)
                End If
                x = x + 1
            Next
        Next
        MsgBox(vypis + Chr(10) + vypis2)

    End Sub
End Module
