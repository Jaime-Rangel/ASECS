using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    public class Variables_Camara
    {
        public string Camara_IP
        {
            get;
            set;
        }

        public string Camara_Puerto_CGI
        {
            set;
            get;
        }

        public string Camara_Puerto_RTSP
        {
            get;
            set;
        }

        public string Ruta_Grabacion
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

        public DirectoryInfo Directorio_VLC
        {
            get;
            set;
        }

        public bool Camara_Activa
        {
            get;
            set;
        }

        public bool Camara_Grabando
        {
            get;
            set;
        }
    }
}
