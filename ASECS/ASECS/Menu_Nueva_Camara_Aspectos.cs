using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Menu_Nueva_Camara_Aspectos
    {
        Menu_Nueva_Camara formulario;

        public Menu_Nueva_Camara_Aspectos(Menu_Nueva_Camara formulario)
        {
            this.formulario = formulario;
        }

        public void Acomodar_Elementos()
        {
            formulario.Protocolo_Transporte.Items.Add("RTSP");
            formulario.Protocolo_Transporte.Items.Add("HTTP");
            formulario.Protocolo_Transporte.Items.Add("UDP");
            formulario.Protocolo_Transporte.Items.Add("TCP");

            formulario.Texto_Puerto_CGI.ReadOnly = true;
            formulario.Texto_Direccion_IP.ReadOnly = true;
            formulario.Texto_Puerto_RTSP.ReadOnly = true;
            formulario.Texto_Puerto_CGI.Text = "81";

            formulario.Lista_Camaras_Disponibles.Left = (formulario.Grupo_Lista_Camaras.Width - formulario.Lista_Camaras_Disponibles.Width) / 2;
            formulario.Lista_Url_Camara_Seleccionada.Left = (formulario.Grupo_Urls_Camara.Width - formulario.Lista_Url_Camara_Seleccionada.Width) / 2;
            formulario.Boton_Agregar_Camara.Left = (formulario.Grupo_Lista_Camaras.Width - formulario.Boton_Agregar_Camara.Width) / 2;
            formulario.Boton_Seleccionar_Camara.Left = (formulario.Grupo_Lista_Camaras.Width - formulario.Boton_Seleccionar_Camara.Width) / 2;

        }

    }
}
