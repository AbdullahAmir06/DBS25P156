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
            dataGridView1.AutoGenerateColumns = false;
            DataTable dt = paymentDAL.GetAllPendingRegistrations();
            //dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;


            if (dt == null)
            {
                MessageBox.Show("Failed to fetch data. Please check your database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    Console.WriteLine(col.Name);
                }

            }


            dataGridView1.Refresh();
            //dataGridView2.DataError += dataGridView1_DataError;

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show($"Invalid value in column {dataGridView2.Columns[e.ColumnIndex].Name}");
            e.ThrowException = false;  // Prevents default error message
        }


        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //print the row number dynamically on the screen
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowIndex = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(rowIndex, dataGridView1.Font, brush, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Initialize the variable
                int registrationNumber = 0;

                // Get the value of the first column (index 0)
                object cellValue = row.Cells[0].Value;

                // Convert to int if not null or empty
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int result))
                {
                    registrationNumber = result;
                }
                // Initialize the variable to store the value
                int statusValue = 0;

                // Get the value of the third column (index 2)
                object cellValue2 = row.Cells[3].Value;

                // Check if the value is not null and convert it to a string
                string statusText = cellValue2?.ToString() ?? string.Empty;

                // Compare and assign the value
                statusValue = (statusText == "Pending") ? 13 : 15;

                paymentDAL.UpdatePaymentStatus(registrationNumber, statusValue);
                MessageBox.Show("Updated Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
