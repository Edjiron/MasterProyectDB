Public Class Form1


    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim dataSet As New seguridadDataSetTableAdapters.tbl_usuarioTableAdapter



        If txbUsuario.Text.Equals("") Or txbClave.Text().Equals("") Then
            MsgBox("Por favor rellene los campos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information)


        Else
            Try
                dataSet.GetDataBy1(txbUsuario.Text, txbClave.Text)
                MsgBox("Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception
                MsgBox("Bienvenido " + dataSet.ScalarQuery(txbUsuario.Text), MessageBoxButtons.OK, MessageBoxIcon.Error)

                Dim a As New Menu()
                a.Show()
                Me.Hide()


            End Try


        End If





    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As New controlAsis()
        Me.Hide()
        a.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim co As New controlAsis
        Hide()
        co.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim a As New adminPermisos
        a.Show()
    End Sub
End Class
