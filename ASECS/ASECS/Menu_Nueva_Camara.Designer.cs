namespace ASECS
{
    partial class Menu_Nueva_Camara
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
            this.Lista_Camaras_Disponibles = new System.Windows.Forms.ListBox();
            this.Boton_Actualizar_Camaras = new System.Windows.Forms.Button();
            this.Boton_Agregar_Camara = new System.Windows.Forms.Button();
            this.Grupo_Lista_Camaras = new System.Windows.Forms.GroupBox();
            this.Protocolo_Transporte = new System.Windows.Forms.ComboBox();
            this.Boton_Seleccionar_Camara = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Texto_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Texto_Contraseña = new System.Windows.Forms.TextBox();
            this.Grupo_Urls_Camara = new System.Windows.Forms.GroupBox();
            this.Texto_Alias = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Texto_Puerto_CGI = new System.Windows.Forms.TextBox();
            this.Lista_Url_Camara_Seleccionada = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Texto_Puerto_RTSP = new System.Windows.Forms.TextBox();
            this.Texto_Direccion_IP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Checkeo_Cambio_Puerto_CGI = new System.Windows.Forms.CheckBox();
            this.Grupo_Lista_Camaras.SuspendLayout();
            this.Grupo_Urls_Camara.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista_Camaras_Disponibles
            // 
            this.Lista_Camaras_Disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_Camaras_Disponibles.FormattingEnabled = true;
            this.Lista_Camaras_Disponibles.ItemHeight = 20;
            this.Lista_Camaras_Disponibles.Location = new System.Drawing.Point(19, 39);
            this.Lista_Camaras_Disponibles.Name = "Lista_Camaras_Disponibles";
            this.Lista_Camaras_Disponibles.Size = new System.Drawing.Size(413, 164);
            this.Lista_Camaras_Disponibles.TabIndex = 0;
            // 
            // Boton_Actualizar_Camaras
            // 
            this.Boton_Actualizar_Camaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Actualizar_Camaras.Location = new System.Drawing.Point(151, 209);
            this.Boton_Actualizar_Camaras.Name = "Boton_Actualizar_Camaras";
            this.Boton_Actualizar_Camaras.Size = new System.Drawing.Size(150, 51);
            this.Boton_Actualizar_Camaras.TabIndex = 1;
            this.Boton_Actualizar_Camaras.Text = "Actualizar";
            this.Boton_Actualizar_Camaras.UseVisualStyleBackColor = true;
            this.Boton_Actualizar_Camaras.Click += new System.EventHandler(this.Boton_Actualizar_Camaras_Click_1);
            // 
            // Boton_Agregar_Camara
            // 
            this.Boton_Agregar_Camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Agregar_Camara.Location = new System.Drawing.Point(162, 461);
            this.Boton_Agregar_Camara.Name = "Boton_Agregar_Camara";
            this.Boton_Agregar_Camara.Size = new System.Drawing.Size(150, 53);
            this.Boton_Agregar_Camara.TabIndex = 3;
            this.Boton_Agregar_Camara.Text = "Agregar Camara";
            this.Boton_Agregar_Camara.UseVisualStyleBackColor = true;
            this.Boton_Agregar_Camara.Click += new System.EventHandler(this.Boton_Agregar_Camara_Click);
            // 
            // Grupo_Lista_Camaras
            // 
            this.Grupo_Lista_Camaras.Controls.Add(this.Protocolo_Transporte);
            this.Grupo_Lista_Camaras.Controls.Add(this.Boton_Seleccionar_Camara);
            this.Grupo_Lista_Camaras.Controls.Add(this.Boton_Actualizar_Camaras);
            this.Grupo_Lista_Camaras.Controls.Add(this.label6);
            this.Grupo_Lista_Camaras.Controls.Add(this.label7);
            this.Grupo_Lista_Camaras.Controls.Add(this.Lista_Camaras_Disponibles);
            this.Grupo_Lista_Camaras.Controls.Add(this.label2);
            this.Grupo_Lista_Camaras.Controls.Add(this.Texto_Usuario);
            this.Grupo_Lista_Camaras.Controls.Add(this.label3);
            this.Grupo_Lista_Camaras.Controls.Add(this.Texto_Contraseña);
            this.Grupo_Lista_Camaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Lista_Camaras.Location = new System.Drawing.Point(15, 12);
            this.Grupo_Lista_Camaras.Name = "Grupo_Lista_Camaras";
            this.Grupo_Lista_Camaras.Size = new System.Drawing.Size(466, 518);
            this.Grupo_Lista_Camaras.TabIndex = 4;
            this.Grupo_Lista_Camaras.TabStop = false;
            this.Grupo_Lista_Camaras.Text = "Lista de Camaras en Red";
            // 
            // Protocolo_Transporte
            // 
            this.Protocolo_Transporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Protocolo_Transporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Protocolo_Transporte.FormattingEnabled = true;
            this.Protocolo_Transporte.Location = new System.Drawing.Point(151, 414);
            this.Protocolo_Transporte.Name = "Protocolo_Transporte";
            this.Protocolo_Transporte.Size = new System.Drawing.Size(164, 28);
            this.Protocolo_Transporte.TabIndex = 14;
            // 
            // Boton_Seleccionar_Camara
            // 
            this.Boton_Seleccionar_Camara.Location = new System.Drawing.Point(151, 461);
            this.Boton_Seleccionar_Camara.Name = "Boton_Seleccionar_Camara";
            this.Boton_Seleccionar_Camara.Size = new System.Drawing.Size(150, 51);
            this.Boton_Seleccionar_Camara.TabIndex = 10;
            this.Boton_Seleccionar_Camara.Text = "Seleccionar";
            this.Boton_Seleccionar_Camara.UseVisualStyleBackColor = true;
            this.Boton_Seleccionar_Camara.Click += new System.EventHandler(this.Boton_Seleccionar_Camara_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Protocolo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 60);
            this.label7.TabIndex = 1;
            this.label7.Text = "Si esta es cámara que deseas agregar selecciónala \r\ne introduce el usuario, contr" +
    "aseña y selecciona \r\nel protocolo (RSTP es el recomendado)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // Texto_Usuario
            // 
            this.Texto_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Usuario.Location = new System.Drawing.Point(151, 336);
            this.Texto_Usuario.Name = "Texto_Usuario";
            this.Texto_Usuario.Size = new System.Drawing.Size(164, 26);
            this.Texto_Usuario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // Texto_Contraseña
            // 
            this.Texto_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Contraseña.Location = new System.Drawing.Point(151, 372);
            this.Texto_Contraseña.Name = "Texto_Contraseña";
            this.Texto_Contraseña.Size = new System.Drawing.Size(164, 26);
            this.Texto_Contraseña.TabIndex = 8;
            this.Texto_Contraseña.UseSystemPasswordChar = true;
            // 
            // Grupo_Urls_Camara
            // 
            this.Grupo_Urls_Camara.Controls.Add(this.Texto_Alias);
            this.Grupo_Urls_Camara.Controls.Add(this.label9);
            this.Grupo_Urls_Camara.Controls.Add(this.label8);
            this.Grupo_Urls_Camara.Controls.Add(this.Boton_Agregar_Camara);
            this.Grupo_Urls_Camara.Controls.Add(this.Texto_Puerto_CGI);
            this.Grupo_Urls_Camara.Controls.Add(this.Lista_Url_Camara_Seleccionada);
            this.Grupo_Urls_Camara.Controls.Add(this.label1);
            this.Grupo_Urls_Camara.Controls.Add(this.Texto_Puerto_RTSP);
            this.Grupo_Urls_Camara.Controls.Add(this.Texto_Direccion_IP);
            this.Grupo_Urls_Camara.Controls.Add(this.label5);
            this.Grupo_Urls_Camara.Controls.Add(this.label4);
            this.Grupo_Urls_Camara.Controls.Add(this.Checkeo_Cambio_Puerto_CGI);
            this.Grupo_Urls_Camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Urls_Camara.Location = new System.Drawing.Point(490, 12);
            this.Grupo_Urls_Camara.Name = "Grupo_Urls_Camara";
            this.Grupo_Urls_Camara.Size = new System.Drawing.Size(466, 518);
            this.Grupo_Urls_Camara.TabIndex = 5;
            this.Grupo_Urls_Camara.TabStop = false;
            this.Grupo_Urls_Camara.Text = "Urls Disponibles";
            // 
            // Texto_Alias
            // 
            this.Texto_Alias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Alias.Location = new System.Drawing.Point(128, 293);
            this.Texto_Alias.Name = "Texto_Alias";
            this.Texto_Alias.Size = new System.Drawing.Size(305, 26);
            this.Texto_Alias.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Alias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 60);
            this.label8.TabIndex = 16;
            this.label8.Text = "Aquí se encuentran las direcciones según \r\nla calidad de la cámara para su visual" +
    "ización,\r\nSelecciona una y da clic en el botón Agregar Camara.\r\n";
            // 
            // Texto_Puerto_CGI
            // 
            this.Texto_Puerto_CGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Puerto_CGI.Location = new System.Drawing.Point(128, 375);
            this.Texto_Puerto_CGI.Name = "Texto_Puerto_CGI";
            this.Texto_Puerto_CGI.Size = new System.Drawing.Size(100, 26);
            this.Texto_Puerto_CGI.TabIndex = 11;
            this.Texto_Puerto_CGI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texto_Puerto_CGI_KeyPress);
            // 
            // Lista_Url_Camara_Seleccionada
            // 
            this.Lista_Url_Camara_Seleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_Url_Camara_Seleccionada.FormattingEnabled = true;
            this.Lista_Url_Camara_Seleccionada.ItemHeight = 20;
            this.Lista_Url_Camara_Seleccionada.Location = new System.Drawing.Point(20, 39);
            this.Lista_Url_Camara_Seleccionada.Name = "Lista_Url_Camara_Seleccionada";
            this.Lista_Url_Camara_Seleccionada.Size = new System.Drawing.Size(413, 164);
            this.Lista_Url_Camara_Seleccionada.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Direccion IP";
            // 
            // Texto_Puerto_RTSP
            // 
            this.Texto_Puerto_RTSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Puerto_RTSP.Location = new System.Drawing.Point(128, 412);
            this.Texto_Puerto_RTSP.Name = "Texto_Puerto_RTSP";
            this.Texto_Puerto_RTSP.Size = new System.Drawing.Size(100, 26);
            this.Texto_Puerto_RTSP.TabIndex = 13;
            // 
            // Texto_Direccion_IP
            // 
            this.Texto_Direccion_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Direccion_IP.Location = new System.Drawing.Point(128, 333);
            this.Texto_Direccion_IP.Name = "Texto_Direccion_IP";
            this.Texto_Direccion_IP.Size = new System.Drawing.Size(305, 26);
            this.Texto_Direccion_IP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Puerto RTSP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Puerto CGI";
            // 
            // Checkeo_Cambio_Puerto_CGI
            // 
            this.Checkeo_Cambio_Puerto_CGI.AutoSize = true;
            this.Checkeo_Cambio_Puerto_CGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkeo_Cambio_Puerto_CGI.Location = new System.Drawing.Point(232, 378);
            this.Checkeo_Cambio_Puerto_CGI.Name = "Checkeo_Cambio_Puerto_CGI";
            this.Checkeo_Cambio_Puerto_CGI.Size = new System.Drawing.Size(201, 28);
            this.Checkeo_Cambio_Puerto_CGI.TabIndex = 4;
            this.Checkeo_Cambio_Puerto_CGI.Text = "Cambiar Este Puerto";
            this.Checkeo_Cambio_Puerto_CGI.UseVisualStyleBackColor = true;
            this.Checkeo_Cambio_Puerto_CGI.CheckedChanged += new System.EventHandler(this.Checkeo_Cambio_Puerto_CGI_CheckedChanged);
            // 
            // Menu_Nueva_Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 544);
            this.Controls.Add(this.Grupo_Lista_Camaras);
            this.Controls.Add(this.Grupo_Urls_Camara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Nueva_Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Agregar Camaras";
            this.Load += new System.EventHandler(this.Menu_Nueva_Camara_Load);
            this.Grupo_Lista_Camaras.ResumeLayout(false);
            this.Grupo_Lista_Camaras.PerformLayout();
            this.Grupo_Urls_Camara.ResumeLayout(false);
            this.Grupo_Urls_Camara.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Boton_Actualizar_Camaras;
        public System.Windows.Forms.ListBox Lista_Camaras_Disponibles;
        public System.Windows.Forms.Button Boton_Agregar_Camara;
        public System.Windows.Forms.GroupBox Grupo_Lista_Camaras;
        public System.Windows.Forms.GroupBox Grupo_Urls_Camara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Texto_Puerto_CGI;
        public System.Windows.Forms.TextBox Texto_Contraseña;
        public System.Windows.Forms.TextBox Texto_Usuario;
        public System.Windows.Forms.TextBox Texto_Direccion_IP;
        public System.Windows.Forms.TextBox Texto_Puerto_RTSP;
        public System.Windows.Forms.ComboBox Protocolo_Transporte;
        public System.Windows.Forms.ListBox Lista_Url_Camara_Seleccionada;
        public System.Windows.Forms.CheckBox Checkeo_Cambio_Puerto_CGI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button Boton_Seleccionar_Camara;
        private System.Windows.Forms.TextBox Texto_Alias;
        private System.Windows.Forms.Label label9;
    }
}