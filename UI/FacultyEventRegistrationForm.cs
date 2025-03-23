using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P156.DAL;

namespace DBS25P156.UI
{
    public partial class FacultyEventRegistrationForm : Form
    {
        RegistrationDAL RegistrationDAL = new RegistrationDAL();
        public FacultyEventRegistrationForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FacultyEventRegistrationForm_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            List<string> Events = RegistrationDAL.getEventsForFaculty();

            foreach (string Event in Events)
            {
                comboBox2.Items.Add(Event);
            }
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

        private void InstituteTextBox_Enter(object sender, EventArgs e)
        {
            Institute.Font = new Font(Institute.Font.FontFamily, 9);
        }

        private void InstituteTextBox_Leave(object sender, EventArgs e)
        {
            Institute.Font = new Font(Institute.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(InstituteTextBox.Text))
            {
                InstituteTextBox.Focus();
                errorProvider2.SetError(InstituteTextBox, "Please Enter Your Institute Name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            RegisterAs.Font = new Font(RegisterAs.Font.FontFamily, 9);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            RegisterAs.Font = new Font(RegisterAs.Font.FontFamily, 8);
            if (comboBox1.SelectedIndex == -1)
            {
                RegisterAs.Focus();
                errorProvider4.SetError(RegisterAs, "Please Select Your Role");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InstituteTextBox.Text) ||
               string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RegistrationDAL.facultyRegistration(textBox3.Text, textBox1.Text, ContactTextBox.Text, InstituteTextBox.Text, comboBox1.Text);
            MessageBox.Show("Register Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            button1.Enabled = false;


            //await Task.Delay(500);
            this.Close();
            //UserHomePageForm userHomePageForm = new UserHomePageForm();
            //this.Hide();
            //userHomePageForm.ShowDialog();

        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider5.SetError(textBox1, "Please enter your Email");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                errorProvider6.SetError(comboBox2, "Please Select the Event");
            }
            else
            {
                errorProvider6.Clear();
            }
        }
    }
}
