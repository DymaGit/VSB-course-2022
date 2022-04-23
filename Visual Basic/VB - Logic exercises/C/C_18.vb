Module C_18


    Sub main()
        Dim i As Integer
        Dim vypis As Integer
        Dim x As Integer
        Dim prvo As String
        prvo = ""

        For i = 1 To 1000
            For x = 2 To i - 1
                If i Mod x = 0 Then
                    vypis = i
                End If
            Next

            If vypis < 1 Then
                prvo = prvo + Str(i)
            End If
            vypis = 0
        Next
        MsgBox(prvo)
    End Sub
End Module
