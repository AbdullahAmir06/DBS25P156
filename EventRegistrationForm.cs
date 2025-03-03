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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBS25P156
{
    public partial class EventRegistrationForm : Form
    {
        public EventRegistrationForm()
        {
            InitializeComponent();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Email_Click(object sender, EventArgs e)
        {

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
                errorProvider1.SetError(ContactTextBox, "Please Enter Your Contact Number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        private void EventRegistrationForm_Load(object sender, EventArgs e)
        {

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
            Role.Font = new Font(Role.Font.FontFamily, 9);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            Role.Font = new Font(Role.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.Focus();
                errorProvider3.SetError(comboBox1, "Please Select Your Role");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InstituteTextBox.Text) ||  // Check TextBox1
            string.IsNullOrWhiteSpace(ContactTextBox.Text) ||  // Check TextBox2
        (!radioButton1.Checked) ||  // Check if any RadioButton is selected
        comboBox1.SelectedIndex == -1)  // Check if ComboBox has a selection
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                label2.Visible = true;
                //this.Close();

            }
        }
        private void radioButton1_Enter(object sender, EventArgs e)
        {
            Fee.Font = new Font(Fee.Font.FontFamily, 12);
        }

        private void radioButton1_Leave(object sender, EventArgs e)
        {
            Fee.Font = new Font(Fee.Font.FontFamily, 9);

            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                //radioButton1.Focus();
                errorProvider4.SetError(radioButton2, "Please Select Your Fees Status");
            }
            else
            {
                errorProvider4.Clear();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_Enter(object sender, EventArgs e)
        {
            Fee.Font = new Font(Fee.Font.FontFamily, 12);
        }

        private void radioButton2_Leave(object sender, EventArgs e)
        {
            Fee.Font = new Font(Fee.Font.FontFamily, 9);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
