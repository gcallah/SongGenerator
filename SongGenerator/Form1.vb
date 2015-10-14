Public Class Form1
    ' Public Property subjects As String() = {"My lady ", "My truck ", "My beer ", "Some outlaws ",
    ' "A horse ", "Some cowboys ", "Hank Williams ", "Johnny Cash ", "My country ", "America ", "My bar ",
    ' "A locomotive ", "A freight train ", "Your sugar daddies ", "My windshield wipers "}
    ' Public Property predicates As String() = {"ran over ", "shot ", "loves ", "gambled away ", "rounded up ",
    '  "drank up all of ", "has captured ", "wants to kiss ", "rode down to ", "is filled with ", "is hunting ",
    ' "square danced with ", "is made for ", "comes running back to "}
    'Public Property objects As String() = {"my heart", "some whiskey", "the flag", "a deck of cards",
    '   "the blue jeans", "some good stuff", "a Chevy", "in prison", "a gambler", "your cheatin' heart",
    '  "a country road", "the trailer park ", "some rednecks", "low places", "my cowboy boots",
    '  "that lonesome whistle", "a bartender", "all alone", "a thousand lonely nights", "that lonesome highway",
    '  "the driving rain"}

    Private Sub MakeSongButton_Click(sender As Object, e As EventArgs) Handles MakeSongButton.Click
        Dim subjects(), predicates(), objects() As String
        subjects = ReadFile("..\..\subjects.txt")
        predicates = ReadFile("..\..\predicates.txt")
        objects = ReadFile("..\..\objects.txt")

        Dim result As String = ""
        Dim i As Integer = 0
        Do While i < 8
            VBMath.Randomize()
            Dim j As Integer = CInt(VBMath.Rnd() * (subjects.Length - 1))
            result &= subjects(j)
            result &= " "
            j = CInt(VBMath.Rnd() * (predicates.Length - 1))
            result &= predicates(j)
            result &= " "
            j = CInt(VBMath.Rnd() * (objects.Length - 1))
            result &= objects(j)
            result &= vbNewLine
            i = i + 1
        Loop
        ResultBox.Text = result
    End Sub

    Private Function ReadFile(ByRef fileName) As String()
        Dim fileReader As String
        Dim resultArr() As String

        fileReader = My.Computer.FileSystem.ReadAllText(fileName)
        resultArr = Split(fileReader, vbNewLine)
        Return resultArr

    End Function
End Class
