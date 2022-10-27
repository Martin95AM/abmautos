Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub ButVol21_Click(sender As Object, e As EventArgs) Handles ButVol21.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ButAñCl_Click(sender As Object, e As EventArgs) Handles ButAñCl.Click
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server= DESKTOP-0JFE16D\SQLEXPRESS; database= Logistica; integrated security= True")
        conexion.Open()
        Dim nom As String = TxtNombre.Text
        Dim cuit As String = TxtCUIT.Text
        Dim cadena As String = "insert into Tbl_Clientes(Nombre, CUIT) values ('" & nom & "'," & cuit & ")"
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        MessageBox.Show("Los datos se guardaron correctamente")
        TxtNombre.Text = ""
        TxtCUIT.Text = ""
        conexion.Close()
    End Sub
End Class