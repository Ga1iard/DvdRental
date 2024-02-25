using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DvdRental
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDevolución_Click(object sender, EventArgs e)
        {

        }

        private void lblOpciones_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panlHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void abrirFormHija(object formhija)
        {
            if (this.pnlFondo.Controls.Count > 0)
                this.pnlFondo.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlFondo.Controls.Add(fh);
            this.pnlFondo.Tag = fh;
            fh.Show();
        }

        private void bntAlquiler_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmAlquiler());
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmDevolucion());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmReportes());
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            /*hola*/
            abrirFormHija(new FrmCrearUsuario());
        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
