namespace ASECS
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.Menu_Lista_Camaras = new System.Windows.Forms.FlowLayoutPanel();
            this.Titulo_Bienvenida = new System.Windows.Forms.Label();
            this.Menu_Principal_Opciones = new System.Windows.Forms.ToolStrip();
            this.Menu_Principal_Agregar = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Principal_Nueva_Camara = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal_Eliminar_Camara = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal_Administrar_Camara = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal_Rutas = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Principal_Cambiar_Rutas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal_Ir_Ruta = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Opciones_Grabacion = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Opciones_Grabacion_Tiempo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Opciones_Configuracion = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Opciones_Configuracion_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Opciones_Usuario = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Opciones_Usuario_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Opciones_Videos = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Opciones_Salir = new System.Windows.Forms.ToolStripDropDownButton();
            this.Dialogo_Ruta_Grabacion = new System.Windows.Forms.FolderBrowserDialog();
            this.Titulo_Vista = new System.Windows.Forms.Label();
            this.Grupo_Grabacion = new System.Windows.Forms.GroupBox();
            this.Titulo_Grabando_Estatus = new System.Windows.Forms.Label();
            this.Imagen_Grabando = new System.Windows.Forms.PictureBox();
            this.Titulo_Grabaciones = new System.Windows.Forms.Label();
            this.Boton_Detener_Grabaciones = new System.Windows.Forms.Button();
            this.Boton_Iniciar_Grabaciones = new System.Windows.Forms.Button();
            this.Menu_Lista_VLC = new System.Windows.Forms.FlowLayoutPanel();
            this.Grupo_Streaming = new System.Windows.Forms.GroupBox();
            this.Boton_Detener_Streaming = new System.Windows.Forms.Button();
            this.Boton_Iniciar_Streaming = new System.Windows.Forms.Button();
            this.Icono_Minimizar = new System.Windows.Forms.NotifyIcon(this.components);
            this.Dialogo_Ruta_VLC = new System.Windows.Forms.FolderBrowserDialog();
            this.Menu_Principal_Opciones.SuspendLayout();
            this.Grupo_Grabacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Grabando)).BeginInit();
            this.Grupo_Streaming.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Lista_Camaras
            // 
            this.Menu_Lista_Camaras.AutoScroll = true;
            this.Menu_Lista_Camaras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_Lista_Camaras.Location = new System.Drawing.Point(9, 340);
            this.Menu_Lista_Camaras.Name = "Menu_Lista_Camaras";
            this.Menu_Lista_Camaras.Size = new System.Drawing.Size(1033, 345);
            this.Menu_Lista_Camaras.TabIndex = 0;
            // 
            // Titulo_Bienvenida
            // 
            this.Titulo_Bienvenida.AutoSize = true;
            this.Titulo_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Bienvenida.Location = new System.Drawing.Point(440, 102);
            this.Titulo_Bienvenida.Name = "Titulo_Bienvenida";
            this.Titulo_Bienvenida.Size = new System.Drawing.Size(115, 24);
            this.Titulo_Bienvenida.TabIndex = 2;
            this.Titulo_Bienvenida.Text = "Bienvenido: ";
            // 
            // Menu_Principal_Opciones
            // 
            this.Menu_Principal_Opciones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Menu_Principal_Opciones.ImageScalingSize = new System.Drawing.Size(70, 60);
            this.Menu_Principal_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Principal_Agregar,
            this.Menu_Principal_Rutas,
            this.Menu_Opciones_Grabacion,
            this.Menu_Opciones_Configuracion,
            this.Menu_Opciones_Usuario,
            this.Menu_Opciones_Videos,
            this.Menu_Opciones_Salir});
            this.Menu_Principal_Opciones.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal_Opciones.Name = "Menu_Principal_Opciones";
            this.Menu_Principal_Opciones.Size = new System.Drawing.Size(1054, 67);
            this.Menu_Principal_Opciones.TabIndex = 3;
            this.Menu_Principal_Opciones.Text = "toolStrip1";
            // 
            // Menu_Principal_Agregar
            // 
            this.Menu_Principal_Agregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Principal_Nueva_Camara,
            this.Menu_Principal_Eliminar_Camara,
            this.Menu_Principal_Administrar_Camara});
            this.Menu_Principal_Agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Principal_Agregar.Image = global::ASECS.Properties.Resources.Camara_IP;
            this.Menu_Principal_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Principal_Agregar.Name = "Menu_Principal_Agregar";
            this.Menu_Principal_Agregar.ShowDropDownArrow = false;
            this.Menu_Principal_Agregar.Size = new System.Drawing.Size(127, 64);
            this.Menu_Principal_Agregar.Text = "Cámaras";
            this.Menu_Principal_Agregar.ToolTipText = "Permite realizar diferentes operaciones de la cámara";
            // 
            // Menu_Principal_Nueva_Camara
            // 
            this.Menu_Principal_Nueva_Camara.Image = global::ASECS.Properties.Resources.Agregar;
            this.Menu_Principal_Nueva_Camara.Name = "Menu_Principal_Nueva_Camara";
            this.Menu_Principal_Nueva_Camara.Size = new System.Drawing.Size(183, 22);
            this.Menu_Principal_Nueva_Camara.Text = "Agregar Cámara";
            this.Menu_Principal_Nueva_Camara.Click += new System.EventHandler(this.Menu_Principal_Nueva_Camara_Click);
            // 
            // Menu_Principal_Eliminar_Camara
            // 
            this.Menu_Principal_Eliminar_Camara.Image = global::ASECS.Properties.Resources.Eliminar;
            this.Menu_Principal_Eliminar_Camara.Name = "Menu_Principal_Eliminar_Camara";
            this.Menu_Principal_Eliminar_Camara.Size = new System.Drawing.Size(183, 22);
            this.Menu_Principal_Eliminar_Camara.Text = "Eliminar Cámara";
            this.Menu_Principal_Eliminar_Camara.Click += new System.EventHandler(this.Menu_Principal_Eliminar_Camara_Click);
            // 
            // Menu_Principal_Administrar_Camara
            // 
            this.Menu_Principal_Administrar_Camara.Image = global::ASECS.Properties.Resources.Administrar;
            this.Menu_Principal_Administrar_Camara.Name = "Menu_Principal_Administrar_Camara";
            this.Menu_Principal_Administrar_Camara.Size = new System.Drawing.Size(183, 22);
            this.Menu_Principal_Administrar_Camara.Text = "Administrar Cámara";
            this.Menu_Principal_Administrar_Camara.Click += new System.EventHandler(this.Menu_Principal_Administrar_Camara_Click);
            // 
            // Menu_Principal_Rutas
            // 
            this.Menu_Principal_Rutas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Principal_Cambiar_Rutas,
            this.Menu_Principal_Ir_Ruta});
            this.Menu_Principal_Rutas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Principal_Rutas.Image = global::ASECS.Properties.Resources.Guardar;
            this.Menu_Principal_Rutas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Principal_Rutas.Name = "Menu_Principal_Rutas";
            this.Menu_Principal_Rutas.ShowDropDownArrow = false;
            this.Menu_Principal_Rutas.Size = new System.Drawing.Size(175, 64);
            this.Menu_Principal_Rutas.Text = "Almacenamiento";
            this.Menu_Principal_Rutas.ToolTipText = "Cambiar lugar donde se almancenan las grabaciones";
            // 
            // Menu_Principal_Cambiar_Rutas
            // 
            this.Menu_Principal_Cambiar_Rutas.Image = global::ASECS.Properties.Resources.Folder;
            this.Menu_Principal_Cambiar_Rutas.Name = "Menu_Principal_Cambiar_Rutas";
            this.Menu_Principal_Cambiar_Rutas.Size = new System.Drawing.Size(268, 22);
            this.Menu_Principal_Cambiar_Rutas.Text = "Cambiar Carpeta de Alacenamiento";
            this.Menu_Principal_Cambiar_Rutas.Click += new System.EventHandler(this.Menu_Principal_Cambiar_Rutas_Click);
            // 
            // Menu_Principal_Ir_Ruta
            // 
            this.Menu_Principal_Ir_Ruta.Image = global::ASECS.Properties.Resources.Carpeta_Ir;
            this.Menu_Principal_Ir_Ruta.Name = "Menu_Principal_Ir_Ruta";
            this.Menu_Principal_Ir_Ruta.Size = new System.Drawing.Size(268, 22);
            this.Menu_Principal_Ir_Ruta.Text = "Ir a la Carpeta de almacenamiento";
            this.Menu_Principal_Ir_Ruta.Click += new System.EventHandler(this.Menu_Principal_Ir_Ruta_Click);
            // 
            // Menu_Opciones_Grabacion
            // 
            this.Menu_Opciones_Grabacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Opciones_Grabacion_Tiempo});
            this.Menu_Opciones_Grabacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Opciones_Grabacion.Image = global::ASECS.Properties.Resources.Opciones;
            this.Menu_Opciones_Grabacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Opciones_Grabacion.Name = "Menu_Opciones_Grabacion";
            this.Menu_Opciones_Grabacion.ShowDropDownArrow = false;
            this.Menu_Opciones_Grabacion.Size = new System.Drawing.Size(208, 64);
            this.Menu_Opciones_Grabacion.Text = "Opciones de Grabación";
            this.Menu_Opciones_Grabacion.ToolTipText = "Permite editar el tiempo de grabacion";
            // 
            // Menu_Opciones_Grabacion_Tiempo
            // 
            this.Menu_Opciones_Grabacion_Tiempo.Image = global::ASECS.Properties.Resources.Tiempo;
            this.Menu_Opciones_Grabacion_Tiempo.Name = "Menu_Opciones_Grabacion_Tiempo";
            this.Menu_Opciones_Grabacion_Tiempo.Size = new System.Drawing.Size(192, 22);
            this.Menu_Opciones_Grabacion_Tiempo.Text = "Tiempo de Grabación";
            this.Menu_Opciones_Grabacion_Tiempo.Click += new System.EventHandler(this.Menu_Opciones_Grabacion_Tiempo_Click);
            // 
            // Menu_Opciones_Configuracion
            // 
            this.Menu_Opciones_Configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Opciones_Configuracion_Editar});
            this.Menu_Opciones_Configuracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Opciones_Configuracion.Image = global::ASECS.Properties.Resources.Configuracion;
            this.Menu_Opciones_Configuracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Opciones_Configuracion.Name = "Menu_Opciones_Configuracion";
            this.Menu_Opciones_Configuracion.ShowDropDownArrow = false;
            this.Menu_Opciones_Configuracion.Size = new System.Drawing.Size(158, 64);
            this.Menu_Opciones_Configuracion.Text = "Configuración";
            // 
            // Menu_Opciones_Configuracion_Editar
            // 
            this.Menu_Opciones_Configuracion_Editar.Image = global::ASECS.Properties.Resources.Editar;
            this.Menu_Opciones_Configuracion_Editar.Name = "Menu_Opciones_Configuracion_Editar";
            this.Menu_Opciones_Configuracion_Editar.Size = new System.Drawing.Size(155, 22);
            this.Menu_Opciones_Configuracion_Editar.Text = "Editar Cámaras";
            this.Menu_Opciones_Configuracion_Editar.Click += new System.EventHandler(this.Menu_Opciones_Configuracion_Editar_Click);
            // 
            // Menu_Opciones_Usuario
            // 
            this.Menu_Opciones_Usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Opciones_Usuario_Editar});
            this.Menu_Opciones_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Opciones_Usuario.Image = global::ASECS.Properties.Resources.Usuario;
            this.Menu_Opciones_Usuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Opciones_Usuario.Name = "Menu_Opciones_Usuario";
            this.Menu_Opciones_Usuario.ShowDropDownArrow = false;
            this.Menu_Opciones_Usuario.Size = new System.Drawing.Size(123, 64);
            this.Menu_Opciones_Usuario.Text = "Usuario";
            // 
            // Menu_Opciones_Usuario_Editar
            // 
            this.Menu_Opciones_Usuario_Editar.Image = global::ASECS.Properties.Resources.Usuario_Editar;
            this.Menu_Opciones_Usuario_Editar.Name = "Menu_Opciones_Usuario_Editar";
            this.Menu_Opciones_Usuario_Editar.Size = new System.Drawing.Size(139, 22);
            this.Menu_Opciones_Usuario_Editar.Text = "Editar datos";
            this.Menu_Opciones_Usuario_Editar.Click += new System.EventHandler(this.Menu_Opciones_Usuario_Editar_Click);
            // 
            // Menu_Opciones_Videos
            // 
            this.Menu_Opciones_Videos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Opciones_Videos.Image")));
            this.Menu_Opciones_Videos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Opciones_Videos.Name = "Menu_Opciones_Videos";
            this.Menu_Opciones_Videos.ShowDropDownArrow = false;
            this.Menu_Opciones_Videos.Size = new System.Drawing.Size(116, 64);
            this.Menu_Opciones_Videos.Text = "Videos";
            this.Menu_Opciones_Videos.Click += new System.EventHandler(this.Menu_Opciones_Videos_Click);
            // 
            // Menu_Opciones_Salir
            // 
            this.Menu_Opciones_Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Opciones_Salir.Image = global::ASECS.Properties.Resources.Salir;
            this.Menu_Opciones_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Opciones_Salir.Name = "Menu_Opciones_Salir";
            this.Menu_Opciones_Salir.ShowDropDownArrow = false;
            this.Menu_Opciones_Salir.Size = new System.Drawing.Size(105, 64);
            this.Menu_Opciones_Salir.Text = "Salir";
            this.Menu_Opciones_Salir.Click += new System.EventHandler(this.Menu_Opciones_Salir_Click);
            // 
            // Titulo_Vista
            // 
            this.Titulo_Vista.AutoSize = true;
            this.Titulo_Vista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Vista.Location = new System.Drawing.Point(440, 313);
            this.Titulo_Vista.Name = "Titulo_Vista";
            this.Titulo_Vista.Size = new System.Drawing.Size(156, 24);
            this.Titulo_Vista.TabIndex = 4;
            this.Titulo_Vista.Text = "Vista de Cámaras";
            // 
            // Grupo_Grabacion
            // 
            this.Grupo_Grabacion.Controls.Add(this.Titulo_Grabando_Estatus);
            this.Grupo_Grabacion.Controls.Add(this.Imagen_Grabando);
            this.Grupo_Grabacion.Controls.Add(this.Titulo_Grabaciones);
            this.Grupo_Grabacion.Controls.Add(this.Boton_Detener_Grabaciones);
            this.Grupo_Grabacion.Controls.Add(this.Boton_Iniciar_Grabaciones);
            this.Grupo_Grabacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Grabacion.Location = new System.Drawing.Point(9, 198);
            this.Grupo_Grabacion.Name = "Grupo_Grabacion";
            this.Grupo_Grabacion.Size = new System.Drawing.Size(1033, 112);
            this.Grupo_Grabacion.TabIndex = 5;
            this.Grupo_Grabacion.TabStop = false;
            this.Grupo_Grabacion.Text = "Grabar";
            // 
            // Titulo_Grabando_Estatus
            // 
            this.Titulo_Grabando_Estatus.AutoSize = true;
            this.Titulo_Grabando_Estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Grabando_Estatus.ForeColor = System.Drawing.Color.Red;
            this.Titulo_Grabando_Estatus.Location = new System.Drawing.Point(70, 41);
            this.Titulo_Grabando_Estatus.Name = "Titulo_Grabando_Estatus";
            this.Titulo_Grabando_Estatus.Size = new System.Drawing.Size(117, 20);
            this.Titulo_Grabando_Estatus.TabIndex = 9;
            this.Titulo_Grabando_Estatus.Text = "**Grabando**";
            // 
            // Imagen_Grabando
            // 
            this.Imagen_Grabando.Image = global::ASECS.Properties.Resources.Grabando;
            this.Imagen_Grabando.Location = new System.Drawing.Point(10, 25);
            this.Imagen_Grabando.Name = "Imagen_Grabando";
            this.Imagen_Grabando.Size = new System.Drawing.Size(54, 50);
            this.Imagen_Grabando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_Grabando.TabIndex = 8;
            this.Imagen_Grabando.TabStop = false;
            // 
            // Titulo_Grabaciones
            // 
            this.Titulo_Grabaciones.AutoSize = true;
            this.Titulo_Grabaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Grabaciones.Location = new System.Drawing.Point(6, 89);
            this.Titulo_Grabaciones.Name = "Titulo_Grabaciones";
            this.Titulo_Grabaciones.Size = new System.Drawing.Size(259, 20);
            this.Titulo_Grabaciones.TabIndex = 2;
            this.Titulo_Grabaciones.Text = "Las Grabaciones se almacenan en:";
            // 
            // Boton_Detener_Grabaciones
            // 
            this.Boton_Detener_Grabaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Detener_Grabaciones.Location = new System.Drawing.Point(502, 33);
            this.Boton_Detener_Grabaciones.Name = "Boton_Detener_Grabaciones";
            this.Boton_Detener_Grabaciones.Size = new System.Drawing.Size(200, 37);
            this.Boton_Detener_Grabaciones.TabIndex = 1;
            this.Boton_Detener_Grabaciones.Text = "Detener Grabaciones";
            this.Boton_Detener_Grabaciones.UseVisualStyleBackColor = true;
            this.Boton_Detener_Grabaciones.Click += new System.EventHandler(this.Boton_Detener_Grabaciones_Click);
            // 
            // Boton_Iniciar_Grabaciones
            // 
            this.Boton_Iniciar_Grabaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Iniciar_Grabaciones.Location = new System.Drawing.Point(296, 33);
            this.Boton_Iniciar_Grabaciones.Name = "Boton_Iniciar_Grabaciones";
            this.Boton_Iniciar_Grabaciones.Size = new System.Drawing.Size(200, 37);
            this.Boton_Iniciar_Grabaciones.TabIndex = 0;
            this.Boton_Iniciar_Grabaciones.Text = "Iniciar Grabaciones";
            this.Boton_Iniciar_Grabaciones.UseVisualStyleBackColor = true;
            this.Boton_Iniciar_Grabaciones.Click += new System.EventHandler(this.Boton_Iniciar_Grabaciones_Click);
            // 
            // Menu_Lista_VLC
            // 
            this.Menu_Lista_VLC.Location = new System.Drawing.Point(9, 70);
            this.Menu_Lista_VLC.Name = "Menu_Lista_VLC";
            this.Menu_Lista_VLC.Size = new System.Drawing.Size(1033, 26);
            this.Menu_Lista_VLC.TabIndex = 6;
            this.Menu_Lista_VLC.Visible = false;
            // 
            // Grupo_Streaming
            // 
            this.Grupo_Streaming.Controls.Add(this.Boton_Detener_Streaming);
            this.Grupo_Streaming.Controls.Add(this.Boton_Iniciar_Streaming);
            this.Grupo_Streaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Streaming.Location = new System.Drawing.Point(9, 129);
            this.Grupo_Streaming.Name = "Grupo_Streaming";
            this.Grupo_Streaming.Size = new System.Drawing.Size(1033, 63);
            this.Grupo_Streaming.TabIndex = 7;
            this.Grupo_Streaming.TabStop = false;
            this.Grupo_Streaming.Text = "Camaras";
            // 
            // Boton_Detener_Streaming
            // 
            this.Boton_Detener_Streaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Detener_Streaming.Location = new System.Drawing.Point(502, 20);
            this.Boton_Detener_Streaming.Name = "Boton_Detener_Streaming";
            this.Boton_Detener_Streaming.Size = new System.Drawing.Size(200, 37);
            this.Boton_Detener_Streaming.TabIndex = 4;
            this.Boton_Detener_Streaming.Text = "Desactivar Cámaras";
            this.Boton_Detener_Streaming.UseVisualStyleBackColor = true;
            this.Boton_Detener_Streaming.Click += new System.EventHandler(this.Boton_Detener_Streaming_Click);
            // 
            // Boton_Iniciar_Streaming
            // 
            this.Boton_Iniciar_Streaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Iniciar_Streaming.Location = new System.Drawing.Point(296, 20);
            this.Boton_Iniciar_Streaming.Name = "Boton_Iniciar_Streaming";
            this.Boton_Iniciar_Streaming.Size = new System.Drawing.Size(200, 37);
            this.Boton_Iniciar_Streaming.TabIndex = 3;
            this.Boton_Iniciar_Streaming.Text = "Activar Cámaras";
            this.Boton_Iniciar_Streaming.UseVisualStyleBackColor = true;
            this.Boton_Iniciar_Streaming.Click += new System.EventHandler(this.Boton_Iniciar_Streaming_Click);
            // 
            // Icono_Minimizar
            // 
            this.Icono_Minimizar.Text = "notifyIcon1";
            this.Icono_Minimizar.Visible = true;
            this.Icono_Minimizar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Icono_Minimizar_MouseDoubleClick);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 691);
            this.Controls.Add(this.Menu_Lista_VLC);
            this.Controls.Add(this.Grupo_Grabacion);
            this.Controls.Add(this.Titulo_Bienvenida);
            this.Controls.Add(this.Titulo_Vista);
            this.Controls.Add(this.Menu_Principal_Opciones);
            this.Controls.Add(this.Menu_Lista_Camaras);
            this.Controls.Add(this.Grupo_Streaming);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.Resize += new System.EventHandler(this.Menu_Principal_Resize);
            this.Menu_Principal_Opciones.ResumeLayout(false);
            this.Menu_Principal_Opciones.PerformLayout();
            this.Grupo_Grabacion.ResumeLayout(false);
            this.Grupo_Grabacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Grabando)).EndInit();
            this.Grupo_Streaming.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Titulo_Bienvenida;
        private System.Windows.Forms.ToolStripDropDownButton Menu_Principal_Agregar;
        private System.Windows.Forms.ToolStripMenuItem Menu_Principal_Nueva_Camara;
        public System.Windows.Forms.FlowLayoutPanel Menu_Lista_Camaras;
        private System.Windows.Forms.ToolStripDropDownButton Menu_Principal_Rutas;
        private System.Windows.Forms.ToolStripMenuItem Menu_Principal_Cambiar_Rutas;
        private System.Windows.Forms.FolderBrowserDialog Dialogo_Ruta_Grabacion;
        public System.Windows.Forms.Label Titulo_Vista;
        private System.Windows.Forms.ToolStripMenuItem Menu_Principal_Administrar_Camara;
        private System.Windows.Forms.ToolStripMenuItem Menu_Principal_Eliminar_Camara;
        private System.Windows.Forms.ToolStripDropDownButton Menu_Opciones_Grabacion;
        private System.Windows.Forms.ToolStripMenuItem Menu_Opciones_Grabacion_Tiempo;
        public System.Windows.Forms.FlowLayoutPanel Menu_Lista_VLC;
        private System.Windows.Forms.ToolStripDropDownButton Menu_Opciones_Configuracion;
        private System.Windows.Forms.ToolStripMenuItem Menu_Opciones_Configuracion_Editar;
        public System.Windows.Forms.NotifyIcon Icono_Minimizar;
        private System.Windows.Forms.ToolStripDropDownButton Menu_Opciones_Salir;
        public System.Windows.Forms.Label Titulo_Grabaciones;
        public System.Windows.Forms.GroupBox Grupo_Grabacion;
        public System.Windows.Forms.PictureBox Imagen_Grabando;
        public System.Windows.Forms.Label Titulo_Grabando_Estatus;
        public System.Windows.Forms.ToolStrip Menu_Principal_Opciones;
        public System.Windows.Forms.Button Boton_Detener_Grabaciones;
        public System.Windows.Forms.Button Boton_Iniciar_Grabaciones;
        public System.Windows.Forms.Button Boton_Detener_Streaming;
        public System.Windows.Forms.Button Boton_Iniciar_Streaming;
        public System.Windows.Forms.GroupBox Grupo_Streaming;
        private System.Windows.Forms.ToolStripDropDownButton Menu_Opciones_Usuario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Opciones_Usuario_Editar;
        private System.Windows.Forms.ToolStripDropDownButton Menu_Opciones_Videos;
        private System.Windows.Forms.ToolStripMenuItem Menu_Principal_Ir_Ruta;
        private System.Windows.Forms.FolderBrowserDialog Dialogo_Ruta_VLC;
    }
}