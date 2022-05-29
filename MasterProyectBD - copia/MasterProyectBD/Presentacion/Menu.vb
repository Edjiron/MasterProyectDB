Public Class Menu
    Private Sub AdministarPermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministarPermisoToolStripMenuItem.Click

        Dim a As New adminPermisos()
        a.Show()
        Me.Hide()
    End Sub

    Private Sub GestionarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarDepartamentoToolStripMenuItem.Click
        Dim a As New GestionDep()
        a.Show()
        Me.Hide()
    End Sub

    Private Sub GestionarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarEmpleadoToolStripMenuItem.Click

        Dim a As New AdminEmpleado()
        a.Show()
        Me.Hide()
    End Sub
End Class