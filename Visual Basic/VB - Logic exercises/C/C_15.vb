Module C_15


    Sub main()
        Dim r As New Random
        Dim nah As Integer
        Dim vypis As String, stejne As String, porad As String
        Dim cislo As Integer
        Dim i As Byte
        vypis = ""
        stejne = ""
        porad = ""

        For i = 1 To 100 Step 2
            nah = (r.Next(1, 6))
            If nah = cislo Then
                stejne = stejne + Str(nah)
                porad = porad + Str(i - 1) + "." + " a" + Str(i) + ".,"
            End If
            cislo = (r.Next(1, 6))
            If nah = cislo Then
                stejne = stejne + Str(nah)
                porad = porad + Str(i) + "." + " a" + Str(i + 1) + ".,"
            End If
            vypis = vypis + Str(nah) + Str(cislo)
        Next
        MsgBox("všechna čísla: " + vypis + Chr(10) + Chr(10) + "stejná čísla: " + stejne + Chr(10) + Chr(10) + "pořadí stejných čísel: " + porad)
    End Sub
End Module
