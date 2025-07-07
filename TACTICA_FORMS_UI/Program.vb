Option Explicit On
Imports Microsoft.Extensions.DependencyInjection
Imports TACTICA_BUSINESS_LOGIC
Imports TACTICA_DATA_ACCESS
Imports System.Configuration
Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim services As ServiceCollection = New ServiceCollection()
        services.AddDataAccess(ConfigurationManager.ConnectionStrings)
        services.AddBusinessLogic()
        services.AddFormUI()

        Dim serviceProvider As ServiceProvider = services.BuildServiceProvider()

        Dim form As Form = serviceProvider.GetRequiredService(Of Principal)()
        Application.Run(form)
    End Sub
End Module
