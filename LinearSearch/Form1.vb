Public Class Form1
    Dim astFruit(9) As String
    Dim stTarget As String
    Dim bFound As Boolean
    Private Sub InitializeData()
        ' Initialize aiData array
        astFruit(1) = "Apple"
        astFruit(2) = "Mango"
        astFruit(3) = "Strawberry"
        astFruit(4) = "Banana"
        astFruit(5) = "Grape"
        astFruit(6) = "Pear"
        astFruit(7) = "Lemon"
        astFruit(8) = "Melon"
        astFruit(9) = "Fig"



    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        InitializeData()
        stTarget = InputBox("Which fruit are you looking for?")
        bFound = False ' Reset the bFound flag

        For i As Integer = 0 To 9
            If astFruit(i).ToUpper = stTarget.ToUpper Then
                bFound = True
                Exit For ' Exit the loop if found
            End If
        Next

        If bFound = True Then
            MsgBox("Found it")
        Else
            MsgBox("Not found")
        End If



    End Sub
End Class
