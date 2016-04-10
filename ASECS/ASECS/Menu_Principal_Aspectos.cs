using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Menu_Principal_Aspectos
    {
        Menu_Principal formulario;
        Variables_Menu_Principal variables;

        public Menu_Principal_Aspectos(Menu_Principal formulario,Variables_Menu_Principal variables)
        {
            this.formulario = formulario;
            this.variables = variables;
        }

        public void Acomodar_Elementos()
        {
            formulario.Titulo_Bienvenida.Left = (formulario.Width - formulario.Titulo_Bienvenida.Width) / 2;
        }

        public void Deshabilitar_Elementos()
        {
            //formulario.Imagen_Grabando.Visible = false;
            //formulario.Titulo_Grabando_Estatus.Visible = false;

            formulario.Grupo_Grabacion.Enabled = false;
            formulario.Grupo_Streaming.Enabled = false;
            formulario.Menu_Principal_Opciones.Enabled = false;
        }

        public void Asignar_Mensaje_Bienvenida()
        {
            formulario.Titulo_Bienvenida.Text += variables.Nombre_Usuario;
            formulario.Titulo_Bienvenida.Left = (formulario.Width - formulario.Titulo_Bienvenida.Width) / 2;
            formulario.Titulo_Vista.Left = (formulario.Width - formulario.Titulo_Vista.Width) / 2;
        }

        public void Habilitar_Elementos()
        {

            formulario.Grupo_Grabacion.Enabled = true;
            formulario.Grupo_Streaming.Enabled = true;
            formulario.Menu_Principal_Opciones.Enabled = true;

            formulario.Imagen_Grabando.Visible = false;
            formulario.Titulo_Grabando_Estatus.Visible = false;
        }
    }
}
