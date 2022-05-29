Imports System.Data.SqlClient

Public Class adminPermisos
    Private Sub adminPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Horario' Puede moverla o quitarla según sea necesario.
        Me.HorarioTableAdapter.Fill(Me.MasterBDDataSet.Horario)
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.vw_Permi' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Vw_EmpleadoCrud' Puede moverla o quitarla según sea necesario.
        Me.Vw_EmpleadoCrudTableAdapter.Fill(Me.MasterBDDataSet.Vw_EmpleadoCrud)
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Permiso' Puede moverla o quitarla según sea necesario.
        Me.PermisoTableAdapter.Fill(Me.MasterBDDataSet.Permiso)
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Vw_Permisos' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.MasterBDDataSet.Departamento)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        Try

            If txbMotivo.Text.Equals("") Or txbInicio.Text.Equals("") Or txbfinal.Equals("") Or cbxDep.SelectedValue < 0 Then

                MessageBox.Show("RELLENE TODOS LOS CAMPOS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim dataset As New MasterBDDataSetTableAdapters.PermisoTableAdapter

                dataset.InsertQuery(1, cbxDep.SelectedValue, 1, txbInicio.Text, txbfinal.Text, txbMotivo.Text)
                Me.PermisoTableAdapter.Fill(Me.MasterBDDataSet.Permiso)
                MessageBox.Show("Se agrego correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Limpiar()
            End If


        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try








    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        Limpiar()
    End Sub

    Public Sub Limpiar()
        Me.txbMotivo.Text = ""
        Me.txbInicio.Text = ""
        Me.txbfinal.Text = ""
        Me.cbxDep.SelectedIndex = -1
        Me.txbIdMotivo.Text = ""
        Me.Tbxbuscar.Text = ""
        Me.PermisoTableAdapter.Fill(Me.MasterBDDataSet.Permiso)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Try

            If txbMotivo.Text.Equals("") Or txbInicio.Text.Equals("") Or txbfinal.Equals("") Or cbxDep.SelectedValue < 0 Then

                MessageBox.Show("RELLENE TODOS LOS CAMPOS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                Dim dataset As New MasterBDDataSetTableAdapters.PermisoTableAdapter
                dataset.UpdateQuery(txbInicio.Text, txbfinal.Text, txbMotivo.Text, txbIdMotivo.Text)
                Me.PermisoTableAdapter.Fill(Me.MasterBDDataSet.Permiso)
                MessageBox.Show("Se edito correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Limpiar()


            End If


        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try


    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick






        Me.txbIdMotivo.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txbMotivo.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txbInicio.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString()
        Me.txbfinal.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString()





    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            If txbIdMotivo.Text.Equals("") Or txbMotivo.Text.Equals("") Or txbInicio.Text.Equals("") Or txbfinal.Equals("") Or cbxDep.SelectedValue < 0 Then

                MessageBox.Show("RELLENE TODOS LOS CAMPOS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else



                Dim dataset As New MasterBDDataSetTableAdapters.PermisoTableAdapter

                dataset.DeletebyEstado(3, txbIdMotivo.Text)
                Me.PermisoTableAdapter.Fill(Me.MasterBDDataSet.Permiso)
                MessageBox.Show("Se elimino Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Limpiar()


                End If




        Catch ex As Exception
            MsgBox("Error al eliminar: ", ex.Message())
            MsgBox("Error al eliminar ", ex.StackTrace())

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As New Menu()
        a.show()
        Me.Hide()
    End Sub

    Private Sub txbBuscar_TextChanged(sender As Object, e As EventArgs) Handles Tbxbuscar.TextChanged
        Try
            Me.DataGridView1.DataSource = Me.PermisoTableAdapter.GetDataBy3(Tbxbuscar.Text)

        Catch ex As Exception
            MsgBox("Error valor nulo")
        End Try


    End Sub

End Class