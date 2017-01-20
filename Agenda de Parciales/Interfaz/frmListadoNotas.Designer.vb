<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoNotas
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
        Me.gbFiltro = New System.Windows.Forms.GroupBox
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPromedio = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboMateria = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtParcial = New System.Windows.Forms.TextBox
        Me.DGVListado = New System.Windows.Forms.DataGridView
        Me.btnReporte = New System.Windows.Forms.Button
        Me.gbFiltro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.btnLimpiar)
        Me.gbFiltro.Controls.Add(Me.btnBuscar)
        Me.gbFiltro.Controls.Add(Me.GroupBox1)
        Me.gbFiltro.Controls.Add(Me.Label3)
        Me.gbFiltro.Controls.Add(Me.txtParcial)
        Me.gbFiltro.Location = New System.Drawing.Point(12, 4)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(680, 109)
        Me.gbFiltro.TabIndex = 0
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtros"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Interfaz.My.Resources.Resources.limpiar
        Me.btnLimpiar.Location = New System.Drawing.Point(577, 58)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 39)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(577, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 37)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPromedio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboMateria)
        Me.GroupBox1.Location = New System.Drawing.Point(125, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Promedio"
        '
        'btnPromedio
        '
        Me.btnPromedio.Location = New System.Drawing.Point(302, 19)
        Me.btnPromedio.Name = "btnPromedio"
        Me.btnPromedio.Size = New System.Drawing.Size(75, 23)
        Me.btnPromedio.TabIndex = 2
        Me.btnPromedio.Text = "&Promedio"
        Me.btnPromedio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Materia:"
        '
        'cboMateria
        '
        Me.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateria.FormattingEnabled = True
        Me.cboMateria.Location = New System.Drawing.Point(59, 21)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Size = New System.Drawing.Size(223, 21)
        Me.cboMateria.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Contenido del Parcial:"
        '
        'txtParcial
        '
        Me.txtParcial.Location = New System.Drawing.Point(184, 78)
        Me.txtParcial.Name = "txtParcial"
        Me.txtParcial.Size = New System.Drawing.Size(223, 20)
        Me.txtParcial.TabIndex = 2
        '
        'DGVListado
        '
        Me.DGVListado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.Location = New System.Drawing.Point(12, 119)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(768, 435)
        Me.DGVListado.TabIndex = 2
        '
        'btnReporte
        '
        Me.btnReporte.Image = Global.Interfaz.My.Resources.Resources.reporte
        Me.btnReporte.Location = New System.Drawing.Point(698, 40)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(82, 37)
        Me.btnReporte.TabIndex = 1
        Me.btnReporte.Text = "&Reporte"
        Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'frmListadoNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.gbFiltro)
        Me.Controls.Add(Me.DGVListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmListadoNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Notas"
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtParcial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboMateria As System.Windows.Forms.ComboBox
    Friend WithEvents DGVListado As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPromedio As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnReporte As System.Windows.Forms.Button
End Class
