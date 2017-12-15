<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressStatesForm
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressStatesLabel = New System.Windows.Forms.Label()
        Me.ProcessContentsRTB = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar.Location = New System.Drawing.Point(12, 39)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(233, 18)
        Me.ProgressBar.TabIndex = 4
        Me.ProgressBar.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "進行状況"
        '
        'ProgressStatesLabel
        '
        Me.ProgressStatesLabel.AutoSize = True
        Me.ProgressStatesLabel.Location = New System.Drawing.Point(93, 13)
        Me.ProgressStatesLabel.Name = "ProgressStatesLabel"
        Me.ProgressStatesLabel.Size = New System.Drawing.Size(63, 12)
        Me.ProgressStatesLabel.TabIndex = 6
        Me.ProgressStatesLabel.Text = "( 100/100 )"
        '
        'ProcessContentsRTB
        '
        Me.ProcessContentsRTB.Location = New System.Drawing.Point(12, 75)
        Me.ProcessContentsRTB.Name = "ProcessContentsRTB"
        Me.ProcessContentsRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.ProcessContentsRTB.Size = New System.Drawing.Size(233, 126)
        Me.ProcessContentsRTB.TabIndex = 7
        Me.ProcessContentsRTB.Text = ""
        '
        'ProgressStatesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 213)
        Me.Controls.Add(Me.ProcessContentsRTB)
        Me.Controls.Add(Me.ProgressStatesLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "ProgressStatesForm"
        Me.Text = "ProgressStatesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressStatesLabel As System.Windows.Forms.Label
    Friend WithEvents ProcessContentsRTB As System.Windows.Forms.RichTextBox
End Class
