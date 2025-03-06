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
    public partial class UserCommitteeForm : Form
    {
        public UserCommitteeForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void UserCommitteeForm_Load(object sender, EventArgs e)
        {


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

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Regular);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            //UserHomePageForm uhp = new UserHomePageForm();
            //uhp.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserEventForm uef = new UserEventForm();
            this.Hide();
            uef.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPaymentForm upf = new UserPaymentForm();
            upf.ShowDialog();
        }
    }
}
