Public Class Form1
    Public Property subjects As String() = {"My lady ", "My truck ", "My beer ", "Some outlaws ",
        "A horse ", "Some cowboys ", "Hank Williams "}
    Public Property predicates As String() = {"ran over ", "shot ", "loves ", "gambled away ", "rounded up ",
        "drank up all of "}
    Public Property objects As String() = {"my heart", "some whiskey", "the flag", "a deck of cards",
        "blue jeans", "some good stuff"}

    Private Sub MakeSongButton_Click(sender As Object, e As EventArgs) Handles MakeSongButton.Click
        Dim result As String = ""
        Dim i As Integer = 0
        Do While i < 3
            result &= subjects(i)
            result &= predicates(i)
            result &= objects(i)
            result &= vbNewLine
            i = i + 1
        Loop
        ResultBox.Text = result
    End Sub
End Class
