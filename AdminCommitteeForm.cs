using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DBS25P156
{
    public partial class AdminCommitteeForm : Form
    {
        public AdminCommitteeForm()
        {
            InitializeComponent();
        }

        private void AdminCommitteeForm_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = false;
            AdminEventPageForm aepf = new AdminEventPageForm();
            this.Hide();
            aepf.ShowDialog();
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = false;
            AdminCommitteeRegistrationForm acrf = new AdminCommitteeRegistrationForm();
            this.Hide();
            acrf.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            groupBoxDelete.Visible = true;
            groupBoxDelete.Location = new Point(336, 213);
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 9);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 8);
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Please select a committee");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {

            if (errorProvider1 == null)
            {
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Task.Delay(500);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select the Committee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = false;
            AdminEditCommitteeForm adminEditCommitteeForm = new AdminEditCommitteeForm();
            this.Hide();
            adminEditCommitteeForm.ShowDialog();
            this.Show();
        }
    }
}
