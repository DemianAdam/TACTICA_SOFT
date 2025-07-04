Public Interface IEventBus
    Sub Susbscribe(Of TEvent As IEvent)(handler As Action(Of TEvent))
    Sub Unsubscribe(Of TEvent As IEvent)(handler As Action(Of TEvent))
    Sub Publish(Of TEvent As IEvent)(eventMessage As TEvent)
End Interface
