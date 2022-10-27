<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TxtOri = New System.Windows.Forms.TextBox()
        Me.TxtDest = New System.Windows.Forms.TextBox()
        Me.ButVol31 = New System.Windows.Forms.Button()
        Me.ButAñVi = New System.Windows.Forms.Button()
        Me.ButModVi = New System.Windows.Forms.Button()
        Me.ButElVi = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButBuscar = New System.Windows.Forms.Button()
        Me.TxtIDVi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblChoferesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogisticaDataSet3 = New abmautos.LogisticaDataSet3()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TblVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogisticaDataSet4 = New abmautos.LogisticaDataSet4()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_ChoferesTableAdapter = New abmautos.LogisticaDataSet3TableAdapters.Tbl_ChoferesTableAdapter()
        Me.Tbl_VehiculosTableAdapter = New abmautos.LogisticaDataSet4TableAdapters.Tbl_VehiculosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblChoferesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticaDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtOri
        '
        Me.TxtOri.Location = New System.Drawing.Point(122, 45)
        Me.TxtOri.Name = "TxtOri"
        Me.TxtOri.Size = New System.Drawing.Size(121, 22)
        Me.TxtOri.TabIndex = 1
        '
        'TxtDest
        '
        Me.TxtDest.Location = New System.Drawing.Point(122, 73)
        Me.TxtDest.Name = "TxtDest"
        Me.TxtDest.Size = New System.Drawing.Size(121, 22)
        Me.TxtDest.TabIndex = 2
        '
        'ButVol31
        '
        Me.ButVol31.Location = New System.Drawing.Point(281, 231)
        Me.ButVol31.Name = "ButVol31"
        Me.ButVol31.Size = New System.Drawing.Size(108, 23)
        Me.ButVol31.TabIndex = 3
        Me.ButVol31.Text = "Volver"
        Me.ButVol31.UseVisualStyleBackColor = True
        '
        'ButAñVi
        '
        Me.ButAñVi.Location = New System.Drawing.Point(281, 41)
        Me.ButAñVi.Name = "ButAñVi"
        Me.ButAñVi.Size = New System.Drawing.Size(108, 23)
        Me.ButAñVi.TabIndex = 4
        Me.ButAñVi.Text = "Añadir"
        Me.ButAñVi.UseVisualStyleBackColor = True
        '
        'ButModVi
        '
        Me.ButModVi.Location = New System.Drawing.Point(281, 72)
        Me.ButModVi.Name = "ButModVi"
        Me.ButModVi.Size = New System.Drawing.Size(108, 23)
        Me.ButModVi.TabIndex = 5
        Me.ButModVi.Text = "Modificar"
        Me.ButModVi.UseVisualStyleBackColor = True
        '
        'ButElVi
        '
        Me.ButElVi.Location = New System.Drawing.Point(281, 101)
        Me.ButElVi.Name = "ButElVi"
        Me.ButElVi.Size = New System.Drawing.Size(108, 23)
        Me.ButElVi.TabIndex = 6
        Me.ButElVi.Text = "Eliminar"
        Me.ButElVi.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(395, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(402, 261)
        Me.DataGridView1.TabIndex = 7
        '
        'ButBuscar
        '
        Me.ButBuscar.Location = New System.Drawing.Point(281, 12)
        Me.ButBuscar.Name = "ButBuscar"
        Me.ButBuscar.Size = New System.Drawing.Size(108, 23)
        Me.ButBuscar.TabIndex = 8
        Me.ButBuscar.Text = "Buscar"
        Me.ButBuscar.UseVisualStyleBackColor = True
        '
        'TxtIDVi
        '
        Me.TxtIDVi.Location = New System.Drawing.Point(122, 17)
        Me.TxtIDVi.Name = "TxtIDVi"
        Me.TxtIDVi.Size = New System.Drawing.Size(121, 22)
        Me.TxtIDVi.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID del Viaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Origen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Destino"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DNI del Chofer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CUIT del Cliente"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblChoferesBindingSource
        Me.ComboBox1.DisplayMember = "DNI"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(122, 100)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.ValueMember = "DNI"
        '
        'TblChoferesBindingSource
        '
        Me.TblChoferesBindingSource.DataMember = "Tbl_Choferes"
        Me.TblChoferesBindingSource.DataSource = Me.LogisticaDataSet3
        '
        'LogisticaDataSet3
        '
        Me.LogisticaDataSet3.DataSetName = "LogisticaDataSet3"
        Me.LogisticaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "CUIT"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(122, 128)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 16
        Me.ComboBox2.ValueMember = "CUIT"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.TblVehiculosBindingSource
        Me.ComboBox3.DisplayMember = "Patente"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(122, 158)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 17
        Me.ComboBox3.ValueMember = "Patente"
        '
        'TblVehiculosBindingSource
        '
        Me.TblVehiculosBindingSource.DataMember = "Tbl_Vehiculos"
        Me.TblVehiculosBindingSource.DataSource = Me.LogisticaDataSet4
        '
        'LogisticaDataSet4
        '
        Me.LogisticaDataSet4.DataSetName = "LogisticaDataSet4"
        Me.LogisticaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Patente"
        '
        'Tbl_ChoferesTableAdapter
        '
        Me.Tbl_ChoferesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_VehiculosTableAdapter
        '
        Me.Tbl_VehiculosTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 266)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIDVi)
        Me.Controls.Add(Me.ButBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButElVi)
        Me.Controls.Add(Me.ButModVi)
        Me.Controls.Add(Me.ButAñVi)
        Me.Controls.Add(Me.ButVol31)
        Me.Controls.Add(Me.TxtDest)
        Me.Controls.Add(Me.TxtOri)
        Me.Name = "Form3"
        Me.Text = "Viajes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblChoferesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticaDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtOri As TextBox
    Friend WithEvents TxtDest As TextBox
    Friend WithEvents ButVol31 As Button
    Friend WithEvents ButAñVi As Button
    Friend WithEvents ButModVi As Button
    Friend WithEvents ButElVi As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButBuscar As Button
    Friend WithEvents TxtIDVi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LogisticaDataSet3 As LogisticaDataSet3
    Friend WithEvents TblChoferesBindingSource As BindingSource
    Friend WithEvents Tbl_ChoferesTableAdapter As LogisticaDataSet3TableAdapters.Tbl_ChoferesTableAdapter
    Friend WithEvents LogisticaDataSet4 As LogisticaDataSet4
    Friend WithEvents TblVehiculosBindingSource As BindingSource
    Friend WithEvents Tbl_VehiculosTableAdapter As LogisticaDataSet4TableAdapters.Tbl_VehiculosTableAdapter
End Class
