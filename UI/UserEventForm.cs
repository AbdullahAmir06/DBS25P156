using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P156.UI
{
    public partial class UserEventForm : Form
    {
        public UserEventForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            //UserHomePageForm userHomePageForm = new UserHomePageForm();
            //userHomePageForm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.UserLoginRoleID == 1)
            {
                EventRegistrationForm eventRegistrationForm = new EventRegistrationForm();
                this.Hide();
                eventRegistrationForm.ShowDialog();
                //this.Show();
            }
            else if (UserSession.UserLoginRoleID == 2)
            {
                FacultyEventRegistrationForm facultyEventRegistrationForm = new FacultyEventRegistrationForm();
                this.Hide();
                facultyEventRegistrationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not authorized to register for an event");
            }
        }

        private void UserEventForm_Load(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventRegistrationForm eventRegistrationForm = new EventRegistrationForm();
            this.Hide();
            eventRegistrationForm.ShowDialog();

            //this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserCommitteeForm userCommitteeForm = new UserCommitteeForm();
            this.Hide();
            userCommitteeForm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPaymentForm userPaymentForm = new UserPaymentForm();
            userPaymentForm.ShowDialog();
        }
    }
}

