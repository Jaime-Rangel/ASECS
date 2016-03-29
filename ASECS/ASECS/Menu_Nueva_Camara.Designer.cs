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
            this.Boton_Buscar_Camaras = new System.Windows.Forms.Button();
            this.Titulo_Nueva_Camara = new System.Windows.Forms.Label();
            this.Boton_Agregar_Camara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista_Camaras_Disponibles
            // 
            this.Lista_Camaras_Disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_Camaras_Disponibles.FormattingEnabled = true;
            this.Lista_Camaras_Disponibles.ItemHeight = 20;
            this.Lista_Camaras_Disponibles.Location = new System.Drawing.Point(79, 36);
            this.Lista_Camaras_Disponibles.Name = "Lista_Camaras_Disponibles";
            this.Lista_Camaras_Disponibles.Size = new System.Drawing.Size(503, 304);
            this.Lista_Camaras_Disponibles.TabIndex = 0;
            // 
            // Boton_Buscar_Camaras
            // 
            this.Boton_Buscar_Camaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Buscar_Camaras.Location = new System.Drawing.Point(265, 346);
            this.Boton_Buscar_Camaras.Name = "Boton_Buscar_Camaras";
            this.Boton_Buscar_Camaras.Size = new System.Drawing.Size(150, 53);
            this.Boton_Buscar_Camaras.TabIndex = 1;
            this.Boton_Buscar_Camaras.Text = "Buscar Camaras";
            this.Boton_Buscar_Camaras.UseVisualStyleBackColor = true;
            this.Boton_Buscar_Camaras.Click += new System.EventHandler(this.Boton_Buscar_Camaras_Click);
            // 
            // Titulo_Nueva_Camara
            // 
            this.Titulo_Nueva_Camara.AutoSize = true;
            this.Titulo_Nueva_Camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Nueva_Camara.Location = new System.Drawing.Point(208, 9);
            this.Titulo_Nueva_Camara.Name = "Titulo_Nueva_Camara";
            this.Titulo_Nueva_Camara.Size = new System.Drawing.Size(243, 24);
            this.Titulo_Nueva_Camara.TabIndex = 2;
            this.Titulo_Nueva_Camara.Text = "Lista de Camaras en Red";
            // 
            // Boton_Agregar_Camara
            // 
            this.Boton_Agregar_Camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Agregar_Camara.Location = new System.Drawing.Point(265, 405);
            this.Boton_Agregar_Camara.Name = "Boton_Agregar_Camara";
            this.Boton_Agregar_Camara.Size = new System.Drawing.Size(150, 53);
            this.Boton_Agregar_Camara.TabIndex = 3;
            this.Boton_Agregar_Camara.Text = "Agregar Camara";
            this.Boton_Agregar_Camara.UseVisualStyleBackColor = true;
            this.Boton_Agregar_Camara.Click += new System.EventHandler(this.Boton_Agregar_Camara_Click);
            // 
            // Menu_Nueva_Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 485);
            this.Controls.Add(this.Boton_Agregar_Camara);
            this.Controls.Add(this.Titulo_Nueva_Camara);
            this.Controls.Add(this.Boton_Buscar_Camaras);
            this.Controls.Add(this.Lista_Camaras_Disponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Nueva_Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Agregar Camaras";
            this.Load += new System.EventHandler(this.Menu_Nueva_Camara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Boton_Buscar_Camaras;
        public System.Windows.Forms.Label Titulo_Nueva_Camara;
        public System.Windows.Forms.ListBox Lista_Camaras_Disponibles;
        public System.Windows.Forms.Button Boton_Agregar_Camara;
    }
}