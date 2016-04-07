using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Ozeki.Camera;
using Ozeki.Media;
using System.Net;
using odm.core;
using onvif.services;
using Microsoft;
using onvif.utils;
using utils;
using System.Globalization;

namespace ASECS
{
    class Menu_Nueva_Camara_Metodos
    {
        Menu_Nueva_Camara formulario;
        private readonly object[] _transports = { "RTSP", "HTTP", "UDP", "TCP" };

        string[] separators = { "rtsp://","/",":"};

        public Menu_Nueva_Camara_Metodos(Menu_Nueva_Camara formulario)
        {
            this.formulario = formulario;
        }
        
        public void Limpiar_Campos_Actualizar()
        {
            formulario.Texto_Direccion_IP.Text = "";
            formulario.Texto_Puerto_RTSP.Text = "";
            formulario.Texto_Alias.Text = "";
        }

        public void Obtener_Listas_Url(ref Variables_Menu_Nueva_Camara Variables_Globales)
        {
            var devHolder = new DeviceDescriptionHolder();

            if (Variables_Globales.Urls.Count != 0)
            {
                devHolder.Uris = Variables_Globales.Urls.ToArray();

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
                Variables_Globales.ONVIFDevices.Add(devHolder);
            }

        }

        public void Obtener_Onvif_Url(ref Variables_Menu_Nueva_Camara Variables)
        {

            DeviceDescriptionHolder ddh = Variables.ONVIFDevices[formulario.Lista_Camaras_Disponibles.SelectedIndex];

            formulario.Texto_Direccion_IP.Text = ddh.Address;

            ddh.Account = new NetworkCredential { UserName = formulario.Texto_Usuario.Text, Password = formulario.Texto_Contraseña.Text };

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
                strSetup.transport.protocol = Enum.TryParse(_transports[formulario.Protocolo_Transporte.SelectedIndex].ToString(), true, out tp) ? tp : TransportProtocol.rtsp;
                
                int i = 0;

                foreach (var p in profiles)
                {
                    var strUri = f.GetStreamUri(strSetup, p.token).RunSynchronously();

                    string urlAuth = strUri.uri.Replace("://",
                                                    "://[USERNAME]:[PASSWORD]@");
                    string uriDisp = strUri.uri;

                    //Agrega URLS limpias
                    Variables.Urls_Onvif.Add(uriDisp);

                    string streamSize = p.videoEncoderConfiguration.resolution.width + "x" + p.videoEncoderConfiguration.resolution.height;
                    uriDisp += " (" + streamSize + ")";

                    urls.Add(new ListItem(uriDisp, new[] { urlAuth, streamSize, ddh.Account.UserName, ddh.Account.Password, ddh.Name, i.ToString(CultureInfo.InvariantCulture) }));
                    i++;
                }

                string guardar_puerto = Convert.ToString(urls[0]);

                string[] words = guardar_puerto.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                int cont=0;

                foreach(var word in words)
                {
                    if (cont == 1)
                    {
                        formulario.Texto_Puerto_RTSP.Text = word;
                    }

                    cont++;
                }

            }

            formulario.Lista_Url_Camara_Seleccionada.Items.AddRange(urls.ToArray());
        }

        public bool Verificar_Campos_Boton_Seleccionar()
        {
            if(formulario.Texto_Usuario.Text!=""&&formulario.Texto_Contraseña.Text!=""&&formulario.Protocolo_Transporte.Text!=""&&formulario.Lista_Camaras_Disponibles.Items.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public int Verificar_Puerto_CGI()
        {
            if (formulario.Checkeo_Cambio_Puerto_CGI.Checked == true)
            {
                if (formulario.Texto_Puerto_CGI.Text != "")
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
            else
                return 1;
        }
    }
}
