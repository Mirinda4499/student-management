using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
            LoadCBX();
        }

     
        private void txtStudentID_Enter(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "Enter ID")
            {
                txtStudentID.Text = "";

                txtStudentID.ForeColor = Color.Black;

            }
        }

        private void txtStudentID_Leave(object sender, EventArgs e)
        {

            if (txtStudentID.Text == "")
            {
                txtStudentID.Text = "Enter ID";

                txtStudentID.ForeColor = Color.DarkGray;

            }
        }

        private void txtStudentName_Enter(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "Enter Name")
            {
                txtStudentName.Text = "";

                txtStudentName.ForeColor = Color.Black;

            }
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                txtStudentName.Text = "Enter Name";

                txtStudentName.ForeColor = Color.DarkGray;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

          
            
                
        }

        private void LoadCBX()
        {
            SqlConnection connection = new SqlConnection(ConnectionString.DB_CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT MAKHOA FROM KHOA";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxMajor.Items.Add(dr[0].ToString());
                }
            }
            connection.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            cbxYear.Items.Clear();

            for (int i = 1; i < 5; i++)
            {
                cbxYear.Items.Add(i);
            }
        }
    }

}

