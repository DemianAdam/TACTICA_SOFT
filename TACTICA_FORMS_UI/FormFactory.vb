Imports Microsoft.Extensions.DependencyInjection

Public Class FormFactory
    Private ReadOnly _serviceProvider As IServiceProvider

    Public Sub New(serviceProvider As IServiceProvider)
        _serviceProvider = serviceProvider
    End Sub

    Public Function CreateForm(Of T As Form)(ParamArray parameters() As Object) As T
        Dim form As T = _serviceProvider.GetService(Of T)()
        If form Is Nothing Then
            Dim obj As Object = ActivatorUtilities.CreateInstance(_serviceProvider, GetType(T), parameters)
            form = DirectCast(obj, T)
        End If

        Return form
    End Function
End Class
