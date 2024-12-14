Public Class Boutique 
    ' A method to enable all buttons except Login after successful login
    Public Sub EnableButtons()
        storebtnproduct.Enabled = True
        storebtninventory.Enabled = True
        storebtnhome.Enabled = True
        storebtnstocks.Enabled = True
        storebtnmaintenance.Enabled = True
        storebtnsettings.Enabled = True
        storebtnlogin.Enabled = False ' Disable Login button after successful login
    End Sub

    ' A method to disable all buttons except Login
    Public Sub DisableButtons()
        storebtnproduct.Enabled = False
        storebtninventory.Enabled = False
        storebtnhome.Enabled = False
        storebtnstocks.Enabled = False
        storebtnmaintenance.Enabled = False
        storebtnsettings.Enabled = False
        storebtnlogin.Enabled = True ' Enable Login button when logged out
    End Sub

    Private Sub Boutique_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Disable all buttons except login at the start
        DisableButtons()
        storebtnlogin.Enabled = True ' Ensure Login is always enabled
    End Sub

    ' Button Click Events
    Private Sub storebtnproduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtnproduct.Click
        Product.Show()
    End Sub

    Private Sub storebtnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtnlogin.Click
        ' Show login form
        Login.Show()
    End Sub

    Private Sub storebtninventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtninventory.Click
        Inventory.Show()
    End Sub

    Private Sub storebtnhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtnhome.Click
        PointSale.Show()
    End Sub

    Private Sub storebtnstocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtnstocks.Click
        Stocks.Show()
    End Sub

    Private Sub storebtnmaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtnmaintenance.Click
        Maintenance.Show()
    End Sub

    Private Sub storebtnsettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles storebtnsettings.Click
        ' Pass Boutique form as the owner to Settings form
        Dim settingsForm As New Settings()
        settingsForm.Owner = Me
        settingsForm.Show()
    End Sub
End Class
