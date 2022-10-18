Module GlobalModule
    Public counter As Integer = 0 ' 景品が今何個目まで渡しているのかを格納する
    Public prizeLength As Integer ' 景品が何個用意されるか
    Public prizeList = New List(Of String) ' 景品画像を格納する配列
    Public SCREEN_WIDTH As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' ディスプレイの幅を取得
    Public SCREEN_HEIGHT As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height '　ディスプレイの高さを取得

End Module

