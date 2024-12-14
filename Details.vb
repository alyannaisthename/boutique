Public Class Details
    Public Overloads Property Name As String
    Public Property UserId As String
    Public Property Username As String
    Public Property Password As String
    Public Property DateCreated As String
    Public Property TimeCreated As String

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        lblid.Text = UserId
        lblname.Text = Name
        lblusername.Text = Username
        lblpassword.Text = Password
        lbldate.Text = DateCreated
        lbltime.Text = TimeCreated

    End Sub
End Class
