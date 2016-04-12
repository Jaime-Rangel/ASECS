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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_buscarpor = new System.Windows.Forms.ComboBox();
            this.grupo_fecha = new System.Windows.Forms.GroupBox();
            this.ubicacion_dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.cmb_ubicacion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lista_videos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_buscar = new System.Windows.Forms.TextBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox2.SuspendLayout();
            this.grupo_fecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_buscarpor);
            this.groupBox2.Controls.Add(this.grupo_fecha);
            this.groupBox2.Location = new System.Drawing.Point(512, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menú para buscar videos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar videos por:";
            // 
            // cmb_buscarpor
            // 
            this.cmb_buscarpor.FormattingEnabled = true;
            this.cmb_buscarpor.Location = new System.Drawing.Point(122, 28);
            this.cmb_buscarpor.Name = "cmb_buscarpor";
            this.cmb_buscarpor.Size = new System.Drawing.Size(104, 21);
            this.cmb_buscarpor.TabIndex = 6;
            this.cmb_buscarpor.SelectedIndexChanged += new System.EventHandler(this.cmb_buscarpor_SelectedIndexChanged);
            // 
            // grupo_fecha
            // 
            this.grupo_fecha.Controls.Add(this.ubicacion_dateTimePicker5);
            this.grupo_fecha.Controls.Add(this.cmb_ubicacion);
            this.grupo_fecha.Controls.Add(this.dateTimePicker4);
            this.grupo_fecha.Controls.Add(this.dateTimePicker3);
            this.grupo_fecha.Controls.Add(this.dateTimePicker2);
            this.grupo_fecha.Controls.Add(this.dateTimePicker1);
            this.grupo_fecha.Controls.Add(this.btn_buscar);
            this.grupo_fecha.Location = new System.Drawing.Point(72, 57);
            this.grupo_fecha.Name = "grupo_fecha";
            this.grupo_fecha.Size = new System.Drawing.Size(194, 111);
            this.grupo_fecha.TabIndex = 7;
            this.grupo_fecha.TabStop = false;
            this.grupo_fecha.Text = "Fecha";
            // 
            // ubicacion_dateTimePicker5
            // 
            this.ubicacion_dateTimePicker5.CustomFormat = "dd-MM-yyyy";
            this.ubicacion_dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ubicacion_dateTimePicker5.Location = new System.Drawing.Point(26, 19);
            this.ubicacion_dateTimePicker5.Name = "ubicacion_dateTimePicker5";
            this.ubicacion_dateTimePicker5.Size = new System.Drawing.Size(144, 20);
            this.ubicacion_dateTimePicker5.TabIndex = 8;
            // 
            // cmb_ubicacion
            // 
            this.cmb_ubicacion.FormattingEnabled = true;
            this.cmb_ubicacion.Location = new System.Drawing.Point(26, 44);
            this.cmb_ubicacion.Name = "cmb_ubicacion";
            this.cmb_ubicacion.Size = new System.Drawing.Size(144, 21);
            this.cmb_ubicacion.TabIndex = 11;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(26, 62);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker4.TabIndex = 10;
            this.dateTimePicker4.TabStop = false;
            this.dateTimePicker4.Value = new System.DateTime(2016, 4, 9, 10, 11, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(26, 45);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(26, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(66, 88);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lista_videos);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(512, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 211);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de videos";
            // 
            // lista_videos
            // 
            this.lista_videos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista_videos.FormattingEnabled = true;
            this.lista_videos.Location = new System.Drawing.Point(6, 19);
            this.lista_videos.Name = "lista_videos";
            this.lista_videos.Size = new System.Drawing.Size(311, 186);
            this.lista_videos.TabIndex = 4;
            this.lista_videos.SelectedIndexChanged += new System.EventHandler(this.lista_videos_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Borrar video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ver todos los videos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_buscar
            // 
            this.txb_buscar.Location = new System.Drawing.Point(33, 20);
            this.txb_buscar.Name = "txb_buscar";
            this.txb_buscar.Size = new System.Drawing.Size(463, 20);
            this.txb_buscar.TabIndex = 13;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(33, 55);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(463, 429);
            this.player.TabIndex = 12;
            // 
            // Menu_Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_buscar);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Videos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Videos";
            this.Load += new System.EventHandler(this.Menu_Videos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grupo_fecha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_buscarpor;
        private System.Windows.Forms.GroupBox grupo_fecha;
        private System.Windows.Forms.DateTimePicker ubicacion_dateTimePicker5;
        private System.Windows.Forms.ComboBox cmb_ubicacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox lista_videos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_buscar;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}