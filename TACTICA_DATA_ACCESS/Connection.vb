Option Strict On
Option Explicit On
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Connection
    Implements IDisposable
    Private ReadOnly _connectionString As String
    Private _idbConnection As IDbConnection

    Public Sub New(connectionStrings As ConnectionStringSettingsCollection)
        _connectionString = connectionStrings("DefaultConnection").ConnectionString
    End Sub

    Public Function CreateConnection() As Connection
        If _idbConnection Is Nothing Then
            _idbConnection = New SqlConnection(_connectionString)
        End If
        If _idbConnection.State <> ConnectionState.Open Then
            _idbConnection.Open()
        End If
        Return Me
    End Function

    Public Function CreateCommand() As IDbCommand
        Return _idbConnection.CreateCommand()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        If _idbConnection IsNot Nothing Then
            If _idbConnection.State <> ConnectionState.Closed Then
                _idbConnection.Close()
            End If
            _idbConnection.Dispose()
            _idbConnection = Nothing
        End If
    End Sub

End Class
