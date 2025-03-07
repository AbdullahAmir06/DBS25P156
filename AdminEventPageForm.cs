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
    public partial class AdminEventPageForm : Form
    {
        public AdminEventPageForm()
        {
            InitializeComponent();
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
        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }
        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = false;

            groupBoxAdd.Visible = true;
            groupBoxAdd.Location = new Point(362, 174);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            groupBoxAdd.Visible = false;
            groupBoxDelete.Visible = false;

            groupBoxUpdate.Visible = true;
            groupBoxUpdate.Location = new Point(359, 228);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            groupBoxUpdate.Visible = false;
            groupBoxAdd.Visible = false;

            groupBoxDelete.Location = new Point(359, 228);
            groupBoxDelete.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //this.Close();
            AdminHomePageForm adminHomePageForm = new AdminHomePageForm();
            this.Hide();
            adminHomePageForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.FontFamily, 9);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.FontFamily, 8);
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 9);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 8);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 9);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 8);
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            label12.Font = new Font(label12.Font.FontFamily, 9);
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            label12.Font = new Font(label12.Font.FontFamily, 8);
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            label13.Font = new Font(label13.Font.FontFamily, 9);
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            label13.Font = new Font(label13.Font.FontFamily, 8);
        }

        private void AdminEventPageForm_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(340, 323);
        }
    }
}
