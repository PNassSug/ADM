Public Class GridLinhaFocu
    Private privateSourceRowHandle As Integer

    Public Property SourceRowHandle() As Integer
        Get
            Return privateSourceRowHandle
        End Get
        Set(ByVal value As Integer)
            privateSourceRowHandle = value
        End Set
    End Property

    Private privateRelationIndex As Integer

    Public Property RelationIndex() As Integer
        Get
            Return privateRelationIndex
        End Get
        Set(ByVal value As Integer)
            privateRelationIndex = value
        End Set
    End Property
End Class
