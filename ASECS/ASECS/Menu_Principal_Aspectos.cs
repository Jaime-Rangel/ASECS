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

        public void Asignar_Mensaje_Bienvenida()
        {
            formulario.Titulo_Bienvenida.Text += variables.Nombre_Usuario;
            formulario.Titulo_Bienvenida.Left = (formulario.Width - formulario.Titulo_Bienvenida.Width) / 2;
        }
    }
}
