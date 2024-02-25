namespace DvdRental
{
    partial class FrmAlquiler
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAlquilerDVDs = new System.Windows.Forms.Label();
            this.btnAlquilarDvd = new System.Windows.Forms.Button();
            this.cmbPeliculas = new System.Windows.Forms.ComboBox();
            this.dtpFechaAlquiler = new System.Windows.Forms.DateTimePicker();
            this.DgvDvdsRestantes = new System.Windows.Forms.DataGridView();
            this.txtUsuarioRenta = new System.Windows.Forms.TextBox();
            this.lblUsuarioAlquiler = new System.Windows.Forms.Label();
            this.lblFechaAlquiler = new System.Windows.Forms.Label();
            this.lblDVDsRestantes = new System.Windows.Forms.Label();
            this.lblDvdAlquilar = new System.Windows.Forms.Label();
            this.lblIngresoDatos = new System.Windows.Forms.Label();
            this.rbtTiendaUno = new System.Windows.Forms.RadioButton();
            this.rbtTiendaDos = new System.Windows.Forms.RadioButton();
            this.lblTienda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDvdsRestantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlquilerDVDs
            // 
            this.lblAlquilerDVDs.AutoSize = true;
            this.lblAlquilerDVDs.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquilerDVDs.ForeColor = System.Drawing.Color.White;
            this.lblAlquilerDVDs.Location = new System.Drawing.Point(43, 27);
            this.lblAlquilerDVDs.Name = "lblAlquilerDVDs";
            this.lblAlquilerDVDs.Size = new System.Drawing.Size(198, 27);
            this.lblAlquilerDVDs.TabIndex = 0;
            this.lblAlquilerDVDs.Text = "Alquiler de DVDs";
            // 
            // btnAlquilarDvd
            // 
            this.btnAlquilarDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAlquilarDvd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlquilarDvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquilarDvd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquilarDvd.ForeColor = System.Drawing.Color.White;
            this.btnAlquilarDvd.Location = new System.Drawing.Point(64, 431);
            this.btnAlquilarDvd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlquilarDvd.Name = "btnAlquilarDvd";
            this.btnAlquilarDvd.Size = new System.Drawing.Size(416, 32);
            this.btnAlquilarDvd.TabIndex = 1;
            this.btnAlquilarDvd.Text = "Alquilar DVD";
            this.btnAlquilarDvd.UseVisualStyleBackColor = false;
            this.btnAlquilarDvd.Click += new System.EventHandler(this.btnAlquilarDvd_Click);
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Location = new System.Drawing.Point(189, 327);
            this.cmbPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.Size = new System.Drawing.Size(299, 24);
            this.cmbPeliculas.TabIndex = 2;
            // 
            // dtpFechaAlquiler
            // 
            this.dtpFechaAlquiler.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpFechaAlquiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaAlquiler.Location = new System.Drawing.Point(211, 263);
            this.dtpFechaAlquiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaAlquiler.Name = "dtpFechaAlquiler";
            this.dtpFechaAlquiler.Size = new System.Drawing.Size(280, 22);
            this.dtpFechaAlquiler.TabIndex = 3;
            // 
            // DgvDvdsRestantes
            // 
            this.DgvDvdsRestantes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvDvdsRestantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDvdsRestantes.Location = new System.Drawing.Point(529, 185);
            this.DgvDvdsRestantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvDvdsRestantes.Name = "DgvDvdsRestantes";
            this.DgvDvdsRestantes.RowHeadersWidth = 51;
            this.DgvDvdsRestantes.RowTemplate.Height = 24;
            this.DgvDvdsRestantes.Size = new System.Drawing.Size(364, 278);
            this.DgvDvdsRestantes.TabIndex = 4;
            // 
            // txtUsuarioRenta
            // 
            this.txtUsuarioRenta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsuarioRenta.Location = new System.Drawing.Point(127, 194);
            this.txtUsuarioRenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioRenta.Name = "txtUsuarioRenta";
            this.txtUsuarioRenta.Size = new System.Drawing.Size(364, 22);
            this.txtUsuarioRenta.TabIndex = 5;
            this.txtUsuarioRenta.TextChanged += new System.EventHandler(this.txtUsuarioRenta_TextChanged);
            // 
            // lblUsuarioAlquiler
            // 
            this.lblUsuarioAlquiler.AutoSize = true;
            this.lblUsuarioAlquiler.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAlquiler.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioAlquiler.Location = new System.Drawing.Point(29, 193);
            this.lblUsuarioAlquiler.Name = "lblUsuarioAlquiler";
            this.lblUsuarioAlquiler.Size = new System.Drawing.Size(91, 21);
            this.lblUsuarioAlquiler.TabIndex = 6;
            this.lblUsuarioAlquiler.Text = "ID usuario";
            // 
            // lblFechaAlquiler
            // 
            this.lblFechaAlquiler.AutoSize = true;
            this.lblFechaAlquiler.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlquiler.ForeColor = System.Drawing.Color.White;
            this.lblFechaAlquiler.Location = new System.Drawing.Point(29, 263);
            this.lblFechaAlquiler.Name = "lblFechaAlquiler";
            this.lblFechaAlquiler.Size = new System.Drawing.Size(154, 21);
            this.lblFechaAlquiler.TabIndex = 8;
            this.lblFechaAlquiler.Text = "Fecha de alquiler";
            // 
            // lblDVDsRestantes
            // 
            this.lblDVDsRestantes.AutoSize = true;
            this.lblDVDsRestantes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVDsRestantes.ForeColor = System.Drawing.Color.White;
            this.lblDVDsRestantes.Location = new System.Drawing.Point(537, 118);
            this.lblDVDsRestantes.Name = "lblDVDsRestantes";
            this.lblDVDsRestantes.Size = new System.Drawing.Size(130, 19);
            this.lblDVDsRestantes.TabIndex = 9;
            this.lblDVDsRestantes.Text = "DVDs restantes";
            // 
            // lblDvdAlquilar
            // 
            this.lblDvdAlquilar.AutoSize = true;
            this.lblDvdAlquilar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvdAlquilar.ForeColor = System.Drawing.Color.White;
            this.lblDvdAlquilar.Location = new System.Drawing.Point(29, 327);
            this.lblDvdAlquilar.Name = "lblDvdAlquilar";
            this.lblDvdAlquilar.Size = new System.Drawing.Size(131, 21);
            this.lblDvdAlquilar.TabIndex = 10;
            this.lblDvdAlquilar.Text = "DVD a alquilar";
            // 
            // lblIngresoDatos
            // 
            this.lblIngresoDatos.AutoSize = true;
            this.lblIngresoDatos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoDatos.ForeColor = System.Drawing.Color.White;
            this.lblIngresoDatos.Location = new System.Drawing.Point(60, 121);
            this.lblIngresoDatos.Name = "lblIngresoDatos";
            this.lblIngresoDatos.Size = new System.Drawing.Size(147, 19);
            this.lblIngresoDatos.TabIndex = 11;
            this.lblIngresoDatos.Text = "Ingreso de datos";
            // 
            // rbtTiendaUno
            // 
            this.rbtTiendaUno.AutoSize = true;
            this.rbtTiendaUno.ForeColor = System.Drawing.Color.White;
            this.rbtTiendaUno.Location = new System.Drawing.Point(211, 386);
            this.rbtTiendaUno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtTiendaUno.Name = "rbtTiendaUno";
            this.rbtTiendaUno.Size = new System.Drawing.Size(81, 20);
            this.rbtTiendaUno.TabIndex = 12;
            this.rbtTiendaUno.TabStop = true;
            this.rbtTiendaUno.Text = "Tienda 1";
            this.rbtTiendaUno.UseVisualStyleBackColor = true;
            this.rbtTiendaUno.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtTiendaDos
            // 
            this.rbtTiendaDos.AutoSize = true;
            this.rbtTiendaDos.ForeColor = System.Drawing.Color.White;
            this.rbtTiendaDos.Location = new System.Drawing.Point(387, 386);
            this.rbtTiendaDos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtTiendaDos.Name = "rbtTiendaDos";
            this.rbtTiendaDos.Size = new System.Drawing.Size(81, 20);
            this.rbtTiendaDos.TabIndex = 13;
            this.rbtTiendaDos.TabStop = true;
            this.rbtTiendaDos.Text = "Tienda 2";
            this.rbtTiendaDos.UseVisualStyleBackColor = true;
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.ForeColor = System.Drawing.Color.White;
            this.lblTienda.Location = new System.Drawing.Point(29, 386);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(158, 21);
            this.lblTienda.TabIndex = 14;
            this.lblTienda.Text = "Tienda de alquiler";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(368, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(483, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // FrmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(921, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTienda);
            this.Controls.Add(this.rbtTiendaDos);
            this.Controls.Add(this.rbtTiendaUno);
            this.Controls.Add(this.lblIngresoDatos);
            this.Controls.Add(this.lblDvdAlquilar);
            this.Controls.Add(this.lblDVDsRestantes);
            this.Controls.Add(this.lblFechaAlquiler);
            this.Controls.Add(this.lblUsuarioAlquiler);
            this.Controls.Add(this.txtUsuarioRenta);
            this.Controls.Add(this.DgvDvdsRestantes);
            this.Controls.Add(this.dtpFechaAlquiler);
            this.Controls.Add(this.cmbPeliculas);
            this.Controls.Add(this.btnAlquilarDvd);
            this.Controls.Add(this.lblAlquilerDVDs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAlquiler";
            this.Load += new System.EventHandler(this.FrmAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDvdsRestantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlquilerDVDs;
        private System.Windows.Forms.Button btnAlquilarDvd;
        private System.Windows.Forms.ComboBox cmbPeliculas;
        private System.Windows.Forms.DateTimePicker dtpFechaAlquiler;
        private System.Windows.Forms.DataGridView DgvDvdsRestantes;
        private System.Windows.Forms.TextBox txtUsuarioRenta;
        private System.Windows.Forms.Label lblUsuarioAlquiler;
        private System.Windows.Forms.Label lblFechaAlquiler;
        private System.Windows.Forms.Label lblDVDsRestantes;
        private System.Windows.Forms.Label lblDvdAlquilar;
        private System.Windows.Forms.Label lblIngresoDatos;
        private System.Windows.Forms.RadioButton rbtTiendaUno;
        private System.Windows.Forms.RadioButton rbtTiendaDos;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
