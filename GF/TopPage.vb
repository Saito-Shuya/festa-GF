Public Class TopPage
    Dim json As Json = New Json()
    Dim prizeTable = New PrizeTable

    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        PrizeNumberTextBox.ResetText()
        PrizeNumberTxtLargeLabel.Text = " "
        Me.Activate()

        prizeTable.Show()
    End Sub

    Private Sub PrizeNumberLabelHandler(sender As Object, e As EventArgs) Handles PrizeNumberTextBox.TextChanged
        PrizeNumberTxtLargeLabel.Text = PrizeNumberTextBox.Text
    End Sub

    Private Sub ResetPrizeNumber(sender As Object, e As EventArgs) Handles ResetBtn.Click
        PrizeNumberTextBox.ResetText()
        PrizeNumberTxtLargeLabel.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TransitionPrizeTableBtn.Click
        If (PrizeNumberTextBox.Text.Length > 0) Then
            prizeTable.Activate()
            PrizeNumberTextBox.ResetText()
            PrizeNumberTxtLargeLabel.Text = " "
        End If
    End Sub

    'KeyPressイベントハンドラ
    Private Sub PrizeNumberTextBoxKeyPressHandler(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = PrizeNumberTextBox
    End Sub

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveControl = PrizeNumberTextBox
    End Sub
End Class
