using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace BusquedaSelectiva
{
    public partial class Form1 : Form
    {
        //Inicializamos una DataTable para guardar la tabla de la base de datos para no tener que conectarnos cada vez a la base de datos.
        DataTable dt = new DataTable();

        //ArrayList para guardar las celdas que coinciden con la búsqueda
        ArrayList celdasCoincidentes = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            ConectarBaseDeDatos();
        }


        private void ConectarBaseDeDatos()
        {
            //He usado la base de datos Bankline de la Moodle
            string conectionString = ConfigurationManager.ConnectionStrings["conexionSQLSERVER"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conectionString);

            string sql = "SELECT * FROM Cliente";

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
            celdasCoincidentes.Clear();
            if (txtBoxBuscador.Text == "")
            {
                // Si el TextBox está vacío, restauramos el color de fondo original de todas las celdas
                foreach (DataGridViewRow fila in dgvTabla.Rows)
                {
                    if (fila.IsNewRow) continue;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        celda.Style.BackColor = Color.White;
                        celda.Style.Font = new Font(dgvTabla.Font, FontStyle.Regular);
                    }
                }
                return;
            }
            // Recorremos todas las filas y columnas del DataGridView buscando el valor introducido en el TextBox
            foreach (DataGridViewRow fila in dgvTabla.Rows)
            {
                // Nos saltamos la fila nueva que permite añadir datos
                if (fila.IsNewRow) continue;

                // Guardamos el índice de la fila actual
                int strFila = fila.Index;

                // Recorremos todas las celdas de la fila actual
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    // Nos saltamos las celdas vacías
                    if (celda.Value == null || celda.Value.ToString() == "") continue;

                    // Guardamos el valor de la celda actual
                    string valor = celda.Value.ToString();


                    // Comprobamos si el valor de la celda contiene el texto del TextBox (ignorando mayúsculas/minúsculas)
                    if (valor.ToLower().Contains(txtBoxBuscador.Text.ToLower()))
                    {
                        // Si coinciden, cambiamos el color de fondo de la celda a verde claro
                        celda.Style.BackColor = Color.FromArgb(201, 255, 201);
                        celda.Style.Font = new Font(dgvTabla.Font, FontStyle.Bold);
                        celdasCoincidentes.Add(celda);
                    }
                    else
                    {
                        // Si no coinciden, restauramos el color de fondo original de la celda
                        celda.Style.BackColor = Color.White;
                        celda.Style.Font = new Font(dgvTabla.Font, FontStyle.Regular);
                    }
                }
            }

            // Seleccionamos la primera coincidencia si existe
            if (celdasCoincidentes.Count > 0)
            {
                DataGridViewCell primeraCelda = (DataGridViewCell)celdasCoincidentes[0];
                dgvTabla.CurrentCell = primeraCelda;
            }
        }

        // Botón para ir a la coincidencia anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (celdasCoincidentes.Count == 0) return;
            dgvTabla.CurrentCell = (DataGridViewCell)celdasCoincidentes[Math.Max(0, celdasCoincidentes.IndexOf(dgvTabla.CurrentCell) - 1)];
        }

        // Botón para ir a la siguiente coincidencia
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (celdasCoincidentes.Count == 0) return;
            dgvTabla.CurrentCell = (DataGridViewCell)celdasCoincidentes[Math.Min(celdasCoincidentes.Count - 1, celdasCoincidentes.IndexOf(dgvTabla.CurrentCell) + 1)];
        }

        // Botón para ir a la primera coincidencia
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (celdasCoincidentes.Count == 0) return;
            dgvTabla.CurrentCell = (DataGridViewCell)celdasCoincidentes[0];
        }

        // Botón para ir a la última coincidencia
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (celdasCoincidentes.Count == 0) return;
            dgvTabla.CurrentCell = (DataGridViewCell)celdasCoincidentes[celdasCoincidentes.Count - 1];

        }

        // Botón para copiar el valor de la celda seleccionada al portapapeles
        private void btnCopiarPortapapeles_Click(object sender, EventArgs e)
        {
            // Comprobamos que hay una celda seleccionada y que no está vacía
            if (dgvTabla.CurrentCell == null || dgvTabla.CurrentCell.Value == null || dgvTabla.CurrentCell.Value.ToString() == "" ) return;

            MessageBox.Show("Valor copiado al portapapeles: " + dgvTabla.CurrentCell.Value.ToString());
            Clipboard.SetText(dgvTabla.CurrentCell.Value.ToString());
        }
    }
}
