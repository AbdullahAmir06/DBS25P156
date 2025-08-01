﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DBS25P156.DAL;
using DBS25P156.Models;

namespace DBS25P156.UI
{
    public partial class UserCommitteeForm : Form
    {
        public DutyDAL DutyDAL = new DutyDAL();
        public UserCommitteeForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginForm lf = new LoginForm();
            //lf.ShowDialog();
        }

        private void UserCommitteeForm_Load(object sender, EventArgs e)
        {
            List<string> Committees = DutyDAL.GetCommitteeNames(UserSession.UserLoginUserName);
            comboBox2.Items.Clear();
            foreach (string CommitteeName in Committees)
            {
                comboBox2.Items.Add(CommitteeName);
            }
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Regular);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            //label5.Font = new Font(label5.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            //label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Regular);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            //UserHomePageForm uhp = new UserHomePageForm();
            //uhp.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserEventRegistrationForm userEventRegistrationForm = new UserEventRegistrationForm();
            //UserEventForm uef = new UserEventForm();
            this.Hide();
            userEventRegistrationForm.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            //UserPaymentForm upf = new UserPaymentForm();
            //upf.ShowDialog();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Please Select Duty Status");
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private  void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DutyDAL.UpdateDutyStatus(comboBox1.Text, comboBox2.Text);
                MessageBox.Show("Duty Status Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox2.Clear();
                dateTimePicker1.Value = DateTime.Now;
                //await Task.Delay(500);
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                errorProvider2.SetError(comboBox2, "Please Selete the Committee Name");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex != -1)
            {
                DutyDAL = DutyDAL.GetDutyDetails(comboBox2.Text);
                if(DutyDAL != null)
                {
                    textBox2.Text = DutyDAL.description;
                    dateTimePicker1.Value = DutyDAL.date;
                }
            }

        }
    }
}
