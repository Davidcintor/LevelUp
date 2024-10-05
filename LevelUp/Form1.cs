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
    }
}
