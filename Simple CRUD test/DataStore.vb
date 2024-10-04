Module DataStore
    Private Users As New List(Of User)()
    Private nextId As Integer = 1

    Public Function CreateUser(name As String, email As String) As User
        Dim user As New User(nextId, name, email)
        Users.Add(user)
        nextId += 1
        Return user
    End Function

    Public Function ReadUsers() As List(Of User)
        Return Users
    End Function

    Public Function UpdateUser(id As Integer, name As String, email As String) As Boolean
        Dim user = Users.FirstOrDefault(Function(u) u.Id = id)
        If user IsNot Nothing Then
            user.Name = name
            user.Email = email
            Return True
        End If
        Return False
    End Function

    Public Function CountUser() As Integer
        Return Users.Count
    End Function

    Public Function DeleteUser(id As Integer) As Boolean
        Dim user = Users.FirstOrDefault(Function(u) u.Id = id)
        If user IsNot Nothing Then
            Users.Remove(user)
            Return True
        End If
        Return False
    End Function
End Module
