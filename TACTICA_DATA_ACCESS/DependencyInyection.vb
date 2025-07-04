Option Strict On
Option Explicit On
Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.DependencyInjection
Imports System.Configuration

Public Module DependencyInyection
    <Extension()>
    Public Sub AddDataAccess(services As IServiceCollection, connectionStrings As ConnectionStringSettingsCollection)
        services.AddSingleton(Of ConnectionStringSettingsCollection)(connectionStrings)
        services.AddScoped(Of Connection)()
        services.AddTransient(Of IClienteRepository, ClienteRepository)()
    End Sub
End Module
