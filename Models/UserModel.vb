'all users database operations will be happen here

Public Class UserModel
    Inherits UserInterface 'will inherits User Interface so that all properties of it will also have User model


    'check if user is authentic/authorize with username and password as parameters
    'will return true if user is authentic, otherwise it return false
    Public Function isUserAuthentic(ByVal username As String, ByVal password As String) As Boolean
        Connected()
        sql = "Select * from tblUser where username = '" & username & "' and password = '" & password & "' "
        CommandRead(sql)
        If dr.HasRows() Then
            Return True
        Else
            Return False
        End If
    End Function

    'get the user role base on his/her username
    Public Function getUserRole(ByVal username As String) As String
        Connected()
        sql = "Select role from tblUser where username = '" & username & "' "
        CommandRead(sql)
        If dr.HasRows() Then
            While dr.Read()
                Return dr.Item("role")
            End While
        End If
        Return ""
    End Function

    'not implented this yet, since we have no User maintenance
    Public Function isUserExist(ByVal username As String) As Boolean
        Connected()
        sql = "Select * from tblUser where username = '" & username & "' "
        CommandRead(sql)
        If dr.HasRows() Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
