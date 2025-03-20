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
using DBS25P156.BLL;
using DBS25P156.Models;
using DBS25P156.DAL;

namespace DBS25P156.UI
{
    public partial class AdminEventPageForm : Form
    {
        Event newEvent = new Event();   //used to fetch data from db

        EventBLL eventBLL = new EventBLL();
        //VenueBLL venueBLL = new VenueBLL();
        public AdminEventPageForm()
        {
            InitializeComponent();
        }

        public void LoadDataIntoComboBoxes()
        {

            //List<string> Venue = venueBLL.GetVenueNames();
            //comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            //foreach (string venue in Venue)
            //{
            //    comboBox1.Items.Add(venue);
            //    comboBox2.Items.Add(venue);
            //}

            //comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            //comboBox3.Items.Clear();
            //comboBox5.Items.Clear();
            //comboBox4.Items.Clear();
            //comboBox6.Items.Clear();
            //comboBox7.Items.Clear();
            comboBox1.DataSource = eventBLL.GetEventCategory();
            comboBox2.DataSource = eventBLL.GetVenueNames();
            comboBox3.DataSource = eventBLL.GetEventNames();
            comboBox4.DataSource = eventBLL.GetVenueNames();
            comboBox5.DataSource = eventBLL.GetVenueNames();
            comboBox6.DataSource = eventBLL.GetEventNames();
            comboBox7.DataSource = eventBLL.GetCommitteeNames();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
        }



