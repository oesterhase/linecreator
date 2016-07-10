Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Module Module1

    Sub Main()
        Dim icon As String = "icon/item/bow_icon.tga"
        Dim item As String = "d:/ymir work/item/weapon/plechi_arch_t2.gr2"
        Dim category As String = "WEAPON"
        Dim tab As Char = vbTab
        Dim list As List(Of String) = New List(Of String)
        Dim startIndex As Integer = 200753
        Dim numberOfRows As Integer = 10

        For i As Integer = startIndex To startIndex + numberOfRows
            list.Add(i.ToString() + tab + category + tab + icon + tab + item)
        Next

        System.IO.File.WriteAllLines("Ausgabe.txt", list)

    End Sub

End Module