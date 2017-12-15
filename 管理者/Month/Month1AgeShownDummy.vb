Public Class Month1AgeShownDummy

    ' 投げやりコード

    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim ht_eventbox As Hashtable = New Hashtable
    Dim id As String
    Dim sqlConnect As SQLConnectClass

    ' データ受け渡し用関数 ついでにコネクトクラスも
    Public Sub SetID(i As String, s As SQLConnectClass)
        id = i
        sqlConnect = s

        If sqlConnect.DBConnect("SELECT * FROM child_monthplan_main_0to1 WHERE month_main_0to1_id = '" & id & "'") = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else

            '反映させる
            Draw_main(sqlConnect.DBResult().Tables.Item(0))

            '表への反映確認
            Dim sqlString As String = "SELECT COUNT(*) " _
            & "FROM `child_monthplan_table_0to1` " _
            & "WHERE " & id & " = month_main_0to1_id;"
            sqlConnect.DBConnect(sqlString)

            If sqlConnect.DBResult(0) = 5 Then
                '表への反映
                sqlString = "SELECT * " _
                            & "FROM `child_monthplan_table_0to1` " _
                            & "WHERE " & id & " = month_main_0to1_id;"
                sqlConnect.DBConnect(sqlString)

                Draw_table(sqlConnect.DBResult().Tables.Item(0))
            End If
        End If
        MsgBox("反映完了!!", MsgBoxStyle.OkOnly, "確認画面")

    End Sub

    Private Sub Draw_main(dt As DataTable)
        ComboBox_ClassName.Text = dt.Rows(0).Item("ClassName").ToString
        TextBoxBoysNumber.Text = dt.Rows(0).Item("BoysNumber").ToString
        TextBoxGirlsNumber.Text = dt.Rows(0).Item("GirlsNumber").ToString
        ComboBoxTargetYear.Text = dt.Rows(0).Item("TargetYear").ToString
        ComboBoxTargetMonth.Text = dt.Rows(0).Item("TargetMonth").ToString
        ComboBoxLeaderName.Text = dt.Rows(0).Item("LeaderName").ToString
        RichTextBoxStateMonth.Text = dt.Rows(0).Item("StateMonth").ToString
        RichTextBoxAimNursing.Text = dt.Rows(0).Item("AimNursing").ToString
        RichTextBoxAimEducation.Text = dt.Rows(0).Item("AimEducation").ToString
        RichTextBoxEvent.Text = dt.Rows(0).Item("Event").ToString
        RichTextBoxContents.Text = dt.Rows(0).Item("Contents").ToString
        RichTextBoxEnvironmentalComposition.Text = dt.Rows(0).Item("EnvironmentalComposition").ToString
        RichTextBoxHealthSafety.Text = dt.Rows(0).Item("HealthSafety").ToString
    End Sub

    Private Sub Draw_table(dt As DataTable)
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
        For i = 0 To 5
            児童名(i).Text = dt.Rows(i).Item("ChildName").ToString
            児童年齢(i).Text = dt.Rows(i).Item("ChildAge").ToString
            予想子ども(i).Text = dt.Rows(i).Item("ChildActivities").ToString
            保育士(i).Text = dt.Rows(i).Item("NurseryTeachers").ToString
            連絡(i).Text = dt.Rows(i).Item("Contact").ToString
        Next
    End Sub

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


    Private Sub 名前を付けて保存ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim prgsForm As New ProgressStatesForm
        prgsForm.Show()
        prgsForm.ProgressStatesMaxSet(100)
        prgsForm.ProgressStatesLabelUpdate(1)
        prgsForm.ProcessContentsSet("SQL接続確認中...")
        hashTableAdd()

        Dim sqlString As String = Input_month_main_low()
        Dim sqlConnect As New SQLConnectClass

        prgsForm.ProgressStatesLabelUpdate(20)
        prgsForm.ProcessContentsSet("SQL接続確認終了")

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else
            sqlConnect.DBConnect("SELECT MAX(month_main_0to1_id) FROM child_monthplan_main_0to1;")
            prgsForm.ProgressStatesLabelUpdate(10)
            prgsForm.ProcessContentsSet("メインデータ保存終了")

            Dim mainID As String = sqlConnect.DBResult(0)

            For i = 0 To 5
                Dim s As String = Input_month_table_low(i, mainID)
                sqlConnect.DBConnect(s)
                prgsForm.ProgressStatesLabelUpdate(10)
                prgsForm.ProcessContentsSet("サブデータ[ " & (i + 1) & " ]保存中")
            Next
        End If

        Dim msg As MsgBoxResult = MsgBox("今回の内容を週案に反映させますか？", MsgBoxStyle.YesNoCancel, "反映確認")

        If msg = vbYes Then
            If sqlConnect.DBConnect(Input_out_nextmonth()) = False Then
                MsgBox(sqlConnect.ErrorMessage)
            End If
        End If
        prgsForm.ProgressStatesLabelUpdate(100)
        prgsForm.ProcessContentsSet("終了")
        prgsForm.ProgressStatesEnd()
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    Private Sub hashTableAdd()
        ht_eventbox.Clear()
        ht_eventbox.Add("ClassName", ComboBox_ClassName.Text)
        ht_eventbox.Add("BoysNumber", TextBoxBoysNumber.Text)
        ht_eventbox.Add("GirlsNumber", TextBoxGirlsNumber.Text)
        ht_eventbox.Add("TargetYear", ComboBoxTargetYear.Text)
        ht_eventbox.Add("TargetMonth", ComboBoxTargetMonth.Text)
        ht_eventbox.Add("LeaderName", ComboBoxLeaderName.Text)
        ht_eventbox.Add("StateMonth", RichTextBoxStateMonth.Text)
        ht_eventbox.Add("AimNursing", RichTextBoxAimNursing.Text)
        ht_eventbox.Add("AimEducation", RichTextBoxAimEducation.Text)
        ht_eventbox.Add("Event", RichTextBoxEvent.Text)
        ht_eventbox.Add("Contents", RichTextBoxContents.Text)
        ht_eventbox.Add("HealthSafety", RichTextBoxHealthSafety.Text)
        ht_eventbox.Add("EnvironmentalComposition", RichTextBoxEnvironmentalComposition.Text)
        ht_eventbox.Add("NextPoint", RichTextBoxNextPoint.Text)
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
                        & "'" & CStr(ht_eventbox("ClassName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("BoysNumber")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("GirlsNumber")) & "'" _
                        & ", NOW()" _
                        & ", " & "'" & CStr(ht_eventbox("TargetYear")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("TargetMonth")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("LeaderName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("StateMonth")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("AimNursing")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("AimEducation")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("Event")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("Contents")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("HealthSafety")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("EnvironmentalComposition")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("NextPoint")) & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_out_nextmonth() As String

        'クラス名・人数・作成日・対象年月
        '指導者名・更新日をつけつつ、
        '"内容"を前月の様子にいれる

        Dim TargetYear As Integer = Integer.Parse(CStr(ht_eventbox("TargetYear")))
        Dim TargetMonth As Integer = Integer.Parse(CStr(ht_eventbox("TargetMonth")))
        Dim dt As DateTime = DateTime.Parse(TargetYear & "/" & TargetMonth & "/1")

        dt = dt.AddMonths(1)

        TargetYear = dt.Year
        TargetMonth = dt.Month

        Dim sqlString As String = "INSERT INTO " _
                    & "`child_monthplan_main_0to1`" _
                        & "(" _
                            & "`ClassName`, `BoysNumber`, `GirlsNumber`," _
                            & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                            & "`LeaderName`, `StateMonth`, `UpdateDate`" _
                        & ")" _
                    & "VALUES (" _
                        & "'" & CStr(ht_eventbox("ClassName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("BoysNumber")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("GirlsNumber")) & "'" _
                        & ", NOW()" _
                        & ", " & "'" & TargetYear.ToString & "'" _
                        & ", " & "'" & TargetMonth.ToString & "'" _
                        & ", " & "'" & CStr(ht_eventbox("LeaderName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("Contents")) & "'" _
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


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
End Class

