Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.DependencyInjection

Public Module DependencyInyection
    <Extension()>
    Public Sub AddBusinessLogic(services As IServiceCollection)
        services.AddSingleton(Of IEventBus, EventBus)()
        services.AddTransient(Of IClienteService, ClienteService)()
    End Sub
End Module
