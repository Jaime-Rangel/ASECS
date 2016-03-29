using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Menu_Nueva_Camara_Aspectos
    {
        Menu_Nueva_Camara formulario;

        public Menu_Nueva_Camara_Aspectos(Menu_Nueva_Camara formulario)
        {
            this.formulario = formulario;
        }

        public void Acomodar_Elementos()
        {
            formulario.Lista_Camaras_Disponibles.Left = (formulario.Width - formulario.Lista_Camaras_Disponibles.Width) / 2;
            formulario.Boton_Buscar_Camaras.Left = (formulario.Width - formulario.Boton_Buscar_Camaras.Width) / 2;
            formulario.Titulo_Nueva_Camara.Left = (formulario.Width - formulario.Titulo_Nueva_Camara.Width) / 2;
            formulario.Boton_Agregar_Camara.Left = (formulario.Width - formulario.Boton_Agregar_Camara.Width) / 2;
        }

    }
}
