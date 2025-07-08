Imports TACTICA_DATA_ACCESS

Friend Class ClienteService
    Implements IClienteService

    Private ReadOnly _clienteRepository As IClienteRepository
    Private ReadOnly _clienteValidator As IValidator(Of ClienteDTO)

    Public Sub New(clienteRepository As IClienteRepository, clienteValidator As IValidator(Of ClienteDTO))
        _clienteRepository = clienteRepository
        _clienteValidator = clienteValidator
    End Sub
    Public Sub Add(entity As ClienteDTO) Implements IBaseService(Of ClienteDTO).Add
        _clienteValidator.Validate(entity)
        Dim cliente As Cliente = entity.ToModel()
        Dim id As Integer = _clienteRepository.Add(cliente)
        entity.Id = id
    End Sub

    Public Sub Update(entity As ClienteDTO) Implements IBaseService(Of ClienteDTO).Update
        _clienteValidator.Validate(entity)
        Dim cliente As Cliente = entity.ToModel()
        _clienteRepository.Update(cliente)
    End Sub

    Public Sub Delete(entity As ClienteDTO) Implements IBaseService(Of ClienteDTO).Delete
        If entity.Ventas IsNot Nothing AndAlso entity.Ventas.Any() Then
            Throw New InvalidOperationException("No se puede eliminar un cliente que tiene ventas asociadas.")
        End If

        Dim cliente As Cliente = entity.ToModel()
        _clienteRepository.Delete(cliente)
    End Sub

    Public Function GetById(id As Integer) As ClienteDTO Implements IBaseService(Of ClienteDTO).GetById
        Dim cliente As Cliente = _clienteRepository.GetById(id)
        Return cliente.ToDTO()
    End Function

    Public Function GetAll() As IEnumerable(Of ClienteDTO) Implements IBaseService(Of ClienteDTO).GetAll
        Dim clientes As IEnumerable(Of Cliente) = _clienteRepository.GetAll()
        Return clientes.ToDTO()
    End Function
End Class

