using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using MySql.Data.MySqlClient;

namespace ASECS
{
    class Camara_CGI
    {
        Variables_Camara variables;
        Camara_Individual formulario;

        public Camara_CGI(Camara_Individual formulario,Variables_Camara variables)
        {
            this.formulario = formulario;
            this.variables = variables;
        }

        private async void Ejectuar_Comando_Inversion(int comando)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://" + variables.Camara_IP + ":" + variables.Camara_Puerto_CGI + "/camera_control.cgi?param=5&value=" + comando + "&user=" + variables.Usuario + "&pwd=" + variables.Contraseña + "&next_url=");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException Exception)
            {
                Console.WriteLine("\nException Message :{0} ", Exception.Message);
            }
        }

        public void Actualizar_Camara_Modo_Espejo_BD(int valor)
        {
            Conexion_BD registro = new Conexion_BD();
            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Camara_Modo_Espejo(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", formulario.Objeto_Camara.Camara_ID);
            chec.Parameters.AddWithValue("@C2", valor);
            chec.ExecuteNonQuery();

            registro.Cerrar_Conexion();
        }

        public void Actualizar_Camara_Invertida_BD(int valor)
        {
            Conexion_BD registro = new Conexion_BD();
            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Camara_Invertida(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", formulario.Objeto_Camara.Camara_ID);
            chec.Parameters.AddWithValue("@C2", valor);
            chec.ExecuteNonQuery();

            registro.Cerrar_Conexion();
        }

        public void Invertir_Horizontal_Vertical_Streaming()
        {
            if (formulario.Checkeo_Intervir_Camara.Checked == true && formulario.Checkeo_Modo_Espejo.Checked == true)
            {
                Ejectuar_Comando_Inversion(3);
            }
            else
                if (formulario.Checkeo_Intervir_Camara.Checked == true)
                {
                    Ejectuar_Comando_Inversion(1);
                }
                else
                    if (formulario.Checkeo_Modo_Espejo.Checked == true)
                    {
                        Ejectuar_Comando_Inversion(2);
                    }
                    else
                    {
                        Ejectuar_Comando_Inversion(0);
                    }
        }
    }
}
