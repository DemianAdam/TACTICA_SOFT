Public MustInherit Class BaseEvent(Of T)
    Implements ITEvent(Of T)

    Public Sub New(data As T, type As ActionType)
        Me.Data = data
        Me.Type = type
    End Sub
    Property Data As T Implements ITEvent(Of T).Data
    Property Type As ActionType Implements ITEvent(Of T).ActionType
End Class
