namespace ASECS
{
    partial class Menu_Administracion_Camara
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
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Aceptar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Tabla_Lista_Camaras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Lista_Camaras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona tu camara para administrarla";
            // 
            // Boton_Aceptar
            // 
            this.Boton_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Aceptar.Location = new System.Drawing.Point(538, 330);
            this.Boton_Aceptar.Name = "Boton_Aceptar";
            this.Boton_Aceptar.Size = new System.Drawing.Size(180, 43);
            this.Boton_Aceptar.TabIndex = 2;
            this.Boton_Aceptar.Text = "Aceptar";
            this.Boton_Aceptar.UseVisualStyleBackColor = true;
            this.Boton_Aceptar.Click += new System.EventHandler(this.Boton_Aceptar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(352, 330);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(180, 43);
            this.Boton_Cancelar.TabIndex = 3;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Tabla_Lista_Camaras
            // 
            this.Tabla_Lista_Camaras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Lista_Camaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Lista_Camaras.Location = new System.Drawing.Point(12, 47);
            this.Tabla_Lista_Camaras.Name = "Tabla_Lista_Camaras";
            this.Tabla_Lista_Camaras.Size = new System.Drawing.Size(706, 277);
            this.Tabla_Lista_Camaras.TabIndex = 4;
            // 
            // Menu_Administracion_Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 388);
            this.Controls.Add(this.Tabla_Lista_Camaras);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Aceptar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Administracion_Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Camaras";
            this.Load += new System.EventHandler(this.Menu_Administracion_Camara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Lista_Camaras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Aceptar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.DataGridView Tabla_Lista_Camaras;
    }
}