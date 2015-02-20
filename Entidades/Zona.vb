Public Class zona

    Public Property Codigo As Integer
    Public Property Distrito As Distrito
    Public Property Vigencia As Boolean

    


    Public ReadOnly Property ZonaNombre As String
        Get
            Dim nombre As String = ""


            nombre = Me.Distrito.nombre + ", " + Me.Distrito.Provincia.Nombre + ", " +
                     Me.Distrito.Provincia.Departamento.Nombre + ", " + Me.Distrito.Provincia.Departamento.Pais.Nombre


            Return nombre
        End Get

    End Property





End Class