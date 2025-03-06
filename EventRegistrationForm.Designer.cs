namespace DBS25P156
{
    partial class EventRegistrationForm
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
            ContactTextBox = new TextBox();
            Contact = new Label();
            BackToLogin = new Label();
            InstituteTextBox = new TextBox();
            Institute = new Label();
            button1 = new Button();
            Role = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Fee = new Label();
            comboBox1 = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(278, 19);
            label1.Name = "label1";
            label1.Size = new Size(299, 40);
            label1.TabIndex = 3;
            label1.Text = "Event Registration Form";
            // 
            // ContactTextBox
            // 
            ContactTextBox.BackColor = Color.LightGray;
            ContactTextBox.Font = new Font("Poppins", 10.2F);
            ContactTextBox.ForeColor = SystemColors.ActiveCaptionText;
            ContactTextBox.Location = new Point(20, 68);
            ContactTextBox.Name = "ContactTextBox";
            ContactTextBox.Size = new Size(375, 33);
            ContactTextBox.TabIndex = 1;
            ContactTextBox.Enter += ContactTextBox_Enter;
            ContactTextBox.Leave += ContactTextBox_Leave;
            // 
            // Contact
            // 
            Contact.BackColor = Color.Transparent;
            Contact.Font = new Font("Poppins", 10.2F);
            Contact.ForeColor = SystemColors.ButtonHighlight;
            Contact.Location = new Point(20, 39);
            Contact.Name = "Contact";
            Contact.Size = new Size(114, 30);
            Contact.TabIndex = 22;
            Contact.Text = "Contact";
            Contact.Click += Email_Click;
            // 
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.BackColor = Color.Transparent;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Poppins", 9F, FontStyle.Underline);
            BackToLogin.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin.Location = new Point(161, 343);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(104, 26);
            BackToLogin.TabIndex = 4;
            BackToLogin.Text = "Go To Home";
            BackToLogin.Click += BackToLogin_Click;
            // 
            // InstituteTextBox
            // 
            InstituteTextBox.BackColor = Color.LightGray;
            InstituteTextBox.Font = new Font("Poppins", 10.2F);
            InstituteTextBox.ForeColor = SystemColors.ActiveCaptionText;
            InstituteTextBox.Location = new Point(20, 132);
            InstituteTextBox.Name = "InstituteTextBox";
            InstituteTextBox.Size = new Size(375, 33);
            InstituteTextBox.TabIndex = 2;
            InstituteTextBox.Enter += InstituteTextBox_Enter;
            InstituteTextBox.Leave += InstituteTextBox_Leave;
            // 
            // Institute
            // 
            Institute.BackColor = Color.Transparent;
            Institute.Font = new Font("Poppins", 10.2F);
            Institute.ForeColor = SystemColors.ButtonHighlight;
            Institute.Location = new Point(20, 104);
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
            button1.Location = new Point(89, 300);
            button1.Name = "button1";
            button1.Size = new Size(241, 37);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Role
            // 
            Role.BackColor = Color.Transparent;
            Role.Font = new Font("Poppins", 10.2F);
            Role.ForeColor = SystemColors.ButtonHighlight;
            Role.Location = new Point(19, 169);
            Role.Name = "Role";
            Role.Size = new Size(123, 22);
            Role.TabIndex = 14;
            Role.Text = "Role";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(Fee);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(ContactTextBox);
            groupBox2.Controls.Add(Contact);
            groupBox2.Controls.Add(BackToLogin);
            groupBox2.Controls.Add(InstituteTextBox);
            groupBox2.Controls.Add(Institute);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(Role);
            groupBox2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(196, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 396);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registration";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(138, 263);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 34);
            radioButton2.TabIndex = 26;
            radioButton2.Text = "Paid";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(20, 263);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 34);
            radioButton1.TabIndex = 25;
            radioButton1.Text = "Pending";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            radioButton1.VisibleChanged += radioButton1_VisibleChanged;
            radioButton1.Click += radioButton1_Click;
            radioButton1.Enter += radioButton1_Enter;
            radioButton1.Leave += radioButton1_Leave;
            // 
            // Fee
            // 
            Fee.BackColor = Color.Transparent;
            Fee.Font = new Font("Poppins", 10.2F);
            Fee.ForeColor = SystemColors.ButtonHighlight;
            Fee.Location = new Point(20, 232);
            Fee.Name = "Fee";
            Fee.Size = new Size(123, 37);
            Fee.TabIndex = 24;
            Fee.Text = "Fee";
            Fee.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Professional", "Guest Speaker", "Judge" });
            comboBox1.Location = new Point(20, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 34);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Enter += comboBox1_Enter;
            comboBox1.Leave += comboBox1_Leave;
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
            // EventRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 510);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "EventRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventRegistrationForm";
            Load += EventRegistrationForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ContactTextBox;
        private Label Contact;
        private Label BackToLogin;
        private TextBox InstituteTextBox;
        private Label Institute;
        private Button button1;
        private Label Role;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private Label Fee;
        private ErrorProvider errorProvider4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}