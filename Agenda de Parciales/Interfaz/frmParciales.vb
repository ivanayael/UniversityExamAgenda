Option Explicit On
Imports Negocio
Public Class frmParciales
    Dim Parcial As New clsParcial
    Dim Materia As New clsMateria
    Dim Validar As New clsValidar
    Dim Retorno As Boolean
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtContenido.Text <> "" Then
            Try
                Dim DS As New DataSet
                DS = Parcial.Buscar(Me.txtContenido.Text)
                Me.txtID.Text = DS.Tables(0).Rows(0).Item("id_parcial")
                Me.txtContenido.Text = DS.Tables(0).Rows(0).Item("contenido")
                Me.txtFecha.Text = DS.Tables(0).Rows(0).Item("fecha")
                Me.cboMateria.SelectedValue = DS.Tables(0).Rows(0).Item("id_materia")
                Me.btnAlta.Enabled = True
                Me.btnBaja.Enabled = True
                Me.btnModificacion.Enabled = True
                Me.btnBuscar.Enabled = True
                Dias_Faltantes_Examen()
            Catch ex As Exception
                MsgBox("No se encuentra coincidencia de búsqueda", MsgBoxStyle.Exclamation, "Error de búsqueda")
                Me.btnLimpiar.PerformClick()
            End Try
        Else : MsgBox("No se filtró nada", MsgBoxStyle.Information, "Error de Filtro")
        End If
    End Sub
    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        If Validar_Contenido_A() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Parcial.Alta(Me.txtContenido.Text, Me.txtFecha.Text, CInt(Me.cboMateria.SelectedValue))
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificacion.Click
        If Validar_Contenido() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Parcial.Modificacion(Me.txtID.Text, Me.txtContenido.Text, Me.txtFecha.Text, CInt(Me.cboMateria.SelectedValue))
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If Validar_Contenido() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Parcial.Baja(Me.txtID.Text)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub frmParciales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtID.ReadOnly = True
        Me.txtID.Enabled = False
        Me.btnLimpiar.PerformClick()
        Call CargarMaterias()
    End Sub
    Private Sub RefrescarBotones()
        Me.btnAlta.Enabled = True
        Me.btnBaja.Enabled = False
        Me.btnModificacion.Enabled = False
        Me.btnBuscar.Enabled = True
    End Sub
    Private Sub Limpiar()
        Me.txtID.Clear()
        Me.txtContenido.Clear()
        Me.txtFecha.Clear()
        Me.cboMateria.SelectedIndex = -1
        Me.lblDiasFaltantes.Text = "Faltan XXX Dias para el Parcial"
    End Sub

    Private Sub Dias_Faltantes_Examen()
        Try
            Dim fecha As Date = Convert.ToDateTime(Me.txtFecha.Text)
            Dim dias As Integer = (Date.Now - fecha).TotalDays
            Me.lblDiasFaltantes.Text = "Faltan " & dias & " días para el Parcial"
        Catch ex As Exception
            MsgBox("Error en la Fecha del Examen", MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub
    Private Function Validar_Contenido() As Boolean
        If Me.txtID.Text = "" Or Me.txtContenido.Text = "" Or Me.txtFecha.Text = "" Or Me.cboMateria.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function Validar_Contenido_A() As Boolean
        If Me.txtContenido.Text = "" Or Me.txtFecha.Text = "" Or Me.cboMateria.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub txtContenido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContenido.KeyPress
        Retorno = Validar.Alfavetico(e.KeyChar.ToString)
        If Retorno = False Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        Retorno = Validar.Numeros(e.KeyChar.ToString)
        If Retorno = False Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txtFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        Retorno = Validar.Numeros(e.KeyChar.ToString)
        If Retorno = False Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub CargarMaterias()
        Try
            Dim DS As DataSet
            DS = Materia.CargarMaterias()
            Me.cboMateria.DataSource = DS.Tables(0)
            Me.cboMateria.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
            Me.cboMateria.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
            Me.cboMateria.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la lista. No se pueden  hacer altas, bajas ni modificaciones", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Limpiar()
        RefrescarBotones()
    End Sub
End Class