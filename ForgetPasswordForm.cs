using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P156
{
    public partial class ForgetPasswordForm : Form
    {
        ForgetPasswordHandler forgetPasswordHandler;
        public ForgetPasswordForm()
        {
            InitializeComponent();
            forgetPasswordHandler = new ForgetPasswordHandler();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // when the close button is clicked
        {
            this.Close(); // close the form
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // when the checkbox is checked
        {
            if (checkBox1.Checked)
            {
                //textBox2.PasswordChar = '\0'; 
                textBox2.UseSystemPasswordChar = false; // show the password
                checkBox1.Text = "Hide Password           "; // show the text
                checkBox1.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\hidden.png"); // show the hidden image  
            }
            else
            {
                textBox2.UseSystemPasswordChar = true; // hide the password
                checkBox1.Text = "Show Password          "; // show the text
                checkBox1.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\eye.png"); // show the eye image

            }
        }

        private void textBox3_Enter(object sender, EventArgs e) // when the textbox is entered
        {
            label4.Font = new Font(label4.Font.FontFamily, 9); // change the font size
        }

        private void textBox3_Leave(object sender, EventArgs e) // when the textbox is left
        {

            label4.Font = new Font(label4.Font.FontFamily, 8); // change the font size
            if (string.IsNullOrEmpty(textBox3.Text)) // check if the textbox is empty
            {
                textBox3.Focus(); // focus on the textbox   
                errorProvider1.SetError(textBox3, "Please Enter Username/Email"); // show error message
            }
            else
            {
                errorProvider1.Clear(); // clear the error
            }
        }

        private void textBox2_Enter(object sender, EventArgs e) // when the textbox is entered
        {
            label3.Font = new Font(label3.Font.FontFamily, 9); // change the font size
        }

        private void textBox2_Leave(object sender, EventArgs e) // when the textbox is left
        {
            label3.Font = new Font(label3.Font.FontFamily, 8); // change the font size
            if (string.IsNullOrEmpty(textBox2.Text)) // check if the textbox is empty
            {
                textBox2.Focus(); // focus on the textbox
                errorProvider2.SetError(textBox2, "Please Enter Password"); // show error message
            }
            else
            {
                errorProvider2.Clear(); // clear the error
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void BackToLogin_Click(object sender, EventArgs e) // when the back to login button is clicked
        {
            this.Close(); // close the form
        }

        private async void button2_Click(object sender, EventArgs e) // when the reset password button is clicked
        {

            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox2.Text)) // check if any field is empty
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // show validation error message
            }
            else
            {
                string username = textBox3.Text; // get the username from the textbox
                string password = textBox2.Text; // get the password from the textbox
                if (forgetPasswordHandler.UserCheck(username)) // check if user exists or not
                {
                    UserSession.UserLoginUserName_Email = username; // store the userid or email in the session

                    forgetPasswordHandler.UpdatePassword(password); // update the password
                    button2.Enabled = false;
                    MessageBox.Show("Password Reset Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // show success message
                    await Task.Delay(500); // wait for 500ms
                    this.Close(); // close the form
                }
                else // if user not found
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // show error message
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