        private void AdminEventPageForm_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(340, 323);
            LoadDataIntoComboBoxes();

        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Regular);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {

            label5.Font = new Font(label5.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {

            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Underline);
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            panel2.Visible = false;
            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = false;

            groupBoxAdd.Visible = true;
            groupBoxAdd.Location = new Point(362, 170);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            panel2.Visible = false;
            groupBoxAdd.Visible = false;
            groupBoxDelete.Visible = false;

            groupBoxUpdate.Visible = true;
            groupBoxUpdate.Location = new Point(359, 228);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            panel2.Visible = false;
            groupBoxUpdate.Visible = false;
            groupBoxAdd.Visible = false;

            groupBoxDelete.Location = new Point(359, 228);
            groupBoxDelete.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            //AdminHomePageForm adminHomePageForm = new AdminHomePageForm();
            //this.Hide();
            //adminHomePageForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.FontFamily, 9);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Enter Name of Event");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 9);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            label10.Font = new Font(label10.Font.FontFamily, 8);

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.Focus();
                errorProvider2.SetError(comboBox1, "Please Select Event Category");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 9);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            label11.Font = new Font(label11.Font.FontFamily, 8);

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider3.SetError(textBox2, "Please Enter description of the event");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            label12.Font = new Font(label12.Font.FontFamily, 9);
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            label12.Font = new Font(label12.Font.FontFamily, 8);

            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                dateTimePicker1.Focus();
                errorProvider4.SetError(dateTimePicker1, "Please Select Date and Time");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            label13.Font = new Font(label13.Font.FontFamily, 9);
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            label13.Font = new Font(label13.Font.FontFamily, 8);

            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                comboBox2.Focus();
                errorProvider5.SetError(comboBox2, "Please Select Event Venue");
            }
            else
            {
                errorProvider5.Clear();
            }
        }


        private async void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //button4.Enabled = false;
                //public bool CreateEvent(string name, string description, DateTime date, string categoryName, string venueName, string committeeName)

                eventBLL.CreateEvent(textBox1.Text, textBox2.Text, dateTimePicker1.Value, dateTimePicker4.Value, comboBox1.Text, comboBox2.Text, comboBox7.Text);
                MessageBox.Show("Event Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataIntoComboBoxes();
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
                //await Task.Delay(500);
                //this.Close();

            }
        }

        private void comboBox6_Enter(object sender, EventArgs e)
        {
            label21.Font = new Font(label21.Font.FontFamily, 9);
        }

        private void comboBox6_Leave(object sender, EventArgs e)
        {
            label21.Font = new Font(label21.Font.FontFamily, 8);

            if (string.IsNullOrEmpty(comboBox6.Text))
            {
                comboBox6.Focus();
                errorProvider6.SetError(comboBox6, "Please Select Event Name");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //newEvent = eventBLL.GetSingleEvent(comboBox6.Text);
            //comboBox5.Text = eventBLL.GetSingleVenueName(newEvent.VenueId);
            //dateTimePicker3.Value = newEvent.Date;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox6.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //button6.Enabled = false;
                eventBLL.DeleteEvent(comboBox6.Text);
                MessageBox.Show("Event Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataIntoComboBoxes();
                comboBox6.SelectedIndex = -1;
                //this.Close();
            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            label16.Font = new Font(label16.Font.FontFamily, 9);
        }
        private void comboBox3_Leave(object sender, EventArgs e)
        {
            label16.Font = new Font(label16.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                comboBox3.Focus();
                errorProvider7.SetError(comboBox3, "Please Select Event Name");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void dateTimePicker2_Enter(object sender, EventArgs e)
        {
            label18.Font = new Font(label18.Font.FontFamily, 9);
        }
        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
            label18.Font = new Font(label18.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(dateTimePicker2.Text))
            {
                dateTimePicker2.Focus();
                errorProvider8.SetError(dateTimePicker2, "Please Select Date and Time");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void comboBox4_Enter(object sender, EventArgs e)
        {
            label17.Font = new Font(label17.Font.FontFamily, 9);
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            label17.Font = new Font(label17.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(comboBox4.Text))
            {
                comboBox4.Focus();
                errorProvider9.SetError(comboBox4, "Please Select Event Venue");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox3.Text) || string.IsNullOrWhiteSpace(comboBox4.Text) || string.IsNullOrWhiteSpace(dateTimePicker2.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = comboBox3.Text;
                string venue = comboBox4.Text;
                DateTime date = dateTimePicker2.Value;
                DateTime time = dateTimePicker5.Value;
                eventBLL.UpdateEvent(name, date, time, venue);
                //button5.Enabled = false;
                //MessageBox.Show("Event Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataIntoComboBoxes();
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                dateTimePicker2.Value = DateTime.Now;

                //this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxAdd_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedItem != null && comboBox7.SelectedItem.ToString() == "Add New Committee")
            {

                AdminCommitteeRegistrationForm form = new AdminCommitteeRegistrationForm();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void comboBox7_Leave(object sender, EventArgs e)
        {
            label22.Font = new Font(label22.Font.FontFamily, 8);
            if (comboBox7.SelectedIndex == -1)
            {
                comboBox7.Focus();
                errorProvider10.SetError(comboBox7, "Please Select Committee");
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void comboBox7_Enter(object sender, EventArgs e)
        {
            label22.Font = new Font(label22.Font.FontFamily, 9);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminCommitteeForm form = new AdminCommitteeForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    newEvent = eventBLL.GetSingleEvent(comboBox3.Text);
        //    comboBox4.Text = eventBLL.GetSingleVenueName(newEvent.VenueId);
        //    dateTimePicker2.Value = newEvent.Date;
        //}

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fetch event details
            //newEvent = eventBLL.GetSingleEvent(comboBox3.Text);

            //if (newEvent != null)  // Check if newEvent is null
            //{
            //    // Assign Venue Name safely
            //    if (newEvent.VenueId != null)
            //    {
            //        comboBox4.Text = eventBLL.GetSingleVenueName(newEvent.VenueId);
            //    }
            //    else
            //    {
            //        comboBox4.Text = "Venue Not Found";
            //    }

            //    // Assign Date to DateTimePicker safely
            //    if (newEvent.Date != DateTime.MinValue) // Ensure the date is valid
            //    {
            //        dateTimePicker2.Value = newEvent.Date;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Date! Please check the event details.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Event not found! Please check the selected item.");
            //}
        }

        private void dateTimePicker4_Enter(object sender, EventArgs e)
        {
            label23.Font = new Font(label23.Font.FontFamily, 9);
        }

        private void dateTimePicker4_Leave(object sender, EventArgs e)
        {
            label23.Font = new Font(label23.Font.FontFamily, 8);
        }

        private void dateTimePicker5_Enter(object sender, EventArgs e)
        {
            label24.Font = new Font(label24.Font.FontFamily, 9);
        }

        private void dateTimePicker5_Leave(object sender, EventArgs e)
        {
            label24.Font = new Font(label24.Font.FontFamily, 8);
        }
    }
}
