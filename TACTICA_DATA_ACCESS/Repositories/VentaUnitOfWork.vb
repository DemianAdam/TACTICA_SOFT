Public Class VentaUnitOfWork
    Implements IVentaUnitOfWork

    Private ReadOnly _conexion As Connection
    Private ReadOnly _ventaRepository As IVentaRepository
    Private ReadOnly _itemRepository As IItemRepository
    Public Sub New(ventaRepository As IVentaRepository, itemRepository As IItemRepository, conexion As Connection)
        _ventaRepository = ventaRepository
        _itemRepository = itemRepository
        _conexion = conexion
    End Sub
    Public Sub Add(venta As Venta, items As List(Of Item)) Implements IVentaUnitOfWork.Add
        Using connection As IDbConnection = _conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                Using transaction As IDbTransaction = connection.BeginTransaction()
                    command.Transaction = transaction
                    Try
                        venta.ID = _ventaRepository.Add(venta, command)
                        For Each item As Item In items
                            item.Venta.ID = venta.ID
                            item.ID = _itemRepository.Add(item, command)
                        Next
                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Public Sub Update(venta As Venta, items As List(Of Item)) Implements IVentaUnitOfWork.Update
        Using connection As IDbConnection = _conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                Using transaction As IDbTransaction = connection.BeginTransaction()
                    command.Transaction = transaction
                    Try
                        _itemRepository.DeleteByVenta(venta, command)
                        _ventaRepository.Update(venta, command)
                        For Each item As Item In items
                            _itemRepository.Add(item, command)
                        Next
                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Public Sub Delete(venta As Venta) Implements IVentaUnitOfWork.Delete
        Using connection As IDbConnection = _conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                Using transaction As IDbTransaction = connection.BeginTransaction()
                    command.Transaction = transaction
                    Try
                        _itemRepository.DeleteByVenta(venta, command)
                        _ventaRepository.Delete(venta, command)
                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Public Function GetAll() As IEnumerable(Of Venta) Implements IVentaUnitOfWork.GetAll
        Return _ventaRepository.GetAll()
    End Function

    Public Function GetAllById(id As Integer) As Venta Implements IVentaUnitOfWork.GetById
        Return _ventaRepository.GetById(id)
    End Function

    Public Function GetAllByCliente(cliente As Cliente) As IEnumerable(Of Venta) Implements IVentaUnitOfWork.GetAllByCliente
        Return _ventaRepository.GetAllByCliente(cliente)
    End Function
End Class
