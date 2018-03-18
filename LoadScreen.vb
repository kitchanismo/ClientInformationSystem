Public Class LoadScreen
    Dim ctr As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ctr += 1
        If ctr = 1 Then
            'check database if okay
            Timer1.Stop()
            Connected()
            Timer1.Start()
        ElseIf ctr = 2 Then
            ctr = 0
            Timer1.Stop()
            Me.Hide()
            User.Show()
        End If
    End Sub

    
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub LoadScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class