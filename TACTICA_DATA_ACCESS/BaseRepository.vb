Option Strict On
Option Explicit On
Imports System.Configuration

Public Class BaseRepository
    Private ReadOnly _connectionString As String

    Public Sub New(connectionStrings As ConnectionStringSettingsCollection)
        _connectionString = connectionStrings("DefaultConnection").ConnectionString
    End Sub



End Class
