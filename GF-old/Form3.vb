Public Class Form3
    Public pic(2)
    Dim sw As New System.Diagnostics.Stopwatch

    Private Shared Property Image As Object
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sw.Start()
        pic(1) = System.Drawing.Image.FromFile("G:\GFプログラミング\GFプログラミング画像\kira1.png")
        pic(2) = System.Drawing.Image.FromFile("G:\GFプログラミング\GFプログラミング画像\kira3.png")
        Timer1.enabled = true

End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static number As Integer = 1
        If number = 0 Then
            BackgroundImage = pic(1)
        ElseIf number = 1 Then
            BackgroundImage = pic(2)
        End If
        number = number + 1
        If number = 2 Then
            number = 0
        End If
        If sw.Elapsed.Seconds = 2 Then
            sw.Reset()
            Timer1.Enabled = False
            Dim f4 As New Form4
            f4.Show()
            Me.Close()
        End If

    End Sub
End Class