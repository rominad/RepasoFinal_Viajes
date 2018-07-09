Public MustInherit Class Servicio
    'mustinherit class (son clases que heredan, no debo instanciar)
    Inherits Paquete
    'campo
    Private _descripcion As String
    'propiedad
    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
    'metodos
    Public Overrides Function ToString() As String
        Return "Servicio: " + Descripcion
    End Function
    'constructores
    Sub New(descripcion As String)
        Me.Descripcion = descripcion
    End Sub
End Class
