namespace ASECS
{
    partial class Menu_Eliminar_Camara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Eliminar_Camara));
            this.Titulo_Mensaje = new System.Windows.Forms.Label();
            this.Tabla_Lista_Camaras = new System.Windows.Forms.DataGridView();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Lista_Camaras)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo_Mensaje
            // 
            this.Titulo_Mensaje.AutoSize = true;
            this.Titulo_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Mensaje.Location = new System.Drawing.Point(273, 20);
            this.Titulo_Mensaje.Name = "Titulo_Mensaje";
            this.Titulo_Mensaje.Size = new System.Drawing.Size(153, 24);
            this.Titulo_Mensaje.TabIndex = 0;
            this.Titulo_Mensaje.Text = "Lista de Camaras";
            // 
            // Tabla_Lista_Camaras
            // 
            this.Tabla_Lista_Camaras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Lista_Camaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Lista_Camaras.Location = new System.Drawing.Point(12, 47);
            this.Tabla_Lista_Camaras.Name = "Tabla_Lista_Camaras";
            this.Tabla_Lista_Camaras.Size = new System.Drawing.Size(706, 277);
            this.Tabla_Lista_Camaras.TabIndex = 1;
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(591, 330);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Cancelar.TabIndex = 5;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Eliminar.Location = new System.Drawing.Point(458, 330);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(127, 38);
            this.Boton_Eliminar.TabIndex = 4;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = true;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // Menu_Eliminar_Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 388);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Tabla_Lista_Camaras);
            this.Controls.Add(this.Titulo_Mensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Eliminar_Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Camara";
            this.Load += new System.EventHandler(this.Menu_Eliminar_Camara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Lista_Camaras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Mensaje;
        private System.Windows.Forms.DataGridView Tabla_Lista_Camaras;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Button Boton_Eliminar;
    }
}