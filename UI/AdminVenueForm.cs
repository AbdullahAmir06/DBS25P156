using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P156.BLL;
using DBS25P156.Models;

namespace DBS25P156.UI
{
    public partial class AdminVenueForm : Form
    {
        public Venue venue = new Venue(); // used only to fetch data from db
        public VenueBLL venueBLL = new VenueBLL();
        public AdminVenueForm()
        {
            InitializeComponent();
        }

        private void AdminVenueForm_Load(object sender, EventArgs e)
        {
            LoadVenuesIntoComboBox();
            panel2.Location = new System.Drawing.Point(342, 246);
        }

        private void LoadVenuesIntoComboBox()
        {
            List<string> Venue = venueBLL.GetVenueNames();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (string venue in Venue)
            {
                comboBox1.Items.Add(venue);
                comboBox2.Items.Add(venue);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.FontFamily, 9);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Enter Venue Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 9);
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 8);
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Focus();
                errorProvider2.SetError(numericUpDown1, "Please Enter Capacity");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 9);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider3.SetError(textBox3, "Please Enter Venue Address");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || numericUpDown1.Value == 0 || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = textBox1.Text;
                int capacity = Convert.ToInt32(numericUpDown1.Value);
                string address = textBox3.Text;

                venueBLL.AddVenue(name, address, capacity);
                textBox1.Clear();
                textBox3.Clear();
                numericUpDown1.Value = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            venue = venueBLL.GetVenueDetail(comboBox1.Text);
            numericUpDown2.Value = venue.Capacity;
            textBox2.Text = venue.Location.ToString();
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            label16.Font = new Font(label16.Font.FontFamily, 9);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            label16.Font = new Font(label16.Font.FontFamily, 8);
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorProvider4.SetError(comboBox1, "Please Select Venue Name");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            label13.Font = new Font(label13.Font.FontFamily, 9);
        }

        private void numericUpDown2_Leave(object sender, EventArgs e)
        {
            label13.Font = new Font(label13.Font.FontFamily, 8);
            if (numericUpDown2.Value == 0)
            {
                numericUpDown2.Focus();
                errorProvider5.SetError(numericUpDown2, "Please Enter Capacity");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label12.Font = new Font(label12.Font.FontFamily, 9);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            label12.Font = new Font(label12.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider6.SetError(textBox2, "Please Enter Venue Address");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || numericUpDown2.Value == 0 || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = comboBox1.Text;
                int capacity = Convert.ToInt32(numericUpDown2.Value);
                string address = textBox2.Text;

                venueBLL.UpdateVenue(name, address, capacity);
                MessageBox.Show("Venue Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVenuesIntoComboBox();
                comboBox1.SelectedIndex = -1;
                numericUpDown2.Value = 0;
                textBox2.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            label19.Font = new Font(label19.Font.FontFamily, 9);
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            label19.Font = new Font(label19.Font.FontFamily, 8);
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                errorProvider7.SetError(comboBox2, "Please Select Venue Name");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = comboBox2.Text;
                venueBLL.DeleteVenue(name);

                MessageBox.Show("Venue Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVenuesIntoComboBox();
                comboBox2.SelectedIndex = -1;
                numericUpDown3.Value = 0;
                textBox4.Clear();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadVenuesIntoComboBox();
            panel2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            groupBox1.Visible = true;
            groupBox1.Location = new Point(367, 159);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadVenuesIntoComboBox();
            panel2.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = false;

            groupBox3.Visible = true;
            groupBox3.Location = new Point(367, 159);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadVenuesIntoComboBox();
            panel2.Visible = false;
            groupBox1.Visible = false;
            groupBox3.Visible = false;

            groupBox4.Visible = true;
            groupBox4.Location = new Point(367, 159);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            venue = venueBLL.GetVenueDetail(comboBox2.Text);
            numericUpDown3.Value = venue.Capacity;
            textBox4.Text = venue.Location.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AdminEventPageForm adminEventPageForm = new AdminEventPageForm();
            this.Hide();
            adminEventPageForm.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminCommitteeForm adminCommitteeForm = new AdminCommitteeForm();
            this.Hide();
            adminCommitteeForm.ShowDialog();
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
