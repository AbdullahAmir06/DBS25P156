namespace DBS25P156.UI
{
    partial class UserEventRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox9 = new TextBox();
            label10 = new Label();
            label3 = new Label();
            button1 = new Button();
            BackToLogin = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox8 = new TextBox();
            NumberOfParticipants = new Label();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            Contact = new Label();
            textBox2 = new TextBox();
            Email = new Label();
            textBox1 = new TextBox();
            nameLabel = new Label();
            comboBox2 = new ComboBox();
            Event = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Poppins Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(225, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 532);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registration";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BackToLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(NumberOfParticipants);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(Contact);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(Event);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 485);
            panel1.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.LightGray;
            comboBox3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.ForeColor = SystemColors.WindowText;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pending", "Paid" });
            comboBox3.Location = new Point(5, 841);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(207, 34);
            comboBox3.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "Paid" });
            comboBox1.Location = new Point(0, 445);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 34);
            comboBox1.TabIndex = 31;
            comboBox1.DragLeave += comboBox1_DragLeave;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.LightGray;
            textBox9.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(5, 914);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(284, 33);
            textBox9.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 881);
            label10.Name = "label10";
            label10.Size = new Size(119, 30);
            label10.TabIndex = 29;
            label10.Text = "Team Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 498);
            label3.Name = "label3";
            label3.Size = new Size(162, 36);
            label3.TabIndex = 17;
            label3.Text = "Participant 2:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(94, 491);
            button1.Name = "button1";
            button1.Size = new Size(241, 37);
            button1.TabIndex = 16;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.BackColor = Color.Transparent;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Poppins", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            BackToLogin.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin.Location = new Point(156, 531);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(119, 30);
            BackToLogin.TabIndex = 15;
            BackToLogin.Text = "Go To Home";
            BackToLogin.Click += BackToLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 808);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 26;
            label5.Text = "Fee : 500";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightGray;
            textBox5.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(5, 772);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(284, 33);
            textBox5.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 415);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 12;
            label2.Text = "Fee : 500";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 534);
            label9.Name = "label9";
            label9.Size = new Size(65, 30);
            label9.TabIndex = 18;
            label9.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 739);
            label6.Name = "label6";
            label6.Size = new Size(81, 30);
            label6.TabIndex = 24;
            label6.Text = "Institute";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.LightGray;
            numericUpDown1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(4, 381);
            numericUpDown1.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 33);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightGray;
            textBox8.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(5, 567);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(284, 33);
            textBox8.TabIndex = 19;
            // 
            // NumberOfParticipants
            // 
            NumberOfParticipants.AutoSize = true;
            NumberOfParticipants.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumberOfParticipants.Location = new Point(3, 348);
            NumberOfParticipants.Name = "NumberOfParticipants";
            NumberOfParticipants.Size = new Size(210, 30);
            NumberOfParticipants.TabIndex = 10;
            NumberOfParticipants.Text = "Number Of Participants";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightGray;
            textBox6.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(5, 704);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(284, 33);
            textBox6.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(3, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(284, 33);
            textBox4.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 602);
            label8.Name = "label8";
            label8.Size = new Size(59, 30);
            label8.TabIndex = 20;
            label8.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 279);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 8;
            label4.Text = "Institute";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(5, 671);
            label7.Name = "label7";
            label7.Size = new Size(81, 30);
            label7.TabIndex = 22;
            label7.Text = "Contact";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(3, 244);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 33);
            textBox3.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightGray;
            textBox7.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(5, 635);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(284, 33);
            textBox7.TabIndex = 21;
            // 
            // Contact
            // 
            Contact.AutoSize = true;
            Contact.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contact.Location = new Point(3, 211);
            Contact.Name = "Contact";
            Contact.Size = new Size(81, 30);
            Contact.TabIndex = 6;
            Contact.Text = "Contact";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(3, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 33);
            textBox2.TabIndex = 5;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(3, 142);
            Email.Name = "Email";
            Email.Size = new Size(59, 30);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 33);
            textBox1.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(3, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(65, 30);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightGray;
            comboBox2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.WindowText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 33);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(272, 38);
            comboBox2.TabIndex = 1;
            comboBox2.Leave += comboBox2_Leave;
            // 
            // Event
            // 
            Event.AutoSize = true;
            Event.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Event.Location = new Point(0, 0);
            Event.Name = "Event";
            Event.Size = new Size(60, 30);
            Event.TabIndex = 0;
            Event.Text = "Event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(176, 20);
            label1.Name = "label1";
            label1.Size = new Size(576, 78);
            label1.TabIndex = 4;
            label1.Text = "Event Registration Form";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UserEventRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(881, 694);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "UserEventRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserEventRegistrationForm";
            Load += UserEventRegistrationForm_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label Event;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label Contact;
        private TextBox textBox2;
        private Label Email;
        private TextBox textBox1;
        private Label nameLabel;
        private Label NumberOfParticipants;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button1;
        private Label BackToLogin;
        private Label label3;
        private Label label5;
        private TextBox textBox5;
        private Label label9;
        private Label label6;
        private TextBox textBox8;
        private TextBox textBox6;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private ErrorProvider errorProvider1;
        private TextBox textBox9;
        private Label label10;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
    }

}