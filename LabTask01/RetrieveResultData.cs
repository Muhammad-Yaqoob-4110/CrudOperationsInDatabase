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
    public partial class RetrieveResultData : Form
    {
        public RetrieveResultData()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new ResultData();
            f1.Show();
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Result", con);
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
                SqlCommand cmd = new SqlCommand("Delete from Result where Student_ID = @Student_ID", con);
                cmd.Parameters.AddWithValue("@Student_ID", row["Student_ID"]);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                dataBind();
            }
            else if (dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
            {
                this.Hide();
                EditResultForm myform = new EditResultForm(row);
                myform.ShowDialog();
                dataBind();
            }
        }

        private void RetrieveResultData_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Result", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
