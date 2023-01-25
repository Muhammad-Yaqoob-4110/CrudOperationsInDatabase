using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabTask01
{
    public partial class RetrieveStudentData : Form
    {
        public RetrieveStudentData()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            DataRow row = currentDataRowView.Row;

            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Delete from Student where RegistrationNumber = @RegistrationNumber", con);
                cmd.Parameters.AddWithValue("@RegistrationNumber", row["RegistrationNumber"]);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                dataBind();
            }
            else if (dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
            {
                this.Hide();
                EditStudentForm myform = new EditStudentForm(row);
                myform.ShowDialog();
                dataBind();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form myform = new StudentData();
            myform.Show();
        }
    }
}
