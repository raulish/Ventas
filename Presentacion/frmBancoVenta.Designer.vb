<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancoVenta

    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBancoVenta))
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dgbBancoVenta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.gbDistrito = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New MetroFramework.Controls.MetroComboBox()
        Me.txtUbicacion = New MetroFramework.Controls.MetroTextBox()
        Me.cmbSiglas = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtIdBanco = New MetroFramework.Controls.MetroTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.MetroTabControl3 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroRadioButton4 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MetroTabControl2.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.dgbBancoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.gbDistrito.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MetroTabControl3.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl2.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl2.Location = New System.Drawing.Point(458, 72)
        Me.MetroTabControl2.Multiline = True
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(463, 327)
        Me.MetroTabControl2.TabIndex = 167
        Me.MetroTabControl2.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTabPage2.Controls.Add(Me.Button1)
        Me.MetroTabPage2.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage2.Controls.Add(Me.MetroRadioButton2)
        Me.MetroTabPage2.Controls.Add(Me.MetroRadioButton1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage2.Controls.Add(Me.dgbBancoVenta)
        Me.MetroTabPage2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = True
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(455, 282)
        Me.MetroTabPage2.TabIndex = 0
        Me.MetroTabPage2.Text = "LISTA BANCO VENTA"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(82, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 32)
        Me.Button1.TabIndex = 156
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(143, 57)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(285, 23)
        Me.MetroTextBox1.TabIndex = 155
        Me.MetroTextBox1.UseSelectable = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(259, 18)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(43, 15)
        Me.MetroRadioButton2.TabIndex = 154
        Me.MetroRadioButton2.Text = "DNI"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(143, 18)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(72, 15)
        Me.MetroRadioButton1.TabIndex = 153
        Me.MetroRadioButton1.Text = "NOMBRE"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 14)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 152
        Me.MetroLabel6.Text = "BUSQUEDA POR :"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'dgbBancoVenta
        '
        Me.dgbBancoVenta.BackgroundColor = System.Drawing.Color.Gray
        Me.dgbBancoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbBancoVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgbBancoVenta.Location = New System.Drawing.Point(22, 100)
        Me.dgbBancoVenta.Name = "dgbBancoVenta"
        Me.dgbBancoVenta.Size = New System.Drawing.Size(419, 179)
        Me.dgbBancoVenta.TabIndex = 151
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "SIGLAS"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "UBICACION"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "ESTADO"
        Me.Column5.Name = "Column5"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.AllowDrop = True
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Location = New System.Drawing.Point(14, 72)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(428, 289)
        Me.MetroTabControl1.TabIndex = 166
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.gbDistrito)
        Me.MetroTabPage1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroTabPage1.Size = New System.Drawing.Size(420, 244)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "DATOS"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'gbDistrito
        '
        Me.gbDistrito.BackColor = System.Drawing.Color.White
        Me.gbDistrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbDistrito.Controls.Add(Me.cmbEstado)
        Me.gbDistrito.Controls.Add(Me.txtUbicacion)
        Me.gbDistrito.Controls.Add(Me.cmbSiglas)
        Me.gbDistrito.Controls.Add(Me.MetroLabel4)
        Me.gbDistrito.Controls.Add(Me.txtNombre)
        Me.gbDistrito.Controls.Add(Me.MetroLabel3)
        Me.gbDistrito.Controls.Add(Me.MetroLabel1)
        Me.gbDistrito.Controls.Add(Me.MetroLabel2)
        Me.gbDistrito.Controls.Add(Me.MetroLabel5)
        Me.gbDistrito.Controls.Add(Me.txtIdBanco)
        Me.gbDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbDistrito.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDistrito.ForeColor = System.Drawing.Color.Black
        Me.gbDistrito.Location = New System.Drawing.Point(3, 14)
        Me.gbDistrito.Name = "gbDistrito"
        Me.gbDistrito.Size = New System.Drawing.Size(403, 213)
        Me.gbDistrito.TabIndex = 152
        Me.gbDistrito.TabStop = False
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.ItemHeight = 23
        Me.cmbEstado.Location = New System.Drawing.Point(95, 165)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(123, 29)
        Me.cmbEstado.TabIndex = 46
        Me.cmbEstado.UseSelectable = True
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Lines = New String(-1) {}
        Me.txtUbicacion.Location = New System.Drawing.Point(95, 120)
        Me.txtUbicacion.MaxLength = 32767
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUbicacion.SelectedText = ""
        Me.txtUbicacion.Size = New System.Drawing.Size(296, 23)
        Me.txtUbicacion.TabIndex = 45
        Me.txtUbicacion.UseSelectable = True
        '
        'cmbSiglas
        '
        Me.cmbSiglas.FormattingEnabled = True
        Me.cmbSiglas.ItemHeight = 23
        Me.cmbSiglas.Location = New System.Drawing.Point(292, 75)
        Me.cmbSiglas.Name = "cmbSiglas"
        Me.cmbSiglas.Size = New System.Drawing.Size(99, 29)
        Me.cmbSiglas.TabIndex = 44
        Me.cmbSiglas.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(235, 79)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 43
        Me.MetroLabel4.Text = "SIGLAS"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'txtNombre
        '
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(95, 75)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(134, 23)
        Me.txtNombre.TabIndex = 42
        Me.txtNombre.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(12, 120)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 41
        Me.MetroLabel3.Text = "UBICACION"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 165)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 40
        Me.MetroLabel1.Text = "ESTADO"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 75)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "NOMBRE"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(12, 34)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 32
        Me.MetroLabel5.Text = " BANCO"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'txtIdBanco
        '
        Me.txtIdBanco.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtIdBanco.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtIdBanco.Lines = New String(-1) {}
        Me.txtIdBanco.Location = New System.Drawing.Point(95, 34)
        Me.txtIdBanco.MaxLength = 32767
        Me.txtIdBanco.Name = "txtIdBanco"
        Me.txtIdBanco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdBanco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdBanco.SelectedText = ""
        Me.txtIdBanco.Size = New System.Drawing.Size(236, 23)
        Me.txtIdBanco.TabIndex = 3
        Me.txtIdBanco.UseSelectable = True
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(-1, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(258, 57)
        Me.Button6.TabIndex = 169
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.AutoSize = True
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MetroTile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Location = New System.Drawing.Point(-1, 2)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(931, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 168
        Me.MetroTile2.Text = "REGISTRO BANCO DE VENTA"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseStyleColors = True
        Me.MetroTile2.UseTileImage = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(-1, 419)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 52)
        Me.Panel1.TabIndex = 170
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(853, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(51, 49)
        Me.btnSalir.TabIndex = 90
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Black
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(15, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(57, 52)
        Me.btnNuevo.TabIndex = 92
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(98, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(71, 52)
        Me.btnModificar.TabIndex = 77
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(188, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(59, 52)
        Me.btnGuardar.TabIndex = 148
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'MetroTabControl3
        '
        Me.MetroTabControl3.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl3.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl3.Location = New System.Drawing.Point(458, 72)
        Me.MetroTabControl3.Multiline = True
        Me.MetroTabControl3.Name = "MetroTabControl3"
        Me.MetroTabControl3.SelectedIndex = 0
        Me.MetroTabControl3.Size = New System.Drawing.Size(463, 320)
        Me.MetroTabControl3.TabIndex = 167
        Me.MetroTabControl3.UseSelectable = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTabPage3.Controls.Add(Me.Button2)
        Me.MetroTabPage3.Controls.Add(Me.MetroTextBox2)
        Me.MetroTabPage3.Controls.Add(Me.MetroRadioButton4)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage3.Controls.Add(Me.DataGridView1)
        Me.MetroTabPage3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = True
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(455, 275)
        Me.MetroTabPage3.TabIndex = 0
        Me.MetroTabPage3.Text = "LISTA BANCO VENTA"
        Me.MetroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(71, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 32)
        Me.Button2.TabIndex = 156
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(125, 44)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.Size = New System.Drawing.Size(285, 23)
        Me.MetroTextBox2.TabIndex = 155
        Me.MetroTextBox2.UseSelectable = True
        '
        'MetroRadioButton4
        '
        Me.MetroRadioButton4.AutoSize = True
        Me.MetroRadioButton4.Location = New System.Drawing.Point(143, 18)
        Me.MetroRadioButton4.Name = "MetroRadioButton4"
        Me.MetroRadioButton4.Size = New System.Drawing.Size(72, 15)
        Me.MetroRadioButton4.TabIndex = 153
        Me.MetroRadioButton4.Text = "NOMBRE"
        Me.MetroRadioButton4.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 14)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel7.TabIndex = 152
        Me.MetroLabel7.Text = "BUSQUEDA POR :"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewComboBoxColumn2})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(419, 179)
        Me.DataGridView1.TabIndex = 151
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "SIGLAS"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "UBICACION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.HeaderText = "ESTADO"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        '
        'frmBancoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTabControl3)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmBancoVenta"
        Me.MetroTabControl2.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.dgbBancoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.gbDistrito.ResumeLayout(False)
        Me.gbDistrito.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MetroTabControl3.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Private WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgbBancoVenta As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents gbDistrito As System.Windows.Forms.GroupBox
    Friend WithEvents cmbEstado As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtUbicacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbSiglas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIdBanco As MetroFramework.Controls.MetroTextBox
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabControl3 As MetroFramework.Controls.MetroTabControl
    Private WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroRadioButton4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
