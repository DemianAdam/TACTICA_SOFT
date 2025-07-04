Imports System.Runtime.CompilerServices
Imports TACTICA_DATA_ACCESS
Friend Module ClienteMapper
    <Extension()>
    Public Function ToModel(cliente As ClienteDTO)
        Dim model As New Cliente With {
            .ID = cliente.Id,
            .Cliente = cliente.Cliente,
            .Telefono = cliente.Telefono,
            .Correo = cliente.Correo
        }
        Return model
    End Function
End Module
