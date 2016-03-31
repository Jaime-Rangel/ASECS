using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using System.Threading;
using System.Net;
using odm.core;
using onvif.services;
using Microsoft;
using onvif.utils;
using utils;
using System.Globalization;

namespace ASECS
{
    public partial class Menu_Nueva_Camara : Form
    {
        //Objetos Programa

        Menu_Nueva_Camara_Aspectos Aspectos;
        Variables_Menu_Nueva_Camara Variables_Globales;
        Menu_Nueva_Camara_Metodos Metodos;
        AxoPlayerLib.AxoPlayer Nueva_Camara;
        Menu_Principal formulario_Menu_Principal;

        //Hilos Programa
        Thread Buscar_Camaras_Hilo;
        Thread Obtener_Ursl_Hilo;

        public Menu_Nueva_Camara(Menu_Principal formulario_Menu_Principal)
        {
            this.formulario_Menu_Principal = formulario_Menu_Principal;
            InitializeComponent();
        }

        private void Menu_Nueva_Camara_Load(object sender, System.EventArgs e)
        {
            Inicializar_Objetos();
            Aspectos.Acomodar_Elementos();
        }

        public void Inicializar_Objetos()
        {
            Aspectos = new Menu_Nueva_Camara_Aspectos(this);
            Variables_Globales = new Variables_Menu_Nueva_Camara();
            Metodos = new Menu_Nueva_Camara_Metodos(this);
            Variables_Globales.Semaforo_Control_Uris = new Semaphore(1,1);
        }

        public struct ListItem
        {
            private readonly string _name;
            internal readonly string[] Value;

            public ListItem(string name, string[] value)
            {
                _name = name;
                Value = value;
            }

            public override string ToString()
            {
                return _name;
            }
        }

        void Obtener_IP_Camaras()
        {
            Variables_Globales.Semaforo_Control_Uris.WaitOne();
            IPCameraFactory.DeviceDiscovered += Camaras_IP_Descubiertas;
            IPCameraFactory.DiscoverDevices();
            Variables_Globales.Semaforo_Control_Uris.Release();
        }

        private void Camaras_IP_Descubiertas(object sender, DiscoveryEventArgs e)
        {
            if (this.Lista_Camaras_Disponibles.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                    Lista_Camaras_Disponibles.Items.Add(e.Device.Uri);
                    Variables_Globales.Urls.Add(e.Device.Uri);
                });
            }
            else
            {
                Lista_Camaras_Disponibles.Items.Add(e.Device.Uri);
                Variables_Globales.Urls.Add(e.Device.Uri);
            }

        }

        private void Boton_Actualizar_Camaras_Click_1(object sender, EventArgs e)
        {
            Variables_Globales.Urls_Onvif = new List<object>();
            Variables_Globales.Urls = new List<Uri>();
            Variables_Globales.ONVIFDevices = new List<DeviceDescriptionHolder>();
            Lista_Camaras_Disponibles.Items.Clear();
            Lista_Url_Camara_Seleccionada.Items.Clear();

            IPCameraFactory.DeviceDiscovered -= Camaras_IP_Descubiertas;
            
            Buscar_Camaras_Hilo = new Thread(() => Obtener_IP_Camaras());
            Buscar_Camaras_Hilo.Start();

            Obtener_Ursl_Hilo = new Thread(() => Metodos.Obtener_Listas_Url(ref Variables_Globales));
            Obtener_Ursl_Hilo.Start();

        }

        private void Asignar_Parametros_Variables()
        {
            Variables_Globales.Usuario = Texto_Usuario.Text;
            Variables_Globales.Contraseña = Texto_Contraseña.Text;
            Variables_Globales.Puerto_CGI = Texto_Puerto_CGI.Text;
            Variables_Globales.Direccion_IP = Texto_Direccion_IP.Text;
            Variables_Globales.Url_RSTP = Convert.ToString(Variables_Globales.Urls_Onvif[Lista_Url_Camara_Seleccionada.SelectedIndex]);
        }

        private void Boton_Agregar_Camara_Click(object sender, System.EventArgs e)
        {
            string text = Lista_Url_Camara_Seleccionada.GetItemText(Lista_Url_Camara_Seleccionada.SelectedItem);

            if (text != "")
            {
                //Todo
                int respuesta = Metodos.Verificar_Puerto_CGI();

                if (respuesta == 1 || respuesta == 3)
                {
                    Asignar_Parametros_Variables();

                    //MessageBox.Show(Convert.ToString(Variables_Globales.Urls_Onvif[Lista_Url_Camara_Seleccionada.SelectedIndex]));
                    formulario_Menu_Principal.Menu_Lista_Camaras.Controls.Add(Nueva_Camara = new AxoPlayerLib.AxoPlayer());

                    Nueva_Camara.Width = 400;
                    Nueva_Camara.Height = 300;
                    Nueva_Camara.PlayVideo(Variables_Globales.Usuario,Variables_Globales.Contraseña,Variables_Globales.Direccion_IP,Convert.ToInt32(Variables_Globales.Puerto_CGI),0,0);
                }
                else
                {
                    MessageBox.Show("Porfavor introduce el puerto CGI",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Selecciona Una Camara");
            }
        }

        private void Boton_Seleccionar_Camara_Click(object sender, EventArgs e)
        {
            bool respuesta;
            Lista_Url_Camara_Seleccionada.Items.Clear();
            respuesta = Metodos.Verificar_Campos_Boton_Seleccionar();

            if (!respuesta)
            {
                MessageBox.Show("Porfavor completa todos los campos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (Lista_Camaras_Disponibles.SelectedIndex != -1)
                {
                    Metodos.Obtener_Onvif_Url(ref Variables_Globales);
                }
                else
                {
                    MessageBox.Show("Porfavor Selecciona Una direccion IP.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
          
        }

        private void Checkeo_Cambio_Puerto_CGI_CheckedChanged(object sender, EventArgs e)
        {
            if(Checkeo_Cambio_Puerto_CGI.Checked == true)
            {
                Texto_Puerto_CGI.ReadOnly = false;
            }
            else
            {
                Texto_Puerto_CGI.Text = "81";
                Texto_Puerto_CGI.ReadOnly = true;
            }
        }

        private void Texto_Puerto_CGI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
