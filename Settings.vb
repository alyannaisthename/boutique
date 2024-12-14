Public Class Settings

    ' Handle Logout button click
    Private Sub storebtnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtnlogout.Click
        ' Log out the user
        MsgBox("You have successfully logged out.", MsgBoxStyle.Information)

        ' Assuming you have a method in the Boutique form to disable buttons
        ' You may want to handle it in the form that initiated the Settings form, for example:
        If TypeOf Me.Owner Is Boutique Then
            Dim boutiqueForm As Boutique = CType(Me.Owner, Boutique)
            boutiqueForm.DisableButtons() ' Disable buttons in Boutique form
        End If

        ' Close the Settings form after logout
        Me.Close()

        ' Optionally show the Login form again (if required)
        Boutique.Show()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub

    Private Sub btnUserLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserLogs.Click
        UserLogs.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
