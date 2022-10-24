Public Class TopPage
    Dim initSetting As InitSettings = New InitSettings() ' settings.jsonに記載されている設定をロード
    Dim prizeTable = New PrizeTable ' 景品一覧フォームのインスタンスを生成する

    ' トップページロード時の初期設定を行う
    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        PrizeNumberTextBox.ResetText() ' 景品番号をリセットする
        PrizeNumberTxtLargeLabel.Text = " " ' 景品番号のラベルの文字をリセットする
        ActiveControl = PrizeNumberTextBox ' 景品番号を書くテキストボックスを選択状態にする

        prizeTable.Show() ' 景品一覧を表示する
        Me.Activate() ' トップページをアクティブにする
    End Sub

    ' トップページがアクティブのウィンドウになったときに、景品番号を書くテキストボックスを選択状態にする
    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveControl = PrizeNumberTextBox
    End Sub

    ' 景品番号を書くテキストボックスの値が変更時に、ラベルを変更する
    Private Sub PrizeNumberLabelHandler(sender As Object, e As EventArgs) Handles PrizeNumberTextBox.TextChanged
        PrizeNumberTxtLargeLabel.Text = PrizeNumberTextBox.Text
    End Sub

    ' リセットボタンをクリックした際に、テキストボックスとラベルをリセットする
    Private Sub ResetPrizeNumber(sender As Object, e As EventArgs) Handles ResetBtn.Click
        PrizeNumberTextBox.ResetText()
        PrizeNumberTxtLargeLabel.Text = " "
    End Sub

    ' 景品　ボタンを押したときに、景品一覧を表示する
    Private Sub TransitionPrizeTable(sender As Object, e As EventArgs) Handles TransitionPrizeTableBtn.Click
        ' ミス回避用に、景品が入ってないときは、景品一覧に遷移しないように制御
        If (PrizeNumberTextBox.Text.Length > 0) Then
            prizeTable.Activate()
            PrizeNumberTextBox.ResetText()
            PrizeNumberTxtLargeLabel.Text = " "
        End If
    End Sub

    ' KeyPressイベントハンドラ一覧
    ' トップページのときのみ作動する
    Private Sub Toppage_KeyPressEventHandler(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
          Handles PrizeNumberTextBox.KeyPress

        'EnterやEscapeキーでビープ音が鳴らないようにする
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) OrElse
            e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            e.Handled = True
        End If

        'Enterキーで景品一覧ページに遷移する
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If (PrizeNumberTextBox.Text.Length > 0) Then
                prizeTable.Activate()
                PrizeNumberTextBox.ResetText()
                PrizeNumberTxtLargeLabel.Text = " "
            End If
        End If

        ' Escape でアプリケーション終了
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Application.Exit()
        End If
    End Sub
End Class
