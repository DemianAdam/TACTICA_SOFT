Option Strict On
Option Explicit On
Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.DependencyInjection

Module DependencyInyection
    <Extension()>
    Public Sub AddFormUI(services As IServiceCollection)
        services.AddSingleton(Of Principal)()
    End Sub
End Module
