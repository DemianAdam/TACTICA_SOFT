
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Connection
    Private ReadOnly _connectionString As String
    Private _idbConnection As IDbConnection

    Public Sub New(connectionStrings As ConnectionStringSettingsCollection)
        _connectionString = connectionStrings("DefaultConnection").ConnectionString
    End Sub

    Public Function CreateConnection() As IDbConnection
        _idbConnection = New SqlConnection(_connectionString)
        If _idbConnection.State <> ConnectionState.Open Then
            _idbConnection.Open()
        End If
        Return _idbConnection
    End Function

End Class
