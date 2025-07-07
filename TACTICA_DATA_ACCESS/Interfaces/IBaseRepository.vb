
Public Interface IBaseRepository(Of T)
    Function GetAll() As IEnumerable(Of T)
    Function GetById(id As Integer) As T
    Function Add(entity As T) As Integer
    Sub Update(entity As T)
    Sub Delete(entity As T)
End Interface
