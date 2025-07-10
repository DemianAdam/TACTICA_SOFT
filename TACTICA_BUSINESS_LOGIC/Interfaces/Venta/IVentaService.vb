Public Interface IVentaService
    Inherits IBaseService(Of VentaDTO)
    Function GetAllByCliente(cliente As ClienteDTO) As IEnumerable(Of VentaDTO)
End Interface
