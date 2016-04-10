namespace ASECS
{
    partial class Menu_Tiempo_Grabacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Tiempo_Grabacion));
            this.Tiempo_Numerico = new System.Windows.Forms.NumericUpDown();
            this.Titulo_Mensaje = new System.Windows.Forms.Label();
            this.Grupo_Opciones = new System.Windows.Forms.GroupBox();
            this.Titulo_Mensaje_Tiempos = new System.Windows.Forms.Label();
            this.Boton_Aceptar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Seleccion_Tiempo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tiempo_Numerico)).BeginInit();
            this.Grupo_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tiempo_Numerico
            // 
            this.Tiempo_Numerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo_Numerico.Location = new System.Drawing.Point(186, 99);
            this.Tiempo_Numerico.Name = "Tiempo_Numerico";
            this.Tiempo_Numerico.Size = new System.Drawing.Size(153, 26);
            this.Tiempo_Numerico.TabIndex = 0;
            this.Tiempo_Numerico.ValueChanged += new System.EventHandler(this.Tiempo_Numerico_ValueChanged);
            // 
            // Titulo_Mensaje
            // 
            this.Titulo_Mensaje.AutoSize = true;
            this.Titulo_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Mensaje.Location = new System.Drawing.Point(6, 55);
            this.Titulo_Mensaje.Name = "Titulo_Mensaje";
            this.Titulo_Mensaje.Size = new System.Drawing.Size(251, 20);
            this.Titulo_Mensaje.TabIndex = 1;
            this.Titulo_Mensaje.Text = "Generar videos cada cierto tiempo";
            // 
            // Grupo_Opciones
            // 
            this.Grupo_Opciones.Controls.Add(this.Titulo_Mensaje_Tiempos);
            this.Grupo_Opciones.Controls.Add(this.Boton_Aceptar);
            this.Grupo_Opciones.Controls.Add(this.Boton_Cancelar);
            this.Grupo_Opciones.Controls.Add(this.Seleccion_Tiempo);
            this.Grupo_Opciones.Controls.Add(this.Titulo_Mensaje);
            this.Grupo_Opciones.Controls.Add(this.Tiempo_Numerico);
            this.Grupo_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Opciones.Location = new System.Drawing.Point(12, 9);
            this.Grupo_Opciones.Name = "Grupo_Opciones";
            this.Grupo_Opciones.Size = new System.Drawing.Size(501, 248);
            this.Grupo_Opciones.TabIndex = 2;
            this.Grupo_Opciones.TabStop = false;
            this.Grupo_Opciones.Text = "Opciones";
            // 
            // Titulo_Mensaje_Tiempos
            // 
            this.Titulo_Mensaje_Tiempos.AutoSize = true;
            this.Titulo_Mensaje_Tiempos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Mensaje_Tiempos.Location = new System.Drawing.Point(6, 147);
            this.Titulo_Mensaje_Tiempos.Name = "Titulo_Mensaje_Tiempos";
            this.Titulo_Mensaje_Tiempos.Size = new System.Drawing.Size(225, 20);
            this.Titulo_Mensaje_Tiempos.TabIndex = 5;
            this.Titulo_Mensaje_Tiempos.Text = "Los videos se generaran cada:";
            // 
            // Boton_Aceptar
            // 
            this.Boton_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Aceptar.Location = new System.Drawing.Point(235, 205);
            this.Boton_Aceptar.Name = "Boton_Aceptar";
            this.Boton_Aceptar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Aceptar.TabIndex = 4;
            this.Boton_Aceptar.Text = "Aceptar";
            this.Boton_Aceptar.UseVisualStyleBackColor = true;
            this.Boton_Aceptar.Click += new System.EventHandler(this.Boton_Aceptar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(368, 205);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Cancelar.TabIndex = 3;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Seleccion_Tiempo
            // 
            this.Seleccion_Tiempo.FormattingEnabled = true;
            this.Seleccion_Tiempo.Location = new System.Drawing.Point(10, 97);
            this.Seleccion_Tiempo.Name = "Seleccion_Tiempo";
            this.Seleccion_Tiempo.Size = new System.Drawing.Size(154, 28);
            this.Seleccion_Tiempo.TabIndex = 2;
            this.Seleccion_Tiempo.SelectedIndexChanged += new System.EventHandler(this.Seleccion_Tiempo_SelectedIndexChanged);
            // 
            // Menu_Tiempo_Grabacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 269);
            this.Controls.Add(this.Grupo_Opciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Tiempo_Grabacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Tiempos de Grabación";
            ((System.ComponentModel.ISupportInitialize)(this.Tiempo_Numerico)).EndInit();
            this.Grupo_Opciones.ResumeLayout(false);
            this.Grupo_Opciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Tiempo_Numerico;
        private System.Windows.Forms.Label Titulo_Mensaje;
        private System.Windows.Forms.GroupBox Grupo_Opciones;
        private System.Windows.Forms.Button Boton_Aceptar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.ComboBox Seleccion_Tiempo;
        private System.Windows.Forms.Label Titulo_Mensaje_Tiempos;
    }
}