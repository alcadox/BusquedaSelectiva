using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BusquedaSelectiva
{
    public partial class Form1 : Form
    {
        //Inicializamos una DataTable para guardar la tabla de la base de datos para no tener que conectarnos cada vez a la base de datos.
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            ConectarBaseDeDatos();
        }


        private void ConectarBaseDeDatos()
        {
            //He usado una base de datos personalizada
            string conectionString = ConfigurationManager.ConnectionStrings["conexionSQLSERVER"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conectionString);

            string sql = "SELECT * FROM clientes";

            try
            {
                //abrir conexion
                conexion.Open();

                //instanciamos el comando
                SqlCommand comando = new SqlCommand(sql, conexion);

                //ejecutamos el comando
                SqlDataReader reader = comando.ExecuteReader();

                //Cargamos los datos en el DataTable
                dt.Load(reader);

                //importamos los datos al DataGridView
                dgvTabla.DataSource = dt;

                comando.Dispose();
                conexion.Close();

            } catch (SqlException e)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + e.Message);
            }
        }

        private void txtBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvTabla.Rows)
            {
                if (fila.IsNewRow) continue;

                int strFila = fila.Index;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value == null || celda.Value.ToString() == "") continue;

                    string valor = celda.Value.ToString();

                    if (valor.ToLower() == txtBoxBuscador.Text.ToLower())
                    {
                        celda.Style.BackColor = Color.Red;
                    }
                    else
                    {
                        celda.Style.BackColor = Color.White;
                    }
                }
                
            }
        }
    }
}
