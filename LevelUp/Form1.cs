using Microsoft.Data.SqlClient;
using System.Data;

namespace LevelUp
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString;
        public Form1()
        {
            InitializeComponent();
            _connectionString = "Server=localhost;Database=LevelUPDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "Select * from Clientes";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvClientes.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "insert into Clientes " +
                        "(nombre,telefono,email)" +
                        " values " +
                        "(@nombre,@telefono,@email)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                        con.Open();
                        int registrosAfectados = cmd.ExecuteNonQuery();

                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se pudo agregar");
                        }

                    }
                }
                MessageBox.Show("Cliente agregado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells["id"].Value.ToString();
                string email = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells["email"].Value.ToString();
                string nombre = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells["nombre"].Value.ToString();
                string telefono = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells["telefono"].Value.ToString();
                txtEmail.Text = email;
                txtNombre.Text = nombre;
                txtTelefono.Text = telefono;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells["id"].Value.ToString());

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "update Clientes " +
                        "set " +
                        "nombre = @nombre " +
                        ", telefono = @telefono " +
                        ", email = @email " +
                        "where id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@id", id);

                        con.Open();
                        int registrosAfectados = cmd.ExecuteNonQuery();

                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se pudo agregar");
                        }

                    }
                }
                MessageBox.Show("Cliente actualizado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
