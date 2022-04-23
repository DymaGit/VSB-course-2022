Module C_14_var_2
    Sub main()
        Dim i As Byte, x As Byte, y As Byte
        Dim vypis As String, vypis2 As String, hvezdy As String
        'varianta 2

        vypis = ""
        vypis2 = ""
        hvezdy = ""
        y = 0

        For i = 0 To 19
            For x = 1 To y
                vypis = vypis + "*"
            Next
            If i Mod 2 = 1 Then
                y = y + 1
            End If
            vypis = vypis + "*" + Chr(10)
        Next

        y = 10
        For i = 0 To 20
            For x = 0 To y
                vypis2 = vypis2 + "*"
            Next
            If i Mod 2 = 1 Then
                y = y - 1
            End If
            hvezdy = hvezdy + vypis2 + Chr(10)
            vypis2 = ""
        Next
        MsgBox(vypis + hvezdy)
    End Sub
End Module
