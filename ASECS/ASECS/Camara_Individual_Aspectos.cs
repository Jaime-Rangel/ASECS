using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Camara_Individual_Aspectos
    {
        Camara_Individual formulario;

        public Camara_Individual_Aspectos(Camara_Individual formulario)
        {
            this.formulario = formulario;
        }

        public void Acomodar_Elementos()
        {
            formulario.Ventana_Camara_IP.Left = (formulario.ClientSize.Width - formulario.Ventana_Camara_IP.Width) / 2;
            formulario.Grupo_Camara_Posicion.Left = (formulario.ClientSize.Width - formulario.Grupo_Camara_Posicion.Width) / 2;
            formulario.Boton_Mover_Centro.Left = (formulario.Grupo_Camara_Posicion.Width - formulario.Boton_Mover_Centro.Width) / 2;
            formulario.Boton_Mover_Arriba.Left = (formulario.Grupo_Camara_Posicion.Width - formulario.Boton_Mover_Arriba.Width) / 2;
            formulario.Boton_Mover_Abajo.Left = (formulario.Grupo_Camara_Posicion.Width - formulario.Boton_Mover_Abajo.Width) / 2;
            formulario.Titulo_Grabando.Visible = false;
        }

        public void Elementos_Desactivados()
        {
            formulario.Grupo_Camara_Posicion.Enabled = false;
            formulario.Grupo_Opciones_Grabacion.Enabled = false;
            formulario.Grupo_Guardar_Posicion.Enabled = false;
            formulario.Checkeo_Escuchar_Camara.Enabled = false;
            formulario.Checkeo_Hablar_Camara.Enabled = false;
            formulario.Checkeo_Intervir_Camara.Enabled = false;
            formulario.Checkeo_Modo_Espejo.Enabled = false;
            formulario.Grupo_Mover_Posicion.Enabled = false;
        }

        public void Elementos_Activados()
        {
            formulario.Grupo_Camara_Posicion.Enabled = true;
            formulario.Grupo_Opciones_Grabacion.Enabled = true;
            formulario.Grupo_Guardar_Posicion.Enabled = true;
            formulario.Checkeo_Escuchar_Camara.Enabled = true;
            formulario.Checkeo_Hablar_Camara.Enabled = true;
            formulario.Checkeo_Intervir_Camara.Enabled = true;
            formulario.Checkeo_Modo_Espejo.Enabled = true;
            formulario.Grupo_Mover_Posicion.Enabled = true;
        }

        public void Asignar_Titulo_Camara()
        {
            formulario.Titulo_Camara.Text = "Lugar: "+ formulario.Nombre_Camara;
            formulario.Titulo_Camara.Left = (formulario.Width - formulario.Titulo_Camara.Width) / 2;
        }

        public void Asignar_Titulo_Grabando()
        {
            formulario.Titulo_Grabando.Text = "***Grabando***";
            formulario.Titulo_Grabando.Left = (formulario.Grupo_Opciones_Grabacion.Width - formulario.Titulo_Grabando.Width) / 2;
        }

        public void Desactivar_Mensaje_Grabando()
        {
            formulario.Titulo_Grabando.Visible = false;
        }

        public void Activar_Mensaje_Grabando()
        {
            formulario.Titulo_Grabando.Visible = true;
        }
    }
}
