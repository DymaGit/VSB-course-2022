Module A12_objemValce
    Sub main()
        Dim prumer As Single, vyska As Single, objem As Single

        prumer = InputBox("zadej prumer bazenu (m)")
        vyska = InputBox("zadej vysku bazenu (m)")
        objem = Math.PI * ((prumer / 2) ^ 2) * vyska

        MsgBox("objem je: " + Str(objem) + " m3")
    End Sub



End Module
