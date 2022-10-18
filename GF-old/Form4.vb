Imports System.Drawing

Public Class Form4

    Dim z As Integer = 0
    Public pic(11) ' 商品画像を格納する配列

    ' 商品画像押したときに、トップページに戻る処理
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (i < 11) Then
            Form1.Activate()
            Me.Close()
        Else
            Dim f6 As New Form6
            f6.Show()
        End If
    End Sub

    ' 戻るボタンを押したときの処理
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Activate()
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        pic(10) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\21gR+fosW0L._SL500_.jpg")
        pic(2) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\5de0ae0b9d057 (1).jpeg")
        pic(3) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\ダウンロード.jfif")
        pic(4) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\4967576491099_L.jpg")
        pic(5) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\sl-010sb_1.jpg")
        pic(6) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\DSC_0295-1024x683.jpg")
        pic(7) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\71b45588f8d31cf924f290c3e0d037d4_a206aaa8c7b90f8bde0fc3073087894b.jpg")
        pic(8) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\OIP.jfif")
        pic(9) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\791847350.jpg")
        pic(1) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\th (1).jfif")
        pic(11) = System.Drawing.Image.FromFile("C:\Users\81704\OneDrive\画像\20170206_bb2b49.jpg")





        PictureBox1.Image = pic(i)



    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles Button1.VisibleChanged

    End Sub

    Private Sub Button1_SizeChanged(sender As Object, e As EventArgs) Handles Button1.SizeChanged

    End Sub
End Class