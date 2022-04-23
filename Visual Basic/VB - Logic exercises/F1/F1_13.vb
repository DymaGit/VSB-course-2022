Module F1_13

    Sub main()
        Dim soucet As Byte
        Dim ret As String       'tento řádek chyběl
        ret = ""                'tento řádek chyběl

        soucet = sectiF(3, 4)
        ret = ret + Chr(10) + "Soucet podle funkce je " + Str(soucet)
        sectiS(3, 4, soucet)
        ret = ret + Chr(10) + "Soucet  podle subrutiny je " + Str(soucet)
        MsgBox(ret)
    End Sub

    Function sectiF(a As Byte, b As Byte) As Byte
        sectiF = a + b
    End Function

    Sub sectiS(a As Byte, b As Byte, vys As Byte)

        vys = a + b + 5

        'Program ignoruje 5ku protože počítá jen s (a As Byte, b As Byte, vys As Byte).
        'Tedy s tím co je deklarováno u subrutiny v závorce.
        'Chybí Byref.. -> (ByRef vys As Byte) aby program počítal i s tím co není konkrétně deklarováno.
    End Sub


End Module
