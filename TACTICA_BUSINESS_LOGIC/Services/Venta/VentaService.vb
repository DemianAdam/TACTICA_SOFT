Imports System.Reflection
Imports TACTICA_DATA_ACCESS

Public Class VentaService
    Implements IVentaService
    Private ReadOnly _ventaUnitOfWork As IVentaUnitOfWork
    Private ReadOnly _ventaValidator As IValidator(Of VentaDTO)
    Public Sub New(ventaUnitOfWork As IVentaUnitOfWork, ventaValidator As IValidator(Of VentaDTO))
        _ventaUnitOfWork = ventaUnitOfWork
        _ventaValidator = ventaValidator
    End Sub

    Public Sub Add(entity As VentaDTO) Implements IBaseService(Of VentaDTO).Add
        _ventaValidator.Validate(entity)
        Dim venta As Venta = entity.ToModel()
        Dim items As List(Of Item) = entity.Items.ToModel().ToList()
        Try
            _ventaUnitOfWork.Add(venta, items)
            entity.Id = venta.ID
            entity.Items = items.ToDTO().ToList()
        Catch
            Throw
        End Try

    End Sub

    Public Sub Update(entity As VentaDTO) Implements IBaseService(Of VentaDTO).Update
        _ventaValidator.Validate(entity)
        Dim venta As Venta = entity.ToModel()
        Dim items As List(Of Item) = entity.Items.ToModel().ToList()
        _ventaUnitOfWork.Update(venta, items)
    End Sub

    Public Sub Delete(entity As VentaDTO) Implements IBaseService(Of VentaDTO).Delete
        Dim venta As Venta = entity.ToModel()
        _ventaUnitOfWork.Delete(venta)
    End Sub

    Public Function GetAllByCliente(cliente As ClienteDTO) As IEnumerable(Of VentaDTO) Implements IVentaService.GetAllByCliente
        Dim model As Cliente = cliente.ToModel()
        Return _ventaUnitOfWork.GetAllByCliente(model).toDTO()
    End Function

    Public Function GetById(id As Integer) As VentaDTO Implements IBaseService(Of VentaDTO).GetById
        Return _ventaUnitOfWork.GetById(id).ToDTO()
    End Function

    Public Function GetAll() As IEnumerable(Of VentaDTO) Implements IBaseService(Of VentaDTO).GetAll
        Return _ventaUnitOfWork.GetAll().ToList().ToDTO()
    End Function
End Class
