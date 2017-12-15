Public Class Month35Age
    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim sqlConnect As SQLConnectClass

    Public Sub SetID(s As SQLConnectClass)
        sqlConnect = s
    End Sub
    Private Sub MonthHigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        AddEventHandler()

        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
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

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs)


        Dim sqlString As String = Input_month_main_high()
        Dim sqlConnect As New SQLConnectClass

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else

            sqlConnect.DBConnect("SELECT MAX(month_main_high_id) FROM child_monthplan_main_high;")
            Dim ds As DataSet = sqlConnect.DBResult()
            Dim dt As DataTable = ds.Tables.Item(0)
            Dim mainID As String = dt.Rows(0).Item(0)
            For i = 0 To 2
                Dim s As String = Input_month_table_high(i, mainID)
                sqlConnect.DBConnect(s)
            Next
        End If
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    '読解性上昇のために作成した関数
    Private Function Input_month_main_high() As String
        Dim sqlString As String

        sqlString = "INSERT INTO " _
                    & "`child_monthplan_main_3to5`" _
                        & "(" _
                            & "`ClassName`, `BoysNumber`, `GirlsNumber`," _
                            & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                            & "`StateMonth`, `Aim`," _
                            & "`LeaderName`, `EvaluationTeacher`, `CollaborationRegion`," _
                            & "`Event`, `CollaborationStaff`, `CooperationHome`," _
                            & "`SpecificChild`, `UpdateDate`" _
                        & ")" _
                    & "VALUES (" _
                               & "'" & ComboBoxClassName.Text & "'" _
                        & ", " & "'" & TextBoxBoysNumber.Text & "'" _
                        & ", " & "'" & TextBoxGirlsNumber.Text & "'" _
                        & ", NOW()" _
                        & ", " & "'" & ComboBoxTargetYear.Text & "'" _
                        & ", " & "'" & ComboBoxTargetMonth.Text & "'" _
                        & ", " & "'" & RichTextBoxStateMonth.Text & "'" _
                        & ", " & "'" & RichTextBoxAim.Text & "'" _
                        & ", " & "'" & ComboBoxLeaderName.Text & "'" _
                        & ", " & "'" & RichTextBoxEvaluationTeacher.Text & "'" _
                        & ", " & "'" & RichTextBoxCollaborationRegion.Text & "'" _
                        & ", " & "'" & RichTextBoxEvent.Text & "'" _
                        & ", " & "'" & RichTextBoxCollaborationStaff.Text & "'" _
                        & ", " & "'" & RichTextBoxCooperationHome.Text & "'" _
                        & ", " & "'" & RichTextBoxSpecificChild.Text & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_month_table_high(i As Integer, main_id As String) As String
        '確実に三回のみ呼び出してください
        Dim sqlString As String
        Dim type = New String() {
            "Nursing", "Education", "Food"
            }
        Dim Contents = New RichTextBox() {
                RichTextBoxNursingContents,
                RichTextBoxEducationContents,
                RichTextBoxFoodContents
            }
        Dim EnvironmentalComposition = New RichTextBox() {
                RichTextBoxNursingConstitution,
                RichTextBoxEducationConstitution,
                RichTextBoxFoodConstitution
            }
        Dim ExpectedChild = New RichTextBox() {
                RichTextBoxNursingExpectedChild,
                RichTextBoxEducationExpectedChild,
                RichTextBoxFoodExpectedChild
            }
        Dim ChildcareAssistance = New RichTextBox() {
                RichTextBoxNursingAssistance,
                RichTextBoxEducationAssistance,
                RichTextBoxFoodAssistance
            }
        sqlString = "INSERT INTO " _
                    & "`child_monthplan_table_3to5`" _
                    & "(" _
                        & "`month_main_3to5_id`," _
                        & "`type`," _
                        & "`Contents`," _
                        & "`EnvironmentalComposition`," _
                        & "`ExpectedChild`," _
                        & "`ChildcareAssistance`" _
                    & ")" _
                    & " VALUES(" _
                        & " " & main_id & "," _
                        & "'" & type(i) & "'," _
                        & "'" & Contents(i).Text & "'," _
                        & "'" & EnvironmentalComposition(i).Text & "'," _
                        & "'" & ExpectedChild(i).Text & "'," _
                        & "'" & ChildcareAssistance(i).Text & "'" _
                    & ");"

        Return sqlString
    End Function


    Private Sub MonthHigh_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub Xend_Click(sender As Object, e As EventArgs)
        Owner.Enabled = True
        Me.Dispose()
    End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

End Class