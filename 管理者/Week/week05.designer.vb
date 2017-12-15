<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class week05
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(week05))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.XEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelDate1 = New System.Windows.Forms.Label()
        Me.LabelDate3 = New System.Windows.Forms.Label()
        Me.LabelDate2 = New System.Windows.Forms.Label()
        Me.LabelDate5 = New System.Windows.Forms.Label()
        Me.LabelDate4 = New System.Windows.Forms.Label()
        Me.LabelDate6 = New System.Windows.Forms.Label()
        Me.ComboClass = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboTeacher = New System.Windows.Forms.ComboBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextMen = New System.Windows.Forms.TextBox()
        Me.TextWomen = New System.Windows.Forms.TextBox()
        Me.LabelSum = New System.Windows.Forms.Label()
        Me.LabelMonth1 = New System.Windows.Forms.Label()
        Me.LabelMonth2 = New System.Windows.Forms.Label()
        Me.LabelMonth3 = New System.Windows.Forms.Label()
        Me.LabelMonth4 = New System.Windows.Forms.Label()
        Me.LabelMonth5 = New System.Windows.Forms.Label()
        Me.LabelMonth6 = New System.Windows.Forms.Label()
        Me.LabelDay1 = New System.Windows.Forms.Label()
        Me.LabelDay2 = New System.Windows.Forms.Label()
        Me.LabelDay3 = New System.Windows.Forms.Label()
        Me.LabelDay4 = New System.Windows.Forms.Label()
        Me.LabelDay6 = New System.Windows.Forms.Label()
        Me.LabelDay5 = New System.Windows.Forms.Label()
        Me.RichPurpose = New System.Windows.Forms.RichTextBox()
        Me.RichFamily = New System.Windows.Forms.RichTextBox()
        Me.RichLastWeek = New System.Windows.Forms.RichTextBox()
        Me.RichNextWeek = New System.Windows.Forms.RichTextBox()
        Me.RichEnvironment1 = New System.Windows.Forms.RichTextBox()
        Me.RichAction1 = New System.Windows.Forms.RichTextBox()
        Me.RichConsideration1 = New System.Windows.Forms.RichTextBox()
        Me.RichEnvironment2 = New System.Windows.Forms.RichTextBox()
        Me.RichAction2 = New System.Windows.Forms.RichTextBox()
        Me.RichConsideration2 = New System.Windows.Forms.RichTextBox()
        Me.RichEnvironment3 = New System.Windows.Forms.RichTextBox()
        Me.RichAction3 = New System.Windows.Forms.RichTextBox()
        Me.RichConsideration3 = New System.Windows.Forms.RichTextBox()
        Me.RichEnvironment4 = New System.Windows.Forms.RichTextBox()
        Me.RichAction4 = New System.Windows.Forms.RichTextBox()
        Me.RichConsideration4 = New System.Windows.Forms.RichTextBox()
        Me.RichEnvironment5 = New System.Windows.Forms.RichTextBox()
        Me.RichAction5 = New System.Windows.Forms.RichTextBox()
        Me.RichConsideration5 = New System.Windows.Forms.RichTextBox()
        Me.RichEnvironment6 = New System.Windows.Forms.RichTextBox()
        Me.RichAction6 = New System.Windows.Forms.RichTextBox()
        Me.RichConsideration6 = New System.Windows.Forms.RichTextBox()
        Me.RichSelfEvaluation = New System.Windows.Forms.RichTextBox()
        Me.RichChildEvaluation = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1135, 24)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSave, Me.ASave, Me.ToolStripMenuItem1, Me.XEnd})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'SSave
        '
        Me.SSave.Name = "SSave"
        Me.SSave.Size = New System.Drawing.Size(177, 22)
        Me.SSave.Text = "上書き保存(&S)"
        '
        'ASave
        '
        Me.ASave.Name = "ASave"
        Me.ASave.Size = New System.Drawing.Size(177, 22)
        Me.ASave.Text = "名前を付けて保存(&A)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'XEnd
        '
        Me.XEnd.Name = "XEnd"
        Me.XEnd.Size = New System.Drawing.Size(177, 22)
        Me.XEnd.Text = "終了(&X)"
        '
        'LabelDate1
        '
        Me.LabelDate1.AutoSize = True
        Me.LabelDate1.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate1.Location = New System.Drawing.Point(65, 467)
        Me.LabelDate1.Name = "LabelDate1"
        Me.LabelDate1.Size = New System.Drawing.Size(0, 12)
        Me.LabelDate1.TabIndex = 2
        '
        'LabelDate3
        '
        Me.LabelDate3.AutoSize = True
        Me.LabelDate3.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate3.Location = New System.Drawing.Point(66, 737)
        Me.LabelDate3.Name = "LabelDate3"
        Me.LabelDate3.Size = New System.Drawing.Size(0, 12)
        Me.LabelDate3.TabIndex = 3
        '
        'LabelDate2
        '
        Me.LabelDate2.AutoSize = True
        Me.LabelDate2.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate2.Location = New System.Drawing.Point(65, 602)
        Me.LabelDate2.Name = "LabelDate2"
        Me.LabelDate2.Size = New System.Drawing.Size(0, 12)
        Me.LabelDate2.TabIndex = 4
        '
        'LabelDate5
        '
        Me.LabelDate5.AutoSize = True
        Me.LabelDate5.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate5.Location = New System.Drawing.Point(66, 1007)
        Me.LabelDate5.Name = "LabelDate5"
        Me.LabelDate5.Size = New System.Drawing.Size(0, 12)
        Me.LabelDate5.TabIndex = 5
        '
        'LabelDate4
        '
        Me.LabelDate4.AutoSize = True
        Me.LabelDate4.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate4.Location = New System.Drawing.Point(65, 872)
        Me.LabelDate4.Name = "LabelDate4"
        Me.LabelDate4.Size = New System.Drawing.Size(0, 12)
        Me.LabelDate4.TabIndex = 6
        '
        'LabelDate6
        '
        Me.LabelDate6.AutoSize = True
        Me.LabelDate6.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate6.Location = New System.Drawing.Point(65, 1142)
        Me.LabelDate6.Name = "LabelDate6"
        Me.LabelDate6.Size = New System.Drawing.Size(0, 12)
        Me.LabelDate6.TabIndex = 7
        '
        'ComboClass
        '
        Me.ComboClass.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboClass.FormattingEnabled = True
        Me.ComboClass.Items.AddRange(New Object() {"ひよこ組", "うさぎ組", "チューリップ組", "ひまわり組"})
        Me.ComboClass.Location = New System.Drawing.Point(525, 51)
        Me.ComboClass.Name = "ComboClass"
        Me.ComboClass.Size = New System.Drawing.Size(231, 31)
        Me.ComboClass.TabIndex = 15
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(929, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(163, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'ComboTeacher
        '
        Me.ComboTeacher.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboTeacher.FormattingEnabled = True
        Me.ComboTeacher.Items.AddRange(New Object() {"森山 有機", "松原 はやお ", "印度 太郎", "近藤 兵介", "前田 ゑいと", "伊藤 桃果 "})
        Me.ComboTeacher.Location = New System.Drawing.Point(826, 85)
        Me.ComboTeacher.Name = "ComboTeacher"
        Me.ComboTeacher.Size = New System.Drawing.Size(273, 31)
        Me.ComboTeacher.TabIndex = 20
        '
        'DTP1
        '
        Me.DTP1.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DTP1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DTP1.Location = New System.Drawing.Point(833, 57)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(120, 20)
        Me.DTP1.TabIndex = 16
        '
        'DTP2
        '
        Me.DTP2.Enabled = False
        Me.DTP2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DTP2.Location = New System.Drawing.Point(977, 57)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(121, 20)
        Me.DTP2.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(570, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "   人(男：　　人 , 女：　　人)"
        '
        'TextMen
        '
        Me.TextMen.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextMen.Location = New System.Drawing.Point(632, 88)
        Me.TextMen.MaxLength = 3
        Me.TextMen.Name = "TextMen"
        Me.TextMen.Size = New System.Drawing.Size(22, 23)
        Me.TextMen.TabIndex = 18
        Me.TextMen.Text = "0"
        Me.TextMen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextWomen
        '
        Me.TextWomen.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextWomen.Location = New System.Drawing.Point(707, 88)
        Me.TextWomen.MaxLength = 3
        Me.TextWomen.Name = "TextWomen"
        Me.TextWomen.Size = New System.Drawing.Size(23, 23)
        Me.TextWomen.TabIndex = 19
        Me.TextWomen.Text = "0"
        Me.TextWomen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelSum
        '
        Me.LabelSum.AutoSize = True
        Me.LabelSum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSum.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelSum.Location = New System.Drawing.Point(557, 91)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(0, 16)
        Me.LabelSum.TabIndex = 22
        Me.LabelSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMonth1
        '
        Me.LabelMonth1.AutoSize = True
        Me.LabelMonth1.BackColor = System.Drawing.Color.Transparent
        Me.LabelMonth1.Location = New System.Drawing.Point(37, 467)
        Me.LabelMonth1.Name = "LabelMonth1"
        Me.LabelMonth1.Size = New System.Drawing.Size(0, 12)
        Me.LabelMonth1.TabIndex = 24
        '
        'LabelMonth2
        '
        Me.LabelMonth2.AutoSize = True
        Me.LabelMonth2.BackColor = System.Drawing.Color.Transparent
        Me.LabelMonth2.Location = New System.Drawing.Point(36, 602)
        Me.LabelMonth2.Name = "LabelMonth2"
        Me.LabelMonth2.Size = New System.Drawing.Size(0, 12)
        Me.LabelMonth2.TabIndex = 26
        '
        'LabelMonth3
        '
        Me.LabelMonth3.AutoSize = True
        Me.LabelMonth3.BackColor = System.Drawing.Color.Transparent
        Me.LabelMonth3.Location = New System.Drawing.Point(36, 737)
        Me.LabelMonth3.Name = "LabelMonth3"
        Me.LabelMonth3.Size = New System.Drawing.Size(0, 12)
        Me.LabelMonth3.TabIndex = 28
        '
        'LabelMonth4
        '
        Me.LabelMonth4.AutoSize = True
        Me.LabelMonth4.BackColor = System.Drawing.Color.Transparent
        Me.LabelMonth4.Location = New System.Drawing.Point(36, 872)
        Me.LabelMonth4.Name = "LabelMonth4"
        Me.LabelMonth4.Size = New System.Drawing.Size(0, 12)
        Me.LabelMonth4.TabIndex = 30
        '
        'LabelMonth5
        '
        Me.LabelMonth5.AutoSize = True
        Me.LabelMonth5.BackColor = System.Drawing.Color.Transparent
        Me.LabelMonth5.Location = New System.Drawing.Point(37, 1007)
        Me.LabelMonth5.Name = "LabelMonth5"
        Me.LabelMonth5.Size = New System.Drawing.Size(0, 12)
        Me.LabelMonth5.TabIndex = 32
        '
        'LabelMonth6
        '
        Me.LabelMonth6.AutoSize = True
        Me.LabelMonth6.BackColor = System.Drawing.Color.Transparent
        Me.LabelMonth6.Location = New System.Drawing.Point(36, 1142)
        Me.LabelMonth6.Name = "LabelMonth6"
        Me.LabelMonth6.Size = New System.Drawing.Size(0, 12)
        Me.LabelMonth6.TabIndex = 34
        '
        'LabelDay1
        '
        Me.LabelDay1.AutoSize = True
        Me.LabelDay1.BackColor = System.Drawing.Color.Transparent
        Me.LabelDay1.Location = New System.Drawing.Point(92, 467)
        Me.LabelDay1.Name = "LabelDay1"
        Me.LabelDay1.Size = New System.Drawing.Size(13, 12)
        Me.LabelDay1.TabIndex = 35
        Me.LabelDay1.Text = "  "
        '
        'LabelDay2
        '
        Me.LabelDay2.AutoSize = True
        Me.LabelDay2.BackColor = System.Drawing.Color.Transparent
        Me.LabelDay2.Location = New System.Drawing.Point(92, 602)
        Me.LabelDay2.Name = "LabelDay2"
        Me.LabelDay2.Size = New System.Drawing.Size(13, 12)
        Me.LabelDay2.TabIndex = 36
        Me.LabelDay2.Text = "  "
        '
        'LabelDay3
        '
        Me.LabelDay3.AutoSize = True
        Me.LabelDay3.BackColor = System.Drawing.Color.Transparent
        Me.LabelDay3.Location = New System.Drawing.Point(92, 737)
        Me.LabelDay3.Name = "LabelDay3"
        Me.LabelDay3.Size = New System.Drawing.Size(13, 12)
        Me.LabelDay3.TabIndex = 37
        Me.LabelDay3.Text = "  "
        '
        'LabelDay4
        '
        Me.LabelDay4.AutoSize = True
        Me.LabelDay4.BackColor = System.Drawing.Color.Transparent
        Me.LabelDay4.Location = New System.Drawing.Point(92, 872)
        Me.LabelDay4.Name = "LabelDay4"
        Me.LabelDay4.Size = New System.Drawing.Size(13, 12)
        Me.LabelDay4.TabIndex = 38
        Me.LabelDay4.Text = "  "
        '
        'LabelDay6
        '
        Me.LabelDay6.AutoSize = True
        Me.LabelDay6.BackColor = System.Drawing.Color.Transparent
        Me.LabelDay6.Location = New System.Drawing.Point(92, 1142)
        Me.LabelDay6.Name = "LabelDay6"
        Me.LabelDay6.Size = New System.Drawing.Size(13, 12)
        Me.LabelDay6.TabIndex = 39
        Me.LabelDay6.Text = "  "
        '
        'LabelDay5
        '
        Me.LabelDay5.AutoSize = True
        Me.LabelDay5.BackColor = System.Drawing.Color.Transparent
        Me.LabelDay5.Location = New System.Drawing.Point(92, 1007)
        Me.LabelDay5.Name = "LabelDay5"
        Me.LabelDay5.Size = New System.Drawing.Size(13, 12)
        Me.LabelDay5.TabIndex = 40
        Me.LabelDay5.Text = "  "
        '
        'RichPurpose
        '
        Me.RichPurpose.Location = New System.Drawing.Point(120, 117)
        Me.RichPurpose.Name = "RichPurpose"
        Me.RichPurpose.Size = New System.Drawing.Size(404, 67)
        Me.RichPurpose.TabIndex = 41
        Me.RichPurpose.Text = ""
        '
        'RichFamily
        '
        Me.RichFamily.Location = New System.Drawing.Point(651, 117)
        Me.RichFamily.Name = "RichFamily"
        Me.RichFamily.Size = New System.Drawing.Size(448, 67)
        Me.RichFamily.TabIndex = 42
        Me.RichFamily.Text = ""
        '
        'RichLastWeek
        '
        Me.RichLastWeek.Location = New System.Drawing.Point(33, 217)
        Me.RichLastWeek.Name = "RichLastWeek"
        Me.RichLastWeek.Size = New System.Drawing.Size(491, 154)
        Me.RichLastWeek.TabIndex = 43
        Me.RichLastWeek.Text = ""
        '
        'RichNextWeek
        '
        Me.RichNextWeek.Location = New System.Drawing.Point(524, 217)
        Me.RichNextWeek.Name = "RichNextWeek"
        Me.RichNextWeek.Size = New System.Drawing.Size(575, 154)
        Me.RichNextWeek.TabIndex = 44
        Me.RichNextWeek.Text = ""
        '
        'RichEnvironment1
        '
        Me.RichEnvironment1.Location = New System.Drawing.Point(120, 405)
        Me.RichEnvironment1.Name = "RichEnvironment1"
        Me.RichEnvironment1.Size = New System.Drawing.Size(328, 135)
        Me.RichEnvironment1.TabIndex = 45
        Me.RichEnvironment1.Text = ""
        '
        'RichAction1
        '
        Me.RichAction1.Location = New System.Drawing.Point(448, 405)
        Me.RichAction1.Name = "RichAction1"
        Me.RichAction1.Size = New System.Drawing.Size(308, 135)
        Me.RichAction1.TabIndex = 46
        Me.RichAction1.Text = ""
        '
        'RichConsideration1
        '
        Me.RichConsideration1.Location = New System.Drawing.Point(756, 405)
        Me.RichConsideration1.Name = "RichConsideration1"
        Me.RichConsideration1.Size = New System.Drawing.Size(343, 135)
        Me.RichConsideration1.TabIndex = 47
        Me.RichConsideration1.Text = ""
        '
        'RichEnvironment2
        '
        Me.RichEnvironment2.Location = New System.Drawing.Point(120, 540)
        Me.RichEnvironment2.Name = "RichEnvironment2"
        Me.RichEnvironment2.Size = New System.Drawing.Size(328, 135)
        Me.RichEnvironment2.TabIndex = 48
        Me.RichEnvironment2.Text = ""
        '
        'RichAction2
        '
        Me.RichAction2.Location = New System.Drawing.Point(448, 540)
        Me.RichAction2.Name = "RichAction2"
        Me.RichAction2.Size = New System.Drawing.Size(308, 135)
        Me.RichAction2.TabIndex = 49
        Me.RichAction2.Text = ""
        '
        'RichConsideration2
        '
        Me.RichConsideration2.Location = New System.Drawing.Point(756, 540)
        Me.RichConsideration2.Name = "RichConsideration2"
        Me.RichConsideration2.Size = New System.Drawing.Size(342, 135)
        Me.RichConsideration2.TabIndex = 50
        Me.RichConsideration2.Text = ""
        '
        'RichEnvironment3
        '
        Me.RichEnvironment3.Location = New System.Drawing.Point(120, 675)
        Me.RichEnvironment3.Name = "RichEnvironment3"
        Me.RichEnvironment3.Size = New System.Drawing.Size(328, 135)
        Me.RichEnvironment3.TabIndex = 51
        Me.RichEnvironment3.Text = ""
        '
        'RichAction3
        '
        Me.RichAction3.Location = New System.Drawing.Point(448, 675)
        Me.RichAction3.Name = "RichAction3"
        Me.RichAction3.Size = New System.Drawing.Size(308, 135)
        Me.RichAction3.TabIndex = 52
        Me.RichAction3.Text = ""
        '
        'RichConsideration3
        '
        Me.RichConsideration3.Location = New System.Drawing.Point(756, 675)
        Me.RichConsideration3.Name = "RichConsideration3"
        Me.RichConsideration3.Size = New System.Drawing.Size(342, 135)
        Me.RichConsideration3.TabIndex = 53
        Me.RichConsideration3.Text = ""
        '
        'RichEnvironment4
        '
        Me.RichEnvironment4.Location = New System.Drawing.Point(120, 810)
        Me.RichEnvironment4.Name = "RichEnvironment4"
        Me.RichEnvironment4.Size = New System.Drawing.Size(328, 135)
        Me.RichEnvironment4.TabIndex = 54
        Me.RichEnvironment4.Text = ""
        '
        'RichAction4
        '
        Me.RichAction4.Location = New System.Drawing.Point(448, 810)
        Me.RichAction4.Name = "RichAction4"
        Me.RichAction4.Size = New System.Drawing.Size(308, 135)
        Me.RichAction4.TabIndex = 55
        Me.RichAction4.Text = ""
        '
        'RichConsideration4
        '
        Me.RichConsideration4.Location = New System.Drawing.Point(756, 810)
        Me.RichConsideration4.Name = "RichConsideration4"
        Me.RichConsideration4.Size = New System.Drawing.Size(342, 135)
        Me.RichConsideration4.TabIndex = 56
        Me.RichConsideration4.Text = ""
        '
        'RichEnvironment5
        '
        Me.RichEnvironment5.Location = New System.Drawing.Point(120, 945)
        Me.RichEnvironment5.Name = "RichEnvironment5"
        Me.RichEnvironment5.Size = New System.Drawing.Size(328, 135)
        Me.RichEnvironment5.TabIndex = 57
        Me.RichEnvironment5.Text = ""
        '
        'RichAction5
        '
        Me.RichAction5.Location = New System.Drawing.Point(448, 945)
        Me.RichAction5.Name = "RichAction5"
        Me.RichAction5.Size = New System.Drawing.Size(308, 135)
        Me.RichAction5.TabIndex = 58
        Me.RichAction5.Text = ""
        '
        'RichConsideration5
        '
        Me.RichConsideration5.Location = New System.Drawing.Point(756, 945)
        Me.RichConsideration5.Name = "RichConsideration5"
        Me.RichConsideration5.Size = New System.Drawing.Size(342, 135)
        Me.RichConsideration5.TabIndex = 59
        Me.RichConsideration5.Text = ""
        '
        'RichEnvironment6
        '
        Me.RichEnvironment6.Location = New System.Drawing.Point(120, 1080)
        Me.RichEnvironment6.Name = "RichEnvironment6"
        Me.RichEnvironment6.Size = New System.Drawing.Size(328, 135)
        Me.RichEnvironment6.TabIndex = 60
        Me.RichEnvironment6.Text = ""
        '
        'RichAction6
        '
        Me.RichAction6.Location = New System.Drawing.Point(448, 1080)
        Me.RichAction6.Name = "RichAction6"
        Me.RichAction6.Size = New System.Drawing.Size(308, 135)
        Me.RichAction6.TabIndex = 61
        Me.RichAction6.Text = ""
        '
        'RichConsideration6
        '
        Me.RichConsideration6.Location = New System.Drawing.Point(756, 1080)
        Me.RichConsideration6.Name = "RichConsideration6"
        Me.RichConsideration6.Size = New System.Drawing.Size(343, 135)
        Me.RichConsideration6.TabIndex = 62
        Me.RichConsideration6.Text = ""
        '
        'RichSelfEvaluation
        '
        Me.RichSelfEvaluation.Location = New System.Drawing.Point(120, 1215)
        Me.RichSelfEvaluation.Name = "RichSelfEvaluation"
        Me.RichSelfEvaluation.Size = New System.Drawing.Size(404, 124)
        Me.RichSelfEvaluation.TabIndex = 63
        Me.RichSelfEvaluation.Text = ""
        '
        'RichChildEvaluation
        '
        Me.RichChildEvaluation.Location = New System.Drawing.Point(582, 1215)
        Me.RichChildEvaluation.Name = "RichChildEvaluation"
        Me.RichChildEvaluation.Size = New System.Drawing.Size(517, 124)
        Me.RichChildEvaluation.TabIndex = 64
        Me.RichChildEvaluation.Text = ""
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.RichChildEvaluation)
        Me.Panel1.Controls.Add(Me.RichSelfEvaluation)
        Me.Panel1.Controls.Add(Me.RichConsideration6)
        Me.Panel1.Controls.Add(Me.RichAction6)
        Me.Panel1.Controls.Add(Me.RichEnvironment6)
        Me.Panel1.Controls.Add(Me.RichConsideration5)
        Me.Panel1.Controls.Add(Me.RichAction5)
        Me.Panel1.Controls.Add(Me.RichEnvironment5)
        Me.Panel1.Controls.Add(Me.RichConsideration4)
        Me.Panel1.Controls.Add(Me.RichAction4)
        Me.Panel1.Controls.Add(Me.RichEnvironment4)
        Me.Panel1.Controls.Add(Me.RichConsideration3)
        Me.Panel1.Controls.Add(Me.RichAction3)
        Me.Panel1.Controls.Add(Me.RichEnvironment3)
        Me.Panel1.Controls.Add(Me.RichConsideration2)
        Me.Panel1.Controls.Add(Me.RichAction2)
        Me.Panel1.Controls.Add(Me.RichEnvironment2)
        Me.Panel1.Controls.Add(Me.RichConsideration1)
        Me.Panel1.Controls.Add(Me.RichAction1)
        Me.Panel1.Controls.Add(Me.RichEnvironment1)
        Me.Panel1.Controls.Add(Me.RichNextWeek)
        Me.Panel1.Controls.Add(Me.RichLastWeek)
        Me.Panel1.Controls.Add(Me.RichFamily)
        Me.Panel1.Controls.Add(Me.RichPurpose)
        Me.Panel1.Controls.Add(Me.LabelDay5)
        Me.Panel1.Controls.Add(Me.LabelDay6)
        Me.Panel1.Controls.Add(Me.LabelDay4)
        Me.Panel1.Controls.Add(Me.LabelDay3)
        Me.Panel1.Controls.Add(Me.LabelDay2)
        Me.Panel1.Controls.Add(Me.LabelDay1)
        Me.Panel1.Controls.Add(Me.LabelMonth6)
        Me.Panel1.Controls.Add(Me.LabelMonth5)
        Me.Panel1.Controls.Add(Me.LabelMonth4)
        Me.Panel1.Controls.Add(Me.LabelMonth3)
        Me.Panel1.Controls.Add(Me.LabelMonth2)
        Me.Panel1.Controls.Add(Me.LabelMonth1)
        Me.Panel1.Controls.Add(Me.LabelSum)
        Me.Panel1.Controls.Add(Me.TextWomen)
        Me.Panel1.Controls.Add(Me.TextMen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DTP2)
        Me.Panel1.Controls.Add(Me.DTP1)
        Me.Panel1.Controls.Add(Me.ComboTeacher)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ComboClass)
        Me.Panel1.Controls.Add(Me.LabelDate6)
        Me.Panel1.Controls.Add(Me.LabelDate4)
        Me.Panel1.Controls.Add(Me.LabelDate5)
        Me.Panel1.Controls.Add(Me.LabelDate2)
        Me.Panel1.Controls.Add(Me.LabelDate3)
        Me.Panel1.Controls.Add(Me.LabelDate1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 1362)
        Me.Panel1.TabIndex = 0
        '
        'week05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1139, 733)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "week05"
        Me.Text = "week05"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents XEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelDate1 As System.Windows.Forms.Label
    Friend WithEvents LabelDate3 As System.Windows.Forms.Label
    Friend WithEvents LabelDate2 As System.Windows.Forms.Label
    Friend WithEvents LabelDate5 As System.Windows.Forms.Label
    Friend WithEvents LabelDate4 As System.Windows.Forms.Label
    Friend WithEvents LabelDate6 As System.Windows.Forms.Label
    Friend WithEvents ComboClass As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboTeacher As System.Windows.Forms.ComboBox
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextMen As System.Windows.Forms.TextBox
    Friend WithEvents TextWomen As System.Windows.Forms.TextBox
    Friend WithEvents LabelSum As System.Windows.Forms.Label
    Friend WithEvents LabelMonth1 As System.Windows.Forms.Label
    Friend WithEvents LabelMonth2 As System.Windows.Forms.Label
    Friend WithEvents LabelMonth3 As System.Windows.Forms.Label
    Friend WithEvents LabelMonth4 As System.Windows.Forms.Label
    Friend WithEvents LabelMonth5 As System.Windows.Forms.Label
    Friend WithEvents LabelMonth6 As System.Windows.Forms.Label
    Friend WithEvents LabelDay1 As System.Windows.Forms.Label
    Friend WithEvents LabelDay2 As System.Windows.Forms.Label
    Friend WithEvents LabelDay3 As System.Windows.Forms.Label
    Friend WithEvents LabelDay4 As System.Windows.Forms.Label
    Friend WithEvents LabelDay6 As System.Windows.Forms.Label
    Friend WithEvents LabelDay5 As System.Windows.Forms.Label
    Friend WithEvents RichPurpose As System.Windows.Forms.RichTextBox
    Friend WithEvents RichFamily As System.Windows.Forms.RichTextBox
    Friend WithEvents RichLastWeek As System.Windows.Forms.RichTextBox
    Friend WithEvents RichNextWeek As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEnvironment1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichAction1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichConsideration1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEnvironment2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichAction2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichConsideration2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEnvironment3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichAction3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichConsideration3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEnvironment4 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichAction4 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichConsideration4 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEnvironment5 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichAction5 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichConsideration5 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEnvironment6 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichAction6 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichConsideration6 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichSelfEvaluation As System.Windows.Forms.RichTextBox
    Friend WithEvents RichChildEvaluation As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
