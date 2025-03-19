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
    public partial class UserHomePageForm : Form
    {

        public UserHomePageForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserHomePageForm_Load);
        }
        private void UserHomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label6_Click(object sender, EventArgs e)
        {

            UserEventForm userEventForm = new UserEventForm();
            this.Hide();
            userEventForm.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserCommitteeForm userCommitteeForm = new UserCommitteeForm();
            userCommitteeForm.ShowDialog();
            this.Show();
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            label2_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPaymentForm userPaymentForm = new UserPaymentForm();
            userPaymentForm.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font, FontStyle.Regular);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font, FontStyle.Regular);
        }
        private void panel4_MouseHover(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label8_Click(object sender, EventArgs e)
        {

            UserEventForm userEventForm = new UserEventForm();
            this.Hide();
            userEventForm.ShowDialog();
            this.Show();
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            //label8_Click(sender, e);
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            label8_Click(sender, e);
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font, FontStyle.Regular);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font, FontStyle.Regular);
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font, FontStyle.Regular);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font, FontStyle.Regular);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label2_Click(sender, e);
        }


        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font, FontStyle.Bold | FontStyle.Underline);
            pictureBox6.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\profs\result-ezgif.com-gif-maker1.gif");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label10_MouseLeave(sender, e);
            pictureBox6.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\profs\1-ezgif.com-gif-maker.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label10_Click(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label9_Click(sender, e);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font, FontStyle.Bold | FontStyle.Underline);
            pictureBox5.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\profs\population-ezgif.com-gif-maker1.gif");
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font, FontStyle.Regular);
            pictureBox5.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\profs\2-ezgif.com-gif-maker.png");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label8_Click(sender, e);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\profs\calendar-ezgif.com-gif-maker1.gif");
            label8.Font = new Font(label8.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\profs\3-ezgif.com-gif-maker.png");
            label8.Font = new Font(label8.Font, FontStyle.Regular);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
