Module E_12
    Sub main()
        Dim pole(9) As Integer
        Dim r As New Random
        Dim vypis As String
        Dim max As String

        vypis = ""
        max = ""
        For i = 0 To 9
            pole(i) = (r.Next(1, 11))
            vypis = vypis + Str(pole(i))
        Next

        For i = 1 To 8
            If pole(i) > pole(i - 1) And pole(i) > pole(i + 1) Then
                max = max + Str(pole(i))
            End If
        Next
        MsgBox("všechna čísla: " + vypis + Chr(10) + Chr(10) + "lokální maxima: " + max)


    End Sub
End Module
