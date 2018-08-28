<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NumerosTextBox = New System.Windows.Forms.TextBox()
        Me.LetraTextBox = New System.Windows.Forms.TextBox()
        Me.CalcularButton = New System.Windows.Forms.Button()
        Me.LimpiarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NumerosTextBox
        '
        Me.NumerosTextBox.Location = New System.Drawing.Point(22, 28)
        Me.NumerosTextBox.Name = "NumerosTextBox"
        Me.NumerosTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NumerosTextBox.TabIndex = 1
        '
        'LetraTextBox
        '
        Me.LetraTextBox.Location = New System.Drawing.Point(168, 28)
        Me.LetraTextBox.Name = "LetraTextBox"
        Me.LetraTextBox.Size = New System.Drawing.Size(22, 20)
        Me.LetraTextBox.TabIndex = 2
        '
        'CalcularButton
        '
        Me.CalcularButton.Location = New System.Drawing.Point(22, 74)
        Me.CalcularButton.Name = "CalcularButton"
        Me.CalcularButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcularButton.TabIndex = 3
        Me.CalcularButton.Text = "Calcular"
        Me.CalcularButton.UseVisualStyleBackColor = True
        '
        'LimpiarButton
        '
        Me.LimpiarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LimpiarButton.Location = New System.Drawing.Point(115, 74)
        Me.LimpiarButton.Name = "LimpiarButton"
        Me.LimpiarButton.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarButton.TabIndex = 4
        Me.LimpiarButton.Text = "Limpiar"
        Me.LimpiarButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.CalcularButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.LimpiarButton
        Me.ClientSize = New System.Drawing.Size(218, 126)
        Me.Controls.Add(Me.LimpiarButton)
        Me.Controls.Add(Me.CalcularButton)
        Me.Controls.Add(Me.LetraTextBox)
        Me.Controls.Add(Me.NumerosTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DNI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumerosTextBox As TextBox
    Friend WithEvents LetraTextBox As TextBox
    Friend WithEvents CalcularButton As Button
    Friend WithEvents LimpiarButton As Button
End Class
