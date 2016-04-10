namespace ASECS
{
    partial class Menu_Editar_Usuario
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
            this.Texto_Usuario = new System.Windows.Forms.TextBox();
            this.Grupo_Datos_Usuario = new System.Windows.Forms.GroupBox();
            this.Boton_Aceptar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Texto_Email = new System.Windows.Forms.TextBox();
            this.Texto_Repetir_Contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Texto_Nueva_Contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Texto_Contraseña_Anterior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grupo_Datos_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Texto_Usuario
            // 
            this.Texto_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Usuario.Location = new System.Drawing.Point(172, 41);
            this.Texto_Usuario.Name = "Texto_Usuario";
            this.Texto_Usuario.Size = new System.Drawing.Size(260, 26);
            this.Texto_Usuario.TabIndex = 0;
            // 
            // Grupo_Datos_Usuario
            // 
            this.Grupo_Datos_Usuario.Controls.Add(this.Boton_Aceptar);
            this.Grupo_Datos_Usuario.Controls.Add(this.Boton_Cancelar);
            this.Grupo_Datos_Usuario.Controls.Add(this.label5);
            this.Grupo_Datos_Usuario.Controls.Add(this.Texto_Email);
            this.Grupo_Datos_Usuario.Controls.Add(this.Texto_Repetir_Contraseña);
            this.Grupo_Datos_Usuario.Controls.Add(this.label4);
            this.Grupo_Datos_Usuario.Controls.Add(this.Texto_Nueva_Contraseña);
            this.Grupo_Datos_Usuario.Controls.Add(this.label3);
            this.Grupo_Datos_Usuario.Controls.Add(this.Texto_Contraseña_Anterior);
            this.Grupo_Datos_Usuario.Controls.Add(this.label2);
            this.Grupo_Datos_Usuario.Controls.Add(this.label1);
            this.Grupo_Datos_Usuario.Controls.Add(this.Texto_Usuario);
            this.Grupo_Datos_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Datos_Usuario.Location = new System.Drawing.Point(12, 12);
            this.Grupo_Datos_Usuario.Name = "Grupo_Datos_Usuario";
            this.Grupo_Datos_Usuario.Size = new System.Drawing.Size(453, 290);
            this.Grupo_Datos_Usuario.TabIndex = 1;
            this.Grupo_Datos_Usuario.TabStop = false;
            this.Grupo_Datos_Usuario.Text = "Datos del Usuario";
            // 
            // Boton_Aceptar
            // 
            this.Boton_Aceptar.Location = new System.Drawing.Point(171, 227);
            this.Boton_Aceptar.Name = "Boton_Aceptar";
            this.Boton_Aceptar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Aceptar.TabIndex = 11;
            this.Boton_Aceptar.Text = "Aceptar";
            this.Boton_Aceptar.UseVisualStyleBackColor = true;
            this.Boton_Aceptar.Click += new System.EventHandler(this.Boton_Aceptar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(305, 227);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Cancelar.TabIndex = 10;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // Texto_Email
            // 
            this.Texto_Email.Location = new System.Drawing.Point(172, 73);
            this.Texto_Email.Name = "Texto_Email";
            this.Texto_Email.Size = new System.Drawing.Size(260, 26);
            this.Texto_Email.TabIndex = 8;
            // 
            // Texto_Repetir_Contraseña
            // 
            this.Texto_Repetir_Contraseña.Location = new System.Drawing.Point(171, 169);
            this.Texto_Repetir_Contraseña.Name = "Texto_Repetir_Contraseña";
            this.Texto_Repetir_Contraseña.Size = new System.Drawing.Size(261, 26);
            this.Texto_Repetir_Contraseña.TabIndex = 7;
            this.Texto_Repetir_Contraseña.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repite la Contraseña";
            // 
            // Texto_Nueva_Contraseña
            // 
            this.Texto_Nueva_Contraseña.Location = new System.Drawing.Point(171, 137);
            this.Texto_Nueva_Contraseña.Name = "Texto_Nueva_Contraseña";
            this.Texto_Nueva_Contraseña.Size = new System.Drawing.Size(261, 26);
            this.Texto_Nueva_Contraseña.TabIndex = 5;
            this.Texto_Nueva_Contraseña.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva Contraseña";
            // 
            // Texto_Contraseña_Anterior
            // 
            this.Texto_Contraseña_Anterior.Location = new System.Drawing.Point(171, 105);
            this.Texto_Contraseña_Anterior.Name = "Texto_Contraseña_Anterior";
            this.Texto_Contraseña_Anterior.Size = new System.Drawing.Size(261, 26);
            this.Texto_Contraseña_Anterior.TabIndex = 3;
            this.Texto_Contraseña_Anterior.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña Anterior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Usuario";
            // 
            // Menu_Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 314);
            this.Controls.Add(this.Grupo_Datos_Usuario);
            this.MaximizeBox = false;
            this.Name = "Menu_Editar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuario";
            this.Load += new System.EventHandler(this.Menu_Editar_Usuario_Load);
            this.Grupo_Datos_Usuario.ResumeLayout(false);
            this.Grupo_Datos_Usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Texto_Usuario;
        private System.Windows.Forms.GroupBox Grupo_Datos_Usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Texto_Nueva_Contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Texto_Contraseña_Anterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Texto_Repetir_Contraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Texto_Email;
        private System.Windows.Forms.Button Boton_Aceptar;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}