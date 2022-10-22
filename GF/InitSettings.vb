Imports System.Text
Imports Newtonsoft.Json

Public Class InitSettings
    Private jsonFilePath As String = "../../settings/settings.json"

    ' コンストラクタの設定
    Sub New()
        Dim jsonList As New List(Of String)(CType(Me.getJson(), IEnumerable(Of String)))
        prizeLength = jsonList.Count ' グローバル変数に景品の個数を格納

        For i = 0 To jsonList.Count - 1
            prizeList.Add(jsonList(i))
            Console.WriteLine(prizeList(i))
        Next
    End Sub

    ' settins.jsonのimageNameを返却する
    Public Function getJson()
        Dim sJSON As String
        Dim enc As Encoding = Encoding.UTF8
        Using sr As New System.IO.StreamReader(jsonFilePath, enc)
            sJSON = sr.ReadToEnd()
        End Using
        Dim model As New Prize.JsonList
        Dim rows As List(Of Prize.JSONRow) = JsonConvert.DeserializeObject(Of List(Of Prize.JSONRow))(sJSON)
        model.Rows = rows.ToArray

        Return model.Rows(0).imageName
    End Function

End Class
