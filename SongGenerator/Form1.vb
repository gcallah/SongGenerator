Public Class Form1
    Public Property subjects As String() = {"My lady ", "My truck ", "My beer ", "Some outlaws ",
        "A horse ", "Some cowboys ", "Hank Williams ", "Johnny Cash ", "My country ", "America"}
    Public Property predicates As String() = {"ran over ", "shot ", "loves ", "gambled away ", "rounded up ",
        "drank up all of ", "has captured ", "wants to kiss ", "rode down to "}
    Public Property objects As String() = {"my heart", "some whiskey", "the flag", "a deck of cards",
        "the blue jeans", "some good stuff", "a Chevy", "in prison", "a gambler", "your cheatin' heart",
        "a country road"}

    Private Sub MakeSongButton_Click(sender As Object, e As EventArgs) Handles MakeSongButton.Click
        Dim result As String = ""
        Dim i As Integer = 0
        Do While i < 4
            VBMath.Randomize()
            Dim j As Integer = CInt(VBMath.Rnd() * (subjects.Length - 1))
            result &= subjects(j)
            j = CInt(VBMath.Rnd() * (predicates.Length - 1))
            result &= predicates(j)
            j = CInt(VBMath.Rnd() * (objects.Length - 1))
            result &= objects(j)
            result &= vbNewLine
            i = i + 1
        Loop
        ResultBox.Text = result
    End Sub
End Class
