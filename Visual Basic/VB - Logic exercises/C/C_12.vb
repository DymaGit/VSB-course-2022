Module C_12

    Sub main()
        Dim i As Byte, x As Byte, prvni As Byte, y As Byte
        Dim r As New Random
        Dim rnd As Single
        Dim vypis As String, vypis2 As String

        x = 0
        y = 0
        vypis = ""
        vypis2 = ""

        For i = 1 To 100
            rnd = Math.Round((r.NextDouble() * (4 - 2) + 2), 2)
            If rnd >= 2.95 And rnd <= 3.05 Then
                vypis = vypis + "(" + Str(rnd) + ")" + Chr(9)
                x = x + 1
                vypis2 = vypis2 + Str(rnd) + ","
                If y = 0 Then
                    y = y + 1
                    prvni = i
                End If
            Else
                vypis = vypis + Str(rnd) + Chr(9)
            End If
        Next
        MsgBox("údery: " + Chr(10) + vypis + Chr(10) + Chr(10) + "trefy: " + vypis2 + Chr(10) + "počet tref: " + Str(x) + Chr(10) + "první trefa padla v pořadí: " + Str(prvni) + ".")
    End Sub
End Module
