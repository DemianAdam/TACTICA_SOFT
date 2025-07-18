﻿
Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.DependencyInjection
Imports System.Configuration

Public Module DependencyInyection
    <Extension()>
    Public Sub AddDataAccess(services As IServiceCollection, connectionStrings As ConnectionStringSettingsCollection)
        services.AddSingleton(Of ConnectionStringSettingsCollection)(connectionStrings)
        services.AddTransient(Of Connection)()
        services.AddTransient(Of IClienteRepository, ClienteRepository)()
        services.AddTransient(Of IProductoRespository, ProductoRepository)()
        services.AddTransient(Of IVentaUnitOfWork, VentaUnitOfWork)
        services.AddTransient(Of IVentaRepository, VentaRespository)
        services.AddTransient(Of IItemRepository, ItemRepository)
    End Sub
End Module
