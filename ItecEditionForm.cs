using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P156
{
    public partial class ItecEditionForm : Form
    {
        ItecEditionFormHandler handler;
        public ItecEditionForm()
        {
            InitializeComponent();
            handler = new ItecEditionFormHandler();
        }
        private void ItecEditionForm_Load(object sender, EventArgs e)
        {
            LoadYearsIntoComboBox();
            groupBoxSelect.Visible = false;
            groupBoxADD.Visible = false;
            groupBoxDelete.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Regular);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Regular);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            groupBoxADD.Visible = false;
            groupBoxDelete.Visible = false;

            groupBoxSelect.Location = new Point(379, 219);
            groupBoxSelect.Visible = true;
            groupBoxSelect.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            groupBoxSelect.Visible = false;
            groupBoxADD.Visible = false;

            groupBoxDelete.Visible = true;
            groupBoxDelete.Location = new Point(379, 219);
            groupBoxDelete.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            groupBoxSelect.Visible = false;
            groupBoxDelete.Visible = false;

            groupBoxADD.Location = new Point(379, 167);
            groupBoxADD.Visible = true;
            groupBoxADD.BringToFront();

        }

        private void groupBoxSelect_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                //errorProvider1.("Please select a year");
                errorProvider1.SetError(comboBox2, "Please select a year");
                return;
            }
            else
            {
                if (handler.CheckEdition(Convert.ToInt32(comboBox2.Text)))
                {
                    handler.DeleteEdition(Convert.ToInt32(comboBox2.SelectedItem));
                    MessageBox.Show("Edition Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Edition Deleted Successfully");
                    LoadYearsIntoComboBox();
                }
                else
                {
                    MessageBox.Show("Edition not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Edition not found");
                }
            }
        }

        private void groupBoxADD_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxDelete_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorProvider2.SetError(comboBox1, "Please select a year");
                //MessageBox.Show("Please select a year");
                return;
            }
            else
            {
                AdminHomePageForm adminHomePageForm = new AdminHomePageForm();
                this.Hide();
                adminHomePageForm.ShowDialog();
                //handler.AddEdition(Convert.ToInt32(comboBox1.SelectedItem));
                //MessageBox.Show("Edition Added Successfully");
                //LoadYearsIntoComboBox();
            }

        }

        private void LoadYearsIntoComboBox()
        {
            List<int> years = handler.GetEdition();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (int year in years)
            {
                comboBox1.Items.Add(year);
                comboBox2.Items.Add(year);
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker1 == null)
            {
                dateTimePicker1.Focus();
                errorProvider3.SetError(dateTimePicker1, "Please select a date");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider4.SetError(textBox1, "Please Enter Edition Name");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider5.SetError(textBox2, "Please Enter Edition Description");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && dateTimePicker1 != null)
            {
                if (handler.CheckEdition(dateTimePicker1.Value.Year))
                {
                    MessageBox.Show("Edition already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Edition already exists");
                    return;
                }
                else
                {
                    handler.AddEdition((dateTimePicker1.Value.Year), textBox1.Text, textBox2.Text);
                    //MessageBox.Show("Edition Added Successfully");
                    MessageBox.Show("Edition Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    LoadYearsIntoComboBox();
                }
            }
            else
            {
                //MessageBox.Show("Please fill all the fields");
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
