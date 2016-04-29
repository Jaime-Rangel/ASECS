using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ASECS
{
    public partial class Login : Form
    {
        public bool campos_verificados = false;
        public bool sesion_verificada = false;
        Login_Validacion verificacion;
        public bool BD_Usuario;
        public Usuario Sesion_Usuario;
        public bool recordando_usuario = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Acomodar_Elementos();
            Inicializar_Campos();
        }

        public void Acomodar_Elementos()
        {
            Texto_Usuario.Left = (Grupo_Login.Width - Texto_Usuario.Width) / 2;
            Texto_Contraseña.Left = (Grupo_Login.Width - Texto_Contraseña.Width) / 2;
            Boton_Iniciar.Left = (Grupo_Login.Width - Boton_Iniciar.Width) / 2;
            Titulo_Usuario.Left = (Grupo_Login.Width - Titulo_Usuario.Width) / 2;
            Titulo_Contraseña.Left = (Grupo_Login.Width - Titulo_Contraseña.Width) / 2;
            Titulo_Perdido.Left = (Grupo_Login.Width - Titulo_Perdido.Width) / 2;
            Texto_Usuario.TextAlign = HorizontalAlignment.Center;
            Texto_Contraseña.TextAlign = HorizontalAlignment.Center;
        }

        public void Inicializar_Campos()
        {
            verificacion = new Login_Validacion(this);
            Sesion_Usuario = new Usuario();
        }

        private void Boton_Iniciar_Click(object sender, EventArgs e)
        {
            int resultado;
            resultado = verificacion.Validar_Campos();

            switch (resultado)
            {
                case 1:
                    MessageBox.Show("Ingresa tu usuario");
                    Texto_Usuario.Focus();
                    break;

                case 2:
                    MessageBox.Show("Ingresa la contraseña");
                    Texto_Contraseña.Focus();
                    break;

                case 3:
                    MessageBox.Show("Ingresa el usuario y contraseña");
                    Texto_Usuario.Focus();
                    break;
            }

            if (campos_verificados == true)
            {
                resultado = verificacion.Validar_Usuario_BD();

                switch (resultado)
                {
                    case 0:
                        MessageBox.Show("No se pudo conectar a la base de datos");
                        break;

                    case 2:
                        MessageBox.Show("La contraseña es incorrecta");
                        Texto_Contraseña.Focus();
                        Texto_Contraseña.SelectAll();
                        break;
                    case 3:
                        MessageBox.Show("El usuario no existe");
                        Texto_Usuario.Focus();
                        Texto_Usuario.SelectAll();
                        break;
                }

                if (sesion_verificada == true)
                {
                    Boton_Iniciar.Enabled = false;
                    verificacion.Obtener_Parametros_Usuario();
                    Tiempo_Barra.Enabled = true;
                    BD_Usuario = true;
                }
            }
        }

        private void Texto_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Texto_Usuario.Text == "")
                {
                    MessageBox.Show("Ingresa tu Usuario");
                    Texto_Usuario.Focus();
                }
                else
                {
                    if (Texto_Contraseña.Text == "")
                    {
                        Texto_Contraseña.Focus();
                    }
                    else
                    {
                        Boton_Iniciar.Focus();
                    }
                }
            }
        }

        private void Texto_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Texto_Usuario.Text == "")
                {
                    MessageBox.Show("Ingresa tu Contraseña");
                    Texto_Contraseña.Focus();
                }
                else
                {
                    if (Texto_Usuario.Text == "")
                    {
                        Texto_Usuario.Focus();
                    }
                    else
                    {
                        Boton_Iniciar.Focus();
                    }
                }
            }
        }

        private void Tiempo_Barra_Tick(object sender, EventArgs e)
        {
            Barra_Progreso.Visible = true;

            Barra_Progreso.Value = Barra_Progreso.Value + 5;

            if (Barra_Progreso.Value == Barra_Progreso.Maximum)
            {
                Tiempo_Barra.Enabled = false;

                Abrir_Ventana();
            }
        }

        public void Abrir_Ventana()
        {
            //this.Hide();
            //Menu_Principal Menu = new Menu_Principal(Sesion_Usuario);
            //Tiempo_Barra.Stop();
            //Menu.ShowDialog();
            //this.Close();

            if (Sesion_Usuario.Directorio_VLC == null)
            {
                MessageBox.Show("No se ha asignado un directorio del plugin de VLC es necesario para que funcione el programa, si no está seguro de como configurar este plugin contacte a su administrador .",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                Asignar_Directorio_VLC();
            }
            else
            {
                this.Hide();
                var Menu = new Menu_Principal(Sesion_Usuario);
                Menu.Closed += (s, args) => this.Close();
                Menu.Show();
            }
        }

        public void Asignar_Directorio_VLC()
        {
            string folder;
            DialogResult result = Dialogo_Ruta_VLC.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    folder = Dialogo_Ruta_VLC.SelectedPath;
                    Sesion_Usuario.Directorio_VLC = folder;
                    verificacion.Actualizar_Directorio_VLC_BD();

                    MessageBox.Show("La ruta se ha almacenado correctamente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                    this.Hide();
                    var Menu = new Menu_Principal(Sesion_Usuario);
                    Menu.Closed += (s, args) => this.Close();
                    Menu.Show();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                    MessageBox.Show("Hubo un error de conexión con la base de datos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("El programa no puede iniciar sin este elemento.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                this.Close();
            }
        }

        private void Titulo_Perdido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (recordando_usuario == false)
            {
                recordando_usuario = true;

                Usuario_Olvidado recordar = new Usuario_Olvidado(this);
                recordar.Show();
            }
        }
    }
}
