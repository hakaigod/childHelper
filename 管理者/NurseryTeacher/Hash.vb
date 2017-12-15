Imports System.Security.Cryptography
Imports System.Text

Public Class Hash


    Private Shared STRETCH_COUNT As Integer = 1000

    ''' <summary>'
    ''' salt ＋ハッシュ化したパスワードを取得'
    ''' </summary>'
    Public Shared Function GetSaltedPassword(password As String, userId As String) As String
        Dim salt As String = GetSha256(userId)
        Return GetSha256(salt + password)
    End Function

    ''' <summary>'
    ''' salt + ストレッチングしたパスワードを取得(推奨)'
    ''' </summary>'
    Public Shared Function GetStretchedPassword(password As String, userId As String) As String
        Dim salt As String = GetSha256(userId)
        Dim hash As String = ""

        For i = 1 To STRETCH_COUNT
            hash = GetSha256(hash + salt + password)
        Next

        Return hash
    End Function

    ''' <summary>'
    ''' 文字列から SHA256 のハッシュ値を取得'
    ''' </summary>'
    Private Shared Function GetSha256(ByVal target As String) As String
        Dim mySHA256 As SHA256 = SHA256Managed.Create()
        Dim byteValue As Byte() = Encoding.UTF8.GetBytes(target)
        Dim hash As Byte() = mySHA256.ComputeHash(byteValue)

        Dim buf As StringBuilder = New StringBuilder()

        For i = 0 To hash.Length - 1
            buf.AppendFormat("{0:x2}", hash(i))
        Next

        Return buf.ToString()
    End Function


End Class
