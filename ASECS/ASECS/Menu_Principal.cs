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
    public partial class Menu_Principal : Form
    {
        //Objetos
        Menu_Principal_Aspectos Aspectos;
        Variables_Menu_Principal Variables_Globales;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        public void Inicializar_Objetos()
        {
            Variables_Globales = new Variables_Menu_Principal();
            Aspectos = new Menu_Principal_Aspectos(this,Variables_Globales);
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            Inicializar_Objetos();
            Inicializar_Variables_Camara();
            Aspectos.Acomodar_Elementos();
            Aspectos.Asignar_Mensaje_Bienvenida();

        }

        public void Inicializar_Variables_Camara()
        {
            Variables_Globales.Nombre_Usuario = "Jaime Rangel Ojeda";
        }

        private void Menu_Principal_Nueva_Camara_Click(object sender, EventArgs e)
        {
            Menu_Nueva_Camara Agregar_Camara = new Menu_Nueva_Camara() ;
            Agregar_Camara.Show();
        }
    }
}
