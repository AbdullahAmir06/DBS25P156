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

namespace DBS25P156.UI
{
    public partial class EventRegistrationForm : Form
    {
        public EventRegistrationForm()
        {
            InitializeComponent();
        }
        private void EventRegistrationForm_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            Fee.Location = new Point(20, 294);
            radioButton1.Location = new Point(20, 328);
            radioButton2.Location = new Point(129, 328);
            button1.Location = new Point(82, 381);
            BackToLogin.Location = new Point(160, 430);
            groupBox2.Location = new Point(209, 62);
            groupBox2.Size = new Size(437, 487);
            this.Size = new Size(860, 620);
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


        private async void button1_Click(object sender, EventArgs e)
        {
            //if (UserSession.UserLoginRoleID == 1)
            //{
                if (comboBox1.SelectedIndex == 0)
                {
                    if (string.IsNullOrWhiteSpace(InstituteTextBox.Text) ||
               string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("Register Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (string.IsNullOrWhiteSpace(InstituteTextBox.Text) ||
               string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
                    {
                        MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("Register Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            //}
                button1.Enabled = false;

                await Task.Delay(500);
                UserHomePageForm userHomePageForm = new UserHomePageForm();
                this.Hide();
                userHomePageForm.ShowDialog();

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

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            NameOfStudent.Font = new Font(NameOfStudent.Font.FontFamily, 9);
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            NameOfStudent.Font = new Font(NameOfStudent.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider3.SetError(textBox3, "Please Enter Your Name");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
                comboBox1.Focus();
                errorProvider5.SetError(comboBox1, "Please Select Registration Type");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                Fee.Location = new Point(20, 294);
                Fee.Text = "500";
                radioButton1.Location = new Point(20, 328);
                radioButton2.Location = new Point(129, 328);
                button1.Location = new Point(82, 381);
                BackToLogin.Location = new Point(160, 430);
                groupBox2.Location = new Point(209, 62);
                groupBox2.Size = new Size(437, 487);
                this.Size = new Size(860, 620);

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                label9.Location = new Point(20, 290);
                label6.Location = new Point(20, 324);
                textBox4.Location = new Point(20, 353);
                label7.Location = new Point(20, 386);
                textBox5.Location = new Point(20, 415);
                label8.Location = new Point(20, 451);
                textBox6.Location = new Point(20, 479);
                label10.Location = new Point(20, 513);
                textBox7.Location = new Point(20, 541);

                Fee.Location = new Point(20, 587);
                Fee.Text = "500 X 2 = 1000";
                radioButton1.Location = new Point(20, 627);
                radioButton2.Location = new Point(129, 627);
                BackToLogin.Location = new Point(160, 717);
                button1.Location = new Point(82, 668);
                groupBox2.Size = new Size(437, 749);
                this.Size = new Size(860, 900);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font.FontFamily, 9);
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Focus();
                errorProvider6.SetError(textBox4, "Please Enter Your Name");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font.FontFamily, 9);
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.Focus();
                errorProvider7.SetError(textBox5, "Please Enter Your Contact");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font.FontFamily, 9);

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Focus();
                errorProvider8.SetError(textBox6, "Please Enter Your Institute Name");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 9);
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                textBox7.Focus();
                errorProvider9.SetError(textBox7, "Please Enter Your Team Name");
            }
            else
            {
                errorProvider9.Clear();
            }
        }
    }
}
