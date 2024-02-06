using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DvdRental
{
    public partial class FrmAlquiler : Form
    {
        public FrmAlquiler()
        {
            InitializeComponent();
        }

        private void FrmAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnAlquilarDvd_Click(object sender, EventArgs e)
        {
            /*
            string usuario = txtUsuarioRenta.Text;
            string dvdSeleccionado = cmbPeliculas.Text;
            DateTime fechaAlquiler = dtpFechaAlquiler.Value;

            NpgsqlConnection conn = new NpgsqlConnection();
            String strConexion = "server=localhost; port=5432; user id=postgres; password=postgres; database=postgres";

            try
            {
                conn.Open();

                // Buscar el usuario
                string queryUsuario = "SELECT customer_id FROM customer WHERE customer_id = @id";
                NpgsqlCommand commandUsuario = new NpgsqlCommand(queryUsuario, conn);
                commandUsuario.Parameters.AddWithValue("@id", usuario);
                int idUsuario = (int)commandUsuario.ExecuteScalar();

                // Buscar el DVD
                string queryDvd = "SELECT film_id FROM film WHERE title = @titulo AND disponible = TRUE"; 
                NpgsqlCommand commandDvd = new NpgsqlCommand(queryDvd, conn);
                commandDvd.Parameters.AddWithValue("@titulo", dvdSeleccionado);
                int idDvdEncontrado = (int)commandDvd.ExecuteScalar();

                if (idUsuario > 0 && idDvdEncontrado > 0)
                {
                    // Registrar el alquiler
                    string queryAlquiler = "INSERT INTO alquileres (usuario_id, dvd_id, fecha_alquiler) VALUES (@usuario_id, @dvd_id, @fecha_alquiler)";
                    NpgsqlCommand commandAlquiler = new NpgsqlCommand(queryAlquiler, conn);
                    commandAlquiler.Parameters.AddWithValue("@usuario_id", idUsuario);
                    commandAlquiler.Parameters.AddWithValue("@dvd_id", idDvdEncontrado);
                    commandAlquiler.Parameters.AddWithValue("@fecha_alquiler", fechaAlquiler);
                    commandAlquiler.ExecuteNonQuery();

                    // Actualizar el estado del DVD
                    string queryUpdateDvd = "UPDATE dvds SET disponible = FALSE WHERE id = @id";
                    NpgsqlCommand commandUpdateDvd = new NpgsqlCommand(queryUpdateDvd, conn);
                    commandUpdateDvd.Parameters.AddWithValue("@id", idDvdEncontrado);
                    commandUpdateDvd.ExecuteNonQuery();

                    MessageBox.Show("Alquiler registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Usuario o DVD no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            */
        }
    }
}
