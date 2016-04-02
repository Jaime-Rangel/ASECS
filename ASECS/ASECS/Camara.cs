using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    public class Camara
    {
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

        public string Alias
        {
            get;
            set;
        }

        public string Direccion_IP
        {
            get;
            set;
        }

        public string Url_RSTP
        {
            get;
            set;
        }

        public bool Invertida_Modo_Espejo
        {
            get;
            set;
        }

        public bool Invertida
        {
            get;
            set;
        }

        public bool Modo_Espejo
        {
            get;
            set;
        }

        public string Puerto_CGI
        {
            get;
            set;
        }

    }
}
