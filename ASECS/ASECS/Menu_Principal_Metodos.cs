using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            formulario_principal.Icono_Minimizar.Icon = new Icon(SystemIcons.Application, 40, 40);
            formulario_principal.Icono_Minimizar.Text = "Regresar a Asecs";
            formulario_principal.Icono_Minimizar.Visible = true;

            formulario_principal.Icono_Minimizar.BalloonTipText = "Asecs sigue en funcionamiento";
            formulario_principal.Icono_Minimizar.BalloonTipTitle = "Aviso Importante";
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

        public void Insertar_Camara_BD(Menu_Nueva_Camara formulario_Nueva_Camara)
        {
            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Insertar_Camara(@C1,@C2,@C3,@C4,@C5,@C6,@C7,@C8,@C9,@C10);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1",formulario_Nueva_Camara.Texto_Usuario.Text);
            chec.Parameters.AddWithValue("@C2",formulario_Nueva_Camara.Texto_Contraseña.Text);
            chec.Parameters.AddWithValue("@C3", formulario_Nueva_Camara.Texto_Alias.Text);
            chec.Parameters.AddWithValue("@C4", formulario_Nueva_Camara.Texto_Direccion_IP.Text);
            chec.Parameters.AddWithValue("@C5", formulario_Nueva_Camara.Texto_Puerto_CGI.Text);
            chec.Parameters.AddWithValue("@C6", formulario_Nueva_Camara.Texto_Puerto_RTSP.Text);
            chec.Parameters.AddWithValue("@C7", false);
            chec.Parameters.AddWithValue("@C8", false);
            chec.Parameters.AddWithValue("@C9", false);
            chec.Parameters.AddWithValue("@C10", null);

            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();

        }

        public int Obtener_ID_Usuario_BD(Menu_Nueva_Camara Formulario_Nueva_Camara)
        {
            string buscando_id = "";
            int id_Usuario;
            Conexion_BD registro = new Conexion_BD();
            registro.Crear_Conexion();
            string buscar = "CALL Obtener_ID_Usuario(@C1);";
            MySqlCommand chec = new MySqlCommand(buscar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1",formulario_principal.Sesion_Usuario.Nombre_Usuario);
            MySqlDataReader leer = chec.ExecuteReader();

            while (leer.Read())
            {
                buscando_id = Convert.ToString(leer.GetString(0));
            }

            id_Usuario = Convert.ToInt32(buscando_id);

            return id_Usuario;

            registro.Cerrar_Conexion();

        }

        public int Obtener_Ultimo_ID_Camara_BD()
        {
            string buscando_id = "";
            int id_Camara;
            Conexion_BD registro = new Conexion_BD();
            registro.Crear_Conexion();
            string buscar = "CALL Obtener_ID_Ultima_Insersion_Camara;";
            MySqlCommand chec = new MySqlCommand(buscar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            MySqlDataReader leer = chec.ExecuteReader();

            while (leer.Read())
            {
                buscando_id = Convert.ToString(leer.GetString(0));
            }

            id_Camara = Convert.ToInt32(buscando_id);

            return id_Camara;

            registro.Cerrar_Conexion();

        }

        public void Insertar_Tabla_Usuario_Camara_BD(int id_Camara,int id_Usuario)
        {
            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Insertar_Tabla_Usuario_Camara(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", id_Camara);
            chec.Parameters.AddWithValue("@C2", id_Usuario);

            chec.ExecuteNonQuery();

            registro.Cerrar_Conexion();

        }

        public void Cargar_Camaras_Usuario_BD(int id_Usuario)
        {
            Camara Objeto_Camara = new Camara();
            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string buscar = "CALL Obtener_Camaras_Usuario(@C1);";
            MySqlCommand chec = new MySqlCommand(buscar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", id_Usuario);
            MySqlDataReader leer = chec.ExecuteReader();

            while (leer.Read())
            {
                Objeto_Camara.Camara_ID = leer.GetInt32(0);
                Objeto_Camara.Usuario = leer.GetString(1);
                Objeto_Camara.Contraseña = leer.GetString(2);
                Objeto_Camara.Alias = leer.GetString(3);
                Objeto_Camara.Direccion_IP = leer.GetString(4);
                Objeto_Camara.Puerto_CGI = leer.GetString(5);
                Objeto_Camara.Puerto_RSTP = leer.GetString(6);
                Objeto_Camara.Invertida = Convert.ToBoolean(leer.GetString(7));
                Objeto_Camara.Modo_Espejo = Convert.ToBoolean(leer.GetString(8));
                Objeto_Camara.Invertida_Modo_Espejo = Convert.ToBoolean(leer.GetString(9));

                if (leer.IsDBNull(10) == true)
                {
                    Agregar_Camaras_Elementos_Graficos(Objeto_Camara);
                    //Objeto_Camara.Posicion_Predeterminada = leer.GetInt32(9);

                }
                else
                {
                    Objeto_Camara.Posicion_Predeterminada = leer.GetInt32(9);
                    Agregar_Camaras_Elementos_Graficos(Objeto_Camara);
                }

            }

            registro.Cerrar_Conexion();

        }

        public void Agregar_Camaras_Elementos_Graficos(Camara Objeto_Camara)
        {
            AxoPlayerLib.AxoPlayer Insertar_Reproductor_Camara;
            Vlc.DotNet.Forms.VlcControl Nuevo_Grabador_VLC;

            //Crea el nodo de referencia para mostrar las camaras al usuario
            formulario_principal.Crear_Nodos_Camaras(Objeto_Camara);
            //agrega el reproductor al menu principal
            formulario_principal.Menu_Lista_Camaras.Controls.Add(Insertar_Reproductor_Camara = new AxoPlayerLib.AxoPlayer());

            Nuevo_Grabador_VLC = new Vlc.DotNet.Forms.VlcControl();
            Nuevo_Grabador_VLC.VlcLibDirectory = new DirectoryInfo(@"C:\\Program Files (x86)\\VideoLAN\\VLC");
            formulario_principal.Menu_Lista_VLC.Controls.Add(Nuevo_Grabador_VLC);

            Nuevo_Grabador_VLC.Width = 50;
            Nuevo_Grabador_VLC.Height = 50;

            //Propiedades del reproductor
            Insertar_Reproductor_Camara.Width = 400;
            Insertar_Reproductor_Camara.Height = 300;

            //Inicia el streaming con los datos obtenidos
            Insertar_Reproductor_Camara.PlayVideo(Objeto_Camara.Usuario, Objeto_Camara.Contraseña, Objeto_Camara.Direccion_IP, Convert.ToInt32(Objeto_Camara.Puerto_CGI), 0, 0);
        }

        public void Actualizar_Ruta_Grabaciones_BD()
        {
            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Ruta_Grabaciones_Usuario(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", formulario_principal.Sesion_Usuario.Usuario_ID);
            chec.Parameters.AddWithValue("@C2", formulario_principal.Variables_Globales.Ruta_Grabacion);

            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();
        }

        public void Eliminar_Camara_Usuario_BD(int id_Camara)
        {
            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Eliminar_Camara_Usuario(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", formulario_principal.Sesion_Usuario.Usuario_ID);
            chec.Parameters.AddWithValue("@C2", id_Camara);

            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();
        }
    }
}
