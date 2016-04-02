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
            this.Menu_Lista_Camaras = new System.Windows.Forms.FlowLayoutPanel();
            this.Titulo_Bienvenida = new System.Windows.Forms.Label();
            this.Menu_Principal_Opciones = new System.Windows.Forms.ToolStrip();
            this.Menu_Principal_Agregar = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Principal_Nueva_Camara = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal_Rutas = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_Principal_Cambiar_Rutas = new System.Windows.Forms.ToolStripMenuItem();
            this.Dialogo_Ruta_Grabacion = new System.Windows.Forms.FolderBrowserDialog();
            this.Titulo_Vista = new System.Windows.Forms.Label();
            this.Menu_Principal_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Lista_Camaras
            // 
            this.Menu_Lista_Camaras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_Lista_Camaras.Location = new System.Drawing.Point(12, 171);
            this.Menu_Lista_Camaras.Name = "Menu_Lista_Camaras";
            this.Menu_Lista_Camaras.Size = new System.Drawing.Size(1012, 389);
            this.Menu_Lista_Camaras.TabIndex = 0;
            // 
            // Titulo_Bienvenida
            // 
            this.Titulo_Bienvenida.AutoSize = true;
            this.Titulo_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Bienvenida.Location = new System.Drawing.Point(438, 63);
            this.Titulo_Bienvenida.Name = "Titulo_Bienvenida";
            this.Titulo_Bienvenida.Size = new System.Drawing.Size(127, 24);
            this.Titulo_Bienvenida.TabIndex = 2;
            this.Titulo_Bienvenida.Text = "Bienvenido: ";
            // 
            // Menu_Principal_Opciones
            // 
            this.Menu_Principal_Opciones.ImageScalingSize = new System.Drawing.Size(70, 60);
            this.Menu_Principal_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Principal_Agregar,
            this.Menu_Principal_Rutas});
            this.Menu_Principal_Opciones.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal_Opciones.Name = "Menu_Principal_Opciones";
            this.Menu_Principal_Opciones.Size = new System.Drawing.Size(1033, 67);
            this.Menu_Principal_Opciones.TabIndex = 3;
            this.Menu_Principal_Opciones.Text = "toolStrip1";
            // 
            // Menu_Principal_Agregar
            // 
            this.Menu_Principal_Agregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Principal_Nueva_Camara});
            this.Menu_Principal_Agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Principal_Agregar.Image = global::ASECS.Properties.Resources.Camara;
            this.Menu_Principal_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Principal_Agregar.Name = "Menu_Principal_Agregar";
            this.Menu_Principal_Agregar.ShowDropDownArrow = false;
            this.Menu_Principal_Agregar.Size = new System.Drawing.Size(126, 64);
            this.Menu_Principal_Agregar.Text = "Agregar";
            this.Menu_Principal_Agregar.ToolTipText = "Permite Registrar Una nueva Camara al Sistema";
            // 
            // Menu_Principal_Nueva_Camara
            // 
            this.Menu_Principal_Nueva_Camara.Image = global::ASECS.Properties.Resources.Nueva_Camara;
            this.Menu_Principal_Nueva_Camara.Name = "Menu_Principal_Nueva_Camara";
            this.Menu_Principal_Nueva_Camara.Size = new System.Drawing.Size(154, 22);
            this.Menu_Principal_Nueva_Camara.Text = "Nueva Camara";
            this.Menu_Principal_Nueva_Camara.Click += new System.EventHandler(this.Menu_Principal_Nueva_Camara_Click);
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
            // Titulo_Vista
            // 
            this.Titulo_Vista.AutoSize = true;
            this.Titulo_Vista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Vista.Location = new System.Drawing.Point(417, 144);
            this.Titulo_Vista.Name = "Titulo_Vista";
            this.Titulo_Vista.Size = new System.Drawing.Size(172, 24);
            this.Titulo_Vista.TabIndex = 4;
            this.Titulo_Vista.Text = "Vista de Camaras";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 572);
            this.Controls.Add(this.Titulo_Vista);
            this.Controls.Add(this.Menu_Principal_Opciones);
            this.Controls.Add(this.Titulo_Bienvenida);
            this.Controls.Add(this.Menu_Lista_Camaras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal ASECS";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.Menu_Principal_Opciones.ResumeLayout(false);
            this.Menu_Principal_Opciones.PerformLayout();
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
    }
}