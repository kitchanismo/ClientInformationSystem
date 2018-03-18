Public Class Main_Form
    'policyNumber will be get the value if client is selected
    Public id As Integer

    'instatiate Client Model
    Dim cm As New ClientModel


    Private Sub Main_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        User.username = ""
        User.role = ""
        User.Show()
    End Sub

    Private Sub Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtrole.Text = "Loading ..."

        'grant access to user role
        AccessGranted(User.role)

        'display all client to listview
        cm.ShowClient(lvClient)
    End Sub

    Private Sub lvClient_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvClient.MouseClick
        'assign policy number when client is select
        With lvClient.SelectedItems(0)
            id = .SubItems(0).Text
            lblclient.Text = "Client List - " & .SubItems(2).Text.ToUpper
        End With
    End Sub

    Private Sub lvClient_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvClient.MouseDoubleClick
        'assign policy number when client is select
        With lvClient.SelectedItems(0)
            id = .SubItems(0).Text
        End With
        Me.TopMost = False
        transparent.Show()
        ViewClient.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cm.Search(txtsearch.Text, lvClient)
        lblclient.Text = "Client List"
    End Sub

    Private Sub btnrefresh_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        cm.ShowClient(lvClient)
        txtsearch.Text = " "
        lblclient.Text = "Client List"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Me.TopMost = False
        transparent.Show()
        AddClient.ShowDialog()
        cm.ShowClient(lvClient)
        lblclient.Text = "Client List"
        Me.TopMost = True
    End Sub

    Private Sub btnarchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarchive.Click
        Me.TopMost = False
        transparent.Show()
        ArchiveClient.ShowDialog()
        cm.ShowClient(lvClient)
        lblclient.Text = "Client List"
        Me.TopMost = True
    End Sub

    Private Sub btnreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreports.Click
        Me.TopMost = False
        transparent.Show()
        Reports.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub timerdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerdate.Tick
        'get the username and role into the User form and concatenate Date and Time
        txtrole.Text = User.username.ToUpper & " | " & User.role.ToUpper & " | " & Format(Date.Now, "short date") & " | " & TimeOfDay
    End Sub


    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.TopMost = False
        'if client is not selected in list
        If lvClient.SelectedItems.Count = 0 Then
            transparent.Show()
            MsgBox("Select Client from List", MsgBoxStyle.Exclamation)
            transparent.Close()
            Exit Sub
        End If

        transparent.Show()

        'show edit form
        EditClient.ShowDialog()
        'refresh client
        cm.ShowClient(lvClient)
        'reset
        lvClient.SelectedItems.Clear()
        lblclient.Text = "Client List"
        Me.TopMost = True
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Me.TopMost = False
        'if client is not selected in list
        If lvClient.SelectedItems.Count = 0 Then
            transparent.Show()
            MsgBox("Select Client from List", MsgBoxStyle.Exclamation)
            transparent.Close()
            Exit Sub
        End If

        'get fullname in selected client list
        Dim fullname As String
        With lvClient.SelectedItems(0)
            fullname = .SubItems(2).Text
        End With


        transparent.Show()
        'confirm if user want to delete or not
        Dim msg As String = MsgBox("Are you sure do you want to delete? " & vbNewLine & vbNewLine & fullname.ToUpper, MsgBoxStyle.YesNo)
        If msg = MsgBoxResult.Yes Then
            'execute delete
            cm.Delete(id)
            'refresh client
            cm.ShowClient(lvClient)

        End If
        'reset
        lvClient.SelectedItems.Clear()
        lblclient.Text = "Client List"
        transparent.Close()
        Me.TopMost = True
    End Sub

    Private Sub lbllogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllogout.Click
        Me.TopMost = False
        transparent.Show()

        Dim msg As String = MsgBox("Are you sure do you want to logout? ", MsgBoxStyle.YesNo)
        If msg = MsgBoxResult.Yes Then
            Me.Close()
            User.username = ""
            User.role = ""
            User.Show()
        End If

        transparent.Close()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        'if client is not selected in list
        Me.TopMost = False
        If lvClient.SelectedItems.Count = 0 Then
            transparent.Show()
            MsgBox("Select Client from List", MsgBoxStyle.Exclamation)
            transparent.Close()
            Exit Sub
        End If
        transparent.Show()
        ViewClient.ShowDialog()
        Me.TopMost = True
    End Sub

    'if user role is manager then access all,if not access view only
    Sub AccessGranted(ByVal role As String)
        If role.ToLower = "manager" Then
            ButtonVisible(True)
        Else
            ButtonVisible(False)
        End If
    End Sub

    Sub ButtonVisible(ByVal i As Boolean)
        btnadd.Visible = i
        btnedit.Visible = i
        btndelete.Visible = i
        btnreports.Visible = i
    End Sub


End Class