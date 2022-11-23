using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoralesPNL
{
    public partial class Form2 : Form
    {
        readonly String[] Preguntas_text = {
            "¿Cuál de las siguientes actividades disfrutas más?",
            "¿Qué programa de televisión prefieres?",
            "Cuando conversas con otra persona, tú: ",
            "Si pudieras adquirir uno de los siguientes artículos, ¿cuál elegirías?",
            "¿Qué prefieres hacer un sábado por la tarde?",
            "¿Qué tipo de exámenes se te facilitan más?",
            "¿Cómo te orientas más fácilmente?",
            "¿En qué prefieres ocupar tu tiempo en un lugar de descanso?",
            "¿Qué te halaga más?",
            "¿Cuál de estos ambientes te atrae más?",
            "¿De qué manera se te facilita aprender algo?",
            "¿A qué evento preferirías asistir?",
            "¿De qué manera te formas una opinión de otras personas?",
            "¿Cómo te consideras?",
            "¿Qué tipo de películas te gustan más?",
            "¿Cómo prefieres mantenerte en contacto con otra persona?",
            "¿Cuál de las siguientes frases se identifican más contigo?",
            "¿Cómo prefieres pasar el tiempo con tu novia o novio?",
            "Si no encuentras las llaves en una bolsa",
            "Cuando tratas de recordar algo, ¿cómo lo haces?",
            
            "Si tuvieras dinero, ¿qué harías?",
            "¿Con qué frase te identificas más?",
            "Si tuvieras que quedarte en una isla desierta, ¿qué preferirías llevar contigo?",
            "¿Cuál de los siguientes entretenimientos prefieres?",
            "¿Cómo es tu forma de vestir?",
            "¿Qué es lo que más te gusta de una fogata nocturna?",
            "¿Cómo se te facilita entender algo?",
            "¿Por qué te distingues?",
            "¿Qué es lo que más disfrutas de un amanecer?",
            "Si pudieras elegir ¿qué preferirías ser?",
            "Cuando eliges tu ropa, ¿qué es lo más importante para ti?",
            "¿Qué es lo que más disfrutas de una habitación?",
            "¿Qué es más sexy para ti?",
            "¿A qué tipo de espectáculo preferirías asistir?",
            "¿Qué te atrae más de una persona?",
            "Cuando vas de compras, ¿en dónde pasas mucho tiempo?",
            "¿Cuáles tu idea de una noche romántica?",
            "¿Qué es lo que más disfrutas de viajar?",
            "Cuando estás en la ciudad, ¿qué es lo que más hechas de menos del campo?",
            "Si te ofrecieran uno de los siguientes empleos, ¿cuál elegirías?"
        };
        readonly String[] OpcionA_text =
        {
            "Escuchar música",
            "Reportajes de descubrimientos y lugares",
            "La escuchas atentamente",
            "Un jacuzzi",
            "Quedarte en casa",
            "Examen oral",
            "Mediante el uso de un mapa",
            "Pensar",
            "Que te digan que tienes buen aspecto",
            "Uno en el que se sienta un clima agradable",
            "Repitiendo en voz alta",
            "A una reunión social",
            "Por la sinceridad en su voz",
            "Atlético",
            "Clásicas",
            "Por correo electrónico",
            "Me gusta que mi coche se sienta bien al conducirlo",
            "Conversando",
            "La buscas mirando",
            "A través de imágenes",

            "Comprar una casa",
            "Reconozco a las personas por su voz",
            "Algunos buenos libros",
            "Tocar un instrumento musical",
            "Impecable",
            "El calor del fuego y los bombones asados",
            "Cuando te lo explican verbalmente",
            "Por tener una gran intuición",
            "La emoción de vivir un nuevo día",
            "Un gran médico",
            "Que sea adecuada",
            "Que sea silenciosa",
            "Una iluminación tenue",
            "A un concierto de música",
            "Su trato y forma de ser",
            "En una librería",
            "A la luz de las velas",
            "Conocer personas y hacer nuevos amigos",
            "El aire limpio y refrescante",
            "Director de una estación de radio"
        };
        readonly String[] OpcionB_text = {
            "Ver películas",
            "Cómico y de entretenimiento",
            "La observas",
            "Un estéreo",
            "Ir a un concierto",
            "Examen escrito",
            "Pidiendo indicaciones",
            "Caminar por los alrededores",
            "Que te digan que tienes un trato muy agradable",
            "Uno en el que se escuchen las olas del mar",
            "Escribiéndolo varias veces",
            "A una exposición de arte",
            "Por la forma de estrecharte la mano",
            "Intelectual",
            "De accion",
            "Tomando un café juntos",
            "Percibo hasta el mas ligero ruido que hace mi coche",
            "Acariciándose",
            "Sacudes la bolsa para oír el ruido",
            "A través de emociones",

            "Viajar y conocer el mundo",
            "No recuerdo el aspecto de la gente",
            "Un radio portátil de alta frecuencia",
            "Sacar fotografías",
            "Informal",
            "El sonido del fuego quemando la leña",
            "Cuando utilizan medios visuales",
            "Por ser un buen conversador",
            "Las tonalidades del cielo",
            "Un gran músico",
            "Que luzca bien",
            "Que sea confortable",
            "El perfume",
            "A un espectáculo de magia",
            "Su aspecto físico",
            "En una perfumería",
            "Con música romántica",
            "Conocer lugares nuevos",
            "Los paisajes",
            "Director de un club deportivo"
        };
        readonly String[] OpcionC_text = {
            "Bailar con buena música",
            "Noticias del mundo",
            "Tiendes a tocarla",
            "Un televisor",
            "Ir al cine",
            "Examen de opcion multiple",
            "A través de la intuición",
            "Descansar",
            "Que te digan que tienes una conversación interesante",
            "Uno con una hermosa vista al océano",
            "Relacionándolo con algo divertido",
            "A una conferencia",
            "Por su aspecto",
            "Sociable",
            "De amor",
            "Por teléfono",
            "Es importante que mi coche esté limpio por fuera y por dentro",
            "Mirando algo juntos",
            "Buscas al tacto",
            "A través de sonidos",

            "Adquirir un estudio de grabación",
            "Recuerdo el aspecto de alguien, pero no su nombre",
            "Golosinas y comida enlatada",
            "Actividades manuales",
            "Muy informal",
            "Mirar el fuego y las estrellas",
            "Cuando se realiza a través de alguna actividad",
            "Por ser un buen observador",
            "El canto de las aves",
            "Un gran pintor",
            "Que sea cómoda",
            "Que esté limpia y ordenada",
            "Cierto tipo de música",
            "A una muestra gastronómica",
            "Su conversación",
            "En una tienda de discos",
            "Bailando tranquilamente",
            "Aprender sobre otras costumbres",
            "La tranquilidad",
            "Director de una revista"
        };
        
        public static int contadorPreguntas = 0;
        public static int contadorVisual = 0;
        public static int contadorAuditivo = 0;
        public static int contadorCinestesico = 0;
        public static int opcionElegida = 0;
        public static string resultado = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NoPregunta.Text = "Pregunta " + (contadorPreguntas + 1) + " de " + Preguntas_text.Length;
            Pregunta.Text = Preguntas_text[0];
            OpcionA.Text = OpcionA_text[0];
            OpcionB.Text = OpcionB_text[0];
            OpcionC.Text = OpcionC_text[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if para saber que radio button se eligio
            if (OpcionA.Checked == true)
            {
                opcionElegida = 1;
            }
            else if (OpcionB.Checked == true)
            {
                opcionElegida = 2;
            }
            else if (OpcionC.Checked == true)
            {
                opcionElegida = 3;
            }
            else
            {
                MessageBox.Show("Favor de elegir una opción");
            }
            
            contadorPreguntas++;

            //Switch para cada pregunta
            switch (contadorPreguntas)
            {
                case 1:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 2:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 3:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 4:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 5:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 6:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 7:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 8:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 9:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 10:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 11:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 12:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 13:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++; 
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 14:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 15:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 16:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++; 
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 17:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++; 
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 18:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++; 
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 19:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 20:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 21:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;  
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 22:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++; 
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 23:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 24:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 25:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 26:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++; 
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 27:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 28:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 29:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 30:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 31:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 32:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
                case 33:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 34:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 35:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 36:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 37:
                    if (opcionElegida == 1)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorAuditivo++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorCinestesico++;
                    }
                    break;
                case 38:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 39:
                    if (opcionElegida == 1)
                    {
                        contadorCinestesico++;
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorVisual++;
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorAuditivo++;
                    }
                    break;
                case 40:
                    if (opcionElegida == 1)
                    {
                        contadorAuditivo++; 
                    }
                    else if (opcionElegida == 2)
                    {
                        contadorCinestesico++; 
                    }
                    else if (opcionElegida == 3)
                    {
                        contadorVisual++;
                    }
                    break;
            }

            if (contadorPreguntas < Preguntas_text.Length)
            {
                
                NoPregunta.Text = "Pregunta " + (contadorPreguntas + 1) + " de " + Preguntas_text.Length;
                Pregunta.Text = Preguntas_text[contadorPreguntas];
                OpcionA.Text = OpcionA_text[contadorPreguntas];
                OpcionB.Text = OpcionB_text[contadorPreguntas];
                OpcionC.Text = OpcionC_text[contadorPreguntas];

                
            }
            else {
                //comparar los contadores para saber que tipo de aprendizaje es
                if (contadorVisual > contadorAuditivo && contadorVisual > contadorCinestesico)
                {
                    resultado = "Visual";
                    MessageBox.Show("Tu tipo de aprendizaje es Visual");
                }
                else if (contadorAuditivo > contadorVisual && contadorAuditivo > contadorCinestesico)
                {
                    resultado = "Auditivo";
                    MessageBox.Show("Tu tipo de aprendizaje es Auditivo");
                }
                else if (contadorCinestesico > contadorVisual && contadorCinestesico > contadorAuditivo)
                {
                    resultado = "Cinestesico";
                    MessageBox.Show("Tu tipo de aprendizaje es Cinestesico");
                }
                else
                {
                    resultado = "Mixto";
                    MessageBox.Show("No se pudo determinar tu tipo de aprendizaje");
                }

                Usuario user = new Usuario();
                user.Nombre = Form1.Nom;
                user.FechaNa = Form1.FeNa;
                user.Correo = Form1.Mail;
                user.Celular = Form1.Tel;
                user.Fecha = Form1.Fe;
                user.Hora = Form1.Ho;
                user.Visual = contadorVisual.ToString();
                user.Auditivo = contadorAuditivo.ToString();
                user.Cinestesico = contadorCinestesico.ToString();
                user.Resultado = resultado;

                int respuestaConexion = UsuarioDAO.Agregar_Usuario(user);
                if (respuestaConexion > 0)
                {
                    MessageBox.Show("Se ha registrado correctamente, puedes cerrar la prueba");
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar");
                }
            }
            


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
