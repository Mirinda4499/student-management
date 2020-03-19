using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            dateTimePicker_DOB.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DOB.CustomFormat = "dd-MM-yyyy";
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
    }
}
