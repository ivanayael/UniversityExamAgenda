Public Class clsMateria
    Private _ID_Materia As Integer
    Private _Materia As String
    Private _Profesor As String
    Private _Mail As String

    Public Property ID_Materia() As Integer
        Get
            Return _ID_Materia
        End Get
        Set(ByVal value As Integer)
            _ID_Materia = value
        End Set
    End Property

    Public Property Materia() As String
        Get
            Return _Materia
        End Get
        Set(ByVal value As String)
            _Materia = value
        End Set
    End Property

    Public Property Profesor() As String
        Get
            Return _Profesor
        End Get
        Set(ByVal value As String)
            _Profesor = value
        End Set
    End Property

    Public Property Mail() As String
        Get
            Return _Mail
        End Get
        Set(ByVal value As String)
            _Mail = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID_Materia As Integer, ByVal Materia As String, ByVal Profesor As String, ByVal Mail As String)
        Me.ID_Materia = ID_Materia
        Me.Materia = Materia
        Me.Profesor = Profesor
        Me.Mail = Mail
    End Sub
    Public Sub Alta(ByVal Materia As String, ByVal Profesor As String, ByVal Mail As String)
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Insert into materia (materia, profesor, mail) values ('" & Materia & "','" & Profesor & "','" & Mail & "')"
        DS = Datos.EjecutarConsultaDS(Consulta)
    End Sub

    Public Function Baja(ByVal ID_Materia As Integer) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Delete from materia where id_materia=" & ID_Materia & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Modificacion(ByVal ID_Materia As Integer, ByVal Materia As String, ByVal Profesor As String, ByVal Mail As String) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "update materia set materia ='" & Materia & "', profesor='" & Profesor & "', mail='" & Mail & "' where id_materia=" & ID_Materia & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Buscar(ByVal Materia As String) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select * from materia where materia like '" & Materia & "%'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Listar() As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select materia as Materia, profesor as Profesor, mail as Mail from materia"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function CargarMaterias() As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select id_materia, materia from materia"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Calcular_Promedio_Materia(ByVal Materia As String) As DataSet
        Dim Datos As New Acceso.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "SELECT AVG(nota.nota) AS Promedio FROM ((nota INNER JOIN  parcial ON nota.id_parcial = parcial.id_parcial) INNER JOIN materia ON parcial.id_materia = materia.id_materia) where materia.materia='" & Materia & "'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class
