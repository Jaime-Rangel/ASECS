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

        public Menu_Tiempo_Grabacion(Menu_Principal formulario_principal)
        {
            InitializeComponent();
            this.formulario_principal = formulario_principal;
            Asignar_Valores();
        }

        public void Asignar_Valores()
        {
            Seleccion_Tiempo.Items.Add("Horas");
            Seleccion_Tiempo.Items.Add("Minutos");
            Tiempo_Numerico.ReadOnly = true;

        }

        private void Menu_Tiempo_Grabacion_Load(object sender, EventArgs e)
        {

        }

        private void Seleccion_Tiempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Seleccion_Tiempo.Text=="Horas")
            {
                Tiempo_Numerico.Maximum = 24;
                Tiempo_Numerico.Minimum = 1;
            }
            else
            if(Seleccion_Tiempo.Text=="Minutos")
            {
                Tiempo_Numerico.Maximum = 60;
                Tiempo_Numerico.Minimum = 1;
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
    }
}
