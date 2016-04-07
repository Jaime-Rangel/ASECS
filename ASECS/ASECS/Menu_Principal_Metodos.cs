using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Menu_Principal_Metodos
    {
        Menu_Principal formulario_principal;

        public Menu_Principal_Metodos(Menu_Principal formulario_principal)
        {
            this.formulario_principal = formulario_principal;
        }

        public void Asignar_Parametros_Icono_Notificacion()
        {
            formulario_principal.Icono_Notificacion.Icon = new Icon(SystemIcons.Application, 40, 40);
            formulario_principal.Icono_Notificacion.BalloonTipTitle = "ASECS";
            formulario_principal.Icono_Notificacion.BalloonTipText = "Se ha minimizado ASECS pero sigue en funcionamiento";
        }


    }
}
