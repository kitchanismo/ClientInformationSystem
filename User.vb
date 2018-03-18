Public Class User

    Public role As String
    Public username As String

    Dim password As String
    Dim um As New UserModel

    Private Sub lblexit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnlgn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnlgn.Click

        username = txtuname.Text.ToLower
        password = txtpword.Text.ToLower

        'check if user is unauthorized or valid
        If um.isUserAuthentic(username, password) Then

            'get and assign the role of the user
            role = um.getUserRole(username)

            MsgBox("Successfully Login!", MsgBoxStyle.Information)
            Main_Form.Show()
            Me.Hide()
        Else
            MsgBox("Username And Password is incorrect!", MsgBoxStyle.Exclamation)
        End If

        txtuname.Clear()
        txtpword.Clear()
    End Sub


    Private Sub btnclose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Login.MouseDown
        pos = GetLocation(Panel1)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Login.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Panel1.Location = SetLocation(pos, MousePosition)
        End If
    End Sub
End Class
