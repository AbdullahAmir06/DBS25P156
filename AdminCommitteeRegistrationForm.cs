using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P156
{
    public partial class AdminCommitteeRegistrationForm : Form
    {
        public AdminCommitteeRegistrationForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminCommitteeRegistrationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(false, "Anas", "Student", "Volunteer", "Photography", "2025-03-20");
            dataGridView1.Rows.Add(false, "Tasawar", "Student", "Volunteer");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridView1.Visible = true;
                groupBox1.Size = new Size(892, 275);
                this.Size = new Size(1004, 445);
            }
            else
            {
                dataGridView1.Visible = false;
            }

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
