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
using System.Xml.Linq;

namespace LabTask01
{
    public partial class EditStudentForm : Form
    {
        DataRow row;
        public EditStudentForm(DataRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            tbRegN.Text = row["RegistrationNumber"].ToString();
            tbName.Text = row["Name"].ToString();
            tbDepartment.Text = row["Department"].ToString();
            tbSession.Text = row["Session"].ToString();
            tbCGPA.Text = row["CGPA"].ToString();
            tbAddress.Text = row["Address"].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form retrieveData = new RetrieveStudentData();
            retrieveData.Show();
        }

        private void btneditStudent_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Student set RegistrationNumber = @RegistrationNumber,Name = @Name, Department = @Department, Session = @Session, CGPA = @CGPA, Address = @Address where RegistrationNumber = @RegistrationNumber", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", tbRegN.Text);
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@Department", tbDepartment.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(tbSession.Text));
            cmd.Parameters.AddWithValue("@CGPA", float.Parse(tbCGPA.Text));
            cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            this.Hide();
            Form retrieveData = new RetrieveStudentData();
            retrieveData.Show();
        }
    }
}
