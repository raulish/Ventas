Public Class RNZona
    Inherits CADO

    Public Function Listar() As List(Of zona)
        Dim zona As List(Of zona)
        Dim pars As New List(Of CParametro)
        Dim dr As NpgsqlDataReader = Nothing
        Dim z As zona = Nothing


        Try
            Me.Conectar(True)
            dr = Me.PedirDataReader("fu_lizonas", Nothing)
            zona = New List(Of zona)

            Do While dr.Read = True
                z = New zona
                z.Codigo = dr.Item("idzona")
                z.Distrito = New Distrito
                z.Distrito.nombre = dr.Item("distrito")
                z.Distrito.Provincia = New Provincia
                z.Distrito.Provincia.Nombre = dr.Item("provincia")
                z.Distrito.Provincia.Departamento = New Departamento
                z.Distrito.Provincia.Departamento.Nombre = dr.Item("departamento")
                z.Distrito.Provincia.Departamento.Pais = New Pais
                z.Distrito.Provincia.Departamento.Pais.Nombre = dr.Item("pais")
                zona.Add(z)
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        End Try

        Return zona
    End Function
End Class
