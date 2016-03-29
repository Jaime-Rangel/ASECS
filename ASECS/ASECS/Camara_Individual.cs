using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ASECS
{
    public partial class Camara_Individual : Form
    {
        //Objetos Atributos
        Camara_Individual_Aspectos Aparencia;
        Variables_Camara Variables_Globales;
        OCX_Operaciones_Camara OCX_Camara;
        Video_Grabacion Grabar_Video;
        Camara_PTZ Movimiento_PTZ;
        Camara_CGI Comando_CGI;

        Thread Verificar_Camara_Activa_Hilo;
        Thread Grabar_Video_Hilo;
        Thread Streaming_Video_Hilo;

        //Atributos variables
        public string Nombre_Camara;

        public Camara_Individual()
        {
            InitializeComponent();
        }

        private void Inicializar_Objetos()
        {
            Aparencia = new Camara_Individual_Aspectos(this);
            Variables_Globales = new Variables_Camara();
            OCX_Camara = new OCX_Operaciones_Camara(this,Variables_Globales);
            Grabar_Video = new Video_Grabacion(this, Variables_Globales);
            Grabar_Video.Asignar_Directorio_VLC();
            Movimiento_PTZ = new Camara_PTZ(this,Variables_Globales);
            Comando_CGI = new Camara_CGI(this,Variables_Globales);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializar_Objetos();
            Acomodar_Elementos_Graficos();
            Inicializar_Variables_Camara();
            Aparencia.Asignar_Titulo_Camara();
        }

        public void Inicializar_Variables_Camara()
        {
            Variables_Globales.Camara_IP = "192.168.1.105";
            Variables_Globales.Camara_Puerto_CGI = "81";
            Variables_Globales.Camara_Puerto_RTSP = "10554";
            Variables_Globales.Ruta_Grabacion = ":sout=#std{access=file,mux=mp4, dst='C:\\Users\\jaime\\test.mp4'}";
            Variables_Globales.Usuario = "admin";
            Variables_Globales.Contraseña = "888888";
            Nombre_Camara = "Cuarto de Jaime";
        }

        private void Acomodar_Elementos_Graficos()
        {

            Aparencia.Acomodar_Elementos();
            Aparencia.Elementos_Desactivados();
            Movimiento_PTZ.Llenar_Movimientos_Posiciones();

        }

        private void Boton_Conectar_Camara_Click(object sender, EventArgs e)
        {
            if (Variables_Globales.Camara_Activa == false)
            {
                double respuesta = OCX_Camara.Verificar_Conexion_Camara_Streaming(Variables_Globales.Camara_IP);

                if (respuesta == 0)
                {
                    MessageBox.Show("La Camara no esta disponible");
                }
                else
                {
                    Aparencia.Elementos_Activados();
                    Variables_Globales.Camara_Activa = true;
                    Streaming_Video_Hilo = new Thread(() => Hilo_Camara_Streaming(this));
                    Verificar_Camara_Activa_Hilo = new Thread(() => Hilo_Camara_Activa(this));
                    Verificar_Camara_Activa_Hilo.Start();
                    Streaming_Video_Hilo.Start();
                }
            }
            else
            {
                MessageBox.Show("La Camara ya esta transmitiendo.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        //Metodo/Hilo para Mostrar la camara en streaming
        private void Hilo_Camara_Streaming(Camara_Individual formulario)
        {
            if (formulario.Ventana_Camara_IP.InvokeRequired)
            {
                formulario.BeginInvoke((MethodInvoker)delegate()
                {
                    OCX_Camara.Iniciar_Streaming(); ;
                });
            }
            else
            {
                OCX_Camara.Iniciar_Streaming(); ;
            }
        }

        //Metodo/Hilo para Verificar que la camara este transmitiendo
        private void Hilo_Camara_Activa(Camara_Individual formulario)
        {
            double handshake;

            do
            {
                Thread.Sleep(5000);
                handshake = OCX_Camara.Verificar_Conexion_Camara_Streaming(Variables_Globales.Camara_IP);
                Console.WriteLine(handshake);

            } while (handshake > 0 && Variables_Globales.Camara_Activa == true);


            if (handshake == 0)
            {
                MessageBox.Show("Se perdio la comunicacion con la camara");

                if (formulario.Ventana_Camara_IP.InvokeRequired)
                {
                    formulario.BeginInvoke((MethodInvoker)delegate()
                    {
                        formulario.Ventana_Camara_IP.StopVideo();
                        formulario.Ventana_Camara_IP.Refresh();
                        Aparencia.Elementos_Desactivados();
                        ;
                    });
                }
                else
                {
                    Aparencia.Elementos_Desactivados();
                    formulario.Ventana_Camara_IP.Refresh(); ;
                }
            }

        }

        private void Boton_Desconectar_Camara_Click(object sender, EventArgs e)
        {
            if (Variables_Globales.Camara_Activa == true && Variables_Globales.Camara_Grabando == false)
            {
                OCX_Camara.Detener_Streaming();
                Aparencia.Elementos_Desactivados();
                Variables_Globales.Camara_Activa = false;
            }
            else
            if(Variables_Globales.Camara_Grabando == true)
            {
                MessageBox.Show("El programa esta grabando, termina la grabacion para detener la camara.",
               "Aviso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("La camara no esta activa.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Checkeo_Escuchar_Camara_CheckedChanged(object sender, EventArgs e)
        {

            if (Checkeo_Escuchar_Camara.Checked == true)
            {
                OCX_Camara.Escuchar_Audio_Camara();
            }
            else
            {
                OCX_Camara.Bloquear_Audio_Camara();
            }
        }

        private void Boton_Iniciar_Grabacion_Click(object sender, EventArgs e)
        {
            if (Variables_Globales.Camara_Grabando == false)
            {
                Variables_Globales.Camara_Grabando = true;
                Grabar_Video_Hilo = new Thread(() => Hilo_Grabar_Video(this));
                Grabar_Video_Hilo.Start();
                Aparencia.Activar_Mensaje_Grabando();
                //Mensaje_Grabando_Hilo = new Thread(() => Hilo_Mostrar_Mensaje(this));
                //Mensaje_Grabando_Hilo.Start();
            }
            else
            {
                MessageBox.Show("El programa ya esta grabando.",
               "Aviso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1);
            }

        }

        private void Hilo_Mostrar_Mensaje(Camara_Individual formulario)
        {
            if (formulario.Titulo_Grabando.InvokeRequired)
            {
                formulario.BeginInvoke((MethodInvoker)delegate()
                {
                     Aparencia.Activar_Mensaje_Grabando();
                     Thread.Sleep(1500);
                     Aparencia.Desactivar_Mensaje_Grabando();
                     Thread.Sleep(1500);
                    ;
                });
            }
            else
            {
                Aparencia.Activar_Mensaje_Grabando();
                Thread.Sleep(1500);
                Aparencia.Desactivar_Mensaje_Grabando();
                Thread.Sleep(1500); ;
            }
        }

        //Metodo/Hilo para grabar video del streaming
        private void Hilo_Grabar_Video(Camara_Individual formulario)
        {
            if (formulario.Ventana_Camara_IP.InvokeRequired)
            {
                formulario.BeginInvoke((MethodInvoker)delegate()
                {
                    Grabar_Video.Grabar_Video_Streaming(); ;
                });
            }
            else
            {
                Grabar_Video.Grabar_Video_Streaming(); ;
            }
        }

        private void Boton_Detener_Grabacion_Click(object sender, EventArgs e)
        {
            if (Variables_Globales.Camara_Grabando == true)
            {
                Grabar_Video.Detener_Grabacion_Streaming();
                Aparencia.Desactivar_Mensaje_Grabando();
                Variables_Globales.Camara_Grabando = false;
            }
            else
            {
                MessageBox.Show("No hay ninguna grabacion activa.",
             "Aviso",
             MessageBoxButtons.OK,
             MessageBoxIcon.Exclamation,
             MessageBoxDefaultButton.Button1);
            }
        }

        private void Boton_Mover_Centro_Click(object sender, EventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(25);
        }

        private void Checkeo_Intervir_Camara_CheckedChanged(object sender, EventArgs e)
        {
            Comando_CGI.Invertir_Horizontal_Vertical_Streaming();
        }

        private void Checkeo_Modo_Espejo_CheckedChanged(object sender, EventArgs e)
        {
            Comando_CGI.Invertir_Horizontal_Vertical_Streaming();
        }

        private void Checkeo_Hablar_Camara_CheckedChanged(object sender, EventArgs e)
        {
            OCX_Camara.Hablar_Audio_Camara();
        }

        private void Boton_Aceptar_Mover_Posicion_Click(object sender, EventArgs e)
        {
            if (Lista_Mover_Posiciones_Camara.Text != "")
            {
                Movimiento_PTZ.Verificar_Posicion_Movimiento_Llamada();
            }
            else
            {
                MessageBox.Show("Selecciona una posicion.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Boton_Guardar_Posicion_Click(object sender, EventArgs e)
        {
            if (Lista_Guardar_Posiciones_Camara.Text != "")
            {
                Movimiento_PTZ.Verificar_Posicion_Movimiento_Establecer();
            }
            else
            {
                MessageBox.Show("Selecciona una posicion.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Boton_Mover_Arriba_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(0);
        }

        private void Boton_Mover_Arriba_MouseUp(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(1);
        }

        private void Boton_Mover_Abajo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(2);
        }

        private void Boton_Mover_Abajo_MouseUp(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(3);
        }

        private void Boton_Mover_Izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(4);
        }

        private void Boton_Mover_Izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(5);
        }

        private void Boton_Mover_Derecha_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(6);
        }

        private void Boton_Mover_Derecha_MouseUp(object sender, MouseEventArgs e)
        {
            Movimiento_PTZ.Generar_Movimiento_Camara(7);
        }


    }
}
