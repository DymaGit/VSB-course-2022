Module C_13

    Sub main()
        'Nevim jak to zarovnat do sloupců
        Dim x As Byte, i As Byte
        Dim nasobilka As String, radek As String, sloupec As String, vypis As String
        nasobilka = ""
        radek = ""
        vypis = ""
        For i = 1 To 10
            radek = radek + Str(i)
            sloupec = Str(i)
            For x = 1 To 10
                nasobilka = nasobilka + Str((i * x))
            Next
            vypis = vypis + sloupec + nasobilka + Chr(10)
            nasobilka = ""
        Next
        MsgBox("   " + radek + Chr(10) + vypis)
    End Sub
End Module
