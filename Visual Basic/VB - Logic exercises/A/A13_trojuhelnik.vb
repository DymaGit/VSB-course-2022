Module A13_trojuhelnik
    Sub main()
        Dim odvesna1 As Single
        Dim odvesna2 As Single
        Dim prepona As Single

        odvesna1 = InputBox("zadej délku dověsny1 (cm)")
        odvesna2 = InputBox("zadej délku dověsny2 (cm)")

        prepona = Math.Sqrt((odvesna1 ^ 2) + (odvesna2 ^ 2))

        MsgBox("Přepona trojúhelníku je: " + Str(Math.Round(prepona, 2)) + " cm.")

    End Sub
End Module
