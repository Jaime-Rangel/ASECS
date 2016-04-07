namespace ASECS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Titulo_Usuario = new System.Windows.Forms.Label();
            this.Texto_Usuario = new System.Windows.Forms.TextBox();
            this.Titulo_Contraseña = new System.Windows.Forms.Label();
            this.Texto_Contraseña = new System.Windows.Forms.TextBox();
            this.Boton_Iniciar = new System.Windows.Forms.Button();
            this.Titulo_Perdido = new System.Windows.Forms.LinkLabel();
            this.Grupo_Login = new System.Windows.Forms.GroupBox();
            this.Grupo_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo_Usuario
            // 
            this.Titulo_Usuario.AutoSize = true;
            this.Titulo_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Usuario.Location = new System.Drawing.Point(119, 44);
            this.Titulo_Usuario.Name = "Titulo_Usuario";
            this.Titulo_Usuario.Size = new System.Drawing.Size(71, 20);
            this.Titulo_Usuario.TabIndex = 0;
            this.Titulo_Usuario.Text = "Usuario";
            // 
            // Texto_Usuario
            // 
            this.Texto_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Usuario.Location = new System.Drawing.Point(28, 67);
            this.Texto_Usuario.Name = "Texto_Usuario";
            this.Texto_Usuario.Size = new System.Drawing.Size(239, 26);
            this.Texto_Usuario.TabIndex = 1;
            this.Texto_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texto_Usuario_KeyPress);
            // 
            // Titulo_Contraseña
            // 
            this.Titulo_Contraseña.AutoSize = true;
            this.Titulo_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Contraseña.Location = new System.Drawing.Point(98, 125);
            this.Titulo_Contraseña.Name = "Titulo_Contraseña";
            this.Titulo_Contraseña.Size = new System.Drawing.Size(102, 20);
            this.Titulo_Contraseña.TabIndex = 2;
            this.Titulo_Contraseña.Text = "Contraseña";
            // 
            // Texto_Contraseña
            // 
            this.Texto_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Contraseña.Location = new System.Drawing.Point(28, 148);
            this.Texto_Contraseña.Name = "Texto_Contraseña";
            this.Texto_Contraseña.Size = new System.Drawing.Size(239, 26);
            this.Texto_Contraseña.TabIndex = 3;
            this.Texto_Contraseña.UseSystemPasswordChar = true;
            this.Texto_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texto_Contraseña_KeyPress);
            // 
            // Boton_Iniciar
            // 
            this.Boton_Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Iniciar.Location = new System.Drawing.Point(79, 193);
            this.Boton_Iniciar.Name = "Boton_Iniciar";
            this.Boton_Iniciar.Size = new System.Drawing.Size(152, 38);
            this.Boton_Iniciar.TabIndex = 4;
            this.Boton_Iniciar.Text = "Iniciar Sesion";
            this.Boton_Iniciar.UseVisualStyleBackColor = true;
            this.Boton_Iniciar.Click += new System.EventHandler(this.Boton_Iniciar_Click);
            // 
            // Titulo_Perdido
            // 
            this.Titulo_Perdido.AutoSize = true;
            this.Titulo_Perdido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Perdido.Location = new System.Drawing.Point(24, 405);
            this.Titulo_Perdido.Name = "Titulo_Perdido";
            this.Titulo_Perdido.Size = new System.Drawing.Size(255, 20);
            this.Titulo_Perdido.TabIndex = 5;
            this.Titulo_Perdido.TabStop = true;
            this.Titulo_Perdido.Text = "Olvide mi usuario o contraseña";
            // 
            // Grupo_Login
            // 
            this.Grupo_Login.Controls.Add(this.Titulo_Perdido);
            this.Grupo_Login.Controls.Add(this.Titulo_Usuario);
            this.Grupo_Login.Controls.Add(this.Texto_Usuario);
            this.Grupo_Login.Controls.Add(this.Titulo_Contraseña);
            this.Grupo_Login.Controls.Add(this.Texto_Contraseña);
            this.Grupo_Login.Controls.Add(this.Boton_Iniciar);
            this.Grupo_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Login.Location = new System.Drawing.Point(12, 7);
            this.Grupo_Login.Name = "Grupo_Login";
            this.Grupo_Login.Size = new System.Drawing.Size(303, 475);
            this.Grupo_Login.TabIndex = 6;
            this.Grupo_Login.TabStop = false;
            this.Grupo_Login.Text = "Introduce tus datos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 494);
            this.Controls.Add(this.Grupo_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Grupo_Login.ResumeLayout(false);
            this.Grupo_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Usuario;
        private System.Windows.Forms.Label Titulo_Contraseña;
        private System.Windows.Forms.LinkLabel Titulo_Perdido;
        private System.Windows.Forms.GroupBox Grupo_Login;
        public System.Windows.Forms.TextBox Texto_Usuario;
        public System.Windows.Forms.TextBox Texto_Contraseña;
        public System.Windows.Forms.Button Boton_Iniciar;
    }
}