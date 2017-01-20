<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDIPrincipal))
        Me.BarraMenu = New System.Windows.Forms.MenuStrip
        Me.MateriaTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.ABM_Materia = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoYReporte_Materia = New System.Windows.Forms.ToolStripMenuItem
        Me.ParcialTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.ABM_Parcial = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoYReporte_Parcial = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.ABM_Notas = New System.Windows.Forms.ToolStripMenuItem
        Me.Listado_Promedio_Notas = New System.Windows.Forms.ToolStripMenuItem
        Me.VerTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraDeHerramientasTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraDeEstadoTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.VentanaTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.CascadaTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.MosaicoVerticalTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.MosaicoHorizontalTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarTodoTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.ContenidoTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AcercaDeTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraEstado = New System.Windows.Forms.StatusStrip
        Me.TTSLFecha = New System.Windows.Forms.ToolStripStatusLabel
        Me.TTSLHora = New System.Windows.Forms.ToolStripStatusLabel
        Me.Fecha_Hora_Actual = New System.Windows.Forms.Timer(Me.components)
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip
        Me.TSB_Materia = New System.Windows.Forms.ToolStripButton
        Me.TSB_Parcial = New System.Windows.Forms.ToolStripButton
        Me.TSB_Notas = New System.Windows.Forms.ToolStripButton
        Me.TSSeparador = New System.Windows.Forms.ToolStripSeparator
        Me.TSB_Lista_Materias = New System.Windows.Forms.ToolStripButton
        Me.TSB_Lista_Parcial = New System.Windows.Forms.ToolStripButton
        Me.TSB_Lista_Notas = New System.Windows.Forms.ToolStripButton
        Me.BarraMenu.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.BarraHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MateriaTSMI, Me.ParcialTSMI, Me.NotasTSMI, Me.VerTSMI, Me.VentanaTSMI, Me.AyudaTSMI})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(865, 24)
        Me.BarraMenu.TabIndex = 0
        Me.BarraMenu.Text = "Menú"
        '
        'MateriaTSMI
        '
        Me.MateriaTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABM_Materia, Me.ListadoYReporte_Materia})
        Me.MateriaTSMI.Name = "MateriaTSMI"
        Me.MateriaTSMI.Size = New System.Drawing.Size(64, 20)
        Me.MateriaTSMI.Text = "&Materias"
        '
        'ABM_Materia
        '
        Me.ABM_Materia.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.ABM_Materia.Name = "ABM_Materia"
        Me.ABM_Materia.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ABM_Materia.Size = New System.Drawing.Size(206, 22)
        Me.ABM_Materia.Text = "ABM y Consulta"
        '
        'ListadoYReporte_Materia
        '
        Me.ListadoYReporte_Materia.Image = Global.Interfaz.My.Resources.Resources.reporte
        Me.ListadoYReporte_Materia.Name = "ListadoYReporte_Materia"
        Me.ListadoYReporte_Materia.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ListadoYReporte_Materia.Size = New System.Drawing.Size(206, 22)
        Me.ListadoYReporte_Materia.Text = "Listado y Reporte"
        '
        'ParcialTSMI
        '
        Me.ParcialTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABM_Parcial, Me.ListadoYReporte_Parcial})
        Me.ParcialTSMI.Name = "ParcialTSMI"
        Me.ParcialTSMI.Size = New System.Drawing.Size(65, 20)
        Me.ParcialTSMI.Text = "&Parciales"
        '
        'ABM_Parcial
        '
        Me.ABM_Parcial.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.ABM_Parcial.Name = "ABM_Parcial"
        Me.ABM_Parcial.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ABM_Parcial.Size = New System.Drawing.Size(206, 22)
        Me.ABM_Parcial.Text = "ABM y Consulta"
        '
        'ListadoYReporte_Parcial
        '
        Me.ListadoYReporte_Parcial.Image = Global.Interfaz.My.Resources.Resources.reporte
        Me.ListadoYReporte_Parcial.Name = "ListadoYReporte_Parcial"
        Me.ListadoYReporte_Parcial.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ListadoYReporte_Parcial.Size = New System.Drawing.Size(206, 22)
        Me.ListadoYReporte_Parcial.Text = "Listado y Reporte"
        '
        'NotasTSMI
        '
        Me.NotasTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABM_Notas, Me.Listado_Promedio_Notas})
        Me.NotasTSMI.Name = "NotasTSMI"
        Me.NotasTSMI.Size = New System.Drawing.Size(50, 20)
        Me.NotasTSMI.Text = "&Notas"
        '
        'ABM_Notas
        '
        Me.ABM_Notas.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.ABM_Notas.Name = "ABM_Notas"
        Me.ABM_Notas.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ABM_Notas.Size = New System.Drawing.Size(218, 22)
        Me.ABM_Notas.Text = "ABM y Consulta"
        '
        'Listado_Promedio_Notas
        '
        Me.Listado_Promedio_Notas.Image = Global.Interfaz.My.Resources.Resources.reporte
        Me.Listado_Promedio_Notas.Name = "Listado_Promedio_Notas"
        Me.Listado_Promedio_Notas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.Listado_Promedio_Notas.Size = New System.Drawing.Size(218, 22)
        Me.Listado_Promedio_Notas.Text = "Listado y Promedio"
        '
        'VerTSMI
        '
        Me.VerTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarraDeHerramientasTSMI, Me.BarraDeEstadoTSMI})
        Me.VerTSMI.Name = "VerTSMI"
        Me.VerTSMI.Size = New System.Drawing.Size(36, 20)
        Me.VerTSMI.Text = "&Ver"
        '
        'BarraDeHerramientasTSMI
        '
        Me.BarraDeHerramientasTSMI.Checked = True
        Me.BarraDeHerramientasTSMI.CheckOnClick = True
        Me.BarraDeHerramientasTSMI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarraDeHerramientasTSMI.Name = "BarraDeHerramientasTSMI"
        Me.BarraDeHerramientasTSMI.Size = New System.Drawing.Size(191, 22)
        Me.BarraDeHerramientasTSMI.Text = "&Barra de Herramientas"
        '
        'BarraDeEstadoTSMI
        '
        Me.BarraDeEstadoTSMI.Checked = True
        Me.BarraDeEstadoTSMI.CheckOnClick = True
        Me.BarraDeEstadoTSMI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarraDeEstadoTSMI.Name = "BarraDeEstadoTSMI"
        Me.BarraDeEstadoTSMI.Size = New System.Drawing.Size(191, 22)
        Me.BarraDeEstadoTSMI.Text = "Ba&rra de Estado"
        '
        'VentanaTSMI
        '
        Me.VentanaTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaTSMI, Me.MosaicoVerticalTSMI, Me.MosaicoHorizontalTSMI, Me.CerrarTodoTSMI})
        Me.VentanaTSMI.Name = "VentanaTSMI"
        Me.VentanaTSMI.Size = New System.Drawing.Size(62, 20)
        Me.VentanaTSMI.Text = "&Ventana"
        '
        'CascadaTSMI
        '
        Me.CascadaTSMI.Name = "CascadaTSMI"
        Me.CascadaTSMI.Size = New System.Drawing.Size(175, 22)
        Me.CascadaTSMI.Text = "C&ascada"
        '
        'MosaicoVerticalTSMI
        '
        Me.MosaicoVerticalTSMI.Name = "MosaicoVerticalTSMI"
        Me.MosaicoVerticalTSMI.Size = New System.Drawing.Size(175, 22)
        Me.MosaicoVerticalTSMI.Text = "Mosaico &vertical"
        '
        'MosaicoHorizontalTSMI
        '
        Me.MosaicoHorizontalTSMI.Name = "MosaicoHorizontalTSMI"
        Me.MosaicoHorizontalTSMI.Size = New System.Drawing.Size(175, 22)
        Me.MosaicoHorizontalTSMI.Text = "Mosaico &horizontal"
        '
        'CerrarTodoTSMI
        '
        Me.CerrarTodoTSMI.Name = "CerrarTodoTSMI"
        Me.CerrarTodoTSMI.Size = New System.Drawing.Size(175, 22)
        Me.CerrarTodoTSMI.Text = "Cerrar &todo"
        '
        'AyudaTSMI
        '
        Me.AyudaTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContenidoTSMI, Me.ToolStripSeparator2, Me.AcercaDeTSMI})
        Me.AyudaTSMI.Name = "AyudaTSMI"
        Me.AyudaTSMI.Size = New System.Drawing.Size(53, 20)
        Me.AyudaTSMI.Text = "&Ayuda"
        '
        'ContenidoTSMI
        '
        Me.ContenidoTSMI.Name = "ContenidoTSMI"
        Me.ContenidoTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContenidoTSMI.Size = New System.Drawing.Size(176, 22)
        Me.ContenidoTSMI.Text = "Co&ntenido"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(173, 6)
        '
        'AcercaDeTSMI
        '
        Me.AcercaDeTSMI.Name = "AcercaDeTSMI"
        Me.AcercaDeTSMI.Size = New System.Drawing.Size(176, 22)
        Me.AcercaDeTSMI.Text = "Ac&erca De"
        '
        'BarraEstado
        '
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTSLFecha, Me.TTSLHora})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 588)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(865, 22)
        Me.BarraEstado.TabIndex = 2
        Me.BarraEstado.Text = "Estado"
        '
        'TTSLFecha
        '
        Me.TTSLFecha.Name = "TTSLFecha"
        Me.TTSLFecha.Size = New System.Drawing.Size(41, 17)
        Me.TTSLFecha.Text = "Fecha:"
        '
        'TTSLHora
        '
        Me.TTSLHora.Name = "TTSLHora"
        Me.TTSLHora.Size = New System.Drawing.Size(36, 17)
        Me.TTSLHora.Text = "Hora:"
        '
        'Fecha_Hora_Actual
        '
        Me.Fecha_Hora_Actual.Enabled = True
        Me.Fecha_Hora_Actual.Interval = 1000
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_Materia, Me.TSB_Parcial, Me.TSB_Notas, Me.TSSeparador, Me.TSB_Lista_Materias, Me.TSB_Lista_Parcial, Me.TSB_Lista_Notas})
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 24)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(865, 25)
        Me.BarraHerramientas.TabIndex = 1
        Me.BarraHerramientas.Text = "ToolStrip1"
        '
        'TSB_Materia
        '
        Me.TSB_Materia.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.TSB_Materia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Materia.Name = "TSB_Materia"
        Me.TSB_Materia.Size = New System.Drawing.Size(67, 22)
        Me.TSB_Materia.Text = "Materia"
        '
        'TSB_Parcial
        '
        Me.TSB_Parcial.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.TSB_Parcial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Parcial.Name = "TSB_Parcial"
        Me.TSB_Parcial.Size = New System.Drawing.Size(62, 22)
        Me.TSB_Parcial.Text = "Parcial"
        '
        'TSB_Notas
        '
        Me.TSB_Notas.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.TSB_Notas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Notas.Name = "TSB_Notas"
        Me.TSB_Notas.Size = New System.Drawing.Size(58, 22)
        Me.TSB_Notas.Text = "Notas"
        '
        'TSSeparador
        '
        Me.TSSeparador.Name = "TSSeparador"
        Me.TSSeparador.Size = New System.Drawing.Size(6, 25)
        '
        'TSB_Lista_Materias
        '
        Me.TSB_Lista_Materias.Image = Global.Interfaz.My.Resources.Resources.reporte
        Me.TSB_Lista_Materias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Lista_Materias.Name = "TSB_Lista_Materias"
        Me.TSB_Lista_Materias.Size = New System.Drawing.Size(67, 22)
        Me.TSB_Lista_Materias.Text = "Materia"
        '
        'TSB_Lista_Parcial
        '
        Me.TSB_Lista_Parcial.Image = Global.Interfaz.My.Resources.Resources.reporte
        Me.TSB_Lista_Parcial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Lista_Parcial.Name = "TSB_Lista_Parcial"
        Me.TSB_Lista_Parcial.Size = New System.Drawing.Size(62, 22)
        Me.TSB_Lista_Parcial.Text = "Parcial"
        '
        'TSB_Lista_Notas
        '
        Me.TSB_Lista_Notas.Image = Global.Interfaz.My.Resources.Resources.reporte
        Me.TSB_Lista_Notas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Lista_Notas.Name = "TSB_Lista_Notas"
        Me.TSB_Lista_Notas.Size = New System.Drawing.Size(53, 22)
        Me.TSB_Lista_Notas.Text = "Nota"
        '
        'frmMDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources.FacuAgenda1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(865, 610)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.BarraMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.BarraMenu
        Me.Name = "frmMDIPrincipal"
        Me.Text = "Facu Agenda v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MateriaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABM_Materia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoYReporte_Materia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParcialTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABM_Parcial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoYReporte_Parcial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TTSLFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TTSLHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Fecha_Hora_Actual As System.Windows.Forms.Timer
    Friend WithEvents NotasTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABM_Notas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Listado_Promedio_Notas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_Materia As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_Parcial As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_Notas As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSB_Lista_Materias As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_Lista_Parcial As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_Lista_Notas As System.Windows.Forms.ToolStripButton
    Friend WithEvents VentanaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MosaicoVerticalTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MosaicoHorizontalTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarTodoTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContenidoTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercaDeTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraDeHerramientasTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraDeEstadoTSMI As System.Windows.Forms.ToolStripMenuItem

End Class
