Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim Name As String
        Dim LastName As String
        Dim Sex As String
        Dim Ocupation As String

        Name = myTextName.Text
        LastName = myTextLastName.Text
        Sex = myTextSex.Text
        Ocupation = ListOcupations.SelectedItem

        MsgBox("Hello my name is: " & Name & " " & LastName & "Soy " & Sex & "And I work how" & Ocupation)


    End Sub




End Class
