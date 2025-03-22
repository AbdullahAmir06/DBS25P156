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
using DBS25P156.DAL;

namespace DBS25P156.UI
{
    public partial class EventRegistrationForm : Form
    {
        RegistrationDAL RegistrationDAL = new RegistrationDAL();

        public EventRegistrationForm()
        {
            InitializeComponent();
        }
        private void EventRegistrationForm_Load(object sender, EventArgs e)
        {
            loadSingleParticipantData();

            List<string> Events = RegistrationDAL.GetAllEvents();

            comboBox2.Items.Clear();
            foreach (string Event in Events)
            {
                comboBox2.Items.Add(Event);
            }
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

                string name = textBox3.Text;
                string contact = ContactTextBox.Text;
                string institute = InstituteTextBox.Text;
                string payment;
                if (radioButton1.Checked)
                {
                    payment = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {

                    payment = radioButton2.Text;
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
                loadSingleParticipantData();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                loadTeamData();
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


        public void loadSingleParticipantData()
        {
            //label6.Visible = false;
            //label7.Visible = false;
            //label8.Visible = false;
            //label9.Visible = false;
            //label10.Visible = false;
            //textBox4.Visible = false;
            //textBox5.Visible = false;
            //textBox6.Visible = false;
            //textBox7.Visible = false;

            //label2.Location = new Point(20, 38);
            //comboBox2.Location = new Point(20, 67);
            //NameOfStudent.Location = new Point(20, 100);
            //textBox3.Location = new Point(20, 129);
            //Contact.Location = new Point(20, 162);
            //ContactTextBox.Location = new Point(20, 191);
            //Institute.Location = new Point(20, 227);
            //InstituteTextBox.Location = new Point(20, 255);
            //label3.Location = new Point(20, 291);
            //textBox1.Location = new Point (20, 318);

            //RegisterAs.Location = new Point(20, 354);
            //comboBox1.Location = new Point(20, 381);


            //Fee.Location = new Point(20, 419);
            //Fee.Text = "500";
            //radioButton1.Location = new Point(20, 453);
            //radioButton2.Location = new Point(129, 453);
            //button1.Location = new Point(82, 504);
            //BackToLogin.Location = new Point(160, 555);
            //groupBox2.Location = new Point(209, 125);
            //groupBox2.Size = new Size(437, 612);
            //this.Size = new Size(860, 745);
        }

        public void loadTeamData()
        {
            //label2.Location = new Point(20, 38);
            //comboBox2.Location = new Point(20, 67);
            //NameOfStudent.Location = new Point(20, 100);
            //textBox3.Location = new Point(20, 129);
            //Contact.Location = new Point(20, 162);
            //ContactTextBox.Location = new Point(20, 191);
            //Institute.Location = new Point(20, 227);
            //InstituteTextBox.Location = new Point(20, 255);
            //label3.Location = new Point(20, 291);
            //textBox1.Location = new Point(20, 318);

            //RegisterAs.Location = new Point(20, 354);
            //comboBox1.Location = new Point(20, 381);



            //label6.Visible = true;
            //label7.Visible = true;
            //label8.Visible = true;
            //label9.Visible = true;
            //label10.Visible = true;
            //textBox4.Visible = true;
            //textBox5.Visible = true;
            //textBox6.Visible = true;
            //textBox7.Visible = true;
            //label9.Location = new Point(20, 415);
            //label6.Location = new Point(20, 449);
            //textBox4.Location = new Point(20, 478);
            //label7.Location = new Point(20, 511);
            //textBox5.Location = new Point(20, 540);

            //label4.Location = new Point(20, 513);
            //textBox2.Location = new Point(20, 541);

            //label8.Location = new Point(20, 639);
            //textBox6.Location = new Point(20, 667);
            //label10.Location = new Point(20, 701);
            //textBox7.Location = new Point(20, 729);

            //Fee.Location = new Point(20, 775);
            //Fee.Text = "500 X 2 = 1000";
            //radioButton1.Location = new Point(20, 815);
            //radioButton2.Location = new Point(129, 815);
            //BackToLogin.Location = new Point(160, 896);
            ////151, 708
            //button1.Location = new Point(82, 856);
            //groupBox2.Size = new Size(437, 937);
            //this.Size = new Size(860, 1088);
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                errorProvider10.SetError(comboBox2, "Please Select the Event Name First");
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
