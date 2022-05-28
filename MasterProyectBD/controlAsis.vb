Public Class controlAsis



    Dim dataset As New MasterBDDataSetTableAdapters.JornadaTableAdapter




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If txbID.Text.Equals("") Then
                MsgBox("Por favor rellene los campos")
                txbID.Text = ""

            Else
                Dim datasetS As New MasterBDDataSetTableAdapters.EmpleadoTableAdapter
                Dim b As String = DateTime.Now.ToString("hh:mm:s")
                Dim a As String = DateTime.Now.ToString("MM/dd/yy")
                dataset.InsertQuery(1, a, b, 0, txbID.Text)
                MsgBox("Bienvenido" + datasetS.SaludoQuery(txbID.Text))
            End If
        Catch ex As Exception
            MsgBox("El Id ingresado no es valido. intente nuevamente")
            txbID.Text = ""
        End Try






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try
            If txbID.Text.Equals("") Then
                MsgBox("Por favor rellene los campos")
                txbID.Text = ""

            Else

                Dim dataset As New MasterBDDataSetTableAdapters.JornadaTableAdapter


                Dim b As String = DateTime.Now.ToString("hh:mm:s")
                Dim datasetS As New MasterBDDataSetTableAdapters.EmpleadoTableAdapter
                dataset.SalidaQuery(b, txbID.Text)

                MsgBox("Adios " + datasetS.SaludoQuery(txbID.Text))

            End If
        Catch ex As Exception
            MsgBox("El Id ingresado no es valido. intente nuevamente")
            txbID.Text = ""
        End Try


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub controlAsis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Label2.Text = DateTime.Now
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As New Form1
        a.Show()
        Me.Hide()
    End Sub
End Class