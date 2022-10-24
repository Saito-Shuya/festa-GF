<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrizeTable
    Inherits System.Windows.Forms.Form

    Private pictureBoxs = New List(Of PictureBox)
    Private labels = New List(Of Label)

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    ' 景品ウィンドウを表示する関数を発火させる
    Private Sub DisplayPrize()
        counter += 1
        Dim prize_announcement As New PrizeAnnouncement
        prize_announcement.Show()
    End Sub

    ' 景品ボックスとラベルを非表示にする
    Private Sub invisiblePictureBox(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim senderPictureBox = CType(sender, PictureBox)
        Dim senderPictureBoxName As String = senderPictureBox.Name
        senderId = senderPictureBoxName.Replace("PictureBox", "") ' グローバルに格納
        Dim senderLabel As Label = Me.labels(senderId)

        senderPictureBox.Image = Nothing
        senderLabel.Visible = False
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrizeTable))

        Console.WriteLine("prizeTable;" + prizeLength.ToString())
        Me.BackBtn = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        ' 各種画像の配置プロパティ
        Dim presentBoxMargin As Integer = 186 ' プレゼントボックスの余白 ボックス同士の余白が広がる
        Dim presentBoxWidthHalf = 49 ' いじっちゃダメ。いじっていいのは、プレゼントボックスの大きさが変わったとき

        Dim firstRowImageHeight As Integer = 210 ' プレゼントボックスの１行目の高さ
        Dim secondRowImageHeight As Integer = 362 ' プレゼントボックスの２行目の高さ
        Dim thirdRowImageHeight As Integer = 512 ' プレゼントボックスの３行目の高さ

        Dim firstRowLabelHeight As Integer = 306 ' ラベルの１行目の高さ
        Dim secondRowLabelHeight As Integer = 452 ' ラベルの２行目の高さ
        Dim thirdRowLabelHeight As Integer = 602 ' ラベルの３行目の高さ

        ' 画像を動的に配置
        For i = 0 To prizeLength
            Me.pictureBoxs.Add(New System.Windows.Forms.PictureBox)
            Me.pictureBoxs(i).BackColor = System.Drawing.Color.White
            Me.pictureBoxs(i).Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.pictureBoxs(i).Name = "PictureBox" + i.ToString()

            Me.pictureBoxs(i).Size = New System.Drawing.Size(99, 87)
            Me.pictureBoxs(i).TabIndex = i
            Me.pictureBoxs(i).TabStop = False

            Dim rowPosition = firstRowImageHeight

            If (10 <= i) Then
                rowPosition = thirdRowImageHeight
            ElseIf (5 <= i) Then
                rowPosition = secondRowImageHeight
            End If

            If (i Mod 5 = 0) Then
                Me.pictureBoxs(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 - presentBoxMargin * 2 - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 1) Then
                Me.pictureBoxs(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 - presentBoxMargin - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 2) Then
                Me.pictureBoxs(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 3) Then
                Me.pictureBoxs(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 + presentBoxMargin - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 4) Then
                Me.pictureBoxs(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 + presentBoxMargin * 2 - presentBoxWidthHalf, rowPosition)
            End If

            Dim pictureBox As PictureBox = Me.pictureBoxs(i)
            AddHandler pictureBox.Click, AddressOf invisiblePictureBox
            AddHandler pictureBox.Click, AddressOf DisplayPrize
        Next i

        ' ラベルを動的に配置
        For i = 0 To prizeLength
            Me.labels.Add(New System.Windows.Forms.Label())
            Me.labels(i).AutoSize = True
            Me.labels(i).BackColor = System.Drawing.Color.Transparent
            Me.labels(i).Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.labels(i).Padding = New Padding(30, 0, 0, 0)
            Me.labels(i).Name = "Label" + i.ToString()
            Me.labels(i).Size = New System.Drawing.Size(39, 38)
            Me.labels(i).TabIndex = prizeLength + i
            Me.labels(i).Text = Chr(Asc("A") + i)

            Dim rowPosition = firstRowLabelHeight

            If (10 <= i) Then
                rowPosition = thirdRowLabelHeight
            ElseIf (5 <= i) Then
                rowPosition = secondRowLabelHeight
            End If

            If (i Mod 5 = 0) Then
                Me.labels(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 - presentBoxMargin * 2 - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 1) Then
                Me.labels(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 - presentBoxMargin - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 2) Then
                Me.labels(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 3) Then
                Me.labels(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 + presentBoxMargin - presentBoxWidthHalf, rowPosition)
            ElseIf (i Mod 5 = 4) Then
                Me.labels(i).Location = New System.Drawing.Point(SCREEN_WIDTH / 2 + presentBoxMargin * 2 - presentBoxWidthHalf, rowPosition)
            End If
        Next i
        '
        'リセットボタン
        '
        Me.BackBtn.Location = New System.Drawing.Point(SCREEN_WIDTH - 212, SCREEN_HEIGHT - 120)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(112, 22)
        Me.BackBtn.TabIndex = 1
        Me.BackBtn.Text = "リセット"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'PrizeTable WindowObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(SCREEN_WIDTH, SCREEN_HEIGHT)

        For i = 0 To prizeLength - 1
            Me.Controls.Add(Me.labels(i))
            Me.Controls.Add(Me.pictureBoxs(i))
        Next i

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrizeTable"
        Me.Text = "PrizeTable"

        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
End Class
