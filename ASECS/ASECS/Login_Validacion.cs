using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Login_Validacion
    {
        Login formulario_login;


        public Login_Validacion(Login form)
        {
            formulario_login = form;
        }

        public int Validar_Campos()
        {
            if (formulario_login.Texto_Usuario.Text == "" && formulario_login.Texto_Contraseña.Text == "")
            {
                formulario_login.Texto_Usuario.Focus();
                formulario_login.campos_verificados = false;
                return 3;
            }
            else
                if (formulario_login.Texto_Usuario.Text != "" && formulario_login.Texto_Contraseña.Text == "")
                {
                    formulario_login.campos_verificados = false;
                    return 2;
                }
                else
                    if (formulario_login.Texto_Usuario.Text == "" && formulario_login.Texto_Contraseña.Text != "")
                    {
                        formulario_login.campos_verificados = false;
                        return 1;
                    }
                    else
                    {
                        formulario_login.campos_verificados = true;
                        return 0;
                    }
        }

        public int Validar_Usuario_BD()
        {
            int respuesta;

            try
            {
                Hashtable lista_usuarios = new Hashtable();

                MySqlDataReader Lectura_Usuarios = null;

                //Crear Conexion
                Conexion_BD login = new Conexion_BD();

                login.Crear_Conexion();
                string id = "SELECT Usuario,Contraseña FROM usuarios";

                MySqlCommand id_comando = new MySqlCommand(id, login.Obtener_Conexion());
                Lectura_Usuarios = id_comando.ExecuteReader();

                while (Lectura_Usuarios.Read())
                {
                    lista_usuarios.Add(Lectura_Usuarios.GetString(0), Lectura_Usuarios.GetString(1));
                }

                respuesta = Verificar_Usuario(lista_usuarios);

                return respuesta;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return 0;
            }

        }

        public int Verificar_Usuario(Hashtable usuarios)
        {
            ICollection key = usuarios.Keys;
            bool usuario_validado = false;
            bool contrase_validada = false;
            int respuesta = 0;

            foreach (string k in key)
            {

                if (formulario_login.Texto_Usuario.Text == (Convert.ToString(k)) && formulario_login.Texto_Contraseña.Text == (Convert.ToString(usuarios[k])))
                {
                    usuario_validado = true;
                    contrase_validada = true;
                    formulario_login.sesion_verificada = true;
                    respuesta = 1;
                    break;
                }
                else
                    if (formulario_login.Texto_Usuario.Text == (Convert.ToString(k)))
                    {
                        usuario_validado = true;
                    }
            }

            if (usuario_validado == true && contrase_validada == false)
            {
                formulario_login.sesion_verificada = false;
                respuesta = 2;
            }
            else
                if (usuario_validado == false)
                {
                    formulario_login.sesion_verificada = false;
                    respuesta = 3;
                }

            return respuesta;

        }
    }
}
