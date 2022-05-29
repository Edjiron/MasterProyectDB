<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministarPermisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionRolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionOpcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptListaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RptfichaUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.EditarToolStripMenuItem, Me.AdministarToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarEmpleadoToolStripMenuItem, Me.GestionarDepartamentoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'GestionarEmpleadoToolStripMenuItem
        '
        Me.GestionarEmpleadoToolStripMenuItem.Name = "GestionarEmpleadoToolStripMenuItem"
        Me.GestionarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionarEmpleadoToolStripMenuItem.Text = "Gestionar empleado"
        '
        'GestionarDepartamentoToolStripMenuItem
        '
        Me.GestionarDepartamentoToolStripMenuItem.Name = "GestionarDepartamentoToolStripMenuItem"
        Me.GestionarDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionarDepartamentoToolStripMenuItem.Text = "Gestionar departamento"
        '
        'AdministarToolStripMenuItem
        '
        Me.AdministarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministarPermisoToolStripMenuItem, Me.AToolStripMenuItem})
        Me.AdministarToolStripMenuItem.Name = "AdministarToolStripMenuItem"
        Me.AdministarToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AdministarToolStripMenuItem.Text = "Administar"
        '
        'AdministarPermisoToolStripMenuItem
        '
        Me.AdministarPermisoToolStripMenuItem.Name = "AdministarPermisoToolStripMenuItem"
        Me.AdministarPermisoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministarPermisoToolStripMenuItem.Text = "Administrar permiso"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AToolStripMenuItem.Text = "Administrar vacaciones"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionUsuarioToolStripMenuItem, Me.GestionRolToolStripMenuItem, Me.GestionOpcionToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'GestionUsuarioToolStripMenuItem
        '
        Me.GestionUsuarioToolStripMenuItem.Name = "GestionUsuarioToolStripMenuItem"
        Me.GestionUsuarioToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GestionUsuarioToolStripMenuItem.Text = "Gestion usuario"
        '
        'GestionRolToolStripMenuItem
        '
        Me.GestionRolToolStripMenuItem.Name = "GestionRolToolStripMenuItem"
        Me.GestionRolToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GestionRolToolStripMenuItem.Text = "Gestion rol"
        '
        'GestionOpcionToolStripMenuItem
        '
        Me.GestionOpcionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AsignarToolStripMenuItem})
        Me.GestionOpcionToolStripMenuItem.Name = "GestionOpcionToolStripMenuItem"
        Me.GestionOpcionToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GestionOpcionToolStripMenuItem.Text = "Gestion opcion"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AsignarToolStripMenuItem
        '
        Me.AsignarToolStripMenuItem.Name = "AsignarToolStripMenuItem"
        Me.AsignarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AsignarToolStripMenuItem.Text = "Asignar"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RptUsuarioToolStripMenuItem, Me.RptListaDeToolStripMenuItem, Me.RptToolStripMenuItem, Me.RptfichaUsuariosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'RptUsuarioToolStripMenuItem
        '
        Me.RptUsuarioToolStripMenuItem.Name = "RptUsuarioToolStripMenuItem"
        Me.RptUsuarioToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RptUsuarioToolStripMenuItem.Text = "Rpt-Usuario"
        '
        'RptListaDeToolStripMenuItem
        '
        Me.RptListaDeToolStripMenuItem.Name = "RptListaDeToolStripMenuItem"
        Me.RptListaDeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RptListaDeToolStripMenuItem.Text = "Rpt-permisos"
        '
        'RptToolStripMenuItem
        '
        Me.RptToolStripMenuItem.Name = "RptToolStripMenuItem"
        Me.RptToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RptToolStripMenuItem.Text = "Rpt-puestos"
        '
        'RptfichaUsuariosToolStripMenuItem
        '
        Me.RptfichaUsuariosToolStripMenuItem.Name = "RptfichaUsuariosToolStripMenuItem"
        Me.RptfichaUsuariosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RptfichaUsuariosToolStripMenuItem.Text = "Rpt-ficha usuarios"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministarPermisoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionRolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionOpcionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RptUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RptListaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RptfichaUsuariosToolStripMenuItem As ToolStripMenuItem
End Class
