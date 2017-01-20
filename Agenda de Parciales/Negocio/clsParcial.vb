Public Class clsParcial
    Private _ID_Parcial As Integer
    Private _Contenido As String
    Private _Fecha As String
    Private _Materia As String
    Public Property ID_Parcial() As Integer
        Get
            Return _ID_Parcial
        End Get
        Set(ByVal value As Integer)
            _ID_Parcial = value
        End Set
    End Property
    Public Property Contenido() As String
        Get
            Return _Contenido
        End Get
        Set(ByVal value As String)
            _Contenido = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Public Property ID_Materia() As Integer
        Get
            Return _Materia
        End Get
        Set(ByVal value As Integer)
            _Materia = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal ID_Parcial As Integer, ByVal Contenido As String, ByVal Fecha As String, ByVal ID_Materia As Integer)
        Me.ID_Parcial = ID_Parcial
        Me.Contenido = Contenido
        Me.Fecha = Fecha
        Me.ID_Materia = ID_Materia
    End Sub
    Public Sub Alta(ByVal Contenido As String, ByVal Fecha As String, ByVal ID_Materia As Integer)
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Insert into parcial (contenido, fecha, id_materia) values ('" & Contenido & "','" & Fecha & "'," & ID_Materia & ")"
        DS = Datos.EjecutarConsultaDS(Consulta)
    End Sub
    Public Function Baja(ByVal ID_Parcial As Integer) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "delete from parcial where id_parcial =" & ID_Parcial & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Modificacion(ByVal ID_Parcial As Integer, ByVal Contenido As String, ByVal Fecha As String, ByVal ID_Materia As Integer) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "update parcial set contenido='" & Contenido & "', fecha='" & Fecha & "', id_materia='" & ID_Materia & "' where id_parcial =" & ID_Parcial & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Buscar(ByVal Contenido As String) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select * from parcial where contenido like '" & Contenido & "%'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Listar() As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "SELECT parcial.contenido as Contenido, Format(parcial.fecha, '" & "ddddd" & "') as Fecha, materia.materia as Materia FROM (materia INNER JOIN parcial ON materia.id_materia = parcial.id_materia)"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function CargarParciales() As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select id_parcial, contenido from parcial"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class
