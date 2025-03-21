using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DBS25P156.BLL;
using DBS25P156.DAL;
using DBS25P156.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBS25P156.UI
{
    public partial class Vendor_SponserHomePage : Form
    {
        public Sponsor_VendorBLL Sponsor_VendorBLL = new Sponsor_VendorBLL();
        public Sponsor_VendorDAL Sponsor_VendorDAL = new Sponsor_VendorDAL();
        public EventDAL EventDAL = new EventDAL();
        public UserBLL UserBLL = new UserBLL();
        public Vendor_SponserHomePage()
        {
            InitializeComponent();
        }
        private void Vendor_SponserHomePage_Load(object sender, EventArgs e)
        {
            if (UserSession.UserLoginRoleID == 4)
            {
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                this.Size = new Size(818, 497);
                groupBox1.Location = new Point(203, 34);
            }
            else if (UserSession.UserLoginRoleID == 3)
            {
                LoadDataIntoComboBox();
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                this.Size = new Size(818, 603);
                groupBox2.Location = new Point(189, 12);

                label4.Location = new Point(17, 317);
                numericUpDown1.Location = new Point(17, 350);
                button2.Location = new Point(90, 435);
                label1.Location = new Point(177, 481);
                groupBox2.Size = new Size(422, 518);
                //this.Size = new Size(818, 603);

            }
        }

        private void LoadDataIntoComboBox()
        {
            List<string> User = UserBLL.GetUsers();
            List<string> Committee = Sponsor_VendorBLL.GetCommitteeNames();
            List<string> Vendor = Sponsor_VendorBLL.GetVendorName();

            string? selectedEntity = comboBox1.SelectedItem?.ToString(); // Use nullable string

            if (string.IsNullOrEmpty(selectedEntity))
            {
                return; // Prevent errors if no selection is made
            }

            comboBox2.Items.Clear();
            if (selectedEntity == "User")
            {
                foreach (string user in User)
                {
                    comboBox2.Items.Add(user);
                }
            }
            else if (selectedEntity == "Committee")
            {
                foreach (string committee in Committee)
                {
                    comboBox2.Items.Add(committee);
                }
            }
            else if (selectedEntity == "Vendor")
            {
                foreach (string vendor in Vendor)
                {
                    comboBox2.Items.Add(vendor);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            this.Hide();
            forgetPasswordForm.ShowDialog();
            this.Show();
        }

        private void ServiceTypeTextBox_Enter(object sender, EventArgs e)
        {
            ServiceType.Font = new Font(ServiceType.Font.FontFamily, 9);
        }

        private void ServiceTypeTextBox_Leave(object sender, EventArgs e)
        {
            ServiceType.Font = new Font(ServiceType.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(ServiceTypeTextBox.Text))
            {
                ServiceTypeTextBox.Focus();
                errorProvider2.SetError(ServiceTypeTextBox, "Please Enter Your Service Type");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(ServiceTypeTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Sponsor_VendorBLL.AddVendor(textBox3.Text, ContactTextBox.Text, ServiceTypeTextBox.Text);
                MessageBox.Show("Vendor Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Clear();
                ServiceTypeTextBox.Clear();
                ContactTextBox.Clear();
                //await Task.Delay(500);
                //this.Close();
            }
        }


        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily, 9);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider4.SetError(textBox1, "Please Enter Your Name");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.FontFamily, 9);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.FontFamily, 8);
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider5.SetError(textBox2, "Please Enter Your Contact");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //r(string name, string contact, int amount, string toEntityUserName, string toEntityType)
                int eventID = EventDAL.GetEventId(comboBox3.Text);
                Sponsor_VendorBLL.AddSponsor(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value), comboBox2.Text, comboBox1.Text, eventID);
                MessageBox.Show("Sponser Registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                numericUpDown1.Value = 0;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                //await Task.Delay(500);
                //this.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
            comboBox2.SelectedIndex = -1;
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox3.Visible = true;
                comboBox3.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                label7.Visible = true;
                label4.Location = new Point(21, 383);
                numericUpDown1.Location = new Point(21, 416);
                button2.Location = new Point(94, 501);
                label1.Location = new Point(181, 547);
                groupBox2.Size = new Size(422, 583);
                this.Size = new Size(818, 688);

            }
            else
            {
                comboBox3.Visible = false;
                label7.Visible = false;
                comboBox2.SelectedIndex = -1;
                label4.Location = new Point(17, 317);
                numericUpDown1.Location = new Point(17, 350);
                button2.Location = new Point(90, 435);
                label1.Location = new Point(177, 481);
                groupBox2.Size = new Size(422, 518);
                this.Size = new Size(818, 603);

            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorProvider6.SetError(comboBox1, "Please Select the Entity Type");
            }

            else
            {
                errorProvider6.Clear();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                errorProvider7.SetError(comboBox2, "Please Select the Entity Name ");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int committeeId = Sponsor_VendorDAL.GetCommiteeId(comboBox2.Text);
            List<string> eventList = EventDAL.GetEventNameOfSpecificCommitteeId(committeeId);
            comboBox3.Items.Clear();

            foreach (string eventName in eventList)
            {
                comboBox3.Items.Add(eventName); // Populate comboBox3 
            }


        }
        private void comboBox3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                errorProvider6.SetError(comboBox2, "Please select the committee name first");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
