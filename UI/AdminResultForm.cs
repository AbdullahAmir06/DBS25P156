using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P156.DAL;

namespace DBS25P156.UI
{
    public partial class AdminResultForm : Form
    {
        ResultDAL ResultDAL = new ResultDAL();
        public AdminResultForm()
        {
            InitializeComponent();
        }

        private void AdminResultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DataTable dt = ResultDAL.GetResultData();


            if (dt == null)
            {
                MessageBox.Show("Failed to fetch data. Please check your database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

            //dataGridView1.CellEnter += dataGridView1_CellEnter;

            dataGridView1.Refresh();
            //dataGridView1.DataError += dataGridView1_DataError;
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                string position = row.Cells["position"].Value?.ToString() ?? string.Empty;
                double score = row.Cells["score"].Value != null ? Convert.ToDouble(row.Cells["score"].Value) : 0.0;
                string remarks = row.Cells["remarks"].Value?.ToString() ?? string.Empty;
                int roleId = row.Cells["result_id"].Value != null ? Convert.ToInt32(row.Cells["result_id"].Value) : 0;

                ResultDAL.UpdateData(roleId, position, score, remarks);

            }
            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
