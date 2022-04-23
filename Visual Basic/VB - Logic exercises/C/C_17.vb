Module C_17
    Sub main()
        Dim i As Byte
        Dim r As New Random
        Dim nah As Integer
        Dim hvezdy As String, vypis As String
        hvezdy = ""
        vypis = ""

        For i = 1 To 20
            nah = (r.Next(1, 21))
            For x = 1 To nah
                hvezdy = hvezdy + "*"
            Next
            vypis = vypis + hvezdy + Chr(10)
            hvezdy = ""
        Next

        MsgBox(vypis)

    End Sub
End Module
