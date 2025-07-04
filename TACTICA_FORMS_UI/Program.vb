Option Strict On
Option Explicit On
Imports Microsoft.Extensions.DependencyInjection
Imports TACTICA_BUSINESS_LOGIC
Imports TACTICA_DATA_ACCESS
Imports System.Configuration
Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim services = New ServiceCollection()
        services.AddDataAccess(ConfigurationManager.ConnectionStrings)
        services.AddBusinessLogic()
        services.AddFormUI()

        Dim serviceProvider = services.BuildServiceProvider()

        Dim form = serviceProvider.GetRequiredService(Of Principal)()
        Application.Run(form)
    End Sub
End Module
