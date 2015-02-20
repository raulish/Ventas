Module modFunciones

    Public Sub EnlazarDatagridView(Of Entidad)(ByVal wData As DataGridView, ByVal wDatos As List(Of Entidad))
        wData.DataSource = Nothing
        If wDatos.Count > 0 Then
            wData.AutoGenerateColumns = False
            wData.DataSource = wDatos
        End If
    End Sub

    Sub ListarComboBox(Of Entidad)(ByVal wCombo As ComboBox, ByVal wColeccion As List(Of Entidad), ByVal wCodigo As String, ByVal wTexto As String)
        wCombo.DataSource = Nothing
        If wCodigo.Count > 0 Then
            wCombo.DataSource = wColeccion
            wCombo.ValueMember = wCodigo
            wCombo.DisplayMember = wTexto
            wCombo.SelectedIndex = -1
        End If

    End Sub

End Module
