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

namespace LabTask01
{
    public partial class CourseData : Form
    {
        public CourseData()
        {
            InitializeComponent();
        }

        private void btnAddaCourse_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Course values (@Course_ID, @Course_Name, @Student_Name, @Teacher_Name, @Semester)", con);
            cmd.Parameters.AddWithValue("@Course_ID", tbCourseID.Text);
            cmd.Parameters.AddWithValue("@Course_Name", tbCourseName.Text);
            cmd.Parameters.AddWithValue("@Student_Name", tbStudentName.Text);
            cmd.Parameters.AddWithValue("@Teacher_Name", tbTeacherName.Text);
            cmd.Parameters.AddWithValue("@Semester", tbSemester.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new StartUp();
            f1.Show();
        }

        private void btnRetrieveCourseData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form retrieveData = new RetrieveCourseData();
            retrieveData.Show();
        }
    }
}
