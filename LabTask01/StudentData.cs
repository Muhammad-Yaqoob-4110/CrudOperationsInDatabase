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
using static System.Collections.Specialized.BitVector32;

namespace LabTask01
{
    public partial class StudentData : Form
    {
        public StudentData()
        {
            InitializeComponent();
        }

        private void btnAddaStudent_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@RegistrationNumber, @Name, @Department, @Session, @CGPA, @Address)", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", tbRegN.Text);
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@Department", tbDepartment.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(tbSession.Text));
            cmd.Parameters.AddWithValue("@CGPA", float.Parse(tbCGPA.Text));
            cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form retrieveData = new RetrieveStudentData();
            retrieveData.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new SearchStudent();
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new StartUp();
            form.Show();
        }
    }
}
