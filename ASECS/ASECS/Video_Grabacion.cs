using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Video_Grabacion
    {
        //atributos
        Camara_Individual formulario;
        Variables_Camara variables;

        public Video_Grabacion(Camara_Individual formulario,Variables_Camara variables)
        {
            this.formulario = formulario;
            this.variables = variables;
        }

        public void Asignar_Directorio_VLC()
        {
            variables.Directorio_VLC = new DirectoryInfo(@"C:\\Program Files (x86)\\VideoLAN\\VLC");
            formulario.Ventana_Grabacion_Video.VlcLibDirectory = variables.Directorio_VLC;
            //Permite asignar el directorio externamente
            ((System.ComponentModel.ISupportInitialize)(formulario.Ventana_Grabacion_Video)).EndInit();
            formulario.Ventana_Grabacion_Video.Visible = false;
        }

        public void Grabar_Video_Streaming()
        {
            DateTime now = DateTime.Now;
            string fecha;
            string año = Convert.ToString(now.Year);
            string mes = Convert.ToString(now.Month);
            string dia = Convert.ToString(now.Day);
            string hora = Convert.ToString(now.Hour);
            hora = hora + "-" + Convert.ToString(now.Minute);
            hora = hora + "-" + Convert.ToString(now.Second);
            fecha = dia + "-" + mes + "-" + año + "-" + hora;

            //control.Play(new Uri("rtsp://" + Resultado.Usuario + ":" + Resultado.Contraseña + "@" + Resultado.Direccion_IP + ":" + Resultado.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='C:\\Users\\jaime\\test.mp4'}");
            //control.Play(new Uri("rtsp://" + Resultado.Usuario + ":" + Resultado.Contraseña + "@" + Resultado.Direccion_IP + ":" + Resultado.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='" + Variables_Globales.Ruta_Grabacion + "\\" + Resultado.Alias + "-" + fecha + ".mp4'}");
 
            formulario.Ventana_Grabacion_Video.Play(new Uri("rtsp://" + variables.Usuario + ":" + variables.Contraseña + "@" + variables.Camara_IP + ":" + variables.Camara_Puerto_RTSP + "/udp/av0_0"), variables.Ruta_Grabacion + formulario.Nombre_Camara + "-" + fecha + ".mp4'}");
        }

        public void Detener_Grabacion_Streaming()
        {
            formulario.Ventana_Grabacion_Video.Stop();
        }
    }
}
