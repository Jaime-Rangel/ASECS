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
using MySql.Data.MySqlClient;

namespace ASECS
{
    public partial class Camara_Individual : Form
    {
        //Objetos Atributos
        Camara_Individual_Aspectos Aparencia;
        public Variables_Camara Variables_Globales;
        OCX_Operaciones_Camara OCX_Camara;
        Video_Grabacion Grabar_Video;
        Camara_PTZ Movimiento_PTZ;
        Camara_CGI Comando_CGI;
        public Camara Objeto_Camara;
        public Menu_Principal formulario_principal;

        //Thread Verificar_Camara_Activa_Hilo;
        Thread Grabar_Video_Hilo;
        Thread Streaming_Video_Hilo;

        //Atributos variables
        public string Nombre_Camara;
        public string Directorio_Usuario;

        public Camara_Individual(Camara Objeto_Camara, Menu_Principal formulario_principal)
        {
            InitializeComponent();
            this.Objeto_Camara = Objeto_Camara;
            this.formulario_principal = formulario_principal;
            Directorio_Usuario = formulario_principal.Sesion_Usuario.Directorio_Usuario;
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

        public void Verificar_Parametros_Camara_BD()
        {
            if (Objeto_Camara.Invertida == true && Objeto_Camara.Modo_Espejo == true)
            {
                Checkeo_Intervir_Camara.Checked = true;
                Checkeo_Modo_Espejo.Checked = true;
            }
            else
            if(Objeto_Camara.Invertida==true)
            {
                Checkeo_Intervir_Camara.Checked = true;
            }
            else
            if(Objeto_Camara.Modo_Espejo==true)
            {
                Checkeo_Modo_Espejo.Checked = true;
            }
            
            if(Objeto_Camara.Posicion_Predeterminada!=null)
            {
     
                Lista_Guardar_Posiciones_Camara.Text = Convert.ToString(Objeto_Camara.Posicion_Predeterminada);
                Checkeo_Camara_Posicion.Checked = true;
            }
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializar_Objetos();
            Acomodar_Elementos_Graficos();
            Inicializar_Variables_Camara();
            Aparencia.Asignar_Titulo_Camara();
            Verificar_Parametros_Camara_BD();
            Encender_Camara();
        }

        public void Inicializar_Variables_Camara()
        {
            Variables_Globales.Camara_IP = Objeto_Camara.Direccion_IP;
            Variables_Globales.Camara_Puerto_CGI = Objeto_Camara.Puerto_CGI;
            Variables_Globales.Camara_Puerto_RTSP = Objeto_Camara.Puerto_RSTP;
            //Variables_Globales.Ruta_Grabacion = ":sout=#std{access=file,mux=mp4, dst='C:\\Users\\jaime\\test.mp4'}";
            Variables_Globales.Ruta_Grabacion = Directorio_Usuario;
            Variables_Globales.Usuario = Objeto_Camara.Usuario;
            Variables_Globales.Contraseña = Objeto_Camara.Contraseña;
            Nombre_Camara = Objeto_Camara.Alias;
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
                    Encender_Camara();
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

        private void Encender_Camara()
        {
            Aparencia.Elementos_Activados();
            Variables_Globales.Camara_Activa = true;
            Streaming_Video_Hilo = new Thread(() => Hilo_Camara_Streaming(this));
            //Verificar_Camara_Activa_Hilo = new Thread(() => Hilo_Camara_Activa(this));
            //Verificar_Camara_Activa_Hilo.Start();
            Streaming_Video_Hilo.Start();
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
                if (formulario_principal.Variables_Globales.Grabaciones_Iniciadas == false)
                {
                    if (string.IsNullOrEmpty(formulario_principal.Sesion_Usuario.Directorio_Usuario) == false)
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
                        MessageBox.Show("No has asignado una ruta para las grabaciones en el menú principal.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("El menú principal ya se encuentra grabando, detén la grabación si deseas iniciar una grabación esta cámara.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
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
                    Grabar_Video.Grabar_Video_Streaming();
                });
            }
            else
            {
                Grabar_Video.Grabar_Video_Streaming();
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
            try
            {
                Comando_CGI.Invertir_Horizontal_Vertical_Streaming();

                if (Checkeo_Intervir_Camara.Checked == true)
                {
                    Actualizar_Lista_Camaras_Invertida(true);
                    Comando_CGI.Actualizar_Camara_Invertida_BD(1);
                }
                else
                {
                    Actualizar_Lista_Camaras_Invertida(false);
                    Comando_CGI.Actualizar_Camara_Invertida_BD(0);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

                MessageBox.Show("Hubo un error de conexión en la base de datos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Checkeo_Modo_Espejo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Comando_CGI.Invertir_Horizontal_Vertical_Streaming();

                if (Checkeo_Modo_Espejo.Checked == true)
                {
                    Actualizar_Lista_Camaras_Modo_Espejo(true);
                    Comando_CGI.Actualizar_Camara_Modo_Espejo_BD(1);
                }
                else
                {
                    Actualizar_Lista_Camaras_Modo_Espejo(false);
                    Comando_CGI.Actualizar_Camara_Modo_Espejo_BD(0);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

                MessageBox.Show("Hubo un error de conexión en la base de datos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        public void Actualizar_Lista_Camaras_Modo_Espejo(bool Espejo)
        {
            Camara Objeto_Camara_Aux = new Camara();
            Objeto_Camara_Aux = Objeto_Camara;
            Objeto_Camara_Aux.Modo_Espejo = Espejo;

            formulario_principal.Lista_Camaras.remove(Objeto_Camara);
            formulario_principal.Lista_Camaras.Insertar(Objeto_Camara_Aux);

            Objeto_Camara = Objeto_Camara_Aux;

        }

        public void Actualizar_Lista_Camaras_Invertida(bool Invertida)
        {
            Camara Objeto_Camara_Aux = new Camara();
            Objeto_Camara_Aux = Objeto_Camara;
            Objeto_Camara_Aux.Invertida = Invertida;

            formulario_principal.Lista_Camaras.remove(Objeto_Camara);
            formulario_principal.Lista_Camaras.Insertar(Objeto_Camara_Aux);

            Objeto_Camara = Objeto_Camara_Aux;

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
                Checkeo_Camara_Posicion.Checked = false;

                MessageBox.Show("Se ha guardado la posición de la cámara.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
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

        private void Camara_Individual_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Pregunta = MessageBox.Show("¿Realmente quieres salir? Cuidado Se detendrán las grabaciones iniciadas",
            "Aviso",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation);

            if (Pregunta == DialogResult.Yes)
            {
                if (Variables_Globales.Camara_Grabando == true)
                {
                    Grabar_Video.Detener_Grabacion_Streaming();
                    Aparencia.Desactivar_Mensaje_Grabando();
                    Variables_Globales.Camara_Grabando = false;
                   
                }
                else
                if(Variables_Globales.Camara_Activa == true)
                {
                    OCX_Camara.Detener_Streaming();
                }
            }
            else
            {
                e.Cancel = true;
                this.Activate();
            }

        }

        public void Actualizar_Posicion_Camara_BD()
        {

            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Posicion_Camara(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", Objeto_Camara.Camara_ID);
            chec.Parameters.AddWithValue("@C2", Lista_Guardar_Posiciones_Camara.Text);

            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();
        }

        public void Actualizar_Posicion_Camara_Null_BD()
        {

            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Posicion_Camara(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", Objeto_Camara.Camara_ID);
            chec.Parameters.AddWithValue("@C2", null);

            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();
        }

        private void Checkeo_Camara_Posicion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Checkeo_Camara_Posicion.Checked == true)
                {

                    if (Lista_Guardar_Posiciones_Camara.Text != "")
                    {

                        Movimiento_PTZ.Verificar_Posicion_Movimiento_Establecer();
                        Actualizar_Posicion_Camara_BD();
                        Objeto_Camara.Posicion_Predeterminada = Convert.ToInt32(Lista_Guardar_Posiciones_Camara.Text);
                        formulario_principal.Lista_Camaras.Actualizar(Objeto_Camara);
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
                else
                {
                    Actualizar_Posicion_Camara_Null_BD();
                    Objeto_Camara.Posicion_Predeterminada = null;
                    formulario_principal.Lista_Camaras.Actualizar(Objeto_Camara);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

                MessageBox.Show("Hubo un error de conexión en la base de datos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

        }

    }
}
