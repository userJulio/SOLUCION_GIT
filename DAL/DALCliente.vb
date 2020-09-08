Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web
Imports LayerEntity
Public Class DALCliente
    Dim cnn As New SqlClient.SqlConnection(Coneccion.cadCon)
    Public Function AgregarCliente(MiCliente As LayerEntity.Cliente) As Boolean
        Try
            Dim cnn As New SqlConnection(DAL.Coneccion.cadCon)
            cnn.Open()
            Dim cmd As New SqlCommand("sp_Insertar_Empleado", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", MiCliente.NameEmp)
            cmd.Parameters.AddWithValue("@posociton", MiCliente.Postion)
            cmd.Parameters.AddWithValue("@oficina", MiCliente.Office)
            cmd.Parameters.AddWithValue("@Edad", MiCliente.Edad)
            cmd.Parameters.AddWithValue("@salario", MiCliente.Salario)
            cmd.ExecuteNonQuery()
            Return True
            cnn.Close()
            If 1 == 1 Then
                String mensaje = "holass"




        Catch ex As Exception
            Return False
            Throw ex
        End Try

    End Function



End Class
