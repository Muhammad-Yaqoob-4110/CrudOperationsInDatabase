using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask01
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form courseData = new CourseData();
            courseData.Show();
        }

        private void btnResultData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form resultData = new ResultData();
            resultData.Show();
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form studentData = new StudentData();
            studentData.Show();
        }
    }
}
