Module E_14
    Sub main()
        Dim i As Byte, a As Byte, save As Byte
        Dim pole(10) As Integer
        Dim r As New Random
        Dim vypis1 As String, vypis2 As String
        Dim dalsi As Byte

        vypis1 = ""
        vypis2 = ""

        For i = 0 To 9
            pole(i) = (r.Next(1, 15))
            vypis1 = vypis1 + Str(pole(i))
        Next

        Do
            For i = 0 To 8
                dalsi = i + 1
                If pole(i) > pole(dalsi) Then
                    save = pole(i)
                    pole(i) = pole(dalsi)
                    pole(dalsi) = save
                End If
            Next
            a = a + 1
        Loop While a < 10

        For i = 0 To 9
            vypis2 = vypis2 + Str(pole(i))
        Next

        MsgBox("náhodná čísla: " + Chr(10) + vypis1 + Chr(10) + Chr(10) + "bubble sort: " + Chr(10) + vypis2)

    End Sub
End Module
