Public Class SyntaxTree

    Private Property InputLine As String
    Public Property Parsed As String

    Public Sub DoParse()
        Parsed = InputLine
    End Sub

    Public Sub New(ByVal inputLine As String)
        Me.InputLine = inputLine

        DoParse()
    End Sub
End Class
