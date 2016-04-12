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
            grupo_fecha.Visible = false;
            txb_buscar.Enabled = false;
        }

        public void carpeta()
        {//rellenar el listbox

            string usuario, url;
            usuario = Environment.UserName;
            //Obtener el folder de videos del equipo*******************************
            url = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            DirectoryInfo din = new DirectoryInfo(url);
            foreach (var fi in din.GetFiles("*.mp4"))
            {
                lista_videos.Items.Add(fi.FullName);
            }
        }

        public void buscar_video_especifico()
        {//buscar entre las carpetas
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txb_buscar.Text = openFileDialog1.FileName;
            }
            player.Ctlcontrols.play();
        }

        public void combo()
        { //rellenar los combos
            cmb_buscarpor.Items.Add("Fecha");
            cmb_buscarpor.Items.Add("Mes");
            cmb_buscarpor.Items.Add("Año");
            cmb_buscarpor.Items.Add("Hora");
            cmb_buscarpor.Items.Add("Ubicación");
            cmb_buscarpor.Items.Add("Ubicación y fecha");
            //cmb_buscarpor.Items.Add("Fecha y ubicación");
        }

        private void lista_videos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_buscar.Text = (string)lista_videos.SelectedItem;
            player.URL = (string)lista_videos.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string video, name;
            video = (string)lista_videos.SelectedItem;
            DirectoryInfo direc = new DirectoryInfo(video);
            name = direc.Name;

            DialogResult boton = MessageBox.Show("¿Desea borrar el video " + name + "?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                System.IO.File.Delete((string)lista_videos.SelectedItem);
                player.Ctlcontrols.stop();
                lista_videos.Items.Clear();
                carpeta();
            }      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista_videos.Items.Clear();
            carpeta();
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
            if (cmb_buscarpor.SelectedIndex == 4)
            {
                lista_videos.Items.Clear();
                buscar_ubicacion(MisDatos);
                if (lista_videos.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron videos");
                }
            }
            if (cmb_buscarpor.SelectedIndex == 5)
            {
                lista_videos.Items.Clear();
                buscar_FechaUbicacion(MisDatos);
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
            //Llenando combo de lugares

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
        public void buscar_ubicacion(Variables_Video MisDatos)
        {
            string ubicacion;
            ubicacion = cmb_ubicacion.Text;
            var index = LinealSearch.findMany(MisDatos.ListaVideos, (Videos busqueda) =>
            {
                return busqueda.nombre == ubicacion;
            });
            for (int i = 0; i < index.Count; i++)
            {
                lista_videos.Items.Add(di + index[i].path);
            }
        }
        public void buscar_FechaUbicacion(Variables_Video MisDatos)
        {
            string ubicacion, dia, mes, año;
            ubicacion = cmb_ubicacion.Text;
            dia = ubicacion_dateTimePicker5.Value.Day.ToString();
            mes = ubicacion_dateTimePicker5.Value.Month.ToString();
            año = ubicacion_dateTimePicker5.Value.Year.ToString();
            var index = LinealSearch.findMany(MisDatos.ListaVideos, (Videos busqueda) =>
            {
                return busqueda.nombre == ubicacion && busqueda.dia == dia && busqueda.mes == mes && busqueda.anio == año;
            });
            for (int i = 0; i < index.Count; i++)
            {
                lista_videos.Items.Add(di + index[i].path);
            }
        }

        private void cmb_buscarpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grupo_fecha.Visible = true;
            if (cmb_buscarpor.SelectedIndex == 0)
            {//fecha
                controles_dia();
            }
            if (cmb_buscarpor.SelectedIndex == 1)
            {
                //mes
                controles_mes();
            }
            if (cmb_buscarpor.SelectedIndex == 2)
            {//año
                controles_anio();
            }
            if (cmb_buscarpor.SelectedIndex == 3)
            {
                //hora
                controles_hora();
            }
            if (cmb_buscarpor.SelectedIndex == 4)
            {
                ////ubicaicon
                controles_ubicacion();
            }
            if (cmb_buscarpor.SelectedIndex == 5)
            {
                controles_fechaUbicaion();
            }
        }

        public void controles_dia()
        {
            grupo_fecha.Text = "Día";
            dateTimePicker1.Visible = true;
            dateTimePicker1.Location = new Point(26, 45);
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            cmb_ubicacion.Visible = false;
            ubicacion_dateTimePicker5.Visible = false;
        }
        public void controles_mes()
        {
            grupo_fecha.Text = "Mes";
            dateTimePicker2.Visible = true;
            dateTimePicker2.Location = new Point(26, 45);
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            cmb_ubicacion.Visible = false;
            ubicacion_dateTimePicker5.Visible = false;
        }
        public void controles_anio()
        {
            grupo_fecha.Text = "Año";
            dateTimePicker3.Visible = true;
            dateTimePicker3.Location = new Point(26, 45);
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker4.Visible = false;
            cmb_ubicacion.Visible = false;
            ubicacion_dateTimePicker5.Visible = false;
        }
        public void controles_hora()
        {
            grupo_fecha.Text = "Hora";
            dateTimePicker4.Visible = true;
            dateTimePicker4.Location = new Point(26, 45);
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            cmb_ubicacion.Visible = false;
        }
        public void controles_ubicacion()
        {
            grupo_fecha.Text = "Ubicación";
            cmb_ubicacion.Visible = true;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            ubicacion_dateTimePicker5.Visible = false;
        }
        public void controles_fechaUbicaion()
        {
            grupo_fecha.Text = "Fecha y ubicación";
            cmb_ubicacion.Visible = true;
            ubicacion_dateTimePicker5.Visible = true;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;

        }
    }
}
