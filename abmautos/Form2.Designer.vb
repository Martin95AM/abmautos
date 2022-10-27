<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TxtCUIT = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.ButVol21 = New System.Windows.Forms.Button()
        Me.ButAñCl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCUIT
        '
        Me.TxtCUIT.Location = New System.Drawing.Point(138, 135)
        Me.TxtCUIT.Name = "TxtCUIT"
        Me.TxtCUIT.Size = New System.Drawing.Size(281, 22)
        Me.TxtCUIT.TabIndex = 0
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(138, 183)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(281, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'ButVol21
        '
        Me.ButVol21.Location = New System.Drawing.Point(73, 235)
        Me.ButVol21.Name = "ButVol21"
        Me.ButVol21.Size = New System.Drawing.Size(108, 23)
        Me.ButVol21.TabIndex = 2
        Me.ButVol21.Text = "Volver"
        Me.ButVol21.UseVisualStyleBackColor = True
        '
        'ButAñCl
        '
        Me.ButAñCl.Location = New System.Drawing.Point(243, 235)
        Me.ButAñCl.Name = "ButAñCl"
        Me.ButAñCl.Size = New System.Drawing.Size(108, 23)
        Me.ButAñCl.TabIndex = 3
        Me.ButAñCl.Text = "Añadir"
        Me.ButAñCl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CUIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 35)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nuevo cliente"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 287)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButAñCl)
        Me.Controls.Add(Me.ButVol21)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCUIT)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCUIT As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents ButVol21 As Button
    Friend WithEvents ButAñCl As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
