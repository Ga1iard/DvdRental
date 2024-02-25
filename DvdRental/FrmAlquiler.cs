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

        public String strConn = "server=localhost; port=5432; user id=postgres; password=postgres; database=dvdrental";
        public FrmAlquiler()
        {
            InitializeComponent();
            LlenarCmbPeliculas();
        }

        public void LlenarCmbPeliculas()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(strConn))
            {
                conn.Open();
                string consulta = "SELECT f.title FROM film f JOIN inventory i on f.film_id = i.film_id GROUP BY f.title";
                DataSet ds = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, conn);
                da.Fill(ds, "film");
                cmbPeliculas.DataSource = ds.Tables[0].DefaultView;
                cmbPeliculas.ValueMember = "title";
                conn.Close();
            }
        }

        public int SeleccionarTienda()
        {
            int tienda = 0;
            if (rbtTiendaUno.Checked)
            {
                tienda = 1;
            }
            if (rbtTiendaDos.Checked)
            {
                tienda = 2;
            }
            return tienda;
        }
        private void FrmAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnAlquilarDvd_Click(object sender, EventArgs e)
        {
            //Variables de consultas
            string usuario = txtUsuarioRenta.Text;
            object itemSeleccionado = cmbPeliculas.SelectedItem;
            string titulo = ((DataRowView)itemSeleccionado)["title"].ToString();
            DateTime fechaAlquiler = dtpFechaAlquiler.Value;
            DateTime fechaActual = DateTime.Today;
            string queryUser = $"SELECT customer_id FROM customer WHERE customer_id = {txtUsuarioRenta.Text}";

            //Conexión con la base de datos
            using (NpgsqlConnection conn = new NpgsqlConnection(strConn)) {
                try
                {
                    conn.Open();

                    // Buscar el usuario
                    NpgsqlCommand commandUsuario = new NpgsqlCommand(queryUser, conn);

                    // Verificar si existe el usuario
                    object resultado = commandUsuario.ExecuteScalar();

                    if (resultado == null)
                    {
                        MessageBox.Show("El usuario no existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (resultado != null)
                    {
                        int idUsuario = (int)resultado;
                        Console.WriteLine(fechaAlquiler.CompareTo(fechaActual));
                        if (fechaAlquiler.CompareTo(fechaActual) >= 0)
                        {
                            if (rbtTiendaUno.Checked || rbtTiendaDos.Checked)
                            {
                                object value = null;
                                int tienda = SeleccionarTienda();
                                Console.WriteLine("La fecha ingresada es igual o mayor");
                                string strConsultaDeudaPelicula = $"SELECT r.return_date FROM rental r JOIN inventory i on i.inventory_id = r.inventory_id JOIN film f ON f.film_id = i.film_id JOIN customer c ON c.customer_id = r.customer_id WHERE c.customer_id = {usuario} and f.film_id in (SELECT film_id FROM film WHERE title = '{titulo}')";
                                int comprobador = 0;
                                using (NpgsqlCommand comm = new NpgsqlCommand(strConsultaDeudaPelicula, conn))
                                {
                                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            value = reader.GetValue(0);
                                            comprobador += 1;
                                        }
                                    }
                                }
                                if (value is DateTime || comprobador == 0)
                                {
                                    //toca modificarlo
                                    string strInventory = $"SELECT inventory_id FROM inventory where store_id ={tienda} and film_id= (SELECT film_id FROM film WHERE title = '{titulo}')";
                                    List <int> inventory_id = new List<int>();
                                    using (NpgsqlCommand commInt = new NpgsqlCommand(strInventory, conn))
                                    {
                                        using (NpgsqlDataReader reader = commInt.ExecuteReader())
                                        {
                                            while (reader.Read())
                                            {
                                                inventory_id.Add(reader.GetInt32(0));
                                                Console.WriteLine(reader.GetInt32(0));
                                            }
                                        }
                                       
                                    }
                                    //Para obtener el ultimo id_rental y sumarle uno para la actualización
                                    //SELECT rental_id FROM rental ORDER BY rental_id DESC
                                    /*
                                     * usaremos 
                                     * rental_id (existe default, next similar al serial
                                     * rental_date @returnDate
                                     * inventory_id -> surge de la tabla inventory
                                     *      film_id -> id de la pelicula a rentar
                                     *      store_id -> de que tienda (1 o 2)
                                     *      last_update -> usa now
                                     *      inventory_id -> hace ref a la pelicual dada la tienda y el id film
                                     * customer_id -> id del comprador
                                     * return_date (null)
                                     * Inventory_id FK -> presente en la tabla inventory hay 4581 posibles id
                                     *      SELECT inventory_id FROM inventory where film_id=999 and store_id =1
                                     * staff_id -> seleccionado entre 1 o 2
                                     * last_update (existe un default, now)
                                     * -Forma de insert una nueva renta con un return_date nula
                                     * insert into rental (rental_date, inventory_id, customer_id, staff_id)
                                       values (now(), 4580, 459,2)
                                     * 
                                     * -Forma de insert una nueva renta con una return_date definida
                                     * INSERT INTO rental (rental_date, inventory_id, customer_id, return_date, staff_id)
                                       VALUES (now(), 4581, 459, to_timestamp(extract(year from now()) || '-' 
                                        || extract(month from now()) || '-' || extract(day from now()), 'YYYY-MM-DD'), 2);
                                     */

                                }
                                else
                                {
                                    //No se puede realizar la renta dado que aun no devuelve la pelicula
                                    MessageBox.Show($"El usuario no puede realizar esta acción,\naun tiene que devolver la pelicual {titulo}.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }

                            }
                            else
                            {
                                MessageBox.Show("Debe seleccionar una tienda.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }

                        }
                        else
                        {
                            MessageBox.Show("La fecha no puede ser menor a la actual.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Ejecución finalizada");
                }
            }
        }

        private void txtUsuarioRenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
