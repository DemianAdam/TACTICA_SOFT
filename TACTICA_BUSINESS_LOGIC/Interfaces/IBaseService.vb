Public Interface IBaseService(Of T)
    Sub Add(entity As T)
    Sub Update(entity As T)
    Sub Delete(entity As T)
    Function GetById(id As Integer) As T
    Function GetAll() As IEnumerable(Of T)
End Interface
