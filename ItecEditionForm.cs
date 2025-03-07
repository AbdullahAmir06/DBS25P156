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
    public partial class ItecEditionForm : Form
    {
        public ItecEditionForm()
        {
            InitializeComponent();
        }
        private void ItecEditionForm_Load(object sender, EventArgs e)
        {
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
            groupBoxADD.Visible = false;
            groupBoxDelete.Visible = false;

            groupBoxSelect.Visible = true;
            groupBoxSelect.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBoxSelect.Visible = false;
            groupBoxADD.Visible = false;

            groupBoxDelete.Visible = true;
            groupBoxDelete.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxSelect.Visible = false;
            groupBoxDelete.Visible = false;

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
            //group
        }

        private void groupBoxADD_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxDelete_Enter(object sender, EventArgs e)
        {

        }
    }
}
