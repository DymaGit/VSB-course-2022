Module Module1
    Public cas As Integer
    Sub Main()
        Dim F As New Form1
        cas = Val(InputBox("zadej počet sekund"))
        If cas > 0 Then
            F.ShowDialog()
        Else
            MsgBox("chybný údaj")
        End If
    End Sub
End Module
