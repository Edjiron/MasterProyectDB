Imports System.Data.SqlClient

Public Class AdminEmpleado
    Private Sub AdminEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.MasterBDDataSet.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.MasterBDDataSet.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.MasterBDDataSet.Cargo)
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Vw_EmpleadoCrud' Puede moverla o quitarla según sea necesario.
        Me.Vw_EmpleadoCrudTableAdapter.Fill(Me.MasterBDDataSet.Vw_EmpleadoCrud)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            If Me.txbNombre.Text.Equals("") Or Me.txbEntrada.Text.Equals("") Or Me.txbSalida.Text.Equals("") Or
                  Me.txbContrato.Text.Equals("") Or Me.txbCedula.Text.Equals("") Or Me.txbTelefono.Text.Equals("") Or
                     Me.txbEmail.Text.Equals("") Or Me.txbDireccion.Text.Equals("") Or
                      Me.txbSeguroS.Text.Equals("") Or Me.tbxCargo.SelectedValue < 0 Then

                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            Else
                Dim tbluser As New MasterBDDataSetTableAdapters.EmpleadoTableAdapter
                tbluser.InsertQuery(Me.txbNombre.Text, Me.txbEntrada.Text, Me.txbSalida.Text, 1, Me.txbContrato.Text, Me.txbCedula.Text, Me.txbTelefono.Text, Me.txbEmail.Text, Me.txbDireccion.Text, Me.txbSeguroS.Text, tbxDepartamento.SelectedValue, tbxCargo.SelectedValue)
                MessageBox.Show("El Registro se ha guardado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Vw_EmpleadoCrudTableAdapter.Fill(Me.MasterBDDataSet.Vw_EmpleadoCrud)
                limpiar()

            End If



        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            If Me.txbNombre.Text.Equals("") Or Me.txbEntrada.Text.Equals("") Or Me.txbSalida.Text.Equals("") Or
                  Me.txbContrato.Text.Equals("") Or Me.txbCedula.Text.Equals("") Or Me.txbTelefono.Text.Equals("") Or
                     Me.txbEmail.Text.Equals("") Or Me.txbDireccion.Text.Equals("") Or
                      Me.txbSeguroS.Text.Equals("") Or Me.tbxCargo.SelectedValue < 0 Then

                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            Else
                Dim tbluser As New MasterBDDataSetTableAdapters.EmpleadoTableAdapter
                tbluser.UpdateQuery(Me.txbNombre.Text, Me.txbEntrada.Text, Me.txbSalida.Text, 1, Me.txbContrato.Text, Me.txbCedula.Text, Me.txbTelefono.Text, Me.txbEmail.Text, Me.txbDireccion.Text, Me.txbSeguroS.Text, 1, 1, Convert.ToInt32(TextBox3.Text))
                MessageBox.Show("El Registro se ha modificado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Vw_EmpleadoCrudTableAdapter.Fill(Me.MasterBDDataSet.Vw_EmpleadoCrud)
                limpiar()
            End If



        Catch sqlEx As SqlException
            MsgBox("Error al actualizar al empleado: ", sqlEx.Message())
            MsgBox("Error al actualizar al emplead0: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al empleado: ", ex.Message())
            MsgBox("Error al registrar al empleado: ", ex.StackTrace())

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If Me.txbNombre.Text.Equals("") Or Me.txbEntrada.Text.Equals("") Or Me.txbSalida.Text.Equals("") Or
                  Me.txbContrato.Text.Equals("") Or Me.txbCedula.Text.Equals("") Or Me.txbTelefono.Text.Equals("") Or
                     Me.txbEmail.Text.Equals("") Or Me.txbDireccion.Text.Equals("") Or
                      Me.txbSeguroS.Text.Equals("") Or Me.tbxCargo.SelectedValue < 0 Then

                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            Else
                Dim dataset As New MasterBDDataSetTableAdapters.EmpleadoTableAdapter
                dataset.UpdateQuery1(3, TextBox3.Text)
                Me.Vw_EmpleadoCrudTableAdapter.Fill(Me.MasterBDDataSet.Vw_EmpleadoCrud)
                limpiar()

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






        Me.TextBox3.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txbNombre.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txbEntrada.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString()
        Me.txbSalida.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString()
        Me.txbContrato.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString()
        Me.txbCedula.Text = DataGridView1.CurrentRow.Cells.Item(5).Value.ToString()
        Me.txbTelefono.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString()
        Me.txbEmail.Text = DataGridView1.CurrentRow.Cells.Item(7).Value.ToString()
        Me.txbDireccion.Text = DataGridView1.CurrentRow.Cells.Item(8).Value.ToString()
        Me.txbSeguroS.Text = DataGridView1.CurrentRow.Cells.Item(9).Value.ToString()

    End Sub

    Private Sub limpiar()
        Me.TextBox3.Text = ""
        Me.txbNombre.Text = ""
        Me.txbEntrada.Text = ""
        Me.txbSalida.Text = ""
        Me.txbContrato.Text = ""
        Me.txbCedula.Text = ""
        Me.txbTelefono.Text = ""
        Me.txbEmail.Text = ""
        Me.txbDireccion.Text = ""
        Me.txbSeguroS.Text = ""
        Me.tbxCargo.SelectedIndex = -1
        Me.tbxDepartamento.SelectedIndex = -1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CargoTableAdapter.FillBy(Me.MasterBDDataSet.Cargo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class