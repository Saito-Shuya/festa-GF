Module GlobalModule
    Public counter As Integer = 0 ' 景品が今何個目まで渡しているのかを格納する
    Public prizeLength As Integer ' 景品が何個用意されるか
    Public prizeList = New List(Of String) ' 景品画像を格納する配列
    Public SCREEN_WIDTH As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ' ディスプレイの幅を取得
    Public SCREEN_HEIGHT As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height '　ディスプレイの高さを取得

    Public prizeImageWidth As String
    Public prizeImageHeight As String
    Public prizeFuukunImageProperties As Object
    Public prizeBannerProperties As Object

    Public finalPageSeason As String

    ' TODO: なるべくグローバルにおかないようにする
    ' 時短のため、応急処置
    Public senderId As String ' 押された景品の番号を格納する
End Module

