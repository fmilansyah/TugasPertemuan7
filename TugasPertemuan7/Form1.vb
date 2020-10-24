Public Class Form1
    Private Sub btn_number_1_Click(sender As Object, e As EventArgs) Handles btn_number_1.Click
        Dim i As Integer

        For i = 1 To 4
            list_number_1.Items.Add(i)
        Next
    End Sub

    Private Sub btn_number_2_Click(sender As Object, e As EventArgs) Handles btn_number_2.Click
        Dim i As Integer

        For i = 1 To 4 Step 2
            list_number_2.Items.Add(i)
        Next
    End Sub

    Private Sub btn_number_3_Click(sender As Object, e As EventArgs) Handles btn_number_3.Click
        Dim i As Integer

        For i = 1 To 4
            list_number_3.Items.Add(i + 1)
        Next
    End Sub

    Private Sub btn_number_4_Click(sender As Object, e As EventArgs) Handles btn_number_4.Click
        Dim i As Integer

        For i = 1 To 4
            list_number_4.Items.Add(i & " A")
        Next
    End Sub

    Private Sub btn_number_5_Click(sender As Object, e As EventArgs) Handles btn_number_5.Click
        Dim i As Integer
        Dim a As String

        For i = 1 To 4
            If i Mod 2 = 0 Then
                a = "Genap"
            Else
                a = "Ganjil"
            End If

            list_number_5.Items.Add(i & " " & a)
        Next
    End Sub

    Private Sub btn_number_6_Click(sender As Object, e As EventArgs) Handles btn_number_6.Click
        Dim i As Integer
        Dim j As Integer

        For i = 1 To 4
            For j = 1 To i
                list_number_6.Items.Add(i)
            Next
        Next
    End Sub

    Private Sub btn_number_7_Click(sender As Object, e As EventArgs) Handles btn_number_7.Click
        Dim i As Integer
        Dim j As Integer

        For i = 1 To 4
            For j = 1 To i
                list_number_7.Items.Add(j & " " & i)
            Next
        Next
    End Sub

    Private Sub btn_while_1_Click(sender As Object, e As EventArgs) Handles btn_while_1.Click
        Dim i As Integer
        i = 1
        While i <= 10
            list_while_1.Items.Add(i)
            i = i + 1
        End While
    End Sub

    Private Sub btn_while_2_Click(sender As Object, e As EventArgs) Handles btn_while_2.Click
        Dim i As Integer
        i = 1
        While i <= 10
            list_while_2.Items.Add(i)
            i = i + 2
        End While
    End Sub

    Private Sub btn_while_3_Click(sender As Object, e As EventArgs) Handles btn_while_3.Click
        Dim i As Integer
        i = 1
        While i <= 10
            list_while_3.Items.Add(i + 1)
            i = i + 1
        End While
    End Sub

    Private Sub btn_while_4_Click(sender As Object, e As EventArgs) Handles btn_while_4.Click
        Dim i As Integer
        i = 1
        While i <= 10
            list_while_4.Items.Add(i & " A")
            i = i + 1
        End While
    End Sub

    Private Sub btn_while_5_Click(sender As Object, e As EventArgs) Handles btn_while_5.Click
        Dim i As Integer
        Dim a As String

        i = 1
        While i <= 10
            If i Mod 2 = 0 Then
                a = "Genap"
            Else
                a = "Ganjil"
            End If

            list_while_5.Items.Add(i & " " & a)

            i = i + 1
        End While
    End Sub
End Class
