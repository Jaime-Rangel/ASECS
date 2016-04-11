namespace ASECS
{
    partial class Editar_Camara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Camara));
            this.Grupo_Datos_Camara = new System.Windows.Forms.GroupBox();
            this.Titulo_Mensaje = new System.Windows.Forms.Label();
            this.Boton_Editar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Texto_Puerto_CGI = new System.Windows.Forms.TextBox();
            this.Texto_Puerto_RSTP = new System.Windows.Forms.TextBox();
            this.Texto_Direccion_IP = new System.Windows.Forms.TextBox();
            this.Texto_Contraseña = new System.Windows.Forms.TextBox();
            this.Texto_Usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Texto_Nombre_Camara = new System.Windows.Forms.TextBox();
            this.Grupo_Datos_Camara.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo_Datos_Camara
            // 
            this.Grupo_Datos_Camara.Controls.Add(this.Titulo_Mensaje);
            this.Grupo_Datos_Camara.Controls.Add(this.Boton_Editar);
            this.Grupo_Datos_Camara.Controls.Add(this.Boton_Cancelar);
            this.Grupo_Datos_Camara.Controls.Add(this.Texto_Puerto_CGI);
            this.Grupo_Datos_Camara.Controls.Add(this.Texto_Puerto_RSTP);
            this.Grupo_Datos_Camara.Controls.Add(this.Texto_Direccion_IP);
            this.Grupo_Datos_Camara.Controls.Add(this.Texto_Contraseña);
            this.Grupo_Datos_Camara.Controls.Add(this.Texto_Usuario);
            this.Grupo_Datos_Camara.Controls.Add(this.label6);
            this.Grupo_Datos_Camara.Controls.Add(this.label5);
            this.Grupo_Datos_Camara.Controls.Add(this.label4);
            this.Grupo_Datos_Camara.Controls.Add(this.label3);
            this.Grupo_Datos_Camara.Controls.Add(this.label2);
            this.Grupo_Datos_Camara.Controls.Add(this.label1);
            this.Grupo_Datos_Camara.Controls.Add(this.Texto_Nombre_Camara);
            this.Grupo_Datos_Camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Datos_Camara.Location = new System.Drawing.Point(12, 12);
            this.Grupo_Datos_Camara.Name = "Grupo_Datos_Camara";
            this.Grupo_Datos_Camara.Size = new System.Drawing.Size(455, 377);
            this.Grupo_Datos_Camara.TabIndex = 0;
            this.Grupo_Datos_Camara.TabStop = false;
            this.Grupo_Datos_Camara.Text = "Datos de la Cámara";
            // 
            // Titulo_Mensaje
            // 
            this.Titulo_Mensaje.AutoSize = true;
            this.Titulo_Mensaje.Location = new System.Drawing.Point(57, 31);
            this.Titulo_Mensaje.Name = "Titulo_Mensaje";
            this.Titulo_Mensaje.Size = new System.Drawing.Size(335, 60);
            this.Titulo_Mensaje.TabIndex = 14;
            this.Titulo_Mensaje.Text = "Este es un modo avanzado asegúrate de que \r\nla información que proporciones sea c" +
    "orrecta \r\nde lo contrario no se visualizara la cámara.";
            // 
            // Boton_Editar
            // 
            this.Boton_Editar.Location = new System.Drawing.Point(175, 325);
            this.Boton_Editar.Name = "Boton_Editar";
            this.Boton_Editar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Editar.TabIndex = 13;
            this.Boton_Editar.Text = "Editar";
            this.Boton_Editar.UseVisualStyleBackColor = true;
            this.Boton_Editar.Click += new System.EventHandler(this.Boton_Editar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(308, 325);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Cancelar.TabIndex = 12;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Texto_Puerto_CGI
            // 
            this.Texto_Puerto_CGI.Location = new System.Drawing.Point(175, 240);
            this.Texto_Puerto_CGI.Name = "Texto_Puerto_CGI";
            this.Texto_Puerto_CGI.Size = new System.Drawing.Size(127, 26);
            this.Texto_Puerto_CGI.TabIndex = 11;
            this.Texto_Puerto_CGI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texto_Puerto_CGI_KeyPress);
            // 
            // Texto_Puerto_RSTP
            // 
            this.Texto_Puerto_RSTP.Location = new System.Drawing.Point(175, 272);
            this.Texto_Puerto_RSTP.Name = "Texto_Puerto_RSTP";
            this.Texto_Puerto_RSTP.Size = new System.Drawing.Size(127, 26);
            this.Texto_Puerto_RSTP.TabIndex = 10;
            this.Texto_Puerto_RSTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texto_Puerto_RSTP_KeyPress);
            // 
            // Texto_Direccion_IP
            // 
            this.Texto_Direccion_IP.Location = new System.Drawing.Point(175, 208);
            this.Texto_Direccion_IP.Name = "Texto_Direccion_IP";
            this.Texto_Direccion_IP.Size = new System.Drawing.Size(260, 26);
            this.Texto_Direccion_IP.TabIndex = 9;
            // 
            // Texto_Contraseña
            // 
            this.Texto_Contraseña.Location = new System.Drawing.Point(175, 176);
            this.Texto_Contraseña.Name = "Texto_Contraseña";
            this.Texto_Contraseña.Size = new System.Drawing.Size(260, 26);
            this.Texto_Contraseña.TabIndex = 8;
            // 
            // Texto_Usuario
            // 
            this.Texto_Usuario.Location = new System.Drawing.Point(175, 144);
            this.Texto_Usuario.Name = "Texto_Usuario";
            this.Texto_Usuario.Size = new System.Drawing.Size(260, 26);
            this.Texto_Usuario.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Puerto RSTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puerto GCI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Cámara";
            // 
            // Texto_Nombre_Camara
            // 
            this.Texto_Nombre_Camara.Location = new System.Drawing.Point(175, 110);
            this.Texto_Nombre_Camara.Name = "Texto_Nombre_Camara";
            this.Texto_Nombre_Camara.Size = new System.Drawing.Size(260, 26);
            this.Texto_Nombre_Camara.TabIndex = 0;
            this.Texto_Nombre_Camara.TextChanged += new System.EventHandler(this.Texto_Nombre_Camara_TextChanged);
            // 
            // Editar_Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 395);
            this.Controls.Add(this.Grupo_Datos_Camara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editar_Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar_Camara";
            this.Load += new System.EventHandler(this.Editar_Camara_Load_1);
            this.Grupo_Datos_Camara.ResumeLayout(false);
            this.Grupo_Datos_Camara.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_Datos_Camara;
        private System.Windows.Forms.TextBox Texto_Nombre_Camara;
        private System.Windows.Forms.TextBox Texto_Puerto_CGI;
        private System.Windows.Forms.TextBox Texto_Puerto_RSTP;
        private System.Windows.Forms.TextBox Texto_Direccion_IP;
        private System.Windows.Forms.TextBox Texto_Contraseña;
        private System.Windows.Forms.TextBox Texto_Usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Button Boton_Editar;
        private System.Windows.Forms.Label Titulo_Mensaje;
    }
}