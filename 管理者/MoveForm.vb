Public Class MoveForm

    Private move_info As String
    Private myOwner As Form

    Public Sub New(f As Form)
        ' Code for the constructor goes here.
        myOwner = f
    End Sub

    ' 他フォームから動かす奴
    Public Sub MoveInfoSetter(mInfo As String)
        Me.move_info = mInfo
    End Sub
    Public Function MoveInfoGetter() As String
        Return Me.move_info
    End Function
    Public Sub MoveForm()

        Select Case MoveInfoGetter()
            Case "SelectAddDocument"
                MoveSelectAddDocument()
            Case "MonthHigh"
                MoveMonthHigh()
            Case "MonthLow"
                MoveMonthLow()

        End Select

    End Sub

    Private Sub MoveMonthHigh()
        Dim f As New Month35Age
        myOwner.Enabled = False
        f.Show(myOwner)
    End Sub

    Private Sub MoveMonthLow()
        Dim f As New MonthLow
        myOwner.Enabled = False
        f.Show(myOwner)
    End Sub

    Private Sub MoveSelectAddDocument()
        Dim f As New SelectAddDocument
        myOwner.Enabled = False
        f.Show(myOwner)
    End Sub
End Class