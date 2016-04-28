using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    public class Video_Grabacion
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
            variables.Directorio_VLC = new DirectoryInfo(formulario.formulario_principal.Sesion_Usuario.Directorio_VLC);
            //variables.Directorio_VLC = new DirectoryInfo(@"C:\\Program Files (x86)\\VideoLAN\\VLC");
            formulario.Ventana_Grabacion_Video.VlcLibDirectory = variables.Directorio_VLC;
            //Permite asignar el directorio externamente
            ((System.ComponentModel.ISupportInitialize)(formulario.Ventana_Grabacion_Video)).EndInit();
            formulario.Ventana_Grabacion_Video.Visible = false;
        }

        public void Grabar_Video_Streaming()
        {
            //DateTime now = DateTime.Now;
            //string fecha;
            //string año = Convert.ToString(now.Year);
            //string mes = Convert.ToString(now.Month);
            //string dia = Convert.ToString(now.Day);
            //string hora = Convert.ToString(now.Hour);
            //hora = hora + "-" + Convert.ToString(now.Minute);
            //hora = hora + "-" + Convert.ToString(now.Second);
            //fecha = dia + "-" + mes + "-" + año + "-" + hora;

            //control.Play(new Uri("rtsp://" + Resultado.Usuario + ":" + Resultado.Contraseña + "@" + Resultado.Direccion_IP + ":" + Resultado.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='C:\\Users\\jaime\\test.mp4'}");
            //control.Play(new Uri("rtsp://" + Resultado.Usuario + ":" + Resultado.Contraseña + "@" + Resultado.Direccion_IP + ":" + Resultado.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='" + Variables_Globales.Ruta_Grabacion + "\\" + Resultado.Alias + "-" + fecha + ".mp4'}");
 
            //formulario.Ventana_Grabacion_Video.Play(new Uri("rtsp://" + variables.Usuario + ":" + variables.Contraseña + "@" + variables.Camara_IP + ":" + variables.Camara_Puerto_RTSP + "/udp/av0_0"), variables.Ruta_Grabacion + formulario.Nombre_Camara + "-" + fecha + ".mp4'}");

            string fecha;

            DateTime now = DateTime.Now;
            string año = Convert.ToString(now.Year);
            string mes = Convert.ToString(now.Month);
            string dia = Convert.ToString(now.Day);
            string hora = Convert.ToString(now.Hour);
            hora = hora + "_" + Convert.ToString(now.Minute);
            hora = hora + "_" + Convert.ToString(now.Second);

            string alias_aux = formulario.Objeto_Camara.Alias.Replace(" ","-");

            StringBuilder alias_limpio = new StringBuilder(alias_aux);

            string myString =
                alias_limpio
                  .Replace("Á", "A")
                  .Replace("É", "E")
                  .Replace("Í", "I")
                  .Replace("Ó", "O")
                  .Replace("Ú", "U")
                  .Replace("Ñ", "N")
                  .Replace("á", "a")
                  .Replace("é", "e")
                  .Replace("í", "i")
                  .Replace("ó", "o")
                  .Replace("ú", "u")
                  .Replace("ñ", "n")
                  .ToString();

            fecha = dia + "_" + mes + "_" + año + "_" + hora;

            //control.Play(new Uri("rtsp://" + Resultado.Usuario + ":" + Resultado.Contraseña + "@" + Resultado.Direccion_IP + ":" + Resultado.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='C:\\Users\\jaime\\test.mp4'}");
            formulario.Ventana_Grabacion_Video.Play(new Uri("rtsp://" + formulario.Objeto_Camara.Usuario + ":" + formulario.Objeto_Camara.Contraseña + "@" + formulario.Objeto_Camara.Direccion_IP + ":" + formulario.Objeto_Camara.Puerto_RSTP + "/udp/av0_0"), ":sout=#std{access=file,mux=mp4, dst='" + formulario.Variables_Globales.Ruta_Grabacion + "\\" + alias_limpio + "_" + fecha + ".mp4'}");

        }

        public void Detener_Grabacion_Streaming()
        {
            formulario.Ventana_Grabacion_Video.Stop();
        }
    }
}
