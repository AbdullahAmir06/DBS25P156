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
using DBS25P156.BLL;
using DBS25P156.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace DBS25P156.UI
{
    public partial class LoginForm : Form
    {
        //private LoginHandler loginHandler;

        private UserBLL userBLL = new UserBLL();
        public LoginForm()
        {
            InitializeComponent();
            //loginHandler = new LoginHandler();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserSession.UserLoginRoleID = 1;    // this need to be changed this is used for reference only
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //textBox2.PasswordChar = '\0';
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide Password           ";
                checkBox1.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\hidden.png");
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Show Password          ";
                checkBox1.Image = Image.FromFile(@"D:\ABDULLAH(D DRIVE)\UET\Semester-2\Database (DB)\DB MIDTERM PROJECT\eye.png");

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            this.Hide();
            sign_Up.ShowDialog();
            this.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter_1(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font.FontFamily, 9);
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please Enter Username/Email");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            label3.Font = new Font(label4.Font.FontFamily, 9);
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            label3.Font = new Font(label4.Font.FontFamily, 8);

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please Enter Password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            this.Hide();
            forgetPasswordForm.ShowDialog();
            this.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "123")
            {
                textBox2.Clear();
                textBox3.Clear();
                ItecEditionForm itecEditionForm = new ItecEditionForm();
                this.Hide();
                itecEditionForm.ShowDialog();
                this.Show();
                return;

            }

            User user = userBLL.AuthenticateUser(username, password); // create user object which authenticates the user existance from database

            if (user != null)
            {
                UserSession.UserLoginUserName = user.Username;
                UserSession.UserLoginEmail = user.Email;
                UserSession.UserLoginRoleID = user.RoleId;
                textBox2.Clear();
                textBox3.Clear();

                if (user.RoleId == 1 || user.RoleId == 2)
                {
                    UserHomePageForm userHomePageForm = new UserHomePageForm();
                    this.Hide();
                    userHomePageForm.ShowDialog();
                    this.Show();
                }
                else if (user.RoleId == 3 || user.RoleId == 4)
                {

                    Vendor_SponserHomePage vendorAndSponserHomePage = new Vendor_SponserHomePage();
                    this.Hide();
                    vendorAndSponserHomePage.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
