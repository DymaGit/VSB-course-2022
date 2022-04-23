Module E_13


    Sub main()
        Dim pole(99) As Integer, nah As Integer
        Dim r As New Random
        Dim vypis As String, vypis2 As String

        vypis = ""
        vypis2 = ""
        For i = 0 To 9
            pole(i) = 0
        Next
        For i = 0 To 9
            nah = (r.Next(1, 11))
            vypis = vypis + Str(nah)
            pole(nah) = pole(nah) + 1
        Next
        For i = 0 To 10
            If pole(i) > 1 Then
                vypis2 = vypis2 + "číslo " + Str(i) + " padlo " + Str(pole(i)) + "x." + Chr(10)
            End If
        Next
        MsgBox("generované čísla: " + vypis + Chr(10) + Chr(10) + vypis2)

    End Sub
End Module
