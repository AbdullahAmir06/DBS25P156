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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(ServiceTypeTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vendor Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void Vendor_SponserHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
