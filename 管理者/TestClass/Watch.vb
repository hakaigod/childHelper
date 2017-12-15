Public Class Watch

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Month1Age
        Me.Enabled = False
        f.Show(Me)


        Dim ht_eventbox As Hashtable = New Hashtable

        ht_eventbox.Add("ClassName", f.ComboBox_ClassName.Text)
        ht_eventbox.Add("BoysNumber", f.TextBoxBoysNumber.Text)
        ht_eventbox.Add("GirlsNumber", f.TextBoxGirlsNumber.Text)
        ht_eventbox.Add("TargetYear", f.ComboBoxTargetYear.Text)
        ht_eventbox.Add("TargetMonth", f.ComboBoxTargetMonth.Text)
        ht_eventbox.Add("LeaderName", f.ComboBoxLeaderName.Text)
        ht_eventbox.Add("StateMonth", f.RichTextBoxStateMonth.Text)
        ht_eventbox.Add("AimNursing", f.RichTextBoxAimNursing.Text)
        ht_eventbox.Add("AimEducation", f.RichTextBoxAimEducation.Text)
        ht_eventbox.Add("Event", f.RichTextBoxEvent.Text)
        ht_eventbox.Add("Contents", f.RichTextBoxContents.Text)
        ht_eventbox.Add("HealthSafety", f.RichTextBoxHealthSafety.Text)
        ht_eventbox.Add("EnvironmentalComposition", f.RichTextBoxEnvironmentalComposition.Text)
        ht_eventbox.Add("NextPoint", f.RichTextBoxNextPoint.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class