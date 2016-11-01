Public Class E_Cliente
    Private _id_cliente As String
    Private _nombre As String
    Private _apellidos As String
    Private _fecha_nacimiento As String
    Private _sexo As Boolean
    Private _pais As String
    Private _ciudad As String
    Private _mail As String
    Private _fecha_registro As String
    Private _estado As String

#Region "Propiedades"
    Public Property id_cliente As String
        Get
            Return _id_cliente
        End Get
        Set(value As String)
            _id_cliente = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
#End Region
    Public Property apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property
    Public Property fecha_nacimiento As String
        Get
            Return _fecha_nacimiento
        End Get
        Set(value As String)
            _fecha_nacimiento = value
        End Set
    End Property
    Public Property sexo As Boolean
        Get
            Return _sexo
        End Get
        Set(value As Boolean)
            _sexo = value
        End Set
    End Property
    Public Property pais As String
        Get
            Return _pais
        End Get
        Set(value As String)
            _pais = value
        End Set
    End Property
    Public Property ciudad As String
        Get
            Return _ciudad
        End Get
        Set(value As String)
            _ciudad = value
        End Set
    End Property
    Public Property mail As String
        Get
            Return _mail
        End Get
        Set(value As String)
            _mail = value
        End Set
    End Property
    Public Property fecha_registro As String
        Get
            Return _fecha_registro
        End Get
        Set(value As String)
            _fecha_registro = value
        End Set
    End Property
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
End Class
