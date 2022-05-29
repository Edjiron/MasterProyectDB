<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminEmpleado
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.DepartamentoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterBDDataSet = New MasterProyectBD.MasterBDDataSet()
        Me.CargoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txbSeguroS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txbDireccion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.txbCedula = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txbContrato = New System.Windows.Forms.TextBox()
        Me.txbSalida = New System.Windows.Forms.TextBox()
        Me.txbEntrada = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegSosINSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwEmpleadoCrudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_EmpleadoCrudTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.Vw_EmpleadoCrudTableAdapter()
        Me.CargoTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.CargoTableAdapter()
        Me.DepartamentoTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.DepartamentoTableAdapter()
        Me.CargoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.EmpleadoTableAdapter()
        Me.tbxCargo = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DepartamentoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEmpleadoCrudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbxCargo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbxDepartamento)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txbSeguroS)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txbDireccion)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.txbEmail)
        Me.GroupBox2.Controls.Add(Me.txbTelefono)
        Me.GroupBox2.Controls.Add(Me.txbCedula)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txbContrato)
        Me.GroupBox2.Controls.Add(Me.txbSalida)
        Me.GroupBox2.Controls.Add(Me.txbEntrada)
        Me.GroupBox2.Controls.Add(Me.txbNombre)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(809, 285)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(451, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Dept:"
        '
        'tbxDepartamento
        '
        Me.tbxDepartamento.DataSource = Me.DepartamentoBindingSource1
        Me.tbxDepartamento.DisplayMember = "nombreDep"
        Me.tbxDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDepartamento.FormattingEnabled = True
        Me.tbxDepartamento.Location = New System.Drawing.Point(507, 191)
        Me.tbxDepartamento.Name = "tbxDepartamento"
        Me.tbxDepartamento.Size = New System.Drawing.Size(255, 24)
        Me.tbxDepartamento.TabIndex = 29
        Me.tbxDepartamento.ValueMember = "id_Dep"
        '
        'DepartamentoBindingSource1
        '
        Me.DepartamentoBindingSource1.DataMember = "Departamento"
        Me.DepartamentoBindingSource1.DataSource = Me.MasterBDDataSet
        '
        'MasterBDDataSet
        '
        Me.MasterBDDataSet.DataSetName = "MasterBDDataSet"
        Me.MasterBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargoBindingSource2
        '
        Me.CargoBindingSource2.DataMember = "Cargo"
        Me.CargoBindingSource2.DataSource = Me.MasterBDDataSet
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(403, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 17)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Seguro social:"
        '
        'txbSeguroS
        '
        Me.txbSeguroS.Location = New System.Drawing.Point(507, 129)
        Me.txbSeguroS.Name = "txbSeguroS"
        Me.txbSeguroS.Size = New System.Drawing.Size(255, 26)
        Me.txbSeguroS.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(430, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Direccion:"
        '
        'txbDireccion
        '
        Me.txbDireccion.Location = New System.Drawing.Point(507, 97)
        Me.txbDireccion.Name = "txbDireccion"
        Me.txbDireccion.Size = New System.Drawing.Size(255, 26)
        Me.txbDireccion.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(419, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 31)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(451, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Cargo:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(131, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(63, 26)
        Me.TextBox3.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(85, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Id:"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(677, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 31)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(592, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 31)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(504, 234)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 31)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(507, 64)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(255, 26)
        Me.txbEmail.TabIndex = 13
        '
        'txbTelefono
        '
        Me.txbTelefono.Location = New System.Drawing.Point(507, 32)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(255, 26)
        Me.txbTelefono.TabIndex = 12
        '
        'txbCedula
        '
        Me.txbCedula.Location = New System.Drawing.Point(131, 193)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(238, 26)
        Me.txbCedula.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(451, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 37)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Email:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(430, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Telefono:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(36, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 17)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Num Cedula:"
        '
        'txbContrato
        '
        Me.txbContrato.Location = New System.Drawing.Point(131, 155)
        Me.txbContrato.Name = "txbContrato"
        Me.txbContrato.Size = New System.Drawing.Size(238, 26)
        Me.txbContrato.TabIndex = 7
        '
        'txbSalida
        '
        Me.txbSalida.Location = New System.Drawing.Point(131, 123)
        Me.txbSalida.Name = "txbSalida"
        Me.txbSalida.Size = New System.Drawing.Size(238, 26)
        Me.txbSalida.TabIndex = 6
        '
        'txbEntrada
        '
        Me.txbEntrada.Location = New System.Drawing.Point(131, 91)
        Me.txbEntrada.Name = "txbEntrada"
        Me.txbEntrada.Size = New System.Drawing.Size(238, 26)
        Me.txbEntrada.TabIndex = 5
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(131, 58)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(238, 26)
        Me.txbNombre.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Fecha Contrato:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(74, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Salida:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(63, 97)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Entrada:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(125, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Nombre Completo:"
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.MasterBDDataSet
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.MasterBDDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.NomEmpleadoDataGridViewTextBoxColumn, Me.FechaEntradaDataGridViewTextBoxColumn, Me.FechaSalidaDataGridViewTextBoxColumn, Me.FechaContratoDataGridViewTextBoxColumn, Me.NumCedulaDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.SegSosINSSDataGridViewTextBoxColumn, Me.TipoCargoDataGridViewTextBoxColumn, Me.NombreDepDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwEmpleadoCrudBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 313)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(732, 150)
        Me.DataGridView1.TabIndex = 27
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "id_Empleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "id_Empleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomEmpleadoDataGridViewTextBoxColumn
        '
        Me.NomEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "nomEmpleado"
        Me.NomEmpleadoDataGridViewTextBoxColumn.HeaderText = "nomEmpleado"
        Me.NomEmpleadoDataGridViewTextBoxColumn.Name = "NomEmpleadoDataGridViewTextBoxColumn"
        Me.NomEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaEntradaDataGridViewTextBoxColumn
        '
        Me.FechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "fechaEntrada"
        Me.FechaEntradaDataGridViewTextBoxColumn.HeaderText = "fechaEntrada"
        Me.FechaEntradaDataGridViewTextBoxColumn.Name = "FechaEntradaDataGridViewTextBoxColumn"
        Me.FechaEntradaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaSalidaDataGridViewTextBoxColumn
        '
        Me.FechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "fechaSalida"
        Me.FechaSalidaDataGridViewTextBoxColumn.HeaderText = "fechaSalida"
        Me.FechaSalidaDataGridViewTextBoxColumn.Name = "FechaSalidaDataGridViewTextBoxColumn"
        Me.FechaSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaContratoDataGridViewTextBoxColumn
        '
        Me.FechaContratoDataGridViewTextBoxColumn.DataPropertyName = "fechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.HeaderText = "fechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.Name = "FechaContratoDataGridViewTextBoxColumn"
        Me.FechaContratoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumCedulaDataGridViewTextBoxColumn
        '
        Me.NumCedulaDataGridViewTextBoxColumn.DataPropertyName = "numCedula"
        Me.NumCedulaDataGridViewTextBoxColumn.HeaderText = "numCedula"
        Me.NumCedulaDataGridViewTextBoxColumn.Name = "NumCedulaDataGridViewTextBoxColumn"
        Me.NumCedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SegSosINSSDataGridViewTextBoxColumn
        '
        Me.SegSosINSSDataGridViewTextBoxColumn.DataPropertyName = "segSosINSS"
        Me.SegSosINSSDataGridViewTextBoxColumn.HeaderText = "segSosINSS"
        Me.SegSosINSSDataGridViewTextBoxColumn.Name = "SegSosINSSDataGridViewTextBoxColumn"
        Me.SegSosINSSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCargoDataGridViewTextBoxColumn
        '
        Me.TipoCargoDataGridViewTextBoxColumn.DataPropertyName = "tipoCargo"
        Me.TipoCargoDataGridViewTextBoxColumn.HeaderText = "tipoCargo"
        Me.TipoCargoDataGridViewTextBoxColumn.Name = "TipoCargoDataGridViewTextBoxColumn"
        Me.TipoCargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDepDataGridViewTextBoxColumn
        '
        Me.NombreDepDataGridViewTextBoxColumn.DataPropertyName = "nombreDep"
        Me.NombreDepDataGridViewTextBoxColumn.HeaderText = "nombreDep"
        Me.NombreDepDataGridViewTextBoxColumn.Name = "NombreDepDataGridViewTextBoxColumn"
        Me.NombreDepDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwEmpleadoCrudBindingSource
        '
        Me.VwEmpleadoCrudBindingSource.DataMember = "Vw_EmpleadoCrud"
        Me.VwEmpleadoCrudBindingSource.DataSource = Me.MasterBDDataSet
        '
        'Vw_EmpleadoCrudTableAdapter
        '
        Me.Vw_EmpleadoCrudTableAdapter.ClearBeforeFill = True
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'CargoBindingSource1
        '
        Me.CargoBindingSource1.DataMember = "Cargo"
        Me.CargoBindingSource1.DataSource = Me.MasterBDDataSet
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.MasterBDDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'tbxCargo
        '
        Me.tbxCargo.DataSource = Me.CargoBindingSource3
        Me.tbxCargo.DisplayMember = "tipoCargo"
        Me.tbxCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCargo.FormattingEnabled = True
        Me.tbxCargo.Location = New System.Drawing.Point(507, 161)
        Me.tbxCargo.Name = "tbxCargo"
        Me.tbxCargo.Size = New System.Drawing.Size(255, 24)
        Me.tbxCargo.TabIndex = 31
        Me.tbxCargo.ValueMember = "id_Puesto"
        '
        'CargoBindingSource3
        '
        Me.CargoBindingSource3.DataMember = "Cargo"
        Me.CargoBindingSource3.DataSource = Me.MasterBDDataSet
        '
        'AdminEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 475)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "AdminEmpleado"
        Me.Text = "AdminEmpleado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DepartamentoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEmpleadoCrudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txbSeguroS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txbDireccion As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbCedula As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txbContrato As TextBox
    Friend WithEvents txbSalida As TextBox
    Friend WithEvents txbEntrada As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MasterBDDataSet As MasterBDDataSet
    Friend WithEvents VwEmpleadoCrudBindingSource As BindingSource
    Friend WithEvents Vw_EmpleadoCrudTableAdapter As MasterBDDataSetTableAdapters.Vw_EmpleadoCrudTableAdapter
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumCedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegSosINSSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxDepartamento As ComboBox
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As MasterBDDataSetTableAdapters.CargoTableAdapter
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As MasterBDDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents DepartamentoBindingSource1 As BindingSource
    Friend WithEvents CargoBindingSource1 As BindingSource
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As MasterBDDataSetTableAdapters.EmpleadoTableAdapter
    Friend WithEvents CargoBindingSource2 As BindingSource
    Friend WithEvents tbxCargo As ComboBox
    Friend WithEvents CargoBindingSource3 As BindingSource
End Class
