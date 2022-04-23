Module C_16


    Sub main()
        Dim i As Byte
        Dim cisla As String, vypis As String
        cisla = ""
        vypis = ""
        For i = 1 To 10
            For x = 1 To i
                cisla = cisla + Str(x)
            Next
            vypis = vypis + cisla + Chr(10)
            cisla = ""
        Next
        MsgBox(vypis)
    End Sub
End Module
