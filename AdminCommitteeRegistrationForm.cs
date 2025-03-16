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
    }
}
