using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace ASECS
{
    public partial class Editar_Camara : Form
    {
        Menu_Principal formulario_principal;
        Camara Objeto_Camara;
        bool Campos_Validados;
        bool IP_Valida;

        public Editar_Camara(Camara Objeto_Camara,Menu_Principal formulario_principal)
        {
            InitializeComponent();
            this.formulario_principal = formulario_principal;
            this.Objeto_Camara = Objeto_Camara;
            Asignar_Valores();
        }

        public void Asignar_Valores()
        {
            Texto_Nombre_Camara.Text = Objeto_Camara.Alias;
            Texto_Usuario.Text = Objeto_Camara.Usuario;
            Texto_Contraseña.Text = Objeto_Camara.Contraseña;
            Texto_Direccion_IP.Text = Objeto_Camara.Direccion_IP;
            Texto_Puerto_CGI.Text = Objeto_Camara.Puerto_CGI;
            Texto_Puerto_RSTP.Text = Objeto_Camara.Puerto_RSTP;
            Texto_Nombre_Camara.MaxLength = 30;
        }

        private void Editar_Camara_Load_1(object sender, EventArgs e)
        {
            Titulo_Mensaje.Left = (Grupo_Datos_Camara.Width - Titulo_Mensaje.Width) / 2;
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Texto_Nombre_Camara_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Texto_Nombre_Camara.Text, @"^[a-zA-Z0-9\s\báéíóúÁÉÍÓÚñÑ]*$"))
            {
                MessageBox.Show("No se admiten estos simbolos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                Texto_Nombre_Camara.Text = Objeto_Camara.Alias;
            }
        }

        public void Actualizar_Camara_BD()
        {
            Conexion_BD registro = new Conexion_BD();
            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Camara(@C1,@C2,@C3,@C4,@C5,@C6,@C7);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", Objeto_Camara.Camara_ID);
            chec.Parameters.AddWithValue("@C2", Texto_Nombre_Camara.Text);
            chec.Parameters.AddWithValue("@C3", Texto_Usuario.Text);
            chec.Parameters.AddWithValue("@C4", Texto_Contraseña.Text);
            chec.Parameters.AddWithValue("@C5", Texto_Direccion_IP.Text);
            chec.Parameters.AddWithValue("@C6", Texto_Puerto_CGI.Text);
            chec.Parameters.AddWithValue("@C7", Texto_Puerto_RSTP.Text);

            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();
        }

        public void Actualizar_Objeto()
        {
            Objeto_Camara.Alias = Texto_Nombre_Camara.Text;
            Objeto_Camara.Usuario = Texto_Usuario.Text;
            Objeto_Camara.Contraseña = Texto_Contraseña.Text;
            Objeto_Camara.Direccion_IP = Texto_Direccion_IP.Text;
            Objeto_Camara.Puerto_CGI = Texto_Puerto_CGI.Text;
            Objeto_Camara.Puerto_RSTP = Texto_Puerto_RSTP.Text;
        }

        public void Validar_Campos()
        {
            if(Texto_Nombre_Camara.Text!=""&&Texto_Usuario.Text!=""&&Texto_Contraseña.Text!=""&&Texto_Direccion_IP.Text!=""&&Texto_Puerto_CGI.Text!=""&&Texto_Puerto_RSTP.Text!="")
            {
                Campos_Validados = true;
            }
            else
            {
                Campos_Validados = false;
            }
        }

        public void Validar_Direccion_IP()
        {
            IPAddress address;
            if (IPAddress.TryParse(Texto_Direccion_IP.Text, out address))
            {
                IP_Valida = true;
            }
            else
            {
                IP_Valida = false;
            }
        }

        private void Boton_Editar_Click(object sender, EventArgs e)
        {
            int index;
            int cont=0;

            Validar_Campos();

            if(Campos_Validados == true)
            {

                Validar_Direccion_IP();

                if(IP_Valida == true)
                {
                    //Se actualiza la base de datos en camaras
                    Actualizar_Camara_BD();
                    //obtengo el index de el alias viejo del objeto camara
                    index = formulario_principal.Lista_Camaras_Alias.IndexOf(Objeto_Camara.Alias);
                    //en la posicion de lista camaras actualizo el nuevo nombre
                    formulario_principal.Lista_Camaras_Alias[index] = Texto_Nombre_Camara.Text;
                    //actualizo el objeto
                    Actualizar_Objeto();
                    //actualizo el objeto en la lista de camaras
                    formulario_principal.Lista_Camaras.Actualizar(Objeto_Camara);

                    //detener video para actualizarlo
                    foreach (AxoPlayerLib.AxoPlayer control in formulario_principal.Menu_Lista_Camaras.Controls)
                    {
                        if (cont == index)
                        {
                            if (formulario_principal.Variables_Globales.Streaming_Activo == true)
                            {
                                control.StopVideo();
                                control.Refresh();
                                control.PlayVideo(Objeto_Camara.Usuario, Objeto_Camara.Contraseña, Objeto_Camara.Direccion_IP, Convert.ToInt32(Objeto_Camara.Puerto_CGI), 0, 0);
                            }
                            else
                            {
                                control.Refresh();
                            }

                            break;
                        }

                        cont++;
                    }

                    MessageBox.Show("Tus cambios se han guardado con éxito.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("La dirección IP no tiene el formato correcto.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);

                    Texto_Direccion_IP.Focus();
                    Texto_Direccion_IP.SelectAll();
                }

            }else
            {
                MessageBox.Show("Completa todos los campos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }
        }

        private void Texto_Puerto_CGI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Texto_Puerto_RSTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
