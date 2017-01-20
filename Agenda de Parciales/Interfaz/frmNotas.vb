Option Explicit On
Imports Negocio
Public Class frmNotas
    Dim Parcial As New clsParcial
    Dim Nota As New clsNota
    Dim Validar As New clsValidar
    Dim Retorno As Boolean
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.cboParcial.SelectedIndex <> -1 Then
            Try
                Dim DS As New DataSet
                DS = Nota.Buscar(Me.cboParcial.SelectedValue)
                Me.txtID.Text = DS.Tables(0).Rows(0).Item("id_nota")
                Me.txtNota.Text = DS.Tables(0).Rows(0).Item("nota")
                Me.cboParcial.SelectedValue = DS.Tables(0).Rows(0).Item("id_parcial")
                Me.btnAlta.Enabled = True
                Me.btnBaja.Enabled = True
                Me.btnModificacion.Enabled = True
                Me.btnBuscar.Enabled = True
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
            Nota.Alta(Me.txtNota.Text, Me.cboParcial.SelectedValue)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificacion.Click
        If Validar_Contenido() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Nota.Modificacion(Me.txtID.Text, Me.txtNota.Text, Me.cboParcial.SelectedValue)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If Validar_Contenido() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Nota.Baja(Me.txtID.Text)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub frmParciales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtID.ReadOnly = True
        Me.txtID.Enabled = False
        Me.btnLimpiar.PerformClick()
        CargarParciales()
    End Sub
    Private Sub RefrescarBotones()
        Me.btnAlta.Enabled = True
        Me.btnBaja.Enabled = False
        Me.btnModificacion.Enabled = False
        Me.btnBuscar.Enabled = True
    End Sub
    Private Sub Limpiar()
        Me.txtID.Clear()
        Me.txtNota.Clear()
        Me.cboParcial.SelectedIndex = -1
    End Sub

    Private Function Validar_Contenido() As Boolean
        If Me.txtID.Text = "" Or Me.txtNota.Text = "" Or Me.cboParcial.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function Validar_Contenido_A() As Boolean
        If Me.txtNota.Text = "" Or Me.cboParcial.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub txtContenido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNota.KeyPress
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
    Private Sub CargarParciales()
        Try
            Dim DS As DataSet
            DS = Parcial.CargarParciales()
            Me.cboParcial.DataSource = DS.Tables(0)
            Me.cboParcial.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
            Me.cboParcial.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
            Me.cboParcial.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la lista. No se pueden  hacer altas, bajas ni modificaciones", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Limpiar()
        RefrescarBotones()
    End Sub
End Class