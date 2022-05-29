<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPermisos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cbxDep = New System.Windows.Forms.ComboBox()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterBDDataSet = New MasterProyectBD.MasterBDDataSet()
        Me.txbIdMotivo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbfinal = New System.Windows.Forms.TextBox()
        Me.txbInicio = New System.Windows.Forms.TextBox()
        Me.txbMotivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartamentoTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.DepartamentoTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PermisoBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPermiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPermisosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPermisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_PermisosTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.Vw_PermisosTableAdapter()
        Me.PermisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.PermisoTableAdapter()
        Me.VwPermisosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPermisosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwEmpleadoCrudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_EmpleadoCrudTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.Vw_EmpleadoCrudTableAdapter()
        Me.VwPermisosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPermiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_PermiTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.vw_PermiTableAdapter()
        Me.SeguridadDataSet = New MasterProyectBD.seguridadDataSet()
        Me.SeguridadDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorarioTableAdapter = New MasterProyectBD.MasterBDDataSetTableAdapters.HorarioTableAdapter()
        Me.VwPermisosBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisoBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.id_Permiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaInPermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaOffInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivoPermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tbxbuscar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermisosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermisosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermisosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEmpleadoCrudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermisosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPermisosBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tbxbuscar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.cbxDep)
        Me.GroupBox1.Controls.Add(Me.txbIdMotivo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txbfinal)
        Me.GroupBox1.Controls.Add(Me.txbInicio)
        Me.GroupBox1.Controls.Add(Me.txbMotivo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 275)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario"
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(390, 32)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(82, 31)
        Me.btnNuevo.TabIndex = 21
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cbxDep
        '
        Me.cbxDep.DataSource = Me.DepartamentoBindingSource
        Me.cbxDep.DisplayMember = "nombreDep"
        Me.cbxDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDep.FormattingEnabled = True
        Me.cbxDep.Location = New System.Drawing.Point(131, 202)
        Me.cbxDep.Name = "cbxDep"
        Me.cbxDep.Size = New System.Drawing.Size(255, 24)
        Me.cbxDep.TabIndex = 20
        Me.cbxDep.ValueMember = "id_Dep"
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.MasterBDDataSet
        '
        'MasterBDDataSet
        '
        Me.MasterBDDataSet.DataSetName = "MasterBDDataSet"
        Me.MasterBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txbIdMotivo
        '
        Me.txbIdMotivo.Location = New System.Drawing.Point(131, 26)
        Me.txbIdMotivo.Name = "txbIdMotivo"
        Me.txbIdMotivo.ReadOnly = True
        Me.txbIdMotivo.Size = New System.Drawing.Size(63, 26)
        Me.txbIdMotivo.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Id:"
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(694, 32)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 31)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(594, 32)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(82, 31)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(493, 32)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(82, 31)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Departamento:"
        '
        'txbfinal
        '
        Me.txbfinal.Location = New System.Drawing.Point(131, 157)
        Me.txbfinal.Name = "txbfinal"
        Me.txbfinal.Size = New System.Drawing.Size(238, 26)
        Me.txbfinal.TabIndex = 6
        '
        'txbInicio
        '
        Me.txbInicio.Location = New System.Drawing.Point(131, 112)
        Me.txbInicio.Name = "txbInicio"
        Me.txbInicio.Size = New System.Drawing.Size(238, 26)
        Me.txbInicio.TabIndex = 5
        '
        'txbMotivo
        '
        Me.txbMotivo.Location = New System.Drawing.Point(131, 67)
        Me.txbMotivo.Name = "txbMotivo"
        Me.txbMotivo.Size = New System.Drawing.Size(238, 26)
        Me.txbMotivo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Final del permiso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicio del permiso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "motivo:"
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Permiso, Me.fechaInPermiso, Me.fechaOffInicio, Me.motivoPermiso})
        Me.DataGridView1.DataSource = Me.PermisoBindingSource8
        Me.DataGridView1.Location = New System.Drawing.Point(23, 318)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(461, 137)
        Me.DataGridView1.TabIndex = 2
        '
        'PermisoBindingSource6
        '
        Me.PermisoBindingSource6.DataMember = "Permiso"
        Me.PermisoBindingSource6.DataSource = Me.MasterBDDataSet
        '
        'VwPermiBindingSource1
        '
        Me.VwPermiBindingSource1.DataMember = "vw_Permi"
        Me.VwPermiBindingSource1.DataSource = Me.MasterBDDataSet
        '
        'VwPermisosBindingSource4
        '
        Me.VwPermisosBindingSource4.DataMember = "Vw_Permisos"
        Me.VwPermisosBindingSource4.DataSource = Me.MasterBDDataSet
        '
        'VwPermisosBindingSource
        '
        Me.VwPermisosBindingSource.DataMember = "Vw_Permisos"
        Me.VwPermisosBindingSource.DataSource = Me.MasterBDDataSet
        '
        'Vw_PermisosTableAdapter
        '
        Me.Vw_PermisosTableAdapter.ClearBeforeFill = True
        '
        'PermisoBindingSource
        '
        Me.PermisoBindingSource.DataMember = "Permiso"
        Me.PermisoBindingSource.DataSource = Me.MasterBDDataSet
        '
        'PermisoTableAdapter
        '
        Me.PermisoTableAdapter.ClearBeforeFill = True
        '
        'VwPermisosBindingSource1
        '
        Me.VwPermisosBindingSource1.DataMember = "Vw_Permisos"
        Me.VwPermisosBindingSource1.DataSource = Me.MasterBDDataSet
        '
        'VwPermisosBindingSource2
        '
        Me.VwPermisosBindingSource2.DataMember = "Vw_Permisos"
        Me.VwPermisosBindingSource2.DataSource = Me.MasterBDDataSet
        '
        'PermisoBindingSource1
        '
        Me.PermisoBindingSource1.DataMember = "Permiso"
        Me.PermisoBindingSource1.DataSource = Me.MasterBDDataSet
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
        'VwPermisosBindingSource3
        '
        Me.VwPermisosBindingSource3.DataMember = "Vw_Permisos"
        Me.VwPermisosBindingSource3.DataSource = Me.MasterBDDataSet
        '
        'VwPermiBindingSource
        '
        Me.VwPermiBindingSource.DataMember = "vw_Permi"
        Me.VwPermiBindingSource.DataSource = Me.MasterBDDataSet
        '
        'Vw_PermiTableAdapter
        '
        Me.Vw_PermiTableAdapter.ClearBeforeFill = True
        '
        'SeguridadDataSet
        '
        Me.SeguridadDataSet.DataSetName = "seguridadDataSet"
        Me.SeguridadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeguridadDataSetBindingSource
        '
        Me.SeguridadDataSetBindingSource.DataSource = Me.SeguridadDataSet
        Me.SeguridadDataSetBindingSource.Position = 0
        '
        'PermisoBindingSource2
        '
        Me.PermisoBindingSource2.DataMember = "Permiso"
        Me.PermisoBindingSource2.DataSource = Me.MasterBDDataSet
        '
        'PermisoBindingSource3
        '
        Me.PermisoBindingSource3.DataMember = "Permiso"
        Me.PermisoBindingSource3.DataSource = Me.MasterBDDataSet
        '
        'HorarioBindingSource
        '
        Me.HorarioBindingSource.DataMember = "Horario"
        Me.HorarioBindingSource.DataSource = Me.MasterBDDataSet
        '
        'HorarioTableAdapter
        '
        Me.HorarioTableAdapter.ClearBeforeFill = True
        '
        'VwPermisosBindingSource5
        '
        Me.VwPermisosBindingSource5.DataMember = "Vw_Permisos"
        Me.VwPermisosBindingSource5.DataSource = Me.MasterBDDataSet
        '
        'PermisoBindingSource4
        '
        Me.PermisoBindingSource4.DataMember = "Permiso"
        Me.PermisoBindingSource4.DataSource = Me.MasterBDDataSet
        '
        'PermisoBindingSource5
        '
        Me.PermisoBindingSource5.DataMember = "Permiso"
        Me.PermisoBindingSource5.DataSource = Me.MasterBDDataSet
        '
        'PermisoBindingSource7
        '
        Me.PermisoBindingSource7.DataMember = "Permiso"
        Me.PermisoBindingSource7.DataSource = Me.MasterBDDataSet
        '
        'PermisoBindingSource8
        '
        Me.PermisoBindingSource8.DataMember = "Permiso"
        Me.PermisoBindingSource8.DataSource = Me.MasterBDDataSet
        '
        'id_Permiso
        '
        Me.id_Permiso.DataPropertyName = "id_Permiso"
        Me.id_Permiso.HeaderText = "id_Permiso"
        Me.id_Permiso.Name = "id_Permiso"
        Me.id_Permiso.ReadOnly = True
        '
        'fechaInPermiso
        '
        Me.fechaInPermiso.DataPropertyName = "fechaInPermiso"
        Me.fechaInPermiso.HeaderText = "fechaInPermiso"
        Me.fechaInPermiso.Name = "fechaInPermiso"
        Me.fechaInPermiso.ReadOnly = True
        '
        'fechaOffInicio
        '
        Me.fechaOffInicio.DataPropertyName = "fechaOffInicio"
        Me.fechaOffInicio.HeaderText = "fechaOffInicio"
        Me.fechaOffInicio.Name = "fechaOffInicio"
        Me.fechaOffInicio.ReadOnly = True
        '
        'motivoPermiso
        '
        Me.motivoPermiso.DataPropertyName = "motivoPermiso"
        Me.motivoPermiso.HeaderText = "motivoPermiso"
        Me.motivoPermiso.Name = "motivoPermiso"
        Me.motivoPermiso.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tbxbuscar
        '
        Me.Tbxbuscar.Location = New System.Drawing.Point(131, 243)
        Me.Tbxbuscar.Name = "Tbxbuscar"
        Me.Tbxbuscar.Size = New System.Drawing.Size(238, 26)
        Me.Tbxbuscar.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Buscar:"
        '
        'adminPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "adminPermisos"
        Me.Text = "adminPermisos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermisosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermisosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermisosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEmpleadoCrudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermisosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPermisosBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbxDep As ComboBox
    Friend WithEvents txbIdMotivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txbfinal As TextBox
    Friend WithEvents txbInicio As TextBox
    Friend WithEvents txbMotivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MasterBDDataSet As MasterBDDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As MasterBDDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VwPermisosBindingSource As BindingSource
    Friend WithEvents Vw_PermisosTableAdapter As MasterBDDataSetTableAdapters.Vw_PermisosTableAdapter
    Friend WithEvents PermisoBindingSource As BindingSource
    Friend WithEvents PermisoTableAdapter As MasterBDDataSetTableAdapters.PermisoTableAdapter
    Friend WithEvents PermisoBindingSource1 As BindingSource
    Friend WithEvents VwPermisosBindingSource1 As BindingSource
    Friend WithEvents VwPermisosBindingSource2 As BindingSource
    Friend WithEvents VwEmpleadoCrudBindingSource As BindingSource
    Friend WithEvents Vw_EmpleadoCrudTableAdapter As MasterBDDataSetTableAdapters.Vw_EmpleadoCrudTableAdapter
    Friend WithEvents VwPermisosBindingSource4 As BindingSource
    Friend WithEvents VwPermisosBindingSource3 As BindingSource
    Friend WithEvents VwPermiBindingSource As BindingSource
    Friend WithEvents Vw_PermiTableAdapter As MasterBDDataSetTableAdapters.vw_PermiTableAdapter
    Friend WithEvents VwPermiBindingSource1 As BindingSource
    Friend WithEvents SeguridadDataSet As seguridadDataSet
    Friend WithEvents SeguridadDataSetBindingSource As BindingSource
    Friend WithEvents PermisoBindingSource3 As BindingSource
    Friend WithEvents PermisoBindingSource2 As BindingSource
    Friend WithEvents HorarioBindingSource As BindingSource
    Friend WithEvents HorarioTableAdapter As MasterBDDataSetTableAdapters.HorarioTableAdapter
    Friend WithEvents VwPermisosBindingSource5 As BindingSource
    Friend WithEvents PermisoBindingSource6 As BindingSource
    Friend WithEvents PermisoBindingSource4 As BindingSource
    Friend WithEvents PermisoBindingSource5 As BindingSource
    Friend WithEvents PermisoBindingSource8 As BindingSource
    Friend WithEvents PermisoBindingSource7 As BindingSource
    Friend WithEvents id_Permiso As DataGridViewTextBoxColumn
    Friend WithEvents fechaInPermiso As DataGridViewTextBoxColumn
    Friend WithEvents fechaOffInicio As DataGridViewTextBoxColumn
    Friend WithEvents motivoPermiso As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Tbxbuscar As TextBox
End Class
