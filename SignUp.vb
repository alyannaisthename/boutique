Imports System.Data.DataTable
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class SignUp
    Dim index As Integer
    Dim date_created As String
    Dim time_created As String

    ' SHA-256 hashing function
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

    ' Generate unique user ID if "NOID" is found
    Public Sub formyid()
        Dim createid = ""

        connstring = "Select * from registration_tble where user_id='" & "NOID" & "'"
        sqlconnection.Open()
        cmd = New MySqlCommand(connstring, sqlconnection)
        dr = cmd.ExecuteReader
        If dr.Read Then
            signuptxtid.Text = "UserId-00" & dr("id").ToString
        Else
            createid = "create"
        End If

        sqlconnection.Close()
        If createid = "create" Then
            makeid()
        End If
    End Sub

    ' Create the user ID
    Public Sub makeid()
        connstring = "insert into registration_tble(user_id) values('" & "NOID" & "')"

        sqlconnection.Open()
        di = New MySqlDataAdapter(connstring, sqlconnection)
        di.Fill(ds)
        sqlconnection.Close()
        formyid()
    End Sub

    ' Form setup when shown
    Private Sub SignUpForm_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        signuptxtid.Focus()
        btnedit.Enabled = False
        DataView()

        signuptxtpassword.PasswordChar = "*"
        signuptxtconfirmpass.PasswordChar = "*"
        formyid()
    End Sub

    ' Handle DataGridView cell click
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        signuptxtid.Text = DataGridView1.Rows(index).Cells(0).Value.ToString()
        signuptxtname.Text = DataGridView1.Rows(index).Cells(1).Value.ToString()
        signuptxtusername.Text = DataGridView1.Rows(index).Cells(2).Value.ToString()
        signuptxtpassword.Text = DataGridView1.Rows(index).Cells(3).Value.ToString()
        date_created = DataGridView1.Rows(index).Cells(4).Value.ToString()
        time_created = DataGridView1.Rows(index).Cells(5).Value.ToString()

        btnedit.Enabled = True
        btnsave.Enabled = False
    End Sub

    ' Toggle show/hide password
    Private Sub signupshowpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signupshowpass.CheckedChanged
        If signupshowpass.Checked Then
            signuptxtpassword.PasswordChar = ""
            signuptxtconfirmpass.PasswordChar = ""
        Else
            signuptxtpassword.PasswordChar = "*"
            signuptxtconfirmpass.PasswordChar = "*"
        End If
    End Sub

    ' Reset form values
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        signuptxtid.Text = ""
        signuptxtname.Text = ""
        signuptxtusername.Text = ""
        signuptxtpassword.Text = ""
        signuptxtconfirmpass.Text = ""
        signuptxtid.Focus()
        btnsave.Enabled = True
        btnedit.Enabled = False
        formyid()
    End Sub

    ' Handle link click to show details form
    Private Sub SignUpForm_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SignUpForm.LinkClicked
        Dim detailsForm As New Details()

        detailsForm.UserID = signuptxtid.Text
        detailsForm.Name = signuptxtname.Text
        detailsForm.Username = signuptxtusername.Text
        detailsForm.Password = signuptxtpassword.Text
        detailsForm.DateCreated = date_created
        detailsForm.TimeCreated = time_created

        detailsForm.Show()
    End Sub

    ' Data view setup
    Public Sub DataView()
        Try
            qry = "SELECT * FROM registration_tble where user_id <> '" & "NOID" & "'"
            sqlconnection.Open()
            cmd = New MySqlCommand(qry, sqlconnection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()

            While dr.Read()
                DataGridView1.Rows.Add(dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If sqlconnection IsNot Nothing AndAlso sqlconnection.State = ConnectionState.Open Then
                sqlconnection.Close()
            End If
        End Try
    End Sub

    ' Save user data with hashed password
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If signuptxtid.Text = "" Then
            MsgBox("User ID is required.", MsgBoxStyle.Exclamation)
            signuptxtid.Focus()
        ElseIf signuptxtname.Text = "" Then
            MsgBox("Name is required.", MsgBoxStyle.Exclamation)
            signuptxtname.Focus()
        ElseIf signuptxtusername.Text = "" Then
            MsgBox("Username is required.", MsgBoxStyle.Exclamation)
            signuptxtusername.Focus()
        ElseIf signuptxtpassword.Text = "" Then
            MsgBox("Password is required.", MsgBoxStyle.Exclamation)
            signuptxtpassword.Focus()
        ElseIf signuptxtconfirmpass.Text = "" Then
            MsgBox("Confirming password is required.", MsgBoxStyle.Exclamation)
            signuptxtconfirmpass.Focus()
        ElseIf signuptxtconfirmpass.Text <> signuptxtpassword.Text Then
            MsgBox("Passwords do not match.", MsgBoxStyle.Exclamation)
            signuptxtconfirmpass.Text = ""
            signuptxtconfirmpass.Focus()
        Else
            ' Hash the password before saving
            Dim hashedPassword As String = GetSHA256Hash(signuptxtpassword.Text)

            ' Save to the database
            connstring = "UPDATE registration_tble SET user_id = '" & signuptxtid.Text & "', name = '" & _
                         signuptxtname.Text & "', username = '" & signuptxtusername.Text & "', password = '" & _
                         hashedPassword & "', date_created = '" & DateTime.Now.ToString("yyyy-MM-dd") & _
                         "', time_created = '" & DateTime.Now.ToString("HH:mm:ss") & "' WHERE user_id = '" & "NOID" & "'"

            sqlconnection.Open()
            Dim di As New MySqlDataAdapter(connstring, sqlconnection)
            di.Fill(ds)
            sqlconnection.Close()

            ' Reset form after saving
            signuptxtid.Text = ""
            signuptxtname.Text = ""
            signuptxtusername.Text = ""
            signuptxtpassword.Text = ""
            signuptxtconfirmpass.Text = ""
            signuptxtid.Focus()
            DataView()
            formyid()
        End If
    End Sub

    ' Edit user data with hashed password
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If signuptxtid.Text = "" Then
            MsgBox("User ID is Required!", MsgBoxStyle.Exclamation)
            signuptxtid.Focus()
        ElseIf signuptxtname.Text = "" Then
            MsgBox("Name is Required!", MsgBoxStyle.Exclamation)
            signuptxtname.Focus()
        ElseIf signuptxtusername.Text = "" Then
            MsgBox("Username is Required!", MsgBoxStyle.Exclamation)
            signuptxtusername.Focus()
        ElseIf signuptxtpassword.Text = "" Then
            MsgBox("Password is Required!", MsgBoxStyle.Exclamation)
            signuptxtpassword.Focus()
        ElseIf signuptxtconfirmpass.Text = "" Then
            MsgBox("Confirming password is Required!", MsgBoxStyle.Exclamation)
            signuptxtconfirmpass.Focus()
        ElseIf signuptxtconfirmpass.Text <> signuptxtpassword.Text Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Exclamation)
            signuptxtconfirmpass.Text = ""
            signuptxtpassword.Focus()
        Else
            ' Hash the password before updating
            Dim hashedPassword As String = GetSHA256Hash(signuptxtpassword.Text)

            ' Update the user data with hashed password
            connstring = "UPDATE registration_tble SET user_id = '" & signuptxtid.Text & "', name = '" & _
                         signuptxtname.Text & "', username = '" & signuptxtusername.Text & "', password = '" & _
                         hashedPassword & "', date_created = '" & DateTime.Now.ToString("yyyy-MM-dd") & _
                         "', time_created = '" & DateTime.Now.ToString("HH:mm:ss") & "' WHERE user_id = '" & signuptxtid.Text & "'"

            sqlconnection.Open()
            Dim di As New MySqlDataAdapter(connstring, sqlconnection)
            di.Fill(ds)
            sqlconnection.Close()

            ' Reset form after updating
            signuptxtid.Text = ""
            signuptxtname.Text = ""
            signuptxtusername.Text = ""
            signuptxtpassword.Text = ""
            signuptxtconfirmpass.Text = ""
            signuptxtid.Focus()
            btnsave.Enabled = True
            btnedit.Enabled = False
            DataView()
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
