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

namespace ASECS
{
    public partial class Menu_Nueva_Camara : Form
    {
        private CameraURLBuilderWF ConstructorURL;
        Menu_Nueva_Camara_Aspectos Aspectos;
        Thread Buscar_Camaras_Hilo;

        public Menu_Nueva_Camara()
        {
            InitializeComponent();
        }

        private void Menu_Nueva_Camara_Load(object sender, EventArgs e)
        {
            Inicializar_Objetos();
            Aspectos.Acomodar_Elementos();
        }

        public void Inicializar_Objetos()
        {
            Aspectos = new Menu_Nueva_Camara_Aspectos(this);
            ConstructorURL =  new CameraURLBuilderWF();
        }

        void GetIpCameras()
        {
            IPCameraFactory.DeviceDiscovered += IPCameraFactory_DeviceDiscovered;
            IPCameraFactory.DiscoverDevices();
        }

        private void IPCameraFactory_DeviceDiscovered(object sender, DiscoveryEventArgs e)
        {
            
            if (this.Lista_Camaras_Disponibles.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                    Lista_Camaras_Disponibles.Items.Add("[IPCamera] Host: " + e.Device.Host + " Port: " + e.Device.Port); ;
                });
            }
            else
            {
                Lista_Camaras_Disponibles.Items.Add("[IPCamera] Host: " + e.Device.Host + " Port: " + e.Device.Port); ;
            }
        }

        public void Buscar_Camaras_Red()
        {
            Buscar_Camaras_Hilo = new Thread(() => GetIpCameras());
            Buscar_Camaras_Hilo.Start();
        }

        private void Boton_Buscar_Camaras_Click(object sender, EventArgs e)
        {
            Buscar_Camaras_Red();
        }

        private void Boton_Agregar_Camara_Click(object sender, EventArgs e)
        {
            string text = Lista_Camaras_Disponibles.GetItemText(Lista_Camaras_Disponibles.SelectedItem);
            if (text != "")
            {
                MessageBox.Show(text);
            }
            else
            {
                MessageBox.Show("Selecciona Una Camara");
            }
        }

    }
}
