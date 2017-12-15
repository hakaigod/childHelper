Public Class MonthLow
    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox

    Private Sub MonthLow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddEventHandler()
    End Sub

    Private Sub AddEventHandler()
        'イベントハンドラ受け入れ先作成
        Me.TextBoxChildrenNum = New System.Windows.Forms.TextBox(1) _
            {TextBoxBoysNumber, TextBoxGirlsNumber}
        'イベントハンドラの登録
        Dim i As Integer
        For i = 0 To Me.TextBoxChildrenNum.Length - 1
            AddHandler Me.TextBoxChildrenNum(i).KeyPress, _
                AddressOf Me.Num_KeyPress
            AddHandler Me.TextBoxChildrenNum(i).TextChanged, _
                AddressOf Me.AutoSum
            AddHandler Me.TextBoxChildrenNum(i).Enter, _
                AddressOf Me.AutoText_Enter
            AddHandler Me.TextBoxChildrenNum(i).Leave, _
                AddressOf Me.AutoText_Leave
        Next i
    End Sub

    Private Sub Num_KeyPress(ByVal sender As Object, _
            ByVal e As KeyPressEventArgs)
        ' テキストの長さ上限値
        Dim textLength = 2
        Dim tBox As TextBox = CType(sender, System.Windows.Forms.TextBox)

        '押されたキーが「0〜9でない場合」かつ「BackSpaceでない場合」イベントをキャンセルする
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        tBox.MaxLength = textLength
    End Sub
    Private Sub AutoSum(ByVal sender As Object, ByVal e As EventArgs)
        'フォーム上のものからとってくる
        Dim strX As String = TextBoxBoysNumber.Text
        Dim strY As String = TextBoxGirlsNumber.Text
        Dim result As Label = LabelSum

        '計算に使う変数
        Dim x As Integer = 0
        Dim y As Integer = 0

        'strXとstrYを数値に変換する
        If strX <> "" Then x = Integer.Parse(strX)
        If strY <> "" Then y = Integer.Parse(strY)

        If x = 0 And y = 0 Then
            result.Text = ""
        Else
            result.Text = x + y
        End If
    End Sub
    Private Sub AutoText_Enter(sender As Object, e As EventArgs)
        Dim tBox As TextBox = CType(sender, System.Windows.Forms.TextBox)
        If tBox.Text = "0" Then
            tBox.Clear()
        End If
    End Sub
    Private Sub AutoText_Leave(sender As Object, e As EventArgs)
        Dim tBox As TextBox = CType(sender, System.Windows.Forms.TextBox)
        If tBox.Text = "" Then
            tBox.Text = "0"
        End If
    End Sub


    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs)
        Dim sqlString As String = Input_month_main_low()
        Dim sqlConnect As New SQLConnectClass

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else
            sqlConnect.DBConnect("SELECT MAX(month_main_low_id) FROM child_monthplan_main_low;")
            Dim ds As DataSet = sqlConnect.DBResult()
            Dim dt As DataTable = ds.Tables.Item(0)
            Dim mainID As String = dt.Rows(0).Item(0)
            For i = 0 To 5
                Dim s As String = Input_month_table_low(i, mainID)
                sqlConnect.DBConnect(s)
            Next
        End If
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    '読解性上昇のために作成した関数
    Private Function Input_month_main_low() As String
        Dim sqlString As String

        sqlString = "INSERT INTO " _
                    & "`child_monthplan_main_0to1`" _
                        & "(" _
                            & "`ClassName`, `BoysNumber`, `GirlsNumber`," _
                            & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                            & "`LeaderName`, `StateMonth`," _
                            & "`AimNursing`, `AimEducation`," _
                            & "`Event`, `Contents`, `HealthSafety`," _
                            & "`EnvironmentalComposition`, `NextPoint`, `UpdateDate`" _
                        & ")" _
                    & "VALUES (" _
                        & "'" & ComboBox_ClassName.Text & "'" _
                        & ", " & "'" & TextBoxBoysNumber.Text & "'" _
                        & ", " & "'" & TextBoxGirlsNumber.Text & "'" _
                        & ", NOW()" _
                        & ", " & "'" & ComboBoxTargetYear.Text & "'" _
                        & ", " & "'" & ComboBoxTargetMonth.Text & "'" _
                        & ", " & "'" & ComboBoxLeaderName.Text & "'" _
                        & ", " & "'" & RichTextBoxStateMonth.Text & "'" _
                        & ", " & "'" & RichTextBoxAimNursing.Text & "'" _
                        & ", " & "'" & RichTextBoxAimEducation.Text & "'" _
                        & ", " & "'" & RichTextBoxEvent.Text & "'" _
                        & ", " & "'" & RichTextBoxContents.Text & "'" _
                        & ", " & "'" & RichTextBoxHealthSafety.Text & "'" _
                        & ", " & "'" & RichTextBoxEnvironmentalComposition.Text & "'" _
                        & ", " & "'" & RichTextBoxNextPoint.Text & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_month_table_low(i As Integer, main_id As String) As String
        Dim sqlString As String
        Dim 児童名 = New ComboBox() {
               ComboBoxChildName1, ComboBoxChildName2, ComboBoxChildName3, _
               ComboBoxChildName4, ComboBoxChildName5, ComboBoxChildName6 _
            }
        Dim 児童年齢 = New NumericUpDown() {
                NumericUpDownChildAge1, NumericUpDownChildAge2, _
                NumericUpDownChildAge3, NumericUpDownChildAge4, _
                NumericUpDownChildAge5, NumericUpDownChildAge6
            }
        Dim 予想子ども = New RichTextBox() {
                RichTextBoxExpectesChild1, RichTextBoxChildActivities2, _
                RichTextBoxChildActivities3, RichTextBoxChildActivities4, _
                RichTextBoxChildActivities5, RichTextBoxChildActivities6
            }
        Dim 保育士 = New RichTextBox() {
                RichTextBoxNurseryTeachers1, RichTextBoxNurseryTeachers2, _
                RichTextBoxNurseryTeachers3, RichTextBoxNurseryTeachers4, _
                RichTextBoxNurseryTeachers5, RichTextBoxNurseryTeachers6
            }
        Dim 連絡 = New RichTextBox() {
            RichTextBox6, RichTextBox5, RichTextBox4, _
            RichTextBox3, RichTextBox2, RichTextBox1 _
        }
        sqlString = "INSERT INTO " _
                    & "`child_monthplan_table_0to1`" _
                    & "(" _
                        & "`month_main_0to1_id`," _
                        & "`ChildName`," _
                        & "`ChildAge`," _
                        & "`ChildActivities`," _
                        & "`NurseryTeachers`," _
                        & "`Contact`" _
                    & ")" _
                    & " VALUES(" _
                        & " " & main_id & "," _
                        & "'" & 児童名(i).Text & "'," _
                        & "'" & 児童年齢(i).Text & "'," _
                        & "'" & 予想子ども(i).Text & "'," _
                        & "'" & 保育士(i).Text & "'" _
                        & "'" & 連絡(i).Text & "'" _
                    & ");"

        Return sqlString
    End Function

    Private Sub MonthLow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub


End Class

