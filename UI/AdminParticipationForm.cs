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
    public partial class AdminParticipationForm : Form
    {
        PaymentDAL paymentDAL = new PaymentDAL();
        public AdminParticipationForm()
        {
            InitializeComponent();
        }

        private void AdminParticipationForm_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = false;
            DataTable dt = paymentDAL.GetAllPendingRegistrations();


            if (dt == null)
            {
                MessageBox.Show("Failed to fetch data. Please check your database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView2.DataSource = dt;
            }


            dataGridView2.Refresh();
            dataGridView2.DataError += dataGridView1_DataError;

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Invalid value in column {dataGridView2.Columns[e.ColumnIndex].Name}");
            e.ThrowException = false;  // Prevents default error message
        }


        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView2.IsCurrentCellDirty)
            {
                dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //print the row number dynamically on the screen
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(dataGridView2.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowIndex = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(rowIndex, dataGridView2.Font, brush, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
