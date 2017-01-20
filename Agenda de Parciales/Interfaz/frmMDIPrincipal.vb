Option Explicit On
Imports System.Windows.Forms
Imports System.IO
Public Class frmMDIPrincipal

#Region "---------------Lista del Menu----------------"

#Region ">>>>>>>>>>>>>>>ABM y Consulta<<<<<<<<<<<<<<<<"
    Private Sub ABM_Materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABM_Materia.Click
        Materias()
    End Sub
    Private Sub ABM_Parcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABM_Parcial.Click
        Parciales()
    End Sub
    Private Sub ABM_Notas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABM_Notas.Click
        Notas()
    End Sub
#End Region

#Region ">>>>>>>>>>>>>>>Listados y Reportes<<<<<<<<<<<<<<<<"
    Private Sub ListadoYReporte_Materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoYReporte_Materia.Click
        Lista_Materias()
    End Sub
    Private Sub ListadoYReporte_Parcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoYReporte_Parcial.Click
        Lista_Parciales()
    End Sub
    Private Sub Listado_Promedio_Notas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Listado_Promedio_Notas.Click
        Lista_Notas()
    End Sub
#End Region

#End Region

#Region "---------------Lista del Herramientas----------------"

#Region ">>>>>>>>>>>>>>>ABM y Consulta<<<<<<<<<<<<<<<<"
    Private Sub TSB_Materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_Materia.Click
        Materias()
    End Sub
    Private Sub TSB_Parcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_Parcial.Click
        Parciales()
    End Sub
    Private Sub TSB_Notas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_Notas.Click
        Notas()
    End Sub
#End Region

#Region ">>>>>>>>>>>>>>>Listados y Reportes<<<<<<<<<<<<<<<<"
    Private Sub TSB_Lista_Materias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_Lista_Materias.Click
        Lista_Materias()
    End Sub
    Private Sub TSB_Lista_Parcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_Lista_Parcial.Click
        Lista_Parciales()
    End Sub
    Private Sub TSB_Lista_Notas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_Lista_Notas.Click
        Lista_Notas()
    End Sub
#End Region

#End Region

#Region "--------------Subfunciones----------------"
    Private Sub Materias()
        Dim Materias As New frmMaterias
        Materias.MdiParent = Me
        Materias.Show()
    End Sub
    Private Sub Parciales()
        Dim Parciales As New frmParciales
        Parciales.MdiParent = Me
        Parciales.Show()
    End Sub
    Private Sub Notas()
        Dim Notas As New frmNotas
        Notas.MdiParent = Me
        Notas.Show()
    End Sub
    Private Sub Lista_Materias()
        Dim ListadoMaterias As New frmListadoMaterias
        ListadoMaterias.MdiParent = Me
        ListadoMaterias.Show()
    End Sub
    Private Sub Lista_Parciales()
        Dim ListadoParciales As New frmListadoParciales
        ListadoParciales.MdiParent = Me
        ListadoParciales.Show()
    End Sub
    Private Sub Lista_Notas()
        Dim ListadoNotas As New frmListadoNotas
        ListadoNotas.MdiParent = Me
        ListadoNotas.Show()
    End Sub
#End Region

#Region "--------------Fecha, Hora y Comprobación BD----------------"
    Private Sub Fecha_Hora_Actual_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha_Hora_Actual.Tick
        Me.TTSLFecha.Text = "Fecha Actual: " & FormatDateTime(Date.Now, DateFormat.ShortDate)
        Me.TTSLHora.Text = "Hora Actual: " & FormatDateTime(Date.Now, DateFormat.LongTime)
    End Sub
    Private Sub frmMDIPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "\Agenda.mdb") Then
        Else
            MsgBox("No Se Encuentra la Base de Datos 'Agenda.mdb', se Cerrará la Aplicación", MsgBoxStyle.Critical, "Error - Base de Datos")
            Me.Close()
        End If
    End Sub
#End Region

#Region "--------------Ventana----------------"
    Private Sub CascadaTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadaTSMI.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoVerticalTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MosaicoVerticalTSMI.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MosaicoHorizontalTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MosaicoHorizontalTSMI.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CerrarTodoTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarTodoTSMI.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
#End Region

#Region "--------------Ayuda----------------"
    Private Sub AcercaDeTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeTSMI.Click
        Dim AcercaDe As New frmAcercaDe
        AcercaDe.MdiParent = Me
        AcercaDe.Show()
    End Sub

    Private Sub ContenidoTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContenidoTSMI.Click
        Dim Ayuda As New frmContenido
        Ayuda.MdiParent = Me
        Ayuda.Show()
    End Sub
#End Region

#Region "--------------Ver----------------"
    Private Sub BarraDeHerramientasTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeHerramientasTSMI.Click
        If Me.BarraDeHerramientasTSMI.Checked = True Then
            Me.BarraHerramientas.Visible = True
        Else
            Me.BarraHerramientas.Visible = False
        End If
    End Sub

    Private Sub BarraDeEstadoTSMI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BarraDeEstadoTSMI.Click
        If Me.BarraDeEstadoTSMI.Checked = True Then
            Me.BarraEstado.Visible = True
        Else
            Me.BarraEstado.Visible = False
        End If
    End Sub
#End Region

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim Bienvenida As New Bienvenida
        If Not Bienvenida.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
        Bienvenida.Dispose()
        Application.DoEvents()
    End Sub

End Class
