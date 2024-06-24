Public Class FormCompatibilidad
    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        ' Volver al menú principal
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub FormCompatibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar el ComboBox con los signos zodiacales
        ComboBoxSignos.Items.AddRange(New String() {"Aries", "Tauro", "Géminis", "Cáncer", "Leo", "Virgo", "Libra", "Escorpio", "Sagitario", "Capricornio", "Acuario", "Piscis"})
    End Sub

    ' Este evento se dispara cuando se hace clic en el botón de generar horóscopo
    Private Sub BntCompatibilidad_Click(sender As Object, e As EventArgs) Handles BntCompatibilidad.Click
        If ComboBoxSignos.SelectedItem IsNot Nothing Then
            Dim signo As String = ComboBoxSignos.SelectedItem.ToString()
            TextBoxCompatibilidad.Text = GenerarCompatibilidad(signo)
            TextBoxIncompatibilidad.Text = GenerarIncompatibilidad(signo)
        Else
            MessageBox.Show("Por favor, selecciona un signo zodiacal.")
        End If
    End Sub



    ' Función para generar compatibilidad
    Private Function GenerarCompatibilidad(signo As String) As String
        ' Aquí puedes agregar lógica para generar horóscopos personalizados
        ' Por ejemplo, usar un diccionario de horóscopos predefinidos
        Dim Compatibilidad As New Dictionary(Of String, String)
        Compatibilidad("Aries") = "Tauro, Géminis, Libra"
        Compatibilidad("Tauro") = "Aries, Tauro, Cáncer, Capricornio"
        Compatibilidad("Géminis") = "Aries, Géminis, Virgo, Acuario"
        Compatibilidad("Cáncer") = "Tauro, Cáncer, Virgo, Escorpio"
        Compatibilidad("Leo") = "Libra, Sagitario, Acuario"
        Compatibilidad("Virgo") = "Géminis, Cáncer, Virgo, Piscis"
        Compatibilidad("Libra") = "Aries, Leo, Libra, Sagitario"
        Compatibilidad("Escorpio") = "Cáncer, Capricornio, Piscis"
        Compatibilidad("Sagitario") = "Leo, Libra, Sagitario, Acuario"
        Compatibilidad("Capricornio") = "Tauro, Escorpio, Capricornio, Piscis"
        Compatibilidad("Acuario") = "Géminis, Leo, Sagitario, Acuario"
        Compatibilidad("Piscis") = "Virgo, Escorpio, Capricornio, Piscis"

        If Compatibilidad.ContainsKey(signo) Then
            Return Compatibilidad(signo)
        Else
            Return "Compatibilidad no disponible."
        End If
    End Function

    ' Función para generar incompatibilidad
    Private Function GenerarIncompatibilidad(signo As String) As String
    ' Aquí puedes agregar lógica para generar horóscopos personalizados
    ' Por ejemplo, usar un diccionario de horóscopos predefinidos
    Dim Incompatibilidad As New Dictionary(Of String, String)
        Incompatibilidad("Aries") = "Escorpio, Capricornio, Piscis"
        Incompatibilidad("Tauro") = "Géminis, Leo, Acuario"
        Incompatibilidad("Géminis") = "Tauro, Cáncer, Capricornio"
        Incompatibilidad("Cáncer") = "Géminis, Libra, Sagitario"
        Incompatibilidad("Leo") = "Tauro, Escorpio, Capricornio"
        Incompatibilidad("Virgo") = "Libra, Sagitario, Acuario"
        Incompatibilidad("Libra") = "Cáncer, Virgo, Piscis"
        Incompatibilidad("Escorpio") = "Aries, Leo, Sagitario"
        Incompatibilidad("Sagitario") = "Cáncer, Virgo, Escorpio"
        Incompatibilidad("Capricornio") = "Aries, Géminis, Leo"
        Incompatibilidad("Acuario") = "Tauro, Virgo, Piscis"
        Incompatibilidad("Piscis") = "Aries, Libra, Acuario"

        If Incompatibilidad.ContainsKey(signo) Then
            Return Incompatibilidad(signo)
        Else
        Return "Incompatibilidad no disponible."
    End If
End Function
End Class
