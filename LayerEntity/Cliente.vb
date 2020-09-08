Public Class Cliente
#Region "CAMPOS"
    Private _IdEmpleado As Integer
    Private _NameEmp As String
    Private _Postion As String
    Private _Office As String
    Private _edad As Integer
    Private _Salario As Integer



#End Region

#Region "Propiedades"
    Public Property IdEmpleado As Integer
        Get
            Return _IdEmpleado
        End Get
        Set(value As Integer)
            _IdEmpleado = value
        End Set
    End Property

    Public Property NameEmp As String
        Get
            Return _NameEmp
        End Get
        Set(value As String)
            _NameEmp = value
        End Set
    End Property

    Public Property Postion As String
        Get
            Return _Postion
        End Get
        Set(value As String)
            _Postion = value
        End Set
    End Property

    Public Property Office As String
        Get
            Return _Office
        End Get
        Set(value As String)
            _Office = value
        End Set
    End Property

    Public Property Edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    Public Property Salario As Integer
        Get
            Return _Salario
        End Get
        Set(value As Integer)
            _Salario = value
        End Set
    End Property



#End Region
    Public Sub New()

    End Sub
    Public Sub New(ByVal IdEmpleadoN As Integer, ByVal NameEmp As String, ByVal Postion As String, ByVal OficinaN As String, ByVal EdadN As Integer, ByVal SalarioN As Integer)
        _IdEmpleado = IdEmpleadoN
        _NameEmp = NameEmp
        _Postion = Postion
        _Office = OficinaN
        _edad = EdadN
        _Salario = SalarioN
    End Sub




End Class
