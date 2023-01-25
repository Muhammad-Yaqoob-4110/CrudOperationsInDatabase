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
    public partial class EditResultForm : Form
    {
        DataRow row;
        public EditResultForm(DataRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void EditResultForm_Load(object sender, EventArgs e)
        {
            tbStudent_ID.Text = row["Student_ID"].ToString();
            tbStudentName.Text = row["Student_Name"].ToString();
            tbCourse_Name.Text = row["Course_Name"].ToString();
            tbMarks.Text = row["Marks"].ToString();
            tbGrade.Text = row["Grade"].ToString();
            tbSection.Text = row["Section"].ToString();
            tbSemester.Text = row["Semester"].ToString();
            tbSession.Text = row["Session"].ToString();
        }

        private void btnEditResult_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Result set Student_ID = @Student_ID,Student_Name = @Student_Name, Course_Name = @Course_Name,Marks = @Marks, Grade = @Grade, Section = @Section,Semester = @Semester,Session = @Session where Student_ID = @Student_ID", con);
            cmd.Parameters.AddWithValue("@Student_ID", tbStudent_ID.Text);
            cmd.Parameters.AddWithValue("@Student_Name", tbStudentName.Text);
            cmd.Parameters.AddWithValue("@Course_Name", tbCourse_Name.Text);
            cmd.Parameters.AddWithValue("@Marks", tbMarks.Text);
            cmd.Parameters.AddWithValue("@Grade", tbGrade.Text);
            cmd.Parameters.AddWithValue("@Section", tbSection.Text);
            cmd.Parameters.AddWithValue("@Semester", int.Parse(tbSemester.Text));
            cmd.Parameters.AddWithValue("@Session", int.Parse(tbSession.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            this.Hide();
            Form retrieveData = new RetrieveResultData();
            retrieveData.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form retrieveData = new RetrieveResultData();
            retrieveData.Show();
        }
    }
}
