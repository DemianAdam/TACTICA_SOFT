Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.DependencyInjection

Public Module DependencyInyection
    <Extension()>
    Public Sub AddBusinessLogic(services As IServiceCollection)
        services.AddSingleton(Of IEventBus, EventBus)()
        services.AddSingleton(Of IValidator(Of ClienteDTO), ClienteDTOValidator)
        services.AddSingleton(Of IValidator(Of ProductoDTO), ProductoDTOValidator)
        services.AddTransient(Of IClienteService, ClienteService)()
        services.AddTransient(Of IProductoService, ProductoService)
    End Sub
End Module
