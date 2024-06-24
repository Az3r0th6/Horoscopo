Public Class FormHoroscopo

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        ' Volver al menú principal
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnAries_Click(sender As Object, e As EventArgs) Handles btnAries.Click
        MostrarHoroscopo("Aries")
    End Sub

    Private Sub btnTauro_Click(sender As Object, e As EventArgs) Handles btnTauro.Click
        MostrarHoroscopo("Tauro")
    End Sub

    Private Sub btnGeminis_Click(sender As Object, e As EventArgs) Handles btnGeminis.Click
        MostrarHoroscopo("Géminis")
    End Sub

    Private Sub btnCancer_Click(sender As Object, e As EventArgs) Handles btnCancer.Click
        MostrarHoroscopo("Cáncer")
    End Sub

    Private Sub btnLeo_Click(sender As Object, e As EventArgs) Handles btnLeo.Click
        MostrarHoroscopo("Leo")
    End Sub

    Private Sub btnVirgo_Click(sender As Object, e As EventArgs) Handles btnVirgo.Click
        MostrarHoroscopo("Virgo")
    End Sub

    Private Sub btnLibra_Click(sender As Object, e As EventArgs) Handles btnLibra.Click
        MostrarHoroscopo("Libra")
    End Sub

    Private Sub btnEscorpio_Click(sender As Object, e As EventArgs) Handles btnEscorpio.Click
        MostrarHoroscopo("Escorpio")
    End Sub

    Private Sub btnSagitario_Click(sender As Object, e As EventArgs) Handles btnSagitario.Click
        MostrarHoroscopo("Sagitario")
    End Sub

    Private Sub btnCapricornio_Click(sender As Object, e As EventArgs) Handles btnCapricornio.Click
        MostrarHoroscopo("Capricornio")
    End Sub

    Private Sub btnAcuario_Click(sender As Object, e As EventArgs) Handles btnAcuario.Click
        MostrarHoroscopo("Acuario")
    End Sub

    Private Sub btnPiscis_Click(sender As Object, e As EventArgs) Handles btnPiscis.Click
        MostrarHoroscopo("Piscis")
    End Sub

    Private Sub MostrarHoroscopo(signo As String)
        Dim descripcion As String = ObtenerDescripcionHoroscopo(signo)
        TextBoxCompatibilidad.Text = descripcion
    End Sub

    Private Function ObtenerDescripcionHoroscopo(signo As String) As String
        ' Aquí puedes agregar las descripciones reales para cada signo
        Select Case signo
            Case "Aries"
                Return "Aries" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Aries, de todas las tareas que tienes en el radar y que sabes muy bien cómo llevar a cabo, ¡no se te puede olvidar la más importante: vivir!, pues muchas veces percibes que la rutina, la rapidez de tus acciones y el día a día te consumen. Es por esto que durante esta semana será vital que hagas un alto en el camino de manera consciente, para que respires, tomes el sol, escribas, cantes o bailes al ritmo que tu corazón te diga. Recuerda que en las pausas puedes encontrar, si sabes escuchar bien, el verdadero propósito de tu vida." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Por estos días será muy importante que le des un respiro a las expectativas que tienes ti misma, pues no hay nadie realmente que te pueda exigir más de lo que sabes hacerlo tú. La clave para vivir con pasión es llevar una maleta ligera, que te permita fluir con lo que te sucede, estando abierta a nuevos aprendizajes." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "¡No le huyas al amor! Porque cuando este llega, siempre trae cosas increíbles; es sensato que tengas temor a lo desconocido, pero encontrar a nuevas personas en el camino y dejarlas entregarte lo mejor que tienen es también una muestra del amor que te tienes a ti, pues conecta de maravilla con la energía del merecimiento divino."
            Case "Tauro"
                Return "Tauro" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Esta semana es una invitación directa para que vivas intensamente todos tus días; no importa si tu plan es ir al trabajo o salir de vacaciones con tus mejores amigas. Todo en la vida está destinado para enseñarte, regalarte magia y construir la mejor versión que tienes de ti misma. Recuerda que los años pasan de manera veloz y aunque el alma no se envejece, nunca estarás tan viva como hoy. Ya sabes que, como dice el refrán popular, no dejes para mañana lo que puedes disfrutar hoy." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Cuando conectas con el agradecimiento y dejas de buscar una explicación en todo lo que te acontece, es mucho más sencillo que logres estar en calma. ¡Sí! Todo lo que te rodea tiene un mensaje poderoso, pero no necesariamente debes correr a buscar su significado, pues las mejores cosas de la vida aparentemente pasan desapercibidas, y cuando menos te lo esperas, las respuestas las encuentras en los momentos que te tomas para conversar contigo misma." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "La recomendación más valiosa de la semana es que logres fortalecer aquellas relaciones que te nutren de emociones bonitas, te llenan de energía y sobre todo, te guíen en el proceso de hacerte las preguntas correctas. Las críticas restan, pero la sensatez con que te cuestionas aquello que sabes que es importante, siempre te multiplica."
            Case "Géminis"
                Return "Géminis" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Prepárate porque estás a punto de vivir uno de los momentos más especiales de los últimos años. La confianza en ti misma y el recordarte que mereces eso y más, serán clave para que más noticias así sigan llegándote a menudo. Vas por muy buen camino, y tu temporada lo confirmó." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Manifestar también es abrirle las puertas al Universo para que traiga no solo regalos materiales, sino también personas invaluables. No dejes nada a la suerte, amiga Géminis, toma lápiz y papel y escribe cómo sueñas a esa persona que quieres que llegue a tu vida. No tiene que ser necesariamente una pareja, puede ser un buen amigo, un jefe o una compañera de clase." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "Date un regalo a ti misma como prueba de que eres lo más importante en tu vida, que todas las decisiones que tomas están pensadas en lo que es mejor para ti y en tu bienestar. El regalo perfecto puede ser ver esa serie que tienes en pausa, pedir un domicilio delicioso y disfrutar el espacio contigo misma, no es más."
            Case "Cáncer"
                Return "Cáncer" & vbCrLf &
           "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
           "Intención de la semana" & vbCrLf &
           "Acostúmbrate a hablarte bonito más a menudo. Háblate bonito cuando te equivoques, cuando algo no pase como lo tenías planeado, cuando alguien intente hacerte sentir menos, cuando te fallen o incluso cuando te falles a ti misma. Recordarte que eres mucho más que las cosas que te pasan a diario, siempre hace la diferencia." & vbCrLf & vbCrLf &
           "Tu energía" & vbCrLf &
           "Habla que el Universo siempre está ahí para escucharte. Solo asegúrate de que las palabras que salgan de tu boca, sean prósperas, positivas y compasivas. Cambia el 'por qué' y pregúntate 'para qué', ahí está la clave." & vbCrLf & vbCrLf &
           "Conexiones del corazón" & vbCrLf &
           "A veces la felicidad está hecha de instantes, así que, si el amor llama a tu puerta, no lo dejes ir: arriésgate porque a lo mejor, termines ganando."
            Case "Leo"
                Return "Leo" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Recuerda que lo más importante en la vida es el momento presente. No te enfoques tanto en lo que vendrá o en lo que ya pasó. Vive y disfruta lo que tienes aquí y ahora." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tu energía es poderosa y magnética. Usa esa energía para atraer lo que realmente deseas. No te conformes con menos de lo que mereces." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "Abre tu corazón a nuevas posibilidades. El amor está a tu alrededor, solo necesitas estar dispuesta a verlo y aceptarlo."
            Case "Virgo"
                Return "Virgo" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Permítete ser vulnerable y aceptar que no tienes todas las respuestas. Está bien pedir ayuda y apoyarte en los demás cuando lo necesites." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tómate un tiempo para ti misma, para reflexionar y recargar energías. No te olvides de cuidar de tu bienestar emocional y mental." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "Las conexiones más fuertes se basan en la autenticidad y la honestidad. Sé tú misma y atraerás a las personas adecuadas a tu vida."
            Case "Libra"
                Return "Libra" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Busca el equilibrio en todas las áreas de tu vida. No te enfoques demasiado en un solo aspecto y descuides los demás." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tu energía es armoniosa y tranquila. Usa esa energía para crear un ambiente de paz y serenidad a tu alrededor." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "El amor verdadero es aquel que te hace sentir en equilibrio y en paz. Busca relaciones que te aporten estabilidad y armonía."
            Case "Escorpio"
                Return "Escorpio" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Deja atrás lo que ya no te sirve y abre espacio para lo nuevo. No te aferres al pasado, vive el presente y crea tu futuro." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tu energía es intensa y transformadora. Usa esa energía para hacer los cambios que necesitas en tu vida." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "El amor es un viaje de transformación. Permítete cambiar y crecer junto a la persona que amas."
            Case "Sagitario"
                Return "Sagitario" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Aventúrate y explora nuevos horizontes. No tengas miedo de salir de tu zona de confort y descubrir nuevas experiencias." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tu energía es expansiva y optimista. Usa esa energía para inspirar y motivar a los demás." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "El amor es una aventura. Disfruta del viaje y no te preocupes tanto por el destino."
            Case "Capricornio"
                Return "Capricornio" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Trabaja duro, pero no te olvides de disfrutar de los frutos de tu esfuerzo. El equilibrio entre el trabajo y la vida personal es esencial." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tu energía es disciplinada y persistente. Usa esa energía para alcanzar tus metas y lograr tus sueños." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "Las relaciones sólidas se construyen con esfuerzo y dedicación. No te rindas, el amor verdadero vale la pena."
            Case "Acuario"
                Return "Acuario" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Sé auténtica y fiel a ti misma. No te conformes con menos de lo que mereces y lucha por tus ideales." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tu energía es innovadora y visionaria. Usa esa energía para crear cambios positivos en tu vida y en el mundo." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "El amor verdadero es aquel que te acepta tal y como eres. No cambies por nadie, encuentra a alguien que te ame por tu autenticidad."
            Case "Piscis"
                Return "Piscis" & vbCrLf &
                       "Junio 17 - Junio 23, 2024" & vbCrLf & vbCrLf &
                       "Intención de la semana" & vbCrLf &
                       "Confía en tu intuición y deja que tu corazón te guíe. Las respuestas que buscas están dentro de ti." & vbCrLf & vbCrLf &
                       "Tu energía" & vbCrLf &
                       "Tu energía es compasiva y empática. Usa esa energía para ayudar y sanar a los demás." & vbCrLf & vbCrLf &
                       "Conexiones del corazón" & vbCrLf &
                       "El amor es un acto de dar y recibir. Abre tu corazón y permite que el amor fluya libremente."

            Case Else
                Return "Signo no encontrado."
        End Select
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormHoroscopo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxCompatibilidad_Click(sender As Object, e As EventArgs) Handles TextBoxCompatibilidad.Click
        Me.TextBox1.MultiLine = True
    End Sub

    Private Function TextBox1() As Object
        Throw New NotImplementedException()
    End Function
End Class
