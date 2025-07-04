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

    <Extension()>
    Public Function ToDTO(cliente As Cliente)
        Dim dto As New ClienteDTO With {
            .Id = cliente.ID,
            .Cliente = cliente.Cliente,
            .Telefono = cliente.Telefono,
            .Correo = cliente.Correo
        }
        Return dto
    End Function

    <Extension()>
    Public Function ToDTO(clientes As IEnumerable(Of Cliente))
        Return clientes.Select(Function(c) c.ToDTO()).ToList()
    End Function
End Module
