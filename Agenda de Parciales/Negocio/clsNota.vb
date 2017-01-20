Public Class clsNota
    Private _ID_Nota As Integer
    Private _Nota As Double
    Private _ID_Parcial As Integer

    Public Property ID_Nota() As Integer
        Get
            Return _ID_Nota
        End Get
        Set(ByVal value As Integer)
            _ID_Nota = value
        End Set
    End Property

    Public Property Nota() As Double
        Get
            Return _Nota
        End Get
        Set(ByVal value As Double)
            _Nota = value
        End Set
    End Property

    Public Property Parcial() As Integer
        Get
            Return _ID_Parcial
        End Get
        Set(ByVal value As Integer)
            _ID_Parcial = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal ID_Nota As Integer, ByVal Nota As Double, ByVal Parcial As Integer)
        Me.ID_Nota = ID_Nota
        Me.Nota = Nota
        Me.Parcial = Parcial
    End Sub
    Public Sub Alta(ByVal Nota As Double, ByVal Parcial As Integer)
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Insert into nota (nota, id_parcial) values ('" & Nota & "'," & Parcial & ")"
        DS = Datos.EjecutarConsultaDS(Consulta)
    End Sub

    Public Function Baja(ByVal ID_Nota As Decimal) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Delete from nota where id_nota='" & Nota & "'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Modificacion(ByVal ID_Nota As Integer, ByVal Nota As Double, ByVal Parcial As Integer) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "update nota set nota ='" & Nota & "', id_parcial=" & Parcial & " where id_nota=" & ID_Nota & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Buscar(ByVal Parcial As Integer) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select * from nota where id_parcial=" & Parcial & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Listar() As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "SELECT nota.nota as Nota, parcial.contenido as Contenido, materia.materia as Materia FROM ((parcial INNER JOIN nota ON parcial.id_parcial = nota.id_parcial) INNER JOIN materia ON parcial.id_materia = materia.id_materia)"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class
