
Public Class PrizeAnnouncement
    ' 商品画像押したときに、トップページに戻る処理
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (counter < prizeLength) Then
            TopPage.Activate()
            Me.Close()
        Else
            Dim final_page As New FinalPage
            final_page.Show()
            Me.Close()
        End If
    End Sub

    ' 戻るボタンを押したときの処理
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (counter < prizeLength) Then
            TopPage.Activate()
            Me.Close()
        Else
            Dim final_page As New FinalPage
            final_page.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim workingDir As String = System.Environment.CurrentDirectory
        Dim r As New System.Text.RegularExpressions.Regex("^.*GF\\")
        Dim m As System.Text.RegularExpressions.Match = r.Match(workingDir)
        PictureBox1.Image = System.Drawing.Image.FromFile(m.Value & "settings\images\" & prizeList(counter - 1))
    End Sub
End Class