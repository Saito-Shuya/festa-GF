Public Class Form2
    Dim pic(11) As String
    Dim z As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' 景品を表示する関数
    Private Sub box()
        i += 1
        Dim f4 As New Form4

        ' 表示する関数
        f4.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        box()
        PictureBox1.Image = Nothing
        Label1.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        box()
        PictureBox2.Image = Nothing
        Label2.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        box()
        PictureBox3.Image = Nothing
        Label3.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        box()
        PictureBox4.Image = Nothing
        Label4.Visible = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        box()
        PictureBox5.Image = Nothing
        Label5.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        box()
        PictureBox7.Image = Nothing
        Label7.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        box()
        PictureBox6.Image = Nothing
        Label6.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        box()
        PictureBox8.Image = Nothing
        Label8.Visible = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        box()
        PictureBox9.Image = Nothing
        Label9.Visible = False
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        box()
        PictureBox10.Image = Nothing
        Label10.Visible = False
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        box()
        PictureBox11.Image = Nothing
        Label11.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class