Public Class Month2Age

    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim sqlConnect As SQLConnectClass

    Public Sub SetID(s As SQLConnectClass)
        sqlConnect = s
    End Sub
    Private Sub MonthHigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
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

        '押されたキーが「0～9でない場合」かつ「BackSpaceでない場合」イベントをキャンセルする
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

    Private Sub 名前を付けて保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 名前を付けて保存ToolStripMenuItem.Click

        Dim sqlString As String = Input_month_main_high()

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else

            sqlConnect.DBConnect("SELECT MAX(month_main_2to2_id) FROM child_monthplan_main_2to2;")
            Dim ds As DataSet = sqlConnect.DBResult()
            Dim dt As DataTable = ds.Tables.Item(0)
            Dim mainID As String = dt.Rows(0).Item(0)
            For i = 0 To 5
                Dim s As String = Input_month_table_high(i, mainID)
                If sqlConnect.DBConnect(s) = False Then
                    MsgBox(sqlConnect.ErrorMessage)
                End If
            Next
        End If
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    '読解性上昇のために作成した関数
    Private Function Input_month_main_high() As String
        Dim sqlString As String

        sqlString = "INSERT INTO " _
                        & "`child_monthplan_main_2to2`" _
                    & "(" _
                        & "`ClassName`,`BoysNumber`, `GirlsNumber`," _
                        & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                        & "`LeaderName`, `StateMonth`," _
                        & "`AimNursing`, `AimEducation`," _
                        & "`Event`, `Contents`, `HealthSafety`," _
                        & "`EnvironmentalComposition`, `Eat`," _
                        & "`EvaluationReflection`, `NextPoint`, `UpdateDate`" _
                    & ")" _
                    & "VALUES (" _
                               & "'" & ClassName.Text & "'" _
                        & ", " & "'" & TextBoxBoysNumber.Text & "'" _
                        & ", " & "'" & TextBoxGirlsNumber.Text & "'" _
                        & ", NOW()" _
                        & ", " & "'" & TargetYear.Text & "'" _
                        & ", " & "'" & TargetMonth.Text & "'" _
                        & ", " & "'" & LeaderName.Text & "'" _
                        & ", " & "'" & StateMonth.Text & "'" _
                        & ", " & "'" & AimNursing.Text & "'" _
                        & ", " & "'" & AimEducation.Text & "'" _
                        & ", " & "'" & RichTextBox_Event.Text & "'" _
                        & ", " & "'" & Contents.Text & "'" _
                        & ", " & "'" & HealthSafety.Text & "'" _
                        & ", " & "'" & EnvironmentalComposition.Text & "'" _
                        & ", " & "'" & Eat.Text & "'" _
                        & ", " & "'" & EvaluationReflection.Text & "'" _
                        & ", " & "'" & NextPoint.Text & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_month_table_high(i As Integer, main_id As String) As String
        '確実に六回のみ呼び出してください
        Dim sqlString As String
        Dim ChildName = New ComboBox() {
                ChildName1,
                ChildName2,
                ChildName3,
                ChildName4,
                ChildName5,
                ChildName6
            }
        Dim ChildAge = New NumericUpDown() {
                ChildAge1,
                ChildAge2,
                ChildAge3,
                ChildAge4,
                ChildAge5,
                ChildAge6
            }
        Dim ChildAim = New RichTextBox() {
                ChildAim1,
                ChildAim2,
                ChildAim3,
                ChildAim4,
                ChildAim5,
                ChildAim6
            }
        Dim NurseryTeachers = New RichTextBox() {
                NurseryTeachers1,
                NurseryTeachers2,
                NurseryTeachers3,
                NurseryTeachers4,
                NurseryTeachers5,
                NurseryTeachers6
            }
        Dim Contact = New RichTextBox() {
                Contact1,
                Contact2,
                Contact3,
                Contact4,
                Contact5,
                Contact6
            }
        sqlString = "INSERT INTO " _
                        & "`child_monthplan_table_2to2`" _
                    & "(" _
                        & "`month_main_2to2_id`, " _
                        & "`ChildName`, " _
                        & "`ChildAge`, " _
                        & "`ChildAim`, " _
                        & "`NurseryTeachers`, " _
                        & "`Contact`" _
                    & ")" _
                    & " VALUES(" _
                        & " " & main_id & "," _
                        & "'" & ChildName(i).Text & "'," _
                        & "'" & ChildAge(i).Text & "'," _
                        & "'" & ChildAim(i).Text & "'," _
                        & "'" & NurseryTeachers(i).Text & "'," _
                        & "'" & Contact(i).Text & "'" _
                    & ");"

        Return sqlString
    End Function


    Private Sub MonthHigh_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub BunifuVTrackbar2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
End Class