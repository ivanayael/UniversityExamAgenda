<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParciales
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
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtContenido = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox
        Me.cboMateria = New System.Windows.Forms.ComboBox
        Me.lblCampo1 = New System.Windows.Forms.Label
        Me.lblCampo2 = New System.Windows.Forms.Label
        Me.lblCampo3 = New System.Windows.Forms.Label
        Me.lblCampo4 = New System.Windows.Forms.Label
        Me.lblDiasFaltantes = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnBaja = New System.Windows.Forms.Button
        Me.btnModificacion = New System.Windows.Forms.Button
        Me.btnAlta = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(101, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(50, 20)
        Me.txtID.TabIndex = 1
        '
        'txtContenido
        '
        Me.txtContenido.Location = New System.Drawing.Point(64, 22)
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(257, 20)
        Me.txtContenido.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(101, 105)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(64, 20)
        Me.txtFecha.TabIndex = 3
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'cboMateria
        '
        Me.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateria.FormattingEnabled = True
        Me.cboMateria.Location = New System.Drawing.Point(101, 131)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Size = New System.Drawing.Size(257, 21)
        Me.cboMateria.TabIndex = 4
        '
        'lblCampo1
        '
        Me.lblCampo1.AutoSize = True
        Me.lblCampo1.Location = New System.Drawing.Point(41, 22)
        Me.lblCampo1.Name = "lblCampo1"
        Me.lblCampo1.Size = New System.Drawing.Size(18, 13)
        Me.lblCampo1.TabIndex = 0
        Me.lblCampo1.Text = "&ID"
        '
        'lblCampo2
        '
        Me.lblCampo2.AutoSize = True
        Me.lblCampo2.Location = New System.Drawing.Point(4, 25)
        Me.lblCampo2.Name = "lblCampo2"
        Me.lblCampo2.Size = New System.Drawing.Size(55, 13)
        Me.lblCampo2.TabIndex = 2
        Me.lblCampo2.Text = "Contenido"
        '
        'lblCampo3
        '
        Me.lblCampo3.AutoSize = True
        Me.lblCampo3.Location = New System.Drawing.Point(41, 108)
        Me.lblCampo3.Name = "lblCampo3"
        Me.lblCampo3.Size = New System.Drawing.Size(37, 13)
        Me.lblCampo3.TabIndex = 10
        Me.lblCampo3.Text = "Fecha"
        '
        'lblCampo4
        '
        Me.lblCampo4.AutoSize = True
        Me.lblCampo4.Location = New System.Drawing.Point(41, 134)
        Me.lblCampo4.Name = "lblCampo4"
        Me.lblCampo4.Size = New System.Drawing.Size(42, 13)
        Me.lblCampo4.TabIndex = 11
        Me.lblCampo4.Text = "Materia"
        '
        'lblDiasFaltantes
        '
        Me.lblDiasFaltantes.AutoSize = True
        Me.lblDiasFaltantes.Location = New System.Drawing.Point(181, 108)
        Me.lblDiasFaltantes.Name = "lblDiasFaltantes"
        Me.lblDiasFaltantes.Size = New System.Drawing.Size(154, 13)
        Me.lblDiasFaltantes.TabIndex = 9
        Me.lblDiasFaltantes.Text = "Faltan XXX Dias para el Parcial"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblCampo2)
        Me.GroupBox1.Controls.Add(Me.txtContenido)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(327, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 39)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Interfaz.My.Resources.Resources.limpiar
        Me.btnLimpiar.Location = New System.Drawing.Point(364, 113)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 39)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Image = Global.Interfaz.My.Resources.Resources.quitar
        Me.btnBaja.Location = New System.Drawing.Point(294, 158)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(99, 39)
        Me.btnBaja.TabIndex = 7
        Me.btnBaja.Text = "&Quitar"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificacion
        '
        Me.btnModificacion.Image = Global.Interfaz.My.Resources.Resources.editar
        Me.btnModificacion.Location = New System.Drawing.Point(189, 158)
        Me.btnModificacion.Name = "btnModificacion"
        Me.btnModificacion.Size = New System.Drawing.Size(99, 39)
        Me.btnModificacion.TabIndex = 6
        Me.btnModificacion.Text = "&Modificar"
        Me.btnModificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificacion.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Image = Global.Interfaz.My.Resources.Resources.agregar
        Me.btnAlta.Location = New System.Drawing.Point(84, 158)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(99, 39)
        Me.btnAlta.TabIndex = 5
        Me.btnAlta.Text = "&Agregar"
        Me.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'frmParciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 216)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificacion)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lblDiasFaltantes)
        Me.Controls.Add(Me.lblCampo4)
        Me.Controls.Add(Me.lblCampo3)
        Me.Controls.Add(Me.lblCampo1)
        Me.Controls.Add(Me.cboMateria)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmParciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Parciales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtContenido As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboMateria As System.Windows.Forms.ComboBox
    Friend WithEvents lblCampo1 As System.Windows.Forms.Label
    Friend WithEvents lblCampo2 As System.Windows.Forms.Label
    Friend WithEvents lblCampo3 As System.Windows.Forms.Label
    Friend WithEvents lblCampo4 As System.Windows.Forms.Label
    Friend WithEvents lblDiasFaltantes As System.Windows.Forms.Label
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnModificacion As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
