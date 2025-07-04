Friend Class EventBus
    Implements IEventBus

    Private ReadOnly _subscribers As Dictionary(Of Type, List(Of [Delegate])) = New Dictionary(Of Type, List(Of [Delegate]))
    Public Sub Susbscribe(Of TEvent As IEvent)(handler As Action(Of TEvent)) Implements IEventBus.Susbscribe
        Dim eventType As Type = GetType(TEvent)
        Dim value As List(Of [Delegate]) = Nothing
        If Not _subscribers.TryGetValue(eventType, value) Then
            value = New List(Of [Delegate])()
            _subscribers(eventType) = value
        End If
        value.Add(handler)
    End Sub

    Public Sub Unsubscribe(Of TEvent As IEvent)(handler As Action(Of TEvent)) Implements IEventBus.Unsubscribe
        Dim eventType As Type = GetType(TEvent)
        Dim value As List(Of [Delegate]) = Nothing
        If _subscribers.TryGetValue(eventType, value) Then
            value.Remove(handler)
        End If
    End Sub

    Public Sub Publish(Of TEvent As IEvent)(eventMessage As TEvent) Implements IEventBus.Publish
        Dim eventType As Type = eventMessage.GetType()

        If _subscribers.ContainsKey(eventType) Then
            For Each handler As [Delegate] In _subscribers(eventType)
                DirectCast(handler, Action(Of TEvent)).Invoke(eventMessage)
            Next
        End If
    End Sub
End Class
