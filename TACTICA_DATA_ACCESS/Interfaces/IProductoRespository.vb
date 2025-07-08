Public Interface IProductoRespository
    Inherits IBaseRepository(Of Producto)
    Function GetAllCategorias() As IEnumerable(Of String)
End Interface
