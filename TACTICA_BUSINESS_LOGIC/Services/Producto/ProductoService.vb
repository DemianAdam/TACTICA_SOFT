Imports TACTICA_DATA_ACCESS

Public Class ProductoService
    Implements IProductoService

    Private ReadOnly _productoRepository As IProductoRespository
    Private ReadOnly _productoValidator As IValidator(Of ProductoDTO)

    Public Sub New(productoRepository As IProductoRespository, productoValidator As IValidator(Of ProductoDTO))
        _productoRepository = productoRepository
        _productoValidator = productoValidator
    End Sub
    Public Sub Add(entity As ProductoDTO) Implements IBaseService(Of ProductoDTO).Add
        _productoValidator.Validate(entity)
        Dim producto As Producto = entity.ToModel()
        Dim id As Integer = _productoRepository.Add(producto)
        entity.Id = id
    End Sub

    Public Sub Update(entity As ProductoDTO) Implements IBaseService(Of ProductoDTO).Update
        _productoValidator.Validate(entity)
        Dim producto As Producto = entity.ToModel()
        _productoRepository.Update(producto)
    End Sub

    Public Sub Delete(entity As ProductoDTO) Implements IBaseService(Of ProductoDTO).Delete
        Throw New NotImplementedException()
    End Sub

    Public Function GetAllCategorias() As IEnumerable(Of String) Implements IProductoService.GetAllCategorias
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As ProductoDTO Implements IBaseService(Of ProductoDTO).GetById
        Throw New NotImplementedException()
    End Function

    Public Function GetAll() As IEnumerable(Of ProductoDTO) Implements IBaseService(Of ProductoDTO).GetAll
        Throw New NotImplementedException()
    End Function
End Class
