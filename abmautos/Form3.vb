Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form3
    Private Sub ButVol31_Click(sender As Object, e As EventArgs) Handles ButVol31.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LogisticaDataSet4.Tbl_Vehiculos' Puede moverla o quitarla según sea necesario.
        Me.Tbl_VehiculosTableAdapter.Fill(Me.LogisticaDataSet4.Tbl_Vehiculos)
        'TODO: esta línea de código carga datos en la tabla 'LogisticaDataSet3.Tbl_Choferes' Puede moverla o quitarla según sea necesario.
        Me.Tbl_ChoferesTableAdapter.Fill(Me.LogisticaDataSet3.Tbl_Choferes)
        Call Data()
    End Sub
    Public Sub Data()
        Dim sCnn As String
        sCnn = "server= DESKTOP-0JFE16D\SQLEXPRESS; database= Logistica; integrated security= True"
        Dim sSel As String = "SELECT Tbl_Viajes.ID_Vi, Tbl_Viajes.Origen, Tbl_Viajes.Destino, Tbl_Choferes.DNI, Tbl_Choferes.Nombre_Ch, Tbl_Choferes.Apellido_Ch, Tbl_Clientes.CUIT, Tbl_Vehiculos.Patente  FROM Tbl_Viajes, Tbl_Choferes, Tbl_Clientes, Tbl_Vehiculos WHERE Tbl_Viajes.DNI_Ch=Tbl_Choferes.DNI AND Tbl_Viajes.CUIT_Cl=Tbl_Clientes.CUIT AND Tbl_Viajes.Patente_Ve=Tbl_Vehiculos.Patente"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        da = New SqlDataAdapter(sSel, sCnn)
        da.Fill(dt)

        Me.DataGridView1.DataSource = dt

        Dim asdf As String
        asdf = "server= DESKTOP-0JFE16D\SQLEXPRESS; database= Logistica; integrated security= True"
        Dim fdsa As String = "SELECT CUIT FROM Tbl_Clientes"
        Dim dat As SqlDataAdapter
        Dim dtbl As New DataTable
        dat = New SqlDataAdapter(fdsa, asdf)
        dat.Fill(dtbl)

        Me.ComboBox2.DataSource = dtbl

        Dim ghjk As String
        ghjk = "server= DESKTOP-0JFE16D\SQLEXPRESS; database= Logistica; integrated security= True"
        Dim kjhg As String = "SELECT DNI FROM Tbl_Choferes"
        Dim data As SqlDataAdapter
        Dim dtble As New DataTable
        data = New SqlDataAdapter(kjhg, ghjk)
        data.Fill(dtble)

        Me.ComboBox1.DataSource = dtble

        Dim qwer As String
        qwer = "server= DESKTOP-0JFE16D\SQLEXPRESS; database= Logistica; integrated security= True"
        Dim rewq As String = "SELECT Patente FROM Tbl_Vehiculos"
        Dim dtas As SqlDataAdapter
        Dim dtbles As New DataTable
        dtas = New SqlDataAdapter(rewq, qwer)
        dtas.Fill(dtbles)

        Me.ComboBox3.DataSource = dtbles
    End Sub

    Private Sub ButAñVi_Click(sender As Object, e As EventArgs) Handles ButAñVi.Click
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server= DESKTOP-0JFE16D\SQLEXPRESS; database= Logistica; integrated security= True")
        conexion.Open()
        Dim Ori As String = TxtOri.Text
        Dim Dest As String = TxtDest.Text
        Dim dni As String = ComboBox1.Text
        Dim cuit As String = ComboBox2.Text
        Dim Pat As String = ComboBox3.Text
        Dim cadena As String = "insert into Tbl_Viajes(Origen, Destino, DNI_Ch, CUIT_Cl, Patente_Ve) values ('" & Ori & "','" & Dest & "'," & dni & "," & cuit & ",'" & Pat & "')"
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        MessageBox.Show("Los datos se guardaron correctamente")
        TxtOri.Text = ""
        TxtDest.Text = ""
        conexion.Close()
        Call Data()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ButBuscar_Click(sender As Object, e As EventArgs) Handles ButBuscar.Click
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server=DESKTOP-0JFE16D\SQLEXPRESS ; database=Logistica ; integrated security = true")
        conexion.Open()
        Dim cod As String = TxtIDVi.Text
        Dim cadena As String = "select ID_Vi, Origen, Destino, DNI_Ch, CUIT_Cl, Patente_Ve from Tbl_Viajes where ID_Vi=" & cod & ""
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        Dim registro As SqlDataReader
        registro = comando.ExecuteReader()
        If registro.Read() = True Then
            TxtIDVi.Text = registro("ID_Vi")
            TxtOri.Text = registro("Origen")
            TxtDest.Text = registro("Destino")
            ComboBox1.Text = registro("DNI_Ch")
            ComboBox2.Text = registro("CUIT_Cl")
            ComboBox3.Text = registro("Patente_Ve")
        Else
            MessageBox.Show("No existe un Viajes con el id ingresado")
        End If
        conexion.Close()
    End Sub

    Private Sub ButModVi_Click(sender As Object, e As EventArgs) Handles ButModVi.Click
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server=DESKTOP-0JFE16D\SQLEXPRESS ; database=Logistica ; integrated security = true")
        conexion.Open()
        Dim cod As String = TxtIDVi.Text
        Dim Ori As String = TxtOri.Text
        Dim Dest As String = TxtDest.Text
        Dim dnich As String = ComboBox1.Text
        Dim cuitcl As String = ComboBox2.Text
        Dim Patve As String = ComboBox3.Text
        Dim cadena As String = "update Tbl_Viajes set Origen='" & Ori & "', Destino='" & Dest & "', DNI_Ch='" & dnich & "', CUIT_Cl='" & cuitcl & "', Patente_Ve='" & Patve & "' where ID_Vi='" & cod & "'"
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        Dim cant As Integer
        cant = comando.ExecuteNonQuery()
        If cant = 1 Then
            MessageBox.Show("Se modificaron los datos del Viaje")
            TxtIDVi.Text = ""
            TxtOri.Text = ""
            TxtDest.Text = ""
        Else
            MessageBox.Show("No existe un Viaje con el id ingresado")
        End If
        conexion.Close()
        Call Data()
    End Sub

    Private Sub ButElVi_Click(sender As Object, e As EventArgs) Handles ButElVi.Click
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server=DESKTOP-0JFE16D\SQLEXPRESS ; database=Logistica ; integrated security = true")
        conexion.Open()
        Dim cod As String = TxtIDVi.Text
        Dim cadena As String = "delete from Tbl_Viajes where ID_Vi=" & cod & ""
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        Dim cant As Integer
        cant = comando.ExecuteNonQuery()
        If cant = 1 Then
            MessageBox.Show("Se borró el Viaje seleccionado")
        Else
            MessageBox.Show("No existe un Viaje con el id ingresado")
        End If
        conexion.Close()
        Call Data()
    End Sub
End Class