Public Class ProgressStatesForm

    Private max As Integer = 100
    Private processNum As Integer = 0

    Private Sub ProgressStatesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Value = 0
        ProcessContentsRTB.Clear()
        ProgressStatesMaxSet(100)
        ProgressStatesLabelSet(0)
        Me.Refresh()
    End Sub

    ''' <summary>
    ''' 進行状況を設定する
    ''' </summary>
    ''' <param name="i">設定値</param>
    ''' <remarks></remarks>
    Public Sub ProgressStatesLabelSet(i As Integer)
        If max < i Then
            i = max
        End If
        processNum = i
        ProgressStatesLabel.Text = "( " & processNum & " / " & max & " )"
    End Sub

    ''' <summary>
    ''' 進行状況を更新する
    ''' </summary>
    ''' <param name="i">指定数値だけ加算する</param>
    ''' <remarks></remarks>
    Public Sub ProgressStatesLabelUpdate(i As Integer)
        processNum += i
        If max < processNum Then
            processNum = max
        End If
        ProgressBar.Value = processNum
        ProgressStatesLabel.Text = "( " & processNum & " / " & max & " )"
        Me.Refresh()
    End Sub

    ''' <summary>
    ''' 進行状況を更新する
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ProgressStatesLabelUpdate()
        ProgressStatesLabelUpdate(1)
    End Sub

    ''' <summary>
    ''' 最大値を設定する
    ''' </summary>
    ''' <param name="m">最大値</param>
    ''' <remarks></remarks>
    Public Sub ProgressStatesMaxSet(m As Integer)
        max = m
        ProgressBar.Maximum = m
        Me.Refresh()
    End Sub

    ''' <summary>
    ''' 進行内容を記録する
    ''' </summary>
    ''' <param name="s">進行内容</param>
    ''' <remarks></remarks>
    Public Sub ProcessContentsSet(s As String)
        ProcessContentsRTB.Text += vbCrLf & s
        ProcessContentsRTB.SelectionStart = ProcessContentsRTB.Text.Length
        ProcessContentsRTB.ScrollToCaret()
    End Sub

    Public Sub ProgressStatesEnd()
        Me.Close()
    End Sub
End Class