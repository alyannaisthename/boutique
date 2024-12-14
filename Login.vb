Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Login

    ' SHA-256 hashing function for password encryption
    Public Function GetSHA256Hash(ByVal input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            ' Convert the input string to bytes and compute the hash
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))

            ' Convert the byte array to a hexadecimal string
            Dim builder As New StringBuilder()
            For Each byteValue As Byte In bytes
                builder.Append(byteValue.ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    Private Sub SignUpForm_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SignUpForm.LinkClicked
        SignUp.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        login_password.PasswordChar = "*"
    End Sub

    Private Sub loginshowpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginshowpass.CheckedChanged
        If loginshowpass.Checked Then
            login_password.PasswordChar = ""
        Else
            login_password.PasswordChar = "*"
        End If
    End Sub

    ' Login Button Click Event
    ' Login Button Click Event
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If login_username.Text = "Username" Then
            MsgBox("Username is Required!", MsgBoxStyle.Exclamation)
            login_username.Focus()
        ElseIf login_password.Text = "Password" Then
            MsgBox("Password is Required!", MsgBoxStyle.Exclamation)
            login_password.Focus()
        Else
            ' Hash the entered password
            Dim hashedPassword As String = GetSHA256Hash(login_password.Text)

            ' Use parameterized query to prevent SQL injection
            Dim connstring As String = "SELECT * FROM registration_tble WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(connstring, sqlconnection)

            ' Add parameters to the query to avoid SQL injection
            cmd.Parameters.AddWithValue("@username", login_username.Text)
            cmd.Parameters.AddWithValue("@password", hashedPassword)

            Try
                sqlconnection.Open()
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    MsgBox("Welcome!", MsgBoxStyle.Information)
                    Me.Hide() ' Hide the login form after successful login

                    ' Log the user's activity
                    dr.Close() ' Close the previous reader before executing a new query
                    Dim logCmd As New MySqlCommand("INSERT INTO activity_logs (username) VALUES (@username)", sqlconnection)
                    logCmd.Parameters.AddWithValue("@username", login_username.Text)
                    logCmd.ExecuteNonQuery()

                    ' Access the open Boutique form and enable the buttons
                    Dim boutiqueForm As Boutique = CType(Application.OpenForms("Boutique"), Boutique)
                    boutiqueForm.EnableButtons() ' Enable buttons in the existing Boutique form

                    ' Clear the textboxes after successful login
                    login_username.Text = ""
                    login_password.Text = ""
                Else
                    MsgBox("Invalid User Credentials!", MsgBoxStyle.Exclamation)
                    login_username.Text = ""
                    login_password.Text = ""
                    login_username.Focus()
                End If
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                sqlconnection.Close()
            End Try
        End If
    End Sub

    Private Sub CloseForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class
