Imports Windows.Win32

Public Class FormNumerologia

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        ' Volver al menú principal
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub FormNumerologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar los ComboBoxes con valores de día, mes y año
        ' ComboBox de Día (1 al 31)
        For i As Integer = 1 To 31
            boxdia.Items.Add(i.ToString())
        Next

        ' ComboBox de Mes (Enero a Diciembre)
        Dim meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        boxmes.Items.AddRange(meses)

        ' ComboBox de Año (opcionalmente puedes definir un rango de años)
        ' Por ejemplo, desde 1900 hasta el año actual
        Dim añoActual As Integer = DateTime.Now.Year
        For i As Integer = 1900 To añoActual
            boxaño.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Validar que se hayan seleccionado día, mes y año
        If boxdia.SelectedItem IsNot Nothing AndAlso boxmes.SelectedItem IsNot Nothing AndAlso boxaño.SelectedItem IsNot Nothing Then
            ' Obtener los valores seleccionados
            Dim dia As Integer = Integer.Parse(boxdia.SelectedItem.ToString())
            Dim mes As Integer = boxmes.SelectedIndex + 1 ' Sumar 1 porque el índice comienza en 0
            Dim año As Integer = Integer.Parse(boxaño.SelectedItem.ToString())

            ' Calcular el número de vida
            Dim numeroVida As Integer = CalcularNumeroVida(dia, mes, año)

            ' Mostrar el número de vida en el TextBox
            TextNumerologia.Text = numeroVida.ToString()

            ' Obtener la descripción del número de vida
            Dim descripcion As String = ObtenerDescripcionNumero(numeroVida)
            Textdescripsion.Text = descripcion
        Else
            MessageBox.Show("Por favor, selecciona una fecha completa.")
        End If
    End Sub


    Private Function CalcularNumeroVida(dia As Integer, mes As Integer, año As Integer) As Integer
        ' Sumar todos los dígitos de la fecha de nacimiento y reducir a una sola cifra
        Dim sumaTotal As Integer = dia + mes + SumarDigitos(año)

        ' Reducir a una sola cifra si es necesario
        While sumaTotal > 9
            sumaTotal = SumarDigitos(sumaTotal)
        End While

        Return sumaTotal
    End Function

    Private Function SumarDigitos(numero As Integer) As Integer
        Dim suma As Integer = 0

        While numero > 0
            suma += numero Mod 10
            numero \= 10
        End While

        Return suma
    End Function

    Private Function ObtenerDescripcionNumero(numero As Integer) As String
        Select Case numero
            Case 1
                Return "El número uno" & vbCrLf &
                       "Representa la prioridad, el comienzo de todas las cosas. Las personas regidas por él han nacido para liderar, van por delante, tienen el empuje y la voluntad para innovar, para crear. Necesitan armarse de valor y esforzarse por avanzar hacia nuevos campos de expresión, como un pionero. Es un buen ejecutivo, trabaja mejor solo y por lo general se muestra eficiente y bien organizado. Se desenvuelve bien en cualquier situación y suele gustarle los deportes y el atletismo. Con un espíritu competitivo y una mente resuelta y decidida, disfruta con la emoción de la victoria y se pone siempre a la cabeza de los grupos. Tiene tanto vigor físico y mental que siempre está proponiéndose grandes logros y empresas a la altura de sus expectativas. Los grandes desafíos y las nuevas ideas lo subyugan. Pero desea con tanta fuerza el éxito que soporta mal el fracaso cuando llega. De ahí que su aspecto negativo esté ligado al egocentrismo. Aspira a ser el centro de atención y tiene condiciones para conseguirlo si evita la arrogancia, la jactancia y la pereza." & vbCrLf &
                      "Predicción: este período será ideal para asumir el puesto de líder que tu naturaleza posee. La suerte llegará sin falta y deberás permanecer atento a las oportunidades que se presenten. Vivirás grandes transformaciones en varios aspectos. El dinero será la recompensa por el trabajo bien hecho y es posible que encuentres nuevas fuentes de ingreso. Cerrarás un ciclo en el desarrollo de tu carrera o profesión para iniciar una nueva etapa de crecimiento y expansión. Posibilidad de dar luz a nuevos proyectos que surgirán de manera inesperada. Pelearás por un sentimiento intenso y profundo para que tu relación de pareja tenga futuro."
            Case 2
                Return "El número dos" & vbCrLf &
                      "La misión para el número dos es convertirse en un buen mediador, más por la persuasión que por la fuerza. Pacifista por naturaleza, su principal cualidad es la diplomacia y la equidad. Es común que se presenten en tu vida situaciones sobre conflictos ajenos en donde buscarás la concordia. Es el más sensible y sutil, tu tendencia es la reserva, prefiriendo permanecer en la sombra. No te importa seguir los pasos de otro que lidera siempre que estés de acuerdo con su proceder. Encontrarás las lecciones que debes aprender durante el curso de tu vida en las asociaciones y los grupos, de esta manera te resultará fácil conseguir el éxito. Meditativo, de reflexionar y analizar todo con detenimiento, pero también afectivo y sentimental. Hay cierta dualidad en la personalidad del número dos: tímido y sensible y a su vez su romanticismo no llega a su cuenta corriente: para su tranquilidad emocional necesita sentirse seguro económicamente. Buen amigo: siempre estará sin vacilar al lado de quien la necesite." & vbCrLf &
                      "Predicción: sensible y solidario, sentirás una enorme necesidad de ayudar a los demás. Sólo deberás permanecer atento para no lastimarte ni desilusionarte fácilmente. En el trabajo podrás destacarte por tu capacidad de concentración y dedicación incondicional. El ámbito financiero se beneficia con tu intuición que te guiará a la hora de tomar decisiones importantes. Las asociaciones comerciales crecerán y traerán grandes satisfacciones. Todo tipo de unión afectiva estará favorecida en este tiempo y vivirás momentos de mucha alegría. Procura moderar los celos y el afán de controlar todo."
            Case 3
                Return "El número tres" & vbCrLf &
                       "Es optimista, creativo y, tengas la edad que tengas, siempre estarás ligado a la juventud y la alegría de vivir. Es el número más dinámico, capaz de llevar adelante varios asuntos a la vez y sacar provecho de las situaciones más inesperadas, transformando todo a su favor como un verdadero malabarista existencial. De sobresalir en las tareas intelectuales, artísticas y creativas; necesita expresar, manifestarse, interactuar y ver los resultados de su trabajo. Tu función en la vida es proporcionar alegría y cultivar el buen humor. Tu personalidad plena de entusiasmo e imaginación podría caer en la superficialidad, el exceso y la indolencia, tendencias que deberás moderar. La facilidad para comunica y el brillo intelectual te hacen destacar ya que el 3 combina la osadía del 1 con la cautela del 2. Se trata de un número de autoexpresión y libertad, destinando sus energías a conquistarlas. Deberás prestar atención a no dispersarte, evitar la rutina, especializarte y dedicarte a actividades de tipo artístico, comunicacional o inventivo." & vbCrLf &
                       "Predicción: desearás fervientemente ser reconocido por tus esfuerzos. Será oportuno pensar en realizar cursos de perfeccionamiento o todo aquello que te permita avanzar en tu carrera. Los resultados podrás percibirlos con el tiempo, ahora será necesario realizar un ajuste en tus cuentas y evitar gastos innecesarios. De este modo lograrás alcanzar una posición más sólida y tranquila. Durante esta etapa, tendrás la posibilidad de desplegar tus aptitudes artísticas y descubrir nuevos caminos de expresión, ya que tu aspecto creativo estará acentuado. Contarás con el apoyo y la anuencia de personas que respetas y admiras mucho. Para el amor será un tiempo revelador en el que descubrirás tus verdaderos deseos y necesidades afectivas."
            Case 4
                Return " El número cuatro" & vbCrLf &
                        "Es todo pragmatismo y sentido común. Trabajarás arduamente y desarrollarás grandes proyectos en todas las facetas de tu vida. Necesitas bases sólidas sobre las que edificar tu vida; el orden y la conducta son las reglas de tu comportamiento. Con los pies bien en la tierra, las personas con esta vibración numérica son prácticas, sencillas, ordenadas y amigas de la disciplina personal. Tus aspectos positivos son la estabilidad, fiabilidad, y dotes organizativos, por eso te manejas muy bien en el mundo de las finanzas y la administración. La rutina es tu talón de Aquiles, por eso deberás equilibrar el aspecto laboral con el personal. Te gusta analizar los detalles y asumir responsabilidades que otros rechazarían. Deseas llevar una vida hogareña y te preocupas de aquellos que se hallan a tu cargo, esperando que te respondan con respeto y dignidad. Llegarás a donde te propongas con esfuerzo y trabajo, la constancia y el tesón serán tu bastión. Deberás aprender a enfrentarte a la realidad y basar tus esfuerzos en un razonamiento profundamente práctico." & vbCrLf &
                       "Predicción: recibirás oportunos ingresos que destinarás al mayor confort del hogar. Tu fortaleza y vitalidad aumentarán marcando una etapa de decisiones importantes que deberás tomar sin titubeos y con firmeza. Alcanzarás una posición de mayor equilibrio y estabilidad y todo lo que inviertas en tu profesión o tu carrera podrá rendir sus frutos. En esta etapa algún sueño podrá convertirse en realidad. Puede ser la concreción de una mudanza, un proyecto laboral con amigos o bien ocupar el puesto de trabajo que estás esperando. Para el amor, será el momento de resolver asuntos pendientes y decir todo lo que piensas y sientes. El diálogo hará retornar el equilibrio y la pasión."
            Case 5
                Return "El número cinco" & vbCrLf &
                        "Es el andador de nuevos caminos. Libertad es tu palabra clave y deberá estar presente en todos los aspectos de tu vida. Si dejas que tu naturaleza se manifieste libremente, lograrás maravillas. Pero si en cambio, te sentís frenado o limitado, perderás todo entusiasmo y no lograrás buenos resultados. Posees una gran audacia y una excelente memoria pero con frecuencia sufrís de inestabilidad emocional e inseguridad. Buen explorador, estudiante diligente, te apasionan las nuevas experiencias y huyes de la monotonía. En tu infinita búsqueda, conocerás diferentes filosofías de vida, lugares y personas que te ayudarán a encontrar el verdadero camino. Estás en este mundo para aprender y experimentar el valor de la libertad, y no te limitarás con excesos. Ávido de emociones, cinco considera que lo único intolerable es el aburrimiento. Por eso suelen triunfar en actividades como los medios de información, los espectáculos o las relaciones públicas." & vbCrLf &
                        "Predicción: etapa de importantes cambios y decisiones. Estarás ansioso y querrás luchar por lograr mayor independencia. Sin embargo, no deberás olvidarte de actuar con responsabilidad y utilizando la razón. Sé osado, pero no dejes de tener los pies en la tierra. Vivirás momentos interesantes en tu faceta personal. Será un período de extraordinarias transformaciones donde podrás dejar atrás todo aquello que ya no es importante en tu vida. Un cambio de look te hará proyectar una imagen más segura y confiada. Las relaciones estarán marcadas por el compromiso y la entrega y se presentará la oportunidad de tomar una decisión trascendente en el amor."
            Case 6
                Return "El número seis" & vbCrLf &
                        "Representa la búsqueda de armonía y equilibrio. La amabilidad y el afán de servir y ayudar son tus cualidades más sobresalientes. Perseguidor de la belleza y el amor, tus valores más preciados, serás muy bueno creando una familia y un hogar, que será, sin dudas, tu obra de arte. Estás en este mundo para aprender el sentido de la responsabilidad con respecto a la familia y la sociedad. El 6 es la vibración del amor y del hogar y tiende a hacerse responsable de las necesidades sociales de los demás. Deberás adquirir un fuerte sentido del equilibrio, de manera que te permita templar las injusticias. Desarrollarás la comprensión y la compasión precisas para aliviar las cargas de aquellos a los que atraerás naturalmente. Formas parte de los que sirven, enseñan y reconfortan a la humanidad. Sensible y romántico, las actividades creativas son ideales para alcanzar el éxito y la felicidad personal. Deberás evitar idealizaciones, afrontar los conflictos con seguridad y madurez, moderar los celos, la terquedad y la intromisión." & vbCrLf &
                        "Predicción: en éste período podrás resolver muchos asuntos con rapidez y habilidad. Deberás estar muy atento a las responsabilidades ya que por hacer demasiado puede que se te olvide cumplir con algo que prometiste. Aclararás problemas con socios y allegados y cederán los roces en tu entorno. Deberás evitar dejar de lado tu faceta afectiva por estar tan ocupado en el trabajo. Procura destinar más tiempo a la familia, amistades y pareja. Gozarás de un mayor equilibrio corporal y mental a través del ejercicio y el contacto con la naturaleza. Si estás solo, tendrás grandes oportunidades de encontrar a alguien especial. También será buen momento para dar un paso adelante en una relación establecida."
            Case 7
                Return "El número siete" & vbCrLf &
                        "La intuición y la sensibilidad predominan en tu vida. Siete es el número más solitario y ensimismado del universo de los números. Analista de los misterios de la vida, vivís metido en tu propio mundo donde te cuestionas sobre los problemas existenciales, místicos y morales que tanto te preocupan, sin dedicarle mucho tiempo a los asuntos más prácticos de la vida. Necesitas momentos de soledad y silencio para meditar y recibir inspiración de tu interior. Cuando te decides a hablar, tus palabras están llenas de sabiduría y tu poderosa intuición te ayuda en cualquier situación que te encuentres. Te gusta leer, pensar, meditar y profundizar en lo oculto, lo misterioso y el lado fenoménico de la vida. Te irá bien en actividades como la investigación científica, las matemáticas, la música o la literatura. Te sienta muy bien vivir cerca de la naturaleza, en un entorno tranquilo y aislado del bullicio. Tus deseos más fuertes están relacionados a lo más elevado en el ámbito espiritual para poder crecer interiormente. No será prudente que te apegues a las cosas materiales y los sentimientos no correspondidos." & vbCrLf &
                         "Predicción: una particular sensibilidad capaz de captar lo más sutil te dará las respuestas que estás buscando. Soplará un aire nuevo que llenará tu vida de entusiasmo. Recibirás ofertas y propuestas sobre actividades desconocidas y nuevos desafíos. Un negocio o un nuevo proyecto captará toda tu atención, pero antes de dar cualquier paso, asesórate de cada detalle a fin de no alimentar falsas ilusiones. Sin embargo, se augura una etapa de pequeños triunfos y alentadoras mejoras ya que estarás inspirado y contarás con una afilada intuición. En el amor, lograrás muchas ventajas si no escondes tus emociones y decides abrirte a vivir plenamente las posibilidades de un nuevo romance.  "
            Case 8
                Return "El número ocho" & vbCrLf &
                        "Este número lleva en su esencia el dualismo y siempre está en los extremos porque no cree en las medias tintas: es a todo o nada, blanco o negro. Continuamente en tensión, su fuerza procede de estar poniéndose siempre a prueba. Tu vida está destinada a grandes negocios y el mundo de las finanzas en general. El triunfo llegará pero a través del propio esfuerzo y la constancia. Tu consigna será la justicia y no deberás desperdiciar tiempo pugnando por la fortuna, sino trabajar por tu propia realización y satisfacción personal. La recompensa será tu desarrollo y una tarea bien hecha. A lo largo de tu vida te asociarás con personas importantes, influyentes y talentosas. Resuelto, obstinado y sin pelos en la lengua, afrontarás las diferentes situaciones con valentía, espíritu de sacrificio y luchando por conseguir la victoria. Exigente, competitivo y poco sutil, tendrás en cuenta que no hay beneficio sin sacrificio y deberás luchar por tu independencia para lograr lo que te propongas. Estás en este mundo para aprender a manejar la autoridad y el dinero, evitando el abuso de poder, la excentricidad y la indolencia." & vbCrLf &
                        "Predicción: las buenas acciones del pasado comenzarán a dar sus frutos. La feliz resolución de un asunto familiar te permitirá proyectarte con fuerza hacia el futuro. El éxito profesional dependerá de tu capacidad de liderar y de rodearte de personas competentes. Evitar la excesiva crítica y desarrollar la tolerancia será la clave para una buena convivencia tanto en el plano laboral como en el afectivo. La vida sedentaria podría afectar tu ánimo, inscribirte en un gimnasio o realizar caminatas te hará sentir pleno y vital. Se abren nuevos caminos al amor, posibilidad de recibir una invitación inesperada. Alegrías, festejos y celebraciones familiares."
            Case 9
                Return "El número nueve" & vbCrLf &
                        "Es la vibración más elevada y representa al amante universal de la humanidad. Paciente, bondadoso y comprensivo, te encuentras en la cima de la expresión de la vida y deberás abrir y mostrar el camino a los demás. Representa al idealista, pero con fuerza de voluntad, fuerte y enérgico. La persona regida por el siete tiende a ser versátil y decidida a conseguir sus objetivos. Humanitario y deseoso de salvar al mundo, no soportas las injusticias y sentís que naciste para luchar contra ellas. Nueve persigue sus objetivos con todo el coraje pero sólo le interesan las grandes causas, en las que es verdaderamente competente. Los temas que más te motivan son salvar el planeta de la autodestrucción, luchar contra la hambruna y la desigualdad para crear un mundo mejor. Tu naturaleza ardorosa te hace muy susceptible, sobre todo con los temas que más te interesan. Generoso y cálido, eres admirado por mucha gente y resultas muy atractivo y magnético a los demás. Dar es recibir para un destino nueve, para quienes la vida es bella si tienen la oportunidad de ayudar a los demás." & vbCrLf &
                        "Predicción: deberás finalizar algunos proyectos para poder dedicarte a todo lo nuevo que la vida te tiene reservado. Tendrás oportunidad de desarrollar tus talentos. Si organizas bien tu tiempo podrás realizar todo lo que te propongas. Posibilidad de estar en contacto con público o de tener una agitada vida social. El desafío estará en no dispersarte y enfocar las energías de manera concreta y positiva. Excelente para cerrar etapas, sanar, soltar y deshacerse de todo aquello que ya ha cumplido su ciclo en tu vida. Este tiempo presentará matices interesantes en las relaciones humanas, algo muy profundo se está transformando en tu interior, lo cual te permitirá abrirte y acercarte al verdadero amor."
            Case Else
                Return "Descripción no disponible."
        End Select
    End Function


End Class
