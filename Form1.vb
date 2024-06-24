Public Class Form1

    Private Sub btnHoroscopo_Click(sender As Object, e As EventArgs) Handles btnHoroscopo.Click
        Dim formHoroscopo As New FormHoroscopo()
        formHoroscopo.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompatibilidad_Click(sender As Object, e As EventArgs) Handles btnCompatibilidad.Click
        Dim formCompatibilidad As New FormCompatibilidad()
        formCompatibilidad.Show()
        Me.Hide()
    End Sub

    Private Sub btnNumerologia_Click(sender As Object, e As EventArgs) Handles btnNumerologia.Click
        Dim formNumerologia As New FormNumerologia()
        formNumerologia.Show()
        Me.Hide()
    End Sub

End Class
