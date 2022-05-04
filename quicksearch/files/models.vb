Imports System.Text.RegularExpressions

Public Class oFile
    Private pathValue As String
    Private nameValue As String
    Private parentFolderValue As String
    Private indentationValue As Integer
    Public Property Path() As String
        Set(value As String)
            pathValue = value
        End Set
        Get
            Return pathValue
        End Get
    End Property

    Public Property Name() As String
        Set(value As String)
            Dim objectName As String
            objectName = Regex.Match(value, "[^\\]+$").Value
            nameValue = objectName
        End Set
        Get
            Return nameValue
        End Get
    End Property
    Public Property ParentFolder() As String
        Set(value As String)
            parentFolderValue = value
        End Set
        Get
            Return parentFolderValue
        End Get
    End Property

    Public Property Increment() As Integer
        Set(value As Integer)
            indentationValue = value
        End Set
        Get
            Return indentationValue
        End Get
    End Property
End Class

Public Class oFolder
    Private pathValue As String
    Private nameValue As String
    Private indentationValue As Integer
    Private filesList As New Collection()

    Public Property Path() As String
        Set(value As String)
            pathValue = value
        End Set
        Get
            Return pathValue
        End Get
    End Property

    Public Property Name() As String
        Set(value As String)
            Dim objectName As String
            objectName = Regex.Match(value, "[^\\]+$").Value
            nameValue = objectName
        End Set
        Get
            Return nameValue
        End Get
    End Property

    Public Property Increment() As Integer
        Set(value As Integer)
            indentationValue = value
        End Set
        Get
            Return indentationValue
        End Get
    End Property

    Public Function AddFile(item As oFile) As Integer
        filesList.Add(item)
        Return 0
    End Function

    Public Function GetFiles() As Collection
        Return filesList
    End Function

End Class