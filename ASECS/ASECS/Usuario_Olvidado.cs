using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASECS
{
    public partial class Usuario_Olvidado : Form
    {
        //atributos
        bool correo_existente = false;
        string usuario;
        string contraseña;
        Login formulario;

        public Usuario_Olvidado(Login formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }

        private void Usuario_Olvidado_Load(object sender, EventArgs e)
        {
            Titulo_Mensaje.Left = (this.Width - Titulo_Mensaje.Width) / 2;
            Texto_Correo.Left = (this.Width - Texto_Correo.Width) / 2;
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            formulario.recordando_usuario = false;
        }

        public void Validar_Datos()
        {
            bool correo_validado;

            Boton_Aceptar.Enabled = false;

            int resultado;

            correo_existente = false;

            correo_validado = Validar_Formato_Correo(Texto_Correo.Text);

            if (correo_validado == true)
            {
                Validar_Correo();

                if (correo_existente == true)
                {
                    resultado = Enviar_Correo();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Se han enviado tus datos.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al enviar el correo electrónico.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                else
                {
                    MessageBox.Show("El correo electrónico no existe.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);

                }
            }
            else
            {
                MessageBox.Show("El correo electrónico no tiene el formato correcto.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            Boton_Aceptar.Enabled = true;
        }

        private void Boton_Aceptar_Click(object sender, EventArgs e)
        {
            if (Texto_Correo.Text != "")
            {
                Validar_Datos();
            }
            else
            {
                MessageBox.Show("Introduce un correo electrónico.",
               "Aviso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1);
            }
        }

        public void Validar_Correo()
        {
            try
            {
                Conexion_BD registro = new Conexion_BD();
                registro.Crear_Conexion();
                string buscar = "CALL Validar_Correo(@C1);";
                MySqlCommand chec = new MySqlCommand(buscar, registro.Obtener_Conexion());
                chec.Connection = registro.Obtener_Conexion();
                chec.Parameters.AddWithValue("@C1", Texto_Correo.Text);
                MySqlDataReader leer = chec.ExecuteReader();

                while (leer.Read())
                {
                    if (leer.IsDBNull(0) == true)
                    {
                        correo_existente = false;
                    }
                    else
                    {
                        usuario = leer.GetString(1);
                        contraseña = leer.GetString(2);

                        correo_existente = true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

                MessageBox.Show("Hubo un error de conexión con la base de datos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        public int Enviar_Correo()
        {
            try
            {
                // Command line argument must the the SMTP host.
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("sistema.asecs", "vstarcam");

                MailMessage mm = new MailMessage("donotreply@domain.com", Texto_Correo.Text, "Recuperación de tu cuenta", "Tu usuario es: " + usuario + " y tu contraseña es: " + contraseña);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);

                return 1;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);

                return 0;
            }
        }

        public bool Validar_Formato_Correo(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }
    }
}
