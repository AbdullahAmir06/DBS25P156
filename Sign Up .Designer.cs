namespace DBS25P156
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            Role = new Label();
            EmailTextBox = new TextBox();
            Email = new Label();
            BackToLogin = new Label();
            UsernameTextBox = new TextBox();
            Username = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            PasswordTextBox = new TextBox();
            Password = new Label();
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
            label1.Location = new Point(320, 21);
            label1.Name = "label1";
            label1.Size = new Size(148, 40);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(Role);
            groupBox2.Controls.Add(EmailTextBox);
            groupBox2.Controls.Add(Email);
            groupBox2.Controls.Add(BackToLogin);
            groupBox2.Controls.Add(UsernameTextBox);
            groupBox2.Controls.Add(Username);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(PasswordTextBox);
            groupBox2.Controls.Add(Password);
            groupBox2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(196, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 410);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sign Up";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Faculty", "Sponsor", "Vendor" });
            comboBox1.Location = new Point(20, 249);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 31);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Enter += comboBox1_Enter;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // Role
            // 
            Role.BackColor = Color.Transparent;
            Role.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role.ForeColor = SystemColors.ButtonHighlight;
            Role.Location = new Point(20, 225);
            Role.Name = "Role";
            Role.Size = new Size(114, 30);
            Role.TabIndex = 23;
            Role.Text = "Role";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.LightGray;
            EmailTextBox.Font = new Font("Poppins", 10.2F);
            EmailTextBox.ForeColor = SystemColors.ActiveCaptionText;
            EmailTextBox.Location = new Point(20, 66);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(375, 33);
            EmailTextBox.TabIndex = 1;
            EmailTextBox.TextChanged += textBox1_TextChanged;
            EmailTextBox.Enter += EmailTextBox_Enter;
            EmailTextBox.Leave += EmailTextBox_Leave;
            // 
            // Email
            // 
            Email.BackColor = Color.Transparent;
            Email.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = SystemColors.ButtonHighlight;
            Email.Location = new Point(20, 39);
            Email.Name = "Email";
            Email.Size = new Size(114, 30);
            Email.TabIndex = 22;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.BackColor = Color.Transparent;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Poppins", 9F, FontStyle.Underline);
            BackToLogin.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin.Location = new Point(161, 352);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(111, 26);
            BackToLogin.TabIndex = 6;
            BackToLogin.Text = "Back to Login";
            BackToLogin.Click += BackToLogin_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.LightGray;
            UsernameTextBox.Font = new Font("Poppins", 10.2F);
            UsernameTextBox.ForeColor = SystemColors.ActiveCaptionText;
            UsernameTextBox.Location = new Point(20, 128);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(375, 33);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += textBox3_TextChanged;
            UsernameTextBox.Enter += UsernameTextBox_Enter;
            UsernameTextBox.Leave += UsernameTextBox_Leave;
            // 
            // Username
            // 
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Poppins", 7.8F);
            Username.ForeColor = SystemColors.ButtonHighlight;
            Username.Location = new Point(20, 104);
            Username.Name = "Username";
            Username.Size = new Size(150, 22);
            Username.TabIndex = 18;
            Username.Text = "Username";
            Username.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(90, 311);
            button1.Name = "button1";
            button1.Size = new Size(241, 37);
            button1.TabIndex = 5;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightGray;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Image = (Image)resources.GetObject("checkBox1.Image");
            checkBox1.ImageAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(243, 249);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(1);
            checkBox1.Size = new Size(152, 33);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show Password          ";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.LightGray;
            PasswordTextBox.Font = new Font("Poppins", 10.2F);
            PasswordTextBox.ForeColor = SystemColors.ActiveCaptionText;
            PasswordTextBox.Location = new Point(20, 189);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(375, 33);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += textBox2_TextChanged;
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // Password
            // 
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Poppins", 7.8F);
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(19, 166);
            Password.Name = "Password";
            Password.Size = new Size(123, 22);
            Password.TabIndex = 14;
            Password.Text = "Password";
            Password.Click += label7_Click;
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
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(835, 517);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Sign_Up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up Menu";
            Load += Sign_Up_Load;
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
        private GroupBox groupBox2;
        private Label BackToLogin;
        private TextBox UsernameTextBox;
        private Label Username;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox PasswordTextBox;
        private Label Password;
        private TextBox EmailTextBox;
        private Label Email;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ComboBox comboBox1;
        private Label Role;
    }
}