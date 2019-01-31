Public Class ksmwater

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rdbmetered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbmetered.Click
        Me.Hide()
        metered.Show()
    End Sub


    Private Sub rdbunmetered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbunmetered.Click
        Me.Hide()
        unmetered.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

  
End Class
