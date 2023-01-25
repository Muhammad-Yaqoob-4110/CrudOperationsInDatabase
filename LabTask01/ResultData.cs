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
    public partial class ResultData : Form
    {
        public ResultData()
        {
            InitializeComponent();
        }

        private void btnRetrieveCourseData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form retrieveData = new RetrieveResultData();
            retrieveData.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new StartUp();
            f1.Show();
        }

        private void btnAddaCourse_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Result values (@Student_ID, @Student_Name, @Course_Name, @Marks, @Grade, @Section, @Semester, @Session)", con);
            cmd.Parameters.AddWithValue("@Student_ID", tbStudent_ID.Text);
            cmd.Parameters.AddWithValue("@Student_Name", tbStudentName.Text);
            cmd.Parameters.AddWithValue("@Course_Name", tbCourse_Name.Text);
            cmd.Parameters.AddWithValue("@Marks", tbMarks.Text);
            cmd.Parameters.AddWithValue("@Grade", tbGrade.Text);
            cmd.Parameters.AddWithValue("@Section", tbSection.Text);
            cmd.Parameters.AddWithValue("@Semester", int.Parse(tbSemester.Text));
            cmd.Parameters.AddWithValue("@Session", int.Parse(tbSession.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void tbCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTeacherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCourseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSemester_Click(object sender, EventArgs e)
        {

        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void lblTeacherName_Click(object sender, EventArgs e)
        {

        }

        private void lblCourseID_Click(object sender, EventArgs e)
        {

        }
    }
}
