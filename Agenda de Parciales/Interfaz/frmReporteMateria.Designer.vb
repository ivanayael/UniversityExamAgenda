<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMateria
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
        Me.CRVMateria = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRVMateria
        '
        Me.CRVMateria.ActiveViewIndex = -1
        Me.CRVMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVMateria.DisplayGroupTree = False
        Me.CRVMateria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVMateria.Location = New System.Drawing.Point(0, 0)
        Me.CRVMateria.Name = "CRVMateria"
        Me.CRVMateria.SelectionFormula = ""
        Me.CRVMateria.Size = New System.Drawing.Size(792, 566)
        Me.CRVMateria.TabIndex = 0
        Me.CRVMateria.ViewTimeSelectionFormula = ""
        '
        'frmReporteMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.CRVMateria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReporteMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Materia"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVMateria As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
