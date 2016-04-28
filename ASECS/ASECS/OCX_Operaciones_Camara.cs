using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
namespace ASECS
{
    class OCX_Operaciones_Camara
    {
        Camara_Individual formulario;
        Variables_Camara variables;

        public OCX_Operaciones_Camara(Camara_Individual formulario,Variables_Camara variables)
        {
            this.formulario = formulario;
            this.variables = variables;
        }

        public void Iniciar_Streaming()
        {
            formulario.Ventana_Camara_IP.PlayVideo(variables.Usuario,variables.Contraseña,variables.Camara_IP,Convert.ToInt32(variables.Camara_Puerto_CGI),0,0);
        }

        public void Detener_Streaming()
        {
            formulario.Ventana_Camara_IP.StopVideo();
            formulario.Ventana_Camara_IP.Refresh();
        }

        public void Escuchar_Audio_Camara()
        {
            formulario.Ventana_Camara_IP.OpenSound();
        }

        public void Bloquear_Audio_Camara()
        {
            formulario.Ventana_Camara_IP.CloseSound();
        }

        public void Hablar_Audio_Camara()
        {
            if (formulario.Checkeo_Hablar_Camara.Checked == true)
            {
                formulario.Ventana_Camara_IP.StartTalk();
            }
            else
            {
                formulario.Ventana_Camara_IP.StopTalk();
            }
        }

        public int Verificar_Conexion_Camara_Streaming(string ip)
        {
            long totalTime = 0;
            int timeout = 120;

            Ping pingSender = new Ping();

            for (int i = 0; i < 1000; i++)
            {
                PingReply reply = pingSender.Send(ip, timeout);
                if (reply.Status == IPStatus.Success)
                {
                    totalTime += reply.RoundtripTime;
                }
                else
                {
                    break;
                }
            }
            return Convert.ToInt32(totalTime);
        }
    }
}
