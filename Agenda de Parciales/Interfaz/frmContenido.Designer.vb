<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContenido
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
        Me.AyudaTP = New System.Windows.Forms.TabControl
        Me.TPMateria = New System.Windows.Forms.TabPage
        Me.lblAyudaMateria = New System.Windows.Forms.Label
        Me.TPParciales = New System.Windows.Forms.TabPage
        Me.lblAyudaParcial = New System.Windows.Forms.Label
        Me.TPNotas = New System.Windows.Forms.TabPage
        Me.lblAyudaNotas = New System.Windows.Forms.Label
        Me.AyudaTP.SuspendLayout()
        Me.TPMateria.SuspendLayout()
        Me.TPParciales.SuspendLayout()
        Me.TPNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'AyudaTP
        '
        Me.AyudaTP.Controls.Add(Me.TPMateria)
        Me.AyudaTP.Controls.Add(Me.TPParciales)
        Me.AyudaTP.Controls.Add(Me.TPNotas)
        Me.AyudaTP.Location = New System.Drawing.Point(13, 11)
        Me.AyudaTP.Name = "AyudaTP"
        Me.AyudaTP.SelectedIndex = 0
        Me.AyudaTP.Size = New System.Drawing.Size(600, 400)
        Me.AyudaTP.TabIndex = 0
        '
        'TPMateria
        '
        Me.TPMateria.Controls.Add(Me.lblAyudaMateria)
        Me.TPMateria.Location = New System.Drawing.Point(4, 22)
        Me.TPMateria.Name = "TPMateria"
        Me.TPMateria.Padding = New System.Windows.Forms.Padding(3)
        Me.TPMateria.Size = New System.Drawing.Size(592, 374)
        Me.TPMateria.TabIndex = 0
        Me.TPMateria.Text = "Ayuda sobre Materias"
        Me.TPMateria.UseVisualStyleBackColor = True
        '
        'lblAyudaMateria
        '
        Me.lblAyudaMateria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAyudaMateria.Location = New System.Drawing.Point(9, 12)
        Me.lblAyudaMateria.Name = "lblAyudaMateria"
        Me.lblAyudaMateria.Size = New System.Drawing.Size(550, 350)
        Me.lblAyudaMateria.TabIndex = 0
        Me.lblAyudaMateria.Text = "Ayuda Sobre Materias"
        '
        'TPParciales
        '
        Me.TPParciales.Controls.Add(Me.lblAyudaParcial)
        Me.TPParciales.Location = New System.Drawing.Point(4, 22)
        Me.TPParciales.Name = "TPParciales"
        Me.TPParciales.Padding = New System.Windows.Forms.Padding(3)
        Me.TPParciales.Size = New System.Drawing.Size(592, 374)
        Me.TPParciales.TabIndex = 1
        Me.TPParciales.Text = "Ayuda sobre Parciales"
        Me.TPParciales.UseVisualStyleBackColor = True
        '
        'lblAyudaParcial
        '
        Me.lblAyudaParcial.ForeColor = System.Drawing.Color.Green
        Me.lblAyudaParcial.Location = New System.Drawing.Point(9, 12)
        Me.lblAyudaParcial.Name = "lblAyudaParcial"
        Me.lblAyudaParcial.Size = New System.Drawing.Size(550, 350)
        Me.lblAyudaParcial.TabIndex = 0
        Me.lblAyudaParcial.Text = "Ayuda Sobre Parciales"
        '
        'TPNotas
        '
        Me.TPNotas.Controls.Add(Me.lblAyudaNotas)
        Me.TPNotas.Location = New System.Drawing.Point(4, 22)
        Me.TPNotas.Name = "TPNotas"
        Me.TPNotas.Padding = New System.Windows.Forms.Padding(3)
        Me.TPNotas.Size = New System.Drawing.Size(592, 374)
        Me.TPNotas.TabIndex = 2
        Me.TPNotas.Text = "Ayuda sobre Notas"
        Me.TPNotas.UseVisualStyleBackColor = True
        '
        'lblAyudaNotas
        '
        Me.lblAyudaNotas.ForeColor = System.Drawing.Color.Maroon
        Me.lblAyudaNotas.Location = New System.Drawing.Point(9, 12)
        Me.lblAyudaNotas.Name = "lblAyudaNotas"
        Me.lblAyudaNotas.Size = New System.Drawing.Size(550, 350)
        Me.lblAyudaNotas.TabIndex = 0
        Me.lblAyudaNotas.Text = "Ayuda Sobre Notas"
        '
        'frmContenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 423)
        Me.Controls.Add(Me.AyudaTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmContenido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contenido de La Ayuda"
        Me.AyudaTP.ResumeLayout(False)
        Me.TPMateria.ResumeLayout(False)
        Me.TPParciales.ResumeLayout(False)
        Me.TPNotas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AyudaTP As System.Windows.Forms.TabControl
    Friend WithEvents TPMateria As System.Windows.Forms.TabPage
    Friend WithEvents lblAyudaMateria As System.Windows.Forms.Label
    Friend WithEvents TPParciales As System.Windows.Forms.TabPage
    Friend WithEvents TPNotas As System.Windows.Forms.TabPage
    Friend WithEvents lblAyudaParcial As System.Windows.Forms.Label
    Friend WithEvents lblAyudaNotas As System.Windows.Forms.Label
End Class
