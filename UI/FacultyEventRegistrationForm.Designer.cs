namespace DBS25P156.UI
{
    partial class FacultyEventRegistrationForm
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            Event = new Label();
            comboBox1 = new ComboBox();
            RegisterAs = new Label();
            textBox3 = new TextBox();
            Names = new Label();
            ContactTextBox = new TextBox();
            Contact = new Label();
            BackToLogin = new Label();
            InstituteTextBox = new TextBox();
            Institute = new Label();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(255, 10);
            label1.Name = "label1";
            label1.Size = new Size(299, 40);
            label1.TabIndex = 4;
            label1.Text = "Event Registration Form";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(Event);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(RegisterAs);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(Names);
            groupBox2.Controls.Add(ContactTextBox);
            groupBox2.Controls.Add(Contact);
            groupBox2.Controls.Add(BackToLogin);
            groupBox2.Controls.Add(InstituteTextBox);
            groupBox2.Controls.Add(Institute);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(195, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 529);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registration";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Poppins", 10.2F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(20, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 33);
            textBox1.TabIndex = 2;
            textBox1.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 10.2F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 179);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 35;
            label2.Text = "Email";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightGray;
            comboBox2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.WindowText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 76);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(272, 38);
            comboBox2.TabIndex = 0;
            comboBox2.Leave += comboBox2_Leave;
            // 
            // Event
            // 
            Event.AutoSize = true;
            Event.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Event.Location = new Point(17, 43);
            Event.Name = "Event";
            Event.Size = new Size(60, 30);
            Event.TabIndex = 32;
            Event.Text = "Event";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Professional", "Guest Speaker", "Judge" });
            comboBox1.Location = new Point(20, 396);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 38);
            comboBox1.TabIndex = 5;
            comboBox1.Enter += comboBox1_Enter;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // RegisterAs
            // 
            RegisterAs.BackColor = Color.Transparent;
            RegisterAs.Font = new Font("Poppins", 10.2F);
            RegisterAs.ForeColor = SystemColors.ButtonHighlight;
            RegisterAs.Location = new Point(20, 369);
            RegisterAs.Name = "RegisterAs";
            RegisterAs.Size = new Size(150, 24);
            RegisterAs.TabIndex = 30;
            RegisterAs.Text = "Register As";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Poppins", 10.2F);
            textBox3.ForeColor = SystemColors.ActiveCaptionText;
            textBox3.Location = new Point(20, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 33);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // Names
            // 
            Names.BackColor = Color.Transparent;
            Names.Font = new Font("Poppins", 10.2F);
            Names.ForeColor = SystemColors.ButtonHighlight;
            Names.Location = new Point(20, 117);
            Names.Name = "Names";
            Names.Size = new Size(114, 30);
            Names.TabIndex = 28;
            Names.Text = "Name";
            // 
            // ContactTextBox
            // 
            ContactTextBox.BackColor = Color.LightGray;
            ContactTextBox.Font = new Font("Poppins", 10.2F);
            ContactTextBox.ForeColor = SystemColors.ActiveCaptionText;
            ContactTextBox.Location = new Point(20, 271);
            ContactTextBox.Name = "ContactTextBox";
            ContactTextBox.Size = new Size(375, 33);
            ContactTextBox.TabIndex = 3;
            ContactTextBox.Enter += ContactTextBox_Enter;
            ContactTextBox.Leave += ContactTextBox_Leave;
            // 
            // Contact
            // 
            Contact.BackColor = Color.Transparent;
            Contact.Font = new Font("Poppins", 10.2F);
            Contact.ForeColor = SystemColors.ButtonHighlight;
            Contact.Location = new Point(20, 241);
            Contact.Name = "Contact";
            Contact.Size = new Size(114, 30);
            Contact.TabIndex = 22;
            Contact.Text = "Contact";
            // 
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.BackColor = Color.Transparent;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Poppins", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            BackToLogin.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin.Location = new Point(146, 488);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(119, 30);
            BackToLogin.TabIndex = 7;
            BackToLogin.Text = "Go To Home";
            BackToLogin.Click += BackToLogin_Click;
            // 
            // InstituteTextBox
            // 
            InstituteTextBox.BackColor = Color.LightGray;
            InstituteTextBox.Font = new Font("Poppins", 10.2F);
            InstituteTextBox.ForeColor = SystemColors.ActiveCaptionText;
            InstituteTextBox.Location = new Point(20, 333);
            InstituteTextBox.Name = "InstituteTextBox";
            InstituteTextBox.Size = new Size(375, 33);
            InstituteTextBox.TabIndex = 4;
            InstituteTextBox.Enter += InstituteTextBox_Enter;
            InstituteTextBox.Leave += InstituteTextBox_Leave;
            // 
            // Institute
            // 
            Institute.BackColor = Color.Transparent;
            Institute.Font = new Font("Poppins", 10.2F);
            Institute.ForeColor = SystemColors.ButtonHighlight;
            Institute.Location = new Point(20, 307);
            Institute.Name = "Institute";
            Institute.Size = new Size(150, 22);
            Institute.TabIndex = 18;
            Institute.Text = "Institute";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(82, 448);
            button1.Name = "button1";
            button1.Size = new Size(241, 37);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // FacultyEventRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(800, 641);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "FacultyEventRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FacultyEventRegistrationForm";
            Load += FacultyEventRegistrationForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label RegisterAs;
        private TextBox textBox3;
        private Label Names;
        private TextBox ContactTextBox;
        private Label Contact;
        private Label BackToLogin;
        private TextBox InstituteTextBox;
        private Label Institute;
        private Button button1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ComboBox comboBox2;
        private Label Event;
        private TextBox textBox1;
        private Label label2;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
    }
}