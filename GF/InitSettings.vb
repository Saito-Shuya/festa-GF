Imports System.Text
Imports GF.PageSettings
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class InitSettings
    Private jsonFilePath As String = "../../settings/settings.json"

    ' コンストラクタ
    ' settings.jsonからの値をグローバル変数に格納
    Sub New()
        Dim json As Object = Me.getJson()
        prizeLength = json.PrizeAnnouncementPage.imageName.Length ' グローバル変数に景品の個数を格納

        For i = 0 To prizeLength - 1
            prizeList.Add(json.PrizeAnnouncementPage.imageName(i)) ' グローバル変数に景品の画像名を格納
        Next

        prizeImageWidth = json.PrizeAnnouncementPage.prizeImageWidth ' 景品の画像の幅を格納
        prizeImageHeight = json.PrizeAnnouncementPage.prizeImageHeight ' 景品の画像の高さを格納

        prizeFuukunImageProperties = json.PrizeAnnouncementPage.fuukunImage ' PrizeAnnouncementのふう君画像の設定を格納
        prizeBannerProperties = json.PrizeAnnouncementPage.banner ' PrizeAnnouncementのバナー設定を格納

        finalPageSeason = json.FinalPage.season ' 最終ページの表示画像の季節をハロウィンにするか、クリスマスにするかを格納する
    End Sub

    ' settins.jsonの値を返却する
    Public Function getJson()
        Dim sJSON As String
        Dim enc As Encoding = Encoding.UTF8
        Using sr As New System.IO.StreamReader(jsonFilePath, enc)
            sJSON = sr.ReadToEnd()
        End Using
        Dim model As New PageSettings.JsonList
        Dim rows As List(Of PageSettings.JSONRow) = JsonConvert.DeserializeObject(Of List(Of PageSettings.JSONRow))(sJSON)
        model.Rows = rows.ToArray

        Return model.Rows(0)
    End Function

End Class
