Option Explicit On
Imports Negocio
Public Class frmListadoMaterias
    Dim Materia As New clsMateria
    Dim DS As DataSet 'declara el Dataset
    Dim DV As New DataView 'declara el dataview
    Dim DT As New DataTable 'declara el datatable
    Private Sub frmListadoMaterias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DT = Materia.Listar.Tables(0) ' llama a la función y la mantiene en un datatable
            DV = DT.DefaultView ' la muestra en un dataview por default
            DGVListado.DataSource = DV ' muestra la informacion en el Datagridview
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
        End Try

        Try
            CargarMaterias()
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la lista de Materias.", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub
    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Try
            Dim MyDataSet As New dsAgenda 'Conjunto de datos
            Dim MyDataTable As New dsAgenda.dtMateriaDataTable 'EL dataTable del conjunto de datos
            Dim ReporteCrystal As New Interfaz.ReporteMaterias  'Documento cristal reports
            Dim VisorReporte As New frmReporteMateria 'Formulario visor
            Dim filas As Integer = Me.DGVListado.Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To filas - 1 'Paso los datos al dataset
                MyDataTable.Rows.Add(Me.DGVListado.Rows(i).Cells(0).Value, Me.DGVListado.Rows(i).Cells(1).Value, Me.DGVListado.Rows(i).Cells(2).Value)
            Next (i)
            MyDataSet.Tables("dtMateria").Merge(MyDataTable) 'genero la tabla
            ReporteCrystal.SetDataSource(MyDataSet) 'lo adjunto al datasource
            VisorReporte.CRVMateria.ReportSource = ReporteCrystal 'establesco la fuente del reporte
            VisorReporte.Show()
        Catch ex As Exception
            MsgBox("No hay datos para cargar en el Reporte", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.txtProfesor.Text <> "" And Me.cboMateria.SelectedIndex = -1 And Me.txtMail.Text = "" Then ' si ambos están habilitados con el check, busca entre las dos fechas
                DV.RowFilter = "Profesor like '%" & Me.txtProfesor.Text & "%'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboMateria.SelectedIndex <> -1 And txtProfesor.Text = "" And Me.txtMail.Text = "" Then  ' si el texto de buscaque de la bitacora tiene algo
                DV.RowFilter = "Materia ='" & cboMateria.Text & "'"  'busca según la descripcion de la bitácora
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.txtProfesor.Text <> "" And Me.cboMateria.SelectedIndex <> -1 And Me.txtMail.Text = "" Then
                DV.RowFilter = "Profesor like '%" & Me.txtProfesor.Text & "%' and Materia ='" & cboMateria.Text & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.txtProfesor.Text = "" And Me.cboMateria.SelectedIndex = -1 And Me.txtMail.Text <> "" Then
                DV.RowFilter = "Mail like '%" & txtMail.Text & "%'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.txtProfesor.Text <> "" And Me.cboMateria.SelectedIndex = -1 And Me.txtMail.Text <> "" Then
                DV.RowFilter = "Mail like '%" & txtMail.Text & "%' and Profesor like '%" & txtProfesor.Text & "%'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.txtProfesor.Text <> "" And Me.cboMateria.SelectedIndex <> -1 And Me.txtMail.Text <> "" Then
                DV.RowFilter = "Mail like '%" & txtMail.Text & "%' and Materia ='" & cboMateria.Text & "' AND Profesor like '%" & Me.txtProfesor.Text & "%'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.txtProfesor.Text = "" And Me.cboMateria.SelectedIndex <> -1 And Me.txtMail.Text <> "" Then
                DV.RowFilter = "Mail like '%" & txtMail.Text & "%' and Materia ='" & cboMateria.Text & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.txtProfesor.Text = "" And Me.cboMateria.SelectedIndex = -1 And Me.txtMail.Text = "" Then
                Try
                    MsgBox("no se filtró nada, se mostrarán todos los datos", MsgBoxStyle.Exclamation, "Error")
                    DT = Materia.Listar().Tables(0)
                    DV = DT.DefaultView ' la muestra en un dataview por default
                    DGVListado.DataSource = DV ' muestra la informacion en el Datagridview
                    Me.DGVListado.Refresh()
                Catch ex As Exception
                    MsgBox("No hay datos para cargar en la lista", MsgBoxStyle.Exclamation, "Atención")
                End Try
            End If
        Catch ex As Exception ' en caso de error, muestra una excepción
            MsgBox("No se encuentra coincidencia de búsqueda", MsgBoxStyle.Exclamation, "Error de búsqueda")
        End Try
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtProfesor.Clear()
        Me.txtMail.Clear()
        Me.cboMateria.SelectedIndex = -1
        Try
            DT = Materia.Listar.Tables(0)
            DV = DT.DefaultView
            DGVListado.DataSource = DV
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la lista", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub
    Private Sub CargarMaterias()
        Dim DS As DataSet
        DS = Materia.CargarMaterias()
        Me.cboMateria.DataSource = DS.Tables(0)
        Me.cboMateria.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        Me.cboMateria.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
        Me.cboMateria.SelectedIndex = -1
    End Sub
End Class