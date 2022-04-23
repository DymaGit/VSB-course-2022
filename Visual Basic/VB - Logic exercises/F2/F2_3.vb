Module F2_3
    Sub main()

        tisk(5, "a")

    End Sub

    Sub tisk(N As Integer, Z As String)
        Dim i As Integer, ret As String
        ret = ""
        For i = 1 To N
            ret = ret + Z
        Next
        MsgBox(ret)

    End Sub

End Module
