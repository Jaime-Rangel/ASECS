using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASECS
{
    public partial class Menu_Videos : Form
    {
        public Videos Objeto_Video;
        DirectoryInfo di;

        public Menu_Videos(Menu_Principal formulario_principal)
        {
            InitializeComponent();
            di = formulario_principal.Variables_Globales.Directorio_Grabacion;
        }

        private void Menu_Videos_Load(object sender, EventArgs e)
        {
            carpeta();
            combo();
            Grupo_Fecha.Visible = false;
            txb_buscar.Enabled = false;
            //Boton_Borrar.Left = (Grupo_Lista.Width - Boton_Borrar.Width) / 2;
            //Boton_Buscar.Left = (Grupo_Fecha.Width - Boton_Buscar.Width)/2;
        }

        public void carpeta()
        {
            string usuario;
            usuario = Environment.UserName;

            foreach (var fi in di.GetFiles("*.mp4"))
            {
                lista_videos.Items.Add(fi.FullName);
            }
        }

        public void combo()
        {
            cmb_buscarpor.Items.Add("Fecha");
            cmb_buscarpor.Items.Add("Mes");
            cmb_buscarpor.Items.Add("Año");
            cmb_buscarpor.Items.Add("Hora");
        }

        private void lista_videos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_buscar.Text = (string)lista_videos.SelectedItem;
            Reproductor.URL = (string)lista_videos.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string video, name;
            video = (string)lista_videos.SelectedItem;

            if (string.IsNullOrEmpty(video) == false)
            {
                DirectoryInfo direc = new DirectoryInfo(video);
                name = direc.Name;

                DialogResult boton = MessageBox.Show("¿Desea borrar el video " + name + "?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (boton == DialogResult.OK)
                {
                System.IO.File.Delete((string)lista_videos.SelectedItem);
                Reproductor.Ctlcontrols.stop();
                lista_videos.Items.Clear();
                carpeta();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún video");
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //boton de la busqueda
            Variables_Video MisDatos = new Variables_Video();
            ArrayList arrText = new ArrayList();
            MisDatos.ListaVideos = new List<Videos>();
            BuscarParametros(MisDatos);
            if (cmb_buscarpor.SelectedIndex == 0)
            {
                lista_videos.Items.Clear();
                buscar_fecha(MisDatos);
                if (lista_videos.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron videos");
                }
            }
            if (cmb_buscarpor.SelectedIndex == 1)
            {
                lista_videos.Items.Clear();
                buscar_meses(MisDatos);
                if (lista_videos.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron videos");
                }
            }
            if (cmb_buscarpor.SelectedIndex == 2)
            {
                lista_videos.Items.Clear();
                buscar_años(MisDatos);
                if (lista_videos.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron videos");
                }
            }
            if (cmb_buscarpor.SelectedIndex == 3)
            {
                lista_videos.Items.Clear();
                buscar_horas(MisDatos);
                if (lista_videos.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron videos");
                }
            }
   
        }

        public void BuscarParametros(Variables_Video MisDatos)
        {
            char[] delimiterChars = { '_' };
            String[] titulos = new String[9];
            Videos dato;
            ArrayList lista_videos = new ArrayList();

            foreach (var fi in di.GetFiles("*.mp4"))
            {
                lista_videos.Add(fi.Name);
            }

            String[] string_videos = (String[])lista_videos.ToArray(typeof(string));

            for (int i = 0; i < string_videos.Length; i++)
            {
                int aux = 0;
                foreach (string word in string_videos[i].Split(delimiterChars))
                {
                    titulos[aux] = word;
                    aux++;
                }
                dato = new Videos();
                dato.nombre = titulos[0];
                dato.dia = titulos[1];
                dato.mes = titulos[2];
                dato.anio = titulos[3];
                dato.hora = titulos[4];
                dato.minutos = titulos[5];
                dato.segundos = titulos[6];
                dato.path = string_videos[i];
                MisDatos.ListaVideos.Add(dato);
            }

        }

        public void buscar_fecha(Variables_Video MisDatos)
        {
            string dia, mes, anio;
            dia = dateTimePicker1.Value.Day.ToString();
            mes = dateTimePicker1.Value.Month.ToString();
            anio = dateTimePicker1.Value.Year.ToString();

            var index = LinealSearch.findMany(MisDatos.ListaVideos, (Videos busqueda) =>
            {
                return busqueda.dia == dia && busqueda.mes == mes && busqueda.anio == anio;
            });

            for (int i = 0; i < index.Count; i++)
            {
                lista_videos.Items.Add(di + index[i].path);
            }
        }
        public void buscar_meses(Variables_Video MisDatos)
        {
            string mes, anio;
            mes = dateTimePicker2.Value.Day.ToString();
            anio = dateTimePicker2.Value.Year.ToString();

            var index = LinealSearch.findMany(MisDatos.ListaVideos, (Videos busqueda) =>
            {
                return busqueda.mes == mes;
            });

            for (int i = 0; i < index.Count; i++)
            {
                lista_videos.Items.Add(di + index[i].path);
            }
        }
        public void buscar_años(Variables_Video MisDatos)
        {
            string anio;
            anio = dateTimePicker3.Value.Year.ToString();

            var index = LinealSearch.findMany(MisDatos.ListaVideos, (Videos busqueda) =>
            {
                return busqueda.anio == anio;
            });

            for (int i = 0; i < index.Count; i++)
            {
                lista_videos.Items.Add(di + index[i].path);
            }
        }

        public void buscar_horas(Variables_Video MisDatos)
        {
            string hora;
            hora = dateTimePicker4.Value.Hour.ToString();

            var index = LinealSearch.findMany(MisDatos.ListaVideos, (Videos busqueda) =>
            {
                return busqueda.hora == hora;
            });

            for (int i = 0; i < index.Count; i++)
            {
                lista_videos.Items.Add(di + index[i].path);
            }
        }
   
        private void cmb_buscarpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grupo_Fecha.Visible = true;
            if (cmb_buscarpor.SelectedIndex == 0)
            {
                controles_dia();
            }
            if (cmb_buscarpor.SelectedIndex == 1)
            {
                controles_mes();
            }
            if (cmb_buscarpor.SelectedIndex == 2)
            {
                controles_anio();
            }
            if (cmb_buscarpor.SelectedIndex == 3)
            {
                controles_hora();
            }
        }

        public void controles_dia()
        {
            Grupo_Fecha.Text = "Día";
            dateTimePicker1.Visible = true;
            dateTimePicker1.Location = new Point(26, 45);
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            ubicacion_dateTimePicker5.Visible = false;
        }
        public void controles_mes()
        {
            Grupo_Fecha.Text = "Mes";
            dateTimePicker2.Visible = true;
            dateTimePicker2.Location = new Point(26, 45);
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            ubicacion_dateTimePicker5.Visible = false;
        }
        public void controles_anio()
        {
            Grupo_Fecha.Text = "Año";
            dateTimePicker3.Visible = true;
            dateTimePicker3.Location = new Point(26, 45);
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker4.Visible = false;
            ubicacion_dateTimePicker5.Visible = false;
        }
        public void controles_hora()
        {
            Grupo_Fecha.Text = "Hora";
            dateTimePicker4.Visible = true;
            dateTimePicker4.Location = new Point(26, 45);
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
        }

    }
}
