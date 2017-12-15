<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClass
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextCluss = New System.Windows.Forms.TextBox()
        Me.Man = New System.Windows.Forms.TextBox()
        Me.Girl = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrerMessage1 = New System.Windows.Forms.Label()
        Me.ErrerMessage2 = New System.Windows.Forms.Label()
        Me.ErrerMessage3 = New System.Windows.Forms.Label()
        Me.ErrerMessage4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "神がかりなボタン"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextCluss
        '
        Me.TextCluss.Location = New System.Drawing.Point(117, 42)
        Me.TextCluss.Name = "TextCluss"
        Me.TextCluss.Size = New System.Drawing.Size(100, 19)
        Me.TextCluss.TabIndex = 1
        '
        'Man
        '
        Me.Man.Location = New System.Drawing.Point(126, 92)
        Me.Man.Name = "Man"
        Me.Man.Size = New System.Drawing.Size(31, 19)
        Me.Man.TabIndex = 2
        '
        'Girl
        '
        Me.Girl.Location = New System.Drawing.Point(218, 92)
        Me.Girl.Name = "Girl"
        Me.Girl.Size = New System.Drawing.Size(31, 19)
        Me.Girl.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(117, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "クラス名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "クラス人数"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "男"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "担当"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "女"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "人"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "人"
        '
        'ErrerMessage1
        '
        Me.ErrerMessage1.AutoSize = True
        Me.ErrerMessage1.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage1.Location = New System.Drawing.Point(87, 64)
        Me.ErrerMessage1.Name = "ErrerMessage1"
        Me.ErrerMessage1.Size = New System.Drawing.Size(126, 12)
        Me.ErrerMessage1.TabIndex = 16
        Me.ErrerMessage1.Text = "クラス名を入力してください"
        Me.ErrerMessage1.Visible = False
        '
        'ErrerMessage2
        '
        Me.ErrerMessage2.AutoSize = True
        Me.ErrerMessage2.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage2.Location = New System.Drawing.Point(41, 114)
        Me.ErrerMessage2.Name = "ErrerMessage2"
        Me.ErrerMessage2.Size = New System.Drawing.Size(254, 12)
        Me.ErrerMessage2.TabIndex = 17
        Me.ErrerMessage2.Text = "男女の合計が1以上になるように数字を入れてください"
        Me.ErrerMessage2.Visible = False
        '
        'ErrerMessage3
        '
        Me.ErrerMessage3.AutoSize = True
        Me.ErrerMessage3.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage3.Location = New System.Drawing.Point(87, 162)
        Me.ErrerMessage3.Name = "ErrerMessage3"
        Me.ErrerMessage3.Size = New System.Drawing.Size(149, 12)
        Me.ErrerMessage3.TabIndex = 18
        Me.ErrerMessage3.Text = "担当保育士を選択してください"
        Me.ErrerMessage3.Visible = False
        '
        'ErrerMessage4
        '
        Me.ErrerMessage4.AutoSize = True
        Me.ErrerMessage4.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage4.Location = New System.Drawing.Point(87, 64)
        Me.ErrerMessage4.Name = "ErrerMessage4"
        Me.ErrerMessage4.Size = New System.Drawing.Size(123, 12)
        Me.ErrerMessage4.TabIndex = 19
        Me.ErrerMessage4.Text = "そのクラス名は存在します"
        Me.ErrerMessage4.Visible = False
        '
        'AddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 229)
        Me.Controls.Add(Me.ErrerMessage4)
        Me.Controls.Add(Me.ErrerMessage3)
        Me.Controls.Add(Me.ErrerMessage2)
        Me.Controls.Add(Me.ErrerMessage1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Girl)
        Me.Controls.Add(Me.Man)
        Me.Controls.Add(Me.TextCluss)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddClass"
        Me.Text = "AddClass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextCluss As System.Windows.Forms.TextBox
    Friend WithEvents Man As System.Windows.Forms.TextBox
    Friend WithEvents Girl As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage1 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage2 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage3 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage4 As System.Windows.Forms.Label
End Class
