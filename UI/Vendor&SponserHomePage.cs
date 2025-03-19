using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBS25P156.UI
{
    public partial class Vendor_SponserHomePage : Form
    {
        public Vendor_SponserHomePage()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            Names.Font = new Font(Names.Font.FontFamily, 9);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            Names.Font = new Font(Names.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please Enter Your Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void ContactTextBox_Enter(object sender, EventArgs e)
        {
            Contact.Font = new Font(Contact.Font.FontFamily, 9);
        }

        private void ContactTextBox_Leave(object sender, EventArgs e)
        {
            Contact.Font = new Font(Contact.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(ContactTextBox.Text))
            {
                ContactTextBox.Focus();
                errorProvider3.SetError(ContactTextBox, "Please Enter Your Contact");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            this.Hide();
            forgetPasswordForm.ShowDialog();
            this.Show();
        }

        private void ServiceTypeTextBox_Enter(object sender, EventArgs e)
        {
            ServiceType.Font = new Font(ServiceType.Font.FontFamily, 9);
        }

        private void ServiceTypeTextBox_Leave(object sender, EventArgs e)
        {
            ServiceType.Font = new Font(ServiceType.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(ServiceTypeTextBox.Text))
            {
                ServiceTypeTextBox.Focus();
                errorProvider2.SetError(ServiceTypeTextBox, "Please Enter Your Service Type");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(ServiceTypeTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vendor Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Task.Delay(500);
                this.Close();
            }
        }

        private void Vendor_SponserHomePage_Load(object sender, EventArgs e)
        {
            if (UserSession.UserLoginRoleID == 3)
            {
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                this.Size = new Size(818, 497);
                groupBox1.Location = new Point(203, 34);
            }
            else if (UserSession.UserLoginRoleID == 4)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                this.Size = new Size(818, 603);
                groupBox2.Location = new Point(189, 12);

            }
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily, 9);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider4.SetError(textBox1, "Please Enter Your Name");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.FontFamily, 9);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider5.SetError(textBox2, "Please Enter Your Contact");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sponser Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await Task.Delay(500);
                this.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
