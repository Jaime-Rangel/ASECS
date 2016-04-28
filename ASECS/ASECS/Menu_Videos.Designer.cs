namespace ASECS
{
    partial class Menu_Videos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Videos));
            this.Grupo_Busqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_buscarpor = new System.Windows.Forms.ComboBox();
            this.Grupo_Fecha = new System.Windows.Forms.GroupBox();
            this.ubicacion_dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Boton_Buscar = new System.Windows.Forms.Button();
            this.Grupo_Lista = new System.Windows.Forms.GroupBox();
            this.lista_videos = new System.Windows.Forms.ListBox();
            this.txb_buscar = new System.Windows.Forms.TextBox();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.Grupo_Busqueda.SuspendLayout();
            this.Grupo_Fecha.SuspendLayout();
            this.Grupo_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupo_Busqueda
            // 
            this.Grupo_Busqueda.Controls.Add(this.label1);
            this.Grupo_Busqueda.Controls.Add(this.cmb_buscarpor);
            this.Grupo_Busqueda.Controls.Add(this.Grupo_Fecha);
            this.Grupo_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Busqueda.Location = new System.Drawing.Point(583, 12);
            this.Grupo_Busqueda.Name = "Grupo_Busqueda";
            this.Grupo_Busqueda.Size = new System.Drawing.Size(486, 252);
            this.Grupo_Busqueda.TabIndex = 17;
            this.Grupo_Busqueda.TabStop = false;
            this.Grupo_Busqueda.Text = "Menú para buscar videos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar videos por:";
            // 
            // cmb_buscarpor
            // 
            this.cmb_buscarpor.FormattingEnabled = true;
            this.cmb_buscarpor.Location = new System.Drawing.Point(151, 23);
            this.cmb_buscarpor.Name = "cmb_buscarpor";
            this.cmb_buscarpor.Size = new System.Drawing.Size(186, 28);
            this.cmb_buscarpor.TabIndex = 6;
            this.cmb_buscarpor.SelectedIndexChanged += new System.EventHandler(this.cmb_buscarpor_SelectedIndexChanged);
            // 
            // Grupo_Fecha
            // 
            this.Grupo_Fecha.Controls.Add(this.ubicacion_dateTimePicker5);
            this.Grupo_Fecha.Controls.Add(this.dateTimePicker4);
            this.Grupo_Fecha.Controls.Add(this.dateTimePicker3);
            this.Grupo_Fecha.Controls.Add(this.dateTimePicker2);
            this.Grupo_Fecha.Controls.Add(this.dateTimePicker1);
            this.Grupo_Fecha.Controls.Add(this.Boton_Buscar);
            this.Grupo_Fecha.Location = new System.Drawing.Point(10, 57);
            this.Grupo_Fecha.Name = "Grupo_Fecha";
            this.Grupo_Fecha.Size = new System.Drawing.Size(470, 146);
            this.Grupo_Fecha.TabIndex = 7;
            this.Grupo_Fecha.TabStop = false;
            this.Grupo_Fecha.Text = "Fecha";
            // 
            // ubicacion_dateTimePicker5
            // 
            this.ubicacion_dateTimePicker5.CustomFormat = "dd-MM-yyyy";
            this.ubicacion_dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ubicacion_dateTimePicker5.Location = new System.Drawing.Point(6, 25);
            this.ubicacion_dateTimePicker5.Name = "ubicacion_dateTimePicker5";
            this.ubicacion_dateTimePicker5.Size = new System.Drawing.Size(144, 26);
            this.ubicacion_dateTimePicker5.TabIndex = 8;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(6, 57);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker4.TabIndex = 10;
            this.dateTimePicker4.TabStop = false;
            this.dateTimePicker4.Value = new System.DateTime(2016, 4, 9, 10, 11, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(156, 57);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(156, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Boton_Buscar
            // 
            this.Boton_Buscar.Location = new System.Drawing.Point(141, 103);
            this.Boton_Buscar.Name = "Boton_Buscar";
            this.Boton_Buscar.Size = new System.Drawing.Size(146, 37);
            this.Boton_Buscar.TabIndex = 6;
            this.Boton_Buscar.Text = "Buscar";
            this.Boton_Buscar.UseVisualStyleBackColor = true;
            this.Boton_Buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Grupo_Lista
            // 
            this.Grupo_Lista.Controls.Add(this.lista_videos);
            this.Grupo_Lista.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Grupo_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_Lista.Location = new System.Drawing.Point(583, 270);
            this.Grupo_Lista.Name = "Grupo_Lista";
            this.Grupo_Lista.Size = new System.Drawing.Size(486, 251);
            this.Grupo_Lista.TabIndex = 16;
            this.Grupo_Lista.TabStop = false;
            this.Grupo_Lista.Text = "Lista de videos";
            // 
            // lista_videos
            // 
            this.lista_videos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista_videos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_videos.FormattingEnabled = true;
            this.lista_videos.ItemHeight = 20;
            this.lista_videos.Location = new System.Drawing.Point(6, 19);
            this.lista_videos.Name = "lista_videos";
            this.lista_videos.Size = new System.Drawing.Size(474, 224);
            this.lista_videos.TabIndex = 4;
            this.lista_videos.SelectedIndexChanged += new System.EventHandler(this.lista_videos_SelectedIndexChanged);
            // 
            // txb_buscar
            // 
            this.txb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_buscar.Location = new System.Drawing.Point(12, 12);
            this.txb_buscar.Name = "txb_buscar";
            this.txb_buscar.Size = new System.Drawing.Size(565, 26);
            this.txb_buscar.TabIndex = 13;
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(12, 44);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(565, 477);
            this.Reproductor.TabIndex = 12;
            // 
            // Menu_Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 535);
            this.Controls.Add(this.Grupo_Busqueda);
            this.Controls.Add(this.txb_buscar);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.Grupo_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Videos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Videos";
            this.Load += new System.EventHandler(this.Menu_Videos_Load);
            this.Grupo_Busqueda.ResumeLayout(false);
            this.Grupo_Busqueda.PerformLayout();
            this.Grupo_Fecha.ResumeLayout(false);
            this.Grupo_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_Busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_buscarpor;
        private System.Windows.Forms.GroupBox Grupo_Fecha;
        private System.Windows.Forms.DateTimePicker ubicacion_dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Boton_Buscar;
        private System.Windows.Forms.GroupBox Grupo_Lista;
        public System.Windows.Forms.ListBox lista_videos;
        private System.Windows.Forms.TextBox txb_buscar;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
    }
}