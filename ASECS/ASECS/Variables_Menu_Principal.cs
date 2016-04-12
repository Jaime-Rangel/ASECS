using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace ASECS
{
    public class Variables_Menu_Principal
    {
        public string Nombre_Usuario
        {
            get;
            set;
        }

        public string Ruta_Grabacion
        {
            get;
            set;
        }

        public bool Grabaciones_Iniciadas
        {
            get;
            set;
        }

        public bool Streaming_Activo
        {
            get;
            set;
        }

        public DirectoryInfo Directorio_Grabacion
        {
            get;
            set;
        }

        public Timer Timer_Grabacion
        {
            get;
            set;
        }
    }
}
