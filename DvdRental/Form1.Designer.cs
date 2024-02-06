namespace DvdRental
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.bntAlquiler = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panlHeader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlFondo.Location = new System.Drawing.Point(229, 32);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(921, 496);
            this.pnlFondo.TabIndex = 0;
            this.pnlFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFondo_Paint);
            this.pnlFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.Color.White;
            this.lblOpciones.Location = new System.Drawing.Point(12, 78);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(198, 23);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Menú de Opciones";
            this.lblOpciones.Click += new System.EventHandler(this.lblOpciones_Click);
            // 
            // bntAlquiler
            // 
            this.bntAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntAlquiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAlquiler.FlatAppearance.BorderSize = 0;
            this.bntAlquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bntAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAlquiler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAlquiler.ForeColor = System.Drawing.Color.White;
            this.bntAlquiler.Location = new System.Drawing.Point(2, 158);
            this.bntAlquiler.Name = "bntAlquiler";
            this.bntAlquiler.Size = new System.Drawing.Size(227, 63);
            this.bntAlquiler.TabIndex = 9;
            this.bntAlquiler.Text = "Alquiler";
            this.bntAlquiler.UseVisualStyleBackColor = false;
            this.bntAlquiler.Click += new System.EventHandler(this.bntAlquiler_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnDevolucion.Location = new System.Drawing.Point(2, 242);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(227, 63);
            this.btnDevolucion.TabIndex = 10;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(2, 330);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(227, 63);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(2, 465);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(227, 63);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panlHeader
            // 
            this.panlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panlHeader.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panlHeader.Location = new System.Drawing.Point(2, 3);
            this.panlHeader.Name = "panlHeader";
            this.panlHeader.Size = new System.Drawing.Size(1148, 30);
            this.panlHeader.TabIndex = 13;
            this.panlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panlHeader_Paint);
            this.panlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 526);
            this.Controls.Add(this.panlHeader);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.bntAlquiler);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button bntAlquiler;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panlHeader;
    }
}

