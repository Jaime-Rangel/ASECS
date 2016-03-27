using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ASECS
{
    class Camara_PTZ 
    {
        Variables_Camara variables;
        Camara_Individual formulario;

        public Camara_PTZ(Camara_Individual formulario,Variables_Camara variables)
        {
            this.formulario = formulario;
            this.variables = variables;
        }

        public async void Generar_Movimiento_Camara(int comando)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://" + variables.Camara_IP + ":" + variables.Camara_Puerto_CGI + "/decoder_control.cgi?command=" + comando + "&onestep=0&sit=&user=" + variables.Usuario + "&pwd=" + variables.Contraseña + "&next_url=");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException Exception)
            {
                Console.WriteLine("\nException Message :{0} ", Exception.Message);
            }
        }

        public async void Llamar_Posicion_Camara(int comando)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://" + variables.Camara_IP + ":" + variables.Camara_Puerto_CGI + "/decoder_control.cgi?command=" + comando + "&onestep=0&sit="+comando+"&user=" + variables.Usuario + "&pwd=" + variables.Contraseña + "&next_url=");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException Exception)
            {
                Console.WriteLine("\nException Message :{0} ", Exception.Message);
            }
        }

        public void Llenar_Movimientos_Posiciones()
        {
            for(int i=0;i<16;i++)
            {
                formulario.Lista_Mover_Posiciones_Camara.Items.Add(i+1);
                formulario.Lista_Guardar_Posiciones_Camara.Items.Add(i+1);
            }
        }

        public void Verificar_Posicion_Movimiento_Llamada()
        {
            switch(formulario.Lista_Mover_Posiciones_Camara.Text)
            {
                case "1":
                    Llamar_Posicion_Camara(31);
                    break;
                case "2":
                    Llamar_Posicion_Camara(33);
                    break;

                case "3":
                    Llamar_Posicion_Camara(35);
                    break;

                case "4":
                    Llamar_Posicion_Camara(37);
                    break;

                case "5":
                    Llamar_Posicion_Camara(39);
                    break;

                case "6":
                    Llamar_Posicion_Camara(41);
                    break;

                case "7":
                    Llamar_Posicion_Camara(43);
                    break;

                case "8":
                    Llamar_Posicion_Camara(45);
                    break;

                case "9":
                    Llamar_Posicion_Camara(47);
                    break;

                case "10":
                    Llamar_Posicion_Camara(49);
                    break;

                case "11":
                    Llamar_Posicion_Camara(51);
                    break;

                case "12":
                    Llamar_Posicion_Camara(53);
                    break;

                case "13":
                    Llamar_Posicion_Camara(55);
                    break;

                case "14":
                    Llamar_Posicion_Camara(57);
                    break;

                case "15":
                    Llamar_Posicion_Camara(59);
                    break;

                case "16":
                    Llamar_Posicion_Camara(61);
                    break;
            }
        }

        public void Verificar_Posicion_Movimiento_Establecer()
        {
            switch(formulario.Lista_Guardar_Posiciones_Camara.Text)
            {
                case "1":
                    Llamar_Posicion_Camara(30);
                    break;

                case "2":
                    Llamar_Posicion_Camara(32);
                    break;

                case "3":
                    Llamar_Posicion_Camara(34);
                    break;

                case "4":
                    Llamar_Posicion_Camara(36);
                    break;

                case "5":
                    Llamar_Posicion_Camara(38);
                    break;

                case "6":
                    Llamar_Posicion_Camara(40);
                    break;

                case "7":
                    Llamar_Posicion_Camara(42);
                    break;

                case "8":
                    Llamar_Posicion_Camara(44);
                    break;

                case "9":
                    Llamar_Posicion_Camara(46);
                    break;

                case "10":
                    Llamar_Posicion_Camara(48);
                    break;

                case "11":
                    Llamar_Posicion_Camara(50);
                    break;

                case "12":
                    Llamar_Posicion_Camara(52);
                    break;

                case "13":
                    Llamar_Posicion_Camara(54);
                    break;

                case "14":
                    Llamar_Posicion_Camara(56);
                    break;

                case "15":
                    Llamar_Posicion_Camara(58);
                    break;

                case "16":
                    Llamar_Posicion_Camara(60);
                    break;
            }
        }

    }
}
