Public Class Form1
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim dataSet As New seguridadDataSetTableAdapters.tbl_usuarioTableAdapter



        Try
            dataSet.GetDataBy1(txbUsuario.Text, txbClave.Text)


        Catch ex As Exception
            MsgBox("Bienvenido " + dataSet.ScalarQuery(txbUsuario.Text))


        End Try





    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As New controlAsis()
        a.Show()
    End Sub
End Class
