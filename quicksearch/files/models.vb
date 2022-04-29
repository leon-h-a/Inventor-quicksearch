Public Class oFolder

    Private longNameValue As String
    Private shortNameValue As String
    Private childObjectsCollection As New Collection()

    Public Property longName() As String
        Get
            Return longNameValue
        End Get
        Set(value As String)
            longNameValue = value
        End Set
    End Property

    Public Property shortName() As String
        Get
            Return shortNameValue
        End Get
        Set(value As String)
            shortNameValue = value
        End Set
    End Property
    Public WriteOnly Property Write() As Collection
        Set(value As Collection)
            childObjectsCollection.Add(value)
        End Set
    End Property

    Public ReadOnly Property Read() As Collection
        Get
            Return childObjectsCollection
        End Get
    End Property

End Class
