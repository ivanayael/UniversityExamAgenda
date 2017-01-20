Option Explicit On
Imports Negocio
Public Class frmListadoParciales
    Dim Materia As New clsMateria
    Dim Parcial As New clsParcial
    Dim DS As DataSet 'declara el Dataset
    Dim DV As New DataView 'declara el dataview
    Dim DT As New DataTable 'declara el datatable
    Private Sub frmListadoMaterias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'habilita checksbox en los datatimepicker
        dtpDesde.ShowCheckBox = True
        dtpHasta.ShowCheckBox = True
        'deshabilita los datatimepicker
        dtpDesde.Checked = False
        dtpHasta.Checked = False
        ' llama a la función y la mantiene en un datatable
        Try
            DT = Parcial.Listar.Tables(0)
            DV = DT.DefaultView ' la muestra en un dataview por default
            DGVListado.DataSource = DV ' muestra la informacion en el Datagridview
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
        End Try

        Try
            CargarMaterias()
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la lista de Materias. No se pueden hacer altas, bajas ni modificaciones", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub
    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Try
            Dim MyDataSet As New dsAgenda 'Conjunto de datos
            Dim MyDataTable As New dsAgenda.dtParcialDataTable 'EL dataTable del conjunto de datos
            Dim ReporteCrystal As New Interfaz.ReporteParciales  'Documento cristal reports
            Dim VisorReporte As New frmReporteParcial 'Formulario visor
            Dim filas As Integer = Me.DGVListado.Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To filas - 1 'Paso los datos al dataset
                MyDataTable.Rows.Add(Me.DGVListado.Rows(i).Cells(0).Value, Me.DGVListado.Rows(i).Cells(1).Value, Me.DGVListado.Rows(i).Cells(2).Value)
            Next (i)
            MyDataSet.Tables("dtParcial").Merge(MyDataTable) 'genero la tabla
            ReporteCrystal.SetDataSource(MyDataSet) 'lo adjunto al datasource
            VisorReporte.CrystalReportViewer1.ReportSource = ReporteCrystal 'establesco la fuente del reporte
            VisorReporte.Show()
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If dtpDesde.Checked = True And dtpHasta.Checked = True And Me.cboMateria.SelectedIndex = -1 And Me.txtContenido.Text = "" Then ' si ambos están habilitados con el check, busca entre las dos fechas
                DV.RowFilter = "Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboMateria.SelectedIndex <> -1 And dtpDesde.Checked = False And dtpHasta.Checked = False And Me.txtContenido.Text = "" Then
                DV.RowFilter = "Materia ='" & cboMateria.Text & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = True And dtpHasta.Checked = True And Me.cboMateria.SelectedIndex <> -1 And Me.txtContenido.Text = "" Then
                DV.RowFilter = "Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "' and Materia ='" & cboMateria.Text & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = False And dtpHasta.Checked = False And Me.cboMateria.SelectedIndex = -1 And Me.txtContenido.Text <> "" Then
                DV.RowFilter = "Contenido Like '%" & txtContenido.Text & "%'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = True And dtpHasta.Checked = True And Me.cboMateria.SelectedIndex = -1 And Me.txtContenido.Text <> "" Then
                DV.RowFilter = "Contenido Like '%" & txtContenido.Text & "%' and Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = True And dtpHasta.Checked = True And Me.cboMateria.SelectedIndex <> -1 And Me.txtContenido.Text <> "" Then
                DV.RowFilter = "Contenido Like '%" & txtContenido.Text & "%' and Materia ='" & cboMateria.Text & "' AND Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = False And dtpHasta.Checked = False And Me.cboMateria.SelectedIndex <> -1 And Me.txtContenido.Text <> "" Then
                DV.RowFilter = "Contenido Like '%" & txtContenido.Text & "%' and Materia ='" & cboMateria.Text & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = False And dtpHasta.Checked = False And Me.txtContenido.Text = "" Then
                MsgBox("no se filtró nada, se mostrarán todos los datos", MsgBoxStyle.Exclamation, "Error")
                Try
                    DT = Parcial.Listar.Tables(0)
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
        Me.txtContenido.Clear()
        Me.dtpDesde.Checked = False
        Me.dtpHasta.Checked = False
        Me.cboMateria.SelectedIndex = -1
        Try
            DT = Parcial.Listar.Tables(0)
            DV = DT.DefaultView
            DGVListado.DataSource = DV
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
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