namespace ASECS
{
    partial class Usuario_Olvidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Olvidado));
            this.Texto_Correo = new System.Windows.Forms.TextBox();
            this.Titulo_Mensaje = new System.Windows.Forms.Label();
            this.Boton_Aceptar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texto_Correo
            // 
            this.Texto_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Correo.Location = new System.Drawing.Point(92, 53);
            this.Texto_Correo.Name = "Texto_Correo";
            this.Texto_Correo.Size = new System.Drawing.Size(315, 26);
            this.Texto_Correo.TabIndex = 0;
            // 
            // Titulo_Mensaje
            // 
            this.Titulo_Mensaje.AutoSize = true;
            this.Titulo_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Mensaje.Location = new System.Drawing.Point(135, 20);
            this.Titulo_Mensaje.Name = "Titulo_Mensaje";
            this.Titulo_Mensaje.Size = new System.Drawing.Size(225, 20);
            this.Titulo_Mensaje.TabIndex = 1;
            this.Titulo_Mensaje.Text = "Introduce tu correo electrónico";
            // 
            // Boton_Aceptar
            // 
            this.Boton_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Aceptar.Location = new System.Drawing.Point(215, 154);
            this.Boton_Aceptar.Name = "Boton_Aceptar";
            this.Boton_Aceptar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Aceptar.TabIndex = 2;
            this.Boton_Aceptar.Text = "Aceptar";
            this.Boton_Aceptar.UseVisualStyleBackColor = true;
            this.Boton_Aceptar.Click += new System.EventHandler(this.Boton_Aceptar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(348, 154);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Cancelar.TabIndex = 3;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Usuario_Olvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 208);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Aceptar);
            this.Controls.Add(this.Titulo_Mensaje);
            this.Controls.Add(this.Texto_Correo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usuario_Olvidado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Cuenta";
            this.Load += new System.EventHandler(this.Usuario_Olvidado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Texto_Correo;
        private System.Windows.Forms.Label Titulo_Mensaje;
        private System.Windows.Forms.Button Boton_Aceptar;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}