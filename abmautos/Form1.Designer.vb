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
        Me.ButNueCl = New System.Windows.Forms.Button()
        Me.ButNueVi = New System.Windows.Forms.Button()
        Me.ButOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButNueCl
        '
        Me.ButNueCl.Location = New System.Drawing.Point(54, 150)
        Me.ButNueCl.Margin = New System.Windows.Forms.Padding(4)
        Me.ButNueCl.Name = "ButNueCl"
        Me.ButNueCl.Size = New System.Drawing.Size(126, 28)
        Me.ButNueCl.TabIndex = 0
        Me.ButNueCl.Text = "Nuevo Cliente"
        Me.ButNueCl.UseVisualStyleBackColor = True
        '
        'ButNueVi
        '
        Me.ButNueVi.Location = New System.Drawing.Point(255, 150)
        Me.ButNueVi.Margin = New System.Windows.Forms.Padding(4)
        Me.ButNueVi.Name = "ButNueVi"
        Me.ButNueVi.Size = New System.Drawing.Size(126, 28)
        Me.ButNueVi.TabIndex = 1
        Me.ButNueVi.Text = "Nuestros Viajes"
        Me.ButNueVi.UseVisualStyleBackColor = True
        '
        'ButOut
        '
        Me.ButOut.Location = New System.Drawing.Point(161, 199)
        Me.ButOut.Margin = New System.Windows.Forms.Padding(4)
        Me.ButOut.Name = "ButOut"
        Me.ButOut.Size = New System.Drawing.Size(109, 28)
        Me.ButOut.TabIndex = 2
        Me.ButOut.Text = "Salir"
        Me.ButOut.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 263)
        Me.Controls.Add(Me.ButOut)
        Me.Controls.Add(Me.ButNueVi)
        Me.Controls.Add(Me.ButNueCl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButNueCl As Button
    Friend WithEvents ButNueVi As Button
    Friend WithEvents ButOut As Button
End Class
