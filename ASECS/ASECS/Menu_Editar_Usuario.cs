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

namespace ASECS
{
    public partial class Menu_Editar_Usuario : Form
    {
        Menu_Principal formulario_principal;
        bool Campos_Validados;
        bool Contraseña_Anterior_Validada;
        bool Contraseña_Nueva_Validada;

        public Menu_Editar_Usuario(Menu_Principal formulario_principal)
        {
            InitializeComponent();
            this.formulario_principal = formulario_principal;
        }

        private void Menu_Editar_Usuario_Load(object sender, EventArgs e)
        {
            Texto_Usuario.ReadOnly = true;
            Asignar_Datos();
        }

        public void Asignar_Datos()
        {
            Texto_Usuario.Text = formulario_principal.Sesion_Usuario.Nombre_Usuario;
            Texto_Email.Text = formulario_principal.Sesion_Usuario.Email_Usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Verificar_Campos()
        {
            if(Texto_Email.Text!="" &&Texto_Nueva_Contraseña.Text!=""&&Texto_Repetir_Contraseña.Text!=""&&Texto_Contraseña_Anterior.Text!="")
            {
                Campos_Validados = true;
            }
            else
            {
                MessageBox.Show("Completa todos los campos",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                Campos_Validados = false;
            }
        }

        public void Checar_Contraseña_Anterior()
        {

            if(Texto_Contraseña_Anterior.Text == formulario_principal.Sesion_Usuario.Contraseña_Usuario)
            {
                Contraseña_Anterior_Validada = true;
            }
            else
            {
                Contraseña_Anterior_Validada = false;

            }
        }

        public void Validar_Nueva_Contraseña()
        {
            if(Texto_Nueva_Contraseña.Text == Texto_Repetir_Contraseña.Text)
            {
                Contraseña_Nueva_Validada = true;
            }
            else
            {
                Contraseña_Nueva_Validada = false;
            }
        }

        public void Actualizar_Usuario_BD()
        {
            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Usuario(@C1,@C2,@C3);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", formulario_principal.Sesion_Usuario.Usuario_ID);
            chec.Parameters.AddWithValue("@C2", Texto_Email.Text);
            chec.Parameters.AddWithValue("@C3", Texto_Nueva_Contraseña.Text);
            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();
        }

        private void Boton_Aceptar_Click(object sender, EventArgs e)
        {
            Verificar_Campos();

            if(Campos_Validados == true)
            {
                Checar_Contraseña_Anterior();

                if(Contraseña_Anterior_Validada == true)
                {
                    Validar_Nueva_Contraseña();

                    if(Contraseña_Nueva_Validada==true)
                    {
                        formulario_principal.Sesion_Usuario.Email_Usuario = Texto_Email.Text;
                        formulario_principal.Sesion_Usuario.Contraseña_Usuario = Texto_Nueva_Contraseña.Text;

                        Actualizar_Usuario_BD();

                        MessageBox.Show("Tus datos se han actualizado",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La nueva contraseña no coincide",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Tu contraseña anterior es invalida",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
