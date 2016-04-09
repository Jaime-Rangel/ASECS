﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ASECS
{
    public partial class Menu_Principal : Form
    {
        //Objetos
        Menu_Principal_Aspectos Aspectos;
        public Variables_Menu_Principal Variables_Globales;
        public Arbol_Camara<Camara> Lista_Camaras;
        public List<string> Lista_Camaras_Alias;
        Camara Busqueda_Objeto_Camara;
        public Menu_Principal_Metodos Metodos;
        public Tiempo Objeto_Tiempo;
        public Usuario Sesion_Usuario;

        public Menu_Principal(Usuario Sesion_Usuario)
        {
            InitializeComponent();
            this.Sesion_Usuario = Sesion_Usuario;
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            Inicializar_Objetos();
            Inicializar_Variables_Camara();
            Aspectos.Acomodar_Elementos();
            Aspectos.Asignar_Mensaje_Bienvenida();
            Metodos.Cargar_Camaras_Usuario_BD(Sesion_Usuario.Usuario_ID);
        }

        public void Inicializar_Objetos()
        {
            Variables_Globales = new Variables_Menu_Principal();
            Aspectos = new Menu_Principal_Aspectos(this, Variables_Globales);
            Lista_Camaras_Alias = new List<string>();
            Metodos = new Menu_Principal_Metodos(this);
            Objeto_Tiempo = new Tiempo();

            Metodos.Asignar_Parametros_Icono_Notificacion();

            Lista_Camaras = new Arbol_Camara<Camara>((Camara a, Camara b) =>
            {
                return string.Compare(a.Alias, b.Alias) < 0;

            }, (Camara Objeto) =>
            {
                return Objeto;

            },(Camara a,Camara b) =>
            {
                if (a.Alias.Equals(b.Alias))
                {
                    return true;
                }
                else
                    return false;
            });
        }

        public int Eliminar_Nodos_Camaras(Camara Eliminar_Camara)
        {
            int index;
            Lista_Camaras.remove(Eliminar_Camara);

            index = Lista_Camaras_Alias.IndexOf(Eliminar_Camara.Alias);
            Lista_Camaras_Alias.RemoveAt(index);

            return index;
        }

        public void Crear_Nodos_Camaras(Camara Nueva_Camara)
        {
            Lista_Camaras_Alias.Add(Nueva_Camara.Alias);
            Lista_Camaras.Insertar(Nueva_Camara);
        }

        public bool Buscar_Camaras_Alias_Nodos_Existentes(string Alias)
        {
            //Busca una camara en el arbol de camaras
            Busqueda_Objeto_Camara = new Camara();

            Camara Resultado_Busqueda_Objeto_Camara_Alias = new Camara();

            Busqueda_Objeto_Camara.Alias = Alias;

            Resultado_Busqueda_Objeto_Camara_Alias = Lista_Camaras.Buscar(Busqueda_Objeto_Camara);

            if (Resultado_Busqueda_Objeto_Camara_Alias==null)
            {
                return false;
            }
            else
                return true;
            
        }

        public void Inicializar_Variables_Camara()
        {
            Variables_Globales.Nombre_Usuario = Sesion_Usuario.Nombre_Usuario;
        }

        private void Menu_Principal_Nueva_Camara_Click(object sender, EventArgs e)
        {
            Menu_Nueva_Camara Agregar_Camara = new Menu_Nueva_Camara(this);
            Agregar_Camara.Show();

        }

        private void Menu_Principal_Cambiar_Rutas_Click(object sender, EventArgs e)
        {
            string folder;
            DialogResult result = Dialogo_Ruta_Grabacion.ShowDialog();
            if( result == DialogResult.OK )
            {
                folder = Dialogo_Ruta_Grabacion.SelectedPath;
                Variables_Globales.Ruta_Grabacion = folder;
                Metodos.Actualizar_Ruta_Grabaciones_BD();
                MessageBox.Show("La ruta se ha almacenado correctamente.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Menu_Principal_Administrar_Camara_Click(object sender, EventArgs e)
        {
            Menu_Administracion_Camara Administrar_Camara = new Menu_Administracion_Camara(this);
            Administrar_Camara.Show();
        }

        private void Menu_Principal_Eliminar_Camara_Click(object sender, EventArgs e)
        {
            Menu_Eliminar_Camara Eliminar_Camara = new Menu_Eliminar_Camara(this);
            Eliminar_Camara.Show();
        }

        private void Menu_Principal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Icono_Minimizar.Visible = true;
                Icono_Minimizar.ShowBalloonTip(2000);
                this.Hide();
            }
        }

        private void Icono_Minimizar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            ShowInTaskbar = true;
            Icono_Minimizar.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Menu_Opciones_Grabacion_Tiempo_Click(object sender, EventArgs e)
        {
            Menu_Tiempo_Grabacion Tiempos = new Menu_Tiempo_Grabacion(this);
            Tiempos.Show();
        }

        public void Iniciar_Grabacion_Camaras()
        {
            string fecha;
            int cont = 0;

            if (string.IsNullOrEmpty(Variables_Globales.Ruta_Grabacion) == false)
            {
                Variables_Globales.Grabaciones_Iniciadas = true;

                foreach (Vlc.DotNet.Forms.VlcControl control in Menu_Lista_VLC.Controls)
                {
                    var Alias = Lista_Camaras_Alias[cont];

                    Busqueda_Objeto_Camara = new Camara();

                    Camara Resultado = new Camara();

                    Busqueda_Objeto_Camara.Alias = Alias;

                    Resultado = Lista_Camaras.Buscar(Busqueda_Objeto_Camara);

                    ((System.ComponentModel.ISupportInitialize)(control)).EndInit();

                    DateTime now = DateTime.Now;
                    string año = Convert.ToString(now.Year);
                    string mes = Convert.ToString(now.Month);
                    string dia = Convert.ToString(now.Day);
                    string hora = Convert.ToString(now.Hour);
                    hora = hora + "-" + Convert.ToString(now.Minute);
                    hora = hora + "-" + Convert.ToString(now.Second);
                    fecha = dia + "-" + mes + "-" + año + "-" + hora;
                    MessageBox.Show(Convert.ToString(fecha));
                    //control.Play(new Uri("rtsp://" + Resultado.Usuario + ":" + Resultado.Contraseña + "@" + Resultado.Direccion_IP + ":" + Resultado.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='C:\\Users\\jaime\\test.mp4'}");
                    control.Play(new Uri("rtsp://" + Resultado.Usuario + ":" + Resultado.Contraseña + "@" + Resultado.Direccion_IP + ":" + Resultado.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='" + Variables_Globales.Ruta_Grabacion + "\\" + Resultado.Alias + "-" + fecha + ".mp4'}");
                    MessageBox.Show(Resultado.Puerto_RSTP);

                    cont++;

                }
            }
            else
            {
                MessageBox.Show("Selecciona una carpeta para almacenar los videos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        public void Detener_Grabacion_Camaras()
        {

            foreach (Vlc.DotNet.Forms.VlcControl control in Menu_Lista_VLC.Controls)
            {
                control.Stop();
            }
        }

        private void Boton_Iniciar_Grabaciones_Click(object sender, EventArgs e)
        {
            if (Menu_Lista_Camaras.Controls.Count > 0)
            {
                Iniciar_Grabacion_Camaras();
            }
            else
            {
                MessageBox.Show("No hay camaras disponibles.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            }
        }

        private void Boton_Detener_Grabaciones_Click(object sender, EventArgs e)
        {
            if (Variables_Globales.Grabaciones_Iniciadas == true)
            {
                Detener_Grabacion_Camaras();
                Variables_Globales.Grabaciones_Iniciadas = false;
            }
            else
            {

                MessageBox.Show("No hay grabaciones en curso.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                //Variables_Globales.Grabaciones_Iniciadas = false;
            }
        }

        private void Boton_Detener_Streaming_Click(object sender, EventArgs e)
        {
            Metodos.Detener_Camaras_Streaming();
        }

        private void Boton_Iniciar_Streaming_Click(object sender, EventArgs e)
        {
            Metodos.Iniciar_Camaras_Streaming();
        }

    }
}
