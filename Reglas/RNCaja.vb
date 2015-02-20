﻿Public Class RNCaja
    Inherits CADO
    'ESTO ES PARA PROBAR GIT OJALA NO SE CAGE CSMM POR CARAJOS NO FUNCIONA
    Sub Registrar(ByVal wCaja As Caja)
        Dim pars As New List(Of CParametro)

        pars.Add(New CParametro("pNumero", wCaja.Numero))
        pars.Add(New CParametro("pDescripcion", wCaja.Descripcion))
        pars.Add(New CParametro("pFechaApertura", wCaja.FechaApertura))
        pars.Add(New CParametro("pFechaCierre", wCaja.FechaCierre))
        pars.Add(New CParametro("pMontoApertura", wCaja.MontoApertua))
        pars.Add(New CParametro("pMontoCierre", wCaja.MontoCierre))
        pars.Add(New CParametro("pEstado", True)) 'siempre estaran activadas las cajas por ahora
        pars.Add(New CParametro("pEmpleado", 1))
        pars.Add(New CParametro("pSucursal", 1))

        Try
            Me.Conectar(False)
            Me.EjecutarOrden("fu_icaja", pars)
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try
    End Sub

End Class

