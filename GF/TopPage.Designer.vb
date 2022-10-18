<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopPage
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopPage))
        Me.TransitionPrizeTableBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.PrizeNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ImgProps = New System.Windows.Forms.PictureBox()
        Me.PrizeNumberTxtLargeLabel = New System.Windows.Forms.Label()
        CType(Me.ImgProps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        '景品ボタン
        '
        Me.TransitionPrizeTableBtn.Location = New System.Drawing.Point(SCREEN_WIDTH - 212, SCREEN_HEIGHT - 170)
        Me.TransitionPrizeTableBtn.Name = "TransitionPrizeTableBtn"
        Me.TransitionPrizeTableBtn.Size = New System.Drawing.Size(112, 24)
        Me.TransitionPrizeTableBtn.TabIndex = 0
        Me.TransitionPrizeTableBtn.Text = "景品"
        Me.TransitionPrizeTableBtn.UseVisualStyleBackColor = True
        '
        'リセットボタン
        '
        Me.ResetBtn.Location = New System.Drawing.Point(SCREEN_WIDTH - 212, SCREEN_HEIGHT - 140)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(112, 22)
        Me.ResetBtn.TabIndex = 1
        Me.ResetBtn.Text = "リセット"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        '景品番号を入力するテキストボックス
        '
        Me.PrizeNumberTextBox.Location = New System.Drawing.Point(SCREEN_WIDTH - 212, SCREEN_HEIGHT - 110)
        Me.PrizeNumberTextBox.Name = "PrizeNumberTextBox"
        Me.PrizeNumberTextBox.Size = New System.Drawing.Size(112, 19)
        Me.PrizeNumberTextBox.TabIndex = 2
        '
        'ふうくん画像
        '
        Me.ImgProps.BackgroundImage = CType(resources.GetObject("ImgProps.FuukunImg"), System.Drawing.Image)
        Me.ImgProps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgProps.Location = New System.Drawing.Point(97, SCREEN_HEIGHT - 350)
        Me.ImgProps.Name = "ImgProps"
        Me.ImgProps.Size = New System.Drawing.Size(250, 241)
        Me.ImgProps.TabIndex = 5
        Me.ImgProps.TabStop = False
        '
        '景品番号　大きい文字
        '
        Me.PrizeNumberTxtLargeLabel.AutoSize = True
        Me.PrizeNumberTxtLargeLabel.Font = New System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 200.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PrizeNumberTxtLargeLabel.Location = New System.Drawing.Point(305, 233)
        Me.PrizeNumberTxtLargeLabel.Name = "PrizeNumberTxtLargeLabel"
        Me.PrizeNumberTxtLargeLabel.Size = New System.Drawing.Size(0, 267)
        Me.PrizeNumberTxtLargeLabel.TabIndex = 6
        '
        'TopPage WindowObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(SCREEN_WIDTH, SCREEN_HEIGHT)
        Me.Controls.Add(Me.PrizeNumberTxtLargeLabel)
        Me.Controls.Add(Me.ImgProps)
        Me.Controls.Add(Me.PrizeNumberTextBox)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.TransitionPrizeTableBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TopPage"
        Me.Text = "TopPage"
        CType(Me.ImgProps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TransitionPrizeTableBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents PrizeNumberTextBox As TextBox
    Friend WithEvents ImgProps As PictureBox
    Friend WithEvents PrizeNumberTxtLargeLabel As System.Windows.Forms.Label
End Class
