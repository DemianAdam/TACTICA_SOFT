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
        If entity.Items IsNot Nothing AndAlso entity.Items.Any() Then
            Throw New InvalidOperationException("No se puede eliminar un producto que tiene ventas asociadas")
        End If
        Dim producto As Producto = entity.ToModel()
        _productoRepository.Delete(producto)
    End Sub

    Public Function GetAllCategorias() As IEnumerable(Of String) Implements IProductoService.GetAllCategorias
        Return _productoRepository.GetAllCategorias()
    End Function

    Public Function GetById(id As Integer) As ProductoDTO Implements IBaseService(Of ProductoDTO).GetById
        Dim producto As Producto = _productoRepository.GetById(id)
        Return producto.ToDTO()
    End Function

    Public Function GetAll() As IEnumerable(Of ProductoDTO) Implements IBaseService(Of ProductoDTO).GetAll
        Dim productos As IEnumerable(Of Producto) = _productoRepository.GetAll()
        Return productos.ToDTO()
    End Function
End Class
