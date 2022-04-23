Module F1_9
    Sub main()
        Dim text As String
        Dim obrac As String

        text = InputBox("zadej text")
        obrattextS(text, obrac)      'neivm proč je to obrac podtržené

        MsgBox("funkce: " + obrattextF(text) + Chr(10) + "subrutina: " + obrac)


    End Sub

    Function obrattextF(txet As String) As String
        Dim max As Integer
        Dim i As Byte
        max = Len(txet)

        obrattextF = ""
        For i = 0 To max - 1
            obrattextF = obrattextF + Mid(txet, max - i, 1)
        Next
    End Function

    Sub obrattextS(txet As String, ByRef obrac As String)
        Dim obratte As String
        Dim max As Integer
        Dim i As Byte
        max = Len(txet)

        obratte = ""
        For i = 0 To max - 1
            obratte = obratte + Mid(txet, max - i, 1)
        Next

        obrac = obratte
    End Sub

End Module
