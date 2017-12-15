Public Class BaseForm

    Inherits Form

    ''' <summary>
    ''' 画面を遷移する
    ''' </summary>
    ''' <param name="TransitionOriginal">遷移元</param>
    ''' <param name="TransitionTarget">遷移先</param>
    Protected Sub forwardScreen(TransitionOriginal As Form, TransitionTarget As Form)
        TransitionTarget.Show()
        My.Application.ApplicationContext.MainForm = TransitionTarget
        TransitionOriginal.Dispose()
    End Sub

End Class