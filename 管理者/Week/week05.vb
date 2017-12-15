Public Class week05

    Private _LabelMonth As New List(Of Label)
    Private _LabelDates As New List(Of Label)
    Private _LabelDays As New List(Of Label)
    Private _RichEnvironment As List(Of RichTextBox)
    Private _RichAction As List(Of RichTextBox)
    Private _RichConsideration As List(Of RichTextBox)

    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox

    Private Sub MonthHigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        AddEventHandler()
    End Sub

    Private Sub AddEventHandler()
        'イベントハンドラ受け入れ先作成
        Me.TextBoxChildrenNum = New System.Windows.Forms.TextBox(1) _
            {TextMen, TextWomen}
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

        '押されたキーが「0～9でない場合」かつ「BackSpaceでない場合」イベントをキャンセルする
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        tBox.MaxLength = textLength
    End Sub
    Private Sub AutoSum(ByVal sender As Object, ByVal e As EventArgs)
        'フォーム上のものからとってくる
        Dim strX As String = TextMen.Text
        Dim strY As String = TextWomen.Text
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

    Private Sub DTP1_ValueChanged(sender As Object, e As EventArgs) Handles DTP1.ValueChanged

        '_LabelDates配列に格納(月)
        Me._LabelMonth.Add(Me.LabelMonth1)
        Me._LabelMonth.Add(Me.LabelMonth2)
        Me._LabelMonth.Add(Me.LabelMonth3)
        Me._LabelMonth.Add(Me.LabelMonth4)
        Me._LabelMonth.Add(Me.LabelMonth5)
        Me._LabelMonth.Add(Me.LabelMonth6)

        '_LabelDates配列に格納(日)
        Me._LabelDates.Add(Me.LabelDate1)
        Me._LabelDates.Add(Me.LabelDate2)
        Me._LabelDates.Add(Me.LabelDate3)
        Me._LabelDates.Add(Me.LabelDate4)
        Me._LabelDates.Add(Me.LabelDate5)
        Me._LabelDates.Add(Me.LabelDate6)

        '_LabelDates配列に格納(曜日)
        Me._LabelDays.Add(Me.LabelDay1)
        Me._LabelDays.Add(Me.LabelDay2)
        Me._LabelDays.Add(Me.LabelDay3)
        Me._LabelDays.Add(Me.LabelDay4)
        Me._LabelDays.Add(Me.LabelDay5)
        Me._LabelDays.Add(Me.LabelDay6)

        '_RichEnvironmentに格納
        ' Me._RichEnvironment.Add(Me.RichEnvironment1)
        ' Me._RichEnvironment.Add(Me.RichEnvironment2)
        '  Me._RichEnvironment.Add(Me.RichEnvironment3)
        ' Me._RichEnvironment.Add(Me.RichEnvironment4)
        ' Me._RichEnvironment.Add(Me.RichEnvironment5)
        'Me._RichEnvironment.Add(Me.RichEnvironment6)

        '_RichActionに格納
        'Me._RichAction.Add(Me.RichAction1)
        ' Me._RichAction.Add(Me.RichAction2)
        ' Me._RichAction.Add(Me.RichAction3)
        'Me._RichAction.Add(Me.RichAction4)
        'Me._RichAction.Add(Me.RichAction5)
        'Me._RichAction.Add(Me.RichAction6)

        '_RichConsiderationに格納
        'Me._RichConsideration.Add(Me.RichConsideration1)
        'Me._RichConsideration.Add(Me.RichConsideration2)
        'Me._RichConsideration.Add(Me.RichConsideration3)
        'Me._RichConsideration.Add(Me.RichConsideration4)
        'Me._RichConsideration.Add(Me.RichConsideration5)
        'Me._RichConsideration.Add(Me.RichConsideration6)


        '上記2つの配列初期化
        '初期化しないと日付変更時に月日曜日の値が残ってしまう
        For reset As Integer = 0 To 5
            Me._LabelMonth(reset).Text = ""
            Me._LabelDates(reset).Text = ""
            Me._LabelDays(reset).Text = ""
        Next reset

        'DTP2へDTP1+5日した日にちを代入()
        DTP2.Value = DTP1.Value.AddDays(5)

        '日付から曜日(日曜日(戻り値:1)～土曜日(戻り値:7)を取得してDTP1WeekDayへ代入)
        Dim DTP1WeekDay As Integer = Weekday(CDate(DTP1.Value))
        Dim DTP2WeekDay As Integer = Weekday(CDate(DTP2.Value))

        If (DTP1WeekDay = 1) Then
            MsgBox("選択した日は休日です。" & Environment.NewLine & "日曜日以外を選択してください。")
            Exit Sub
        End If

        '対象期間が〇曜日～土曜日となるように固定する
        If (DTP2WeekDay < 7) Then
            DTP2.Value = DTP1.Value.AddDays(7 - DTP1WeekDay)
            DTP2WeekDay = Weekday(CDate(DTP2.Value))
        End If

        Dim CountDay As Integer = 1
        Dim SetTextDTP(6) As Date

        'LabelMonth & DayのText変更
        For i As Integer = 0 To DTP2WeekDay - DTP1WeekDay
            '月の判定
            If (DTP1.Value.Month = DTP1.Value.AddDays(i).Month) Then
                Me._LabelMonth(i).Text = DTP1.Value.Month
            Else
                Me._LabelMonth(i).Text = DTP2.Value.Month
            End If

            '日の判定
            If (DTP1.Value.Day <= DTP1.Value.AddDays(i).Day) Then
                Me._LabelDates(i).Text = DTP1.Value.Day + i
            Else
                Me._LabelDates(i).Text += Str(CountDay)
                CountDay += 1
            End If

            '曜日の設定(例："ddd"=月　"dddd"=月曜日)
            Me._LabelDays(i).Text = String.Concat("（", DTP1.Value.AddDays(i).ToString("ddd"), "）")

            '「環境構成」,「予想される子どもの行動」,「保育者の援助と配慮」がnullではなく、かつ空文字列でもない
            '  If (String.IsNullOrEmpty(_RichEnvironment(i).Text) = False Or String.IsNullOrEmpty(_RichAction(i).Text) = False _
            '     Or String.IsNullOrEmpty(_RichConsideration(i).Text) = False) Then
            'SetTextDTP(i) = DTP1.Value.AddDays(i)
            'End If

        Next i
    End Sub

    Private Sub ASave_Click(sender As Object, e As EventArgs) Handles ASave.Click

        Dim sqlString As String = Input_main_sql()
        Dim sqlConnect As New SQLConnectClass

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else

            sqlConnect.DBConnect("SELECT MAX(week_main_0to5_id) FROM child_weekplan_main_0to5;")
            Dim ds As DataSet = sqlConnect.DBResult()
            Dim dt As DataTable = ds.Tables.Item(0)
            Dim mainID As String = dt.Rows(0).Item(0)
            For i = 0 To 5
                Dim s As String = Input_table_sql(i, mainID)
                sqlConnect.DBConnect(s)
            Next
        End If
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    '読解性上昇のために作成した関数
    Private Function Input_main_sql() As String
        Dim sqlString As String

        sqlString = "INSERT INTO " _
                    & "`child_weekplan_main_0to5`" _
                    & "(" _
                        & "`ClassName`, `BoysNumber`, `GirlsNumber`," _
                        & "`CreatedDate`, `TargetYear`, `TargetMonth`, `TargetDay`," _
                        & "`LeaderName`, `Aim`, `CooperationHome`," _
                        & "`StateWeek`, `NextWeek`, `EvaluationReflection`," _
                        & "`ChildEvaluation`, `UpdateDate`" _
                    & ")" _
                    & "VALUES (" _
                               & "'" & ComboClass.Text & "'" _
                        & ", " & "'" & TextMen.Text & "'" _
                        & ", " & "'" & TextWomen.Text & "'" _
                        & ", NOW()" _
                        & ", " & "'" & DTP1.Value.Year.ToString & "'" _
                        & ", " & "'" & DTP1.Value.Month.ToString & "'" _
                        & ", " & "'" & DTP1.Value.Day.ToString & "'" _
                        & ", " & "'" & ComboTeacher.Text & "'" _
                        & ", " & "'" & RichPurpose.Text & "'" _
                        & ", " & "'" & RichFamily.Text & "'" _
                        & ", " & "'" & RichLastWeek.Text & "'" _
                        & ", " & "'" & RichNextWeek.Text & "'" _
                        & ", " & "'" & RichSelfEvaluation.Text & "'" _
                        & ", " & "'" & RichChildEvaluation.Text & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_table_sql(i As Integer, main_id As String) As String
        '確実に六回のみ呼び出してください
        Dim sqlString As String
        Dim TargetMonth = New String() {
                LabelMonth1.Text, LabelMonth2.Text, _
                LabelMonth3.Text, LabelMonth5.Text, _
                LabelMonth5.Text, LabelMonth6.Text _
            }
        Dim TargetDay = New String() {
                LabelDate1.Text, LabelDate2.Text, _
                LabelDate3.Text, LabelDate5.Text, _
                LabelDate5.Text, LabelDate6.Text _
            }
        Dim EnvironmentalComposition = New String() {
                RichEnvironment1.Text,
                RichEnvironment2.Text,
                RichEnvironment3.Text,
                RichEnvironment4.Text,
                RichEnvironment5.Text,
                RichEnvironment6.Text
            }
        Dim ExpectedChild = New String() {
                RichAction1.Text,
                RichAction2.Text,
                RichAction3.Text,
                RichAction4.Text,
                RichAction5.Text,
                RichAction6.Text
            }
        Dim ChildcareAssistance = New String() {
                RichConsideration1.Text,
                RichConsideration2.Text,
                RichConsideration3.Text,
                RichConsideration4.Text,
                RichConsideration5.Text,
                RichConsideration6.Text
            }
        sqlString = "INSERT INTO " _
                    & "`child_monthplan_table_3to5`" _
                    & "(" _
                        & "`week_main_0to5_id`," _
                        & "`TargetMonth`," _
                        & "`TargetDay`," _
                        & "`EnvironmentalComposition`," _
                        & "`ExpectedChild`," _
                        & "`ChildcareAssistance`" _
                    & ")" _
                    & " VALUES(" _
                        & " " & main_id & "," _
                        & "'" & TargetMonth(i) & "'," _
                        & "'" & TargetDay(i) & "'," _
                        & "'" & EnvironmentalComposition(i) & "'," _
                        & "'" & ExpectedChild(i) & "'," _
                        & "'" & ChildcareAssistance(i) & "'" _
                    & ");"

        Return sqlString
    End Function

End Class