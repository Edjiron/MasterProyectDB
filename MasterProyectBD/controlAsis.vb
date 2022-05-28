Public Class controlAsis

    Dim dataset As New MasterBDDataSetTableAdapters.JornadaTableAdapter


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim b As String = DateTime.Now.ToString("hh: mm : ss")
        Dim a As String = DateTime.Now.ToString("MM/dd/yy")






        dataset.InsertQuery(1, a, b, b, txbID.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dataset As New MasterBDDataSetTableAdapters.JornadaTableAdapter
        Dim b As String = DateTime.Now.ToString("hh: mm : ss")
        dataset.SalidaQuery(b, txbID.Text)
    End Sub
End Class