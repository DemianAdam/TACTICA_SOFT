﻿Public Class InvalidClienteException
    Inherits Exception
    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class
