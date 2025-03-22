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
            textBox5.Visible = false;
            radioButton4.Visible = false;
            radioButton3.Visible = false;

            label3.Location = new Point(-1000, -1000);
            label9.Location = new Point(-1000, -1000);
            label8.Location = new Point(-1000, -1000);
            label5.Location = new Point(-1000, -1000);
            textBox8.Location = new Point(-1000, -1000);
            textBox7.Location = new Point(-1000, -1000);
            label7.Location = new Point(-1000, -1000);
            textBox6.Location = new Point(-1000, -1000);
            label6.Location = new Point(-1000, -1000);
            textBox5.Location = new Point(-1000, -1000);
            radioButton4.Location = new Point(-1000, -1000);
            radioButton3.Location = new Point(-1000, -1000);

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
            textBox5.Visible = true;
            radioButton4.Visible = true;
            radioButton3.Visible = true;

            label3.Location = new Point(3, 498);
            label9.Location = new Point(5, 534);
            label8.Location = new Point(5, 602);
            label5.Location = new Point(-1000, -1000);
            textBox8.Location = new Point(5, 567);
            textBox7.Location = new Point(5, 635);
            label7.Location = new Point(5, 671);
            textBox6.Location = new Point(5, 704);
            label6.Location = new Point(5, 739);
            textBox5.Location = new Point(5, 772);
            radioButton4.Location = new Point(7, 839);
            radioButton3.Location = new Point(122, 839);


            button1.Location = new Point(91, 888);
            BackToLogin.Location = new Point(153, 928);
        }

        private void UserEventRegistrationForm_Load(object sender, EventArgs e)
        {
            value1();

            comboBox2.Items.Clear();
            List <string> Events = RegistrationDAL.GetAllEvents();

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
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || comboBox2.SelectedIndex == -1 || (radioButton1.Checked == false && radioButton2.Checked == false))
                {
                    errorProvider1.SetError(groupBox1, "Please fill all the fields");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                    
                    string payment = string.Empty;
                    if (radioButton1.Checked)
                    {
                        payment = radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        payment = radioButton2.Text;
                    }

                    RegistrationDAL.singleParticipantRegistration(comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, payment);
                    MessageBox.Show("Registration Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (numericUpDown1.Value == 2)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || comboBox2.SelectedIndex == -1 || (radioButton1.Checked == false && radioButton2.Checked == false) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox5.Text) || (radioButton3.Checked == false && radioButton4.Checked == false))
                {
                    errorProvider1.SetError(groupBox1, "Please fill all the fields");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }
    }
}
