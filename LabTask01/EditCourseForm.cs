using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabTask01
{
    public partial class EditCourseForm : Form
    {
        DataRow row;
        public EditCourseForm(DataRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new RetrieveCourseData();
            f1.Show();
        }

        private void btneditStudent_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Course set  Course_ID = @Course_ID,Course_Name = @Course_Name, Student_Name = @Student_Name, Teacher_Name = @Teacher_Name, Semester = @Semester where Course_ID = @Course_ID", con);
            cmd.Parameters.AddWithValue("@Course_ID", tbCourse_ID.Text);
            cmd.Parameters.AddWithValue("@Course_Name", tbCourse_Name.Text);
            cmd.Parameters.AddWithValue("@Student_Name", tbStudent_Name.Text);
            cmd.Parameters.AddWithValue("@Teacher_Name", tbTeacher_Name.Text);
            cmd.Parameters.AddWithValue("@Semester", tbSemester.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            this.Hide();
            Form retrieveData = new RetrieveCourseData();
            retrieveData.Show();
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            tbCourse_ID.Text = row["Course_ID"].ToString();
            tbCourse_Name.Text = row["Course_Name"].ToString();
            tbStudent_Name.Text = row["Student_Name"].ToString();
            tbTeacher_Name.Text = row["Teacher_Name"].ToString();
            tbSemester.Text = row["Semester"].ToString();
        }
    }
}
