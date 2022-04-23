Module C_14
    Sub main()
        Dim i As Byte, x As Byte
        Dim hvezda As String, hvezda2 As String, ubir As String

        'varianta 1: tam kde je hvězda "*" pouze připíšu jednu další.. "**"

        hvezda = ""
        hvezda2 = ""
        ubir = ""

        For i = 0 To 9
            For x = 1 To i
                hvezda = hvezda + "*"
            Next
            hvezda = hvezda + "*" + Chr(10)
        Next

        For i = 1 To 10
            For x = 1 To 10 - i
                hvezda2 = hvezda2 + "*"
            Next
            ubir = ubir + hvezda2 + Chr(10)
            hvezda2 = ""
        Next
        MsgBox(hvezda + ubir)
    End Sub
End Module
