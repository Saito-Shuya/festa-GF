Public Class Form5
    Dim z As Integer = 0
    Public pic(15)

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (i < 15) Then
            Form1.Activate()
            Me.Close()
        Else
            Dim f6 As New Form6
            f6.Show()
        End If
    End Sub
    Private Function Label1() As Object
        Throw New NotImplementedException
    End Function
End Class