Module F1_11
    Sub main()
        Dim text As String
        Dim znak As String
        Dim pocet As Byte

        text = InputBox("zadej nějaký text")
        znak = InputBox("zadej znak a dostaneš počet")
        vyskytyS(text, znak, pocet)

        MsgBox("funkce: " + Str(vyskytyF(text, znak)) + Chr(10) + "subrutina: " + Str(pocet))

    End Sub


    Function vyskytyF(veta As String, pismeno As String) As Byte
        Dim max As Byte, i As Byte, pocet As Byte
        Dim vypis As String

        max = Len(veta)
        pocet = 0
        For i = 1 To max

            vypis = Mid(veta, i, 1)
            If vypis = pismeno Then
                pocet = pocet + 1
            End If
        Next
        vyskytyF = pocet
    End Function

    Sub vyskytyS(veta As String, pismeno As String, ByRef pocet As Byte)
        Dim max As Byte, i As Byte
        Dim vypis As String

        max = Len(veta)
        pocet = 0
        For i = 1 To max

            vypis = Mid(veta, i, 1)
            If vypis = pismeno Then
                pocet = pocet + 1
            End If
        Next
    End Sub

End Module
