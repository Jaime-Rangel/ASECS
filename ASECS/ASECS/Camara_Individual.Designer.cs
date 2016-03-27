namespace ASECS
{
    partial class Camara_Individual
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camara_Individual));
            this.Ventana_Camara_IP = new AxoPlayerLib.AxoPlayer();
            this.Grupo_Opciones_Camara = new System.Windows.Forms.GroupBox();
            this.Checkeo_Hablar_Camara = new System.Windows.Forms.CheckBox();
            this.Checkeo_Modo_Espejo = new System.Windows.Forms.CheckBox();
            this.Checkeo_Escuchar_Camara = new System.Windows.Forms.CheckBox();
            this.Checkeo_Intervir_Camara = new System.Windows.Forms.CheckBox();
            this.Boton_Desconectar_Camara = new System.Windows.Forms.Button();
            this.Boton_Conectar_Camara = new System.Windows.Forms.Button();
            this.Grupo_Opciones_Grabacion = new System.Windows.Forms.GroupBox();
            this.Titulo_Grabando = new System.Windows.Forms.Label();
            this.Boton_Detener_Grabacion = new System.Windows.Forms.Button();
            this.Boton_Iniciar_Grabacion = new System.Windows.Forms.Button();
            this.Grupo_Camara_Posicion = new System.Windows.Forms.GroupBox();
            this.Boton_Mover_Derecha = new System.Windows.Forms.Button();
            this.Boton_Mover_Izquierda = new System.Windows.Forms.Button();
            this.Boton_Mover_Centro = new System.Windows.Forms.Button();
            this.Boton_Mover_Abajo = new System.Windows.Forms.Button();
            this.Boton_Mover_Arriba = new System.Windows.Forms.Button();
            this.Grupo_Mover_Posicion = new System.Windows.Forms.GroupBox();
            this.Boton_Aceptar_Mover_Posicion = new System.Windows.Forms.Button();
            this.Lista_Mover_Posiciones_Camara = new System.Windows.Forms.ComboBox();
            this.Grupo_Guardar_Posicion = new System.Windows.Forms.GroupBox();
            this.Boton_Guardar_Posicion = new System.Windows.Forms.Button();
            this.Lista_Guardar_Posiciones_Camara = new System.Windows.Forms.ComboBox();
            this.Titulo_Camara = new System.Windows.Forms.Label();
            this.Ventana_Grabacion_Video = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.Ventana_Camara_IP)).BeginInit();
            this.Grupo_Opciones_Camara.SuspendLayout();
            this.Grupo_Opciones_Grabacion.SuspendLayout();
            this.Grupo_Camara_Posicion.SuspendLayout();
            this.Grupo_Mover_Posicion.SuspendLayout();
            this.Grupo_Guardar_Posicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ventana_Grabacion_Video)).BeginInit();
            this.SuspendLayout();
            // 
            // Ventana_Camara_IP
            // 
            this.Ventana_Camara_IP.Enabled = true;
            this.Ventana_Camara_IP.Location = new System.Drawing.Point(224, 46);
            this.Ventana_Camara_IP.Name = "Ventana_Camara_IP";
            this.Ventana_Camara_IP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Ventana_Camara_IP.OcxState")));
            this.Ventana_Camara_IP.Size = new System.Drawing.Size(598, 411);
            this.Ventana_Camara_IP.TabIndex = 0;
            // 
            // Grupo_Opciones_Camara
            // 
            this.Grupo_Opciones_Camara.Controls.Add(this.Checkeo_Hablar_Camara);
            this.Grupo_Opciones_Camara.Controls.Add(this.Checkeo_Modo_Espejo);
            this.Grupo_Opciones_Camara.Controls.Add(this.Checkeo_Escuchar_Camara);
            this.Grupo_Opciones_Camara.Controls.Add(this.Checkeo_Intervir_Camara);
            this.Grupo_Opciones_Camara.Controls.Add(this.Boton_Desconectar_Camara);
            this.Grupo_Opciones_Camara.Controls.Add(this.Boton_Conectar_Camara);
            this.Grupo_Opciones_Camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Opciones_Camara.Location = new System.Drawing.Point(12, 46);
            this.Grupo_Opciones_Camara.Name = "Grupo_Opciones_Camara";
            this.Grupo_Opciones_Camara.Size = new System.Drawing.Size(194, 411);
            this.Grupo_Opciones_Camara.TabIndex = 1;
            this.Grupo_Opciones_Camara.TabStop = false;
            this.Grupo_Opciones_Camara.Text = "Opciones de la Camara";
            // 
            // Checkeo_Hablar_Camara
            // 
            this.Checkeo_Hablar_Camara.AutoSize = true;
            this.Checkeo_Hablar_Camara.Location = new System.Drawing.Point(6, 258);
            this.Checkeo_Hablar_Camara.Name = "Checkeo_Hablar_Camara";
            this.Checkeo_Hablar_Camara.Size = new System.Drawing.Size(81, 24);
            this.Checkeo_Hablar_Camara.TabIndex = 5;
            this.Checkeo_Hablar_Camara.Text = "Hablar";
            this.Checkeo_Hablar_Camara.UseVisualStyleBackColor = true;
            this.Checkeo_Hablar_Camara.CheckedChanged += new System.EventHandler(this.Checkeo_Hablar_Camara_CheckedChanged);
            // 
            // Checkeo_Modo_Espejo
            // 
            this.Checkeo_Modo_Espejo.AutoSize = true;
            this.Checkeo_Modo_Espejo.Location = new System.Drawing.Point(6, 198);
            this.Checkeo_Modo_Espejo.Name = "Checkeo_Modo_Espejo";
            this.Checkeo_Modo_Espejo.Size = new System.Drawing.Size(132, 24);
            this.Checkeo_Modo_Espejo.TabIndex = 4;
            this.Checkeo_Modo_Espejo.Text = "Modo Espejo";
            this.Checkeo_Modo_Espejo.UseVisualStyleBackColor = true;
            this.Checkeo_Modo_Espejo.CheckedChanged += new System.EventHandler(this.Checkeo_Modo_Espejo_CheckedChanged);
            // 
            // Checkeo_Escuchar_Camara
            // 
            this.Checkeo_Escuchar_Camara.AutoSize = true;
            this.Checkeo_Escuchar_Camara.Location = new System.Drawing.Point(6, 168);
            this.Checkeo_Escuchar_Camara.Name = "Checkeo_Escuchar_Camara";
            this.Checkeo_Escuchar_Camara.Size = new System.Drawing.Size(170, 24);
            this.Checkeo_Escuchar_Camara.TabIndex = 3;
            this.Checkeo_Escuchar_Camara.Text = "Escuchar Camara";
            this.Checkeo_Escuchar_Camara.UseVisualStyleBackColor = true;
            this.Checkeo_Escuchar_Camara.CheckedChanged += new System.EventHandler(this.Checkeo_Escuchar_Camara_CheckedChanged);
            // 
            // Checkeo_Intervir_Camara
            // 
            this.Checkeo_Intervir_Camara.AutoSize = true;
            this.Checkeo_Intervir_Camara.Location = new System.Drawing.Point(6, 228);
            this.Checkeo_Intervir_Camara.Name = "Checkeo_Intervir_Camara";
            this.Checkeo_Intervir_Camara.Size = new System.Drawing.Size(151, 24);
            this.Checkeo_Intervir_Camara.TabIndex = 2;
            this.Checkeo_Intervir_Camara.Text = "Invertir Camara";
            this.Checkeo_Intervir_Camara.UseVisualStyleBackColor = true;
            this.Checkeo_Intervir_Camara.CheckedChanged += new System.EventHandler(this.Checkeo_Intervir_Camara_CheckedChanged);
            // 
            // Boton_Desconectar_Camara
            // 
            this.Boton_Desconectar_Camara.Location = new System.Drawing.Point(6, 110);
            this.Boton_Desconectar_Camara.Name = "Boton_Desconectar_Camara";
            this.Boton_Desconectar_Camara.Size = new System.Drawing.Size(182, 51);
            this.Boton_Desconectar_Camara.TabIndex = 1;
            this.Boton_Desconectar_Camara.Text = "Desconectar Camara";
            this.Boton_Desconectar_Camara.UseVisualStyleBackColor = true;
            this.Boton_Desconectar_Camara.Click += new System.EventHandler(this.Boton_Desconectar_Camara_Click);
            // 
            // Boton_Conectar_Camara
            // 
            this.Boton_Conectar_Camara.Location = new System.Drawing.Point(6, 53);
            this.Boton_Conectar_Camara.Name = "Boton_Conectar_Camara";
            this.Boton_Conectar_Camara.Size = new System.Drawing.Size(182, 51);
            this.Boton_Conectar_Camara.TabIndex = 0;
            this.Boton_Conectar_Camara.Text = "Conectar Camara";
            this.Boton_Conectar_Camara.UseVisualStyleBackColor = true;
            this.Boton_Conectar_Camara.Click += new System.EventHandler(this.Boton_Conectar_Camara_Click);
            // 
            // Grupo_Opciones_Grabacion
            // 
            this.Grupo_Opciones_Grabacion.Controls.Add(this.Ventana_Grabacion_Video);
            this.Grupo_Opciones_Grabacion.Controls.Add(this.Titulo_Grabando);
            this.Grupo_Opciones_Grabacion.Controls.Add(this.Boton_Detener_Grabacion);
            this.Grupo_Opciones_Grabacion.Controls.Add(this.Boton_Iniciar_Grabacion);
            this.Grupo_Opciones_Grabacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Opciones_Grabacion.Location = new System.Drawing.Point(848, 46);
            this.Grupo_Opciones_Grabacion.Name = "Grupo_Opciones_Grabacion";
            this.Grupo_Opciones_Grabacion.Size = new System.Drawing.Size(194, 411);
            this.Grupo_Opciones_Grabacion.TabIndex = 2;
            this.Grupo_Opciones_Grabacion.TabStop = false;
            this.Grupo_Opciones_Grabacion.Text = "Opciones de Grabacion";
            // 
            // Titulo_Grabando
            // 
            this.Titulo_Grabando.AutoSize = true;
            this.Titulo_Grabando.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Grabando.ForeColor = System.Drawing.Color.Red;
            this.Titulo_Grabando.Location = new System.Drawing.Point(21, 168);
            this.Titulo_Grabando.Name = "Titulo_Grabando";
            this.Titulo_Grabando.Size = new System.Drawing.Size(150, 24);
            this.Titulo_Grabando.TabIndex = 3;
            this.Titulo_Grabando.Text = "***Grabando***";
            // 
            // Boton_Detener_Grabacion
            // 
            this.Boton_Detener_Grabacion.Location = new System.Drawing.Point(6, 110);
            this.Boton_Detener_Grabacion.Name = "Boton_Detener_Grabacion";
            this.Boton_Detener_Grabacion.Size = new System.Drawing.Size(182, 51);
            this.Boton_Detener_Grabacion.TabIndex = 1;
            this.Boton_Detener_Grabacion.Text = "Detener Grabacion";
            this.Boton_Detener_Grabacion.UseVisualStyleBackColor = true;
            this.Boton_Detener_Grabacion.Click += new System.EventHandler(this.Boton_Detener_Grabacion_Click);
            // 
            // Boton_Iniciar_Grabacion
            // 
            this.Boton_Iniciar_Grabacion.Location = new System.Drawing.Point(6, 53);
            this.Boton_Iniciar_Grabacion.Name = "Boton_Iniciar_Grabacion";
            this.Boton_Iniciar_Grabacion.Size = new System.Drawing.Size(182, 51);
            this.Boton_Iniciar_Grabacion.TabIndex = 0;
            this.Boton_Iniciar_Grabacion.Text = "Iniciar Grabacion";
            this.Boton_Iniciar_Grabacion.UseVisualStyleBackColor = true;
            this.Boton_Iniciar_Grabacion.Click += new System.EventHandler(this.Boton_Iniciar_Grabacion_Click);
            // 
            // Grupo_Camara_Posicion
            // 
            this.Grupo_Camara_Posicion.Controls.Add(this.Boton_Mover_Derecha);
            this.Grupo_Camara_Posicion.Controls.Add(this.Boton_Mover_Izquierda);
            this.Grupo_Camara_Posicion.Controls.Add(this.Boton_Mover_Centro);
            this.Grupo_Camara_Posicion.Controls.Add(this.Boton_Mover_Abajo);
            this.Grupo_Camara_Posicion.Controls.Add(this.Boton_Mover_Arriba);
            this.Grupo_Camara_Posicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Camara_Posicion.Location = new System.Drawing.Point(263, 463);
            this.Grupo_Camara_Posicion.Name = "Grupo_Camara_Posicion";
            this.Grupo_Camara_Posicion.Size = new System.Drawing.Size(512, 239);
            this.Grupo_Camara_Posicion.TabIndex = 3;
            this.Grupo_Camara_Posicion.TabStop = false;
            this.Grupo_Camara_Posicion.Text = "Posicion de la Camara";
            // 
            // Boton_Mover_Derecha
            // 
            this.Boton_Mover_Derecha.Location = new System.Drawing.Point(378, 97);
            this.Boton_Mover_Derecha.Name = "Boton_Mover_Derecha";
            this.Boton_Mover_Derecha.Size = new System.Drawing.Size(128, 65);
            this.Boton_Mover_Derecha.TabIndex = 4;
            this.Boton_Mover_Derecha.Text = "Mover Derecha";
            this.Boton_Mover_Derecha.UseVisualStyleBackColor = true;
            this.Boton_Mover_Derecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Derecha_MouseDown);
            this.Boton_Mover_Derecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Derecha_MouseUp);
            // 
            // Boton_Mover_Izquierda
            // 
            this.Boton_Mover_Izquierda.Location = new System.Drawing.Point(6, 97);
            this.Boton_Mover_Izquierda.Name = "Boton_Mover_Izquierda";
            this.Boton_Mover_Izquierda.Size = new System.Drawing.Size(128, 65);
            this.Boton_Mover_Izquierda.TabIndex = 3;
            this.Boton_Mover_Izquierda.Text = "Mover Izquierda";
            this.Boton_Mover_Izquierda.UseVisualStyleBackColor = true;
            this.Boton_Mover_Izquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Izquierda_MouseDown);
            this.Boton_Mover_Izquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Izquierda_MouseUp);
            // 
            // Boton_Mover_Centro
            // 
            this.Boton_Mover_Centro.Location = new System.Drawing.Point(197, 97);
            this.Boton_Mover_Centro.Name = "Boton_Mover_Centro";
            this.Boton_Mover_Centro.Size = new System.Drawing.Size(128, 65);
            this.Boton_Mover_Centro.TabIndex = 2;
            this.Boton_Mover_Centro.Text = "Centrar";
            this.Boton_Mover_Centro.UseVisualStyleBackColor = true;
            this.Boton_Mover_Centro.Click += new System.EventHandler(this.Boton_Mover_Centro_Click);
            // 
            // Boton_Mover_Abajo
            // 
            this.Boton_Mover_Abajo.Location = new System.Drawing.Point(197, 168);
            this.Boton_Mover_Abajo.Name = "Boton_Mover_Abajo";
            this.Boton_Mover_Abajo.Size = new System.Drawing.Size(128, 65);
            this.Boton_Mover_Abajo.TabIndex = 1;
            this.Boton_Mover_Abajo.Text = "Mover Abajo";
            this.Boton_Mover_Abajo.UseVisualStyleBackColor = true;
            this.Boton_Mover_Abajo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Abajo_MouseDown);
            this.Boton_Mover_Abajo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Abajo_MouseUp);
            // 
            // Boton_Mover_Arriba
            // 
            this.Boton_Mover_Arriba.Location = new System.Drawing.Point(197, 25);
            this.Boton_Mover_Arriba.Name = "Boton_Mover_Arriba";
            this.Boton_Mover_Arriba.Size = new System.Drawing.Size(128, 65);
            this.Boton_Mover_Arriba.TabIndex = 0;
            this.Boton_Mover_Arriba.Text = "Mover Arriba";
            this.Boton_Mover_Arriba.UseVisualStyleBackColor = true;
            this.Boton_Mover_Arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Arriba_MouseDown);
            this.Boton_Mover_Arriba.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Boton_Mover_Arriba_MouseUp);
            // 
            // Grupo_Mover_Posicion
            // 
            this.Grupo_Mover_Posicion.Controls.Add(this.Boton_Aceptar_Mover_Posicion);
            this.Grupo_Mover_Posicion.Controls.Add(this.Lista_Mover_Posiciones_Camara);
            this.Grupo_Mover_Posicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Mover_Posicion.Location = new System.Drawing.Point(12, 463);
            this.Grupo_Mover_Posicion.Name = "Grupo_Mover_Posicion";
            this.Grupo_Mover_Posicion.Size = new System.Drawing.Size(194, 239);
            this.Grupo_Mover_Posicion.TabIndex = 4;
            this.Grupo_Mover_Posicion.TabStop = false;
            this.Grupo_Mover_Posicion.Text = "Mover a Posicion";
            // 
            // Boton_Aceptar_Mover_Posicion
            // 
            this.Boton_Aceptar_Mover_Posicion.Location = new System.Drawing.Point(6, 104);
            this.Boton_Aceptar_Mover_Posicion.Name = "Boton_Aceptar_Mover_Posicion";
            this.Boton_Aceptar_Mover_Posicion.Size = new System.Drawing.Size(182, 51);
            this.Boton_Aceptar_Mover_Posicion.TabIndex = 1;
            this.Boton_Aceptar_Mover_Posicion.Text = "Mover";
            this.Boton_Aceptar_Mover_Posicion.UseVisualStyleBackColor = true;
            this.Boton_Aceptar_Mover_Posicion.Click += new System.EventHandler(this.Boton_Aceptar_Mover_Posicion_Click);
            // 
            // Lista_Mover_Posiciones_Camara
            // 
            this.Lista_Mover_Posiciones_Camara.FormattingEnabled = true;
            this.Lista_Mover_Posiciones_Camara.Location = new System.Drawing.Point(6, 25);
            this.Lista_Mover_Posiciones_Camara.Name = "Lista_Mover_Posiciones_Camara";
            this.Lista_Mover_Posiciones_Camara.Size = new System.Drawing.Size(182, 28);
            this.Lista_Mover_Posiciones_Camara.TabIndex = 0;
            // 
            // Grupo_Guardar_Posicion
            // 
            this.Grupo_Guardar_Posicion.Controls.Add(this.Boton_Guardar_Posicion);
            this.Grupo_Guardar_Posicion.Controls.Add(this.Lista_Guardar_Posiciones_Camara);
            this.Grupo_Guardar_Posicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Guardar_Posicion.Location = new System.Drawing.Point(848, 463);
            this.Grupo_Guardar_Posicion.Name = "Grupo_Guardar_Posicion";
            this.Grupo_Guardar_Posicion.Size = new System.Drawing.Size(194, 239);
            this.Grupo_Guardar_Posicion.TabIndex = 5;
            this.Grupo_Guardar_Posicion.TabStop = false;
            this.Grupo_Guardar_Posicion.Text = "Guardar Posicion";
            // 
            // Boton_Guardar_Posicion
            // 
            this.Boton_Guardar_Posicion.Location = new System.Drawing.Point(6, 97);
            this.Boton_Guardar_Posicion.Name = "Boton_Guardar_Posicion";
            this.Boton_Guardar_Posicion.Size = new System.Drawing.Size(182, 51);
            this.Boton_Guardar_Posicion.TabIndex = 1;
            this.Boton_Guardar_Posicion.Text = "Guardar";
            this.Boton_Guardar_Posicion.UseVisualStyleBackColor = true;
            this.Boton_Guardar_Posicion.Click += new System.EventHandler(this.Boton_Guardar_Posicion_Click);
            // 
            // Lista_Guardar_Posiciones_Camara
            // 
            this.Lista_Guardar_Posiciones_Camara.FormattingEnabled = true;
            this.Lista_Guardar_Posiciones_Camara.Location = new System.Drawing.Point(6, 25);
            this.Lista_Guardar_Posiciones_Camara.Name = "Lista_Guardar_Posiciones_Camara";
            this.Lista_Guardar_Posiciones_Camara.Size = new System.Drawing.Size(182, 28);
            this.Lista_Guardar_Posiciones_Camara.TabIndex = 0;
            // 
            // Titulo_Camara
            // 
            this.Titulo_Camara.AutoSize = true;
            this.Titulo_Camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Camara.Location = new System.Drawing.Point(482, 23);
            this.Titulo_Camara.Name = "Titulo_Camara";
            this.Titulo_Camara.Size = new System.Drawing.Size(81, 20);
            this.Titulo_Camara.TabIndex = 6;
            this.Titulo_Camara.Text = "Camara: ";
            // 
            // Ventana_Grabacion_Video
            // 
            this.Ventana_Grabacion_Video.BackColor = System.Drawing.Color.Black;
            this.Ventana_Grabacion_Video.Location = new System.Drawing.Point(6, 273);
            this.Ventana_Grabacion_Video.Name = "Ventana_Grabacion_Video";
            this.Ventana_Grabacion_Video.Size = new System.Drawing.Size(182, 132);
            this.Ventana_Grabacion_Video.Spu = -1;
            this.Ventana_Grabacion_Video.TabIndex = 4;
            this.Ventana_Grabacion_Video.Text = "vlcControl1";
            this.Ventana_Grabacion_Video.VlcLibDirectory = null;
            this.Ventana_Grabacion_Video.VlcMediaplayerOptions = null;
            // 
            // Camara_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 715);
            this.Controls.Add(this.Titulo_Camara);
            this.Controls.Add(this.Grupo_Guardar_Posicion);
            this.Controls.Add(this.Grupo_Mover_Posicion);
            this.Controls.Add(this.Grupo_Camara_Posicion);
            this.Controls.Add(this.Grupo_Opciones_Grabacion);
            this.Controls.Add(this.Grupo_Opciones_Camara);
            this.Controls.Add(this.Ventana_Camara_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Camara_Individual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara Individual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ventana_Camara_IP)).EndInit();
            this.Grupo_Opciones_Camara.ResumeLayout(false);
            this.Grupo_Opciones_Camara.PerformLayout();
            this.Grupo_Opciones_Grabacion.ResumeLayout(false);
            this.Grupo_Opciones_Grabacion.PerformLayout();
            this.Grupo_Camara_Posicion.ResumeLayout(false);
            this.Grupo_Mover_Posicion.ResumeLayout(false);
            this.Grupo_Guardar_Posicion.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.Ventana_Grabacion_Video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxoPlayerLib.AxoPlayer Ventana_Camara_IP;
        private System.Windows.Forms.Button Boton_Desconectar_Camara;
        private System.Windows.Forms.Button Boton_Conectar_Camara;
        public System.Windows.Forms.GroupBox Grupo_Camara_Posicion;
        private System.Windows.Forms.Button Boton_Detener_Grabacion;
        private System.Windows.Forms.Button Boton_Iniciar_Grabacion;
        private System.Windows.Forms.Button Boton_Mover_Derecha;
        private System.Windows.Forms.Button Boton_Mover_Izquierda;
        public System.Windows.Forms.Button Boton_Mover_Arriba;
        public System.Windows.Forms.Button Boton_Mover_Centro;
        public System.Windows.Forms.Button Boton_Mover_Abajo;
        public System.Windows.Forms.CheckBox Checkeo_Intervir_Camara;
        public System.Windows.Forms.CheckBox Checkeo_Modo_Espejo;
        public System.Windows.Forms.CheckBox Checkeo_Hablar_Camara;
        public System.Windows.Forms.ComboBox Lista_Mover_Posiciones_Camara;
        public System.Windows.Forms.ComboBox Lista_Guardar_Posiciones_Camara;
        private System.Windows.Forms.Button Boton_Aceptar_Mover_Posicion;
        private System.Windows.Forms.Button Boton_Guardar_Posicion;
        public System.Windows.Forms.GroupBox Grupo_Opciones_Camara;
        public System.Windows.Forms.GroupBox Grupo_Opciones_Grabacion;
        public System.Windows.Forms.GroupBox Grupo_Mover_Posicion;
        public System.Windows.Forms.GroupBox Grupo_Guardar_Posicion;
        public System.Windows.Forms.CheckBox Checkeo_Escuchar_Camara;
        public System.Windows.Forms.Label Titulo_Camara;
        public System.Windows.Forms.Label Titulo_Grabando;
        public Vlc.DotNet.Forms.VlcControl Ventana_Grabacion_Video;

    }
}

