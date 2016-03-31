using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ASECS
{
    class Variables_Menu_Nueva_Camara
    {
        public List<DeviceDescriptionHolder> ONVIFDevices
        {
            get;
            set;
        }

        public List<Uri> Urls
        {
            get;
            set;
        }

        public List<object> Urls_Onvif
        {
            get;
            set;
        }

        public Semaphore Semaforo_Control_Uris
        {
            get;
            set;
        }

        public string Usuario
        {
            get;
            set;
        }

        public string Contraseña
        {
            get;
            set;
        }

        public string Url_RSTP
        {
            get;
            set;
        }

        public string Puerto_CGI
        {
            get;
            set;
        }

        public string Direccion_IP
        {
            get;
            set;
        }
    }
}
