Public Class AddClass
    Dim sql As New SQLConnectClass

    Private Sub AddCluss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.DBConnect("SELECT COUNT(userName) FROM test_id")
        Dim count As String = sql.DBResult(0, 0)
        Dim i As Integer
        For i = 0 To Integer.Parse(count) - 1 Step 1
            Sql.DBConnect("SELECT userName FROM test_id")
            ComboBox1.Items.Add(Sql.DBResult(i, 0))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainID, Errflg
        Errflg = 0
        mainID = 0
        Dim sqltext = "SELECT COUNT(ClassName) FROM `test_cluss` WHERE `ClassName` LIKE '" & TextCluss.Text & "'"
        sql.DBConnect(sqltext)
        MsgBox(sqltext)
        Dim className = sql.DBResult(0, 0)

        ErrerMessage1.Visible = False
        ErrerMessage2.Visible = False
        ErrerMessage3.Visible = False
        ErrerMessage4.Visible = False

        If Me.Man.Text = "" Then
            Me.Man.Text = "0"
        End If


        If Me.Girl.Text = "" Then
            Me.Girl.Text = "0"
        End If
        If (Me.Man.Text = "0" And Me.Girl.Text = "0") Or Me.Man.Text = "" Or Me.Girl.Text = "" Then
            Dim result As DialogResult = MessageBox.Show("クラス人数が0ですがそのまま登録してもよいですか？",
                                                        "質問",
                                                        MessageBoxButtons.YesNoCancel,
                                                        MessageBoxIcon.Exclamation,
                                                        MessageBoxDefaultButton.Button2)
            If result <> DialogResult.Yes Then
                ErrerMessage2.Visible = True
                Errflg = 1
            End If

        End If

        If Me.TextCluss.Text = "" Then
            ErrerMessage1.Visible = True
            Errflg = 1
        End If


        If Me.ComboBox1.Text = "" Then
            ErrerMessage3.Visible = True
            Errflg = 1
        End If

        If className <> 0 Then
            ErrerMessage4.Visible = True
            Errflg = 1
        End If

        If Errflg <> 1 Then
            Dim atai, atai2, atai3, atai4, sqlStr

            atai = Me.TextCluss.Text
            atai2 = Me.Man.Text
            atai3 = Me.Girl.Text
            atai4 = Me.ComboBox1.Text

            sqlStr = "INSERT INTO `test_cluss` " _
                & "(`main_id`, `ClassName`, `Classmate_man`, `Classmate_girl`, `Homeroom`)" _
                          & "VALUES (NULL, '" & atai & "', '" & atai2 & "', '" _
                          & atai3 & "', '" & atai4 & "')"
            If sql.DBConnect(sqlStr) = False Then
                MsgBox(sql.ErrorMessage())
            Else
                MsgBox(sqlStr)
                MsgBox("できたよー")
            End If
        End If

    End Sub

    Private Sub Man_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Man.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        Man.MaxLength = 2
    End Sub

    Private Sub Girl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Girl.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        Girl.MaxLength = 2

    End Sub



End Class