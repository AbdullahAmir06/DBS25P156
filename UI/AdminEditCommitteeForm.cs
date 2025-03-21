using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DBS25P156.BLL;
using DBS25P156.DAL;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P156.UI
{
    public partial class AdminEditCommitteeForm : Form
    {
        CommitteeDAL committeeDAL = new CommitteeDAL();
        public AdminEditCommitteeForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminEditCommitteeForm_Load(object sender, EventArgs e)
        {
            checkBoxNotClicked();
            dataGridView1.AutoGenerateColumns = false;


            List<string> Committees = committeeDAL.GetCommitteeNames();
            comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            foreach (string committees in Committees)
            {
                comboBox1.Items.Add(committees);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBoxCLicked();

                dataGridView1.AutoGenerateColumns = false;

                int committeeId = committeeDAL.GetCommitteeId(comboBox1.Text);
                //MessageBox.Show("value: "+committeeId);
                DataTable dt = committeeDAL.GetCommitteeData(committeeId);



                if (dt == null)
                {
                    MessageBox.Show("Failed to fetch data. Please check your database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Deadline"].DefaultCellStyle.Format = "yyyy-MM-dd";

                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["Select"].Value = true; // or false to uncheck
                }


                dataGridView1.Refresh();


            }

            else
            {
                checkBoxNotClicked();
            }

        }

        private void checkBoxCLicked()
        {
            button1.Visible = true;
            GoBack.Visible = true;
            dataGridView1.Visible = true;
            this.Size = new Size(1004, 664);
            groupBox1.Size = new Size(894, 529);
            button1.Location = new Point(348, 457);
            GoBack.Location = new Point(430, 498);
            dataGridView1.Location = new Point(17, 167);
        }

        private void checkBoxNotClicked()
        {
            button1.Visible = false;
            GoBack.Visible = false;
            dataGridView1.Visible = false;
            this.Size = new Size(1004, 458);
            groupBox1.Size = new Size(892, 275);
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // it check for the index to be at 0 for select statement to be checked and change their behaviour accordingly
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                bool Check = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                dataGridView1.Rows[e.RowIndex].Cells["Duty"].ReadOnly = !Check;
                dataGridView1.Rows[e.RowIndex].Cells["Role"].ReadOnly = !Check;
                dataGridView1.Rows[e.RowIndex].Cells["Deadline"].ReadOnly = !Check;

            }
        }

        //this is used to immediately take effect when there is some uncommited thing i.e when combo box is clicked it immediately rollback effect
        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
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
            bool valid = true;
            //int counter = 0;

            // Loop through each row in the DataGridView
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    // Check if the checkbox in the first column is checked
            //    if (row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value == true)
            //    {
            //        counter++;
            //    }
            //}

            //// If no row is selected, show an error
            //if (counter < 5)
            //{
            //    errorProvider2.SetError(dataGridView1, "Please select at least 5 persons.");
            //    valid = false;
            //    dataGridView1.Focus(); // Set focus on DataGridView
            //}
            //else
            //{
            //    errorProvider2.Clear(); // Clear the error if selection is 
            //}

            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Please Enter Committee Name");
                valid = false;
                comboBox1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }

            if (valid)
            {
                MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int committeeId = committeeDAL.GetCommitteeId(comboBox1.Text);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //a(int committeeId, string name, string taskDescription, DateTime date)
                    string assignedTo = row.Cells["Names"].Value.ToString();
                    string taskDescription = row.Cells["Duty"].Value.ToString();
                    DateTime deadline = Convert.ToDateTime(row.Cells["Deadline"].Value);

                    committeeDAL.UpdateCommmitteeData(committeeId, assignedTo, taskDescription, deadline);
                }

                //await Task.Delay(500);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please correct the errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // appearance effect on the label when the text box is clicked
        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 9);
        }


        // force user to enter name

        private void dataGridView1_Leave(object sender, EventArgs e)
        {

        }
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 9);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 8);
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Please Select Committee Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            int committeeId = committeeDAL.GetCommitteeId(comboBox1.Text);
            //MessageBox.Show("value: "+committeeId);
            DataTable dt = committeeDAL.GetCommitteeData(committeeId);


            if (dt == null)
            {
                MessageBox.Show("Failed to fetch data. Please check your database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Deadline"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Select"].Value = true; // or false to uncheck
            }


            dataGridView1.Refresh();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Deadline")
            {
                string newDate = e.FormattedValue.ToString();

                // Allow empty values (user is still typing)
                if (string.IsNullOrWhiteSpace(newDate))
                {
                    return;
                }

                // Ensure the input is exactly 10 characters (YYYY-MM-DD)
                if (newDate.Length < 10)
                {
                    return; // Don't validate until the user finishes typing
                }

                // Validate the date format properly
                if (!DateTime.TryParseExact(newDate, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    e.Cancel = true; // Prevents invalid entry
                    MessageBox.Show("Invalid date format. Use YYYY-MM-DD.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // Prevents the default error popup
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Deadline")
            {
                string newDate = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(newDate) && newDate.Length == 10)
                {
                    if (!DateTime.TryParseExact(newDate, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out _))
                    {
                        MessageBox.Show("Invalid date format. Use YYYY-MM-DD.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


    }
}