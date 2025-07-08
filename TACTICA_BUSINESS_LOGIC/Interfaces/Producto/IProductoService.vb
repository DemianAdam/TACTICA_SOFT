Public Interface IProductoService
    Inherits IBaseService(Of ProductoDTO)

    Function GetAllCategorias() As IEnumerable(Of String)
End Interface
