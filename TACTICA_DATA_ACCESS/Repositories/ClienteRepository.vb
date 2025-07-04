Option Strict On
Option Explicit On
Imports System.Configuration

Public Class ClienteRepository
    Inherits BaseRepository
    Implements IClienteRepository

    Public Sub New(connectionStrings As ConnectionStringSettingsCollection)
        MyBase.New(connectionStrings)
    End Sub

    Public Sub Add(entity As Cliente) Implements IBaseRepository(Of Cliente).Add

    End Sub

    Public Sub Update(entity As Cliente) Implements IBaseRepository(Of Cliente).Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Delete(entity As Cliente) Implements IBaseRepository(Of Cliente).Delete
        Throw New NotImplementedException()
    End Sub

    Public Function GetAll() As IEnumerable(Of Cliente) Implements IBaseRepository(Of Cliente).GetAll
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As Cliente Implements IBaseRepository(Of Cliente).GetById
        Throw New NotImplementedException()
    End Function
End Class
