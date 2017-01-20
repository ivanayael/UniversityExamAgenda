<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterias
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
        Me.lblCampo4 = New System.Windows.Forms.Label
        Me.lblCampo3 = New System.Windows.Forms.Label
        Me.lblCampo2 = New System.Windows.Forms.Label
        Me.lblCampo1 = New System.Windows.Forms.Label
        Me.txtMateria = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtProfesor = New System.Windows.Forms.TextBox
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnBaja = New System.Windows.Forms.Button
        Me.btnModificacion = New System.Windows.Forms.Button
        Me.btnAlta = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCampo4
        '
        Me.lblCampo4.AutoSize = True
        Me.lblCampo4.Location = New System.Drawing.Point(42, 136)
        Me.lblCampo4.Name = "lblCampo4"
        Me.lblCampo4.Size = New System.Drawing.Size(26, 13)
        Me.lblCampo4.TabIndex = 10
        Me.lblCampo4.Text = "&Mail"
        '
        'lblCampo3
        '
        Me.lblCampo3.AutoSize = True
        Me.lblCampo3.Location = New System.Drawing.Point(42, 110)
        Me.lblCampo3.Name = "lblCampo3"
        Me.lblCampo3.Size = New System.Drawing.Size(46, 13)
        Me.lblCampo3.TabIndex = 9
        Me.lblCampo3.Text = "&Profesor"
        '
        'lblCampo2
        '
        Me.lblCampo2.AutoSize = True
        Me.lblCampo2.Location = New System.Drawing.Point(4, 25)
        Me.lblCampo2.Name = "lblCampo2"
        Me.lblCampo2.Size = New System.Drawing.Size(42, 13)
        Me.lblCampo2.TabIndex = 2
        Me.lblCampo2.Text = "&Materia"
        '
        'lblCampo1
        '
        Me.lblCampo1.AutoSize = True
        Me.lblCampo1.Location = New System.Drawing.Point(42, 20)
        Me.lblCampo1.Name = "lblCampo1"
        Me.lblCampo1.Size = New System.Drawing.Size(18, 13)
        Me.lblCampo1.TabIndex = 0
        Me.lblCampo1.Text = "&ID"
        '
        'txtMateria
        '
        Me.txtMateria.Location = New System.Drawing.Point(54, 22)
        Me.txtMateria.Name = "txtMateria"
        Me.txtMateria.Size = New System.Drawing.Size(257, 20)
        Me.txtMateria.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(92, 17)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(50, 20)
        Me.txtID.TabIndex = 1
        '
        'txtProfesor
        '
        Me.txtProfesor.Location = New System.Drawing.Point(92, 107)
        Me.txtProfesor.Name = "txtProfesor"
        Me.txtProfesor.Size = New System.Drawing.Size(257, 20)
        Me.txtProfesor.TabIndex = 3
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(92, 133)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(257, 20)
        Me.txtMail.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCampo2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtMateria)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(322, 12)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(360, 115)
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
        Me.btnBaja.Location = New System.Drawing.Point(306, 161)
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
        Me.btnModificacion.Location = New System.Drawing.Point(201, 161)
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
        Me.btnAlta.Location = New System.Drawing.Point(96, 161)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(99, 39)
        Me.btnAlta.TabIndex = 5
        Me.btnAlta.Text = "&Agregar"
        Me.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'frmMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 216)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtProfesor)
        Me.Controls.Add(Me.lblCampo4)
        Me.Controls.Add(Me.lblCampo3)
        Me.Controls.Add(Me.lblCampo1)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificacion)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMaterias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Materias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCampo4 As System.Windows.Forms.Label
    Friend WithEvents lblCampo3 As System.Windows.Forms.Label
    Friend WithEvents lblCampo2 As System.Windows.Forms.Label
    Friend WithEvents lblCampo1 As System.Windows.Forms.Label
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnModificacion As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtMateria As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
