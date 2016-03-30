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

        Semaphore Semaforo_Control_Uris = new Semaphore(1, 1);

        List<DeviceDescriptionHolder> ONVIFDevices;
        List<Uri> Urls;

        private readonly object[] _transports = { "RTSP", "HTTP", "UDP", "TCP" };

        //Objetos Programa
        Menu_Principal formulario_Menu_Principal;

        Menu_Nueva_Camara_Aspectos Aspectos;
        Variables_Menu_Nueva_Camara Variables_Globales;
        Menu_Nueva_Camara_Metodos Metodos;

        //Hilos Programa
        Thread Buscar_Camaras_Hilo;
        Thread Obtener_Ursl_Hilo;

        public Menu_Nueva_Camara(Menu_Principal formulario_Menu_Principal)
        {
            this.formulario_Menu_Principal = formulario_Menu_Principal;
            InitializeComponent();

            Protocolo_Transporte.Items.Add("RTSP");
            Protocolo_Transporte.Items.Add("HTTP");
            Protocolo_Transporte.Items.Add("UDP");
            Protocolo_Transporte.Items.Add("TCP");
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
        }

        private void Obtener_Listas_Url()
        {
            Thread.Sleep(1000);

            Semaforo_Control_Uris.WaitOne();

            var devHolder = new DeviceDescriptionHolder();

            if (Urls.Count != 0)
            {
                devHolder.Uris = Urls.ToArray();

                foreach (var uri in devHolder.Uris)
                {
                    if (uri.IsAbsoluteUri)
                    {
                        devHolder.Address += uri.DnsSafeHost + "; ";
                    }
                }

                devHolder.Address = devHolder.Address.TrimEnd(';', ' ');

                if (devHolder.Address == "")
                {
                    devHolder.IsInvalidUris = true;
                    devHolder.Address = "Invalid Uri";
                }

                ONVIFDevices.Add(devHolder);
            }

            Semaforo_Control_Uris.Release();
        }

        private void Obtener_Onvif_Url()
        {
            DeviceDescriptionHolder ddh = ONVIFDevices[Lista_Camaras_Disponibles.SelectedIndex];

            ddh.Account = new NetworkCredential { UserName = Texto_Usuario.Text, Password = Texto_Contraseña.Text };
            var sessionFactory = new NvtSessionFactory(ddh.Account);

            var urls = new List<object>();

            foreach (var uri in ddh.Uris)
            {
                var f = sessionFactory.CreateSession(uri);

                ddh.URL = uri.ToString();

                Profile[] profiles = null;
                try
                {
                    profiles = f.GetProfiles().RunSynchronously();
                }
                catch (Exception ex)
                {
                    urls.Add("Verifica que tu Informacion sea correcta.");
                    continue;
                }

                ddh.Profiles = profiles;
                var strSetup = new StreamSetup { transport = new Transport() };
                TransportProtocol tp;
                strSetup.transport.protocol = Enum.TryParse(_transports[Protocolo_Transporte.SelectedIndex].ToString(), true, out tp) ? tp : TransportProtocol.rtsp;
                int i = 0;
                foreach (var p in profiles)
                {
                    var strUri = f.GetStreamUri(strSetup, p.token).RunSynchronously();
                    string urlAuth = strUri.uri.Replace("://",
                                                    "://[USERNAME]:[PASSWORD]@");
                    string uriDisp = strUri.uri;
                    string streamSize = p.videoEncoderConfiguration.resolution.width + "x" + p.videoEncoderConfiguration.resolution.height;
                    uriDisp += " (" + streamSize + ")";

                    urls.Add(new ListItem(uriDisp, new[] { urlAuth, streamSize, ddh.Account.UserName, ddh.Account.Password, ddh.Name, i.ToString(CultureInfo.InvariantCulture) }));
                    i++;
                }

            }

            Lista_Url_Camara_Seleccionada.Items.AddRange(urls.ToArray());
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
            Semaforo_Control_Uris.WaitOne();
            IPCameraFactory.DeviceDiscovered += Camaras_IP_Descubiertas;
            IPCameraFactory.DiscoverDevices();
            Semaforo_Control_Uris.Release();

            //Version ineficiente
            //Buscar_Camaras_Hilo.Abort();
        }

        private void Camaras_IP_Descubiertas(object sender, DiscoveryEventArgs e)
        {
            if (this.Lista_Camaras_Disponibles.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                    Lista_Camaras_Disponibles.Items.Add(e.Device.Uri);
                    Urls.Add(e.Device.Uri);
                });
            }
            else
            {
                Lista_Camaras_Disponibles.Items.Add(e.Device.Uri);
                Urls.Add(e.Device.Uri);
            }

        }


        private void Boton_Actualizar_Camaras_Click_1(object sender, EventArgs e)
        {
            Urls = new List<Uri>();
            ONVIFDevices = new List<DeviceDescriptionHolder>();
            Lista_Camaras_Disponibles.Items.Clear();

            IPCameraFactory.DeviceDiscovered -= Camaras_IP_Descubiertas;
            
            Buscar_Camaras_Hilo = new Thread(() => Obtener_IP_Camaras());
            Buscar_Camaras_Hilo.Start();

            //Version ineficiente
            //while(Buscar_Camaras_Hilo.IsAlive)
            //{
            //    System.Console.WriteLine("Wait");
            //}

            Obtener_Ursl_Hilo = new Thread(() => Obtener_Listas_Url());
            Obtener_Ursl_Hilo.Start();

        }

        private void Boton_Agregar_Camara_Click(object sender, System.EventArgs e)
        {
            string text = Lista_Camaras_Disponibles.GetItemText(Lista_Camaras_Disponibles.SelectedItem);
            if (text != "")
            {
                //Todo
                Obtener_Onvif_Url();
            }
            else
            {
                MessageBox.Show("Selecciona Una Camara");
            }
        }

        private void Boton_Seleccionar_Camara_Click(object sender, EventArgs e)
        {
            Obtener_Onvif_Url();
        }

    }
}
