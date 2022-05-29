Public Class GestionDep
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TxbDep.Text.Equals("") Or txbDesp.Text.Equals("") Then
            MsgBox("Rellene los campos por favor")

        Else
            Dim dataset As New MasterBDDataSetTableAdapters.DepartamentoTableAdapter
            dataset.InsertQuery(Me.TxbDep.Text, Me.txbDesp.Text, 1)
            MsgBox("Se ha agregado Correctamente")
            limpiar()
            Me.DepartamentoTableAdapter.Fill(Me.MasterBDDataSet.Departamento)
        End If



    End Sub

    Private Sub GestionDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MasterBDDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.MasterBDDataSet.Departamento)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        If TxbDep.Text.Equals("") Or txbIdDep.Text.Equals("") Or txbDesp.Text.Equals("") Then

            MsgBox("Rellene los campos por favor")
        Else

            Dim dataset As New MasterBDDataSetTableAdapters.DepartamentoTableAdapter
            dataset.UpdateQuery(Me.TxbDep.Text, Me.txbDesp.Text, 1, txbIdDep.Text)
            Me.DepartamentoTableAdapter.Fill(Me.MasterBDDataSet.Departamento)
            limpiar()
            MsgBox("Se ha actualizado Correctamente")
        End If


    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick






        Me.txbIdDep.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString()
        Me.TxbDep.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txbDesp.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString()






    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If TxbDep.Text.Equals("") Or txbIdDep.Text.Equals("") Or txbDesp.Text.Equals("") Then

            MsgBox("Rellene los campos por favor")
        Else
            Dim dataset As New MasterBDDataSetTableAdapters.DepartamentoTableAdapter
            dataset.DeletebyEstado(3, txbIdDep.Text)
            limpiar()
            Me.DepartamentoTableAdapter.Fill(Me.MasterBDDataSet.Departamento)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        txbIdDep.Text = ""
        TxbDep.Text = ""
        txbDesp.Text = ""
    End Sub
End Class