Imports System.Runtime.CompilerServices
Imports TACTICA_DATA_ACCESS

Friend Module ProductoMapper
    <Extension()>
    Public Function ToModel(producto As ProductoDTO) As Producto
        Dim model As New Producto With {
            .ID = producto.Id,
            .Nombre = producto.Nombre,
            .Precio = producto.Precio,
            .Categoria = producto.Categoria
            }
        Return model
    End Function

    <Extension()>
    Public Function ToDTO(producto As Producto) As ProductoDTO
        Dim dto As New ProductoDTO With {
            .Id = producto.ID,
            .Nombre = producto.Nombre,
            .Precio = If(producto.Precio, 0),
            .Categoria = producto.Categoria
            }
        Return dto
    End Function

    <Extension()>
    Public Function ToDTO(productos As IEnumerable(Of Producto)) As IEnumerable(Of ProductoDTO)
        Return productos.Select(Function(p) p.ToDTO())
    End Function
End Module
