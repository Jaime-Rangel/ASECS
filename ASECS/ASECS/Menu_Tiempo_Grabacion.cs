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
    public partial class Menu_Tiempo_Grabacion : Form
    {
        Menu_Principal formulario_principal;
        string Tiempo_BD;
        public Menu_Tiempo_Grabacion(Menu_Principal formulario_principal)
        {
            InitializeComponent();
            this.formulario_principal = formulario_principal;
            Asignar_Valores();
            Verificar_Tiempo_BD();
        }

        public void Asignar_Valores()
        {
            Seleccion_Tiempo.Items.Add("Horas");
            Seleccion_Tiempo.Items.Add("Minutos");
            Tiempo_Numerico.ReadOnly = true;

        }

        public void Verificar_Tiempo_BD()
        {
            if (formulario_principal.Objeto_Tiempo.Tiempo_Cantidad != null)
            {
                if (formulario_principal.Objeto_Tiempo.Tiempo_Unidad == "Horas")
                {
                    Seleccion_Tiempo.SelectedIndex = 0;
                }
                else
                {
                    Seleccion_Tiempo.SelectedIndex = 1;
                }

                Tiempo_Numerico.Value = Convert.ToDecimal(formulario_principal.Objeto_Tiempo.Tiempo_Cantidad);
            }
        }

        private void Seleccion_Tiempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Seleccion_Tiempo.Text=="Horas")
            {
                Tiempo_Numerico.Maximum = 24;
                Tiempo_Numerico.Minimum = 1;
                Titulo_Mensaje_Tiempos.Text = " Los videos se generaran cada: " + Tiempo_Numerico.Value + " " + Seleccion_Tiempo.Text;
            }
            else
            if(Seleccion_Tiempo.Text=="Minutos")
            {
                Tiempo_Numerico.Maximum = 60;
                Tiempo_Numerico.Minimum = 1;
                Titulo_Mensaje_Tiempos.Text = " Los videos se generaran cada: " + Tiempo_Numerico.Value + " " + Seleccion_Tiempo.Text;
            }
        }

        private void Tiempo_Numerico_ValueChanged(object sender, EventArgs e)
        {
            if (Seleccion_Tiempo.Text != "")
            {
                Titulo_Mensaje_Tiempos.Text = " Los videos se generaran cada: "+Tiempo_Numerico.Value +" " + Seleccion_Tiempo.Text;
            }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Boton_Aceptar_Click(object sender, EventArgs e)
        {
            if (Seleccion_Tiempo.Text != "")
            {
                formulario_principal.Objeto_Tiempo.Tiempo_Unidad = Seleccion_Tiempo.Text;
                formulario_principal.Objeto_Tiempo.Tiempo_Cantidad = Convert.ToInt32(Tiempo_Numerico.Value);

                int unidad = Convert.ToInt32(Tiempo_Numerico.Value);

                if (Seleccion_Tiempo.Text == "Horas")
                {
                    Tiempo_BD = "H"+":"+Convert.ToString(unidad);
                    unidad = unidad * 1000;
                    formulario_principal.Variables_Globales.Timer_Grabacion = new System.Timers.Timer(60 * 60 * unidad);
                }
                else
                {
                    Tiempo_BD = "M" + ":" + Convert.ToString(unidad);
                    formulario_principal.Variables_Globales.Timer_Grabacion = new System.Timers.Timer(60 * unidad * 1000);
                }

                Insertar_Tiempo_Grabacion_BD();

                MessageBox.Show("Se han guardado tus cambios",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona la unidad de tiempo",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        public void Insertar_Tiempo_Grabacion_BD()
        {
            Conexion_BD registro = new Conexion_BD();

            registro.Crear_Conexion();
            string insertar = "CALL Actualizar_Tiempo_Grabacion(@C1,@C2);";
            MySqlCommand chec = new MySqlCommand(insertar, registro.Obtener_Conexion());
            chec.Connection = registro.Obtener_Conexion();
            chec.Parameters.AddWithValue("@C1", Tiempo_BD);
            chec.Parameters.AddWithValue("@C2", formulario_principal.Sesion_Usuario.Usuario_ID);

            chec.ExecuteNonQuery();
            registro.Cerrar_Conexion();
        }
    }
}
