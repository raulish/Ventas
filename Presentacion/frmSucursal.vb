
Public Class frmSucursal

    Private Actual As Sucursal
    Private Sub frmSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ToolTip1 As New ToolTip
        ToolTip1.SetToolTip(btnGuardar, "Guardar Datos")
        ToolTip1.SetToolTip(btnModificar, "Modificar Datos")
        ToolTip1.SetToolTip(btnNuevo, "Nuevos Datos")
        ToolTip1.SetToolTip(btnSalir, "Salir")
        'Me.gbListado.Enabled = False
        ListarSucursales("")
        ListarZonas()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ActivarControles(True)
        Me.Actual = Nothing
        Me.txtDireccion.Text = ""
        Me.txtCorreo.Text = ""
        Me.txtTelefono.Text = ""

    End Sub

    Private Sub ActivarControles(ByVal wEstado As Boolean)
        Me.gbDatos.Enabled = wEstado
        Me.gbListado.Enabled = Not wEstado
        If wEstado = True Then
            Me.txtDireccion.Focus()
        Else
            Me.txtSucursal.Focus()
        End If
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dgvSucursal.CurrentRow IsNot Nothing Then
            Me.Actual = DirectCast(Me.dgvSucursal.CurrentRow.DataBoundItem, Sucursal)
            Me.PresentarDatos()
        Else
            MessageBox.Show("Debe seleccionar una sucursal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PresentarDatos()
        Dim rn As New RNSucursal

        Try
            Me.Actual = rn.Leer(Me.Actual)
            If Me.Actual IsNot Nothing Then
                With Me.Actual

                    Me.txtCorreo.Text = .Correo
                    Me.txtDireccion.Text = .Direccion
                    Me.txtTelefono.Text = .Telefono

                End With

                Me.ActivarControles(True)
            Else
                MessageBox.Show("No se encontró la Sucursal solicitada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarSucursales(txtSucursal.Text)
    End Sub

    Private Sub ListarSucursales(ByVal wNombre As String)
        Dim rn As RNSucursal
        Dim sucursal As List(Of Sucursal)


        rn = New RNSucursal
        Try
            sucursal = rn.Listar(wNombre)
            modFunciones.EnlazarDatagridView(Me.dgvSucursal, sucursal)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rn As RNSucursal
        Dim s As Sucursal

        If Me.ValidateChildren = True Then
            s = New Sucursal
            s.Correo = Me.txtCorreo.Text
            s.Direccion = Me.txtDireccion.Text
            s.Telefono = Me.txtTelefono.Text
            rn = New RNSucursal
            Try
                If Me.Actual Is Nothing Then
                    rn.Registrar(s)
                    MessageBox.Show("Su Registro se Guardo con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.ActivarControles(False)
                    ListarSucursales("")
                Else
                    If (MessageBox.Show("¿Esta seguro de Guardar los cambios de este registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) Then
                        s.Codigo = Me.Actual.Codigo
                        rn.Actualizar(s)
                        Me.ActivarControles(False)
                        ListarSucursales("")
                    Else
                        Me.ActivarControles(True)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                rn = Nothing
                s = Nothing
            End Try

        End If
    End Sub
    Private Sub ListarZonas()
        Dim rn As New RNZona
        Dim zonas As List(Of zona)

        Try
            zonas = rn.Listar()
            modFunciones.ListarComboBox(Me.cboZonas, zonas, "Codigo", "ZonaNombre")

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try

    End Sub

End Class