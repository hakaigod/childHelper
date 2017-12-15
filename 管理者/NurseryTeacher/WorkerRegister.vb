Imports System.Text.RegularExpressions

Public Class TeacherEdit

    Dim Sql As New SQLConnectClass


    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        encsjis = System.Text.Encoding.GetEncoding("Shift_JIS")
        PositionComboBox.SelectedIndex = 1
        Year.Value = Now.Year
    End Sub

    Private Sub RegistrationButton_Click_1(sender As Object, e As EventArgs) Handles RegistrationButton.Click

        Dim atai, atai2, atai3, Errflg, sqlstr

        Errflg = 0

        '姓名のエラーメッセージ
        LastNameError1.Visible = False
        LastNameError2.Visible = False
        FirstNameError1.Visible = False
        FirstNameError2.Visible = False

        '連絡先のエラーメッセージ
        DaytimeError.Visible = False
        EmergencyError.Visible = False
        EmailError1.Visible = False
        EmailError2.Visible = False

        '住所のエラーメッセージ
        PostalCodeError.Visible = False
        PrefectureError.Visible = False
        MunicipalityError.Visible = False
        AddressError.Visible = False

        'ユーザー登録のエラーメッセージ
        UserIdError.Visible = False
        ConfirmationUserPassError.Visible = False


        '姓名チェック
        If Me.LastName.Text = "" Then
            LastNameError1.Visible = True
            Errflg += 1
        End If

        If Me.Lastname2.Text = "" Then
            LastNameError2.Visible = True
            Errflg += 1
        End If

        If Me.FirstName.Text = "" Then
            FirstNameError1.Visible = True
            Errflg += 1
        End If

        If Me.FirstName2.Text = "" Then
            FirstNameError2.Visible = True
            Errflg += 1
        End If

        '連絡先チェック
        If Me.Tell1.Text = "" Then
            DaytimeError.Visible = True
            Errflg += 1
        End If

        If Me.Tell2.Text = "" Then
            DaytimeError.Visible = True
            Errflg += 1
        End If

        If Me.Tell3.Text = "" Then
            DaytimeError.Visible = True
            Errflg += 1
        End If

        If Me.TellEmergency.Text = "" Then
            EmergencyError.Visible = True
            Errflg += 1
        End If

        If Me.TellEmergency2.Text = "" Then
            EmergencyError.Visible = True
            Errflg += 1
        End If

        If Me.TellEmergency3.Text = "" Then
            EmergencyError.Visible = True
            Errflg += 1
        End If

        If Me.EmailTextBox1.Text = "" Or Me.EmailTextBox2.Text = "" Then
            EmailError1.Visible = True
            Errflg += 1
        End If

        If Me.EmailTextBox2.Text.IndexOf(",") >= 0 Then
            EmailError2.Visible = True
            Errflg += 1
        End If

        '住所チェック
        If Me.PostalCode1.Text = "" Then
            PostalCodeError.Visible = True
            Errflg += 1
        End If

        If Me.PostalCode2.Text = "" Then
            PostalCodeError.Visible = True
            Errflg += 1
        End If

        If Me.PrefectureComboBox.Text = "" Then
            PrefectureError.Visible = True
            Errflg += 1
        End If

        If Me.MunicipalityTextBox.Text = "" Then
            MunicipalityError.Visible = True
            Errflg += 1
        End If

        If Me.AddressTextBox.Text = "" Or Me.AddressTextBox.ToString.IndexOf("--") >= 0 Then
            'Or Char.IsDigit(Me.AddressTextBox.ToString.Substring(Me.AddressTextBox.TextLength)) = False Then
            AddressError.Visible = True
            Errflg += 1
        End If

        'ユーザー登録チェック
        If UserIdTextbox.TextLength < 4 Then
            UserIdError.Visible = True
            Errflg += 1
        End If

        If UserPassTextbox.TextLength < 4 Then
            UserPassError1.ForeColor = Color.Red
            Errflg += 1
        End If

        If System.Text.RegularExpressions.Regex.IsMatch( _
        Me.UserPassTextbox.Text, "([a-z]+\d)|(\d+[a-z])") = False Then
            UserPassError2.ForeColor = Color.Red
            Errflg += 1
        End If

        If Me.UserPassTextbox.Text <> Me.ConfirmationUserPassTextbox.Text Then
            ConfirmationUserPassError.Visible = True
            Errflg += 1
        End If

        If Me.ConfirmationUserPassTextbox.Text = "" Then
            ConfirmationUserPassError.Visible = True
            Errflg += 1
        End If

        If Errflg = 0 Then

            atai = Me.UserIdTextbox.Text
            atai2 = Hash.GetStretchedPassword(Me.UserPassTextbox.Text, Me.UserIdTextbox.Text)
            atai3 = Me.ConfirmationUserPassTextbox.Text

            sqlstr = "INSERT INTO test_id(userID, userPassword, username)" _
                          & "VALUES ('" & atai & "','" & atai2 & "','" & atai3 & "')"
            If Sql.DBConnect(sqlstr) = False Then
                MsgBox(Sql.ErrorMessage())
            End If
        End If

        If Errflg = 0 Then
            MsgBox("正常に登録されました。")
            Me.Close()
        End If

        If Errflg = 1 Then
            MsgBox("登録出来ませんでした。赤字の箇所を修正してください。")
        End If
    End Sub

    Private Sub CancelButton_Click_1(sender As Object, e As EventArgs) Handles CancelButton2.Click

        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("登録を中断しますか？", _
                                                     "質問", _
                                                     MessageBoxButtons.OKCancel, _
                                                     MessageBoxIcon.Warning)
        '何が選択されたか調べる 
        If result = DialogResult.OK Then
            '「はい」が選択された時 
            Me.Close()
        ElseIf result = DialogResult.No Then
            '「キャンセル」が選択された時 
        End If
    End Sub

    Private encsjis As System.Text.Encoding


    Private Sub Watermark1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LastName.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.LastName.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.LastName.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(LastName.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            LastName.Text = LastName.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub Watermark2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstName.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.FirstName.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.FirstName.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(FirstName.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            FirstName.Text = FirstName.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub Watermark3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lastname2.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.Lastname2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.Lastname2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(Lastname2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            Lastname2.Text = Lastname2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub Watermark4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstName2.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.FirstName2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.FirstName2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(FirstName2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            FirstName2.Text = FirstName2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub PrefectureComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrefectureComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub PostalCodeSearchButton_Click(sender As Object, e As EventArgs) Handles PostalCodeSearchButton.Click
        '見つかったかどうかのフラグ
        Dim blnFlag As Boolean = False

        '郵便番号の上3ケタが入力されていないとき
        If (PostalCode1.Text = "") Then
            MessageBox.Show("郵便番号の上3桁が入力されていません。")
            Me.PostalCode1.Focus()
            Return
            '郵便番号の上4ケタが入力されていないとき
        ElseIf (PostalCode2.Text = "") Then
            MessageBox.Show("郵便番号の下4桁が入力されていません。")
            Me.PostalCode2.Focus()
            Return
        End If

        'マウスカーソルを砂時計にする
        Cursor.Current = Cursors.WaitCursor

        '郵便番号上3桁と下4桁を結合
        Dim sKey As String = PostalCode1.Text + PostalCode2.Text

        Try
            'StreamReaderオブジェクトの作成
            Dim sr As New System.IO.StreamReader("C:\Users\15110007\Documents\Visual Studio 2013\Projects\最新版NurseryTeacher\ken_all\KEN_ALL.CSV", System.Text.Encoding.Default)
            '1行ずつ読み込み
            Dim dat As String = sr.ReadLine()

            '郵便番号データから読み取った行がNullでない限りループする
            While (String.IsNullOrEmpty(dat) = False)

                'CSVファイルの郵便番号格納用変数
                Dim tmpZip As String
                'カンマで区切られた文字列を取得
                Dim sbuf As String() = dat.Split(",")

                'CSVファイル配列の3番目が郵便番号
                tmpZip = sbuf(2).Trim(ControlChars.Quote)

                'sbuf(8)...町域名に「（ 」が含まれているか調べる
                sbuf(8) = sbuf(8).Trim(ControlChars.Quote)
                Dim StrCheck As Integer = sbuf(8).IndexOf("（")
                If 0 <= StrCheck Then
                    ' 町域名に「（ 」が含まれていたら、「（ 」以降の文字を削除
                    sbuf(8) = sbuf(8).Remove(StrCheck, (sbuf(8).Length - StrCheck))
                End If

                '入力された郵便番号と比較
                If (sKey = tmpZip) Then
                    '都道府県名テキストボックスに都道府県名を表示
                    PrefectureComboBox.Text = sbuf(6).Trim(ControlChars.Quote)
                    '入力された郵便番号の下4桁が全て0の場合
                    If (PostalCode2.Text = "0000") Then
                        '市区町村テキストボックスに市区町村名を表示
                        MunicipalityTextBox.Text = sbuf(7).Trim(ControlChars.Quote)
                    Else
                        '市区町村テキストボックスに市区町村名+町域名を表示
                        MunicipalityTextBox.Text = sbuf(7).Trim(ControlChars.Quote) + sbuf(8).Trim(ControlChars.Quote)
                    End If
                    'フラグをTrueにし、ループを抜ける
                    blnFlag = True
                    Exit While
                End If

                Application.DoEvents()
                dat = sr.ReadLine()
            End While

            'ファイルを閉じる
            sr.Close()

        Catch ex As Exception
            'ファイルエラーが発生
            MessageBox.Show(ex.Message, "ファイルエラー",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            '処理を抜ける
            Return

        Finally
            'マウスカーソルをデフォルトにする
            Cursor.Current = Cursors.Default

            If (blnFlag = False) Then
                MessageBox.Show("該当の郵便番号は見つかりませんでした。",
                                "郵便番号検索",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddressTextBox.KeyPress
        '0～9、バックスペース、ハイフン以外のキーを押した場合はイベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso _
                e.KeyChar <> ControlChars.Back And e.KeyChar <> "-" Then
            e.Handled = True
        End If

    End Sub

    Private Sub RoomNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RoomNumberTextBox.KeyPress, PostalCode2.KeyPress, PostalCode1.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso _
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub Tell1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TellEmergency3.KeyPress, TellEmergency2.KeyPress, TellEmergency.KeyPress, Tell3.KeyPress, Tell2.KeyPress, Tell1.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso _
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' Private Sub Year_Move(sender As Object, e As EventArgs) Handles Year.Move
    '    If Year.ToString.Length > 4 Then
    '       Year = Year.ToString.Remove(3)
    '      Year = Year.ToString.Length
    '   End If
    'End Sub

End Class