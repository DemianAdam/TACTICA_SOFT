Option Strict On
Option Explicit On
Imports System.Runtime.CompilerServices
Imports TACTICA_DATA_ACCESS
Friend Module ClienteMapper
    <Extension()>
    Public Function ToModel(cliente As ClienteDTO) As Cliente
        Dim model As New Cliente With {
            .ID = cliente.Id,
            .Cliente = cliente.Cliente,
            .Telefono = cliente.Telefono,
            .Correo = cliente.Correo
        }
        Return model
    End Function

    <Extension()>
    Public Function ToDTO(cliente As Cliente) As ClienteDTO
        Dim dto As New ClienteDTO With {
            .Id = cliente.ID,
            .Cliente = cliente.Cliente,
            .Telefono = cliente.Telefono,
            .Correo = cliente.Correo
        }
        Return dto
    End Function

    <Extension()>
    Public Function ToDTO(clientes As IEnumerable(Of Cliente)) As IEnumerable(Of ClienteDTO)
        Return clientes.Select(Function(c) c.ToDTO())
    End Function
End Module
