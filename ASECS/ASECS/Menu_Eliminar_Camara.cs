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
    public partial class Menu_Eliminar_Camara : Form
    {
        Menu_Principal formulario_principal;
        public Menu_Eliminar_Camara(Menu_Principal formulario_principal)
        {
            InitializeComponent();
            this.formulario_principal = formulario_principal;

            Crear_Tabla_Datos();
            Obtener_Lista_Camaras();
        }

        private void Menu_Eliminar_Camara_Load(object sender, EventArgs e)
        {
            Titulo_Mensaje.Left = (this.Width - Titulo_Mensaje.Width) / 2;
        }

        public void Obtener_Lista_Camaras()
        {
            foreach (string Alias in formulario_principal.Lista_Camaras_Alias)
            {
                Camara Resultado_Camara = new Camara();
                Camara Busqueda_Objeto_Camara = new Camara();
                Busqueda_Objeto_Camara.Alias = Alias;
                Resultado_Camara = formulario_principal.Lista_Camaras.Buscar(Busqueda_Objeto_Camara);

                Tabla_Lista_Camaras.Rows.Add(Resultado_Camara.Alias, Resultado_Camara.Direccion_IP);
            }
        }

        public void Crear_Tabla_Datos()
        {
            Tabla_Lista_Camaras.ColumnCount = 2;
            Tabla_Lista_Camaras.Columns[0].Name = "Alias";
            Tabla_Lista_Camaras.Columns[1].Name = "Direccion IP";
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = Tabla_Lista_Camaras.CurrentCell.RowIndex;
                string Alias = Convert.ToString(Tabla_Lista_Camaras.Rows[fila].Cells[0].Value);

                if (Alias != "")
                {
                    int index_alias;
                    Camara Objeto_Eliminar_Camara = new Camara();
                    
                    Objeto_Eliminar_Camara.Alias = Alias;
                    index_alias = formulario_principal.Eliminar_Nodos_Camaras(Objeto_Eliminar_Camara);
                    formulario_principal.Menu_Lista_Camaras.Controls.RemoveAt(index_alias);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecciona una camara",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona una camara",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
