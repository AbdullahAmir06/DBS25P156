using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Text.RegularExpressions; // To check for regular expression in email i.e @ and .

namespace DBS25P156
{
    public partial class Sign_Up : Form
    {
        string Pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";    // check if the email is in the correct format i.e it contain in @ and .
        public Sign_Up()
        {
            InitializeComponent();
        }


        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //textBox2.PasswordChar = '\0';
                PasswordTextBox.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide Password           ";
                checkBox1.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\hidden.png");
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                checkBox1.Text = "Show Password          ";
                checkBox1.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\eye.png");

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Account Created Successfully.", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                await Task.Delay(500);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            Email.Font = new Font(Email.Font.FontFamily, 9);
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            Email.Font = new Font(Email.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(EmailTextBox.Text) || Regex.IsMatch(EmailTextBox.Text, Pattern) == false)
            {
                EmailTextBox.Focus();
                errorProvider1.SetError(EmailTextBox, "Please Enter Correct Email");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            Username.Font = new Font(Username.Font.FontFamily, 9);
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            Username.Font = new Font(Username.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                UsernameTextBox.Focus();
                errorProvider2.SetError(UsernameTextBox, "Please Enter Username");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            Password.Font = new Font(Password.Font.FontFamily, 9);
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            Password.Font = new Font(Password.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                PasswordTextBox.Focus();
                errorProvider3.SetError(PasswordTextBox, "Please Enter Password");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



// (Regex.IsMatch(textBox3.Text,Pattern)==false))