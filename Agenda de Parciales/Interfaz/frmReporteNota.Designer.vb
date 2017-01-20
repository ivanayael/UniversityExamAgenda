<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteNota
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
        Me.CRVNota = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRVNota
        '
        Me.CRVNota.ActiveViewIndex = -1
        Me.CRVNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVNota.DisplayGroupTree = False
        Me.CRVNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVNota.Location = New System.Drawing.Point(0, 0)
        Me.CRVNota.Name = "CRVNota"
        Me.CRVNota.SelectionFormula = ""
        Me.CRVNota.Size = New System.Drawing.Size(792, 566)
        Me.CRVNota.TabIndex = 0
        Me.CRVNota.ViewTimeSelectionFormula = ""
        '
        'frmReporteNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.CRVNota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReporteNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Notas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVNota As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
