Public Class SelectAddDocument
    Inherits BaseForm '★System.Windows.Forms.Form から BaseForm に変更
    '終了処理
    Private Sub SelectAddDocument_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Owner.Enabled = True
        Me.Dispose()
    End Sub
    '--------------------------------------------------------------------------------
    'ボタン押下の動作
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)

        Dim form1 As New AdministratorForm '遷移先
        Owner.Enabled = True

        'メモリ開放も行う方の閉じる()
        Me.Dispose()
    End Sub


    'ここまでボタン押下動作
    '------------------------------------------------------------


    'ここから移動用
    '------------------------------------------------------------

    Private Sub ButtonMonthHigh_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub
    Private Sub ButtonMonthLow_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthLow")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub ButtonWeekLow_Click(sender As Object, e As EventArgs) Handles ButtonWeekLow.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("WeekLow")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub ButtonWeekHigh_Click(sender As Object, e As EventArgs) Handles ButtonWeekHigh.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("WeekHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub
    'ここまで移動用
    '---------------------------------------------------------------------






    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthLow")
        f.MoveForm()
        Me.Dispose()
    End Sub


    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

End Class

