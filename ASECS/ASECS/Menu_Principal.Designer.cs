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
            this.Menu_Opciones_Grabacion = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Opciones_Grabacion_Tiempo = new System.Windows.Forms.ToolStripMenuItem();
            this.Dialogo_Ruta_Grabacion = new System.Windows.Forms.FolderBrowserDialog();
            this.Titulo_Vista = new System.Windows.Forms.Label();
            this.Icono_Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.Grupo_Grabacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Detener_Grabaciones = new System.Windows.Forms.Button();
            this.Boton_Iniciar_Grabaciones = new System.Windows.Forms.Button();
            this.Menu_Lista_VLC = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Boton_Iniciar_Streaming = new System.Windows.Forms.Button();
            this.Boton_Detener_Streaming = new System.Windows.Forms.Button();
            this.Menu_Principal_Opciones.SuspendLayout();
            this.Grupo_Grabacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Lista_Camaras
            // 
            this.Menu_Lista_Camaras.AutoScroll = true;
            this.Menu_Lista_Camaras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_Lista_Camaras.Location = new System.Drawing.Point(9, 317);
            this.Menu_Lista_Camaras.Name = "Menu_Lista_Camaras";
            this.Menu_Lista_Camaras.Size = new System.Drawing.Size(1012, 345);
            this.Menu_Lista_Camaras.TabIndex = 0;
            // 
            // Titulo_Bienvenida
            // 
            this.Titulo_Bienvenida.AutoSize = true;
            this.Titulo_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Bienvenida.Location = new System.Drawing.Point(435, 99);
            this.Titulo_Bienvenida.Name = "Titulo_Bienvenida";
            this.Titulo_Bienvenida.Size = new System.Drawing.Size(127, 24);
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
            this.Menu_Opciones_Grabacion});
            this.Menu_Principal_Opciones.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal_Opciones.Name = "Menu_Principal_Opciones";
            this.Menu_Principal_Opciones.Size = new System.Drawing.Size(1033, 67);
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
            this.Menu_Principal_Agregar.Image = global::ASECS.Properties.Resources.Camara;
            this.Menu_Principal_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Principal_Agregar.Name = "Menu_Principal_Agregar";
            this.Menu_Principal_Agregar.ShowDropDownArrow = false;
            this.Menu_Principal_Agregar.Size = new System.Drawing.Size(127, 64);
            this.Menu_Principal_Agregar.Text = "Camaras";
            this.Menu_Principal_Agregar.ToolTipText = "Permite realizar diferentes operaciones de la camara";
            // 
            // Menu_Principal_Nueva_Camara
            // 
            this.Menu_Principal_Nueva_Camara.Image = global::ASECS.Properties.Resources.Agregar;
            this.Menu_Principal_Nueva_Camara.Name = "Menu_Principal_Nueva_Camara";
            this.Menu_Principal_Nueva_Camara.Size = new System.Drawing.Size(183, 22);
            this.Menu_Principal_Nueva_Camara.Text = "Agregar Camara";
            this.Menu_Principal_Nueva_Camara.Click += new System.EventHandler(this.Menu_Principal_Nueva_Camara_Click);
            // 
            // Menu_Principal_Eliminar_Camara
            // 
            this.Menu_Principal_Eliminar_Camara.Image = global::ASECS.Properties.Resources.Eliminar;
            this.Menu_Principal_Eliminar_Camara.Name = "Menu_Principal_Eliminar_Camara";
            this.Menu_Principal_Eliminar_Camara.Size = new System.Drawing.Size(183, 22);
            this.Menu_Principal_Eliminar_Camara.Text = "Eliminar Camara";
            this.Menu_Principal_Eliminar_Camara.Click += new System.EventHandler(this.Menu_Principal_Eliminar_Camara_Click);
            // 
            // Menu_Principal_Administrar_Camara
            // 
            this.Menu_Principal_Administrar_Camara.Image = global::ASECS.Properties.Resources.Administrar;
            this.Menu_Principal_Administrar_Camara.Name = "Menu_Principal_Administrar_Camara";
            this.Menu_Principal_Administrar_Camara.Size = new System.Drawing.Size(183, 22);
            this.Menu_Principal_Administrar_Camara.Text = "Administrar Camara";
            this.Menu_Principal_Administrar_Camara.Click += new System.EventHandler(this.Menu_Principal_Administrar_Camara_Click);
            // 
            // Menu_Principal_Rutas
            // 
            this.Menu_Principal_Rutas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Principal_Cambiar_Rutas});
            this.Menu_Principal_Rutas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Principal_Rutas.Image = global::ASECS.Properties.Resources.Ruta_Grabacion;
            this.Menu_Principal_Rutas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Principal_Rutas.Name = "Menu_Principal_Rutas";
            this.Menu_Principal_Rutas.ShowDropDownArrow = false;
            this.Menu_Principal_Rutas.Size = new System.Drawing.Size(175, 64);
            this.Menu_Principal_Rutas.Text = "Almacenamiento";
            this.Menu_Principal_Rutas.ToolTipText = "Cambiar lugar donde se almancenan las grabaciones";
            // 
            // Menu_Principal_Cambiar_Rutas
            // 
            this.Menu_Principal_Cambiar_Rutas.Image = global::ASECS.Properties.Resources.Ruta;
            this.Menu_Principal_Cambiar_Rutas.Name = "Menu_Principal_Cambiar_Rutas";
            this.Menu_Principal_Cambiar_Rutas.Size = new System.Drawing.Size(268, 22);
            this.Menu_Principal_Cambiar_Rutas.Text = "Cambiar Carpeta de Alacenamiento";
            this.Menu_Principal_Cambiar_Rutas.Click += new System.EventHandler(this.Menu_Principal_Cambiar_Rutas_Click);
            // 
            // Menu_Opciones_Grabacion
            // 
            this.Menu_Opciones_Grabacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Opciones_Grabacion_Tiempo});
            this.Menu_Opciones_Grabacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Opciones_Grabacion.Image = global::ASECS.Properties.Resources.Filmacion;
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
            // Titulo_Vista
            // 
            this.Titulo_Vista.AutoSize = true;
            this.Titulo_Vista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Vista.Location = new System.Drawing.Point(419, 290);
            this.Titulo_Vista.Name = "Titulo_Vista";
            this.Titulo_Vista.Size = new System.Drawing.Size(172, 24);
            this.Titulo_Vista.TabIndex = 4;
            this.Titulo_Vista.Text = "Vista de Camaras";
            // 
            // Icono_Notificacion
            // 
            this.Icono_Notificacion.Text = "Regresar a ASECS";
            this.Icono_Notificacion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Icono_Notificacion_MouseDoubleClick);
            // 
            // Grupo_Grabacion
            // 
            this.Grupo_Grabacion.Controls.Add(this.label1);
            this.Grupo_Grabacion.Controls.Add(this.Boton_Detener_Grabaciones);
            this.Grupo_Grabacion.Controls.Add(this.Boton_Iniciar_Grabaciones);
            this.Grupo_Grabacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Grabacion.Location = new System.Drawing.Point(9, 195);
            this.Grupo_Grabacion.Name = "Grupo_Grabacion";
            this.Grupo_Grabacion.Size = new System.Drawing.Size(1012, 92);
            this.Grupo_Grabacion.TabIndex = 5;
            this.Grupo_Grabacion.TabStop = false;
            this.Grupo_Grabacion.Text = "Grabar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Las Grabaciones se almacenan en:";
            // 
            // Boton_Detener_Grabaciones
            // 
            this.Boton_Detener_Grabaciones.Location = new System.Drawing.Point(216, 25);
            this.Boton_Detener_Grabaciones.Name = "Boton_Detener_Grabaciones";
            this.Boton_Detener_Grabaciones.Size = new System.Drawing.Size(200, 34);
            this.Boton_Detener_Grabaciones.TabIndex = 1;
            this.Boton_Detener_Grabaciones.Text = "Detener Grabaciones";
            this.Boton_Detener_Grabaciones.UseVisualStyleBackColor = true;
            this.Boton_Detener_Grabaciones.Click += new System.EventHandler(this.Boton_Detener_Grabaciones_Click);
            // 
            // Boton_Iniciar_Grabaciones
            // 
            this.Boton_Iniciar_Grabaciones.Location = new System.Drawing.Point(10, 25);
            this.Boton_Iniciar_Grabaciones.Name = "Boton_Iniciar_Grabaciones";
            this.Boton_Iniciar_Grabaciones.Size = new System.Drawing.Size(200, 34);
            this.Boton_Iniciar_Grabaciones.TabIndex = 0;
            this.Boton_Iniciar_Grabaciones.Text = "Iniciar Grabaciones";
            this.Boton_Iniciar_Grabaciones.UseVisualStyleBackColor = true;
            this.Boton_Iniciar_Grabaciones.Click += new System.EventHandler(this.Boton_Iniciar_Grabaciones_Click);
            // 
            // Menu_Lista_VLC
            // 
            this.Menu_Lista_VLC.Location = new System.Drawing.Point(9, 70);
            this.Menu_Lista_VLC.Name = "Menu_Lista_VLC";
            this.Menu_Lista_VLC.Size = new System.Drawing.Size(1012, 26);
            this.Menu_Lista_VLC.TabIndex = 6;
            this.Menu_Lista_VLC.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Boton_Detener_Streaming);
            this.groupBox1.Controls.Add(this.Boton_Iniciar_Streaming);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Streaming";
            // 
            // Boton_Iniciar_Streaming
            // 
            this.Boton_Iniciar_Streaming.Location = new System.Drawing.Point(10, 23);
            this.Boton_Iniciar_Streaming.Name = "Boton_Iniciar_Streaming";
            this.Boton_Iniciar_Streaming.Size = new System.Drawing.Size(200, 34);
            this.Boton_Iniciar_Streaming.TabIndex = 3;
            this.Boton_Iniciar_Streaming.Text = "Iniciar Streaming";
            this.Boton_Iniciar_Streaming.UseVisualStyleBackColor = true;
            this.Boton_Iniciar_Streaming.Click += new System.EventHandler(this.Boton_Iniciar_Streaming_Click);
            // 
            // Boton_Detener_Streaming
            // 
            this.Boton_Detener_Streaming.Location = new System.Drawing.Point(216, 23);
            this.Boton_Detener_Streaming.Name = "Boton_Detener_Streaming";
            this.Boton_Detener_Streaming.Size = new System.Drawing.Size(200, 34);
            this.Boton_Detener_Streaming.TabIndex = 4;
            this.Boton_Detener_Streaming.Text = "Detener Streaming";
            this.Boton_Detener_Streaming.UseVisualStyleBackColor = true;
            this.Boton_Detener_Streaming.Click += new System.EventHandler(this.Boton_Detener_Streaming_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 670);
            this.Controls.Add(this.Menu_Lista_VLC);
            this.Controls.Add(this.Grupo_Grabacion);
            this.Controls.Add(this.Titulo_Bienvenida);
            this.Controls.Add(this.Titulo_Vista);
            this.Controls.Add(this.Menu_Principal_Opciones);
            this.Controls.Add(this.Menu_Lista_Camaras);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal ASECS";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.Resize += new System.EventHandler(this.Menu_Principal_Resize);
            this.Menu_Principal_Opciones.ResumeLayout(false);
            this.Menu_Principal_Opciones.PerformLayout();
            this.Grupo_Grabacion.ResumeLayout(false);
            this.Grupo_Grabacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Titulo_Bienvenida;
        private System.Windows.Forms.ToolStrip Menu_Principal_Opciones;
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
        public System.Windows.Forms.NotifyIcon Icono_Notificacion;
        private System.Windows.Forms.ToolStripMenuItem Menu_Opciones_Grabacion_Tiempo;
        private System.Windows.Forms.GroupBox Grupo_Grabacion;
        private System.Windows.Forms.Button Boton_Detener_Grabaciones;
        private System.Windows.Forms.Button Boton_Iniciar_Grabaciones;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel Menu_Lista_VLC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Boton_Detener_Streaming;
        private System.Windows.Forms.Button Boton_Iniciar_Streaming;
    }
}