Imports MySql.Data.MySqlClient

''' <summary>
''' version 2.0
''' </summary>
Public Class SQLConnectClass

    Private ds As New DataSet
    Private err As String
    Private connectDim As New MySqlConnection

    Sub New()
        err = ""
        ' 1.接続文字列を作成する
        Dim Builder = New MySqlConnectionStringBuilder()
        ' データベースに接続するために必要な情報を入力
        Builder.Server = "childdboic.c0lduagr2af9.us-east-2.rds.amazonaws.com"
        Builder.Port = 3306
        Builder.UserID = "b5261fe21dd18e"
        Builder.Password = "kF2AH9GMLD9AM2pJ"
        Builder.Database = "child_db"
        Builder.CharacterSet = "UTF8"
        Builder.ConnectionTimeout = 30

        ' Builderにて、接続文の生成
        Dim ConStr = Builder.ToString()

        Try
            ' 2.データベースに接続するための準備をして、実際につなぐ
            Me.connectDim.ConnectionString = ConStr
            Me.connectDim.Open()
        Catch e As MySqlException
            MsgBox(e.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' 指定されたSQLを実行します。
    ''' </summary>
    ''' <param name="sqlRequestString">実行するSQL文</param>
    ''' <returns>正常終了: TRUE エラー発生: FALSE</returns>
    ''' <remarks></remarks>
    Public Function DBConnect(sqlRequestString As String) As Boolean
        Try
            ' 3.データ取得のためのアダプタの設定 (sql文, 接続済ばしょ)
            Dim Adapter = New MySqlDataAdapter(sqlRequestString, Me.connectDim)

            ' 4.データを取得し、セットする
            Me.ds.Clear()
            Dim temp_ds As New DataSet
            Adapter.Fill(temp_ds)
            Me.ds = temp_ds
            Return True
        Catch e As SystemException
            ' 4.エラーを、セットする
            Me.err = e.ToString()
            Return False
        End Try
    End Function

    ''' <summary>
    ''' DataSet型を取り出す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>互換性のために必須で残す</remarks>
    Public Function DBResult() As DataSet
        Return Me.ds
    End Function

    ''' <summary>
    ''' 指定した行・列に存在する項目を取り出す
    ''' </summary>
    ''' <param name="lineIndex">0から始まる行番号</param>
    ''' <param name="columnName">列の名前</param>
    ''' <returns>単一の文字列</returns>
    ''' <remarks></remarks>
    Public Function DBResult(lineIndex As Integer, columnName As String) As String
        Return ds.Tables.Item(0).Rows(lineIndex).Item(columnName).ToString
    End Function

    ''' <summary>
    ''' 指定した行・列に存在する項目を取り出す
    ''' </summary>
    ''' <param name="lineIndex">0から始まる行番号</param>
    ''' <param name="columnIndex">0から始まる列番号</param>
    ''' <returns>単一の文字列</returns>
    ''' <remarks></remarks>
    Public Function DBResult(lineIndex As Integer, columnIndex As Integer) As String
        Return ds.Tables.Item(0).Rows(lineIndex).Item(columnIndex).ToString
    End Function
    ''' <summary>
    ''' 最初の行の指定列に存在する項目を取り出す
    ''' </summary>
    ''' <param name="columnName">列の名前</param>
    ''' <returns>単一の文字列</returns>
    ''' <remarks></remarks>
    Public Function DBResult(columnName As String) As String
        Return ds.Tables.Item(0).Rows(0).Item(columnName).ToString
    End Function

    ''' <summary>
    ''' 最初の行の指定列に存在する項目を取り出す
    ''' </summary>
    ''' <param name="columnIndex">0から始まる列番号</param>
    ''' <returns>単一の文字列</returns>
    ''' <remarks></remarks>
    Public Function DBResult(columnIndex As Integer) As String
        Return ds.Tables.Item(0).Rows(0).Item(columnIndex).ToString
    End Function


    Public Function ErrorMessage() As String
        Return Me.err
    End Function

End Class
