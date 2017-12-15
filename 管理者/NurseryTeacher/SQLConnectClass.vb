Imports MySql.Data.MySqlClient

Public Class SQLConnectClass

    Private ds As New DataSet
    Private err As String
    Private connectDim As New MySqlConnection

    Sub New()
        ' 1.接続文字列を作成する
        Dim Builder = New MySqlConnectionStringBuilder()
        ' データベースに接続するために必要な情報を入力
        Builder.Server = "us-cdbr-sl-dfw-01.cleardb.net"
        Builder.Port = 3306
        Builder.UserID = "b5261fe21dd18e"
        Builder.Password = "be2aad25"
        Builder.Database = "ibmx_8240fb568648f48"
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

    Public Function DBConnect(sqlRequestString As String) As Boolean
        Try
            ' 3.データ取得のためのアダプタの設定 (sql文, 接続済ばしょ)
            Dim Adapter = New MySqlDataAdapter(sqlRequestString, Me.connectDim)

            ' 4.データを取得し、セットする
            Me.ds.Clear()
            Adapter.Fill(Me.ds)
            Return True
        Catch e As SystemException
            ' 4.エラーを、セットする
            Me.err = e.ToString()
            Return False
        End Try
    End Function

    Public Function DBResult() As DataSet
        Return Me.ds
    End Function

    Public Function ErrorMessage() As String
        Return Me.err
    End Function

End Class
