Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For Each
        Dim classData As String
        Dim classList() As String = {"Teknik Informatika - A", "Sistem Infromasi - A", "Teknologi Informasi - A", "Teknik Informatika - B", "Sistem Infromasi - B", "Teknologi Informasi - B"}

        For Each classData In classList
            cb_class.Items.Add(classData)
        Next

        'While
        Dim dateList As Integer = 1

        While dateList <= 31
            cb_date.Items.Add(dateList)
            dateList += 1
        End While

        'Do While
        Dim monthList As Integer = 1
        Do While monthList <= 2000
            cb_month.Items.Add(monthList)
            If monthList = 12 Then
                Exit Do
            End If
            monthList += 1
        Loop

        'For
        Dim yearList As Integer
        For yearList = Year(Now) - 100 To Year(Now)
            cb_year.Items.Add(yearList)
        Next

        'Do Until
        Dim bodyWeight As Integer = 10
        Do Until bodyWeight >= 200
            cb_weight.Items.Add(bodyWeight & " kg")
            bodyWeight += 5
        Loop

        'Do ... Loop While
        Dim bodyHeight As Integer = 10
        Do
            cb_height.Items.Add(bodyHeight & " cm")
            bodyHeight += 5
        Loop While bodyHeight <= 200

        'Do ... Loop Until
        Dim age As Integer = 18
        Do
            cb_age.Items.Add(age & " Tahun")
            age += 1
        Loop Until age > 70
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Data Berhasil Disimpan")
    End Sub
End Class
