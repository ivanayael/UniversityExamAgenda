Option Explicit On
Imports Negocio
Public Class frmListadoNotas
    Dim Nota As New clsNota
    Dim Materia As New clsMateria
    Dim DS As DataSet 'declara el Dataset
    Dim DV As New DataView 'declara el dataview
    Dim DT As New DataTable 'declara el datatable
    Private Sub frmListadoNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DT = Nota.Listar.Tables(0)
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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            If Me.cboMateria.SelectedIndex <> -1 And Me.txtParcial.Text = "" Then  ' si el texto de buscaque de la bitacora tiene algo
                DV.RowFilter = "Materia ='" & cboMateria.Text & "'"  'busca según la descripcion de la bitácora
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboMateria.SelectedIndex = -1 And Me.txtParcial.Text <> "" Then
                DV.RowFilter = "Contenido Like '%" & txtParcial.Text & "%'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboMateria.SelectedIndex <> -1 And Me.txtParcial.Text <> "" Then
                DV.RowFilter = "Contenido Like '%" & txtParcial.Text & "%' and Materia ='" & cboMateria.Text & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboMateria.SelectedIndex = -1 And Me.txtParcial.Text = "" Then
                MsgBox("no se filtró nada, se mostrarán todos los datos", MsgBoxStyle.Exclamation, "Error")
                Try
                    DT = Nota.Listar.Tables(0)
                    DV = DT.DefaultView ' la muestra en un dataview por default
                    DGVListado.DataSource = DV ' muestra la informacion en el Datagridview
                    Me.DGVListado.Refresh()
                Catch ex As Exception
                    MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
                End Try
            End If
        Catch ex As Exception ' en caso de error, muestra una excepción
            MsgBox("No se encuentra coincidencia de búsqueda", MsgBoxStyle.Exclamation, "Error de búsqueda")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtParcial.Clear()
        Me.cboMateria.SelectedIndex = -1
        Try
            DT = Nota.Listar.Tables(0)
            DV = DT.DefaultView
            DGVListado.DataSource = DV
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla.", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnPromedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromedio.Click
        If Me.cboMateria.SelectedIndex <> -1 Then
            Try
                Dim Promedio As Decimal
                Dim DSProm As DataSet = Materia.Calcular_Promedio_Materia(Me.cboMateria.Text)
                Dim row As DataRow = DSProm.Tables(0).Rows(0)
                Promedio = CDec(row.Item(0))
                MsgBox("EL <<Promedio>> para la Materia '" & Me.cboMateria.Text & "' es de '" & Promedio & "'", MsgBoxStyle.Information, "Promedio para '" & Me.cboMateria.Text & "'")
            Catch ex As Exception
                MsgBox("No se puede calcular el promedio, no hay datos de notas", MsgBoxStyle.Exclamation, "Atención")
            End Try
        Else : MsgBox("No se filtró nada", MsgBoxStyle.Information, "Error de Filtrado")
            Exit Sub
        End If
    End Sub
    Private Sub CargarMaterias()
        Dim DS As DataSet
        DS = Materia.CargarMaterias()
        Me.cboMateria.DataSource = DS.Tables(0)
        Me.cboMateria.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        Me.cboMateria.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
        Me.cboMateria.SelectedIndex = -1
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Try
            Dim MyDataSet As New dsAgenda 'Conjunto de datos
            Dim MyDataTable As New dsAgenda.dtNotaDataTable 'EL dataTable del conjunto de datos
            Dim ReporteCrystal As New Interfaz.ReporteNotas  'Documento cristal reports
            Dim VisorReporte As New frmReporteNota 'Formulario visor
            Dim filas As Integer = Me.DGVListado.Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To filas - 1 'Paso los datos al dataset
                MyDataTable.Rows.Add(Me.DGVListado.Rows(i).Cells(0).Value, Me.DGVListado.Rows(i).Cells(1).Value, Me.DGVListado.Rows(i).Cells(2).Value)
            Next (i)
            MyDataSet.Tables("dtNota").Merge(MyDataTable) 'genero la tabla
            ReporteCrystal.SetDataSource(MyDataSet) 'lo adjunto al datasource
            VisorReporte.CRVNota.ReportSource = ReporteCrystal 'establesco la fuente del reporte
            VisorReporte.Show()
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

End Class