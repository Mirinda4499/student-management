using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        public DataTable getStudents()
        {
            DataTable studentTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.DB_CONNECTION_STRING))
            {
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM SVIEN", connection);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);

                studentTable = data.Tables[0];

                connection.Close();
            }
            return studentTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getStudents();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
