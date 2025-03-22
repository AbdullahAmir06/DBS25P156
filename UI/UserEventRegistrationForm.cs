using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P156.DAL;

namespace DBS25P156.UI
{
    public partial class UserEventRegistrationForm : Form
    {
        RegistrationDAL RegistrationDAL = new RegistrationDAL();
        public UserEventRegistrationForm()
        {
            InitializeComponent();
            //panel1.Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            panel1.AutoScroll = false;
            if (numericUpDown1.Value == 1)
            {
                //panel1.Refresh();
                value1();
            }
            else if (numericUpDown1.Value == 2)
            {
                //panel1.Refresh();
                value2();
            }

            panel1.AutoScroll = true;
            panel1.AutoScrollPosition = new Point(0, 0);
        }


        public void value1()
        {
            label3.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label5.Visible = false;
            textBox8.Visible = false;
            textBox7.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            textBox9.Visible = false;
            textBox5.Visible = false;
            //radioButton4.Visible = false;
            //radioButton3.Visible = false;
            comboBox3.Visible = false;

            label3.Location = new Point(-1000, -1000);
            label9.Location = new Point(-1000, -1000);
            label8.Location = new Point(-1000, -1000);
            label5.Location = new Point(-1000, -1000);
            textBox8.Location = new Point(-1000, -1000);
            textBox7.Location = new Point(-1000, -1000);
            label7.Location = new Point(-1000, -1000);
            textBox6.Location = new Point(-1000, -1000);
            label6.Location = new Point(-1000, -1000);
            label10.Location = new Point(-1000, -1000);
            textBox9.Location = new Point(-1000, -1000);
            textBox5.Location = new Point(-1000, -1000);
            comboBox3.Location = new Point(-1000, -1000);
            //radioButton4.Location = new Point(-1000, -1000);
            //radioButton3.Location = new Point(-1000, -1000);

            button1.Location = new Point(94, 491);
            BackToLogin.Location = new Point(156, 531);

        }

        public void value2()
        {
            label3.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label5.Visible = true;
            textBox8.Visible = true;
            textBox7.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
            label6.Visible = true;
            label10.Visible = true;
            textBox9.Visible = true;
            textBox5.Visible = true;
            comboBox3.Visible = true;
            //radioButton4.Visible = true;
            //radioButton3.Visible = true;

            label3.Location = new Point(3, 498);
            label9.Location = new Point(5, 534);
            label8.Location = new Point(5, 602);
            label5.Location = new Point(5, 808);
            textBox8.Location = new Point(5, 567);
            textBox7.Location = new Point(5, 635);
            label7.Location = new Point(5, 671);
            textBox6.Location = new Point(5, 704);
            label6.Location = new Point(5, 739);
            textBox5.Location = new Point(5, 772);
            //radioButton4.Location = new Point(7, 839);
            //radioButton3.Location = new Point(122, 839);
            comboBox3.Location = new Point(5, 841);
            label10.Location = new Point(5, 881);
            textBox9.Location = new Point(5, 914);


            button1.Location = new Point(91, 975);
            BackToLogin.Location = new Point(153, 1024);
        }

        private void UserEventRegistrationForm_Load(object sender, EventArgs e)
        {
            value1();

            comboBox2.Items.Clear();
            List<string> Events = RegistrationDAL.GetAllEvents();

            foreach (string Event in Events)
            {
                comboBox2.Items.Add(Event);
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "Please Select the Event Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 1)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex ==-1)
                {
                    groupBox1.Focus();
                    errorProvider1.SetError(groupBox1, "Please fill all the fields");
                    return;
                }
                else
                {
                    errorProvider1.Clear();

                    string payment = comboBox1.Text;

                    RegistrationDAL.singleParticipantRegistration(comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, payment);
                    MessageBox.Show("Registration Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (numericUpDown1.Value == 2)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex ==-1 || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox5.Text) || comboBox3.SelectedIndex ==-1)
                {
                    groupBox1.Focus();
                    errorProvider1.SetError(groupBox1, "Please fill all the fields");
                    return;
                }
                else
                {
                    errorProvider1.Clear();



                    string payment1 = comboBox1.Text;
                    string payment2 = comboBox3.Text;



                    RegistrationDAL.RegisterTeam(comboBox2.Text, textBox9.Text);
                    RegistrationDAL.singleParticipantRegistration(comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, payment1);
                    RegistrationDAL.TeamParticipantRegistration(textBox1.Text, textBox3.Text,textBox9.Text);
                    //public bool singleParticipantRegistration(string eventName, string name, string email, string contact, string institution, string paymentStatus)
                    RegistrationDAL.singleParticipantRegistration(comboBox2.Text, textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text, payment2);
                    RegistrationDAL.TeamParticipantRegistration(textBox8.Text, textBox6.Text, textBox9.Text);
                    MessageBox.Show("Registration Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBox1_DragLeave(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex ==-1)
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Please Select the Payment Status");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
