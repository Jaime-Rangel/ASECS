using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    public class Menu_Principal_Metodos
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

        public void Detener_Camaras_Streaming()
        {
            foreach (AxoPlayerLib.AxoPlayer control in formulario_principal.Menu_Lista_Camaras.Controls)
            {
                control.StopVideo();
                control.Refresh();
            }
        }

        public void Iniciar_Camaras_Streaming()
        {
            Camara Objeto_Camara;
            Camara Resultado;

            int cont=0;

            foreach (AxoPlayerLib.AxoPlayer control in formulario_principal.Menu_Lista_Camaras.Controls)
            {
                var Alias = formulario_principal.Lista_Camaras_Alias[cont];
                Objeto_Camara = new Camara();
                Resultado = new Camara();

                Objeto_Camara.Alias = Alias;
                Resultado = formulario_principal.Lista_Camaras.Buscar(Objeto_Camara);

                control.PlayVideo(Resultado.Usuario, Resultado.Contraseña, Resultado.Direccion_IP, Convert.ToInt32(Resultado.Puerto_CGI), 0, 0);

                cont++;
            }
        }

    }
}
